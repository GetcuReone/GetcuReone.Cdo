using System.IO;

namespace GetcuReone.Cdo.Folder
{
    /// <inheritdoc/>
    public sealed class FolderService : IFolder
    {
        private readonly DirectoryInfo _rootFolder;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="folderPath"></param>
        public FolderService(string folderPath)
        {
            _rootFolder = new DirectoryInfo(folderPath);
        }

        /// <inheritdoc/>
        public DirectoryInfo CreateFolder()
        {
            _rootFolder.Create();
            _rootFolder.Refresh();
            return _rootFolder;
        }

        /// <inheritdoc/>
        public void DeleteFile(string fileName)
        {
            System.IO.File.Delete(Path.Combine(_rootFolder.FullName, fileName));
        }

        /// <inheritdoc/>
        public FileInfo DownloadFile(string filePath)
        {
            FileInfo fileFrom = new FileInfo(filePath);
            FileInfo fileTo = new FileInfo(Path.Combine(_rootFolder.FullName, fileFrom.Name));

            if (!fileTo.Exists)
            {
                if (!fileTo.Directory.Exists)
                    fileTo.Directory.Create();
            }

            using (FileStream fileFromStream = fileFrom.OpenRead())
            {
                using (FileStream fileToStream = fileTo.Open(FileMode.OpenOrCreate))
                    fileFromStream.CopyTo(fileToStream);
            }

            fileTo.Refresh();
            return fileTo;
        }

        /// <inheritdoc/>
        public bool ExistsCurrentFolder()
        {
            _rootFolder.Refresh();
            return _rootFolder.Exists;
        }

        /// <inheritdoc/>
        public FileInfo GetFileInfo(string fileName)
        {
            return new FileInfo(Path.Combine(_rootFolder.FullName, fileName));
        }

        /// <inheritdoc/>
        public void MoveTo(string newFilePath, string oldName)
        {
            GetFileInfo(oldName).MoveTo(newFilePath);
        }

        /// <inheritdoc/>
        public FileInfo[] GetFiles()
        {
            return _rootFolder.GetFiles();
        }

        /// <inheritdoc/>
        public FileInfo[] GetFiles(string searchPattern)
        {
            return _rootFolder.GetFiles(searchPattern);
        }

        /// <inheritdoc/>
        public string GetPath()
        {
            return _rootFolder.FullName;
        }
    }
}
