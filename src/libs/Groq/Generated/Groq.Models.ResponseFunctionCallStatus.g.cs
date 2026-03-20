
#nullable enable

namespace Groq
{
    /// <summary>
    /// The status of the item.
    /// </summary>
    public enum ResponseFunctionCallStatus
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
    public static class ResponseFunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallStatus value)
        {
            return value switch
            {
                ResponseFunctionCallStatus.InProgress => "in_progress",
                ResponseFunctionCallStatus.Completed => "completed",
                ResponseFunctionCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ResponseFunctionCallStatus.InProgress,
                "completed" => ResponseFunctionCallStatus.Completed,
                "incomplete" => ResponseFunctionCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}