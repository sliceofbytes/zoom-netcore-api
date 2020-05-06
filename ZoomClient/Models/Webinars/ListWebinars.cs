using System.Collections.Generic;
using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    /// <summary>
    /// List of webinars.
    /// </summary>
    public partial class ListWebinars : BaseList
    {

        /// <summary>
        /// List of webinar objects.
        /// </summary>
        [JsonProperty("webinars", NullValueHandling = NullValueHandling.Ignore)]
        public List<Webinar> Webinars { get; set; }
    }
}
