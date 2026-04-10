#nullable enable

namespace Groq
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete model<br/>
        /// Delete a model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.DeleteModelResponse> DeleteModelAsync(
            string model,
            global::Groq.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}