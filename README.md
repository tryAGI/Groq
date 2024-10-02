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

## Support

Priority place for bugs: https://github.com/tryAGI/Groq/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Groq/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).