# Embeddings



This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);
CreateEmbeddingRequest request = new() {
    Input = "Hello, world",
    Model = CreateEmbeddingRequestModel.NomicEmbedTextV15
};
var response = await client.Embeddings.CreateEmbeddingAsync(request);
Console.WriteLine(response.Data[0].Embedding1);
```