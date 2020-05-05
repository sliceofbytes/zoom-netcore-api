using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    public partial class PlanNumber
    {
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hosts { get; set; }

        /// <summary>
        /// Additional phone number <a
        /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans#additional-zoom-phone-plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
