namespace Groq.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GroqClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GROQ_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GROQ_API_KEY environment variable is not found.");

        var client = new GroqClient(apiKey);
        
        return client;
    }

    private static async Task<string> DownloadFileToTempAsync(string url)
    {
        string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + Path.GetExtension(url));
        using (HttpClient client = new())
        {
            byte[] fileBytes = await client.GetByteArrayAsync(url);
            await System.IO.File.WriteAllBytesAsync(tempFilePath, fileBytes);
        }
        return tempFilePath;
    }
}
