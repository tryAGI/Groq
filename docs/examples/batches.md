# Batches

List and manage batch processing jobs.

This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);

// List all batch processing jobs.
var response = await client.Batch.ListBatchesAsync();
```