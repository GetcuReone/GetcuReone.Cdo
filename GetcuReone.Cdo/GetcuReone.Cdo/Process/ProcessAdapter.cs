using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.Process
{
    /// <summary>
    /// Adapter for <see cref="IProcess"/>.
    /// </summary>
    public sealed class ProcessAdapter : AdapterProxyBase<IProcess>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ProcessAdapter() : base(() => new ProcessService()) { }

        /// <inheritdoc cref="IProcess.Start(string, string)"/>
        public System.Diagnostics.Process Start(string process, string args)
        {
            return CreateProxy().Start(process, args);
        }
    }
}
