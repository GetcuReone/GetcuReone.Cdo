using System.IO;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// A service for working with folders in the file system.
    /// </summary>
    public interface IFolder
    {
        /// <summary>
        /// Return file info.
        /// </summary>
        /// <param name="fileName">Relative file name.</param>
        /// <returns>File info.</returns>
        FileInfo GetFileInfo(string fileName);

        /// <summary>
        /// Create current folder.
        /// </summary>
        /// <returns>Folder info.</returns>
        DirectoryInfo CreateFolder();

        /// <summary>
        /// Is the current folder contained in the file system.
        /// </summary>
        /// <returns>True - folder exists.</returns>
        bool ExistsCurrentFolder();

        /// <summary>
        /// Move file.
        /// </summary>
        /// <param name="newFilePath">New file path.</param>
        /// <param name="oldName">Old file name.</param>
        void MoveTo(string newFilePath, string oldName);

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="fileName">имя файла</param>
        void DeleteFile(string fileName);

        /// <summary>
        /// Download file in folder.
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns>File info.</returns>
        FileInfo DownloadFile(string filePath);

        /// <summary>
        /// Get files.
        /// </summary>
        /// <returns>Files.</returns>
        FileInfo[] GetFiles();

        /// <summary>
        /// Get files.
        /// </summary>
        /// <param name="searchPattern">Search pattern.</param>
        /// <returns>Files.</returns>
        FileInfo[] GetFiles(string searchPattern);

        /// <summary>
        /// Get path current folder.
        /// </summary>
        /// <returns>Current folder path.</returns>
        string GetPath();
    }
}
