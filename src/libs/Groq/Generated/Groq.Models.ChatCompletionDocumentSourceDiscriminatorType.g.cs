
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionDocumentSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionDocumentSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDocumentSourceDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionDocumentSourceDiscriminatorType.Text => "text",
                ChatCompletionDocumentSourceDiscriminatorType.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDocumentSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionDocumentSourceDiscriminatorType.Text,
                "json" => ChatCompletionDocumentSourceDiscriminatorType.Json,
                _ => null,
            };
        }
    }
}