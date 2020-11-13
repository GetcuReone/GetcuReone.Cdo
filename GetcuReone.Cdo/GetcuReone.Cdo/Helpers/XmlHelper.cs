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
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <typeparam name="TStream"></typeparam>
        /// <param name="serializeObj"></param>
        /// <param name="stream"></param>
        public static void SerializeToStream<TSerializeObj, TStream>(this TSerializeObj serializeObj, TStream stream)
            where TStream : Stream
        {
            var formatter = new XmlSerializer(typeof(TSerializeObj));
            formatter.Serialize(stream, serializeObj);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <paramref name="writer"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <param name="serializeObj"></param>
        /// <param name="writer"></param>
        public static void SerializeToTextWriter<TSerializeObj>(this TSerializeObj serializeObj, TextWriter writer)
        {
            var formatter = new XmlSerializer(typeof(TSerializeObj));
            formatter.Serialize(writer, serializeObj);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <see cref="string"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <param name="serializeObj"></param>
        /// <returns></returns>
        public static string Serialize<TSerializeObj>(this TSerializeObj serializeObj)
        {
            return Serialize(serializeObj, Encoding.UTF8);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <see cref="string"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <param name="serializeObj"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
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
        /// <typeparam name="TDeserializeObj"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static TDeserializeObj DeserializeFromXml<TDeserializeObj>(this Stream stream)
        {
            var formatter = new XmlSerializer(typeof(TDeserializeObj));
            return (TDeserializeObj)formatter.Deserialize(stream);
        }

        /// <summary>
        /// Desirialize from string.
        /// </summary>
        /// <typeparam name="TDeserializeObj"></typeparam>
        /// <param name="xml"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
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
