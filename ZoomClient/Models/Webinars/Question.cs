using System.Collections.Generic;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class Question
    {
        /// <summary>
        /// Email address of the user who submitted answers to the poll.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Name of the user who submitted answers to the poll. If "anonymous" option is enabled for
        /// a poll, the participant's polling information will be kept anonymous and the value of
        /// `name` field will be "Anonymous Attendee".
        /// </summary>
        public string Name { get; set; }

        public List<QuestionDetail> QuestionDetails { get; set; }
    }

}
