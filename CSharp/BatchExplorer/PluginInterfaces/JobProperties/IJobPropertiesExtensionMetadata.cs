using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.BatchExplorer.Helpers;

namespace Microsoft.Azure.BatchExplorer.ViewModels
{
    /// <summary>
    /// Metadata associated with a Job Property
    /// </summary>
    public interface IJobPropertiesExtensionMetadata
    {
        /// <summary>
        /// This Name will appear in right click menu of Job when clicked in BatchExplorer.
        /// </summary>
        string Name { get; }
    }
}
