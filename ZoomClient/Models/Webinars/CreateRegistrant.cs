using System.Collections.Generic;

namespace AndcultureCode.ZoomClient.Models.Webinars
{

    /// <summary>
    /// Webinar registrant.
    /// </summary>
    public partial class CreateWebinarRegistrant
    {
        /// <summary>
        /// Registrant's address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Registrant's city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// A field that allows registrants to provide any questions or comments that they might have.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Registrant's country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Custom questions.
        /// </summary>
        public List<CustomQuestion> CustomQuestions { get; set; }

        /// <summary>
        /// A valid email address of the registrant.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Registrant's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Registrant's Industry.
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Registrant's job title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Registrant's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Number of
        /// Employees:<br>`1-20`<br>`21-50`<br>`51-100`<br>`101-500`<br>`500-1,000`<br>`1,001-5,000`<br>`5,001-10,000`<br>`More
        /// than 10,000`
        /// </summary>
        public string NoOfEmployees { get; set; }

        /// <summary>
        /// Registrant's Organization.
        /// </summary>
        public string Org { get; set; }

        /// <summary>
        /// Registrant's Phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// This field can be included to gauge interest of webinar attendees towards buying your
        /// product or service.
        ///
        /// Purchasing Time Frame:<br>`Within a month`<br>`1-3 months`<br>`4-6 months`<br>`More than
        /// 6 months`<br>`No timeframe`
        /// </summary>
        public string PurchasingTimeFrame { get; set; }

        /// <summary>
        /// Role in Purchase Process:<br>`Decision
        /// Maker`<br>`Evaluator/Recommender`<br>`Influencer`<br>`Not involved`
        /// </summary>
        public string RoleInPurchaseProcess { get; set; }

        /// <summary>
        /// Registrant's State/Province.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Registrant's Zip/Postal Code.
        /// </summary>
        public string Zip { get; set; }
    }

}
