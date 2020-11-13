using GetcuReone.Cdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetcuReone.Cdo.Folder
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
            : base(path => new FolderService(path))
        {
            _folderPath = folderPath;
        }

        /// <summary>
        /// Download file in folder. 
        /// </summary>
        /// <param name="filePath"></param>
        public virtual void DownloadFile(string filePath)
        {
            CreateProxy(_folderPath).DownloadFile(filePath);
        }

        /// <summary>
        /// Get file path.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public virtual string GetFullName(string fileName)
        {

            return CreateProxy(_folderPath).GetFileInfo(fileName).FullName;
        }

        /// <summary>
        /// Contain file.
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public virtual bool ContainFile(string fileName)
        {
            return CreateProxy(_folderPath).GetFileInfo(fileName).Exists;
        }

        /// <summary>
        /// Rename file.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="oldName"></param>
        public virtual void RenameFile(string newName, string oldName)
        {
            CreateProxy(_folderPath).MoveTo(newName, oldName);
        }

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="fileName"></param>
        public virtual void DeleteFile(string fileName)
        {
            CreateProxy(_folderPath).DeleteFile(fileName);
        }

        /// <summary>
        /// Is the current folder contained in the file system.
        /// </summary>
        /// <returns></returns>
        public virtual bool ExistsCurrentFolder()
        {
            return CreateProxy(_folderPath).ExistsCurrentFolder();
        }

        /// <summary>
        /// Create current folder.
        /// </summary>
        public virtual void CreateCurrentFolder()
        {
            CreateProxy(_folderPath).CreateFolder();
        }

        /// <summary>
        /// Get files.
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetFiles()
        {
            return CreateProxy(_folderPath).GetFiles().Select(file => file.FullName).ToList();
        }

        /// <summary>
        /// Get files.
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetFiles(string searchPattern)
        {
            return CreateProxy(_folderPath).GetFiles(searchPattern).Select(file => file.FullName).ToList();
        }
    }
}
