using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace AndcultureCode.ZoomClient.Models.Billing
{

    public partial class PlanZoomRooms
    {
        /// <summary>
        /// Account plan number of hosts.
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hosts { get; set; }

        /// <summary>
        /// Account <a
        /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
