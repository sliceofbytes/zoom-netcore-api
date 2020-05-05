using System.Collections.Generic;
using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{


    /// <summary>
    /// Webinar panelist.
    /// </summary>
    public partial class ListPanelist
    {
        /// <summary>
        /// List of panelist objects.
        /// </summary>
        [JsonProperty("panelists", NullValueHandling = NullValueHandling.Ignore)]
        public List<Panelist> Panelists { get; set; }

        /// <summary>
        /// Total records.
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRecords { get; set; }
    }
}


