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
        /// <returns></returns>
        FileInfo GetFileInfo(string fileName);

        /// <summary>
        /// Create current folder.
        /// </summary>
        DirectoryInfo CreateFolder();

        /// <summary>
        /// Is the current folder contained in the file system.
        /// </summary>
        /// <returns></returns>
        bool ExistsCurrentFolder();

        /// <summary>
        /// Move file.
        /// </summary>
        /// <param name="newFilePath"></param>
        /// <param name="oldName"></param>
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
        /// <returns></returns>
        FileInfo DownloadFile(string filePath);

        /// <summary>
        /// Get files.
        /// </summary>
        /// <returns></returns>
        FileInfo[] GetFiles();

        /// <summary>
        /// Get files.
        /// </summary>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        FileInfo[] GetFiles(string searchPattern);
    }
}
