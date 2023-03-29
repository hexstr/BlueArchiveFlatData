// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterDialogExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterDialogExcel GetRootAsCharacterDialogExcel(ByteBuffer _bb) { return GetRootAsCharacterDialogExcel(_bb, new CharacterDialogExcel()); }
  public static CharacterDialogExcel GetRootAsCharacterDialogExcel(ByteBuffer _bb, CharacterDialogExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterDialogExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ProductionStep ProductionStep { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ProductionStep.ToDo; } }
  public FlatDataGlobal.DialogCategory DialogCategory { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogCategory.Cafe; } }
  public FlatDataGlobal.DialogCondition DialogCondition { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.DialogCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogCondition.Idle; } }
  public FlatDataGlobal.Anniversary Anniversary { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.Anniversary)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.Anniversary.None; } }
  public string StartDate { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(14); }
  public string EndDate { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(16); }
  public long GroupId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.DialogType DialogType { get { int o = __p.__offset(20); return o != 0 ? (FlatDataGlobal.DialogType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogType.Talk; } }
  public string ActionName { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionNameBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetActionNameBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetActionNameArray() { return __p.__vector_as_array<byte>(22); }
  public long Duration { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AnimationName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetAnimationNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetAnimationNameArray() { return __p.__vector_as_array<byte>(26); }
  public string LocalizeKR { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(28); }
  public string LocalizeJP { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(30); }
  public string LocalizeTH { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTHBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTHBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetLocalizeTHArray() { return __p.__vector_as_array<byte>(32); }
  public string LocalizeTW { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTWBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTWBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetLocalizeTWArray() { return __p.__vector_as_array<byte>(34); }
  public string LocalizeEN { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeENBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetLocalizeENBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetLocalizeENArray() { return __p.__vector_as_array<byte>(36); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(38); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(40); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsTh(int j) { int o = __p.__offset(42); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsThLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsTw(int j) { int o = __p.__offset(44); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsTwLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsEn(int j) { int o = __p.__offset(46); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsEnLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool TeenMode { get { int o = __p.__offset(48); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.CharacterDialogExcel> CreateCharacterDialogExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      FlatDataGlobal.ProductionStep ProductionStep = FlatDataGlobal.ProductionStep.ToDo,
      FlatDataGlobal.DialogCategory DialogCategory = FlatDataGlobal.DialogCategory.Cafe,
      FlatDataGlobal.DialogCondition DialogCondition = FlatDataGlobal.DialogCondition.Idle,
      FlatDataGlobal.Anniversary Anniversary = FlatDataGlobal.Anniversary.None,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long GroupId = 0,
      FlatDataGlobal.DialogType DialogType = FlatDataGlobal.DialogType.Talk,
      StringOffset ActionNameOffset = default(StringOffset),
      long Duration = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      StringOffset LocalizeTHOffset = default(StringOffset),
      StringOffset LocalizeTWOffset = default(StringOffset),
      StringOffset LocalizeENOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset),
      VectorOffset VoiceClipsThOffset = default(VectorOffset),
      VectorOffset VoiceClipsTwOffset = default(VectorOffset),
      VectorOffset VoiceClipsEnOffset = default(VectorOffset),
      bool TeenMode = false) {
    builder.StartTable(23);
    CharacterDialogExcel.AddDuration(builder, Duration);
    CharacterDialogExcel.AddGroupId(builder, GroupId);
    CharacterDialogExcel.AddCharacterId(builder, CharacterId);
    CharacterDialogExcel.AddVoiceClipsEn(builder, VoiceClipsEnOffset);
    CharacterDialogExcel.AddVoiceClipsTw(builder, VoiceClipsTwOffset);
    CharacterDialogExcel.AddVoiceClipsTh(builder, VoiceClipsThOffset);
    CharacterDialogExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    CharacterDialogExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    CharacterDialogExcel.AddLocalizeEN(builder, LocalizeENOffset);
    CharacterDialogExcel.AddLocalizeTW(builder, LocalizeTWOffset);
    CharacterDialogExcel.AddLocalizeTH(builder, LocalizeTHOffset);
    CharacterDialogExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogExcel.AddAnimationName(builder, AnimationNameOffset);
    CharacterDialogExcel.AddActionName(builder, ActionNameOffset);
    CharacterDialogExcel.AddDialogType(builder, DialogType);
    CharacterDialogExcel.AddEndDate(builder, EndDateOffset);
    CharacterDialogExcel.AddStartDate(builder, StartDateOffset);
    CharacterDialogExcel.AddAnniversary(builder, Anniversary);
    CharacterDialogExcel.AddDialogCondition(builder, DialogCondition);
    CharacterDialogExcel.AddDialogCategory(builder, DialogCategory);
    CharacterDialogExcel.AddProductionStep(builder, ProductionStep);
    CharacterDialogExcel.AddTeenMode(builder, TeenMode);
    return CharacterDialogExcel.EndCharacterDialogExcel(builder);
  }

  public static void StartCharacterDialogExcel(FlatBufferBuilder builder) { builder.StartTable(23); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, FlatDataGlobal.ProductionStep ProductionStep) { builder.AddInt(1, (int)ProductionStep, 0); }
  public static void AddDialogCategory(FlatBufferBuilder builder, FlatDataGlobal.DialogCategory DialogCategory) { builder.AddInt(2, (int)DialogCategory, 0); }
  public static void AddDialogCondition(FlatBufferBuilder builder, FlatDataGlobal.DialogCondition DialogCondition) { builder.AddInt(3, (int)DialogCondition, 0); }
  public static void AddAnniversary(FlatBufferBuilder builder, FlatDataGlobal.Anniversary Anniversary) { builder.AddInt(4, (int)Anniversary, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(5, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(6, EndDateOffset.Value, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(7, GroupId, 0); }
  public static void AddDialogType(FlatBufferBuilder builder, FlatDataGlobal.DialogType DialogType) { builder.AddInt(8, (int)DialogType, 0); }
  public static void AddActionName(FlatBufferBuilder builder, StringOffset ActionNameOffset) { builder.AddOffset(9, ActionNameOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(10, Duration, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset AnimationNameOffset) { builder.AddOffset(11, AnimationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(12, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(13, LocalizeJPOffset.Value, 0); }
  public static void AddLocalizeTH(FlatBufferBuilder builder, StringOffset LocalizeTHOffset) { builder.AddOffset(14, LocalizeTHOffset.Value, 0); }
  public static void AddLocalizeTW(FlatBufferBuilder builder, StringOffset LocalizeTWOffset) { builder.AddOffset(15, LocalizeTWOffset.Value, 0); }
  public static void AddLocalizeEN(FlatBufferBuilder builder, StringOffset LocalizeENOffset) { builder.AddOffset(16, LocalizeENOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(17, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(18, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsTh(FlatBufferBuilder builder, VectorOffset VoiceClipsThOffset) { builder.AddOffset(19, VoiceClipsThOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsThVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsThVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsTw(FlatBufferBuilder builder, VectorOffset VoiceClipsTwOffset) { builder.AddOffset(20, VoiceClipsTwOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsTwVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsTwVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsEn(FlatBufferBuilder builder, VectorOffset VoiceClipsEnOffset) { builder.AddOffset(21, VoiceClipsEnOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsEnVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsEnVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTeenMode(FlatBufferBuilder builder, bool TeenMode) { builder.AddBool(22, TeenMode, false); }
  public static Offset<FlatDataGlobal.CharacterDialogExcel> EndCharacterDialogExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterDialogExcel>(o);
  }
}


}
