namespace AndcultureCode.ZoomClient.Models.Webinars
{
    using Newtonsoft.Json;

    /// <summary>
    /// Custom Question.
    /// </summary>
    public partial class CustomQuestion
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
