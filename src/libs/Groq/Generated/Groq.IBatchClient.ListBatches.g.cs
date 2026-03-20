#nullable enable

namespace Groq
{
    public partial interface IBatchClient
    {

        /// <summary>
        /// List your organization's batches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.ListBatchesResponse> ListBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}