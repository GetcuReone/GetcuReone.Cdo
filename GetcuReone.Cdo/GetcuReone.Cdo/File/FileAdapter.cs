using GetcuReone.Cdi;
using System.IO;
using System.Text;

namespace GetcuReone.Cdo.File
{
    /// <summary>
    /// adapter for <see cref="IFile"/>.
    /// </summary>
    public sealed class FileAdapter : GrAdapterProxyBase<IFile, string>
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(FileAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public FileAdapter(): base(filePath => new FileService(filePath))
        {
        }

        /// <summary>
        /// Write text in file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="text"></param>
        public void WriteAllText(string filePath, string text)
        {
            CreateProxy(filePath).WriteAllText(text);
        }

        /// <summary>
        /// Write text in file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="text"></param>
        /// <param name="encoding"></param>
        public void WriteAllText(string filePath, string text, Encoding encoding)
        {
            CreateProxy(filePath).WriteAllText(text, encoding);
        }

        /// <summary>
        /// Read text from file.
        /// </summary>
        /// <param name="filePath"></param>
        public string ReadAllText(string filePath)
        {
            return CreateProxy(filePath).ReadAllText();
        }

        /// <summary>
        /// Read text from file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        public string ReadAllText(string filePath, Encoding encoding)
        {
            return CreateProxy(filePath).ReadAllText(encoding);
        }

        /// <summary>
        /// Open read.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public FileStream OpenRead(string filePath)
        {
            return CreateProxy(filePath).OpenRead();
        }

        /// <summary>
        /// Open.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public FileStream Open(string filePath, FileMode mode)
        {
            return CreateProxy(filePath).Open(mode);
        }

        /// <summary>
        /// Open write.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public FileStream OpenWrite(string filePath)
        {
            return CreateProxy(filePath).OpenWrite();
        }
    }
}
