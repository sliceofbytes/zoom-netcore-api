using AndcultureCode.ZoomClient.Interfaces;
using AndcultureCode.ZoomClient.Models;
using AndcultureCode.ZoomClient.Models.Billing;
using AndcultureCode.ZoomClient.Extensions;

using RestSharp;
using System;


namespace AndcultureCode.ZoomClient
{
    public class ZoomBillingClient : IZoomBillingClient
    {

        #region Constants

        const string GET_BILLING_INFO = "accounts/{accountId}/billing";
        const string GET_PLANS_INFO = "accounts/{accountId}/plans";

        #endregion

        #region Properties

        ZoomClientOptions Options { get; set; }
        RestClient WebClient { get; set; }

        #endregion

        #region Constructor

        internal ZoomBillingClient(ZoomClientOptions options, RestClient webClient)
        {
            Options = options;
            WebClient = webClient;
        }


        #endregion

        #region IZoomGroupsClient Implementation


        public BillingInfo GetBillingInfo(string accountId)
        {
            var request = BuildRequestAuthorization(GET_BILLING_INFO, Method.GET);
            var response = WebClient.Execute<BillingInfo>(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }

            if (!string.IsNullOrWhiteSpace(response.ErrorMessage))
            {
                throw new Exception(response.ErrorMessage);
            }

            if (!string.IsNullOrWhiteSpace(response.StatusDescription) && !string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusDescription} || {response.Content}");
            }

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusCode} || {response.Content}");
            }

            return null;
        }


        public PlanInfo GetPlansInfo(string accountId)
        {
            var request = BuildRequestAuthorization(GET_PLANS_INFO, Method.GET);
            var response = WebClient.Execute<PlanInfo>(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }

            if (!string.IsNullOrWhiteSpace(response.ErrorMessage))
            {
                throw new Exception(response.ErrorMessage);
            }

            if (!string.IsNullOrWhiteSpace(response.StatusDescription) && !string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusDescription} || {response.Content}");
            }

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusCode} || {response.Content}");
            }

            return null;
        }


        #endregion

        #region Private Methods
        RestRequest BuildRequestAuthorization(string resource, Method method)
        {
            return WebClient.BuildRequestAuthorization(Options, resource, method);
        }
        #endregion
    }
}
