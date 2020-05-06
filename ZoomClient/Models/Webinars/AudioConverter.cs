using Newtonsoft.Json;
using System;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
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
}
