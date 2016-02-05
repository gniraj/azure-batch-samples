using Microsoft.Azure.BatchExplorer.Helpers;

namespace Microsoft.Azure.BatchExplorer.ViewModels
{
    /// <summary>
    /// Operation that can be performed for a job property
    /// </summary>
    public interface IJobPropertiesExtension
    {
        /// <summary>
        /// Return CommandBase which will be used by BatchExplorer UI
        /// </summary>
        /// <returns>CommandBase</returns>
        CommandBase GetCommandBase();
    }
}
