
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
        OnDemand,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Performance,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
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
                CreateChatCompletionRequestServiceTier.OnDemand => "on_demand",
                CreateChatCompletionRequestServiceTier.Flex => "flex",
                CreateChatCompletionRequestServiceTier.Performance => "performance",
                CreateChatCompletionRequestServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "on_demand" => CreateChatCompletionRequestServiceTier.OnDemand,
                "flex" => CreateChatCompletionRequestServiceTier.Flex,
                "performance" => CreateChatCompletionRequestServiceTier.Performance,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateChatCompletionRequestServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}