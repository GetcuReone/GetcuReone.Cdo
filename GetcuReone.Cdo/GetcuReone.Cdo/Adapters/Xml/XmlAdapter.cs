using GetcuReone.Cdi;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GetcuReone.Cdo.Adapters.Xml
{
    /// <summary>
    /// Adapter for xml.
    /// </summary>
    public sealed class XmlAdapter : GrAdapterBase
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(XmlAdapter);

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <paramref name="stream"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <typeparam name="TStream"></typeparam>
        /// <param name="serializeObj"></param>
        /// <param name="stream"></param>
        public void Serialize<TSerializeObj, TStream>(TSerializeObj serializeObj, TStream stream)
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
        public void Serialize<TSerializeObj>(TSerializeObj serializeObj, TextWriter writer)
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
        public string SerializeToString<TSerializeObj>(TSerializeObj serializeObj)
        {
            return SerializeToString(serializeObj, Encoding.UTF8);
        }

        /// <summary>
        /// Serialize <paramref name="serializeObj"/> in <see cref="string"/>.
        /// </summary>
        /// <typeparam name="TSerializeObj"></typeparam>
        /// <param name="serializeObj"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string SerializeToString<TSerializeObj>(TSerializeObj serializeObj, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream())
            {
                using(var streamWriter = new StreamWriter(memoryStream, encoding))
                {
                    Serialize(serializeObj, streamWriter);
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
        /// <typeparam name="TStream"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public TDeserializeObj Deserialize<TDeserializeObj, TStream>(TStream stream)
            where TStream : Stream
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
        public TDeserializeObj Deserialize<TDeserializeObj>(string xml, Encoding encoding)
        {
            using(var memoryStream = new MemoryStream())
            {
                using(var streamWriter = new StreamWriter(memoryStream))
                {
                    streamWriter.WriteLine(xml);
                    streamWriter.Flush();
                    memoryStream.Position = 0;

                    return Deserialize<TDeserializeObj, MemoryStream>(memoryStream);
                }
            }
        }

        /// <summary>
        /// Desirialize from string.
        /// </summary>
        /// <typeparam name="TDeserializeObj"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public TDeserializeObj Deserialize<TDeserializeObj>(string xml)
        {
            return Deserialize<TDeserializeObj>(xml, Encoding.UTF8);
        }
    }
}
