
#nullable enable

namespace Groq
{
    /// <summary>
    /// The service tier to use for the request. Defaults to `on_demand`.<br/>
    /// - `auto` will automatically select the highest tier available within the rate limits of your organization.<br/>
    /// - `flex` uses the flex tier, which will succeed or fail quickly.
    /// </summary>
    public enum CreateChatCompletionRequestServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class CreateChatCompletionRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionRequestServiceTier.Auto => "auto",
                CreateChatCompletionRequestServiceTier.Flex => "flex",
                CreateChatCompletionRequestServiceTier.OnDemand => "on_demand",
                CreateChatCompletionRequestServiceTier.Performance => "performance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionRequestServiceTier.Auto,
                "flex" => CreateChatCompletionRequestServiceTier.Flex,
                "on_demand" => CreateChatCompletionRequestServiceTier.OnDemand,
                "performance" => CreateChatCompletionRequestServiceTier.Performance,
                _ => null,
            };
        }
    }
}