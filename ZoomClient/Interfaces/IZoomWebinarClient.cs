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
        /// <returns></returns>
        ListWebinars GetWebinars(string userId);


        /// <summary>
        /// List webinars under your account. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarcreate
        /// </summary>
        /// <returns></returns>
        Webinar CreateWebinar(CreateWebinar createWebinar);


        /// <summary>
        /// Get webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <returns></returns>
        Webinar GetWebinar(int webinarId);

        /// <summary>
        /// Update webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarupdate
        /// </summary>
        /// <returns></returns>
        bool UpdateWebinar(Webinar webinar);


        /// <summary>
        /// Delete a webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinar
        /// </summary>
        /// <returns></returns>
        bool DeleteWebinar(int webinarId);

        /// <summary>
        /// Update a webinar status. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarstatus
        /// Update a webinar’s status. Use this API to end an ongoing webinar.
        /// action = "end" is only valid action.
        /// </summary>
        /// <returns></returns>
        bool UpdateWebinarStatus(int webinarId, string action);


        /// <summary>
        /// List panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelists
        /// </summary>
        /// <returns></returns>
        ListPanelist GetPanelist(int webinarId);


        /// <summary>
        /// Add panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistcreate
        /// </summary>
        /// <returns></returns>
        bool AddPanelist(int webinarId, AddPanelists panelists);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistsdelete
        /// </summary>
        /// <returns></returns>
        bool RemoveAllPanelist(int webinarId);


        /// <summary>
        /// Remove all panelist for webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarpanelistdelete
        /// </summary>
        /// <returns></returns>
        bool RemovePanelist(int webinarId, int panelistId);


        /// <summary>
        /// List registrants for a webinar. https://marketplace.zoom.us/docs/api-reference/zoom-api/webinars/webinarregistrants
        /// </summary>
        /// <returns></returns>
        ListWebinarRegistrants ListRegistrants(int webinarId, string status = "approved", int page_size = 30, int page_number = 1);


    }
}
