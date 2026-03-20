/*
order: 60
title: Batches
slug: batches

List and manage batch processing jobs.
*/

namespace Groq.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListBatches()
    {
        using var client = GetAuthenticatedClient();

        //// List all batch processing jobs.
        var response = await client.Batch.ListBatchesAsync();

        Assert.IsNotNull(response);
    }
}
