namespace Groq.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GroqClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GROQ_API_KEY") ??
            throw new AssertInconclusiveException("GROQ_API_KEY environment variable is not found.");

        var client = new GroqClient(apiKey);
        
        return client;
    }
}
