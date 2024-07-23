// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
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
  public FlatDataGlobal.StageDifficulty StageDifficulty { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StageDifficulty.None; } }
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
  public long PrevStageSubEventId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenConditionScenarioId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.EventContentType OpenConditionContentType { get { int o = __p.__offset(26); return o != 0 ? (FlatDataGlobal.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentType.Stage; } }
  public long OpenConditionContentId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType StageEnterCostType { get { int o = __p.__offset(32); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(44, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(44); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(46, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(46); }
  public string StrategyMap { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(48); }
  public string StrategyMapBG { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(50); }
  public long EventContentStageRewardId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.StageTopography StageTopography { get { int o = __p.__offset(56); return o != 0 ? (FlatDataGlobal.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(60); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(60, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(60); }
  public FlatDataGlobal.StrategyEnvironment StrategyEnvironment { get { int o = __p.__offset(62); return o != 0 ? (FlatDataGlobal.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StrategyEnvironment.None; } }
  public long GroundID { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ContentType ContentType { get { int o = __p.__offset(66); return o != 0 ? (FlatDataGlobal.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool InstantClear { get { int o = __p.__offset(70); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long BuffContentId { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ChallengeDisplay { get { int o = __p.__offset(76); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.StarGoalType StarGoal(int j) { int o = __p.__offset(78); return o != 0 ? (FlatDataGlobal.StarGoalType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.StarGoalType)0; }
  public int StarGoalLength { get { int o = __p.__offset(78); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.StarGoalType> GetStarGoalBytes() { return __p.__vector_as_span<FlatDataGlobal.StarGoalType>(78, 4); }
#else
  public ArraySegment<byte>? GetStarGoalBytes() { return __p.__vector_as_arraysegment(78); }
#endif
  public FlatDataGlobal.StarGoalType[] GetStarGoalArray() { int o = __p.__offset(78); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.StarGoalType[] a = new FlatDataGlobal.StarGoalType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.StarGoalType)__p.bb.GetInt(p + i * 4); } return a; }
  public int StarGoalAmount(int j) { int o = __p.__offset(80); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StarGoalAmountLength { get { int o = __p.__offset(80); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStarGoalAmountBytes() { return __p.__vector_as_span<int>(80, 4); }
#else
  public ArraySegment<byte>? GetStarGoalAmountBytes() { return __p.__vector_as_arraysegment(80); }
#endif
  public int[] GetStarGoalAmountArray() { return __p.__vector_as_array<int>(80); }
  public bool IsDefeatBattle { get { int o = __p.__offset(82); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint StageHint { get { int o = __p.__offset(84); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataGlobal.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(86); return o != 0 ? (FlatDataGlobal.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EchelonExtensionType.Base; } }

  public static Offset<FlatDataGlobal.EventContentStageExcel> CreateEventContentStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      long EventContentId = 0,
      FlatDataGlobal.StageDifficulty stageDifficulty = FlatDataGlobal.StageDifficulty.None,
      StringOffset StageNumberOffset = default(StringOffset),
      int StageDisplay = 0,
      long PrevStageId = 0,
      long OpenDate = 0,
      long OpenEventPoint = 0,
      long PrevStageSubEventId = 0,
      long OpenConditionScenarioId = 0,
      FlatDataGlobal.EventContentType OpenConditionContentType = FlatDataGlobal.EventContentType.Stage,
      long OpenConditionContentId = 0,
      long BattleDuration = 0,
      FlatDataGlobal.ParcelType StageEnterCostType = FlatDataGlobal.ParcelType.None,
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
      FlatDataGlobal.StageTopography stageTopography = FlatDataGlobal.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      FlatDataGlobal.StrategyEnvironment strategyEnvironment = FlatDataGlobal.StrategyEnvironment.None,
      long GroundID = 0,
      FlatDataGlobal.ContentType contentType = FlatDataGlobal.ContentType.None,
      long BGMId = 0,
      bool InstantClear = false,
      long BuffContentId = 0,
      long FixedEchelonId = 0,
      bool ChallengeDisplay = false,
      VectorOffset StarGoalOffset = default(VectorOffset),
      VectorOffset StarGoalAmountOffset = default(VectorOffset),
      bool IsDefeatBattle = false,
      uint StageHint = 0,
      FlatDataGlobal.EchelonExtensionType echelonExtensionType = FlatDataGlobal.EchelonExtensionType.Base) {
    builder.StartTable(42);
    EventContentStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    EventContentStageExcel.AddBuffContentId(builder, BuffContentId);
    EventContentStageExcel.AddBGMId(builder, BGMId);
    EventContentStageExcel.AddGroundID(builder, GroundID);
    EventContentStageExcel.AddEventContentStageRewardId(builder, EventContentStageRewardId);
    EventContentStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    EventContentStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    EventContentStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    EventContentStageExcel.AddBattleDuration(builder, BattleDuration);
    EventContentStageExcel.AddOpenConditionContentId(builder, OpenConditionContentId);
    EventContentStageExcel.AddOpenConditionScenarioId(builder, OpenConditionScenarioId);
    EventContentStageExcel.AddPrevStageSubEventId(builder, PrevStageSubEventId);
    EventContentStageExcel.AddOpenEventPoint(builder, OpenEventPoint);
    EventContentStageExcel.AddOpenDate(builder, OpenDate);
    EventContentStageExcel.AddPrevStageId(builder, PrevStageId);
    EventContentStageExcel.AddEventContentId(builder, EventContentId);
    EventContentStageExcel.AddId(builder, Id);
    EventContentStageExcel.AddEchelonExtensionType(builder, echelonExtensionType);
    EventContentStageExcel.AddStageHint(builder, StageHint);
    EventContentStageExcel.AddStarGoalAmount(builder, StarGoalAmountOffset);
    EventContentStageExcel.AddStarGoal(builder, StarGoalOffset);
    EventContentStageExcel.AddContentType(builder, contentType);
    EventContentStageExcel.AddStrategyEnvironment(builder, strategyEnvironment);
    EventContentStageExcel.AddBgmId(builder, BgmIdOffset);
    EventContentStageExcel.AddRecommandLevel(builder, RecommandLevel);
    EventContentStageExcel.AddStageTopography(builder, stageTopography);
    EventContentStageExcel.AddMaxTurn(builder, MaxTurn);
    EventContentStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    EventContentStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    EventContentStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    EventContentStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    EventContentStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    EventContentStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    EventContentStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    EventContentStageExcel.AddOpenConditionContentType(builder, OpenConditionContentType);
    EventContentStageExcel.AddStageDisplay(builder, StageDisplay);
    EventContentStageExcel.AddStageNumber(builder, StageNumberOffset);
    EventContentStageExcel.AddStageDifficulty(builder, stageDifficulty);
    EventContentStageExcel.AddName(builder, NameOffset);
    EventContentStageExcel.AddIsDefeatBattle(builder, IsDefeatBattle);
    EventContentStageExcel.AddChallengeDisplay(builder, ChallengeDisplay);
    EventContentStageExcel.AddInstantClear(builder, InstantClear);
    return EventContentStageExcel.EndEventContentStageExcel(builder);
  }

  public static void StartEventContentStageExcel(FlatBufferBuilder builder) { builder.StartTable(42); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(2, EventContentId, 0); }
  public static void AddStageDifficulty(FlatBufferBuilder builder, FlatDataGlobal.StageDifficulty stageDifficulty) { builder.AddInt(3, (int)stageDifficulty, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset StageNumberOffset) { builder.AddOffset(4, StageNumberOffset.Value, 0); }
  public static void AddStageDisplay(FlatBufferBuilder builder, int StageDisplay) { builder.AddInt(5, StageDisplay, 0); }
  public static void AddPrevStageId(FlatBufferBuilder builder, long PrevStageId) { builder.AddLong(6, PrevStageId, 0); }
  public static void AddOpenDate(FlatBufferBuilder builder, long OpenDate) { builder.AddLong(7, OpenDate, 0); }
  public static void AddOpenEventPoint(FlatBufferBuilder builder, long OpenEventPoint) { builder.AddLong(8, OpenEventPoint, 0); }
  public static void AddPrevStageSubEventId(FlatBufferBuilder builder, long PrevStageSubEventId) { builder.AddLong(9, PrevStageSubEventId, 0); }
  public static void AddOpenConditionScenarioId(FlatBufferBuilder builder, long OpenConditionScenarioId) { builder.AddLong(10, OpenConditionScenarioId, 0); }
  public static void AddOpenConditionContentType(FlatBufferBuilder builder, FlatDataGlobal.EventContentType OpenConditionContentType) { builder.AddInt(11, (int)OpenConditionContentType, 0); }
  public static void AddOpenConditionContentId(FlatBufferBuilder builder, long OpenConditionContentId) { builder.AddLong(12, OpenConditionContentId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(13, BattleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType StageEnterCostType) { builder.AddInt(14, (int)StageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long StageEnterCostId) { builder.AddLong(15, StageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int StageEnterCostAmount) { builder.AddInt(16, StageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int StageEnterEchelonCount) { builder.AddInt(17, StageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long StarConditionTacticRankSCount) { builder.AddLong(18, StarConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long StarConditionTurnCount) { builder.AddLong(19, StarConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset EnterScenarioGroupIdOffset) { builder.AddOffset(20, EnterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset ClearScenarioGroupIdOffset) { builder.AddOffset(21, ClearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset StrategyMapOffset) { builder.AddOffset(22, StrategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset StrategyMapBGOffset) { builder.AddOffset(23, StrategyMapBGOffset.Value, 0); }
  public static void AddEventContentStageRewardId(FlatBufferBuilder builder, long EventContentStageRewardId) { builder.AddLong(24, EventContentStageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int MaxTurn) { builder.AddInt(25, MaxTurn, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatDataGlobal.StageTopography stageTopography) { builder.AddInt(26, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int RecommandLevel) { builder.AddInt(27, RecommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset BgmIdOffset) { builder.AddOffset(28, BgmIdOffset.Value, 0); }
  public static void AddStrategyEnvironment(FlatBufferBuilder builder, FlatDataGlobal.StrategyEnvironment strategyEnvironment) { builder.AddInt(29, (int)strategyEnvironment, 0); }
  public static void AddGroundID(FlatBufferBuilder builder, long GroundID) { builder.AddLong(30, GroundID, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatDataGlobal.ContentType contentType) { builder.AddInt(31, (int)contentType, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(32, BGMId, 0); }
  public static void AddInstantClear(FlatBufferBuilder builder, bool InstantClear) { builder.AddBool(33, InstantClear, false); }
  public static void AddBuffContentId(FlatBufferBuilder builder, long BuffContentId) { builder.AddLong(34, BuffContentId, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long FixedEchelonId) { builder.AddLong(35, FixedEchelonId, 0); }
  public static void AddChallengeDisplay(FlatBufferBuilder builder, bool ChallengeDisplay) { builder.AddBool(36, ChallengeDisplay, false); }
  public static void AddStarGoal(FlatBufferBuilder builder, VectorOffset StarGoalOffset) { builder.AddOffset(37, StarGoalOffset.Value, 0); }
  public static VectorOffset CreateStarGoalVector(FlatBufferBuilder builder, FlatDataGlobal.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.StarGoalType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.StarGoalType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarGoalAmount(FlatBufferBuilder builder, VectorOffset StarGoalAmountOffset) { builder.AddOffset(38, StarGoalAmountOffset.Value, 0); }
  public static VectorOffset CreateStarGoalAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsDefeatBattle(FlatBufferBuilder builder, bool IsDefeatBattle) { builder.AddBool(39, IsDefeatBattle, false); }
  public static void AddStageHint(FlatBufferBuilder builder, uint StageHint) { builder.AddUint(40, StageHint, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, FlatDataGlobal.EchelonExtensionType echelonExtensionType) { builder.AddInt(41, (int)echelonExtensionType, 0); }
  public static Offset<FlatDataGlobal.EventContentStageExcel> EndEventContentStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentStageExcel>(o);
  }
}


}
