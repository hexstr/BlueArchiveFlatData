// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EliminateRaidStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EliminateRaidStageExcel GetRootAsEliminateRaidStageExcel(ByteBuffer _bb) { return GetRootAsEliminateRaidStageExcel(_bb, new EliminateRaidStageExcel()); }
  public static EliminateRaidStageExcel GetRootAsEliminateRaidStageExcel(ByteBuffer _bb, EliminateRaidStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EliminateRaidStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseBossIndex { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool UseBossAIPhaseSync { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string RaidBossGroup { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRaidBossGroupBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetRaidBossGroupBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetRaidBossGroupArray() { return __p.__vector_as_array<byte>(10); }
  public FlatDataGlobal.ParcelType RaidEnterCostType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long RaidEnterCostId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RaidEnterCostAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BossSpinePath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBossSpinePathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetBossSpinePathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetBossSpinePathArray() { return __p.__vector_as_array<byte>(18); }
  public string PortraitPath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPortraitPathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetPortraitPathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetPortraitPathArray() { return __p.__vector_as_array<byte>(20); }
  public string BGPath { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBGPathBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetBGPathBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetBGPathArray() { return __p.__vector_as_array<byte>(22); }
  public long RaidCharacterId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BossCharacterId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BossCharacterIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBossCharacterIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetBossCharacterIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetBossCharacterIdArray() { return __p.__vector_as_array<long>(26); }
  public FlatDataGlobal.Difficulty Difficulty { get { int o = __p.__offset(28); return o != 0 ? (FlatDataGlobal.Difficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.Difficulty.Normal; } }
  public bool DifficultyOpenCondition { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsOpen { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long MaxPlayerCount { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RaidRoomLifeTime { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long BattleDuration { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GroundDevName { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroundDevNameBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetGroundDevNameBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetGroundDevNameArray() { return __p.__vector_as_array<byte>(42); }
  public string EnterTimeLine { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnterTimeLineBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetEnterTimeLineBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetEnterTimeLineArray() { return __p.__vector_as_array<byte>(44); }
  public FlatDataGlobal.TacticEnvironment TacticEnvironment { get { int o = __p.__offset(46); return o != 0 ? (FlatDataGlobal.TacticEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TacticEnvironment.None; } }
  public int SeasonDamageRatio { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long DefaultClearScore { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaximumScore { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PerSecondMinusScore { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HPPercentScore { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MinimumAcquisitionScore { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaximumAcquisitionScore { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidRewardGroupId { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RaidRewardDevName { get { int o = __p.__offset(64); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRaidRewardDevNameBytes() { return __p.__vector_as_span<byte>(64, 1); }
#else
  public ArraySegment<byte>? GetRaidRewardDevNameBytes() { return __p.__vector_as_arraysegment(64); }
#endif
  public byte[] GetRaidRewardDevNameArray() { return __p.__vector_as_array<byte>(64); }
  public string BattleReadyTimelinePath(int j) { int o = __p.__offset(66); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int BattleReadyTimelinePathLength { get { int o = __p.__offset(66); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int BattleReadyTimelinePhaseStart(int j) { int o = __p.__offset(68); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseStartLength { get { int o = __p.__offset(68); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_span<int>(68, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_arraysegment(68); }
#endif
  public int[] GetBattleReadyTimelinePhaseStartArray() { return __p.__vector_as_array<int>(68); }
  public int BattleReadyTimelinePhaseEnd(int j) { int o = __p.__offset(70); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseEndLength { get { int o = __p.__offset(70); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_span<int>(70, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_arraysegment(70); }
#endif
  public int[] GetBattleReadyTimelinePhaseEndArray() { return __p.__vector_as_array<int>(70); }
  public string VictoryTimelinePath { get { int o = __p.__offset(72); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(72, 1); }
#else
  public ArraySegment<byte>? GetVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(72); }
#endif
  public byte[] GetVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(72); }
  public string PhaseChangeTimelinePath { get { int o = __p.__offset(74); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_span<byte>(74, 1); }
#else
  public ArraySegment<byte>? GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_arraysegment(74); }
#endif
  public byte[] GetPhaseChangeTimelinePathArray() { return __p.__vector_as_array<byte>(74); }
  public long TimeLinePhase { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint EnterScenarioKey { get { int o = __p.__offset(78); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint ClearScenarioKey { get { int o = __p.__offset(80); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public int InitSupplyCount { get { int o = __p.__offset(82); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool ShowSkillCard { get { int o = __p.__offset(84); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint BossBGInfoKey { get { int o = __p.__offset(86); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatDataGlobal.EliminateRaidStageExcel> CreateEliminateRaidStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool UseBossIndex = false,
      bool UseBossAIPhaseSync = false,
      StringOffset RaidBossGroupOffset = default(StringOffset),
      FlatDataGlobal.ParcelType RaidEnterCostType = FlatDataGlobal.ParcelType.None,
      long RaidEnterCostId = 0,
      int RaidEnterCostAmount = 0,
      StringOffset BossSpinePathOffset = default(StringOffset),
      StringOffset PortraitPathOffset = default(StringOffset),
      StringOffset BGPathOffset = default(StringOffset),
      long RaidCharacterId = 0,
      VectorOffset BossCharacterIdOffset = default(VectorOffset),
      FlatDataGlobal.Difficulty difficulty = FlatDataGlobal.Difficulty.Normal,
      bool DifficultyOpenCondition = false,
      bool IsOpen = false,
      long MaxPlayerCount = 0,
      int RaidRoomLifeTime = 0,
      long BattleDuration = 0,
      long GroundId = 0,
      StringOffset GroundDevNameOffset = default(StringOffset),
      StringOffset EnterTimeLineOffset = default(StringOffset),
      FlatDataGlobal.TacticEnvironment tacticEnvironment = FlatDataGlobal.TacticEnvironment.None,
      int SeasonDamageRatio = 0,
      long DefaultClearScore = 0,
      long MaximumScore = 0,
      long PerSecondMinusScore = 0,
      long HPPercentScore = 0,
      long MinimumAcquisitionScore = 0,
      long MaximumAcquisitionScore = 0,
      long RaidRewardGroupId = 0,
      StringOffset RaidRewardDevNameOffset = default(StringOffset),
      VectorOffset BattleReadyTimelinePathOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseStartOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseEndOffset = default(VectorOffset),
      StringOffset VictoryTimelinePathOffset = default(StringOffset),
      StringOffset PhaseChangeTimelinePathOffset = default(StringOffset),
      long TimeLinePhase = 0,
      uint EnterScenarioKey = 0,
      uint ClearScenarioKey = 0,
      int InitSupplyCount = 0,
      bool ShowSkillCard = false,
      uint BossBGInfoKey = 0) {
    builder.StartTable(42);
    EliminateRaidStageExcel.AddTimeLinePhase(builder, TimeLinePhase);
    EliminateRaidStageExcel.AddRaidRewardGroupId(builder, RaidRewardGroupId);
    EliminateRaidStageExcel.AddMaximumAcquisitionScore(builder, MaximumAcquisitionScore);
    EliminateRaidStageExcel.AddMinimumAcquisitionScore(builder, MinimumAcquisitionScore);
    EliminateRaidStageExcel.AddHPPercentScore(builder, HPPercentScore);
    EliminateRaidStageExcel.AddPerSecondMinusScore(builder, PerSecondMinusScore);
    EliminateRaidStageExcel.AddMaximumScore(builder, MaximumScore);
    EliminateRaidStageExcel.AddDefaultClearScore(builder, DefaultClearScore);
    EliminateRaidStageExcel.AddGroundId(builder, GroundId);
    EliminateRaidStageExcel.AddBattleDuration(builder, BattleDuration);
    EliminateRaidStageExcel.AddMaxPlayerCount(builder, MaxPlayerCount);
    EliminateRaidStageExcel.AddRaidCharacterId(builder, RaidCharacterId);
    EliminateRaidStageExcel.AddRaidEnterCostId(builder, RaidEnterCostId);
    EliminateRaidStageExcel.AddId(builder, Id);
    EliminateRaidStageExcel.AddBossBGInfoKey(builder, BossBGInfoKey);
    EliminateRaidStageExcel.AddInitSupplyCount(builder, InitSupplyCount);
    EliminateRaidStageExcel.AddClearScenarioKey(builder, ClearScenarioKey);
    EliminateRaidStageExcel.AddEnterScenarioKey(builder, EnterScenarioKey);
    EliminateRaidStageExcel.AddPhaseChangeTimelinePath(builder, PhaseChangeTimelinePathOffset);
    EliminateRaidStageExcel.AddVictoryTimelinePath(builder, VictoryTimelinePathOffset);
    EliminateRaidStageExcel.AddBattleReadyTimelinePhaseEnd(builder, BattleReadyTimelinePhaseEndOffset);
    EliminateRaidStageExcel.AddBattleReadyTimelinePhaseStart(builder, BattleReadyTimelinePhaseStartOffset);
    EliminateRaidStageExcel.AddBattleReadyTimelinePath(builder, BattleReadyTimelinePathOffset);
    EliminateRaidStageExcel.AddRaidRewardDevName(builder, RaidRewardDevNameOffset);
    EliminateRaidStageExcel.AddSeasonDamageRatio(builder, SeasonDamageRatio);
    EliminateRaidStageExcel.AddTacticEnvironment(builder, tacticEnvironment);
    EliminateRaidStageExcel.AddEnterTimeLine(builder, EnterTimeLineOffset);
    EliminateRaidStageExcel.AddGroundDevName(builder, GroundDevNameOffset);
    EliminateRaidStageExcel.AddRaidRoomLifeTime(builder, RaidRoomLifeTime);
    EliminateRaidStageExcel.AddDifficulty(builder, difficulty);
    EliminateRaidStageExcel.AddBossCharacterId(builder, BossCharacterIdOffset);
    EliminateRaidStageExcel.AddBGPath(builder, BGPathOffset);
    EliminateRaidStageExcel.AddPortraitPath(builder, PortraitPathOffset);
    EliminateRaidStageExcel.AddBossSpinePath(builder, BossSpinePathOffset);
    EliminateRaidStageExcel.AddRaidEnterCostAmount(builder, RaidEnterCostAmount);
    EliminateRaidStageExcel.AddRaidEnterCostType(builder, RaidEnterCostType);
    EliminateRaidStageExcel.AddRaidBossGroup(builder, RaidBossGroupOffset);
    EliminateRaidStageExcel.AddShowSkillCard(builder, ShowSkillCard);
    EliminateRaidStageExcel.AddIsOpen(builder, IsOpen);
    EliminateRaidStageExcel.AddDifficultyOpenCondition(builder, DifficultyOpenCondition);
    EliminateRaidStageExcel.AddUseBossAIPhaseSync(builder, UseBossAIPhaseSync);
    EliminateRaidStageExcel.AddUseBossIndex(builder, UseBossIndex);
    return EliminateRaidStageExcel.EndEliminateRaidStageExcel(builder);
  }

  public static void StartEliminateRaidStageExcel(FlatBufferBuilder builder) { builder.StartTable(42); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddUseBossIndex(FlatBufferBuilder builder, bool UseBossIndex) { builder.AddBool(1, UseBossIndex, false); }
  public static void AddUseBossAIPhaseSync(FlatBufferBuilder builder, bool UseBossAIPhaseSync) { builder.AddBool(2, UseBossAIPhaseSync, false); }
  public static void AddRaidBossGroup(FlatBufferBuilder builder, StringOffset RaidBossGroupOffset) { builder.AddOffset(3, RaidBossGroupOffset.Value, 0); }
  public static void AddRaidEnterCostType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType RaidEnterCostType) { builder.AddInt(4, (int)RaidEnterCostType, 0); }
  public static void AddRaidEnterCostId(FlatBufferBuilder builder, long RaidEnterCostId) { builder.AddLong(5, RaidEnterCostId, 0); }
  public static void AddRaidEnterCostAmount(FlatBufferBuilder builder, int RaidEnterCostAmount) { builder.AddInt(6, RaidEnterCostAmount, 0); }
  public static void AddBossSpinePath(FlatBufferBuilder builder, StringOffset BossSpinePathOffset) { builder.AddOffset(7, BossSpinePathOffset.Value, 0); }
  public static void AddPortraitPath(FlatBufferBuilder builder, StringOffset PortraitPathOffset) { builder.AddOffset(8, PortraitPathOffset.Value, 0); }
  public static void AddBGPath(FlatBufferBuilder builder, StringOffset BGPathOffset) { builder.AddOffset(9, BGPathOffset.Value, 0); }
  public static void AddRaidCharacterId(FlatBufferBuilder builder, long RaidCharacterId) { builder.AddLong(10, RaidCharacterId, 0); }
  public static void AddBossCharacterId(FlatBufferBuilder builder, VectorOffset BossCharacterIdOffset) { builder.AddOffset(11, BossCharacterIdOffset.Value, 0); }
  public static VectorOffset CreateBossCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBossCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDifficulty(FlatBufferBuilder builder, FlatDataGlobal.Difficulty difficulty) { builder.AddInt(12, (int)difficulty, 0); }
  public static void AddDifficultyOpenCondition(FlatBufferBuilder builder, bool DifficultyOpenCondition) { builder.AddBool(13, DifficultyOpenCondition, false); }
  public static void AddIsOpen(FlatBufferBuilder builder, bool IsOpen) { builder.AddBool(14, IsOpen, false); }
  public static void AddMaxPlayerCount(FlatBufferBuilder builder, long MaxPlayerCount) { builder.AddLong(15, MaxPlayerCount, 0); }
  public static void AddRaidRoomLifeTime(FlatBufferBuilder builder, int RaidRoomLifeTime) { builder.AddInt(16, RaidRoomLifeTime, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(17, BattleDuration, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(18, GroundId, 0); }
  public static void AddGroundDevName(FlatBufferBuilder builder, StringOffset GroundDevNameOffset) { builder.AddOffset(19, GroundDevNameOffset.Value, 0); }
  public static void AddEnterTimeLine(FlatBufferBuilder builder, StringOffset EnterTimeLineOffset) { builder.AddOffset(20, EnterTimeLineOffset.Value, 0); }
  public static void AddTacticEnvironment(FlatBufferBuilder builder, FlatDataGlobal.TacticEnvironment tacticEnvironment) { builder.AddInt(21, (int)tacticEnvironment, 0); }
  public static void AddSeasonDamageRatio(FlatBufferBuilder builder, int SeasonDamageRatio) { builder.AddInt(22, SeasonDamageRatio, 0); }
  public static void AddDefaultClearScore(FlatBufferBuilder builder, long DefaultClearScore) { builder.AddLong(23, DefaultClearScore, 0); }
  public static void AddMaximumScore(FlatBufferBuilder builder, long MaximumScore) { builder.AddLong(24, MaximumScore, 0); }
  public static void AddPerSecondMinusScore(FlatBufferBuilder builder, long PerSecondMinusScore) { builder.AddLong(25, PerSecondMinusScore, 0); }
  public static void AddHPPercentScore(FlatBufferBuilder builder, long HPPercentScore) { builder.AddLong(26, HPPercentScore, 0); }
  public static void AddMinimumAcquisitionScore(FlatBufferBuilder builder, long MinimumAcquisitionScore) { builder.AddLong(27, MinimumAcquisitionScore, 0); }
  public static void AddMaximumAcquisitionScore(FlatBufferBuilder builder, long MaximumAcquisitionScore) { builder.AddLong(28, MaximumAcquisitionScore, 0); }
  public static void AddRaidRewardGroupId(FlatBufferBuilder builder, long RaidRewardGroupId) { builder.AddLong(29, RaidRewardGroupId, 0); }
  public static void AddRaidRewardDevName(FlatBufferBuilder builder, StringOffset RaidRewardDevNameOffset) { builder.AddOffset(30, RaidRewardDevNameOffset.Value, 0); }
  public static void AddBattleReadyTimelinePath(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePathOffset) { builder.AddOffset(31, BattleReadyTimelinePathOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseStart(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseStartOffset) { builder.AddOffset(32, BattleReadyTimelinePhaseStartOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseEnd(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseEndOffset) { builder.AddOffset(33, BattleReadyTimelinePhaseEndOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVictoryTimelinePath(FlatBufferBuilder builder, StringOffset VictoryTimelinePathOffset) { builder.AddOffset(34, VictoryTimelinePathOffset.Value, 0); }
  public static void AddPhaseChangeTimelinePath(FlatBufferBuilder builder, StringOffset PhaseChangeTimelinePathOffset) { builder.AddOffset(35, PhaseChangeTimelinePathOffset.Value, 0); }
  public static void AddTimeLinePhase(FlatBufferBuilder builder, long TimeLinePhase) { builder.AddLong(36, TimeLinePhase, 0); }
  public static void AddEnterScenarioKey(FlatBufferBuilder builder, uint EnterScenarioKey) { builder.AddUint(37, EnterScenarioKey, 0); }
  public static void AddClearScenarioKey(FlatBufferBuilder builder, uint ClearScenarioKey) { builder.AddUint(38, ClearScenarioKey, 0); }
  public static void AddInitSupplyCount(FlatBufferBuilder builder, int InitSupplyCount) { builder.AddInt(39, InitSupplyCount, 0); }
  public static void AddShowSkillCard(FlatBufferBuilder builder, bool ShowSkillCard) { builder.AddBool(40, ShowSkillCard, false); }
  public static void AddBossBGInfoKey(FlatBufferBuilder builder, uint BossBGInfoKey) { builder.AddUint(41, BossBGInfoKey, 0); }
  public static Offset<FlatDataGlobal.EliminateRaidStageExcel> EndEliminateRaidStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EliminateRaidStageExcel>(o);
  }
}


}
