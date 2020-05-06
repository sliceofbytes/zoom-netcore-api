namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class TrackingSource
    {
        /// <summary>
        /// Unique Identifier for the tracking source.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Number of registrations made from this source.
        /// </summary>
        public long? RegistrationCount { get; set; }

        /// <summary>
        /// Name of the source (platform) where the registration URL was shared.
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// Tracking URL. The URL that was shared for the registration.
        /// </summary>
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Number of visitors who visited the registration page from this source.
        /// </summary>
        public long? VisitorCount { get; set; }
    }
}