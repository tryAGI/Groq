
#nullable enable

namespace Groq
{
    /// <summary>
    /// Specification of the Groq cloud API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IGroqClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

    }
}