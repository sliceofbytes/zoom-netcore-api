using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Additional audio conferencing <a
    /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans#audio-conferencing-plans">plan
    /// type.</a>
    /// </summary>
    public partial class PlanAudio
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
        /// Dedicated dial-In numbers.
        /// </summary>
        [JsonProperty("ddi_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public long? DdiNumbers { get; set; }

        /// <summary>
        /// Premium countries: multiple values should be separated by commas. For a list of allowed
        /// values, refer to the "ID" field in the [Premium
        /// Countries](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#premium-countries)
        /// table.
        /// </summary>
        [JsonProperty("premium_countries", NullValueHandling = NullValueHandling.Ignore)]
        public string PremiumCountries { get; set; }

        /// <summary>
        /// Toll-free countries: multiple values should separated by a comma. For a list of allowed
        /// values, refer to the "ID" field in the [Toll Free
        /// Countries](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#toll-free-countries)
        /// table.
        /// </summary>
        [JsonProperty("tollfree_countries", NullValueHandling = NullValueHandling.Ignore)]
        public string TollfreeCountries { get; set; }

        /// <summary>
        /// Additional audio conferencing <a href="/api-reference/other-references/plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
