#nullable enable

namespace Groq
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete a file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.DeleteFileResponse> DeleteFileAsync(
            string fileId,
            global::Groq.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}