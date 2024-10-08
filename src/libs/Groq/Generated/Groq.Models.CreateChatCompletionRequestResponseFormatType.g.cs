
#nullable enable

namespace Groq
{
    /// <summary>
    /// Must be one of `text` or `json_object`.<br/>
    /// Default Value: text<br/>
    /// Example: json_object
    /// </summary>
    public enum CreateChatCompletionRequestResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestResponseFormatType value)
        {
            return value switch
            {
                CreateChatCompletionRequestResponseFormatType.Text => "text",
                CreateChatCompletionRequestResponseFormatType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateChatCompletionRequestResponseFormatType.Text,
                "json_object" => CreateChatCompletionRequestResponseFormatType.JsonObject,
                _ => null,
            };
        }
    }
}