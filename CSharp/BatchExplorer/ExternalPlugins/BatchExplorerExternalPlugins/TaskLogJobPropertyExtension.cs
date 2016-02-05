using System.ComponentModel.Composition;
using Microsoft.Azure.BatchExplorer.Helpers;
using Microsoft.Azure.BatchExplorer.ViewModels;

namespace Microsoft.Azure.BatchExplorer.Plugins.JobPropertyPlugin
{
    [Export(typeof(IJobPropertiesExtension))]
    [ExportMetadata("Name", "TaskLog")]
    public class TaskLogJobPropertyExtension : IJobPropertiesExtension
    {
        public CommandBase GetCommandBase()
        {
            return new CommandBase(null);
        }
    }
}