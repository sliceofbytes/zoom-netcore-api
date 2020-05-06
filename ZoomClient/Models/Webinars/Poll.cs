using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Webinars
{
    /// <summary>
    /// Poll
    /// </summary>
    public partial class Poll
    {
        /// <summary>
        /// ID of Poll
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Array of Polls
        /// </summary>
        [JsonProperty("questions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PollQuestion> Questions { get; set; }

        /// <summary>
        /// Status of Poll:<br>`notstart` - Poll not started<br>`started` - Poll started<br>`ended` -
        /// Poll ended<br>`sharing` - Sharing poll results
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public PollStatus? Status { get; set; }

        /// <summary>
        /// Title for the poll.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}
