# Groq

[![Nuget package](https://img.shields.io/nuget/vpre/Groq)](https://www.nuget.org/packages/Groq/)
[![dotnet](https://github.com/tryAGI/Groq/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Groq/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Groq)](https://github.com/tryAGI/Groq/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Groq OpenAPI specification](https://storage.googleapis.com/stainless-sdk-openapi-specs/groqcloud%2Fgroqcloud-1f0d266ba97b03672f10d33a6dc6e324af9a95646f978ffbff6a31f3907bbfe7.yml) using [AutoSDK](https://github.com/TryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support via `tryAGI.OpenAI` CustomProviders

### Usage
```csharp
using Groq;

using var client = new GroqClient(apiKey);
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
Console.WriteLine(response.Choices[0].Message.Content);
```

### Microsoft.Extensions.AI (MEAI) Support

Groq provides an OpenAI-compatible API. For `IChatClient` and `IEmbeddingGenerator` support via [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI.Abstractions), use the `tryAGI.OpenAI` package:
```
dotnet add package tryAGI.OpenAI
```
```csharp
using OpenAI;
using Microsoft.Extensions.AI;

using var client = CustomProviders.Groq(apiKey);

// IChatClient
IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync("Hello!");

// IEmbeddingGenerator
IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(["Hello, world!"]);
```

<!-- EXAMPLES:START -->
### Audio


```csharp
using var client = new GroqClient(apiKey);
var url = "https://speech.zone/simple4all/wp-content/uploads/2012/10/nina_01_071.wav";
string tempFilePath = await DownloadFileToTempAsync(url);

var request = new CreateTranscriptionRequest {
    Filename = "sample",
    File = System.IO.File.ReadAllBytes(tempFilePath),
    Model = CreateTranscriptionRequestModel.WhisperLargeV3,
    Language = "en",
};
var response = await client.Audio.CreateTranscriptionAsync(request);
Console.WriteLine(response);
```

### Chat


```csharp
using var client = new GroqClient(apiKey);
IList<ChatCompletionRequestMessage> messages = [
    new ChatCompletionRequestUserMessage {
        Role = ChatCompletionRequestUserMessageRole.User,
        Content = "Generate five random words."
    }];
CreateChatCompletionRequest request = new() {
    Messages = messages,
    Model = CreateChatCompletionRequestModel.Llama3370bVersatile
};
var response = await client.Chat.CreateChatCompletionAsync(request);
Console.WriteLine(response.Choices[0].Message.Content);
```

### Embeddings


```csharp
using var client = new GroqClient(apiKey);
CreateEmbeddingRequest request = new() {
    Input = "Hello, world",
    Model = CreateEmbeddingRequestModel.NomicEmbedTextV15
};
var response = await client.Embeddings.CreateEmbeddingAsync(request);
Console.WriteLine(response.Data[0].Embedding1);
```

### Text to Speech
Generate speech audio from text using the Groq TTS API.

```csharp
using var client = new GroqClient(apiKey);

// Generate speech from text using PlayAI TTS.
var audioBytes = await client.Audio.CreateSpeechAsync(
    model: CreateSpeechRequestModel.PlayaiTts,
    input: "Hello from Groq text to speech!",
    voice: "Arista-PlayAI",
    responseFormat: CreateSpeechRequestResponseFormat.Wav);
```

### Files
Upload and manage files for use with the Groq Batch API.

```csharp
using var client = new GroqClient(apiKey);

// List all uploaded files.
var response = await client.Files.ListFilesAsync();
```

### Batches
List and manage batch processing jobs.

```csharp
using var client = new GroqClient(apiKey);

// List all batch processing jobs.
var response = await client.Batch.ListBatchesAsync();
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Groq/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Groq/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
