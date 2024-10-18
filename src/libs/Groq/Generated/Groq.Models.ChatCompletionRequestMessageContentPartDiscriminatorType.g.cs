
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartDiscriminatorType.Text => "text",
                ChatCompletionRequestMessageContentPartDiscriminatorType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestMessageContentPartDiscriminatorType.Text,
                "image_url" => ChatCompletionRequestMessageContentPartDiscriminatorType.ImageUrl,
                _ => null,
            };
        }
    }
}