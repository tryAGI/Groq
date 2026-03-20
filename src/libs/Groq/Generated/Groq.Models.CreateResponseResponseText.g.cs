
#nullable enable

namespace Groq
{
    /// <summary>
    /// Text format configuration used for the response.
    /// </summary>
    public sealed partial class CreateResponseResponseText
    {
        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ResponseFormatConfigurationJsonConverter))]
        public global::Groq.ResponseFormatConfiguration? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseText" /> class.
        /// </summary>
        /// <param name="format">
        /// An object specifying the format that the model must output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseResponseText(
            global::Groq.ResponseFormatConfiguration? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseText" /> class.
        /// </summary>
        public CreateResponseResponseText()
        {
        }
    }
}