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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.DeleteModelResponse> DeleteModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}