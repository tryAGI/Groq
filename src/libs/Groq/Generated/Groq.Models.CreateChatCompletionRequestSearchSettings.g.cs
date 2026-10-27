
#nullable enable

namespace Groq
{
    /// <summary>
    /// Settings for web search functionality when the model uses a web search tool.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestSearchSettings
    {
        /// <summary>
        /// Name of country to prioritize search results from (e.g., "united states", "germany", "france").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// A list of domains to exclude from the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// A list of domains to include in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Whether to include images in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestSearchSettings" /> class.
        /// </summary>
        /// <param name="country">
        /// Name of country to prioritize search results from (e.g., "united states", "germany", "france").
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from the search results.
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to include in the search results.
        /// </param>
        /// <param name="includeImages">
        /// Whether to include images in the search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestSearchSettings(
            string? country,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.Collections.Generic.IList<string>? includeDomains,
            bool? includeImages)
        {
            this.Country = country;
            this.ExcludeDomains = excludeDomains;
            this.IncludeDomains = includeDomains;
            this.IncludeImages = includeImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestSearchSettings" /> class.
        /// </summary>
        public CreateChatCompletionRequestSearchSettings()
        {
        }

    }
}