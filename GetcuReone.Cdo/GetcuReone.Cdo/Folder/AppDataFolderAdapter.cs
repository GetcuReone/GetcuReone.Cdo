using System;
using System.IO;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Adapter for folder '{current_directory}/AppData'
    /// </summary>
    public class AppDataFolderAdapter : BaseFolderAdapter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AppDataFolderAdapter() : base(Path.Combine(Environment.CurrentDirectory, "AppData")) { }
    }
}
