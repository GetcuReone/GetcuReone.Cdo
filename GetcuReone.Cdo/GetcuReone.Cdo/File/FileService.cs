using System.IO;
using System.Text;
using IoFile = System.IO.File;

namespace GetcuReone.Cdo.File
{
    /// <inheritdoc/>
    public class FileService : IFile
    {
        private readonly string _filePath;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath"></param>
        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        /// <inheritdoc/>
        public string ReadAllText()
        {
            return IoFile.ReadAllText(_filePath);
        }

        /// <inheritdoc/>
        public string ReadAllText(Encoding encoding)
        {
            return IoFile.ReadAllText(_filePath, encoding);
        }

        /// <inheritdoc/>
        public void WriteAllText(string text)
        {
            IoFile.WriteAllText(_filePath, text);
        }

        /// <inheritdoc/>
        public void WriteAllText(string text, Encoding encoding)
        {
            IoFile.WriteAllText(_filePath, text, encoding);
        }

        /// <inheritdoc/>
        public FileStream OpenRead()
        {
            return IoFile.OpenRead(_filePath);
        }

        /// <inheritdoc/>
        public FileStream Open(FileMode mode)
        {
            return IoFile.Open(_filePath, mode);
        }

        /// <inheritdoc/>
        public FileStream OpenWrite()
        {
            return IoFile.OpenWrite(_filePath);
        }
    }
}
