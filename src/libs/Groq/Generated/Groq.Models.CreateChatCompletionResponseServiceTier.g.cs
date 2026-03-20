
#nullable enable

namespace Groq
{
    /// <summary>
    /// The service tier used for the request.
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
                CreateChatCompletionResponseServiceTier.OnDemand => "on_demand",
                CreateChatCompletionResponseServiceTier.Flex => "flex",
                CreateChatCompletionResponseServiceTier.Performance => "performance",
                CreateChatCompletionResponseServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "on_demand" => CreateChatCompletionResponseServiceTier.OnDemand,
                "flex" => CreateChatCompletionResponseServiceTier.Flex,
                "performance" => CreateChatCompletionResponseServiceTier.Performance,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateChatCompletionResponseServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}