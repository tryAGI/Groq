
#nullable enable

namespace Groq
{
    /// <summary>
    /// Custom key-value pairs for storing additional information. Maximum of 16 pairs.
    /// </summary>
    public sealed partial class CreateResponseRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}