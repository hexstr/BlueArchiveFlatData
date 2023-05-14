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
  public long OriginalCharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventID { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ProductionStep Productionstep { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ProductionStep.ToDo; } }
  public FlatDataJp.DialogCategory Dialogcategory { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCategory.Cafe; } }
  public FlatDataJp.DialogCondition Dialogcondition { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.DialogCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCondition.Idle; } }
  public FlatDataJp.DialogConditionDetail Dialogconditiondetail { get { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.DialogConditionDetail)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogConditionDetail.None; } }
  public long DialogConditionDetailValue { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.DialogType Dialogtype { get { int o = __p.__offset(24); return o != 0 ? (FlatDataJp.DialogType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogType.Talk; } }
  public string ActionName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetActionNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetActionNameArray() { return __p.__vector_as_array<byte>(26); }
  public long Duration { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AnimationName { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationNameBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetAnimationNameBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetAnimationNameArray() { return __p.__vector_as_array<byte>(30); }
  public string LocalizeKR { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(32); }
  public string LocalizeJP { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(34); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(36); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(38); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool CollectionVisible { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataJp.CVCollectionType Cvcollectiontype { get { int o = __p.__offset(42); return o != 0 ? (FlatDataJp.CVCollectionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CVCollectionType.CVNormal; } }
  public long UnlockEventSeason { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioGroupId { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LocalizeCVGroup { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCVGroupBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCVGroupBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetLocalizeCVGroupArray() { return __p.__vector_as_array<byte>(48); }

  public static Offset<FlatDataJp.CharacterDialogEventExcel> CreateCharacterDialogEventExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long OriginalCharacterId = 0,
      long DisplayOrder = 0,
      long EventID = 0,
      FlatDataJp.ProductionStep productionstep = FlatDataJp.ProductionStep.ToDo,
      FlatDataJp.DialogCategory dialogcategory = FlatDataJp.DialogCategory.Cafe,
      FlatDataJp.DialogCondition dialogcondition = FlatDataJp.DialogCondition.Idle,
      FlatDataJp.DialogConditionDetail dialogconditiondetail = FlatDataJp.DialogConditionDetail.None,
      long DialogConditionDetailValue = 0,
      long GroupId = 0,
      FlatDataJp.DialogType dialogtype = FlatDataJp.DialogType.Talk,
      StringOffset ActionNameOffset = default(StringOffset),
      long Duration = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset),
      bool CollectionVisible = false,
      FlatDataJp.CVCollectionType cvcollectiontype = FlatDataJp.CVCollectionType.CVNormal,
      long UnlockEventSeason = 0,
      long ScenarioGroupId = 0,
      StringOffset LocalizeCVGroupOffset = default(StringOffset)) {
    builder.StartTable(23);
    CharacterDialogEventExcel.AddScenarioGroupId(builder, ScenarioGroupId);
    CharacterDialogEventExcel.AddUnlockEventSeason(builder, UnlockEventSeason);
    CharacterDialogEventExcel.AddDuration(builder, Duration);
    CharacterDialogEventExcel.AddGroupId(builder, GroupId);
    CharacterDialogEventExcel.AddDialogConditionDetailValue(builder, DialogConditionDetailValue);
    CharacterDialogEventExcel.AddEventID(builder, EventID);
    CharacterDialogEventExcel.AddDisplayOrder(builder, DisplayOrder);
    CharacterDialogEventExcel.AddOriginalCharacterId(builder, OriginalCharacterId);
    CharacterDialogEventExcel.AddCharacterId(builder, CharacterId);
    CharacterDialogEventExcel.AddLocalizeCVGroup(builder, LocalizeCVGroupOffset);
    CharacterDialogEventExcel.AddCvcollectiontype(builder, cvcollectiontype);
    CharacterDialogEventExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    CharacterDialogEventExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    CharacterDialogEventExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogEventExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogEventExcel.AddAnimationName(builder, AnimationNameOffset);
    CharacterDialogEventExcel.AddActionName(builder, ActionNameOffset);
    CharacterDialogEventExcel.AddDialogtype(builder, dialogtype);
    CharacterDialogEventExcel.AddDialogconditiondetail(builder, dialogconditiondetail);
    CharacterDialogEventExcel.AddDialogcondition(builder, dialogcondition);
    CharacterDialogEventExcel.AddDialogcategory(builder, dialogcategory);
    CharacterDialogEventExcel.AddProductionstep(builder, productionstep);
    CharacterDialogEventExcel.AddCollectionVisible(builder, CollectionVisible);
    return CharacterDialogEventExcel.EndCharacterDialogEventExcel(builder);
  }

  public static void StartCharacterDialogEventExcel(FlatBufferBuilder builder) { builder.StartTable(23); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddOriginalCharacterId(FlatBufferBuilder builder, long OriginalCharacterId) { builder.AddLong(1, OriginalCharacterId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(2, DisplayOrder, 0); }
  public static void AddEventID(FlatBufferBuilder builder, long EventID) { builder.AddLong(3, EventID, 0); }
  public static void AddProductionstep(FlatBufferBuilder builder, FlatDataJp.ProductionStep productionstep) { builder.AddInt(4, (int)productionstep, 0); }
  public static void AddDialogcategory(FlatBufferBuilder builder, FlatDataJp.DialogCategory dialogcategory) { builder.AddInt(5, (int)dialogcategory, 0); }
  public static void AddDialogcondition(FlatBufferBuilder builder, FlatDataJp.DialogCondition dialogcondition) { builder.AddInt(6, (int)dialogcondition, 0); }
  public static void AddDialogconditiondetail(FlatBufferBuilder builder, FlatDataJp.DialogConditionDetail dialogconditiondetail) { builder.AddInt(7, (int)dialogconditiondetail, 0); }
  public static void AddDialogConditionDetailValue(FlatBufferBuilder builder, long DialogConditionDetailValue) { builder.AddLong(8, DialogConditionDetailValue, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(9, GroupId, 0); }
  public static void AddDialogtype(FlatBufferBuilder builder, FlatDataJp.DialogType dialogtype) { builder.AddInt(10, (int)dialogtype, 0); }
  public static void AddActionName(FlatBufferBuilder builder, StringOffset ActionNameOffset) { builder.AddOffset(11, ActionNameOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(12, Duration, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset AnimationNameOffset) { builder.AddOffset(13, AnimationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(14, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(15, LocalizeJPOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(16, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(17, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCollectionVisible(FlatBufferBuilder builder, bool CollectionVisible) { builder.AddBool(18, CollectionVisible, false); }
  public static void AddCvcollectiontype(FlatBufferBuilder builder, FlatDataJp.CVCollectionType cvcollectiontype) { builder.AddInt(19, (int)cvcollectiontype, 0); }
  public static void AddUnlockEventSeason(FlatBufferBuilder builder, long UnlockEventSeason) { builder.AddLong(20, UnlockEventSeason, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, long ScenarioGroupId) { builder.AddLong(21, ScenarioGroupId, 0); }
  public static void AddLocalizeCVGroup(FlatBufferBuilder builder, StringOffset LocalizeCVGroupOffset) { builder.AddOffset(22, LocalizeCVGroupOffset.Value, 0); }
  public static Offset<FlatDataJp.CharacterDialogEventExcel> EndCharacterDialogEventExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterDialogEventExcel>(o);
  }
}


}
