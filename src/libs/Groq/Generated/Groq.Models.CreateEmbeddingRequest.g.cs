
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingRequest
    {
        /// <summary>
        /// The format to return the embeddings in. Can only be `float` or `base64`.<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter))]
        public global::Groq.CreateEmbeddingRequestEncodingFormat? EncodingFormat { get; set; } = global::Groq.CreateEmbeddingRequestEncodingFormat.Float;

        /// <summary>
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model, cannot be an empty string, and any array must be 2048 dimensions or less.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// ID of the model to use.<br/>
        /// Example: nomic-embed-text-v1_5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?> Model { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}