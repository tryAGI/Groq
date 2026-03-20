/*
order: 40
title: Text to Speech
slug: text-to-speech

Generate speech audio from text using the Groq TTS API.
*/

namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        //// Generate speech from text using PlayAI TTS.
        var audioBytes = await client.Audio.CreateSpeechAsync(
            model: CreateSpeechRequestModel.PlayaiTts,
            input: "Hello from Groq text to speech!",
            voice: "Arista-PlayAI",
            responseFormat: CreateSpeechRequestResponseFormat.Wav);

        Assert.IsNotNull(audioBytes);
        Assert.IsTrue(audioBytes.Length > 0);
    }
}
