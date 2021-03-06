﻿using System;

namespace GetcuReone.Cdo.Folder
{
    /// <summary>
    /// Adapter for <see cref="IFolder"/>. Current folder.
    /// </summary>
    public sealed class CurrentFolderAdapter : FolderAdapterBase
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(CurrentFolderAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public CurrentFolderAdapter() : base(Environment.CurrentDirectory)
        {
        }
    }
}
