using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    internal class PollStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PollStatus) || t == typeof(PollStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ended":
                    return PollStatus.Ended;
                case "notstart":
                    return PollStatus.Notstart;
                case "sharing":
                    return PollStatus.Sharing;
                case "started":
                    return PollStatus.Started;
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
            var value = (PollStatus)untypedValue;
            switch (value)
            {
                case PollStatus.Ended:
                    serializer.Serialize(writer, "ended");
                    return;
                case PollStatus.Notstart:
                    serializer.Serialize(writer, "notstart");
                    return;
                case PollStatus.Sharing:
                    serializer.Serialize(writer, "sharing");
                    return;
                case PollStatus.Started:
                    serializer.Serialize(writer, "started");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly PollStatusConverter Singleton = new PollStatusConverter();
    }
}
