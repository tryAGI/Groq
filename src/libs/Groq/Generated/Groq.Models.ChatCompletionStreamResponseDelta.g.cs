
#nullable enable

namespace Groq
{
    /// <summary>
    /// A chat completion delta generated by streamed model responses.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseDelta
    {
        /// <summary>
        /// The contents of the chunk message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Groq.ChatCompletionStreamResponseDeltaFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter))]
        public global::Groq.ChatCompletionStreamResponseDeltaRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCallChunk>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseDelta" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the chunk message.
        /// </param>
        /// <param name="role">
        /// The role of the author of this message.
        /// </param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamResponseDelta(
            string? content,
            global::Groq.ChatCompletionStreamResponseDeltaRole? role,
            global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCallChunk>? toolCalls)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseDelta" /> class.
        /// </summary>
        public ChatCompletionStreamResponseDelta()
        {
        }
    }
}