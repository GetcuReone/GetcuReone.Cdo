using System.IO;
using System.Text;

namespace GetcuReone.Cdo.File
{
    /// <summary>
    /// For work with <see cref="File"/>
    /// </summary>
    public interface IFile
    {
        /// <summary>
        /// Read all text.
        /// </summary>
        /// <returns>File text.</returns>
        string ReadAllText();

        /// <summary>
        /// Read all text.
        /// </summary>
        /// <param name="encoding">File encoding.</param>
        /// <returns>File text.</returns>
        string ReadAllText(Encoding encoding);

        /// <summary>
        /// Write all text.
        /// </summary>
        /// <param name="text"></param>
        void WriteAllText(string text);

        /// <summary>
        /// Write all text.
        /// </summary>
        /// <param name="text">File text.</param>
        /// <param name="encoding">File encoding.</param>
        void WriteAllText(string text, Encoding encoding);

        /// <summary>
        /// Open read.
        /// </summary>
        /// <returns>File stream</returns>
        FileStream OpenRead();

        /// <summary>
        /// Open.
        /// </summary>
        /// <param name="mode">Opening mode.</param>
        /// <returns>File stream.</returns>
        FileStream Open(FileMode mode);

        /// <summary>
        /// Open write.
        /// </summary>
        /// <returns>File stream in write mode.</returns>
        FileStream OpenWrite();
    }
}
