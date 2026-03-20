/*
order: 50
title: Files
slug: files

Upload and manage files for use with the Groq Batch API.
*/

namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListFiles()
    {
        using var client = GetAuthenticatedClient();

        //// List all uploaded files.
        var response = await client.Files.ListFilesAsync();

        Assert.IsNotNull(response);
    }
}
