// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using EtyTool.JsonSchema;
//
//    var merriamResponse = MerriamResponse.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace EtyTool.JsonSchema
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class MerriamResponse
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hwi")]
        public Hwi Hwi { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vrs")]
        public List<Vr> Vrs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fl")]
        public string Fl { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ins")]
        public List<In> Ins { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("def")]
        public List<Def> Def { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("et")]
        public List<List<string>> Et { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("shortdef")]
        public List<string> Shortdef { get; set; }
    }

    public partial class Def
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sseq")]
        public List<List<List<SseqElement>>> Sseq { get; set; }
    }

    public partial class SseqClass
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("dt")]
        public List<List<SseqDt>> Dt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vrs")]
        public List<Vr> Vrs { get; set; }
    }

    public partial class DtClass
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("aq")]
        public Aq Aq { get; set; }
    }

    public partial class Aq
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("auth")]
        public string Auth { get; set; }
    }

    public partial class Vr
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vl")]
        public string Vl { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("va")]
        public string Va { get; set; }
    }

    public partial class Hwi
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hw")]
        public string Hw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("prs")]
        public List<Pr> Prs { get; set; }
    }

    public partial class Pr
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mw")]
        public string Mw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sound")]
        public Sound Sound { get; set; }
    }

    public partial class Sound
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("audio")]
        public string Audio { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ref")]
        public string Ref { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("stat")]
        public string Stat { get; set; }
    }

    public partial class In
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("il")]
        public string Il { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("if")]
        public string If { get; set; }
    }

    public partial class Meta
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("uuid")]
        public Guid? Uuid { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("section")]
        public string Section { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("stems")]
        public List<string> Stems { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("offensive")]
        public bool? Offensive { get; set; }
    }

    public partial struct DtDtUnion
    {
        public DtClass DtClass;
        public List<string> StringArray;

        public static implicit operator DtDtUnion(DtClass DtClass) => new DtDtUnion { DtClass = DtClass };
        public static implicit operator DtDtUnion(List<string> StringArray) => new DtDtUnion { StringArray = StringArray };
    }

    public partial struct SseqDt
    {
        public List<DtDtUnion> AnythingArray;
        public string String;

        public static implicit operator SseqDt(List<DtDtUnion> AnythingArray) => new SseqDt { AnythingArray = AnythingArray };
        public static implicit operator SseqDt(string String) => new SseqDt { String = String };
    }

    public partial struct SseqElement
    {
        public SseqClass SseqClass;
        public string String;

        public static implicit operator SseqElement(SseqClass SseqClass) => new SseqElement { SseqClass = SseqClass };
        public static implicit operator SseqElement(string String) => new SseqElement { String = String };
    }

    public partial class MerriamResponse
    {
        public static List<MerriamResponse> FromJson(string json) => JsonSerializer.Deserialize<List<MerriamResponse>>(json, EtyTool.JsonSchema.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<MerriamResponse> self) => JsonSerializer.Serialize(self, EtyTool.JsonSchema.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                SseqElementConverter.Singleton,
                SseqDtConverter.Singleton,
                DtDtUnionConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class SseqElementConverter : JsonConverter<SseqElement>
    {
        public override bool CanConvert(Type t) => t == typeof(SseqElement);

        public override SseqElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new SseqElement { String = stringValue };
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<SseqClass>(ref reader, options);
                    return new SseqElement { SseqClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type SseqElement");
        }

        public override void Write(Utf8JsonWriter writer, SseqElement value, JsonSerializerOptions options)
        {
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            if (value.SseqClass != null)
            {
                JsonSerializer.Serialize(writer, value.SseqClass, options);
                return;
            }
            throw new Exception("Cannot marshal type SseqElement");
        }

        public static readonly SseqElementConverter Singleton = new SseqElementConverter();
    }

    internal class SseqDtConverter : JsonConverter<SseqDt>
    {
        public override bool CanConvert(Type t) => t == typeof(SseqDt);

        public override SseqDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new SseqDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<DtDtUnion>>(ref reader, options);
                    return new SseqDt { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SseqDt");
        }

        public override void Write(Utf8JsonWriter writer, SseqDt value, JsonSerializerOptions options)
        {
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            if (value.AnythingArray != null)
            {
                JsonSerializer.Serialize(writer, value.AnythingArray, options);
                return;
            }
            throw new Exception("Cannot marshal type SseqDt");
        }

        public static readonly SseqDtConverter Singleton = new SseqDtConverter();
    }

    internal class DtDtUnionConverter : JsonConverter<DtDtUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(DtDtUnion);

        public override DtDtUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<DtClass>(ref reader, options);
                    return new DtDtUnion { DtClass = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<string>>(ref reader, options);
                    return new DtDtUnion { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DtDtUnion");
        }

        public override void Write(Utf8JsonWriter writer, DtDtUnion value, JsonSerializerOptions options)
        {
            if (value.StringArray != null)
            {
                JsonSerializer.Serialize(writer, value.StringArray, options);
                return;
            }
            if (value.DtClass != null)
            {
                JsonSerializer.Serialize(writer, value.DtClass, options);
                return;
            }
            throw new Exception("Cannot marshal type DtDtUnion");
        }

        public static readonly DtDtUnionConverter Singleton = new DtDtUnionConverter();
    }
    
    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
                this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
                var value = reader.GetString();
                return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
                this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
                var value = reader.GetString();
                return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
                get => _dateTimeStyles;
                set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
                get => _dateTimeFormat ?? string.Empty;
                set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
                get => _culture ?? CultureInfo.CurrentCulture;
                set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
                string text;


                if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                        || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                        value = value.ToUniversalTime();
                }

                text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

                writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
                string? dateText = reader.GetString();

                if (string.IsNullOrEmpty(dateText) == false)
                {
                        if (!string.IsNullOrEmpty(_dateTimeFormat))
                        {
                                return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                        }
                        else
                        {
                                return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                        }
                }
                else
                {
                        return default(DateTimeOffset);
                }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
