using System;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Adapter for <see cref="IFolder"/>. Current folder.
    /// </summary>
    public sealed class CurrentFolderAdapter : FolderAdapterBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CurrentFolderAdapter() : base(Environment.CurrentDirectory) { }
    }
}
