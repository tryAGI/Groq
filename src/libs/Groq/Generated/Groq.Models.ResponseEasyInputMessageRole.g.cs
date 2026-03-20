
#nullable enable

namespace Groq
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
    /// </summary>
    public enum ResponseEasyInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEasyInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEasyInputMessageRole value)
        {
            return value switch
            {
                ResponseEasyInputMessageRole.User => "user",
                ResponseEasyInputMessageRole.Assistant => "assistant",
                ResponseEasyInputMessageRole.System => "system",
                ResponseEasyInputMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEasyInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseEasyInputMessageRole.User,
                "assistant" => ResponseEasyInputMessageRole.Assistant,
                "system" => ResponseEasyInputMessageRole.System,
                "developer" => ResponseEasyInputMessageRole.Developer,
                _ => null,
            };
        }
    }
}