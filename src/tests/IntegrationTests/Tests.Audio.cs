namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateTranscriptionAudio()
    {
        using var client = GetAuthenticatedClient();
        var url = "https://speech.zone/simple4all/wp-content/uploads/2012/10/nina_01_071.wav";
        string tempFilePath = await DownloadFileToTempAsync(url);

        var request = new CreateTranscriptionRequest { 
            Filename = "sample", 
            File = File.ReadAllBytes(tempFilePath),
            Model = CreateTranscriptionRequestModel.WhisperLargeV3,
            Language = "en",    
        };
        var response = await client.Audio.CreateTranscriptionAsync(request);
        Assert.IsNotNull(response);
        Console.WriteLine(response);
    }
}
