using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Microsoft.Extensions.Logging;
using NEventStore.Logging;

namespace NEventStore.Serialization.System.Text.Json
{
    public class MsftJsonSerializer : ISerialize
    {
        private static readonly ILogger Logger = LogFactory.BuildLogger(typeof(MsftJsonSerializer));

        /// <summary>
        /// NEventStore Json Serialization using System.Text.Json
        /// </summary>
        /// <param name="jsonSerializerOptions">Allows configuring some Json serialization options,
        /// some of them will be overwritten given the values passed to <paramref name="knownTypes"/> parameter</param>
        /// <param name="knownTypes">
        /// Every Type specified here will be serialized with special handling, particularly for known types.
        /// Every other type will be serialized with the default options.
        /// </param>
        public MsftJsonSerializer()
        {

        }

        public virtual void Serialize<T>(Stream output, T graph)
        {
            Logger.LogTrace(Messages.SerializingGraph, typeof(T));
            // JsonSerializer.Serialize(output, graph, GetSerializerOptions(graph.GetType()));
            JsonSerializer.Serialize(output, graph);
            //JsonSerializer.SerializeToUtf8Bytes(graph);
        }

        public virtual T Deserialize<T>(Stream input)
        {
            Logger.LogTrace(Messages.DeserializingStream, typeof(T));
            // return JsonSerializer.Deserialize<T>(input, GetSerializerOptions(typeof(T)));
            return JsonSerializer.Deserialize<T>(input);
            //JsonSerializer.Deserialize<T>(new ReadOnlySpan<byte>(resultBytes));
        }
    }
}