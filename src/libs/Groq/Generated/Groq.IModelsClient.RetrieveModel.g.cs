#nullable enable

namespace Groq
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get detailed information about a [model](https://console.groq.com/docs/models).<br/>
        /// Get a specific model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.Model6> RetrieveModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}