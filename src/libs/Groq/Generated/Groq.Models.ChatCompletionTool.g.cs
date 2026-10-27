
#nullable enable

namespace Groq
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionTool
    {
        /// <summary>
        /// A list of tool names to allow from the MCP server. If specified, only these tools will be exposed to the model. If empty or not specified, all discovered tools will be available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Groq.FunctionObject? Function { get; set; }

        /// <summary>
        /// HTTP headers to send with requests to the MCP server (optional for MCP tools).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// A human-readable label for the MCP server (optional for MCP tools).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// The URL of the MCP server to connect to (required for MCP tools).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.AnyOfJsonConverter<global::Groq.ChatCompletionToolType?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.AnyOf<global::Groq.ChatCompletionToolType?, string> Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="allowedTools">
        /// A list of tool names to allow from the MCP server. If specified, only these tools will be exposed to the model. If empty or not specified, all discovered tools will be available.
        /// </param>
        /// <param name="function"></param>
        /// <param name="headers">
        /// HTTP headers to send with requests to the MCP server (optional for MCP tools).
        /// </param>
        /// <param name="serverLabel">
        /// A human-readable label for the MCP server (optional for MCP tools).
        /// </param>
        /// <param name="serverUrl">
        /// The URL of the MCP server to connect to (required for MCP tools).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTool(
            global::Groq.AnyOf<global::Groq.ChatCompletionToolType?, string> type,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::Groq.FunctionObject? function,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? serverLabel,
            string? serverUrl)
        {
            this.AllowedTools = allowedTools;
            this.Function = function;
            this.Headers = headers;
            this.ServerLabel = serverLabel;
            this.ServerUrl = serverUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        public ChatCompletionTool()
        {
        }

    }
}