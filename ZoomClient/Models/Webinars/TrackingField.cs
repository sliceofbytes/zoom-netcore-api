using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{

    public partial class TrackingField
    {
        /// <summary>
        /// Tracking fields type
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Tracking fields value
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
