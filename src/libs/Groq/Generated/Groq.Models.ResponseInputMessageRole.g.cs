
#nullable enable

namespace Groq
{
    /// <summary>
    /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
    /// </summary>
    public enum ResponseInputMessageRole
    {
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        User,
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        System,
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputMessageRole value)
        {
            return value switch
            {
                ResponseInputMessageRole.User => "user",
                ResponseInputMessageRole.System => "system",
                ResponseInputMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInputMessageRole.User,
                "system" => ResponseInputMessageRole.System,
                "developer" => ResponseInputMessageRole.Developer,
                _ => null,
            };
        }
    }
}