namespace GetcuReone.Cdo.Process
{
    /// <summary>
    /// Service for process.
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Start process.
        /// </summary>
        /// <param name="processName">Process name.</param>
        /// <param name="args">Process arguments.</param>
        /// <returns>Process.</returns>
        System.Diagnostics.Process Start(string processName, string args);
    }
}
