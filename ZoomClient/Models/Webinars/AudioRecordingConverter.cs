using Newtonsoft.Json;
using System;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
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
