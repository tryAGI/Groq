# Audio



This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);
var url = "https://speech.zone/simple4all/wp-content/uploads/2012/10/nina_01_071.wav";
string tempFilePath = await DownloadFileToTempAsync(url);

var request = new CreateTranscriptionRequest {
    Filename = "sample",
    File = File.ReadAllBytes(tempFilePath),
    Model = CreateTranscriptionRequestModel.WhisperLargeV3,
    Language = "en",
};
var response = await client.Audio.CreateTranscriptionAsync(request);
Console.WriteLine(response);
```