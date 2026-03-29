
#nullable enable

namespace Groq
{
    /// <summary>
    /// An output message from the model.
    /// </summary>
    public sealed partial class ResponseOutputMessage
    {
        /// <summary>
        /// The type of the output message. Always `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseOutputMessageTypeJsonConverter))]
        public global::Groq.ResponseOutputMessageType Type { get; set; }

        /// <summary>
        /// The unique ID of the output message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseOutputMessageStatusJsonConverter))]
        public global::Groq.ResponseOutputMessageStatus? Status { get; set; }

        /// <summary>
        /// The role of the output message. Always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseOutputMessageRoleJsonConverter))]
        public global::Groq.ResponseOutputMessageRole Role { get; set; }

        /// <summary>
        /// The content of the output message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Groq.ResponseOutputContent> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the output message.
        /// </param>
        /// <param name="content">
        /// The content of the output message.
        /// </param>
        /// <param name="type">
        /// The type of the output message. Always `message`.
        /// </param>
        /// <param name="status">
        /// The status of the message.
        /// </param>
        /// <param name="role">
        /// The role of the output message. Always `assistant`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputMessage(
            string id,
            global::System.Collections.Generic.IList<global::Groq.ResponseOutputContent> content,
            global::Groq.ResponseOutputMessageType type,
            global::Groq.ResponseOutputMessageStatus? status,
            global::Groq.ResponseOutputMessageRole role)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        public ResponseOutputMessage()
        {
        }
    }
}