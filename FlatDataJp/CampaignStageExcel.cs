// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb) { return GetRootAsCampaignStageExcel(_bb, new CampaignStageExcel()); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb, CampaignStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string StageNumber { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageNumberBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStageNumberBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStageNumberArray() { return __p.__vector_as_array<byte>(8); }
  public long CleardScenarioId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType StageEnterCostType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(26); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(28); }
  public string StrategyMap { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(30); }
  public string StrategyMapBG { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(32); }
  public long CampaignStageRewardId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.StageTopography Stagetopography { get { int o = __p.__offset(38); return o != 0 ? (FlatDataJp.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(42); }
  public FlatDataJp.StrategyEnvironment Strategyenvironment { get { int o = __p.__offset(44); return o != 0 ? (FlatDataJp.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StrategyEnvironment.None; } }
  public long GroundId { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ContentType Contenttype { get { int o = __p.__offset(48); return o != 0 ? (FlatDataJp.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string FirstClearReportEventName { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearReportEventNameBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetFirstClearReportEventNameBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetFirstClearReportEventNameArray() { return __p.__vector_as_array<byte>(52); }
  public long TacticRewardExp { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.CampaignStageExcel> CreateCampaignStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset StageNumberOffset = default(StringOffset),
      long CleardScenarioId = 0,
      long BattleDuration = 0,
      FlatDataJp.ParcelType StageEnterCostType = FlatDataJp.ParcelType.None,
      long StageEnterCostId = 0,
      int StageEnterCostAmount = 0,
      int StageEnterEchelonCount = 0,
      long StarConditionTacticRankSCount = 0,
      long StarConditionTurnCount = 0,
      VectorOffset EnterScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ClearScenarioGroupIdOffset = default(VectorOffset),
      StringOffset StrategyMapOffset = default(StringOffset),
      StringOffset StrategyMapBGOffset = default(StringOffset),
      long CampaignStageRewardId = 0,
      int MaxTurn = 0,
      FlatDataJp.StageTopography stagetopography = FlatDataJp.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      FlatDataJp.StrategyEnvironment strategyenvironment = FlatDataJp.StrategyEnvironment.None,
      long GroundId = 0,
      FlatDataJp.ContentType contenttype = FlatDataJp.ContentType.None,
      long BGMId = 0,
      StringOffset FirstClearReportEventNameOffset = default(StringOffset),
      long TacticRewardExp = 0,
      long FixedEchelonId = 0) {
    builder.StartTable(27);
    CampaignStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    CampaignStageExcel.AddTacticRewardExp(builder, TacticRewardExp);
    CampaignStageExcel.AddBGMId(builder, BGMId);
    CampaignStageExcel.AddGroundId(builder, GroundId);
    CampaignStageExcel.AddCampaignStageRewardId(builder, CampaignStageRewardId);
    CampaignStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    CampaignStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    CampaignStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    CampaignStageExcel.AddBattleDuration(builder, BattleDuration);
    CampaignStageExcel.AddCleardScenarioId(builder, CleardScenarioId);
    CampaignStageExcel.AddId(builder, Id);
    CampaignStageExcel.AddFirstClearReportEventName(builder, FirstClearReportEventNameOffset);
    CampaignStageExcel.AddContenttype(builder, contenttype);
    CampaignStageExcel.AddStrategyenvironment(builder, strategyenvironment);
    CampaignStageExcel.AddBgmId(builder, BgmIdOffset);
    CampaignStageExcel.AddRecommandLevel(builder, RecommandLevel);
    CampaignStageExcel.AddStagetopography(builder, stagetopography);
    CampaignStageExcel.AddMaxTurn(builder, MaxTurn);
    CampaignStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    CampaignStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    CampaignStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    CampaignStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    CampaignStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    CampaignStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    CampaignStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    CampaignStageExcel.AddStageNumber(builder, StageNumberOffset);
    CampaignStageExcel.AddName(builder, NameOffset);
    return CampaignStageExcel.EndCampaignStageExcel(builder);
  }

  public static void StartCampaignStageExcel(FlatBufferBuilder builder) { builder.StartTable(27); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset StageNumberOffset) { builder.AddOffset(2, StageNumberOffset.Value, 0); }
  public static void AddCleardScenarioId(FlatBufferBuilder builder, long CleardScenarioId) { builder.AddLong(3, CleardScenarioId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(4, BattleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, FlatDataJp.ParcelType StageEnterCostType) { builder.AddInt(5, (int)StageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long StageEnterCostId) { builder.AddLong(6, StageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int StageEnterCostAmount) { builder.AddInt(7, StageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int StageEnterEchelonCount) { builder.AddInt(8, StageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long StarConditionTacticRankSCount) { builder.AddLong(9, StarConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long StarConditionTurnCount) { builder.AddLong(10, StarConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset EnterScenarioGroupIdOffset) { builder.AddOffset(11, EnterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset ClearScenarioGroupIdOffset) { builder.AddOffset(12, ClearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset StrategyMapOffset) { builder.AddOffset(13, StrategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset StrategyMapBGOffset) { builder.AddOffset(14, StrategyMapBGOffset.Value, 0); }
  public static void AddCampaignStageRewardId(FlatBufferBuilder builder, long CampaignStageRewardId) { builder.AddLong(15, CampaignStageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int MaxTurn) { builder.AddInt(16, MaxTurn, 0); }
  public static void AddStagetopography(FlatBufferBuilder builder, FlatDataJp.StageTopography stagetopography) { builder.AddInt(17, (int)stagetopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int RecommandLevel) { builder.AddInt(18, RecommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset BgmIdOffset) { builder.AddOffset(19, BgmIdOffset.Value, 0); }
  public static void AddStrategyenvironment(FlatBufferBuilder builder, FlatDataJp.StrategyEnvironment strategyenvironment) { builder.AddInt(20, (int)strategyenvironment, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(21, GroundId, 0); }
  public static void AddContenttype(FlatBufferBuilder builder, FlatDataJp.ContentType contenttype) { builder.AddInt(22, (int)contenttype, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(23, BGMId, 0); }
  public static void AddFirstClearReportEventName(FlatBufferBuilder builder, StringOffset FirstClearReportEventNameOffset) { builder.AddOffset(24, FirstClearReportEventNameOffset.Value, 0); }
  public static void AddTacticRewardExp(FlatBufferBuilder builder, long TacticRewardExp) { builder.AddLong(25, TacticRewardExp, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long FixedEchelonId) { builder.AddLong(26, FixedEchelonId, 0); }
  public static Offset<FlatDataJp.CampaignStageExcel> EndCampaignStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CampaignStageExcel>(o);
  }
}


}
