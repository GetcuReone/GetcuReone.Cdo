using GetcuReone.Cdi;
using GetcuReone.Services.Process;

namespace GetcuReone.Cdo.Adapters.Process
{
    /// <summary>
    /// Adapter for <see cref="IProcess"/>.
    /// </summary>
    public sealed class ProcessAdapter : GrAdapterProxyBase<IProcess>
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(ProcessAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public ProcessAdapter() : base(() => new ProcessService())
        {
        }

        /// <summary>
        /// Start process.
        /// </summary>
        /// <param name="process"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public System.Diagnostics.Process Start(string process, string args)
        {
            CallMethodLogging(new { process, args });

            return ReturnNotLogging(
                CreateProxy().Start(process, args));
        }
    }
}
