using System;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Adapter for <see cref="IFolder"/>. Current folder.
    /// </summary>
    public class CurrentFolderAdapter : BaseFolderAdapter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CurrentFolderAdapter() : base(Environment.CurrentDirectory) { }
    }
}
