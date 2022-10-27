using System.IO;
using System.Text;
using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.File
{
    /// <summary>
    /// adapter for <see cref="IFile"/>.
    /// </summary>
    public sealed class FileAdapter : AdapterProxyBase<IFile, string>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FileAdapter(): base(filePath => new FileService(filePath)) { }

        /// <inheritdoc cref="IFile.WriteAllText(string)"/>
        /// <param name="filePath">File path.</param>
        /// <param name="text">File text.</param>
        public void WriteAllText(string filePath, string text)
        {
            CreateProxy(filePath).WriteAllText(text);
        }

        /// <inheritdoc cref="IFile.WriteAllText(string, Encoding)"/>
        /// <param name="filePath">File path.</param>
        /// <param name="text">File text.</param>
        /// <param name="encoding">File encoding.</param>
        public void WriteAllText(string filePath, string text, Encoding encoding)
        {
            CreateProxy(filePath).WriteAllText(text, encoding);
        }

        /// <inheritdoc cref="IFile.ReadAllText()"/>
        /// <param name="filePath">File path.</param>
        public string ReadAllText(string filePath)
        {
            return CreateProxy(filePath).ReadAllText();
        }

        /// <inheritdoc cref="IFile.ReadAllText(Encoding)"/>
        /// <param name="filePath">File path.</param>
        /// <param name="encoding">File encoding.</param>
        public string ReadAllText(string filePath, Encoding encoding)
        {
            return CreateProxy(filePath).ReadAllText(encoding);
        }

        /// <inheritdoc cref="IFile.OpenRead"/>
        /// <param name="filePath">File path.</param>
        public FileStream OpenRead(string filePath)
        {
            return CreateProxy(filePath).OpenRead();
        }

        /// <inheritdoc cref="IFile.Open(FileMode)"/>
        /// <param name="filePath">File path.</param>
        /// <param name="mode">Opening mode.</param>
        public FileStream Open(string filePath, FileMode mode)
        {
            return CreateProxy(filePath).Open(mode);
        }

        /// <inheritdoc cref="IFile.OpenWrite"/>
        /// <param name="filePath">File path.</param>
        public FileStream OpenWrite(string filePath)
        {
            return CreateProxy(filePath).OpenWrite();
        }
    }
}
