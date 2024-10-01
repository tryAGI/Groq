namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();
        IList<ChatCompletionRequestMessage> messages = [ 
            new ChatCompletionRequestUserMessage {
                Role = ChatCompletionRequestUserMessageRole.User,
                Content = "Generate a random name"
            }];
        CreateChatCompletionRequest request = new() { 
            Messages = messages, 
            Model = CreateChatCompletionRequestModel.Llama370b8192 
        };
        var response = await client.Chat.CreateChatCompletionAsync(request);
        Assert.IsNotNull(response);
        Console.WriteLine(response.Choices[0].Message.Content);
    }
}
