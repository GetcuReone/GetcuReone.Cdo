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
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(AppDataFolderAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public AppDataFolderAdapter() : base(Path.Combine(Environment.CurrentDirectory, "AppData"))
        {
        }
    }
}
