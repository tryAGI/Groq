using System.Reflection;

namespace Groq.IntegrationTests;

/// <summary>
/// The streaming method exists only because generate.sh declares `text/event-stream` on the chat
/// completion response: a `stream: true` flag in the request schema does not produce one, and the
/// upstream document declares only `application/json`. If a spec refresh drops that declaration,
/// `CreateChatCompletionAsStreamAsync` disappears and every streaming caller stops compiling — but
/// nothing would fail first, because every other test here needs an API key and reports
/// inconclusive without one.
///
/// So this asserts the shape, not the behaviour. It needs no key and no network.
/// </summary>
[TestClass]
public class StreamingContractTests
{
    [TestMethod]
    public void TheStreamingMethodIsGenerated()
    {
        // Overloads exist, so GetMethod by name alone throws AmbiguousMatchException.
        var method = typeof(global::Groq.IChatClient)
            .GetMethods()
            .FirstOrDefault(x => x.Name == "CreateChatCompletionAsStreamAsync");

        Assert.IsNotNull(
            method,
            "Groq.IChatClient.CreateChatCompletionAsStreamAsync is gone. It comes from the " +
            "text/event-stream declaration that generate.sh adds; if a spec refresh dropped it, " +
            "restore the declaration rather than the method.");

        var returns = method.ReturnType;
        Assert.IsTrue(
            returns.IsGenericType &&
            returns.GetGenericTypeDefinition() == typeof(IAsyncEnumerable<>),
            $"Expected an IAsyncEnumerable, got {returns} — a buffered return means the " +
            "streaming content type was lost and the call now reads the whole body.");
        Assert.AreEqual(
            typeof(global::Groq.CreateChatCompletionStreamResponse),
            returns.GetGenericArguments()[0],
            "The stream yields the wrong type; check which schema the text/event-stream " +
            "declaration points at.");
    }

    [TestMethod]
    public void AChunkDeserializesByItsWireNames()
    {
        var chunk = global::Groq.CreateChatCompletionStreamResponse.FromJson(
            // `choices` is required on this one, so an empty array is the smallest valid chunk;
            // omitting it makes the deserializer throw rather than leave the property null.
            """{"id":"chatcmpl-1","object":"chat.completion.chunk","created":1,"model":"fixture","choices":[]}""");

        Assert.IsNotNull(chunk);
        Assert.AreEqual("chatcmpl-1", chunk.Id);
        Assert.AreEqual("fixture", chunk.Model);
    }
}
