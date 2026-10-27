
#nullable enable

namespace Groq
{
    /// <summary>
    /// The service tier used for the request. Deployments running in strict OpenAI compatibility report Groq-specific tiers as `default`.
    /// </summary>
    public enum CreateChatCompletionResponseServiceTier
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
    public static class CreateChatCompletionResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionResponseServiceTier.Auto => "auto",
                CreateChatCompletionResponseServiceTier.Default => "default",
                CreateChatCompletionResponseServiceTier.Flex => "flex",
                CreateChatCompletionResponseServiceTier.OnDemand => "on_demand",
                CreateChatCompletionResponseServiceTier.Performance => "performance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionResponseServiceTier.Auto,
                "default" => CreateChatCompletionResponseServiceTier.Default,
                "flex" => CreateChatCompletionResponseServiceTier.Flex,
                "on_demand" => CreateChatCompletionResponseServiceTier.OnDemand,
                "performance" => CreateChatCompletionResponseServiceTier.Performance,
                _ => null,
            };
        }
    }
}