
#nullable enable

namespace Groq
{
    /// <summary>
    /// This is not yet supported by any of our models.<br/>
    /// Modify the likelihood of specified tokens appearing in the completion.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestLogitBias
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestLogitBias" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionRequestLogitBias(
 )
        {
        }
    }
}