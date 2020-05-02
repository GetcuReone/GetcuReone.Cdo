using GetcuReone.Cdi;
using GetcuReone.Services.Folder;

namespace GetcuReone.Cdo.Adapters.Folder
{
    /// <summary>
    /// Base clas for folder adapter
    /// </summary>
    public abstract class FolderAdapterBase : GrAdapterProxyBase<IFolder, string>
    {
        private readonly string _folderPath;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected FolderAdapterBase(string folderPath)
            :base(path => new FolderService(path))
        {
            _folderPath = folderPath;
        }

        /// <summary>
        /// Download file in folder. 
        /// </summary>
        /// <param name="filePath"></param>
        public virtual void DownloadFile(string filePath)
        {
            CallMethodLogging(parameter: filePath);
            CreateProxy(_folderPath).DownloadFile(filePath);
            ReturnLogging();
        }

        /// <summary>
        /// Get file path.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public virtual string GetFullName(string fileName)
        {
            CallMethodLogging(parameter: fileName);

            string result = CreateProxy(_folderPath).GetFileInfo(fileName).FullName;

            return ReturnLogging(returnedObj: result);
        }

        /// <summary>
        /// Contain file.
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public virtual bool ContainFile(string fileName)
        {
            CallMethodLogging(parameter: fileName);

            bool result = CreateProxy(_folderPath).GetFileInfo(fileName).Exists;

            return ReturnLogging(result);
        }

        /// <summary>
        /// Rename file.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="oldName"></param>
        public virtual void RenameFile(string newName, string oldName)
        {
            CallMethodLogging(new { newName, oldName });
            CreateProxy(_folderPath).MoveTo(newName, oldName);
            ReturnLogging();
        }

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="fileName"></param>
        public virtual void DeleteFile(string fileName)
        {
            CallMethodLogging(parameter: fileName);
            CreateProxy(_folderPath).DeleteFile(fileName);
            ReturnLogging();
        }

        /// <summary>
        /// Is the current folder contained in the file system.
        /// </summary>
        /// <returns></returns>
        public virtual bool ExistsCurrentFolder()
        {
            CallMethodLogging();

            return ReturnLogging(
                CreateProxy(_folderPath).ExistsCurrentFolder());
        }

        /// <summary>
        /// Create current folder.
        /// </summary>
        public virtual void CreateCurrentFolder()
        {
            CallMethodLogging();

            CreateProxy(_folderPath).CreateFolder();

            ReturnLogging();
        }
    }
}
