
#nullable enable

namespace Groq
{
    /// <summary>
    /// The status of the function call.
    /// </summary>
    public enum ResponseOutputFunctionCallStatus
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
    public static class ResponseOutputFunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputFunctionCallStatus value)
        {
            return value switch
            {
                ResponseOutputFunctionCallStatus.InProgress => "in_progress",
                ResponseOutputFunctionCallStatus.Completed => "completed",
                ResponseOutputFunctionCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputFunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ResponseOutputFunctionCallStatus.InProgress,
                "completed" => ResponseOutputFunctionCallStatus.Completed,
                "incomplete" => ResponseOutputFunctionCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}