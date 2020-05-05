using System.Collections.Generic;
using Newtonsoft.Json;


namespace AndcultureCode.ZoomClient.Models.Billing
{
    /// <summary>
    /// Phone Plan Object
    /// </summary>
    public partial class PhonePlan
    {
        /// <summary>
        /// Additional phone base plans.
        /// </summary>
        [JsonProperty("plan_base", NullValueHandling = NullValueHandling.Ignore)]
        public PlanPhonePlanBase PlanBase { get; set; }

        /// <summary>
        /// Additional phone calling plans.
        /// </summary>
        [JsonProperty("plan_calling", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlanCalling> PlanCalling { get; set; }

        /// <summary>
        /// Additional phone number plans.
        /// </summary>
        [JsonProperty("plan_number", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlanNumber> PlanNumber { get; set; }
    }
}
