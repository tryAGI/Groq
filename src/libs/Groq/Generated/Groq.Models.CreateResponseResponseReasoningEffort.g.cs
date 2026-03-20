
#nullable enable

namespace Groq
{
    /// <summary>
    /// The reasoning effort level used.
    /// </summary>
    public enum CreateResponseResponseReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseResponseReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseReasoningEffort value)
        {
            return value switch
            {
                CreateResponseResponseReasoningEffort.Low => "low",
                CreateResponseResponseReasoningEffort.Medium => "medium",
                CreateResponseResponseReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => CreateResponseResponseReasoningEffort.Low,
                "medium" => CreateResponseResponseReasoningEffort.Medium,
                "high" => CreateResponseResponseReasoningEffort.High,
                _ => null,
            };
        }
    }
}