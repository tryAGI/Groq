
#nullable enable

namespace Groq
{
    /// <summary>
    /// Specifies the detail level of the image.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartImageImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartImageImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartImageImageUrlDetail value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto => "auto",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low => "low",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartImageImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto,
                "low" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low,
                "high" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.High,
                _ => null,
            };
        }
    }
}