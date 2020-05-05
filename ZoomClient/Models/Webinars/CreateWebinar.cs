﻿namespace AndcultureCode.ZoomClient.Models.Webinars
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Webinar object.
    /// </summary>
    public partial class CreateWebinar
    {
        /// <summary>
        /// Webinar description.
        /// </summary>
        [JsonProperty("agenda", NullValueHandling = NullValueHandling.Ignore)]
        public string Agenda { get; set; }

        /// <summary>
        /// Webinar duration (minutes). Used for scheduled webinars only.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// Webinar password. Password may only contain the following characters: [a-z A-Z 0-9 @ - _
        /// * !]. Max of 10 characters.
        ///
        /// If "Require a password when scheduling new meetings" setting has been **enabled** **and**
        /// [locked](https://support.zoom.us/hc/en-us/articles/115005269866-Using-Tiered-Settings#locked)
        /// for the user, the password field will be autogenerated for the Webinar in the response
        /// even if it is not provided in the API request. <br><br>
        ///
        /// **Note:** If the account owner or the admin has configured [minimum password requirement
        /// settings](https://support.zoom.us/hc/en-us/articles/360033559832-Meeting-and-webinar-passwords#h_a427384b-e383-4f80-864d-794bf0a37604),
        /// the password value provided here must meet those requirements. <br><br>If the
        /// requirements are enabled, you can view those requirements by calling [Get Account
        /// Settings](https://marketplace.zoom.us/docs/api-reference/zoom-api/accounts/accountsettings)
        /// API.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// Recurrence object. Use this object only for a webinar of type `9` i.e., a recurring
        /// webinar with fixed time.
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public RecurrenceWebinar Recurrence { get; set; }

        /// <summary>
        /// Create Webinar settings.
        /// </summary>
        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public Settings Settings { get; set; }

        /// <summary>
        /// Webinar start time. We support two formats for `start_time` - local time and GMT.<br>
        ///
        /// To set time as GMT the format should be `yyyy-MM-dd`T`HH:mm:ssZ`.
        ///
        /// To set time using a specific timezone, use `yyyy-MM-dd`T`HH:mm:ss` format and specify the
        /// timezone
        /// [ID](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#timezones)
        /// in the `timezone` field OR leave it blank and the timezone set on your Zoom account will
        /// be used. You can also set the time as UTC as the timezone field.
        ///
        /// The `start_time` should only be used for scheduled and / or recurring webinars with fixed
        /// time.
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Time zone to format start_time. For example, "America/Los_Angeles". For scheduled
        /// meetings only. Please reference our
        /// [timezone](https://marketplace.zoom.us/docs/api-reference/other-references/abbreviation-lists#timezones)
        /// list for supported time zones and their formats.
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// Webinar topic.
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// Tracking fields
        /// </summary>
        [JsonProperty("tracking_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrackingField> TrackingFields { get; set; }

        /// <summary>
        /// Webinar Types:<br>`5` - Webinar.<br>`6` - Recurring webinar with no fixed time.<br>`9` -
        /// Recurring webinar with a fixed time.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AudioConverter.Singleton,
                AutoRecordingConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AudioConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Audio) || t == typeof(Audio?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "both":
                    return Audio.Both;
                case "telephony":
                    return Audio.Telephony;
                case "voip":
                    return Audio.Voip;
            }
            throw new Exception("Cannot unmarshal type Audio");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Audio)untypedValue;
            switch (value)
            {
                case Audio.Both:
                    serializer.Serialize(writer, "both");
                    return;
                case Audio.Telephony:
                    serializer.Serialize(writer, "telephony");
                    return;
                case Audio.Voip:
                    serializer.Serialize(writer, "voip");
                    return;
            }
            throw new Exception("Cannot marshal type Audio");
        }

        public static readonly AudioConverter Singleton = new AudioConverter();
    }

    internal class AutoRecordingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AutoRecording) || t == typeof(AutoRecording?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cloud":
                    return AutoRecording.Cloud;
                case "local":
                    return AutoRecording.Local;
                case "none":
                    return AutoRecording.None;
            }
            throw new Exception("Cannot unmarshal type AutoRecording");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AutoRecording)untypedValue;
            switch (value)
            {
                case AutoRecording.Cloud:
                    serializer.Serialize(writer, "cloud");
                    return;
                case AutoRecording.Local:
                    serializer.Serialize(writer, "local");
                    return;
                case AutoRecording.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type AutoRecording");
        }

        public static readonly AutoRecordingConverter Singleton = new AutoRecordingConverter();
    }
}
