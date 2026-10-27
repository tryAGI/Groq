
#nullable enable

namespace Groq
{
    /// <summary>
    /// Custom template configuration for message formatting.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestCustomTemplate
    {
        /// <summary>
        /// Whether to preserve the order of system messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_system_message_order")]
        public bool? PreserveSystemMessageOrder { get; set; }

        /// <summary>
        /// Whether to allow relaxed message ordering in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relaxed_message_ordering")]
        public bool? RelaxedMessageOrdering { get; set; }

        /// <summary>
        /// The custom template string to use for formatting messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCustomTemplate" /> class.
        /// </summary>
        /// <param name="template">
        /// The custom template string to use for formatting messages.
        /// </param>
        /// <param name="preserveSystemMessageOrder">
        /// Whether to preserve the order of system messages.
        /// </param>
        /// <param name="relaxedMessageOrdering">
        /// Whether to allow relaxed message ordering in the conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestCustomTemplate(
            string template,
            bool? preserveSystemMessageOrder,
            bool? relaxedMessageOrdering)
        {
            this.PreserveSystemMessageOrder = preserveSystemMessageOrder;
            this.RelaxedMessageOrdering = relaxedMessageOrdering;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCustomTemplate" /> class.
        /// </summary>
        public CreateChatCompletionRequestCustomTemplate()
        {
        }

    }
}