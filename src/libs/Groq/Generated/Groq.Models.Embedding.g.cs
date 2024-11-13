
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// Represents an embedding vector returned by embedding endpoint.
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string> Embedding1 { get; set; }

        /// <summary>
        /// The index of the embedding in the list of embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.EmbeddingObjectJsonConverter))]
        public global::Groq.EmbeddingObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="embedding1"></param>
        /// <param name="index">
        /// The index of the embedding in the list of embeddings.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Embedding(
            global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string> embedding1,
            int index,
            global::Groq.EmbeddingObject @object)
        {
            this.Embedding1 = embedding1;
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        public Embedding()
        {
        }
    }
}