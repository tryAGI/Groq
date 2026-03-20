#nullable enable

namespace Groq
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Lists all previously created fine tunings. This endpoint is in closed beta. [Contact us](https://groq.com/contact) for more information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.ListFineTuningsResponse> ListFineTuningsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}