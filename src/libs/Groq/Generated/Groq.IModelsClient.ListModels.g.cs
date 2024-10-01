#nullable enable

namespace Groq
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models<br/>
        /// get all available models
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.ListModelsResponse> ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}