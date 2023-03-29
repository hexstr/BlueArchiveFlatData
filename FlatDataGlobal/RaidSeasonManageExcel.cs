// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RaidSeasonManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static RaidSeasonManageExcel GetRootAsRaidSeasonManageExcel(ByteBuffer _bb) { return GetRootAsRaidSeasonManageExcel(_bb, new RaidSeasonManageExcel()); }
  public static RaidSeasonManageExcel GetRootAsRaidSeasonManageExcel(ByteBuffer _bb, RaidSeasonManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidSeasonManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonDisplay { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SeasonStartData { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonStartDataBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSeasonStartDataBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSeasonStartDataArray() { return __p.__vector_as_array<byte>(8); }
  public string SeasonEndData { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonEndDataBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSeasonEndDataBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSeasonEndDataArray() { return __p.__vector_as_array<byte>(10); }
  public string SettlementEndDate { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSettlementEndDateBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSettlementEndDateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSettlementEndDateArray() { return __p.__vector_as_array<byte>(12); }
  public string OpenRaidBossGroup(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int OpenRaidBossGroupLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long RankingRewardGroupId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxSeasonRewardGauage { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StackedSeasonRewardGauge(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StackedSeasonRewardGaugeLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetStackedSeasonRewardGaugeArray() { return __p.__vector_as_array<long>(20); }
  public long SeasonRewardId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetSeasonRewardIdArray() { return __p.__vector_as_array<long>(22); }

  public static Offset<FlatDataGlobal.RaidSeasonManageExcel> CreateRaidSeasonManageExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long SeasonDisplay = 0,
      StringOffset SeasonStartDataOffset = default(StringOffset),
      StringOffset SeasonEndDataOffset = default(StringOffset),
      StringOffset SettlementEndDateOffset = default(StringOffset),
      VectorOffset OpenRaidBossGroupOffset = default(VectorOffset),
      long RankingRewardGroupId = 0,
      int MaxSeasonRewardGauage = 0,
      VectorOffset StackedSeasonRewardGaugeOffset = default(VectorOffset),
      VectorOffset SeasonRewardIdOffset = default(VectorOffset)) {
    builder.StartTable(10);
    RaidSeasonManageExcel.AddRankingRewardGroupId(builder, RankingRewardGroupId);
    RaidSeasonManageExcel.AddSeasonDisplay(builder, SeasonDisplay);
    RaidSeasonManageExcel.AddSeasonId(builder, SeasonId);
    RaidSeasonManageExcel.AddSeasonRewardId(builder, SeasonRewardIdOffset);
    RaidSeasonManageExcel.AddStackedSeasonRewardGauge(builder, StackedSeasonRewardGaugeOffset);
    RaidSeasonManageExcel.AddMaxSeasonRewardGauage(builder, MaxSeasonRewardGauage);
    RaidSeasonManageExcel.AddOpenRaidBossGroup(builder, OpenRaidBossGroupOffset);
    RaidSeasonManageExcel.AddSettlementEndDate(builder, SettlementEndDateOffset);
    RaidSeasonManageExcel.AddSeasonEndData(builder, SeasonEndDataOffset);
    RaidSeasonManageExcel.AddSeasonStartData(builder, SeasonStartDataOffset);
    return RaidSeasonManageExcel.EndRaidSeasonManageExcel(builder);
  }

  public static void StartRaidSeasonManageExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddSeasonId(FlatBufferBuilder builder, long SeasonId) { builder.AddLong(0, SeasonId, 0); }
  public static void AddSeasonDisplay(FlatBufferBuilder builder, long SeasonDisplay) { builder.AddLong(1, SeasonDisplay, 0); }
  public static void AddSeasonStartData(FlatBufferBuilder builder, StringOffset SeasonStartDataOffset) { builder.AddOffset(2, SeasonStartDataOffset.Value, 0); }
  public static void AddSeasonEndData(FlatBufferBuilder builder, StringOffset SeasonEndDataOffset) { builder.AddOffset(3, SeasonEndDataOffset.Value, 0); }
  public static void AddSettlementEndDate(FlatBufferBuilder builder, StringOffset SettlementEndDateOffset) { builder.AddOffset(4, SettlementEndDateOffset.Value, 0); }
  public static void AddOpenRaidBossGroup(FlatBufferBuilder builder, VectorOffset OpenRaidBossGroupOffset) { builder.AddOffset(5, OpenRaidBossGroupOffset.Value, 0); }
  public static VectorOffset CreateOpenRaidBossGroupVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOpenRaidBossGroupVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRankingRewardGroupId(FlatBufferBuilder builder, long RankingRewardGroupId) { builder.AddLong(6, RankingRewardGroupId, 0); }
  public static void AddMaxSeasonRewardGauage(FlatBufferBuilder builder, int MaxSeasonRewardGauage) { builder.AddInt(7, MaxSeasonRewardGauage, 0); }
  public static void AddStackedSeasonRewardGauge(FlatBufferBuilder builder, VectorOffset StackedSeasonRewardGaugeOffset) { builder.AddOffset(8, StackedSeasonRewardGaugeOffset.Value, 0); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, VectorOffset SeasonRewardIdOffset) { builder.AddOffset(9, SeasonRewardIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.RaidSeasonManageExcel> EndRaidSeasonManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.RaidSeasonManageExcel>(o);
  }
}


}
