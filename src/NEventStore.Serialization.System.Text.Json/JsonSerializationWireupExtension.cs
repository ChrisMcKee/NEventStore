using System.Text.Json;

namespace NEventStore.Serialization.System.Text.Json
{
    public static class JsonSerializationWireupExtension
    {
        /// <summary>
        /// Specify we want to use Json serialization using System.Text.Json
        /// </summary>
        /// <param name="wireup"></param>
        /// <param name="jsonSerializerSettings">
        /// </param>
        public static SerializationWireup UsingJsonSerialization(
            this PersistenceWireup wireup,
            JsonSerializerOptions jsonSerializerSettings = null)
        {
            return wireup.UsingCustomSerialization(new MsftJsonSerializer());
        }
    }
}
