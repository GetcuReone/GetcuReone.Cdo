namespace GetcuReone.Cdo.Process
{
    /// <summary>
    /// Service for process.
    /// </summary>
    public class ProcessService : IProcess
    {
        /// <inheritdoc/>
        public System.Diagnostics.Process Start(string processName, string args)
        {
            return System.Diagnostics.Process.Start(processName, args);
        }
    }
}
