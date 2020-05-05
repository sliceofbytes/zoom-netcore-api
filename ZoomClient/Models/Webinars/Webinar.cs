using System;
using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class Webinar
    {
        /// <summary>
        /// Webinar Description. The length of agenda gets truncated to 250 characters when you list
        /// all webinars for a user. To view the complete agenda, retrieve details for a single
        /// webinar [here](https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar).
        /// </summary>
        [JsonProperty("agenda", NullValueHandling = NullValueHandling.Ignore)]
        public string Agenda { get; set; }

        /// <summary>
        /// Time of webinar creation.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Meeting duration.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// ID of the host of the webinar.
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// Webinar ID in "**long**" format(represented as int64 data type in JSON), also known as
        /// the webinar number.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Join URL of the webinar (using which others can join the webinar).
        /// </summary>
        [JsonProperty("join_url", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinUrl { get; set; }

        /// <summary>
        /// Scheduled start time of the Webinar.
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// [Timezone
        /// ID](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#timezones)
        /// for the Webinar.
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// Meeting topic.
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// Meeting type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        /// <summary>
        /// Unique identifier for a Webinar. Each webinar instance will generate its own UUID. Once a
        /// Webinar ends, the value of uuid for the same webinar will be different from when it was
        /// scheduled.
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }
    }
}
