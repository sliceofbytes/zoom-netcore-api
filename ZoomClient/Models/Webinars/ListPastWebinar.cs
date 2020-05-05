using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public class ListPastWebinar : BaseList
    {
        /// Zoom property: participants
        /// </summary>
        public List<PastWebinar> Webinars { get; set; }
    }
}
