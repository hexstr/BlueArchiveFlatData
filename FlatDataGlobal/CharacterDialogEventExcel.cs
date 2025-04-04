// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
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

  public long CostumeUniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OriginalCharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventID { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ProductionStep ProductionStep { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ProductionStep.ToDo; } }
  public FlatDataGlobal.DialogCategory DialogCategory { get { int o = __p.__offset(14); return o != 0 ? (FlatDataGlobal.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogCategory.Cafe; } }
  public FlatDataGlobal.DialogCondition DialogCondition { get { int o = __p.__offset(16); return o != 0 ? (FlatDataGlobal.DialogCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogCondition.Idle; } }
  public FlatDataGlobal.DialogConditionDetail DialogConditionDetail { get { int o = __p.__offset(18); return o != 0 ? (FlatDataGlobal.DialogConditionDetail)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogConditionDetail.None; } }
  public long DialogConditionDetailValue { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.DialogType DialogType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataGlobal.DialogType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DialogType.Talk; } }
  public string ActionName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetActionNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetActionNameArray() { return __p.__vector_as_array<byte>(26); }
  public long Duration { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DurationKr { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AnimationName { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationNameBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetAnimationNameBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetAnimationNameArray() { return __p.__vector_as_array<byte>(32); }
  public string LocalizeKR { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(34); }
  public string LocalizeJP { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(36); }
  public string LocalizeTH { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTHBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTHBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetLocalizeTHArray() { return __p.__vector_as_array<byte>(38); }
  public string LocalizeTW { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTWBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTWBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetLocalizeTWArray() { return __p.__vector_as_array<byte>(40); }
  public string LocalizeEN { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeENBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetLocalizeENBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetLocalizeENArray() { return __p.__vector_as_array<byte>(42); }
  public uint VoiceId(int j) { int o = __p.__offset(44); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceIdLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceIdBytes() { return __p.__vector_as_span<uint>(44, 4); }
#else
  public ArraySegment<byte>? GetVoiceIdBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public uint[] GetVoiceIdArray() { return __p.__vector_as_array<uint>(44); }
  public bool CollectionVisible { get { int o = __p.__offset(46); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.CVCollectionType CVCollectionType { get { int o = __p.__offset(48); return o != 0 ? (FlatDataGlobal.CVCollectionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.CVCollectionType.CVNormal; } }
  public long UnlockEventSeason { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioGroupId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LocalizeCVGroup { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCVGroupBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCVGroupBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetLocalizeCVGroupArray() { return __p.__vector_as_array<byte>(54); }

  public static Offset<FlatDataGlobal.CharacterDialogEventExcel> CreateCharacterDialogEventExcel(FlatBufferBuilder builder,
      long CostumeUniqueId = 0,
      long OriginalCharacterId = 0,
      long DisplayOrder = 0,
      long EventID = 0,
      FlatDataGlobal.ProductionStep productionStep = FlatDataGlobal.ProductionStep.ToDo,
      FlatDataGlobal.DialogCategory dialogCategory = FlatDataGlobal.DialogCategory.Cafe,
      FlatDataGlobal.DialogCondition dialogCondition = FlatDataGlobal.DialogCondition.Idle,
      FlatDataGlobal.DialogConditionDetail dialogConditionDetail = FlatDataGlobal.DialogConditionDetail.None,
      long DialogConditionDetailValue = 0,
      long GroupId = 0,
      FlatDataGlobal.DialogType dialogType = FlatDataGlobal.DialogType.Talk,
      StringOffset ActionNameOffset = default(StringOffset),
      long Duration = 0,
      long DurationKr = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      StringOffset LocalizeTHOffset = default(StringOffset),
      StringOffset LocalizeTWOffset = default(StringOffset),
      StringOffset LocalizeENOffset = default(StringOffset),
      VectorOffset VoiceIdOffset = default(VectorOffset),
      bool CollectionVisible = false,
      FlatDataGlobal.CVCollectionType cVCollectionType = FlatDataGlobal.CVCollectionType.CVNormal,
      long UnlockEventSeason = 0,
      long ScenarioGroupId = 0,
      StringOffset LocalizeCVGroupOffset = default(StringOffset)) {
    builder.StartTable(26);
    CharacterDialogEventExcel.AddScenarioGroupId(builder, ScenarioGroupId);
    CharacterDialogEventExcel.AddUnlockEventSeason(builder, UnlockEventSeason);
    CharacterDialogEventExcel.AddDurationKr(builder, DurationKr);
    CharacterDialogEventExcel.AddDuration(builder, Duration);
    CharacterDialogEventExcel.AddGroupId(builder, GroupId);
    CharacterDialogEventExcel.AddDialogConditionDetailValue(builder, DialogConditionDetailValue);
    CharacterDialogEventExcel.AddEventID(builder, EventID);
    CharacterDialogEventExcel.AddDisplayOrder(builder, DisplayOrder);
    CharacterDialogEventExcel.AddOriginalCharacterId(builder, OriginalCharacterId);
    CharacterDialogEventExcel.AddCostumeUniqueId(builder, CostumeUniqueId);
    CharacterDialogEventExcel.AddLocalizeCVGroup(builder, LocalizeCVGroupOffset);
    CharacterDialogEventExcel.AddCVCollectionType(builder, cVCollectionType);
    CharacterDialogEventExcel.AddVoiceId(builder, VoiceIdOffset);
    CharacterDialogEventExcel.AddLocalizeEN(builder, LocalizeENOffset);
    CharacterDialogEventExcel.AddLocalizeTW(builder, LocalizeTWOffset);
    CharacterDialogEventExcel.AddLocalizeTH(builder, LocalizeTHOffset);
    CharacterDialogEventExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogEventExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogEventExcel.AddAnimationName(builder, AnimationNameOffset);
    CharacterDialogEventExcel.AddActionName(builder, ActionNameOffset);
    CharacterDialogEventExcel.AddDialogType(builder, dialogType);
    CharacterDialogEventExcel.AddDialogConditionDetail(builder, dialogConditionDetail);
    CharacterDialogEventExcel.AddDialogCondition(builder, dialogCondition);
    CharacterDialogEventExcel.AddDialogCategory(builder, dialogCategory);
    CharacterDialogEventExcel.AddProductionStep(builder, productionStep);
    CharacterDialogEventExcel.AddCollectionVisible(builder, CollectionVisible);
    return CharacterDialogEventExcel.EndCharacterDialogEventExcel(builder);
  }

  public static void StartCharacterDialogEventExcel(FlatBufferBuilder builder) { builder.StartTable(26); }
  public static void AddCostumeUniqueId(FlatBufferBuilder builder, long CostumeUniqueId) { builder.AddLong(0, CostumeUniqueId, 0); }
  public static void AddOriginalCharacterId(FlatBufferBuilder builder, long OriginalCharacterId) { builder.AddLong(1, OriginalCharacterId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(2, DisplayOrder, 0); }
  public static void AddEventID(FlatBufferBuilder builder, long EventID) { builder.AddLong(3, EventID, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, FlatDataGlobal.ProductionStep productionStep) { builder.AddInt(4, (int)productionStep, 0); }
  public static void AddDialogCategory(FlatBufferBuilder builder, FlatDataGlobal.DialogCategory dialogCategory) { builder.AddInt(5, (int)dialogCategory, 0); }
  public static void AddDialogCondition(FlatBufferBuilder builder, FlatDataGlobal.DialogCondition dialogCondition) { builder.AddInt(6, (int)dialogCondition, 0); }
  public static void AddDialogConditionDetail(FlatBufferBuilder builder, FlatDataGlobal.DialogConditionDetail dialogConditionDetail) { builder.AddInt(7, (int)dialogConditionDetail, 0); }
  public static void AddDialogConditionDetailValue(FlatBufferBuilder builder, long DialogConditionDetailValue) { builder.AddLong(8, DialogConditionDetailValue, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(9, GroupId, 0); }
  public static void AddDialogType(FlatBufferBuilder builder, FlatDataGlobal.DialogType dialogType) { builder.AddInt(10, (int)dialogType, 0); }
  public static void AddActionName(FlatBufferBuilder builder, StringOffset ActionNameOffset) { builder.AddOffset(11, ActionNameOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(12, Duration, 0); }
  public static void AddDurationKr(FlatBufferBuilder builder, long DurationKr) { builder.AddLong(13, DurationKr, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset AnimationNameOffset) { builder.AddOffset(14, AnimationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(15, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(16, LocalizeJPOffset.Value, 0); }
  public static void AddLocalizeTH(FlatBufferBuilder builder, StringOffset LocalizeTHOffset) { builder.AddOffset(17, LocalizeTHOffset.Value, 0); }
  public static void AddLocalizeTW(FlatBufferBuilder builder, StringOffset LocalizeTWOffset) { builder.AddOffset(18, LocalizeTWOffset.Value, 0); }
  public static void AddLocalizeEN(FlatBufferBuilder builder, StringOffset LocalizeENOffset) { builder.AddOffset(19, LocalizeENOffset.Value, 0); }
  public static void AddVoiceId(FlatBufferBuilder builder, VectorOffset VoiceIdOffset) { builder.AddOffset(20, VoiceIdOffset.Value, 0); }
  public static VectorOffset CreateVoiceIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCollectionVisible(FlatBufferBuilder builder, bool CollectionVisible) { builder.AddBool(21, CollectionVisible, false); }
  public static void AddCVCollectionType(FlatBufferBuilder builder, FlatDataGlobal.CVCollectionType cVCollectionType) { builder.AddInt(22, (int)cVCollectionType, 0); }
  public static void AddUnlockEventSeason(FlatBufferBuilder builder, long UnlockEventSeason) { builder.AddLong(23, UnlockEventSeason, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, long ScenarioGroupId) { builder.AddLong(24, ScenarioGroupId, 0); }
  public static void AddLocalizeCVGroup(FlatBufferBuilder builder, StringOffset LocalizeCVGroupOffset) { builder.AddOffset(25, LocalizeCVGroupOffset.Value, 0); }
  public static Offset<FlatDataGlobal.CharacterDialogEventExcel> EndCharacterDialogEventExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterDialogEventExcel>(o);
  }
}


}
