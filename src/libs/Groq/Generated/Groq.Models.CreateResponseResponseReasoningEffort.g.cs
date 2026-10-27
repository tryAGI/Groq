
#nullable enable

namespace Groq
{
    /// <summary>
    /// The reasoning effort level used. When omitted from the request, this is `none`<br/>
    /// for Qwen3.8 and `medium` for GPT-OSS models.
    /// </summary>
    public enum CreateResponseResponseReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
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
        None,
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
                CreateResponseResponseReasoningEffort.High => "high",
                CreateResponseResponseReasoningEffort.Low => "low",
                CreateResponseResponseReasoningEffort.Medium => "medium",
                CreateResponseResponseReasoningEffort.None => "none",
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
                "high" => CreateResponseResponseReasoningEffort.High,
                "low" => CreateResponseResponseReasoningEffort.Low,
                "medium" => CreateResponseResponseReasoningEffort.Medium,
                "none" => CreateResponseResponseReasoningEffort.None,
                _ => null,
            };
        }
    }
}