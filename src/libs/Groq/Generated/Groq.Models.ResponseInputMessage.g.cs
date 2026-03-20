
#nullable enable

namespace Groq
{
    /// <summary>
    /// A message input to the model with explicit type field.
    /// </summary>
    public sealed partial class ResponseInputMessage
    {
        /// <summary>
        /// The type of the message input. Always set to `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseInputMessageTypeJsonConverter))]
        public global::Groq.ResponseInputMessageType Type { get; set; }

        /// <summary>
        /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.ResponseInputMessageRole Role { get; set; }

        /// <summary>
        /// A list of one or many input content items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Groq.ResponseInputContent> Content { get; set; }

        /// <summary>
        /// The status of item. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseInputMessageStatusJsonConverter))]
        public global::Groq.ResponseInputMessageStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the message input. Always set to `message`.
        /// </param>
        /// <param name="role">
        /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
        /// </param>
        /// <param name="content">
        /// A list of one or many input content items.
        /// </param>
        /// <param name="status">
        /// The status of item. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseInputMessage(
            global::Groq.ResponseInputMessageRole role,
            global::System.Collections.Generic.IList<global::Groq.ResponseInputContent> content,
            global::Groq.ResponseInputMessageType type,
            global::Groq.ResponseInputMessageStatus? status)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputMessage" /> class.
        /// </summary>
        public ResponseInputMessage()
        {
        }
    }
}