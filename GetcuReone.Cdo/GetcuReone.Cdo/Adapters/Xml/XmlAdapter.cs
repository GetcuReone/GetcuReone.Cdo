using GetcuReone.Cdi;
using System.IO;
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
    }
}
