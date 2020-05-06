namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public partial class InMeetingFile
    {
        /// <summary>
        /// URL to download the file.
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Name of the file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        public long? FileSize { get; set; }
    }

}
