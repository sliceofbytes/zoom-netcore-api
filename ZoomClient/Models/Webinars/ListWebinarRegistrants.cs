using System.Collections.Generic;
using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{


    /// <summary>
    /// List of users.
    /// </summary>
    public partial class ListWebinarRegistrants : BaseList
    {
        /// <summary>
        /// List of registrant objects.
        /// </summary>
        [JsonProperty("registrants", NullValueHandling = NullValueHandling.Ignore)]
        public List<WebinarRegistrant> Registrants { get; set; }

    }
}
