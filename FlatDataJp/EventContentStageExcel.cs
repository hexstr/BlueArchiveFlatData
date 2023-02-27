// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentStageExcel GetRootAsEventContentStageExcel(ByteBuffer _bb) { return GetRootAsEventContentStageExcel(_bb, new EventContentStageExcel()); }
  public static EventContentStageExcel GetRootAsEventContentStageExcel(ByteBuffer _bb, EventContentStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public long EventContentId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.StageDifficulty StageDifficulty { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageDifficulty.None; } }
  public string StageNumber { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageNumberBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStageNumberBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStageNumberArray() { return __p.__vector_as_array<byte>(12); }
  public int StageDisplay { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long PrevStageId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenDate { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenEventPoint { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenConditionScenarioId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType StageEnterCostType { get { int o = __p.__offset(26); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(38); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(40, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(40); }
  public string StrategyMap { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(42); }
  public string StrategyMapBG { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(44); }
  public long EventContentStageRewardId { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.StageTopography StageTopography { get { int o = __p.__offset(50); return o != 0 ? (FlatDataJp.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(54); }
  public FlatDataJp.StrategyEnvironment StrategyEnvironment { get { int o = __p.__offset(56); return o != 0 ? (FlatDataJp.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StrategyEnvironment.None; } }
  public long GroundID { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ContentType ContentType { get { int o = __p.__offset(60); return o != 0 ? (FlatDataJp.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool InstantClear { get { int o = __p.__offset(64); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long BuffContentId { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ChallengeDisplay { get { int o = __p.__offset(68); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.EventContentStageExcel> CreateEventContentStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      long EventContentId = 0,
      FlatDataJp.StageDifficulty StageDifficulty = FlatDataJp.StageDifficulty.None,
      StringOffset StageNumberOffset = default(StringOffset),
      int StageDisplay = 0,
      long PrevStageId = 0,
      long OpenDate = 0,
      long OpenEventPoint = 0,
      long OpenConditionScenarioId = 0,
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
      long EventContentStageRewardId = 0,
      int MaxTurn = 0,
      FlatDataJp.StageTopography StageTopography = FlatDataJp.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      FlatDataJp.StrategyEnvironment StrategyEnvironment = FlatDataJp.StrategyEnvironment.None,
      long GroundID = 0,
      FlatDataJp.ContentType ContentType = FlatDataJp.ContentType.None,
      long BGMId = 0,
      bool InstantClear = false,
      long BuffContentId = 0,
      bool ChallengeDisplay = false) {
    builder.StartTable(33);
    EventContentStageExcel.AddBuffContentId(builder, BuffContentId);
    EventContentStageExcel.AddBGMId(builder, BGMId);
    EventContentStageExcel.AddGroundID(builder, GroundID);
    EventContentStageExcel.AddEventContentStageRewardId(builder, EventContentStageRewardId);
    EventContentStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    EventContentStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    EventContentStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    EventContentStageExcel.AddBattleDuration(builder, BattleDuration);
    EventContentStageExcel.AddOpenConditionScenarioId(builder, OpenConditionScenarioId);
    EventContentStageExcel.AddOpenEventPoint(builder, OpenEventPoint);
    EventContentStageExcel.AddOpenDate(builder, OpenDate);
    EventContentStageExcel.AddPrevStageId(builder, PrevStageId);
    EventContentStageExcel.AddEventContentId(builder, EventContentId);
    EventContentStageExcel.AddId(builder, Id);
    EventContentStageExcel.AddContentType(builder, ContentType);
    EventContentStageExcel.AddStrategyEnvironment(builder, StrategyEnvironment);
    EventContentStageExcel.AddBgmId(builder, BgmIdOffset);
    EventContentStageExcel.AddRecommandLevel(builder, RecommandLevel);
    EventContentStageExcel.AddStageTopography(builder, StageTopography);
    EventContentStageExcel.AddMaxTurn(builder, MaxTurn);
    EventContentStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    EventContentStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    EventContentStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    EventContentStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    EventContentStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    EventContentStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    EventContentStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    EventContentStageExcel.AddStageDisplay(builder, StageDisplay);
    EventContentStageExcel.AddStageNumber(builder, StageNumberOffset);
    EventContentStageExcel.AddStageDifficulty(builder, StageDifficulty);
    EventContentStageExcel.AddName(builder, NameOffset);
    EventContentStageExcel.AddChallengeDisplay(builder, ChallengeDisplay);
    EventContentStageExcel.AddInstantClear(builder, InstantClear);
    return EventContentStageExcel.EndEventContentStageExcel(builder);
  }

  public static void StartEventContentStageExcel(FlatBufferBuilder builder) { builder.StartTable(33); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(2, EventContentId, 0); }
  public static void AddStageDifficulty(FlatBufferBuilder builder, FlatDataJp.StageDifficulty StageDifficulty) { builder.AddInt(3, (int)StageDifficulty, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset StageNumberOffset) { builder.AddOffset(4, StageNumberOffset.Value, 0); }
  public static void AddStageDisplay(FlatBufferBuilder builder, int StageDisplay) { builder.AddInt(5, StageDisplay, 0); }
  public static void AddPrevStageId(FlatBufferBuilder builder, long PrevStageId) { builder.AddLong(6, PrevStageId, 0); }
  public static void AddOpenDate(FlatBufferBuilder builder, long OpenDate) { builder.AddLong(7, OpenDate, 0); }
  public static void AddOpenEventPoint(FlatBufferBuilder builder, long OpenEventPoint) { builder.AddLong(8, OpenEventPoint, 0); }
  public static void AddOpenConditionScenarioId(FlatBufferBuilder builder, long OpenConditionScenarioId) { builder.AddLong(9, OpenConditionScenarioId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(10, BattleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, FlatDataJp.ParcelType StageEnterCostType) { builder.AddInt(11, (int)StageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long StageEnterCostId) { builder.AddLong(12, StageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int StageEnterCostAmount) { builder.AddInt(13, StageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int StageEnterEchelonCount) { builder.AddInt(14, StageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long StarConditionTacticRankSCount) { builder.AddLong(15, StarConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long StarConditionTurnCount) { builder.AddLong(16, StarConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset EnterScenarioGroupIdOffset) { builder.AddOffset(17, EnterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset ClearScenarioGroupIdOffset) { builder.AddOffset(18, ClearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset StrategyMapOffset) { builder.AddOffset(19, StrategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset StrategyMapBGOffset) { builder.AddOffset(20, StrategyMapBGOffset.Value, 0); }
  public static void AddEventContentStageRewardId(FlatBufferBuilder builder, long EventContentStageRewardId) { builder.AddLong(21, EventContentStageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int MaxTurn) { builder.AddInt(22, MaxTurn, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatDataJp.StageTopography StageTopography) { builder.AddInt(23, (int)StageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int RecommandLevel) { builder.AddInt(24, RecommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset BgmIdOffset) { builder.AddOffset(25, BgmIdOffset.Value, 0); }
  public static void AddStrategyEnvironment(FlatBufferBuilder builder, FlatDataJp.StrategyEnvironment StrategyEnvironment) { builder.AddInt(26, (int)StrategyEnvironment, 0); }
  public static void AddGroundID(FlatBufferBuilder builder, long GroundID) { builder.AddLong(27, GroundID, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatDataJp.ContentType ContentType) { builder.AddInt(28, (int)ContentType, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(29, BGMId, 0); }
  public static void AddInstantClear(FlatBufferBuilder builder, bool InstantClear) { builder.AddBool(30, InstantClear, false); }
  public static void AddBuffContentId(FlatBufferBuilder builder, long BuffContentId) { builder.AddLong(31, BuffContentId, 0); }
  public static void AddChallengeDisplay(FlatBufferBuilder builder, bool ChallengeDisplay) { builder.AddBool(32, ChallengeDisplay, false); }
  public static Offset<FlatDataJp.EventContentStageExcel> EndEventContentStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentStageExcel>(o);
  }
}


}
