using System.Collections.Generic;
using System.Linq;
using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Base clas for folder adapter
    /// </summary>
    public abstract class BaseFolderAdapter : AdapterProxyBase<IFolder, string>
    {
        private readonly string _folderPath;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected BaseFolderAdapter(string folderPath) : base(path => new FolderService(path))
        {
            _folderPath = folderPath;
        }

        /// <inheritdoc cref="IFolder.DeleteFile(string)"/>
        public virtual string DownloadFile(string filePath)
        {
            return CreateProxy(_folderPath).DownloadFile(filePath).FullName;
        }

        /// <summary>
        /// Get file path.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <returns>File path.</returns>
        public virtual string GetFullName(string fileName)
        {
            return CreateProxy(_folderPath).GetFileInfo(fileName).FullName;
        }

        /// <summary>
        /// Contain file.
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns>True - file contain</returns>
        public virtual bool ContainFile(string fileName)
        {
            return CreateProxy(_folderPath).GetFileInfo(fileName).Exists;
        }

        /// <summary>
        /// Rename file.
        /// </summary>
        /// <param name="newName">New name file.</param>
        /// <param name="oldName">Old name file.</param>
        public virtual void RenameFile(string newName, string oldName)
        {
            CreateProxy(_folderPath).MoveTo(newName, oldName);
        }

        /// <inheritdoc cref="IFolder.DeleteFile(string)"/>
        public virtual void DeleteFile(string fileName)
        {
            CreateProxy(_folderPath).DeleteFile(fileName);
        }

        /// <inheritdoc cref="IFolder.ExistsCurrentFolder"/>
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
        /// <returns>File paths.</returns>
        public virtual List<string> GetFiles()
        {
            return CreateProxy(_folderPath).GetFiles().Select(file => file.FullName).ToList();
        }

        /// <inheritdoc cref="IFolder.GetFiles(string)"/>
        public virtual List<string> GetFiles(string searchPattern)
        {
            return CreateProxy(_folderPath).GetFiles(searchPattern).Select(file => file.FullName).ToList();
        }

        /// <inheritdoc cref="IFolder.GetPath"/>
        public virtual string GetPath()
        {
            return CreateProxy(_folderPath).GetPath();
        }
    }
}
