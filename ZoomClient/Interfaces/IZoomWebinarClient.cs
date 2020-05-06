using AndcultureCode.ZoomClient.Models.Meetings;
using AndcultureCode.ZoomClient.Models.Webinars;
using System;
using System.Collections.Generic;
using System.Text;

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
        /// <returns></returns>
        Webinar CreateWebinar(string userId, Webinar webinar);


        /// <summary>
        /// Get webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <returns></returns>
        Webinar GetWebinar(string webinarId);

        /// <summary>
        /// Update webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarupdate
        /// </summary>
        /// <returns></returns>
        bool UpdateWebinar(string webinarId, string occurenceId, Webinar webinar);


        /// <summary>
        /// Delete a webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <returns></returns>
        bool DeleteWebinar(string webinarId, string occurrenceId);

        /// <summary>
        /// End a Webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarstatus
        /// </summary>
        /// <returns></returns>
        bool EndWebinar(int webinarId);


        /// <summary>
        /// List panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelists
        /// </summary>
        /// <returns></returns>
        ListPanelist GetPanelist(string webinarId);


        /// <summary>
        /// Add panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistcreate
        /// </summary>
        /// <returns></returns>
        bool AddPanelist(string webinarId, List<Panelist> panelists);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistsdelete
        /// </summary>
        /// <returns></returns>
        bool RemoveAllPanelist(string webinarId);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistdelete
        /// </summary>
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
        /// 
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


        ListRegistrationQuestions GetRegistrationQuestions(string webinarId);

        bool UpdateRegistrationQuestions(string webinarId, ListRegistrationQuestions questions);


        WebinarRegistrant GetWebinarRegistrant(string webinarId, string registrantId, string occurenceId);

        ListWebinarAbsentees GetWebinarAbsentees(string webinarUUID, int pageSize, string nextPageToken);


        ListWebinarTrackingSources GetWebinarTrackingSources(string webinarId);

        ListPastWebinarPollResults GetPastWebinarPollResults(string webinarId);

        ListPastWebinarQAResults GetPastWebinarQAResults(string webinarId);

        ListPastWebinarFiles GetPastWebinarFiles(string webinarId);







    }
}
