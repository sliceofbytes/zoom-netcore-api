using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Webinars
{

    /// <summary>
    /// Poll List
    /// </summary>
    public partial class ListWebinarPolls : BaseList
    {
        /// <summary>
        /// Array of Polls
        /// </summary>
        [JsonProperty("polls", NullValueHandling = NullValueHandling.Ignore)]
        public List<Poll> Polls { get; set; }

    }
}
