using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Account plan object.
    /// </summary>
    public partial class PlanWebinar
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
