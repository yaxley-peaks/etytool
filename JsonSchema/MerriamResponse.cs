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
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hom")]
        public long? Hom { get; set; }

        [JsonPropertyName("hwi")]
        public Hwi Hwi { get; set; }

        [JsonPropertyName("fl")]
        public string Fl { get; set; }

        [JsonPropertyName("def")]
        public List<Def> Def { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("et")]
        public List<List<string>> Et { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("shortdef")]
        public List<string> Shortdef { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vrs")]
        public List<Vr> Vrs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ins")]
        public List<In> Ins { get; set; }
    }

    public partial class Def
    {
        [JsonPropertyName("sseq")]
        public List<List<List<DefSseq>>> Sseq { get; set; }
    }

    public partial class PurpleSseq
    {
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonPropertyName("dt")]
        public List<List<StickyDt>> Dt { get; set; }
    }

    public partial class PurpleDt
    {
        [JsonPropertyName("t")]
        public string T { get; set; }
    }

    public partial class FluffySseq
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonPropertyName("dt")]
        public List<List<IndecentDt>> Dt { get; set; }
    }

    public partial class FluffyDt
    {
        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("aq")]
        public Aq Aq { get; set; }
    }

    public partial class Aq
    {
        [JsonPropertyName("auth")]
        public string Auth { get; set; }
    }

    public partial class Hwi
    {
        [JsonPropertyName("hw")]
        public string Hw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("prs")]
        public List<HwiPr> Prs { get; set; }
    }

    public partial class HwiPr
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("l")]
        public string L { get; set; }

        [JsonPropertyName("mw")]
        public string Mw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sound")]
        public Sound Sound { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("pun")]
        public string Pun { get; set; }
    }

    public partial class Sound
    {
        [JsonPropertyName("audio")]
        public string Audio { get; set; }

        [JsonPropertyName("ref")]
        public string Ref { get; set; }

        [JsonPropertyName("stat")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Stat { get; set; }
    }

    public partial class In
    {
        [JsonPropertyName("il")]
        public string Il { get; set; }

        [JsonPropertyName("if")]
        public string If { get; set; }

        [JsonPropertyName("prs")]
        public List<InPr> Prs { get; set; }
    }

    public partial class InPr
    {
        [JsonPropertyName("mw")]
        public string Mw { get; set; }

        [JsonPropertyName("sound")]
        public Sound Sound { get; set; }
    }

    public partial class Meta
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        [JsonPropertyName("src")]
        public Src Src { get; set; }

        [JsonPropertyName("section")]
        public Section Section { get; set; }

        [JsonPropertyName("stems")]
        public List<string> Stems { get; set; }

        [JsonPropertyName("offensive")]
        public bool Offensive { get; set; }
    }

    public partial class Vr
    {
        [JsonPropertyName("vl")]
        public string Vl { get; set; }

        [JsonPropertyName("va")]
        public string Va { get; set; }
    }

    public enum SseqEnum { Pseq, Sense };

    public enum Section { Alpha, Geog, Idioms };

    public enum Src { Collegiate, Ld };

    public partial struct TentacledDt
    {
        public List<PurpleDt> PurpleDtArray;
        public string String;

        public static implicit operator TentacledDt(List<PurpleDt> PurpleDtArray) => new TentacledDt { PurpleDtArray = PurpleDtArray };
        public static implicit operator TentacledDt(string String) => new TentacledDt { String = String };
    }

    public partial struct StickyDt
    {
        public List<List<List<TentacledDt>>> AnythingArrayArrayArray;
        public string String;

        public static implicit operator StickyDt(List<List<List<TentacledDt>>> AnythingArrayArrayArray) => new StickyDt { AnythingArrayArrayArray = AnythingArrayArrayArray };
        public static implicit operator StickyDt(string String) => new StickyDt { String = String };
    }

    public partial struct SseqSseqUnion
    {
        public SseqEnum? Enum;
        public PurpleSseq PurpleSseq;

        public static implicit operator SseqSseqUnion(SseqEnum Enum) => new SseqSseqUnion { Enum = Enum };
        public static implicit operator SseqSseqUnion(PurpleSseq PurpleSseq) => new SseqSseqUnion { PurpleSseq = PurpleSseq };
    }

    public partial struct IndigoDt
    {
        public List<List<TentacledDt>> AnythingArrayArray;
        public FluffyDt FluffyDt;

        public static implicit operator IndigoDt(List<List<TentacledDt>> AnythingArrayArray) => new IndigoDt { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator IndigoDt(FluffyDt FluffyDt) => new IndigoDt { FluffyDt = FluffyDt };
    }

    public partial struct IndecentDt
    {
        public List<IndigoDt> AnythingArray;
        public string String;

        public static implicit operator IndecentDt(List<IndigoDt> AnythingArray) => new IndecentDt { AnythingArray = AnythingArray };
        public static implicit operator IndecentDt(string String) => new IndecentDt { String = String };
    }

    public partial struct DefSseq
    {
        public List<List<SseqSseqUnion>> AnythingArrayArray;
        public SseqEnum? Enum;
        public FluffySseq FluffySseq;

        public static implicit operator DefSseq(List<List<SseqSseqUnion>> AnythingArrayArray) => new DefSseq { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator DefSseq(SseqEnum Enum) => new DefSseq { Enum = Enum };
        public static implicit operator DefSseq(FluffySseq FluffySseq) => new DefSseq { FluffySseq = FluffySseq };
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
                DefSseqConverter.Singleton,
                SseqSseqUnionConverter.Singleton,
                StickyDtConverter.Singleton,
                TentacledDtConverter.Singleton,
                SseqEnumConverter.Singleton,
                IndecentDtConverter.Singleton,
                IndigoDtConverter.Singleton,
                SectionConverter.Singleton,
                SrcConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class DefSseqConverter : JsonConverter<DefSseq>
    {
        public override bool CanConvert(Type t) => t == typeof(DefSseq);

        public override DefSseq Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    switch (stringValue)
                    {
                        case "pseq":
                            return new DefSseq { Enum = SseqEnum.Pseq };
                        case "sense":
                            return new DefSseq { Enum = SseqEnum.Sense };
                    }
                    break;
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<FluffySseq>(ref reader, options);
                    return new DefSseq { FluffySseq = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<List<SseqSseqUnion>>>(ref reader, options);
                    return new DefSseq { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DefSseq");
        }

        public override void Write(Utf8JsonWriter writer, DefSseq value, JsonSerializerOptions options)
        {
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SseqEnum.Pseq:
                        JsonSerializer.Serialize(writer, "pseq", options);
                        return;
                    case SseqEnum.Sense:
                        JsonSerializer.Serialize(writer, "sense", options);
                        return;
                }
            }
            if (value.AnythingArrayArray != null)
            {
                JsonSerializer.Serialize(writer, value.AnythingArrayArray, options);
                return;
            }
            if (value.FluffySseq != null)
            {
                JsonSerializer.Serialize(writer, value.FluffySseq, options);
                return;
            }
            throw new Exception("Cannot marshal type DefSseq");
        }

        public static readonly DefSseqConverter Singleton = new DefSseqConverter();
    }

    internal class SseqSseqUnionConverter : JsonConverter<SseqSseqUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(SseqSseqUnion);

        public override SseqSseqUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    switch (stringValue)
                    {
                        case "pseq":
                            return new SseqSseqUnion { Enum = SseqEnum.Pseq };
                        case "sense":
                            return new SseqSseqUnion { Enum = SseqEnum.Sense };
                    }
                    break;
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<PurpleSseq>(ref reader, options);
                    return new SseqSseqUnion { PurpleSseq = objectValue };
            }
            throw new Exception("Cannot unmarshal type SseqSseqUnion");
        }

        public override void Write(Utf8JsonWriter writer, SseqSseqUnion value, JsonSerializerOptions options)
        {
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SseqEnum.Pseq:
                        JsonSerializer.Serialize(writer, "pseq", options);
                        return;
                    case SseqEnum.Sense:
                        JsonSerializer.Serialize(writer, "sense", options);
                        return;
                }
            }
            if (value.PurpleSseq != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleSseq, options);
                return;
            }
            throw new Exception("Cannot marshal type SseqSseqUnion");
        }

        public static readonly SseqSseqUnionConverter Singleton = new SseqSseqUnionConverter();
    }

    internal class StickyDtConverter : JsonConverter<StickyDt>
    {
        public override bool CanConvert(Type t) => t == typeof(StickyDt);

        public override StickyDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new StickyDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<List<List<TentacledDt>>>>(ref reader, options);
                    return new StickyDt { AnythingArrayArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StickyDt");
        }

        public override void Write(Utf8JsonWriter writer, StickyDt value, JsonSerializerOptions options)
        {
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            if (value.AnythingArrayArrayArray != null)
            {
                JsonSerializer.Serialize(writer, value.AnythingArrayArrayArray, options);
                return;
            }
            throw new Exception("Cannot marshal type StickyDt");
        }

        public static readonly StickyDtConverter Singleton = new StickyDtConverter();
    }

    internal class TentacledDtConverter : JsonConverter<TentacledDt>
    {
        public override bool CanConvert(Type t) => t == typeof(TentacledDt);

        public override TentacledDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new TentacledDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleDt>>(ref reader, options);
                    return new TentacledDt { PurpleDtArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TentacledDt");
        }

        public override void Write(Utf8JsonWriter writer, TentacledDt value, JsonSerializerOptions options)
        {
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            if (value.PurpleDtArray != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleDtArray, options);
                return;
            }
            throw new Exception("Cannot marshal type TentacledDt");
        }

        public static readonly TentacledDtConverter Singleton = new TentacledDtConverter();
    }

    internal class SseqEnumConverter : JsonConverter<SseqEnum>
    {
        public override bool CanConvert(Type t) => t == typeof(SseqEnum);

        public override SseqEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "pseq":
                    return SseqEnum.Pseq;
                case "sense":
                    return SseqEnum.Sense;
            }
            throw new Exception("Cannot unmarshal type SseqEnum");
        }

        public override void Write(Utf8JsonWriter writer, SseqEnum value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case SseqEnum.Pseq:
                    JsonSerializer.Serialize(writer, "pseq", options);
                    return;
                case SseqEnum.Sense:
                    JsonSerializer.Serialize(writer, "sense", options);
                    return;
            }
            throw new Exception("Cannot marshal type SseqEnum");
        }

        public static readonly SseqEnumConverter Singleton = new SseqEnumConverter();
    }

    internal class IndecentDtConverter : JsonConverter<IndecentDt>
    {
        public override bool CanConvert(Type t) => t == typeof(IndecentDt);

        public override IndecentDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new IndecentDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<IndigoDt>>(ref reader, options);
                    return new IndecentDt { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndecentDt");
        }

        public override void Write(Utf8JsonWriter writer, IndecentDt value, JsonSerializerOptions options)
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
            throw new Exception("Cannot marshal type IndecentDt");
        }

        public static readonly IndecentDtConverter Singleton = new IndecentDtConverter();
    }

    internal class IndigoDtConverter : JsonConverter<IndigoDt>
    {
        public override bool CanConvert(Type t) => t == typeof(IndigoDt);

        public override IndigoDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<FluffyDt>(ref reader, options);
                    return new IndigoDt { FluffyDt = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<List<TentacledDt>>>(ref reader, options);
                    return new IndigoDt { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndigoDt");
        }

        public override void Write(Utf8JsonWriter writer, IndigoDt value, JsonSerializerOptions options)
        {
            if (value.AnythingArrayArray != null)
            {
                JsonSerializer.Serialize(writer, value.AnythingArrayArray, options);
                return;
            }
            if (value.FluffyDt != null)
            {
                JsonSerializer.Serialize(writer, value.FluffyDt, options);
                return;
            }
            throw new Exception("Cannot marshal type IndigoDt");
        }

        public static readonly IndigoDtConverter Singleton = new IndigoDtConverter();
    }

    internal class ParseStringConverter : JsonConverter<long>
    {
        public override bool CanConvert(Type t) => t == typeof(long);

        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class SectionConverter : JsonConverter<Section>
    {
        public override bool CanConvert(Type t) => t == typeof(Section);

        public override Section Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "alpha":
                    return Section.Alpha;
                case "geog":
                    return Section.Geog;
                case "idioms":
                    return Section.Idioms;
            }
            throw new Exception("Cannot unmarshal type Section");
        }

        public override void Write(Utf8JsonWriter writer, Section value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Section.Alpha:
                    JsonSerializer.Serialize(writer, "alpha", options);
                    return;
                case Section.Geog:
                    JsonSerializer.Serialize(writer, "geog", options);
                    return;
                case Section.Idioms:
                    JsonSerializer.Serialize(writer, "idioms", options);
                    return;
            }
            throw new Exception("Cannot marshal type Section");
        }

        public static readonly SectionConverter Singleton = new SectionConverter();
    }

    internal class SrcConverter : JsonConverter<Src>
    {
        public override bool CanConvert(Type t) => t == typeof(Src);

        public override Src Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "collegiate":
                    return Src.Collegiate;
                case "ld":
                    return Src.Ld;
            }
            throw new Exception("Cannot unmarshal type Src");
        }

        public override void Write(Utf8JsonWriter writer, Src value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Src.Collegiate:
                    JsonSerializer.Serialize(writer, "collegiate", options);
                    return;
                case Src.Ld:
                    JsonSerializer.Serialize(writer, "ld", options);
                    return;
            }
            throw new Exception("Cannot marshal type Src");
        }

        public static readonly SrcConverter Singleton = new SrcConverter();
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
