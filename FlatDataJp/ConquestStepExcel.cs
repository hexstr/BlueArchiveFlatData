// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestStepExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb) { return GetRootAsConquestStepExcel(_bb, new ConquestStepExcel()); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb, ConquestStepExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestStepExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.StageDifficulty MapDifficulty { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageDifficulty.None; } }
  public int Step { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string StepGoalLocalize { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepGoalLocalizeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStepGoalLocalizeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStepGoalLocalizeArray() { return __p.__vector_as_array<byte>(10); }
  public long StepEnterScenarioGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType StepEnterItemType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long StepEnterItemUniqueId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StepEnterItemAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UnexpectedEventUnitId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int UnexpectedEventUnitIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetUnexpectedEventUnitIdArray() { return __p.__vector_as_array<long>(20); }
  public string UnexpectedEventPrefab { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnexpectedEventPrefabBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetUnexpectedEventPrefabBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetUnexpectedEventPrefabArray() { return __p.__vector_as_array<byte>(22); }
  public long TreasureBoxObjectId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TreasureBoxCountPerStepOpen { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.ConquestStepExcel> CreateConquestStepExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataJp.StageDifficulty MapDifficulty = FlatDataJp.StageDifficulty.None,
      int Step = 0,
      StringOffset StepGoalLocalizeOffset = default(StringOffset),
      long StepEnterScenarioGroupId = 0,
      FlatDataJp.ParcelType StepEnterItemType = FlatDataJp.ParcelType.None,
      long StepEnterItemUniqueId = 0,
      long StepEnterItemAmount = 0,
      VectorOffset UnexpectedEventUnitIdOffset = default(VectorOffset),
      StringOffset UnexpectedEventPrefabOffset = default(StringOffset),
      long TreasureBoxObjectId = 0,
      int TreasureBoxCountPerStepOpen = 0) {
    builder.StartTable(12);
    ConquestStepExcel.AddTreasureBoxObjectId(builder, TreasureBoxObjectId);
    ConquestStepExcel.AddStepEnterItemAmount(builder, StepEnterItemAmount);
    ConquestStepExcel.AddStepEnterItemUniqueId(builder, StepEnterItemUniqueId);
    ConquestStepExcel.AddStepEnterScenarioGroupId(builder, StepEnterScenarioGroupId);
    ConquestStepExcel.AddEventContentId(builder, EventContentId);
    ConquestStepExcel.AddTreasureBoxCountPerStepOpen(builder, TreasureBoxCountPerStepOpen);
    ConquestStepExcel.AddUnexpectedEventPrefab(builder, UnexpectedEventPrefabOffset);
    ConquestStepExcel.AddUnexpectedEventUnitId(builder, UnexpectedEventUnitIdOffset);
    ConquestStepExcel.AddStepEnterItemType(builder, StepEnterItemType);
    ConquestStepExcel.AddStepGoalLocalize(builder, StepGoalLocalizeOffset);
    ConquestStepExcel.AddStep(builder, Step);
    ConquestStepExcel.AddMapDifficulty(builder, MapDifficulty);
    return ConquestStepExcel.EndConquestStepExcel(builder);
  }

  public static void StartConquestStepExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, FlatDataJp.StageDifficulty MapDifficulty) { builder.AddInt(1, (int)MapDifficulty, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(2, Step, 0); }
  public static void AddStepGoalLocalize(FlatBufferBuilder builder, StringOffset StepGoalLocalizeOffset) { builder.AddOffset(3, StepGoalLocalizeOffset.Value, 0); }
  public static void AddStepEnterScenarioGroupId(FlatBufferBuilder builder, long StepEnterScenarioGroupId) { builder.AddLong(4, StepEnterScenarioGroupId, 0); }
  public static void AddStepEnterItemType(FlatBufferBuilder builder, FlatDataJp.ParcelType StepEnterItemType) { builder.AddInt(5, (int)StepEnterItemType, 0); }
  public static void AddStepEnterItemUniqueId(FlatBufferBuilder builder, long StepEnterItemUniqueId) { builder.AddLong(6, StepEnterItemUniqueId, 0); }
  public static void AddStepEnterItemAmount(FlatBufferBuilder builder, long StepEnterItemAmount) { builder.AddLong(7, StepEnterItemAmount, 0); }
  public static void AddUnexpectedEventUnitId(FlatBufferBuilder builder, VectorOffset UnexpectedEventUnitIdOffset) { builder.AddOffset(8, UnexpectedEventUnitIdOffset.Value, 0); }
  public static VectorOffset CreateUnexpectedEventUnitIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnexpectedEventUnitIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddUnexpectedEventPrefab(FlatBufferBuilder builder, StringOffset UnexpectedEventPrefabOffset) { builder.AddOffset(9, UnexpectedEventPrefabOffset.Value, 0); }
  public static void AddTreasureBoxObjectId(FlatBufferBuilder builder, long TreasureBoxObjectId) { builder.AddLong(10, TreasureBoxObjectId, 0); }
  public static void AddTreasureBoxCountPerStepOpen(FlatBufferBuilder builder, int TreasureBoxCountPerStepOpen) { builder.AddInt(11, TreasureBoxCountPerStepOpen, 0); }
  public static Offset<FlatDataJp.ConquestStepExcel> EndConquestStepExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConquestStepExcel>(o);
  }
}


}
