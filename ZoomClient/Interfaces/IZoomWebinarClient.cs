using AndcultureCode.ZoomClient.Models.Webinars;
using System.Collections.Generic;

namespace AndcultureCode.ZoomClient.Interfaces
{
    public interface IZoomWebinarClient
    {
        /// <summary>
        /// List webinars under your account. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinars
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pageSize">Max 300</param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        ListWebinars GetWebinars(string userId, int pageSize = 30, int pageNumber = 1);



        /// <summary>
        /// List webinars under your account. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarcreate
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="webinar"></param>
        /// <returns></returns>
        Webinar CreateWebinar(string userId, Webinar webinar);



        /// <summary>
        /// Get webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        Webinar GetWebinar(string webinarId);


        /// <summary>
        /// Update webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarupdate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="occurenceId"></param>
        /// <param name="webinar"></param>
        /// <returns></returns>
        bool UpdateWebinar(string webinarId, string occurenceId, Webinar webinar);



        /// <summary>
        /// Delete a webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="occurrenceId"></param>
        /// <returns></returns>
        bool DeleteWebinar(string webinarId, string occurrenceId = null);


        /// <summary>
        /// End a Webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarstatus
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        bool EndWebinar(int webinarId);


        /// <summary>
        /// List panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelists
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListPanelist GetPanelist(string webinarId);



        /// <summary>
        /// Add panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistcreate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="panelists"></param>
        /// <returns></returns>
        bool AddPanelist(string webinarId, List<Panelist> panelists);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistsdelete
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        bool RemoveAllPanelist(string webinarId);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistdelete
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="panelistId"></param>
        /// <returns></returns>
        bool RemovePanelist(string webinarId, string panelistId);

        /// <summary>
        /// List registrants for a webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrants
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="occurenceId"></param>
        /// <param name="status">pending, approved, denied</param>
        /// <param name="page_size">default:30, max: 300</param>
        /// <param name="page_number">default:1</param>
        /// <returns></returns>
        ListWebinarRegistrants GetWebinarRegistrants(string webinarId, string occurenceId, string status = "approved", int page_size = 30, int page_number = 1);


        /// <summary>
        /// Create Webinar Registrant https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrantcreate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="occurrence_ids">Multiple values seperated by comma.</param>
        /// <param name="registrant"></param>
        /// <returns></returns>
        WebinarRegistrant CreateWebinarRegistrant(string webinarId, CreateWebinarRegistrant registrant, string occurrence_ids = null);



        /// <summary>
        /// Update a meeting registrant’s status. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrantstatus
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="registrants"></param>
        /// <param name="status"></param>
        /// <param name="occurrenceId"></param>
        /// <returns></returns>
        bool UpdateWebinarRegistrant(string meetingId, List<UpdateWebinarRegistrant> registrants, string status, string occurrenceId = null);


        /// <summary>
        /// Get past meeting details. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/pastwebinars
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListPastWebinar GetPastWebinarInstances(string webinarId);

        /// <summary>
        /// List the polls of a webinar https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpolls
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListWebinarPolls GetWebinarPolls(string webinarId);

        /// <summary>
        /// Create a webinar poll https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpollcreate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="poll"></param>
        /// <returns></returns>
        Poll CreateWebinarPoll(string webinarId, Poll poll);

        /// <summary>
        /// Get Webinar Poll  https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpollget
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="pollId"></param>
        /// <returns></returns>
        Poll GetWebinarPoll(string webinarId, string pollId);

        /// <summary>
        /// Update Webinar Poll https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpollupdate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="pollId"></param>
        /// <param name="poll"></param>
        /// <returns></returns>
        bool UpdateWebinarPoll(string webinarId, string pollId, Poll poll);

        /// <summary>
        /// Delete Webinar Poll https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpolldelete
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="pollId"></param>
        /// <returns></returns>
        bool DeleteWebinarPoll(string webinarId, string pollId);


        /// <summary>
        /// Get Registration Questions https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrantsquestionsget
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListRegistrationQuestions GetRegistrationQuestions(string webinarId);


        /// <summary>
        /// Update Registration Questions https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrantquestionupdate
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="questions"></param>
        /// <returns></returns>
        bool UpdateRegistrationQuestions(string webinarId, ListRegistrationQuestions questions);


        /// <summary>
        /// Get Webinar Registrants https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrantget
        /// </summary>
        /// <param name="webinarId"></param>
        /// <param name="registrantId"></param>
        /// <param name="occurenceId"></param>
        /// <returns></returns>
        WebinarRegistrant GetWebinarRegistrant(string webinarId, string registrantId, string occurenceId = null);


        /// <summary>
        /// Get Webinar Absentees https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarabsentees
        /// </summary>
        /// <param name="webinarUUID"></param>
        /// <param name="pageSize"></param>
        /// <param name="nextPageToken"></param>
        /// <returns></returns>
        ListWebinarAbsentees GetWebinarAbsentees(string webinarUUID, int pageSize = 30, string nextPageToken = null);

        /// <summary>
        /// Get Webinar Tracking Sources https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/gettrackingsources
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListWebinarTrackingSources GetWebinarTrackingSources(string webinarId);


        /// <summary>
        /// Get Past Webinar Poll Results https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/listpastwebinarpollresults
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListPastWebinarPollResults GetPastWebinarPollResults(string webinarId);


        /// <summary>
        /// Get Past Webinar Q&A Results https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/listpastwebinarqa
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListPastWebinarQAResults GetPastWebinarQAResults(string webinarId);


        /// <summary>
        /// Get Past Webinar Files https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/listpastwebinarfiles
        /// </summary>
        /// <param name="webinarId"></param>
        /// <returns></returns>
        ListPastWebinarFiles GetPastWebinarFiles(string webinarId);

    }
}
