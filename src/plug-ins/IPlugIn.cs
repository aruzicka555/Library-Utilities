// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

namespace Landis.Utilities.PlugIns
{
    /// <summary>
    /// Common interface to all types of plug-ins.
    /// </summary>
    public interface IPlugIn
    {
        /// <summary>
        /// The name that users refer to the plug-in by.
        /// </summary>
        string Name
        {
            get;
        }
    }
}
