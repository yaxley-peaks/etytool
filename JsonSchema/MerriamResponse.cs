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

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fl")]
        public string Fl { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ins")]
        public List<In> Ins { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("def")]
        public List<MerriamResponseDef> Def { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("dros")]
        public List<Dro> Dros { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("et")]
        public List<List<string>> Et { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("shortdef")]
        public List<string> Shortdef { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("cxs")]
        public List<Cx> Cxs { get; set; }
    }

    public partial class Cx
    {
        [JsonPropertyName("cxl")]
        public string Cxl { get; set; }

        [JsonPropertyName("cxtis")]
        public List<Cxti> Cxtis { get; set; }
    }

    public partial class Cxti
    {
        [JsonPropertyName("cxt")]
        public string Cxt { get; set; }
    }

    public partial class MerriamResponseDef
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vd")]
        public string Vd { get; set; }

        [JsonPropertyName("sseq")]
        public List<List<List<StickySseq>>> Sseq { get; set; }
    }

    public partial class PurpleSseq
    {
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonPropertyName("dt")]
        public List<List<SdsenseDt>> Dt { get; set; }
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

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("dt")]
        public List<List<HilariousDt>> Dt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sdsense")]
        public PurpleSdsense Sdsense { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sls")]
        public List<string> Sls { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vrs")]
        public List<SseqVr> Vrs { get; set; }
    }

    public partial class FluffyDt
    {
        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("aq")]
        public PurpleAq Aq { get; set; }
    }

    public partial class PurpleAq
    {
        [JsonPropertyName("auth")]
        public string Auth { get; set; }
    }

    public partial class TentacledDt
    {
        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("aq")]
        public FluffyAq Aq { get; set; }
    }

    public partial class FluffyAq
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("auth")]
        public string Auth { get; set; }
    }

    public partial class StickyDt
    {
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        [JsonPropertyName("cats")]
        public List<Cat> Cats { get; set; }
    }

    public partial class Cat
    {
        [JsonPropertyName("cat")]
        public string CatCat { get; set; }
    }

    public partial class PurpleSdsense
    {
        [JsonPropertyName("sd")]
        public string Sd { get; set; }

        [JsonPropertyName("dt")]
        public List<List<string>> Dt { get; set; }
    }

    public partial class SseqVr
    {
        [JsonPropertyName("vl")]
        public string Vl { get; set; }

        [JsonPropertyName("va")]
        public string Va { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("prs")]
        public List<Pr> Prs { get; set; }
    }

    public partial class Pr
    {
        [JsonPropertyName("mw")]
        public string Mw { get; set; }

        [JsonPropertyName("sound")]
        public Sound Sound { get; set; }
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

    public partial class Dro
    {
        [JsonPropertyName("drp")]
        public string Drp { get; set; }

        [JsonPropertyName("def")]
        public List<DroDef> Def { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("vrs")]
        public List<DroVr> Vrs { get; set; }
    }

    public partial class DroDef
    {
        [JsonPropertyName("sseq")]
        public List<List<List<IndigoSseq>>> Sseq { get; set; }
    }

    public partial class TentacledSseq
    {
        [JsonPropertyName("dt")]
        public List<List<IndigoDt>> Dt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sn")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Sn { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sdsense")]
        public FluffySdsense Sdsense { get; set; }
    }

    public partial class FluffySdsense
    {
        [JsonPropertyName("sd")]
        public string Sd { get; set; }

        [JsonPropertyName("dt")]
        public List<List<SdsenseDt>> Dt { get; set; }
    }

    public partial class DroVr
    {
        [JsonPropertyName("vl")]
        public string Vl { get; set; }

        [JsonPropertyName("va")]
        public string Va { get; set; }
    }

    public partial class Hwi
    {
        [JsonPropertyName("hw")]
        public string Hw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("prs")]
        public List<Pr> Prs { get; set; }
    }

    public partial class In
    {
        [JsonPropertyName("if")]
        public string If { get; set; }
    }

    public partial class Meta
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("sort")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Sort { get; set; }

        [JsonPropertyName("src")]
        public Src Src { get; set; }

        [JsonPropertyName("section")]
        public Section Section { get; set; }

        [JsonPropertyName("stems")]
        public List<string> Stems { get; set; }

        [JsonPropertyName("offensive")]
        public bool Offensive { get; set; }
    }

    public enum SseqEnum { Pseq, Sen, Sense };

    public enum Section { Alpha };

    public enum Src { Collegiate };

    public partial struct SdsenseDt
    {
        public List<PurpleDt> PurpleDtArray;
        public string String;

        public static implicit operator SdsenseDt(List<PurpleDt> PurpleDtArray) => new SdsenseDt { PurpleDtArray = PurpleDtArray };
        public static implicit operator SdsenseDt(string String) => new SdsenseDt { String = String };
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
        public List<FluffyDt> FluffyDtArray;
        public string String;

        public static implicit operator IndigoDt(List<FluffyDt> FluffyDtArray) => new IndigoDt { FluffyDtArray = FluffyDtArray };
        public static implicit operator IndigoDt(string String) => new IndigoDt { String = String };
    }

    public partial struct IndecentDt
    {
        public List<List<IndigoDt>> AnythingArrayArray;
        public TentacledDt TentacledDt;

        public static implicit operator IndecentDt(List<List<IndigoDt>> AnythingArrayArray) => new IndecentDt { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator IndecentDt(TentacledDt TentacledDt) => new IndecentDt { TentacledDt = TentacledDt };
    }

    public partial struct HilariousDt
    {
        public List<IndecentDt> AnythingArray;
        public StickyDt StickyDt;
        public string String;

        public static implicit operator HilariousDt(List<IndecentDt> AnythingArray) => new HilariousDt { AnythingArray = AnythingArray };
        public static implicit operator HilariousDt(StickyDt StickyDt) => new HilariousDt { StickyDt = StickyDt };
        public static implicit operator HilariousDt(string String) => new HilariousDt { String = String };
    }

    public partial struct StickySseq
    {
        public List<List<SseqSseqUnion>> AnythingArrayArray;
        public SseqEnum? Enum;
        public FluffySseq FluffySseq;

        public static implicit operator StickySseq(List<List<SseqSseqUnion>> AnythingArrayArray) => new StickySseq { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator StickySseq(SseqEnum Enum) => new StickySseq { Enum = Enum };
        public static implicit operator StickySseq(FluffySseq FluffySseq) => new StickySseq { FluffySseq = FluffySseq };
    }

    public partial struct IndigoSseq
    {
        public SseqEnum? Enum;
        public TentacledSseq TentacledSseq;

        public static implicit operator IndigoSseq(SseqEnum Enum) => new IndigoSseq { Enum = Enum };
        public static implicit operator IndigoSseq(TentacledSseq TentacledSseq) => new IndigoSseq { TentacledSseq = TentacledSseq };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                StickySseqConverter.Singleton,
                SseqSseqUnionConverter.Singleton,
                SdsenseDtConverter.Singleton,
                SseqEnumConverter.Singleton,
                HilariousDtConverter.Singleton,
                IndecentDtConverter.Singleton,
                IndigoDtConverter.Singleton,
                IndigoSseqConverter.Singleton,
                SectionConverter.Singleton,
                SrcConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class StickySseqConverter : JsonConverter<StickySseq>
    {
        public override bool CanConvert(Type t) => t == typeof(StickySseq);

        public override StickySseq Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    switch (stringValue)
                    {
                        case "pseq":
                            return new StickySseq { Enum = SseqEnum.Pseq };
                        case "sen":
                            return new StickySseq { Enum = SseqEnum.Sen };
                        case "sense":
                            return new StickySseq { Enum = SseqEnum.Sense };
                    }
                    break;
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<FluffySseq>(ref reader, options);
                    return new StickySseq { FluffySseq = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<List<SseqSseqUnion>>>(ref reader, options);
                    return new StickySseq { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StickySseq");
        }

        public override void Write(Utf8JsonWriter writer, StickySseq value, JsonSerializerOptions options)
        {
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SseqEnum.Pseq:
                        JsonSerializer.Serialize(writer, "pseq", options);
                        return;
                    case SseqEnum.Sen:
                        JsonSerializer.Serialize(writer, "sen", options);
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
            throw new Exception("Cannot marshal type StickySseq");
        }

        public static readonly StickySseqConverter Singleton = new StickySseqConverter();
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
                        case "sen":
                            return new SseqSseqUnion { Enum = SseqEnum.Sen };
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
                    case SseqEnum.Sen:
                        JsonSerializer.Serialize(writer, "sen", options);
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

    internal class SdsenseDtConverter : JsonConverter<SdsenseDt>
    {
        public override bool CanConvert(Type t) => t == typeof(SdsenseDt);

        public override SdsenseDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new SdsenseDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleDt>>(ref reader, options);
                    return new SdsenseDt { PurpleDtArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SdsenseDt");
        }

        public override void Write(Utf8JsonWriter writer, SdsenseDt value, JsonSerializerOptions options)
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
            throw new Exception("Cannot marshal type SdsenseDt");
        }

        public static readonly SdsenseDtConverter Singleton = new SdsenseDtConverter();
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
                case "sen":
                    return SseqEnum.Sen;
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
                case SseqEnum.Sen:
                    JsonSerializer.Serialize(writer, "sen", options);
                    return;
                case SseqEnum.Sense:
                    JsonSerializer.Serialize(writer, "sense", options);
                    return;
            }
            throw new Exception("Cannot marshal type SseqEnum");
        }

        public static readonly SseqEnumConverter Singleton = new SseqEnumConverter();
    }

    internal class HilariousDtConverter : JsonConverter<HilariousDt>
    {
        public override bool CanConvert(Type t) => t == typeof(HilariousDt);

        public override HilariousDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new HilariousDt { String = stringValue };
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<StickyDt>(ref reader, options);
                    return new HilariousDt { StickyDt = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<IndecentDt>>(ref reader, options);
                    return new HilariousDt { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type HilariousDt");
        }

        public override void Write(Utf8JsonWriter writer, HilariousDt value, JsonSerializerOptions options)
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
            if (value.StickyDt != null)
            {
                JsonSerializer.Serialize(writer, value.StickyDt, options);
                return;
            }
            throw new Exception("Cannot marshal type HilariousDt");
        }

        public static readonly HilariousDtConverter Singleton = new HilariousDtConverter();
    }

    internal class IndecentDtConverter : JsonConverter<IndecentDt>
    {
        public override bool CanConvert(Type t) => t == typeof(IndecentDt);

        public override IndecentDt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<TentacledDt>(ref reader, options);
                    return new IndecentDt { TentacledDt = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<List<IndigoDt>>>(ref reader, options);
                    return new IndecentDt { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndecentDt");
        }

        public override void Write(Utf8JsonWriter writer, IndecentDt value, JsonSerializerOptions options)
        {
            if (value.AnythingArrayArray != null)
            {
                JsonSerializer.Serialize(writer, value.AnythingArrayArray, options);
                return;
            }
            if (value.TentacledDt != null)
            {
                JsonSerializer.Serialize(writer, value.TentacledDt, options);
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
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new IndigoDt { String = stringValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<FluffyDt>>(ref reader, options);
                    return new IndigoDt { FluffyDtArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndigoDt");
        }

        public override void Write(Utf8JsonWriter writer, IndigoDt value, JsonSerializerOptions options)
        {
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            if (value.FluffyDtArray != null)
            {
                JsonSerializer.Serialize(writer, value.FluffyDtArray, options);
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

    internal class IndigoSseqConverter : JsonConverter<IndigoSseq>
    {
        public override bool CanConvert(Type t) => t == typeof(IndigoSseq);

        public override IndigoSseq Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    switch (stringValue)
                    {
                        case "pseq":
                            return new IndigoSseq { Enum = SseqEnum.Pseq };
                        case "sen":
                            return new IndigoSseq { Enum = SseqEnum.Sen };
                        case "sense":
                            return new IndigoSseq { Enum = SseqEnum.Sense };
                    }
                    break;
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<TentacledSseq>(ref reader, options);
                    return new IndigoSseq { TentacledSseq = objectValue };
            }
            throw new Exception("Cannot unmarshal type IndigoSseq");
        }

        public override void Write(Utf8JsonWriter writer, IndigoSseq value, JsonSerializerOptions options)
        {
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SseqEnum.Pseq:
                        JsonSerializer.Serialize(writer, "pseq", options);
                        return;
                    case SseqEnum.Sen:
                        JsonSerializer.Serialize(writer, "sen", options);
                        return;
                    case SseqEnum.Sense:
                        JsonSerializer.Serialize(writer, "sense", options);
                        return;
                }
            }
            if (value.TentacledSseq != null)
            {
                JsonSerializer.Serialize(writer, value.TentacledSseq, options);
                return;
            }
            throw new Exception("Cannot marshal type IndigoSseq");
        }

        public static readonly IndigoSseqConverter Singleton = new IndigoSseqConverter();
    }

    internal class SectionConverter : JsonConverter<Section>
    {
        public override bool CanConvert(Type t) => t == typeof(Section);

        public override Section Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "alpha")
            {
                return Section.Alpha;
            }
            throw new Exception("Cannot unmarshal type Section");
        }

        public override void Write(Utf8JsonWriter writer, Section value, JsonSerializerOptions options)
        {
            if (value == Section.Alpha)
            {
                JsonSerializer.Serialize(writer, "alpha", options);
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
            if (value == "collegiate")
            {
                return Src.Collegiate;
            }
            throw new Exception("Cannot unmarshal type Src");
        }

        public override void Write(Utf8JsonWriter writer, Src value, JsonSerializerOptions options)
        {
            if (value == Src.Collegiate)
            {
                JsonSerializer.Serialize(writer, "collegiate", options);
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
