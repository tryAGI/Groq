namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        using var client = GetAuthenticatedClient();
        CreateEmbeddingRequest request = new() { 
            Input = "Hello, world",
            Model = CreateEmbeddingRequestModel.NomicEmbedTextV15
        };
        var response = await client.Embeddings.CreateEmbeddingAsync(request);
        Assert.IsNotNull(response);
        Console.WriteLine(response.Data[0].Embedding1);
    }
}
