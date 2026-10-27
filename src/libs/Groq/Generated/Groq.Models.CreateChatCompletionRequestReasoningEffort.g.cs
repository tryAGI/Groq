
#nullable enable

namespace Groq
{
    /// <summary>
    /// qwen3 models support `none` to disable reasoning and `default` or null<br/>
    /// to use the model default.<br/>
    /// qwen/qwen3.8-27b additionally supports `low`, `medium`, and `high`.<br/>
    /// Its default is `none`; `high` selects the model's native `xhigh` mode.<br/>
    /// openai/gpt-oss-20b and openai/gpt-oss-120b support 'low', 'medium', or 'high'.<br/>
    /// 'medium' is the default value.<br/>
    /// Values outside a model's supported set are rejected with a 400.
    /// </summary>
    public enum CreateChatCompletionRequestReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        Default,
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
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                CreateChatCompletionRequestReasoningEffort.Default => "default",
                CreateChatCompletionRequestReasoningEffort.High => "high",
                CreateChatCompletionRequestReasoningEffort.Low => "low",
                CreateChatCompletionRequestReasoningEffort.Max => "max",
                CreateChatCompletionRequestReasoningEffort.Medium => "medium",
                CreateChatCompletionRequestReasoningEffort.Minimal => "minimal",
                CreateChatCompletionRequestReasoningEffort.None => "none",
                CreateChatCompletionRequestReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateChatCompletionRequestReasoningEffort.Default,
                "high" => CreateChatCompletionRequestReasoningEffort.High,
                "low" => CreateChatCompletionRequestReasoningEffort.Low,
                "max" => CreateChatCompletionRequestReasoningEffort.Max,
                "medium" => CreateChatCompletionRequestReasoningEffort.Medium,
                "minimal" => CreateChatCompletionRequestReasoningEffort.Minimal,
                "none" => CreateChatCompletionRequestReasoningEffort.None,
                "xhigh" => CreateChatCompletionRequestReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}