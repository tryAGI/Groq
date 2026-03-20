#nullable enable

namespace Groq
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancels a batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.Batch> CancelBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}