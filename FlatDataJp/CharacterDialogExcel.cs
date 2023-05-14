// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
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
  public long DisplayOrder { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ProductionStep Productionstep { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ProductionStep.ToDo; } }
  public FlatDataJp.DialogCategory Dialogcategory { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCategory.Cafe; } }
  public FlatDataJp.DialogCondition Dialogcondition { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.DialogCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogCondition.Idle; } }
  public FlatDataJp.Anniversary Anniversary { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.Anniversary)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Anniversary.None; } }
  public string StartDate { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(16); }
  public string EndDate { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(18); }
  public long GroupId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.DialogType Dialogtype { get { int o = __p.__offset(22); return o != 0 ? (FlatDataJp.DialogType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DialogType.Talk; } }
  public string ActionName { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionNameBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetActionNameBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetActionNameArray() { return __p.__vector_as_array<byte>(24); }
  public long Duration { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AnimationName { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationNameBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetAnimationNameBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetAnimationNameArray() { return __p.__vector_as_array<byte>(28); }
  public string LocalizeKR { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(30); }
  public string LocalizeJP { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(32); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(34); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(36); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool ApplyPosition { get { int o = __p.__offset(38); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float PosX { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PosY { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool CollectionVisible { get { int o = __p.__offset(44); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataJp.CVCollectionType Cvcollectiontype { get { int o = __p.__offset(46); return o != 0 ? (FlatDataJp.CVCollectionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CVCollectionType.CVNormal; } }
  public long UnlockFavorRank { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LocalizeCVGroup { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCVGroupBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCVGroupBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetLocalizeCVGroupArray() { return __p.__vector_as_array<byte>(50); }

  public static Offset<FlatDataJp.CharacterDialogExcel> CreateCharacterDialogExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long DisplayOrder = 0,
      FlatDataJp.ProductionStep productionstep = FlatDataJp.ProductionStep.ToDo,
      FlatDataJp.DialogCategory dialogcategory = FlatDataJp.DialogCategory.Cafe,
      FlatDataJp.DialogCondition dialogcondition = FlatDataJp.DialogCondition.Idle,
      FlatDataJp.Anniversary anniversary = FlatDataJp.Anniversary.None,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long GroupId = 0,
      FlatDataJp.DialogType dialogtype = FlatDataJp.DialogType.Talk,
      StringOffset ActionNameOffset = default(StringOffset),
      long Duration = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset),
      bool ApplyPosition = false,
      float PosX = 0.0f,
      float PosY = 0.0f,
      bool CollectionVisible = false,
      FlatDataJp.CVCollectionType cvcollectiontype = FlatDataJp.CVCollectionType.CVNormal,
      long UnlockFavorRank = 0,
      StringOffset LocalizeCVGroupOffset = default(StringOffset)) {
    builder.StartTable(24);
    CharacterDialogExcel.AddUnlockFavorRank(builder, UnlockFavorRank);
    CharacterDialogExcel.AddDuration(builder, Duration);
    CharacterDialogExcel.AddGroupId(builder, GroupId);
    CharacterDialogExcel.AddDisplayOrder(builder, DisplayOrder);
    CharacterDialogExcel.AddCharacterId(builder, CharacterId);
    CharacterDialogExcel.AddLocalizeCVGroup(builder, LocalizeCVGroupOffset);
    CharacterDialogExcel.AddCvcollectiontype(builder, cvcollectiontype);
    CharacterDialogExcel.AddPosY(builder, PosY);
    CharacterDialogExcel.AddPosX(builder, PosX);
    CharacterDialogExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    CharacterDialogExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    CharacterDialogExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    CharacterDialogExcel.AddLocalizeKR(builder, LocalizeKROffset);
    CharacterDialogExcel.AddAnimationName(builder, AnimationNameOffset);
    CharacterDialogExcel.AddActionName(builder, ActionNameOffset);
    CharacterDialogExcel.AddDialogtype(builder, dialogtype);
    CharacterDialogExcel.AddEndDate(builder, EndDateOffset);
    CharacterDialogExcel.AddStartDate(builder, StartDateOffset);
    CharacterDialogExcel.AddAnniversary(builder, anniversary);
    CharacterDialogExcel.AddDialogcondition(builder, dialogcondition);
    CharacterDialogExcel.AddDialogcategory(builder, dialogcategory);
    CharacterDialogExcel.AddProductionstep(builder, productionstep);
    CharacterDialogExcel.AddCollectionVisible(builder, CollectionVisible);
    CharacterDialogExcel.AddApplyPosition(builder, ApplyPosition);
    return CharacterDialogExcel.EndCharacterDialogExcel(builder);
  }

  public static void StartCharacterDialogExcel(FlatBufferBuilder builder) { builder.StartTable(24); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(1, DisplayOrder, 0); }
  public static void AddProductionstep(FlatBufferBuilder builder, FlatDataJp.ProductionStep productionstep) { builder.AddInt(2, (int)productionstep, 0); }
  public static void AddDialogcategory(FlatBufferBuilder builder, FlatDataJp.DialogCategory dialogcategory) { builder.AddInt(3, (int)dialogcategory, 0); }
  public static void AddDialogcondition(FlatBufferBuilder builder, FlatDataJp.DialogCondition dialogcondition) { builder.AddInt(4, (int)dialogcondition, 0); }
  public static void AddAnniversary(FlatBufferBuilder builder, FlatDataJp.Anniversary anniversary) { builder.AddInt(5, (int)anniversary, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(6, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(7, EndDateOffset.Value, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(8, GroupId, 0); }
  public static void AddDialogtype(FlatBufferBuilder builder, FlatDataJp.DialogType dialogtype) { builder.AddInt(9, (int)dialogtype, 0); }
  public static void AddActionName(FlatBufferBuilder builder, StringOffset ActionNameOffset) { builder.AddOffset(10, ActionNameOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, long Duration) { builder.AddLong(11, Duration, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset AnimationNameOffset) { builder.AddOffset(12, AnimationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset LocalizeKROffset) { builder.AddOffset(13, LocalizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset LocalizeJPOffset) { builder.AddOffset(14, LocalizeJPOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(15, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(16, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddApplyPosition(FlatBufferBuilder builder, bool ApplyPosition) { builder.AddBool(17, ApplyPosition, false); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(18, PosX, 0.0f); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(19, PosY, 0.0f); }
  public static void AddCollectionVisible(FlatBufferBuilder builder, bool CollectionVisible) { builder.AddBool(20, CollectionVisible, false); }
  public static void AddCvcollectiontype(FlatBufferBuilder builder, FlatDataJp.CVCollectionType cvcollectiontype) { builder.AddInt(21, (int)cvcollectiontype, 0); }
  public static void AddUnlockFavorRank(FlatBufferBuilder builder, long UnlockFavorRank) { builder.AddLong(22, UnlockFavorRank, 0); }
  public static void AddLocalizeCVGroup(FlatBufferBuilder builder, StringOffset LocalizeCVGroupOffset) { builder.AddOffset(23, LocalizeCVGroupOffset.Value, 0); }
  public static Offset<FlatDataJp.CharacterDialogExcel> EndCharacterDialogExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterDialogExcel>(o);
  }
}


}
