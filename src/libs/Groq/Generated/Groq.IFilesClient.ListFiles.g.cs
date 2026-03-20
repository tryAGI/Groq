#nullable enable

namespace Groq
{
    public partial interface IFilesClient
    {

        /// <summary>
        /// Returns a list of files.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.ListFilesResponse> ListFilesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}