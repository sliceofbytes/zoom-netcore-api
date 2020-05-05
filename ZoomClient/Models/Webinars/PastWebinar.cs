using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AndcultureCode.ZoomClient.Models.Webinars
{

    public partial class PastWebinar : BaseObject
    {
        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Webinar UUID.
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }
    }
}
