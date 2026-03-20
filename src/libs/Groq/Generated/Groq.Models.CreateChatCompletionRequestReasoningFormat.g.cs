
#nullable enable

namespace Groq
{
    /// <summary>
    /// Specifies how to output reasoning tokens<br/>
    /// This field is mutually exclusive with `include_reasoning`.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum CreateChatCompletionRequestReasoningFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Parsed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestReasoningFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestReasoningFormat value)
        {
            return value switch
            {
                CreateChatCompletionRequestReasoningFormat.Hidden => "hidden",
                CreateChatCompletionRequestReasoningFormat.Raw => "raw",
                CreateChatCompletionRequestReasoningFormat.Parsed => "parsed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestReasoningFormat? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => CreateChatCompletionRequestReasoningFormat.Hidden,
                "raw" => CreateChatCompletionRequestReasoningFormat.Raw,
                "parsed" => CreateChatCompletionRequestReasoningFormat.Parsed,
                _ => null,
            };
        }
    }
}