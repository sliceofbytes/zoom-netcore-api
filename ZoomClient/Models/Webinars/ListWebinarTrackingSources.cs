using System.Collections.Generic;

namespace AndcultureCode.ZoomClient.Models.Webinars
{

    public partial class ListWebinarTrackingSources : BaseList
    {
        /// <summary>
        /// Tracking Sources object.
        /// </summary>
        public List<TrackingSource> TrackingSources { get; set; }
    }

}