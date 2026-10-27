
#nullable enable

namespace Groq
{
    /// <summary>
    /// Level of reasoning effort. Supported values: `none`, `low`, `medium`, `high`.<br/>
    /// `none` disables reasoning and is supported only by Qwen3.8 models. Lower graded<br/>
    /// values provide faster responses with less reasoning depth. When omitted, the<br/>
    /// default is `none` for Qwen3.8 and `medium` for GPT-OSS models.
    /// </summary>
    public enum CreateResponseRequestReasoningEffort
    {
        /// <summary>
        /// `none`, `low`, `medium`, `high`.
        /// </summary>
        High,
        /// <summary>
        /// `none`, `low`, `medium`, `high`.
        /// </summary>
        Low,
        /// <summary>
        /// `none`, `low`, `medium`, `high`.
        /// </summary>
        Medium,
        /// <summary>
        /// `none`, `low`, `medium`, `high`.
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestReasoningEffort value)
        {
            return value switch
            {
                CreateResponseRequestReasoningEffort.High => "high",
                CreateResponseRequestReasoningEffort.Low => "low",
                CreateResponseRequestReasoningEffort.Medium => "medium",
                CreateResponseRequestReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateResponseRequestReasoningEffort.High,
                "low" => CreateResponseRequestReasoningEffort.Low,
                "medium" => CreateResponseRequestReasoningEffort.Medium,
                "none" => CreateResponseRequestReasoningEffort.None,
                _ => null,
            };
        }
    }
}