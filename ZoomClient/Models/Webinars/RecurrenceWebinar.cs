namespace AndcultureCode.ZoomClient.Models.Webinars
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Recurrence object. Use this object only for a webinar of type `9` i.e., a recurring
    /// webinar with fixed time.
    /// </summary>
    public partial class RecurrenceWebinar
    {
        /// <summary>
        /// Select a date when the webinar will recur before it is canceled. Should be in UTC time,
        /// such as 2017-11-25T12:00:00Z. (Cannot be used with "end_times".)
        /// </summary>
        [JsonProperty("end_date_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDateTime { get; set; }

        /// <summary>
        /// Select how many times the webinar will recur before it is canceled. (Cannot be used with
        /// "end_date_time".)
        /// </summary>
        [JsonProperty("end_times", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTimes { get; set; }

        /// <summary>
        /// Use this field **only if you're scheduling a recurring webinar of type** `3` to state
        /// which day in a month, the webinar should recur. The value range is from 1 to 31.
        ///
        /// For instance, if you would like the webinar to recur on 23rd of each month, provide `23`
        /// as the value of this field and `1` as the value of the `repeat_interval` field. Instead,
        /// if you would like the webinar to recur once every three months, on 23rd of the month,
        /// change the value of the `repeat_interval` field to `3`.
        /// </summary>
        [JsonProperty("monthly_day", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonthlyDay { get; set; }

        /// <summary>
        /// Use this field **only if you're scheduling a recurring webinar of type** `3` to state the
        /// week of the month when the webinar should recur. If you use this field, **you must also
        /// use the `monthly_week_day` field to state the day of the week when the webinar should
        /// recur.** <br>`-1` - Last week of the month.<br>`1` - First week of the month.<br>`2` -
        /// Second week of the month.<br>`3` - Third week of the month.<br>`4` - Fourth week of the
        /// month.
        /// </summary>
        [JsonProperty("monthly_week", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonthlyWeek { get; set; }

        /// <summary>
        /// Use this field **only if you're scheduling a recurring webinar of type** `3` to state a
        /// specific day in a week when the monthly webinar should recur. To use this field, you must
        /// also use the `monthly_week` field. <br>`1` - Sunday.<br>`2` - Monday.<br>`3` -
        /// Tuesday.<br>`4` -  Wednesday.<br>`5` - Thursday.<br>`6` - Friday.<br>`7` - Saturday.
        /// </summary>
        [JsonProperty("monthly_week_day", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonthlyWeekDay { get; set; }

        /// <summary>
        /// Define the interval at which the webinar should recur. For instance, if you would like to
        /// schedule a Webinar that recurs every two months, you must set the value of this field as
        /// `2` and the value of the `type` parameter as `3`.
        ///
        /// For a daily webinar, the maximum interval you can set is `90` days. For a weekly webinar,
        /// the maximum interval that you can set is `12` weeks. For a monthly webinar, the maximum
        /// interval that you can set is `3` months.
        /// </summary>
        [JsonProperty("repeat_interval", NullValueHandling = NullValueHandling.Ignore)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// Recurrence webinar types:<br>`1` - Daily.<br>`2` - Weekly.<br>`3` - Monthly.
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }

        /// <summary>
        /// Use this field **only if you're scheduling a recurring webinar of type** `2` to state
        /// which day(s) of the week the webinar should repeat. <br>
        /// **Note:** If you would like the webinar to occur on multiple days of a week, you should
        /// provide comma separated values for this field.<br>`1`  - Sunday. <br>`2` - Monday.<br>`3`
        /// - Tuesday.<br>`4` -  Wednesday.<br>`5` -  Thursday.<br>`6` - Friday.<br>`7` - Saturday.
        /// </summary>
        [JsonProperty("weekly_days", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeeklyDays { get; set; }
    }
}
