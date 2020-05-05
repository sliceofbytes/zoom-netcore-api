using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Account Plans object.
    /// </summary>
    public partial class PlanInfo
    {
        /// <summary>
        /// Additional audio conferencing <a
        /// href="https://marketplace.zoom.us/docs/api-reference/other-references/plans#audio-conferencing-plans">plan
        /// type.</a>
        /// </summary>
        [JsonProperty("plan_audio", NullValueHandling = NullValueHandling.Ignore)]
        public PlanAudio PlanAudio { get; set; }

        /// <summary>
        /// Account base plan object.
        /// </summary>
        [JsonProperty("plan_base")]
        public PlanInfoPlanBase PlanBase { get; set; }

        /// <summary>
        /// Additional large meeting Plans.
        /// </summary>
        [JsonProperty("plan_large_meeting", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlanLargeMeeting> PlanLargeMeeting { get; set; }

        /// <summary>
        /// Phone Plan Object
        /// </summary>
        [JsonProperty("plan_phone", NullValueHandling = NullValueHandling.Ignore)]
        public PhonePlan PlanPhone { get; set; }

        /// <summary>
        /// Additional cloud recording plan.
        /// </summary>
        [JsonProperty("plan_recording", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanRecording { get; set; }

        /// <summary>
        /// Account plan object.
        /// </summary>
        [JsonProperty("plan_room_connector", NullValueHandling = NullValueHandling.Ignore)]
        public PlanRoomConnector PlanRoomConnector { get; set; }

        /// <summary>
        /// Additional webinar plans.
        /// </summary>
        [JsonProperty("plan_webinar", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlanWebinar> PlanWebinar { get; set; }

        /// <summary>
        /// Account plan object.
        /// </summary>
        [JsonProperty("plan_zoom_rooms", NullValueHandling = NullValueHandling.Ignore)]
        public PlanZoomRooms PlanZoomRooms { get; set; }
    }
}
