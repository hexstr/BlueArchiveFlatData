// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGEncounterExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MinigameTBGEncounterExcel GetRootAsMinigameTBGEncounterExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGEncounterExcel(_bb, new MinigameTBGEncounterExcel()); }
  public static MinigameTBGEncounterExcel GetRootAsMinigameTBGEncounterExcel(ByteBuffer _bb, MinigameTBGEncounterExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGEncounterExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool AllThema { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int ThemaIndex(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ThemaIndexLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetThemaIndexBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetThemaIndexBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetThemaIndexArray() { return __p.__vector_as_array<int>(10); }
  public FlatDataGlobal.TBGObjectType ObjectType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.TBGObjectType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TBGObjectType.None; } }
  public string EnemyImagePath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnemyImagePathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetEnemyImagePathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetEnemyImagePathArray() { return __p.__vector_as_array<byte>(14); }
  public string EnemyNameLocalize { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnemyNameLocalizeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetEnemyNameLocalizeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetEnemyNameLocalizeArray() { return __p.__vector_as_array<byte>(16); }
  public long OptionGroupId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string EncounterTitleLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEncounterTitleLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetEncounterTitleLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetEncounterTitleLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public string StoryImagePath { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStoryImagePathBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetStoryImagePathBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetStoryImagePathArray() { return __p.__vector_as_array<byte>(22); }
  public string BeforeStoryLocalize { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforeStoryLocalizeBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetBeforeStoryLocalizeBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetBeforeStoryLocalizeArray() { return __p.__vector_as_array<byte>(24); }
  public string BeforeStoryOption1Localize { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforeStoryOption1LocalizeBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetBeforeStoryOption1LocalizeBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetBeforeStoryOption1LocalizeArray() { return __p.__vector_as_array<byte>(26); }
  public string BeforeStoryOption2Localize { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforeStoryOption2LocalizeBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetBeforeStoryOption2LocalizeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetBeforeStoryOption2LocalizeArray() { return __p.__vector_as_array<byte>(28); }
  public string BeforeStoryOption3Localize { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforeStoryOption3LocalizeBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetBeforeStoryOption3LocalizeBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetBeforeStoryOption3LocalizeArray() { return __p.__vector_as_array<byte>(30); }
  public string ClearStoryLocalize { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetClearStoryLocalizeBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetClearStoryLocalizeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetClearStoryLocalizeArray() { return __p.__vector_as_array<byte>(32); }
  public string DefeatStoryLocalize { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefeatStoryLocalizeBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetDefeatStoryLocalizeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetDefeatStoryLocalizeArray() { return __p.__vector_as_array<byte>(34); }
  public string RunawayStoryLocalize { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRunawayStoryLocalizeBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetRunawayStoryLocalizeBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetRunawayStoryLocalizeArray() { return __p.__vector_as_array<byte>(36); }

  public static Offset<FlatDataGlobal.MinigameTBGEncounterExcel> CreateMinigameTBGEncounterExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long UniqueId = 0,
      bool AllThema = false,
      VectorOffset ThemaIndexOffset = default(VectorOffset),
      FlatDataGlobal.TBGObjectType ObjectType = FlatDataGlobal.TBGObjectType.None,
      StringOffset EnemyImagePathOffset = default(StringOffset),
      StringOffset EnemyNameLocalizeOffset = default(StringOffset),
      long OptionGroupId = 0,
      StringOffset EncounterTitleLocalizeOffset = default(StringOffset),
      StringOffset StoryImagePathOffset = default(StringOffset),
      StringOffset BeforeStoryLocalizeOffset = default(StringOffset),
      StringOffset BeforeStoryOption1LocalizeOffset = default(StringOffset),
      StringOffset BeforeStoryOption2LocalizeOffset = default(StringOffset),
      StringOffset BeforeStoryOption3LocalizeOffset = default(StringOffset),
      StringOffset ClearStoryLocalizeOffset = default(StringOffset),
      StringOffset DefeatStoryLocalizeOffset = default(StringOffset),
      StringOffset RunawayStoryLocalizeOffset = default(StringOffset)) {
    builder.StartTable(17);
    MinigameTBGEncounterExcel.AddOptionGroupId(builder, OptionGroupId);
    MinigameTBGEncounterExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGEncounterExcel.AddEventContentId(builder, EventContentId);
    MinigameTBGEncounterExcel.AddRunawayStoryLocalize(builder, RunawayStoryLocalizeOffset);
    MinigameTBGEncounterExcel.AddDefeatStoryLocalize(builder, DefeatStoryLocalizeOffset);
    MinigameTBGEncounterExcel.AddClearStoryLocalize(builder, ClearStoryLocalizeOffset);
    MinigameTBGEncounterExcel.AddBeforeStoryOption3Localize(builder, BeforeStoryOption3LocalizeOffset);
    MinigameTBGEncounterExcel.AddBeforeStoryOption2Localize(builder, BeforeStoryOption2LocalizeOffset);
    MinigameTBGEncounterExcel.AddBeforeStoryOption1Localize(builder, BeforeStoryOption1LocalizeOffset);
    MinigameTBGEncounterExcel.AddBeforeStoryLocalize(builder, BeforeStoryLocalizeOffset);
    MinigameTBGEncounterExcel.AddStoryImagePath(builder, StoryImagePathOffset);
    MinigameTBGEncounterExcel.AddEncounterTitleLocalize(builder, EncounterTitleLocalizeOffset);
    MinigameTBGEncounterExcel.AddEnemyNameLocalize(builder, EnemyNameLocalizeOffset);
    MinigameTBGEncounterExcel.AddEnemyImagePath(builder, EnemyImagePathOffset);
    MinigameTBGEncounterExcel.AddObjectType(builder, ObjectType);
    MinigameTBGEncounterExcel.AddThemaIndex(builder, ThemaIndexOffset);
    MinigameTBGEncounterExcel.AddAllThema(builder, AllThema);
    return MinigameTBGEncounterExcel.EndMinigameTBGEncounterExcel(builder);
  }

  public static void StartMinigameTBGEncounterExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(1, UniqueId, 0); }
  public static void AddAllThema(FlatBufferBuilder builder, bool AllThema) { builder.AddBool(2, AllThema, false); }
  public static void AddThemaIndex(FlatBufferBuilder builder, VectorOffset ThemaIndexOffset) { builder.AddOffset(3, ThemaIndexOffset.Value, 0); }
  public static VectorOffset CreateThemaIndexVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateThemaIndexVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateThemaIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateThemaIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartThemaIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddObjectType(FlatBufferBuilder builder, FlatDataGlobal.TBGObjectType ObjectType) { builder.AddInt(4, (int)ObjectType, 0); }
  public static void AddEnemyImagePath(FlatBufferBuilder builder, StringOffset EnemyImagePathOffset) { builder.AddOffset(5, EnemyImagePathOffset.Value, 0); }
  public static void AddEnemyNameLocalize(FlatBufferBuilder builder, StringOffset EnemyNameLocalizeOffset) { builder.AddOffset(6, EnemyNameLocalizeOffset.Value, 0); }
  public static void AddOptionGroupId(FlatBufferBuilder builder, long OptionGroupId) { builder.AddLong(7, OptionGroupId, 0); }
  public static void AddEncounterTitleLocalize(FlatBufferBuilder builder, StringOffset EncounterTitleLocalizeOffset) { builder.AddOffset(8, EncounterTitleLocalizeOffset.Value, 0); }
  public static void AddStoryImagePath(FlatBufferBuilder builder, StringOffset StoryImagePathOffset) { builder.AddOffset(9, StoryImagePathOffset.Value, 0); }
  public static void AddBeforeStoryLocalize(FlatBufferBuilder builder, StringOffset BeforeStoryLocalizeOffset) { builder.AddOffset(10, BeforeStoryLocalizeOffset.Value, 0); }
  public static void AddBeforeStoryOption1Localize(FlatBufferBuilder builder, StringOffset BeforeStoryOption1LocalizeOffset) { builder.AddOffset(11, BeforeStoryOption1LocalizeOffset.Value, 0); }
  public static void AddBeforeStoryOption2Localize(FlatBufferBuilder builder, StringOffset BeforeStoryOption2LocalizeOffset) { builder.AddOffset(12, BeforeStoryOption2LocalizeOffset.Value, 0); }
  public static void AddBeforeStoryOption3Localize(FlatBufferBuilder builder, StringOffset BeforeStoryOption3LocalizeOffset) { builder.AddOffset(13, BeforeStoryOption3LocalizeOffset.Value, 0); }
  public static void AddClearStoryLocalize(FlatBufferBuilder builder, StringOffset ClearStoryLocalizeOffset) { builder.AddOffset(14, ClearStoryLocalizeOffset.Value, 0); }
  public static void AddDefeatStoryLocalize(FlatBufferBuilder builder, StringOffset DefeatStoryLocalizeOffset) { builder.AddOffset(15, DefeatStoryLocalizeOffset.Value, 0); }
  public static void AddRunawayStoryLocalize(FlatBufferBuilder builder, StringOffset RunawayStoryLocalizeOffset) { builder.AddOffset(16, RunawayStoryLocalizeOffset.Value, 0); }
  public static Offset<FlatDataGlobal.MinigameTBGEncounterExcel> EndMinigameTBGEncounterExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MinigameTBGEncounterExcel>(o);
  }
}


}
