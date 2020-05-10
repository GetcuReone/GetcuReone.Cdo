using GetcuReone.Cdi;
using GetcuReone.Services.File;
using System.IO;
using System.Text;

namespace GetcuReone.Cdo.Adapters.File
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
        public FileAdapter() : base(filePath => new FileService(filePath))
        {
        }

        /// <summary>
        /// Write text in file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="text"></param>
        public void WriteAllText(string filePath, string text)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
                text = text,
            });

            CreateProxy(filePath).WriteAllText(text);

            ReturnLogging();
        }

        /// <summary>
        /// Write text in file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="text"></param>
        /// <param name="encoding"></param>
        public void WriteAllText(string filePath, string text, Encoding encoding)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
                text = text,
                encoding = encoding,
            });

            CreateProxy(filePath).WriteAllText(text, encoding);

            ReturnLogging();
        }

        /// <summary>
        /// Read text from file.
        /// </summary>
        /// <param name="filePath"></param>
        public string ReadAllText(string filePath)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
            });

            return ReturnLogging(
                returnedObj: CreateProxy(filePath).ReadAllText());
        }

        /// <summary>
        /// Read text from file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        public string ReadAllText(string filePath, Encoding encoding)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
                encoding = encoding,
            });

            return ReturnLogging(
                returnedObj: CreateProxy(filePath).ReadAllText(encoding));
        }

        /// <summary>
        /// Open read.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public FileStream OpenRead(string filePath)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
            });

            return ReturnNotLogging(
                CreateProxy(filePath).OpenRead());
        }

        /// <summary>
        /// Open.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public FileStream Open(string filePath, FileMode mode)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
                mode = mode,
            });

            return ReturnNotLogging(
                CreateProxy(filePath).Open(mode));
        }

        /// <summary>
        /// Open write.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public FileStream OpenWrite(string filePath)
        {
            CallMethodLogging(new
            {
                filePath = filePath,
            });

            return ReturnNotLogging(
                CreateProxy(filePath).OpenWrite());
        }
    }
}
