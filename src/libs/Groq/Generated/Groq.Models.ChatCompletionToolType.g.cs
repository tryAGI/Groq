
#nullable enable

namespace Groq
{
    /// <summary>
    /// The type of the tool. `function`, `browser_search`, and `code_interpreter` are supported.
    /// </summary>
    public enum ChatCompletionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        BrowserSearch,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolType value)
        {
            return value switch
            {
                ChatCompletionToolType.Function => "function",
                ChatCompletionToolType.BrowserSearch => "browser_search",
                ChatCompletionToolType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionToolType.Function,
                "browser_search" => ChatCompletionToolType.BrowserSearch,
                "code_interpreter" => ChatCompletionToolType.CodeInterpreter,
                _ => null,
            };
        }
    }
}