
#nullable enable

namespace Groq
{
    /// <summary>
    /// Chat-template parameters forwarded to Dynamo deployments unchanged.<br/>
    /// The serving runtime validates parameter names, values, and model support.<br/>
    /// Rejected for deployments that do not use Dynamo.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestChatTemplateArgs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}