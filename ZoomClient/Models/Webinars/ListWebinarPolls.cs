using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace AndcultureCode.ZoomClient.Models.Webinars
{

    /// <summary>
    /// Poll List
    /// </summary>
    public partial class ListWebinarPolls
    {
        /// <summary>
        /// Array of Polls
        /// </summary>
        [JsonProperty("polls", NullValueHandling = NullValueHandling.Ignore)]
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// The number of all records available across pages
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRecords { get; set; }
    }

    /// <summary>
    /// Poll Question & Answer type:<br>`single` - Single choice<br>`mutliple` - Multiple choice
    /// </summary>
    public enum PollTypeEnum { Multiple, Single };

    /// <summary>
    /// Status of Poll:<br>`notstart` - Poll not started<br>`started` - Poll started<br>`ended` -
    /// Poll ended<br>`sharing` - Sharing poll results
    /// </summary>
    public enum Status { Ended, Notstart, Sharing, Started };


    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PollTypeEnum) || t == typeof(PollTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "multiple":
                    return PollTypeEnum.Multiple;
                case "single":
                    return PollTypeEnum.Single;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PollTypeEnum)untypedValue;
            switch (value)
            {
                case PollTypeEnum.Multiple:
                    serializer.Serialize(writer, "multiple");
                    return;
                case PollTypeEnum.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ended":
                    return Status.Ended;
                case "notstart":
                    return Status.Notstart;
                case "sharing":
                    return Status.Sharing;
                case "started":
                    return Status.Started;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Ended:
                    serializer.Serialize(writer, "ended");
                    return;
                case Status.Notstart:
                    serializer.Serialize(writer, "notstart");
                    return;
                case Status.Sharing:
                    serializer.Serialize(writer, "sharing");
                    return;
                case Status.Started:
                    serializer.Serialize(writer, "started");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
