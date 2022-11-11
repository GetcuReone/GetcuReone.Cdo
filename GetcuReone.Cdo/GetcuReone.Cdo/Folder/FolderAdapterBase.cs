using System;

namespace GetcuReone.Cdo.Folder
{
    /// <inheritdoc />
    [Obsolete("[2.0.2]")]
    public abstract class FolderAdapterBase : BaseFolderAdapter
    {
        /// <inheritdoc />
        protected FolderAdapterBase(string folderPath) : base(folderPath) { }
    }
}
