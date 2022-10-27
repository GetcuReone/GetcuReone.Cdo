using System;
using System.IO;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Adapter for folder '{current_directory}/AppData'
    /// </summary>
    public sealed class AppDataFolderAdapter : FolderAdapterBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AppDataFolderAdapter() : base(Path.Combine(Environment.CurrentDirectory, "AppData")) { }
    }
}
