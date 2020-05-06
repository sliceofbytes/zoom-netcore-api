using AndcultureCode.ZoomClient.Extensions;
using AndcultureCode.ZoomClient.Interfaces;
using AndcultureCode.ZoomClient.Models;
using AndcultureCode.ZoomClient.Models.Webinars;
using RestSharp;
using System;
using System.Collections.Generic;

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

        const string GET_WEBINAR_PANELISTS = "webinars/{webinarId}/panelists";
        const string POST_WEBINAR_PANELISTS = "webinars/{webinarId}/panelists";
        const string DELETE_WEBINAR_PANELISTS = "webinars/{webinarId}/panelists";
        const string DELETE_WEBINAR_PANELIST = "webinars/{webinarId}/panelists/{panelistId}";

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
        const string POST_WEBINAR_POLL = "webinar/{webinarId}/polls";
        const string GET_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";
        const string PUT_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";
        const string DELETE_WEBINAR_POLL = "webinar/{webinarId}/polls/{pollId}";

        const string GET_WEBINAR_REGISTRATION_QUESTIONS = "webinars/{webinarId}/registrants/questions";
        const string PATCH_WEBINAR_REGISTRATION_QEUSTIONS = "webinars/{webinarId}/registrants/questions";

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


        #region IZoomWebinarClient Implementation

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

        public WebinarRegistrant CreateWebinarRegistrant(string webinarId, CreateWebinarRegistrant webinarRegistrant, string occurrenceIds = null)
        {
            var request = BuildRequestAuthorization(POST_WEBINAR_REGISTRANTS, Method.POST);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            if (!string.IsNullOrWhiteSpace(occurrenceIds))
            {
                request.AddParameter("occurrence_ids", occurrenceIds, ParameterType.QueryString);
            }
            request.AddJsonBody(webinarRegistrant);

            var response = WebClient.Execute<WebinarRegistrant>(request);

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

        public ListPanelist GetPanelist(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_PANELISTS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);

            var response = WebClient.Execute<ListPanelist>(request);

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

        public bool AddPanelist(string webinarId, List<Panelist> panelists)
        {
            var request = BuildRequestAuthorization(POST_WEBINAR_PANELISTS, Method.POST);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddJsonBody(panelists);

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.Created)
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

        public bool RemoveAllPanelist(string webinarId)
        {
            var request = BuildRequestAuthorization(DELETE_WEBINAR_PANELISTS, Method.DELETE);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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

        public bool RemovePanelist(string webinarId, string panelistId)
        {
            var request = BuildRequestAuthorization(DELETE_WEBINAR_PANELIST, Method.DELETE);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("panelistId", panelistId, ParameterType.UrlSegment);

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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

        public ListWebinarPolls GetWebinarPolls(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_POLLS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListWebinarPolls>(request);

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

        public Poll GetWebinarPoll(string webinarId, string pollId)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_POLL, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("pollId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<Poll>(request);

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

        public Poll CreateWebinarPoll(string webinarId, Poll poll)
        {
            var request = BuildRequestAuthorization(POST_WEBINAR_POLL, Method.POST);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddJsonBody(poll);

            var response = WebClient.Execute<Poll>(request);

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

        public bool DeleteWebinarPoll(string webinarId, string pollId)
        {
            var request = BuildRequestAuthorization(DELETE_WEBINAR_POLL, Method.DELETE);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("pollId", pollId, ParameterType.UrlSegment);


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

        public bool UpdateWebinarPoll(string webinarId, string pollId, Poll poll)
        {
            var request = BuildRequestAuthorization(PUT_WEBINAR_POLL, Method.PUT);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddParameter("pollId", webinarId, ParameterType.UrlSegment);

            request.AddJsonBody(poll);

            var response = WebClient.Execute(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.Created)
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

        public ListRegistrationQuestions GetRegistrationQuestions(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_REGISTRATION_QUESTIONS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListRegistrationQuestions>(request);

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

        public bool UpdateRegistrationQuestions(string webinarId, ListRegistrationQuestions questions)
        {
            var request = BuildRequestAuthorization(PATCH_WEBINAR_REGISTRATION_QEUSTIONS, Method.PATCH);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);
            request.AddJsonBody(questions);

            var response = WebClient.Execute<ListRegistrationQuestions>(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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

        public ListWebinarTrackingSources GetWebinarTrackingSources(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_WEBINAR_TRACKING_SOURCES, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListWebinarTrackingSources>(request);

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

        public ListPastWebinarFiles GetPastWebinarFiles(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_PAST_WEBINAR_FILES, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListPastWebinarFiles>(request);

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

        public ListPastWebinar GetPastWebinarInstances(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_PAST_WEBINARS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListPastWebinar>(request);

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

        public ListPastWebinarPollResults GetPastWebinarPollResults(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_PAST_WEBINAR_POLLS, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListPastWebinarPollResults>(request);

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

        public ListPastWebinarQAResults GetPastWebinarQAResults(string webinarId)
        {
            var request = BuildRequestAuthorization(GET_PAST_WEBINAR_QA, Method.GET);
            request.AddParameter("webinarId", webinarId, ParameterType.UrlSegment);


            var response = WebClient.Execute<ListPastWebinarQAResults>(request);

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

        public ListWebinarAbsentees GetWebinarAbsentees(string webinarUUID, int pageSize, string nextPageToken)
        {
            if (pageSize > 300)
            {
                throw new Exception("GetMeetingParticipantsReport page size max 300");
            }

            var request = BuildRequestAuthorization(GET_PAST_WEBINAR_ABSENTEES, Method.GET);
            request.AddParameter("meetingId", webinarUUID, ParameterType.UrlSegment);
            request.AddParameter("page_size", pageSize, ParameterType.QueryString);
            if (!string.IsNullOrWhiteSpace(nextPageToken))
            {
                request.AddParameter("next_page_token", nextPageToken, ParameterType.QueryString);
            }

            var response = WebClient.Execute<ListWebinarAbsentees>(request);

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
