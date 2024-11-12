#nullable enable

namespace Groq
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Groq.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.CreateTranscriptionResponseJson> CreateTranscriptionAsync(
            global::Groq.CreateTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. Only `whisper-large-v3` is currently available.<br/>
        /// Example: whisper-large-v3
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should match the audio language.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Groq.CreateTranscriptionResponseJson> CreateTranscriptionAsync(
            byte[] file,
            string filename,
            global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?> model,
            global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>? language = default,
            string? prompt = default,
            global::Groq.CreateTranscriptionRequestResponseFormat? responseFormat = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::Groq.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}