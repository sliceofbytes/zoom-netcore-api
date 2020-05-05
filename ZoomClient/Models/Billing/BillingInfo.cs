namespace AndcultureCode.ZoomClient.Models.Billing
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Billing Contact object.
    /// </summary>
    public partial class BillingInfo
    {
        /// <summary>
        /// Billing Contact's address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Billing Contact's apartment/suite.
        /// </summary>
        [JsonProperty("apt", NullValueHandling = NullValueHandling.Ignore)]
        public string Apt { get; set; }

        /// <summary>
        /// Billing Contact's city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Billing Contact's Country
        /// [ID](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#countries)
        /// in abbreviated format.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Billing Contact's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Billing Contact's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Billing Contact's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Billing Contact's phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Billing Contact's state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Billing Contact's zip/postal code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
