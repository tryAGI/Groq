
#nullable enable

namespace Groq
{
    /// <summary>
    /// An object specifying the format that the model must output. <br/>
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
    /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestResponseFormat
    {
        /// <summary>
        /// Must be one of `text` or `json_object`.<br/>
        /// Default Value: text<br/>
        /// Example: json_object
        /// </summary>
        /// <example>json_object</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.CreateChatCompletionRequestResponseFormatTypeJsonConverter))]
        public global::Groq.CreateChatCompletionRequestResponseFormatType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be one of `text` or `json_object`.<br/>
        /// Default Value: text<br/>
        /// Example: json_object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestResponseFormat(
            global::Groq.CreateChatCompletionRequestResponseFormatType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        public CreateChatCompletionRequestResponseFormat()
        {
        }
    }
}