#nullable enable

namespace Groq
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get model<br/>
        /// Get a specific model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.Model5> RetrieveModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}