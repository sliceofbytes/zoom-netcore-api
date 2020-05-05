using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class QuestionClass
    {
        /// <summary>
        /// Field name
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public FieldName? FieldName { get; set; }

        /// <summary>
        /// State whether the selected fields are required or optional.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuestionRequired { get; set; }
    }
}
