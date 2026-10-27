
#nullable enable

namespace Groq
{
    /// <summary>
    /// HTTP headers to send with requests to the MCP server (optional for MCP tools).
    /// </summary>
    public sealed partial class ChatCompletionToolHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}