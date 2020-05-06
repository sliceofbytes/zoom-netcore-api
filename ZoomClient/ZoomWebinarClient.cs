using AndcultureCode.ZoomClient.Interfaces;
using AndcultureCode.ZoomClient.Models;
using AndcultureCode.ZoomClient.Models.Webinars;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient
{
    public class ZoomWebinarClient : IZoomWebinarClient
    {

        #region Constants

        const string GET_WEBINARS = "users/{userId}/webinars";
        const string GET_WEBINAR = "users/{userId}/webinars";
        const string POST_WEBINAR = "webinars/{webinarId}";
        const string PATCH_WEBINAR = "webinars/{webinarId}";
        const string DELETE_WEBINAR = "webinars/{webinarId}";
        const string PUT_WEBINAR = "webinars/{webinarId}/status";

        const string GET_PANELISTS = "webinars/{webinarId}/panelists";
        const string POST_PANELISTS = "webinars/{webinarId}/panelists";
        const string DELETE_PANELISTS = "webinars/{webinarId}/panelists";
        const string DELETE_PANELIST = "webinars/{webinarId}/panelists/{panelistId}";

        const string GET_WEBINAR_REGISTRANTS = "webinars/{webinarId}/registrants";
        const string GET_WEBINAR_REGISTRANT = "webinars/{webinarId}/registrants/{registrantId}";
        const string POST_WEBINAR_REGISTRANTS = "webinars/{webinarId}/registrants";
        const string PUT_WEBINAR_REGISTRANTS_STATUS = "webinars/{webinarId}/registrants/status";

       



        const string GET_PAST_WEBINARS = "past_webinars/{webinarId}/instances";
        const string GET_PAST_WEBINAR_ABSENTEES = "past_webinars/{webinarUUID}/absentees";
        const string GET_PAST_WEBINAR_POLLS = "past_webinars/{webinarId}/polls";
        const string GET_PAST_WEBINAR_QA = "past_webinars/{webinarId}/qa";
        const string GET_PAST_WEBINAR_FILES = "past_webinars/{webinarId}/files";

        const string GET_WEBINAR_POLLS = "webinar/{webinarId}/polls";
        const string POST_WEBINAR_POLLS = "webinar/{webinarId}/polls";
        const string GET_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";
        const string PUT_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";
        const string DELETE_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";

        const string GET_REGISTRATION_QUESTIONS = "webinars/{webinarId}/registrants/questions";
        const string PATCH_REGISTRATION_QEUSTIONS = "webinars/{webinarId}/registrants/questions";

        const string GET_WEBINAR_TRACKING_SOURCES = "/webinars/{webinarId}/tracking_sources";

        #endregion


        #region Properties

        ZoomClientOptions Options { get; set; }
        RestClient WebClient { get; set; }

        #endregion


        #region Constructor

        internal ZoomWebinarClient(ZoomClientOptions options, RestClient webClient)
        {
            Options = options;
            WebClient = webClient;
        }

        #endregion



        public ListWebinars GetWebinars(string userId, int pageSize = 30, int pageNumber = 1)
        {
            if (pageSize > 300)
            {
                throw new Exception("GetMeetings page size max 300");
            }

            var request = BuildRequestAuthorization(GET_WEBINARS, Method.GET);
            request.AddParameter("userId", userId, ParameterType.UrlSegment);
            request.AddParameter("page_size", pageSize, ParameterType.QueryString);
            request.AddParameter("page_number", pageNumber, ParameterType.QueryString);

            var response = WebClient.Execute<ListWebinars>(request);

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

        public Webinar CreateWebinar(string userId, Webinar webinar)
        {
            var request = BuildRequestAuthorization(POST_WEBINAR, Method.POST);
            request.AddParameter("userId", userId, ParameterType.UrlSegment);
            request.AddJsonBody(webinar);

            var response = WebClient.Execute<Webinar>(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.Created)
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

        public Webinar GetWebinar(string webinarId)
        {

            var request = BuildRequestAuthorization(GET_WEBINAR, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);

            var response = WebClient.Execute<Webinar>(request);

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

        public bool UpdateWebinar(string webinarId, string occurenceId, Webinar webinar)
        {
            var request = BuildRequestAuthorization(PATCH_WEBINAR, Method.PATCH);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddJsonBody(webinar);

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
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

            return false;
        }

        public bool DeleteWebinar(string webinarId, string occurrenceId)
        {
            var request = BuildRequestAuthorization(DELETE_WEBINAR, Method.DELETE);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            if (!string.IsNullOrWhiteSpace(occurrenceId))
            {
                request.AddParameter("occurrence_id", occurrenceId, ParameterType.QueryString);
            }

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
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

            return false;
        }


        public bool EndWebinar(int webinarId)
        {
            var request = BuildRequestAuthorization(PUT_WEBINAR, Method.PUT);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddJsonBody(new { action = "end" });

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
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

            return false;
        }


        public ListWebinarRegistrants GetWebinarRegistrants(string webinarId, string occurrenceId, string status = "approved", int pageSize = 30, int pageNumber = 1)
        {
            if (pageSize > 300)
            {
                throw new Exception("GetMeetingRegistrants page size max 300");
            }

            if (!status.Equals(WebinarRegistrantStatuses.Approved, StringComparison.InvariantCultureIgnoreCase) &&
                !status.Equals(WebinarRegistrantStatuses.Denied, StringComparison.InvariantCultureIgnoreCase) &&
                !status.Equals(WebinarRegistrantStatuses.Pending, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"GetMeetingRegistrants status allowed values are [{WebinarRegistrantStatuses.Approved},{WebinarRegistrantStatuses.Denied},{WebinarRegistrantStatuses.Pending}]");
            }

            var request = BuildRequestAuthorization(GET_WEBINAR_REGISTRANTS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("status", status, ParameterType.QueryString);
            request.AddParameter("page_size", pageSize, ParameterType.QueryString);
            request.AddParameter("page_number", pageNumber, ParameterType.QueryString);
            if (!string.IsNullOrWhiteSpace(occurrenceId))
            {
                request.AddParameter("occurrence_id", occurrenceId, ParameterType.QueryString);
            }

            var response = WebClient.Execute<ListWebinarRegistrants>(request);

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

        public WebinarRegistrant GetWebinarRegistrant(string webinarId, string registrantId, string occurrenceId = null)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_REGISTRANT, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("registrantId", registrantId, ParameterType.UrlSegment);
            if (!string.IsNullOrWhiteSpace(occurrenceId))
            {
                request.AddParameter("occurrence_id", occurrenceId, ParameterType.QueryString);
            }

            var response = WebClient.Execute<WebinarRegistrant>(request);

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

        public bool UpdateWebinarRegistrant(string webinarId, List<UpdateWebinarRegistrant> registrants, string status,  string occurrenceId = null)
        {
            if (!status.Equals(UpdateWebinarRegistrantStatuses.Approve, StringComparison.InvariantCultureIgnoreCase) &&
                !status.Equals(UpdateWebinarRegistrantStatuses.Deny, StringComparison.InvariantCultureIgnoreCase) &&
                !status.Equals(UpdateWebinarRegistrantStatuses.Cancel, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"UpdateMeetingRegistrant status allowed values are [{UpdateWebinarRegistrantStatuses.Approve},{UpdateWebinarRegistrantStatuses.Deny},{UpdateWebinarRegistrantStatuses.Cancel}]");
            }

            var request = BuildRequestAuthorization(PUT_WEBINAR_REGISTRANTS_STATUS, Method.PUT);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            if (!string.IsNullOrWhiteSpace(occurrenceId))
            {
                request.AddParameter("occurrence_id", occurrenceId, ParameterType.QueryString);
            }
            request.AddJsonBody(new { action = status, registrants });

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
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

            return false;
        }






        public bool AddPanelist(string webinarId, List<Panelist> panelists)
        {
            throw new NotImplementedException();
        }



        public Poll CreateWebinarPoll(string webinarId, Poll poll)
        {
            throw new NotImplementedException();
        }





        public bool DeleteWebinarPoll(string webinarId, string pollId)
        {
            throw new NotImplementedException();
        }



        public ListPanelist GetPanelist(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListPastWebinarFiles GetPastWebinarFiles(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListPastWebinar GetPastWebinarInstances(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListPastWebinarPollResults GetPastWebinarPollResults(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListPastWebinarQAResults GetPastWebinarQAResults(string webinarId)
        {
            throw new NotImplementedException();
        }



        public ListWebinarAbsentees GetWebinarAbsentees(string webinarUUID, int pageSize, string nextPageToken)
        {
            throw new NotImplementedException();
        }

        public Poll GetWebinarPoll(string webinarId, string pollId)
        {
            throw new NotImplementedException();
        }




        public ListWebinarTrackingSources GetWebinarTrackingSources(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListRegistrationQuestions ListRegistrationQuestions(string webinarId)
        {
            throw new NotImplementedException();
        }

        public ListWebinarPolls ListWebinarPolls(string webinarId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAllPanelist(string webinarId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePanelist(string webinarId, string panelistId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRegistrationQuestions(string webinarId, ListRegistrationQuestions questions)
        {
            throw new NotImplementedException();
        }



        public bool UpdateWebinarPoll(string webinarId, string pollId, Poll poll)
        {
            throw new NotImplementedException();
        }


        #region Private Methods

        RestRequest BuildRequestAuthorization(string resource, Method method)
        {
            return WebClient.BuildRequestAuthorization(Options, resource, method);
        }

        #endregion
    }
}
