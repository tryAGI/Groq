
#nullable enable

namespace Groq
{
    /// <summary>
    /// A document whose contents are provided inline as JSON data.
    /// </summary>
    public sealed partial class ChatCompletionDocumentSourceJSON
    {
        /// <summary>
        /// Identifies this document source as JSON data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceJSONTypeJsonConverter))]
        public global::Groq.ChatCompletionDocumentSourceJSONType Type { get; set; }

        /// <summary>
        /// The JSON payload associated with the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceJSON" /> class.
        /// </summary>
        /// <param name="type">
        /// Identifies this document source as JSON data.
        /// </param>
        /// <param name="data">
        /// The JSON payload associated with the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionDocumentSourceJSON(
            object data,
            global::Groq.ChatCompletionDocumentSourceJSONType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceJSON" /> class.
        /// </summary>
        public ChatCompletionDocumentSourceJSON()
        {
        }
    }
}