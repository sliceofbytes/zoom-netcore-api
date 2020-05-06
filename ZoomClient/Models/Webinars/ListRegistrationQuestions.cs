using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace AndcultureCode.ZoomClient.Models.Webinars
{


    /// <summary>
    /// Webinar Registrant Questions
    /// </summary>
    public partial class ListRegistrationQuestions
    {
        /// <summary>
        /// Array of Registrant Custom Questions.
        /// </summary>
        [JsonProperty("custom_questions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomRegistrationQuestion> CustomQuestions { get; set; }

        /// <summary>
        /// Array of registration fields whose values should be provided by registrants during
        /// registration.
        /// </summary>
        [JsonProperty("questions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegistrationQuestion> Questions { get; set; }
    }

    /// <summary>
    /// The question-answer type.
    /// </summary>
    public enum QuestionTypeEnum { Multiple, Short, SingleDropdown, SingleRadio };

    /// <summary>
    /// Field name
    /// </summary>
    public enum FieldName { Address, City, Comments, Country, Industry, JobTitle, LastName, NoOfEmployees, Org, Phone, PurchasingTimeFrame, RoleInPurchaseProcess, State, Zip };

    public partial struct CustomRegistrationQuestion
    {
        public List<object> AnythingArray;
        public bool? Bool;
        public CustomQuestionClass CustomQuestionClass;
        public double? Double;
        public long? Integer;
        public string String;

        public static implicit operator CustomRegistrationQuestion(List<object> AnythingArray) => new CustomRegistrationQuestion { AnythingArray = AnythingArray };
        public static implicit operator CustomRegistrationQuestion(bool Bool) => new CustomRegistrationQuestion { Bool = Bool };
        public static implicit operator CustomRegistrationQuestion(CustomQuestionClass CustomQuestionClass) => new CustomRegistrationQuestion { CustomQuestionClass = CustomQuestionClass };
        public static implicit operator CustomRegistrationQuestion(double Double) => new CustomRegistrationQuestion { Double = Double };
        public static implicit operator CustomRegistrationQuestion(long Integer) => new CustomRegistrationQuestion { Integer = Integer };
        public static implicit operator CustomRegistrationQuestion(string String) => new CustomRegistrationQuestion { String = String };
        public bool IsNull => AnythingArray == null && Bool == null && CustomQuestionClass == null && Double == null && Integer == null && String == null;
    }

    public partial struct RegistrationQuestion
    {
        public List<object> AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public RegistrationQuestionClass QuestionClass;
        public string String;

        public static implicit operator RegistrationQuestion(List<object> AnythingArray) => new RegistrationQuestion { AnythingArray = AnythingArray };
        public static implicit operator RegistrationQuestion(bool Bool) => new RegistrationQuestion { Bool = Bool };
        public static implicit operator RegistrationQuestion(double Double) => new RegistrationQuestion { Double = Double };
        public static implicit operator RegistrationQuestion(long Integer) => new RegistrationQuestion { Integer = Integer };
        public static implicit operator RegistrationQuestion(RegistrationQuestionClass QuestionClass) => new RegistrationQuestion { QuestionClass = QuestionClass };
        public static implicit operator RegistrationQuestion(string String) => new RegistrationQuestion { String = String };
        public bool IsNull => AnythingArray == null && Bool == null && QuestionClass == null && Double == null && Integer == null && String == null;
    }

    public partial class RegistrationQuestionClass
    {
        /// <summary>
        /// Field name
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public FieldName? FieldName { get; set; }

        /// <summary>
        /// State whether the selected fields are required or optional.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuestionRequired { get; set; }
    }

    internal static class ListRegistrationQuestionsConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CustomQuestionElementConverter.Singleton,
                QuestionTypeEnumConverter.Singleton,
                QuestionElementConverter.Singleton,
                FieldNameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CustomQuestionElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CustomRegistrationQuestion) || t == typeof(CustomRegistrationQuestion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new CustomRegistrationQuestion { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new CustomRegistrationQuestion { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new CustomRegistrationQuestion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new CustomRegistrationQuestion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CustomRegistrationQuestion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CustomQuestionClass>(reader);
                    return new CustomRegistrationQuestion { CustomQuestionClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new CustomRegistrationQuestion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CustomQuestionElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CustomRegistrationQuestion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.CustomQuestionClass != null)
            {
                serializer.Serialize(writer, value.CustomQuestionClass);
                return;
            }
            throw new Exception("Cannot marshal type CustomQuestionElement");
        }

        public static readonly CustomQuestionElementConverter Singleton = new CustomQuestionElementConverter();
    }

    internal class QuestionTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QuestionTypeEnum) || t == typeof(QuestionTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "multiple":
                    return QuestionTypeEnum.Multiple;
                case "short":
                    return QuestionTypeEnum.Short;
                case "single_dropdown":
                    return QuestionTypeEnum.SingleDropdown;
                case "single_radio":
                    return QuestionTypeEnum.SingleRadio;
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
            var value = (QuestionTypeEnum)untypedValue;
            switch (value)
            {
                case QuestionTypeEnum.Multiple:
                    serializer.Serialize(writer, "multiple");
                    return;
                case QuestionTypeEnum.Short:
                    serializer.Serialize(writer, "short");
                    return;
                case QuestionTypeEnum.SingleDropdown:
                    serializer.Serialize(writer, "single_dropdown");
                    return;
                case QuestionTypeEnum.SingleRadio:
                    serializer.Serialize(writer, "single_radio");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly QuestionTypeEnumConverter Singleton = new QuestionTypeEnumConverter();
    }

    internal class QuestionElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RegistrationQuestion) || t == typeof(RegistrationQuestion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new RegistrationQuestion { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new RegistrationQuestion { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new RegistrationQuestion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new RegistrationQuestion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RegistrationQuestion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RegistrationQuestionClass>(reader);
                    return new RegistrationQuestion { QuestionClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new RegistrationQuestion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type QuestionElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RegistrationQuestion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.QuestionClass != null)
            {
                serializer.Serialize(writer, value.QuestionClass);
                return;
            }
            throw new Exception("Cannot marshal type QuestionElement");
        }

        public static readonly QuestionElementConverter Singleton = new QuestionElementConverter();
    }

    internal class FieldNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FieldName) || t == typeof(FieldName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "address":
                    return FieldName.Address;
                case "city":
                    return FieldName.City;
                case "comments":
                    return FieldName.Comments;
                case "country":
                    return FieldName.Country;
                case "industry":
                    return FieldName.Industry;
                case "job_title":
                    return FieldName.JobTitle;
                case "last_name":
                    return FieldName.LastName;
                case "no_of_employees":
                    return FieldName.NoOfEmployees;
                case "org":
                    return FieldName.Org;
                case "phone":
                    return FieldName.Phone;
                case "purchasing_time_frame":
                    return FieldName.PurchasingTimeFrame;
                case "role_in_purchase_process":
                    return FieldName.RoleInPurchaseProcess;
                case "state":
                    return FieldName.State;
                case "zip":
                    return FieldName.Zip;
            }
            throw new Exception("Cannot unmarshal type FieldName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FieldName)untypedValue;
            switch (value)
            {
                case FieldName.Address:
                    serializer.Serialize(writer, "address");
                    return;
                case FieldName.City:
                    serializer.Serialize(writer, "city");
                    return;
                case FieldName.Comments:
                    serializer.Serialize(writer, "comments");
                    return;
                case FieldName.Country:
                    serializer.Serialize(writer, "country");
                    return;
                case FieldName.Industry:
                    serializer.Serialize(writer, "industry");
                    return;
                case FieldName.JobTitle:
                    serializer.Serialize(writer, "job_title");
                    return;
                case FieldName.LastName:
                    serializer.Serialize(writer, "last_name");
                    return;
                case FieldName.NoOfEmployees:
                    serializer.Serialize(writer, "no_of_employees");
                    return;
                case FieldName.Org:
                    serializer.Serialize(writer, "org");
                    return;
                case FieldName.Phone:
                    serializer.Serialize(writer, "phone");
                    return;
                case FieldName.PurchasingTimeFrame:
                    serializer.Serialize(writer, "purchasing_time_frame");
                    return;
                case FieldName.RoleInPurchaseProcess:
                    serializer.Serialize(writer, "role_in_purchase_process");
                    return;
                case FieldName.State:
                    serializer.Serialize(writer, "state");
                    return;
                case FieldName.Zip:
                    serializer.Serialize(writer, "zip");
                    return;
            }
            throw new Exception("Cannot marshal type FieldName");
        }

        public static readonly FieldNameConverter Singleton = new FieldNameConverter();
    }
}
