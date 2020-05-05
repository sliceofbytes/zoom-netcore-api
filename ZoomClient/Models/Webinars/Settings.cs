namespace AndcultureCode.ZoomClient.Models.Webinars
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Create Webinar settings.
    /// </summary>
    public partial class Settings
    {
        /// <summary>
        /// Allow attendees to join from multiple devices.
        /// </summary>
        [JsonProperty("allow_multiple_devices", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowMultipleDevices { get; set; }

        /// <summary>
        /// Alternative host emails or IDs. Multiple values separated by comma.
        /// </summary>
        [JsonProperty("alternative_hosts", NullValueHandling = NullValueHandling.Ignore)]
        public string AlternativeHosts { get; set; }

        /// <summary>
        /// `0` - Automatically approve.<br>`1` - Manually approve.<br>`2` - No registration required.
        /// </summary>
        [JsonProperty("approval_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? ApprovalType { get; set; }

        /// <summary>
        /// Determine how participants can join the audio portion of the meeting.
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public Audio? Audio { get; set; }

        /// <summary>
        /// Meeting authentication domains. This option, allows you to specify the rule so that Zoom
        /// users, whose email address contains a certain domain, can join the Webinar. You can
        /// either provide multiple domains, using a comma in between and/or use a wildcard for
        /// listing domains.
        /// </summary>
        [JsonProperty("authentication_domains", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationDomains { get; set; }

        /// <summary>
        /// Specify the authentication type for users to join a Webinar with`meeting_authentication`
        /// setting set to `true`. The value of this field can be retrieved from the `id` field
        /// within `authentication_options` array in the response of [Get User Settings
        /// API](https://marketplace.zoom.us/docs/api-reference/zoom-api/users/usersettings).
        /// </summary>
        [JsonProperty("authentication_option", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationOption { get; set; }

        /// <summary>
        /// Automatic recording:<br>`local` - Record on local.<br>`cloud` -  Record on
        /// cloud.<br>`none` - Disabled.
        /// </summary>
        [JsonProperty("auto_recording", NullValueHandling = NullValueHandling.Ignore)]
        public AutoRecording? AutoRecording { get; set; }

        /// <summary>
        /// Close registration after event date.
        /// </summary>
        [JsonProperty("close_registration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloseRegistration { get; set; }

        /// <summary>
        /// Contact email for registration
        /// </summary>
        [JsonProperty("contact_email", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Contact name for registration
        /// </summary>
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        /// Only signed-in users can join this meeting.
        ///
        /// **This field is deprecated and will not be supported in future.** <br><br> Instead of
        /// this field, use the "meeting_authentication", "authentication_option" and/or
        /// "authentication_domains" fields to establish the authentication mechanism for this
        /// Webinar.
        /// </summary>
        [JsonProperty("enforce_login", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnforceLogin { get; set; }

        /// <summary>
        /// Only signed-in users with specified domains can join meetings.
        ///
        /// **This field is deprecated and will not be supported in future.** <br><br> Instead of
        /// this field, use the "authentication_domains" field for this Webinar.
        /// </summary>
        [JsonProperty("enforce_login_domains", NullValueHandling = NullValueHandling.Ignore)]
        public string EnforceLoginDomains { get; set; }

        /// <summary>
        /// List of global dial-in countries
        /// </summary>
        [JsonProperty("global_dial_in_countries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GlobalDialInCountries { get; set; }

        /// <summary>
        /// Default to HD video.
        /// </summary>
        [JsonProperty("hd_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HdVideo { get; set; }

        /// <summary>
        /// Start video when host joins webinar.
        /// </summary>
        [JsonProperty("host_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HostVideo { get; set; }

        /// <summary>
        /// Only
        /// [authenticated](https://support.zoom.us/hc/en-us/articles/360037117472-Authentication-Profiles-for-Meetings-and-Webinars)
        /// users can join meeting if the value of this field is set to `true`.
        /// </summary>
        [JsonProperty("meeting_authentication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MeetingAuthentication { get; set; }

        /// <summary>
        /// Make the webinar on-demand
        /// </summary>
        [JsonProperty("on_demand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnDemand { get; set; }

        /// <summary>
        /// Start video when panelists join webinar.
        /// </summary>
        [JsonProperty("panelists_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PanelistsVideo { get; set; }

        /// <summary>
        /// Zoom will open a survey page in attendees' browsers after leaving the webinar
        /// </summary>
        [JsonProperty("post_webinar_survey", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PostWebinarSurvey { get; set; }

        /// <summary>
        /// Enable practice session.
        /// </summary>
        [JsonProperty("practice_session", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PracticeSession { get; set; }

        /// <summary>
        /// Send email notifications to registrants about approval, cancellation, denial of the
        /// registration. The value of this field must be set to true in order to use the
        /// `registrants_confirmation_email` field.
        /// </summary>
        [JsonProperty("registrants_email_notification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegistrantsEmailNotification { get; set; }

        /// <summary>
        /// Restrict number of registrants for a webinar. By default, it is set to `0`. A `0` value
        /// means that the restriction option is disabled. Provide a number higher than 0 to restrict
        /// the webinar registrants by the that number.
        /// </summary>
        [JsonProperty("registrants_restrict_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegistrantsRestrictNumber { get; set; }

        /// <summary>
        /// Registration types. Only used for recurring webinars with a fixed time.<br>`1` -
        /// Attendees register once and can attend any of the webinar sessions.<br>`2` - Attendees
        /// need to register for each session in order to attend.<br>`3` - Attendees register once
        /// and can choose one or more sessions to attend.
        /// </summary>
        [JsonProperty("registration_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegistrationType { get; set; }

        /// <summary>
        /// Show social share buttons on the registration page.
        /// </summary>
        [JsonProperty("show_share_button", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowShareButton { get; set; }

        /// <summary>
        /// Survey url for post webinar survey
        /// </summary>
        [JsonProperty("survey_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SurveyUrl { get; set; }
    }
}
