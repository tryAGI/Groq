
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XGroq
    {
        /// <summary>
        /// An error string indicating why a stream was stopped early
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// A groq request ID which can be used by to refer to a specific request to groq support <br/>
        /// Only sent with the first chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Groq.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroq" /> class.
        /// </summary>
        /// <param name="error">
        /// An error string indicating why a stream was stopped early
        /// </param>
        /// <param name="id">
        /// A groq request ID which can be used by to refer to a specific request to groq support <br/>
        /// Only sent with the first chunk
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public XGroq(
            string? error,
            string? id,
            global::Groq.CompletionUsage? usage)
        {
            this.Error = error;
            this.Id = id;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroq" /> class.
        /// </summary>
        public XGroq()
        {
        }
    }
}