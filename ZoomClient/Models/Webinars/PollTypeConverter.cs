using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
    internal class PollTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PollType) || t == typeof(PollType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "multiple":
                    return PollType.Multiple;
                case "single":
                    return PollType.Single;
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
            var value = (PollType)untypedValue;
            switch (value)
            {
                case PollType.Multiple:
                    serializer.Serialize(writer, "multiple");
                    return;
                case PollType.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly PollTypeConverter Singleton = new PollTypeConverter();
    }
}
