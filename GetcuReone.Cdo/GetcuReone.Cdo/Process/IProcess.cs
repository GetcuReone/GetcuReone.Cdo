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
        /// <param name="processName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        System.Diagnostics.Process Start(string processName, string args);
    }
}
