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
        /// <returns></returns>
        string ReadAllText();

        /// <summary>
        /// Read all text.
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string ReadAllText(Encoding encoding);

        /// <summary>
        /// Write all text.
        /// </summary>
        /// <param name="text"></param>
        void WriteAllText(string text);

        /// <summary>
        /// Write all text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="encoding"></param>
        void WriteAllText(string text, Encoding encoding);

        /// <summary>
        /// Open read.
        /// </summary>
        /// <returns></returns>
        FileStream OpenRead();

        /// <summary>
        /// Open.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        FileStream Open(FileMode mode);

        /// <summary>
        /// Open write.
        /// </summary>
        /// <returns></returns>
        FileStream OpenWrite();

        void MoveTo()
    }
}
