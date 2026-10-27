
#nullable enable

namespace Groq
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionRequestSystemMessage
    {
        /// <summary>
        /// The contents of the system message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>> Content { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `system`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.ChatCompletionRequestSystemMessageRole Role { get; set; }

        /// <summary>
        /// DO NOT USE.  This field is present because OpenAI allows it and users send it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the system message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `system`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        /// <param name="toolCallId">
        /// DO NOT USE.  This field is present because OpenAI allows it and users send it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestSystemMessage(
            global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>> content,
            global::Groq.ChatCompletionRequestSystemMessageRole role,
            string? name,
            string? toolCallId)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestSystemMessage" /> class.
        /// </summary>
        public ChatCompletionRequestSystemMessage()
        {
        }

    }
}