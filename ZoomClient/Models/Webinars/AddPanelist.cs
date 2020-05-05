using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        [JsonProperty("panelists", NullValueHandling = NullValueHandling.Ignore)]
        public List<Panelist> Panelists { get; set; }
    }

}
