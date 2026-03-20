# Files

Upload and manage files for use with the Groq Batch API.

This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);

// List all uploaded files.
var response = await client.Files.ListFilesAsync();
```