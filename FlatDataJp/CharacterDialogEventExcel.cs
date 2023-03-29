// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterDialogEventExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterDialogEventExcel GetRootAsCharacterDialogEventExcel(ByteBuffer _bb) { return GetRootAsCharacterDialogEventExcel(_bb, new CharacterDialogEventExcel()); }
  public static CharacterDialogEventExcel GetRootAsCharacterDialogEventExcel(ByteBuffer _bb, CharacterDialogEventExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterDialogEventExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ProductionStep ProductionStep { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ProductionStep.ToDo; } }
  public FlatDataJp.DialogCategory DialogCategory { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCategory.Cafe; } }
  public FlatDataJp.DialogCondition DialogCondition { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.DialogCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCondition.Idle; } }
  public FlatDataJp.DialogConditionDetail DialogConditionDetail { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.DialogConditionDetail)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogConditionDetail.None; } }
  public long DialogConditionDetailValue { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.DialogType DialogType { get { int o = __p.__offset(20); return o != 0 ? (FlatDataJp.DialogType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogType.Talk; } }
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
  public string VoiceClipsKr(int j) { int o = __p.__offset(32); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(34); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.CharacterDialogEventExcel> CreateCharacterDialogEventExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long EventID = 0,
      FlatDataJp.ProductionStep ProductionStep = FlatDataJp.ProductionStep.ToDo,
      FlatDataJp.DialogCategory DialogCategory = FlatDataJp.DialogCategory.Cafe,
      FlatDataJp.DialogCondition DialogCondition = FlatDataJp.DialogCondition.Idle,
      FlatDataJp.DialogConditionDetail DialogConditionDetail = FlatDataJp.DialogConditionDetail.None,
      long DialogConditionDetailValue = 0,
      long GroupId = 0,
      FlatDataJp.DialogType DialogType = FlatDataJp.DialogType.Talk,
      StringOffset ActionNameOffset = default(StringOffset),
      long Duration = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset)) {
    builder.StartTable(16);
    CharacterDialogEventExcel.AddDuration(builder, Duration);
    CharacterDialogEventExcel.AddGroupId(builder, GroupId);
    CharacterDialogEventExcel.AddDialogConditionDetailValue(builder, DialogConditionDetailValue);
    CharacterDialogEventExcel.AddEventID(builder, EventID);
    CharacterDialogEventExcel.AddCharacterId(builder, CharacterId);
    CharacterDialogEventExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    CharacterDialogEventExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    CharacterDialogEventExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogEventExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogEventExcel.AddAnimationName(builder, AnimationNameOffset);
    CharacterDialogEventExcel.AddActionName(builder, ActionNameOffset);
    CharacterDialogEventExcel.AddDialogType(builder, DialogType);
    CharacterDialogEventExcel.AddDialogConditionDetail(builder, DialogConditionDetail);
    CharacterDialogEventExcel.AddDialogCondition(builder, DialogCondition);
    CharacterDialogEventExcel.AddDialogCategory(builder, DialogCategory);
    CharacterDialogEventExcel.AddProductionStep(builder, ProductionStep);
    return CharacterDialogEventExcel.EndCharacterDialogEventExcel(builder);
  }

  public static void StartCharacterDialogEventExcel(FlatBufferBuilder builder) { builder.StartTable(16); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddEventID(FlatBufferBuilder builder, long EventID) { builder.AddLong(1, EventID, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, FlatDataJp.ProductionStep ProductionStep) { builder.AddInt(2, (int)ProductionStep, 0); }
  public static void AddDialogCategory(FlatBufferBuilder builder, FlatDataJp.DialogCategory DialogCategory) { builder.AddInt(3, (int)DialogCategory, 0); }
  public static void AddDialogCondition(FlatBufferBuilder builder, FlatDataJp.DialogCondition DialogCondition) { builder.AddInt(4, (int)DialogCondition, 0); }
  public static void AddDialogConditionDetail(FlatBufferBuilder builder, FlatDataJp.DialogConditionDetail DialogConditionDetail) { builder.AddInt(5, (int)DialogConditionDetail, 0); }
  public static void AddDialogConditionDetailValue(FlatBufferBuilder builder, long DialogConditionDetailValue) { builder.AddLong(6, DialogConditionDetailValue, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(7, GroupId, 0); }
  public static void AddDialogType(FlatBufferBuilder builder, FlatDataJp.DialogType DialogType) { builder.AddInt(8, (int)DialogType, 0); }
  public static void AddActionName(FlatBufferBuilder builder, StringOffset ActionNameOffset) { builder.AddOffset(9, ActionNameOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(10, Duration, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset AnimationNameOffset) { builder.AddOffset(11, AnimationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(12, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(13, LocalizeJPOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(14, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(15, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.CharacterDialogEventExcel> EndCharacterDialogEventExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterDialogEventExcel>(o);
  }
}


}
