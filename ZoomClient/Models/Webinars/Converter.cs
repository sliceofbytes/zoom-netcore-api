using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace AndcultureCode.ZoomClient.Models.Webinars
{
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
                CustomQuestionElementConverter.Singleton,
                QuestionTypeEnumConverter.Singleton,
                QuestionElementConverter.Singleton,
                FieldNameConverter.Singleton,
                PollTypeConverter.Singleton,
                PollStatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
