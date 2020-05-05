using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Account base plan object.
    /// </summary>
    public partial class PlanInfoPlanBase
    {
        /// <summary>
        /// Account base plan number of hosts. For a Pro Plan please select a value between 1 and 9.
        /// For a Business Plan please select a value between 10 and 49. For a Education Plan please
        /// select a value between 20 and 149. For a Free Trial Plan please select a value between 1
        /// and 9999.
        /// </summary>
        [JsonProperty("hosts")]
        public long Hosts { get; set; }

        /// <summary>
        /// Account base <a
        /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
