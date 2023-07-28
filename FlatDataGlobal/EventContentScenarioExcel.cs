// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentScenarioExcel GetRootAsEventContentScenarioExcel(ByteBuffer _bb) { return GetRootAsEventContentScenarioExcel(_bb, new EventContentScenarioExcel()); }
  public static EventContentScenarioExcel GetRootAsEventContentScenarioExcel(ByteBuffer _bb, EventContentScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Order { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecollectionNumber { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsRecollection { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsMeetup { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsOmnibus { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long ScenarioGroupId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ScenarioGroupIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetScenarioGroupIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetScenarioGroupIdArray() { return __p.__vector_as_array<long>(18); }
  public FlatDataGlobal.EventContentScenarioConditionType ScenarioConditionType { get { int o = __p.__offset(20); return o != 0 ? (FlatDataGlobal.EventContentScenarioConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentScenarioConditionType.None; } }
  public long ConditionAmount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConditionEventContentId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearedScenarioGroupId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint RecollectionSummaryLocalizeScenarioId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string RecollectionResource { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRecollectionResourceBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetRecollectionResourceBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetRecollectionResourceArray() { return __p.__vector_as_array<byte>(30); }
  public bool IsRecollectionHorizon { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.ParcelType CostParcelType { get { int o = __p.__offset(34); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long CostId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int CostAmount { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.ParcelType RewardParcelType(int j) { int o = __p.__offset(40); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(40, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public FlatDataGlobal.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(40); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardId(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardIdLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardIdBytes() { return __p.__vector_as_span<long>(42, 8); }
#else
  public ArraySegment<byte>? GetRewardIdBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public long[] GetRewardIdArray() { return __p.__vector_as_array<long>(42); }
  public int RewardAmount(int j) { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RewardAmountLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRewardAmountBytes() { return __p.__vector_as_span<int>(44, 4); }
#else
  public ArraySegment<byte>? GetRewardAmountBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public int[] GetRewardAmountArray() { return __p.__vector_as_array<int>(44); }

  public static Offset<FlatDataGlobal.EventContentScenarioExcel> CreateEventContentScenarioExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long Order = 0,
      long RecollectionNumber = 0,
      bool IsRecollection = false,
      bool IsMeetup = false,
      bool IsOmnibus = false,
      VectorOffset ScenarioGroupIdOffset = default(VectorOffset),
      FlatDataGlobal.EventContentScenarioConditionType ScenarioConditionType = FlatDataGlobal.EventContentScenarioConditionType.None,
      long ConditionAmount = 0,
      long ConditionEventContentId = 0,
      long ClearedScenarioGroupId = 0,
      uint RecollectionSummaryLocalizeScenarioId = 0,
      StringOffset RecollectionResourceOffset = default(StringOffset),
      bool IsRecollectionHorizon = false,
      FlatDataGlobal.ParcelType CostParcelType = FlatDataGlobal.ParcelType.None,
      long CostId = 0,
      int CostAmount = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardIdOffset = default(VectorOffset),
      VectorOffset RewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(21);
    EventContentScenarioExcel.AddCostId(builder, CostId);
    EventContentScenarioExcel.AddClearedScenarioGroupId(builder, ClearedScenarioGroupId);
    EventContentScenarioExcel.AddConditionEventContentId(builder, ConditionEventContentId);
    EventContentScenarioExcel.AddConditionAmount(builder, ConditionAmount);
    EventContentScenarioExcel.AddRecollectionNumber(builder, RecollectionNumber);
    EventContentScenarioExcel.AddOrder(builder, Order);
    EventContentScenarioExcel.AddEventContentId(builder, EventContentId);
    EventContentScenarioExcel.AddId(builder, Id);
    EventContentScenarioExcel.AddRewardAmount(builder, RewardAmountOffset);
    EventContentScenarioExcel.AddRewardId(builder, RewardIdOffset);
    EventContentScenarioExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentScenarioExcel.AddCostAmount(builder, CostAmount);
    EventContentScenarioExcel.AddCostParcelType(builder, CostParcelType);
    EventContentScenarioExcel.AddRecollectionResource(builder, RecollectionResourceOffset);
    EventContentScenarioExcel.AddRecollectionSummaryLocalizeScenarioId(builder, RecollectionSummaryLocalizeScenarioId);
    EventContentScenarioExcel.AddScenarioConditionType(builder, ScenarioConditionType);
    EventContentScenarioExcel.AddScenarioGroupId(builder, ScenarioGroupIdOffset);
    EventContentScenarioExcel.AddIsRecollectionHorizon(builder, IsRecollectionHorizon);
    EventContentScenarioExcel.AddIsOmnibus(builder, IsOmnibus);
    EventContentScenarioExcel.AddIsMeetup(builder, IsMeetup);
    EventContentScenarioExcel.AddIsRecollection(builder, IsRecollection);
    return EventContentScenarioExcel.EndEventContentScenarioExcel(builder);
  }

  public static void StartEventContentScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(21); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddOrder(FlatBufferBuilder builder, long Order) { builder.AddLong(2, Order, 0); }
  public static void AddRecollectionNumber(FlatBufferBuilder builder, long RecollectionNumber) { builder.AddLong(3, RecollectionNumber, 0); }
  public static void AddIsRecollection(FlatBufferBuilder builder, bool IsRecollection) { builder.AddBool(4, IsRecollection, false); }
  public static void AddIsMeetup(FlatBufferBuilder builder, bool IsMeetup) { builder.AddBool(5, IsMeetup, false); }
  public static void AddIsOmnibus(FlatBufferBuilder builder, bool IsOmnibus) { builder.AddBool(6, IsOmnibus, false); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, VectorOffset ScenarioGroupIdOffset) { builder.AddOffset(7, ScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddScenarioConditionType(FlatBufferBuilder builder, FlatDataGlobal.EventContentScenarioConditionType ScenarioConditionType) { builder.AddInt(8, (int)ScenarioConditionType, 0); }
  public static void AddConditionAmount(FlatBufferBuilder builder, long ConditionAmount) { builder.AddLong(9, ConditionAmount, 0); }
  public static void AddConditionEventContentId(FlatBufferBuilder builder, long ConditionEventContentId) { builder.AddLong(10, ConditionEventContentId, 0); }
  public static void AddClearedScenarioGroupId(FlatBufferBuilder builder, long ClearedScenarioGroupId) { builder.AddLong(11, ClearedScenarioGroupId, 0); }
  public static void AddRecollectionSummaryLocalizeScenarioId(FlatBufferBuilder builder, uint RecollectionSummaryLocalizeScenarioId) { builder.AddUint(12, RecollectionSummaryLocalizeScenarioId, 0); }
  public static void AddRecollectionResource(FlatBufferBuilder builder, StringOffset RecollectionResourceOffset) { builder.AddOffset(13, RecollectionResourceOffset.Value, 0); }
  public static void AddIsRecollectionHorizon(FlatBufferBuilder builder, bool IsRecollectionHorizon) { builder.AddBool(14, IsRecollectionHorizon, false); }
  public static void AddCostParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType CostParcelType) { builder.AddInt(15, (int)CostParcelType, 0); }
  public static void AddCostId(FlatBufferBuilder builder, long CostId) { builder.AddLong(16, CostId, 0); }
  public static void AddCostAmount(FlatBufferBuilder builder, int CostAmount) { builder.AddInt(17, CostAmount, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(18, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardId(FlatBufferBuilder builder, VectorOffset RewardIdOffset) { builder.AddOffset(19, RewardIdOffset.Value, 0); }
  public static VectorOffset CreateRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardAmount(FlatBufferBuilder builder, VectorOffset RewardAmountOffset) { builder.AddOffset(20, RewardAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.EventContentScenarioExcel> EndEventContentScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentScenarioExcel>(o);
  }
}


}
