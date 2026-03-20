
#nullable enable

namespace Groq
{
    /// <summary>
    /// The status of item. Populated when items are returned via API.
    /// </summary>
    public enum ResponseInputMessageStatus
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
    public static class ResponseInputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputMessageStatus value)
        {
            return value switch
            {
                ResponseInputMessageStatus.InProgress => "in_progress",
                ResponseInputMessageStatus.Completed => "completed",
                ResponseInputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ResponseInputMessageStatus.InProgress,
                "completed" => ResponseInputMessageStatus.Completed,
                "incomplete" => ResponseInputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}