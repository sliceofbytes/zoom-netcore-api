using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{

    /// <summary>
    /// Registrant.
    /// </summary>
    public partial class WebinarRegistrant
    {
        /// <summary>
        /// Registrant's address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// Registrant's city.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// A field that allows registrants to provide any questions or comments that they might have.
        /// </summary>
        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public string Comments { get; set; }

        /// <summary>
        /// Registrant's country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// The time at which the registrant registered.
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreateTime { get; set; }

        /// <summary>
        /// Custom questions.
        /// </summary>
        [JsonProperty("custom_questions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomQuestion> CustomQuestions { get; set; }

        /// <summary>
        /// A valid email address of the registrant.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Registrant's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Registrant ID.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Registrant's Industry.
        /// </summary>
        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string Industry { get; set; }

        /// <summary>
        /// Registrant's job title.
        /// </summary>
        [JsonProperty("job_title", NullValueHandling = NullValueHandling.Ignore)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The URL using which an approved registrant can join the webinar.
        /// </summary>
        [JsonProperty("join_url", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinUrl { get; set; }

        /// <summary>
        /// Registrant's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Number of
        /// Employees:<br>`1-20`<br>`21-50`<br>`51-100`<br>`101-500`<br>`500-1,000`<br>`1,001-5,000`<br>`5,001-10,000`<br>`More
        /// than 10,000`
        /// </summary>
        [JsonProperty("no_of_employees", NullValueHandling = NullValueHandling.Ignore)]
        public string NoOfEmployees { get; set; }

        /// <summary>
        /// Registrant's Organization.
        /// </summary>
        [JsonProperty("org", NullValueHandling = NullValueHandling.Ignore)]
        public string Org { get; set; }

        /// <summary>
        /// Registrant's Phone number.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// This field can be included to gauge interest of webinar attendees towards buying your
        /// product or service.
        ///
        /// Purchasing Time Frame:<br>`Within a month`<br>`1-3 months`<br>`4-6 months`<br>`More than
        /// 6 months`<br>`No timeframe`
        /// </summary>
        [JsonProperty("purchasing_time_frame", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchasingTimeFrame { get; set; }

        /// <summary>
        /// Role in Purchase Process:<br>`Decision
        /// Maker`<br>`Evaluator/Recommender`<br>`Influencer`<br>`Not involved`
        /// </summary>
        [JsonProperty("role_in_purchase_process", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleInPurchaseProcess { get; set; }

        /// <summary>
        /// Registrant's State/Province.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The status of the registrant's registration. <br> `approved`: User has been successfully
        /// approved for the webinar.<br> `pending`:  The registration is still pending.<br>
        /// `denied`: User has been denied from joining the webinar.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public WebinarRegistrantStatus? Status { get; set; }

        /// <summary>
        /// Registrant's Zip/Postal Code.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}
