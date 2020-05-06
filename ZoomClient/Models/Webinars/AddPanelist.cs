using System.Collections.Generic;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    /// <summary>
    /// Webinar panelist.
    /// </summary>
    public partial class AddPanelists
    {
        /// <summary>
        /// List of panelist objects.
        /// </summary>
        public List<Panelist> Panelists { get; set; }
    }

}
