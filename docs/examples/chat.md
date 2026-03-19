# Chat



This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);
IList<ChatCompletionRequestMessage> messages = [
    new ChatCompletionRequestUserMessage {
        Role = ChatCompletionRequestUserMessageRole.User,
        Content = "Generate five random words."
    }];
CreateChatCompletionRequest request = new() {
    Messages = messages,
    Model = CreateChatCompletionRequestModel.Llama370b8192
};
var response = await client.Chat.CreateChatCompletionAsync(request);
Console.WriteLine(response.Choices[0].Message.Content);
```