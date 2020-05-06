using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class CustomQuestionClass
    {
        /// <summary>
        /// An array of answer choices. Can't be used for short answer type.
        /// </summary>
        [JsonProperty("answers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Answers { get; set; }

        /// <summary>
        /// State whether or not the custom question is required to be answered by a registrant.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomQuestionRequired { get; set; }

        /// <summary>
        /// Custom question.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The question-answer type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public PollType? Type { get; set; }
    }
}
