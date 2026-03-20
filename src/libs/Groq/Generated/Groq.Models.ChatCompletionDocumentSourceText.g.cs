
#nullable enable

namespace Groq
{
    /// <summary>
    /// A document whose contents are provided inline as text.
    /// </summary>
    public sealed partial class ChatCompletionDocumentSourceText
    {
        /// <summary>
        /// Identifies this document source as inline text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceTextTypeJsonConverter))]
        public global::Groq.ChatCompletionDocumentSourceTextType Type { get; set; }

        /// <summary>
        /// The document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceText" /> class.
        /// </summary>
        /// <param name="type">
        /// Identifies this document source as inline text.
        /// </param>
        /// <param name="text">
        /// The document contents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionDocumentSourceText(
            string text,
            global::Groq.ChatCompletionDocumentSourceTextType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceText" /> class.
        /// </summary>
        public ChatCompletionDocumentSourceText()
        {
        }
    }
}