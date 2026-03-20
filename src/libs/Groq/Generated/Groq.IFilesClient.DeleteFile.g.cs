#nullable enable

namespace Groq
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete a file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.DeleteFileResponse> DeleteFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}