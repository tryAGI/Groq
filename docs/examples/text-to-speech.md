# Text to Speech

Generate speech audio from text using the Groq TTS API.

This example assumes `using Groq;` is in scope and `apiKey` contains your Groq API key.

```csharp
using var client = new GroqClient(apiKey);

// Generate speech from text using PlayAI TTS.
var audioBytes = await client.Audio.CreateSpeechAsync(
    model: CreateSpeechRequestModel.PlayaiTts,
    input: "Hello from Groq text to speech!",
    voice: "Arista-PlayAI",
    responseFormat: CreateSpeechRequestResponseFormat.Wav);
```