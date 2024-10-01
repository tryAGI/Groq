
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranslationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        WhisperLargeV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranslationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationRequestModel value)
        {
            return value switch
            {
                CreateTranslationRequestModel.WhisperLargeV3 => "whisper-large-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-large-v3" => CreateTranslationRequestModel.WhisperLargeV3,
                _ => null,
            };
        }
    }
}