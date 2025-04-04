// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterDialogSubtitleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterDialogSubtitleExcel GetRootAsCharacterDialogSubtitleExcel(ByteBuffer _bb) { return GetRootAsCharacterDialogSubtitleExcel(_bb, new CharacterDialogSubtitleExcel()); }
  public static CharacterDialogSubtitleExcel GetRootAsCharacterDialogSubtitleExcel(ByteBuffer _bb, CharacterDialogSubtitleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterDialogSubtitleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string LocalizeCVGroup { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCVGroupBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCVGroupBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLocalizeCVGroupArray() { return __p.__vector_as_array<byte>(4); }
  public long CharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string TLMID { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTLMIDBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTLMIDBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTLMIDArray() { return __p.__vector_as_array<byte>(8); }
  public long Duration { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DurationKr { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Separate { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string LocalizeKR { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(16); }
  public string LocalizeJP { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(18); }
  public string LocalizeTH { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTHBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTHBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetLocalizeTHArray() { return __p.__vector_as_array<byte>(20); }
  public string LocalizeTW { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTWBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTWBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetLocalizeTWArray() { return __p.__vector_as_array<byte>(22); }
  public string LocalizeEN { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeENBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetLocalizeENBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetLocalizeENArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<FlatDataGlobal.CharacterDialogSubtitleExcel> CreateCharacterDialogSubtitleExcel(FlatBufferBuilder builder,
      StringOffset LocalizeCVGroupOffset = default(StringOffset),
      long CharacterId = 0,
      StringOffset TLMIDOffset = default(StringOffset),
      long Duration = 0,
      long DurationKr = 0,
      bool Separate = false,
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      StringOffset LocalizeTHOffset = default(StringOffset),
      StringOffset LocalizeTWOffset = default(StringOffset),
      StringOffset LocalizeENOffset = default(StringOffset)) {
    builder.StartTable(11);
    CharacterDialogSubtitleExcel.AddDurationKr(builder, DurationKr);
    CharacterDialogSubtitleExcel.AddDuration(builder, Duration);
    CharacterDialogSubtitleExcel.AddCharacterId(builder, CharacterId);
    CharacterDialogSubtitleExcel.AddLocalizeEN(builder, LocalizeENOffset);
    CharacterDialogSubtitleExcel.AddLocalizeTW(builder, LocalizeTWOffset);
    CharacterDialogSubtitleExcel.AddLocalizeTH(builder, LocalizeTHOffset);
    CharacterDialogSubtitleExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogSubtitleExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogSubtitleExcel.AddTLMID(builder, TLMIDOffset);
    CharacterDialogSubtitleExcel.AddLocalizeCVGroup(builder, LocalizeCVGroupOffset);
    CharacterDialogSubtitleExcel.AddSeparate(builder, Separate);
    return CharacterDialogSubtitleExcel.EndCharacterDialogSubtitleExcel(builder);
  }

  public static void StartCharacterDialogSubtitleExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddLocalizeCVGroup(FlatBufferBuilder builder, StringOffset LocalizeCVGroupOffset) { builder.AddOffset(0, LocalizeCVGroupOffset.Value, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(1, CharacterId, 0); }
  public static void AddTLMID(FlatBufferBuilder builder, StringOffset TLMIDOffset) { builder.AddOffset(2, TLMIDOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(3, Duration, 0); }
  public static void AddDurationKr(FlatBufferBuilder builder, long DurationKr) { builder.AddLong(4, DurationKr, 0); }
  public static void AddSeparate(FlatBufferBuilder builder, bool Separate) { builder.AddBool(5, Separate, false); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(6, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(7, LocalizeJPOffset.Value, 0); }
  public static void AddLocalizeTH(FlatBufferBuilder builder, StringOffset LocalizeTHOffset) { builder.AddOffset(8, LocalizeTHOffset.Value, 0); }
  public static void AddLocalizeTW(FlatBufferBuilder builder, StringOffset LocalizeTWOffset) { builder.AddOffset(9, LocalizeTWOffset.Value, 0); }
  public static void AddLocalizeEN(FlatBufferBuilder builder, StringOffset LocalizeENOffset) { builder.AddOffset(10, LocalizeENOffset.Value, 0); }
  public static Offset<FlatDataGlobal.CharacterDialogSubtitleExcel> EndCharacterDialogSubtitleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterDialogSubtitleExcel>(o);
  }
}


}
