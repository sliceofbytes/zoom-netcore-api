using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Additional phone base plans.
    /// </summary>
    public partial class PlanPhonePlanBase
    {
        /// <summary>
        /// Call-out countries: multiple values should separated by  commas. For a list of allowed
        /// values, refer to the "ID" field in
        /// [this](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#tsp-call-out-countries)
        /// table.
        /// </summary>
        [JsonProperty("callout_countries", NullValueHandling = NullValueHandling.Ignore)]
        public string CalloutCountries { get; set; }

        /// <summary>
        /// Additional phone base <a
        /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans#additional-zoom-phone-plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
