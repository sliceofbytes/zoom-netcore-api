using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    /// <summary>
    /// Status of Poll:<br>`notstart` - Poll not started<br>`started` - Poll started<br>`ended` -
    /// Poll ended<br>`sharing` - Sharing poll results
    /// </summary>
    public enum PollStatus { Ended, Notstart, Sharing, Started };
}
