using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class PollQuestion
    {
        /// <summary>
        /// Answers to the questions
        /// </summary>
        [JsonProperty("answers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Answers { get; set; }

        /// <summary>
        /// Question to be asked to the attendees.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Poll Question & Answer type:<br>`single` - Single choice<br>`mutliple` - Multiple choice
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public PollType? Type { get; set; }
    }
}
