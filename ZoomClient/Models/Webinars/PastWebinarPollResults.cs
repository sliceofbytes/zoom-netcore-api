using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class ListPastWebinarPollResults
    {
        /// <summary>
        /// Webinar ID in "**long**" format(represented as int64 data type in JSON), also known as
        /// the webinar number.
        /// </summary>
        public long? Id { get; set; }

        public List<Question> Questions { get; set; }

        /// <summary>
        /// The start time of the Webinar.
        /// </summary>
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Webinar UUID.
        /// </summary>
        public string Uuid { get; set; }
    }

}
