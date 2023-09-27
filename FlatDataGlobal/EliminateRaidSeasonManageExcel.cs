// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EliminateRaidSeasonManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EliminateRaidSeasonManageExcel GetRootAsEliminateRaidSeasonManageExcel(ByteBuffer _bb) { return GetRootAsEliminateRaidSeasonManageExcel(_bb, new EliminateRaidSeasonManageExcel()); }
  public static EliminateRaidSeasonManageExcel GetRootAsEliminateRaidSeasonManageExcel(ByteBuffer _bb, EliminateRaidSeasonManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EliminateRaidSeasonManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public string LobbyTableBGPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyTableBGPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetLobbyTableBGPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetLobbyTableBGPathArray() { return __p.__vector_as_array<byte>(14); }
  public string LobbyScreenBGPath { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyScreenBGPathBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetLobbyScreenBGPathBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetLobbyScreenBGPathArray() { return __p.__vector_as_array<byte>(16); }
  public string OpenRaidBossGroup01 { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup01Bytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup01Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetOpenRaidBossGroup01Array() { return __p.__vector_as_array<byte>(18); }
  public string OpenRaidBossGroup02 { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup02Bytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup02Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetOpenRaidBossGroup02Array() { return __p.__vector_as_array<byte>(20); }
  public string OpenRaidBossGroup03 { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup03Bytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup03Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetOpenRaidBossGroup03Array() { return __p.__vector_as_array<byte>(22); }
  public long RankingRewardGroupId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxSeasonRewardGauage { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StackedSeasonRewardGauge(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StackedSeasonRewardGaugeLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetStackedSeasonRewardGaugeArray() { return __p.__vector_as_array<long>(28); }
  public long SeasonRewardId(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardIdBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetSeasonRewardIdArray() { return __p.__vector_as_array<long>(30); }

  public static Offset<FlatDataGlobal.EliminateRaidSeasonManageExcel> CreateEliminateRaidSeasonManageExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long SeasonDisplay = 0,
      StringOffset SeasonStartDataOffset = default(StringOffset),
      StringOffset SeasonEndDataOffset = default(StringOffset),
      StringOffset SettlementEndDateOffset = default(StringOffset),
      StringOffset LobbyTableBGPathOffset = default(StringOffset),
      StringOffset LobbyScreenBGPathOffset = default(StringOffset),
      StringOffset OpenRaidBossGroup01Offset = default(StringOffset),
      StringOffset OpenRaidBossGroup02Offset = default(StringOffset),
      StringOffset OpenRaidBossGroup03Offset = default(StringOffset),
      long RankingRewardGroupId = 0,
      int MaxSeasonRewardGauage = 0,
      VectorOffset StackedSeasonRewardGaugeOffset = default(VectorOffset),
      VectorOffset SeasonRewardIdOffset = default(VectorOffset)) {
    builder.StartTable(14);
    EliminateRaidSeasonManageExcel.AddRankingRewardGroupId(builder, RankingRewardGroupId);
    EliminateRaidSeasonManageExcel.AddSeasonDisplay(builder, SeasonDisplay);
    EliminateRaidSeasonManageExcel.AddSeasonId(builder, SeasonId);
    EliminateRaidSeasonManageExcel.AddSeasonRewardId(builder, SeasonRewardIdOffset);
    EliminateRaidSeasonManageExcel.AddStackedSeasonRewardGauge(builder, StackedSeasonRewardGaugeOffset);
    EliminateRaidSeasonManageExcel.AddMaxSeasonRewardGauage(builder, MaxSeasonRewardGauage);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup03(builder, OpenRaidBossGroup03Offset);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup02(builder, OpenRaidBossGroup02Offset);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup01(builder, OpenRaidBossGroup01Offset);
    EliminateRaidSeasonManageExcel.AddLobbyScreenBGPath(builder, LobbyScreenBGPathOffset);
    EliminateRaidSeasonManageExcel.AddLobbyTableBGPath(builder, LobbyTableBGPathOffset);
    EliminateRaidSeasonManageExcel.AddSettlementEndDate(builder, SettlementEndDateOffset);
    EliminateRaidSeasonManageExcel.AddSeasonEndData(builder, SeasonEndDataOffset);
    EliminateRaidSeasonManageExcel.AddSeasonStartData(builder, SeasonStartDataOffset);
    return EliminateRaidSeasonManageExcel.EndEliminateRaidSeasonManageExcel(builder);
  }

  public static void StartEliminateRaidSeasonManageExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddSeasonId(FlatBufferBuilder builder, long SeasonId) { builder.AddLong(0, SeasonId, 0); }
  public static void AddSeasonDisplay(FlatBufferBuilder builder, long SeasonDisplay) { builder.AddLong(1, SeasonDisplay, 0); }
  public static void AddSeasonStartData(FlatBufferBuilder builder, StringOffset SeasonStartDataOffset) { builder.AddOffset(2, SeasonStartDataOffset.Value, 0); }
  public static void AddSeasonEndData(FlatBufferBuilder builder, StringOffset SeasonEndDataOffset) { builder.AddOffset(3, SeasonEndDataOffset.Value, 0); }
  public static void AddSettlementEndDate(FlatBufferBuilder builder, StringOffset SettlementEndDateOffset) { builder.AddOffset(4, SettlementEndDateOffset.Value, 0); }
  public static void AddLobbyTableBGPath(FlatBufferBuilder builder, StringOffset LobbyTableBGPathOffset) { builder.AddOffset(5, LobbyTableBGPathOffset.Value, 0); }
  public static void AddLobbyScreenBGPath(FlatBufferBuilder builder, StringOffset LobbyScreenBGPathOffset) { builder.AddOffset(6, LobbyScreenBGPathOffset.Value, 0); }
  public static void AddOpenRaidBossGroup01(FlatBufferBuilder builder, StringOffset OpenRaidBossGroup01Offset) { builder.AddOffset(7, OpenRaidBossGroup01Offset.Value, 0); }
  public static void AddOpenRaidBossGroup02(FlatBufferBuilder builder, StringOffset OpenRaidBossGroup02Offset) { builder.AddOffset(8, OpenRaidBossGroup02Offset.Value, 0); }
  public static void AddOpenRaidBossGroup03(FlatBufferBuilder builder, StringOffset OpenRaidBossGroup03Offset) { builder.AddOffset(9, OpenRaidBossGroup03Offset.Value, 0); }
  public static void AddRankingRewardGroupId(FlatBufferBuilder builder, long RankingRewardGroupId) { builder.AddLong(10, RankingRewardGroupId, 0); }
  public static void AddMaxSeasonRewardGauage(FlatBufferBuilder builder, int MaxSeasonRewardGauage) { builder.AddInt(11, MaxSeasonRewardGauage, 0); }
  public static void AddStackedSeasonRewardGauge(FlatBufferBuilder builder, VectorOffset StackedSeasonRewardGaugeOffset) { builder.AddOffset(12, StackedSeasonRewardGaugeOffset.Value, 0); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, VectorOffset SeasonRewardIdOffset) { builder.AddOffset(13, SeasonRewardIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.EliminateRaidSeasonManageExcel> EndEliminateRaidSeasonManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EliminateRaidSeasonManageExcel>(o);
  }
}


}
