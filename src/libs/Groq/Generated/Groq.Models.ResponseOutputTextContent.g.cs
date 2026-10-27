
#nullable enable

namespace Groq
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class ResponseOutputTextContent
    {
        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Groq.ResponseAnnotation> Annotations { get; set; }

        /// <summary>
        /// Log probability information for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<string>? Logprobs { get; set; }

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseOutputTextContentTypeJsonConverter))]
        public global::Groq.ResponseOutputTextContentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextContent" /> class.
        /// </summary>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="logprobs">
        /// Log probability information for the output.
        /// </param>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputTextContent(
            global::System.Collections.Generic.IList<global::Groq.ResponseAnnotation> annotations,
            string text,
            global::System.Collections.Generic.IList<string>? logprobs,
            global::Groq.ResponseOutputTextContentType type)
        {
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Logprobs = logprobs;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextContent" /> class.
        /// </summary>
        public ResponseOutputTextContent()
        {
        }

    }
}