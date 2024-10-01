
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImageImageUrl
    {
        /// <summary>
        /// Specifies the detail level of the image.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter))]
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Detail { get; set; } = global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto;

        /// <summary>
        /// Either a URL of the image or the base64 encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}