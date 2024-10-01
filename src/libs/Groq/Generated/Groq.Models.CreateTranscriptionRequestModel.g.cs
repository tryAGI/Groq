
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        WhisperLargeV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestModel value)
        {
            return value switch
            {
                CreateTranscriptionRequestModel.WhisperLargeV3 => "whisper-large-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-large-v3" => CreateTranscriptionRequestModel.WhisperLargeV3,
                _ => null,
            };
        }
    }
}