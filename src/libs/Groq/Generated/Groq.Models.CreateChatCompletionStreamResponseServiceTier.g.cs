
#nullable enable

namespace Groq
{
    /// <summary>
    /// The service tier used for the request. Deployments running in strict OpenAI compatibility report Groq-specific tiers as `default`.
    /// </summary>
    public enum CreateChatCompletionStreamResponseServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        OnDemand,
        /// <summary>
        ///
        /// </summary>
        Performance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseServiceTier.Auto => "auto",
                CreateChatCompletionStreamResponseServiceTier.Default => "default",
                CreateChatCompletionStreamResponseServiceTier.Flex => "flex",
                CreateChatCompletionStreamResponseServiceTier.OnDemand => "on_demand",
                CreateChatCompletionStreamResponseServiceTier.Performance => "performance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionStreamResponseServiceTier.Auto,
                "default" => CreateChatCompletionStreamResponseServiceTier.Default,
                "flex" => CreateChatCompletionStreamResponseServiceTier.Flex,
                "on_demand" => CreateChatCompletionStreamResponseServiceTier.OnDemand,
                "performance" => CreateChatCompletionStreamResponseServiceTier.Performance,
                _ => null,
            };
        }
    }
}