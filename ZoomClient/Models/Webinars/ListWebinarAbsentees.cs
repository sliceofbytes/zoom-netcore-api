using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    public class ListWebinarAbsentees : BaseList
    {
        /// <summary>
        /// List of registrant objects.
        /// </summary>
        public List<WebinarRegistrant> Registrants { get; set; }

    }
}
