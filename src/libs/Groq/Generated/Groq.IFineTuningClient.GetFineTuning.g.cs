#nullable enable

namespace Groq
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Retrieves an existing fine tuning by id This endpoint is in closed beta. [Contact us](https://groq.com/contact) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.ReadFineTuningResponse> GetFineTuningAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}