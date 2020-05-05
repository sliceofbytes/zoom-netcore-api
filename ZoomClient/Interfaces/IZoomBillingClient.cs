using AndcultureCode.ZoomClient.Models.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Interfaces
{
    public interface IZoomBillingClient
    {
        /// <summary>
        /// Get Billing Info. https://marketplace.zoom.us/docs/api-reference/zoom-api/billing/accountbilling
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        BillingInfo GetBillingInfo(string accountId);


        /// <summary>
        /// Get Plan Info. https://marketplace.zoom.us/docs/api-reference/zoom-api/billing/accountplans
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        PlanInfo GetPlansInfo(string accountId);

    }
}
