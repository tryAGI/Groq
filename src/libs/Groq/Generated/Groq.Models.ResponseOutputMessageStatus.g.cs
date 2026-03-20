
#nullable enable

namespace Groq
{
    /// <summary>
    /// The status of the message.
    /// </summary>
    public enum ResponseOutputMessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputMessageStatus value)
        {
            return value switch
            {
                ResponseOutputMessageStatus.InProgress => "in_progress",
                ResponseOutputMessageStatus.Completed => "completed",
                ResponseOutputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ResponseOutputMessageStatus.InProgress,
                "completed" => ResponseOutputMessageStatus.Completed,
                "incomplete" => ResponseOutputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}