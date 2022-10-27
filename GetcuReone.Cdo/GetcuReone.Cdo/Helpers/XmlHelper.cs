using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GetcuReone.Cdo.Helpers
{
    /// <summary>
    /// Helper for xml operation.
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <paramref name="stream"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj">The type of the object being serialized.</typeparam>
        /// <typeparam name="TStream">Stream type.</typeparam>
        /// <param name="serializeObj">Serializable object.</param>
        /// <param name="stream">Stream.</param>
        public static void SerializeToStream<TSerializeObj, TStream>(this TSerializeObj serializeObj, TStream stream)
            where TStream : Stream
        {
            var formatter = new XmlSerializer(typeof(TSerializeObj));
            formatter.Serialize(stream, serializeObj);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <paramref name="writer"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj">The type of the object being serialized.</typeparam>
        /// <param name="serializeObj">Serializable object.</param>
        /// <param name="writer">Write stream.</param>
        public static void SerializeToTextWriter<TSerializeObj>(this TSerializeObj serializeObj, TextWriter writer)
        {
            var formatter = new XmlSerializer(typeof(TSerializeObj));
            formatter.Serialize(writer, serializeObj);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <see cref="string"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj">The type of the object being serialized.</typeparam>
        /// <param name="serializeObj">Serializable object.</param>
        /// <returns>Xml text.</returns>
        public static string Serialize<TSerializeObj>(this TSerializeObj serializeObj)
        {
            return Serialize(serializeObj, Encoding.UTF8);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <see cref="string"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj">The type of the object being serialized.</typeparam>
        /// <param name="serializeObj">Serializable object.</param>
        /// <param name="encoding">Encoding.</param>
        /// <returns>Xml text.</returns>
        public static string Serialize<TSerializeObj>(TSerializeObj serializeObj, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream, encoding))
                {
                    serializeObj.SerializeToTextWriter(streamWriter);
                    memoryStream.Position = 0;

                    using (var streamReader = new StreamReader(memoryStream, encoding))
                        return streamReader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Deserialize obj <typeparamref name="TDeserializeObj"/> type from <paramref name="stream"/>.
        /// </summary>
        /// <typeparam name="TDeserializeObj">The type of the object being deserialized.</typeparam>
        /// <param name="stream">Stream.</param>
        /// <returns>Deserializable object.</returns>
        public static TDeserializeObj DeserializeFromXml<TDeserializeObj>(this Stream stream)
        {
            var formatter = new XmlSerializer(typeof(TDeserializeObj));
            return (TDeserializeObj)formatter.Deserialize(stream);
        }

        /// <summary>
        /// Desirialize from string.
        /// </summary>
        /// <typeparam name="TDeserializeObj">The type of the object being deserialized.</typeparam>
        /// <param name="xml">Xml string.</param>
        /// <param name="encoding">Encoding.</param>
        /// <returns>Deserializable object.</returns>
        public static TDeserializeObj DeserializeFromXml<TDeserializeObj>(string xml, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    streamWriter.WriteLine(xml);
                    streamWriter.Flush();
                    memoryStream.Position = 0;

                    return memoryStream.DeserializeFromXml<TDeserializeObj>();
                }
            }
        }
    }
}
