using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AndcultureCode.ZoomClient.Models.Webinars
{


    /// <summary>
    /// List of webinars.
    /// </summary>
    public partial class ListWebinars
    {
        /// <summary>
        /// The number of pages returned for the request made.
        /// </summary>
        [JsonProperty("page_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageCount { get; set; }

        /// <summary>
        /// The page number of the current results.
        /// </summary>
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of records returned with a single API call.
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The total number of all the records available across pages.
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRecords { get; set; }

        /// <summary>
        /// List of webinar objects.
        /// </summary>
        [JsonProperty("webinars", NullValueHandling = NullValueHandling.Ignore)]
        public List<Webinar> Webinars { get; set; }
    }
}
