
#nullable enable

namespace Groq
{
    /// <summary>
    /// Whether to enable citations in the response. When enabled, the model will include citations for information retrieved from provided documents or web searches.<br/>
    /// Default Value: enabled
    /// </summary>
    public enum CreateChatCompletionRequestCitationOptions
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestCitationOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestCitationOptions value)
        {
            return value switch
            {
                CreateChatCompletionRequestCitationOptions.Enabled => "enabled",
                CreateChatCompletionRequestCitationOptions.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestCitationOptions? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CreateChatCompletionRequestCitationOptions.Enabled,
                "disabled" => CreateChatCompletionRequestCitationOptions.Disabled,
                _ => null,
            };
        }
    }
}