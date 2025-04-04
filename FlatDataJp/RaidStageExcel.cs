// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RaidStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static RaidStageExcel GetRootAsRaidStageExcel(ByteBuffer _bb) { return GetRootAsRaidStageExcel(_bb, new RaidStageExcel()); }
  public static RaidStageExcel GetRootAsRaidStageExcel(ByteBuffer _bb, RaidStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public string PortraitPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPortraitPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPortraitPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPortraitPathArray() { return __p.__vector_as_array<byte>(12); }
  public string BGPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBGPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetBGPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetBGPathArray() { return __p.__vector_as_array<byte>(14); }
  public long RaidCharacterId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BossCharacterId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BossCharacterIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBossCharacterIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetBossCharacterIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetBossCharacterIdArray() { return __p.__vector_as_array<long>(18); }
  public FlatDataJp.Difficulty Difficulty { get { int o = __p.__offset(20); return o != 0 ? (FlatDataJp.Difficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Difficulty.Normal; } }
  public bool DifficultyOpenCondition { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long MaxPlayerCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RaidRoomLifeTime { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long BattleDuration { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GroundDevName { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroundDevNameBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetGroundDevNameBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetGroundDevNameArray() { return __p.__vector_as_array<byte>(32); }
  public string EnterTimeLine { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnterTimeLineBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetEnterTimeLineBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetEnterTimeLineArray() { return __p.__vector_as_array<byte>(34); }
  public FlatDataJp.TacticEnvironment TacticEnvironment { get { int o = __p.__offset(36); return o != 0 ? (FlatDataJp.TacticEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticEnvironment.None; } }
  public long DefaultClearScore { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaximumScore { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PerSecondMinusScore { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HPPercentScore { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MinimumAcquisitionScore { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaximumAcquisitionScore { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidRewardGroupId { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BattleReadyTimelinePath(int j) { int o = __p.__offset(52); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int BattleReadyTimelinePathLength { get { int o = __p.__offset(52); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int BattleReadyTimelinePhaseStart(int j) { int o = __p.__offset(54); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseStartLength { get { int o = __p.__offset(54); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_span<int>(54, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public int[] GetBattleReadyTimelinePhaseStartArray() { return __p.__vector_as_array<int>(54); }
  public int BattleReadyTimelinePhaseEnd(int j) { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseEndLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_span<int>(56, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public int[] GetBattleReadyTimelinePhaseEndArray() { return __p.__vector_as_array<int>(56); }
  public string VictoryTimelinePath { get { int o = __p.__offset(58); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(58, 1); }
#else
  public ArraySegment<byte>? GetVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public byte[] GetVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(58); }
  public string PhaseChangeTimelinePath { get { int o = __p.__offset(60); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_span<byte>(60, 1); }
#else
  public ArraySegment<byte>? GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public byte[] GetPhaseChangeTimelinePathArray() { return __p.__vector_as_array<byte>(60); }
  public long TimeLinePhase { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint EnterScenarioKey { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint ClearScenarioKey { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool ShowSkillCard { get { int o = __p.__offset(68); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint BossBGInfoKey { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(72); return o != 0 ? (FlatDataJp.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EchelonExtensionType.Base; } }

  public static Offset<FlatDataJp.RaidStageExcel> CreateRaidStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool UseBossIndex = false,
      bool UseBossAIPhaseSync = false,
      StringOffset RaidBossGroupOffset = default(StringOffset),
      StringOffset PortraitPathOffset = default(StringOffset),
      StringOffset BGPathOffset = default(StringOffset),
      long RaidCharacterId = 0,
      VectorOffset BossCharacterIdOffset = default(VectorOffset),
      FlatDataJp.Difficulty difficulty = FlatDataJp.Difficulty.Normal,
      bool DifficultyOpenCondition = false,
      long MaxPlayerCount = 0,
      int RaidRoomLifeTime = 0,
      long BattleDuration = 0,
      long GroundId = 0,
      StringOffset GroundDevNameOffset = default(StringOffset),
      StringOffset EnterTimeLineOffset = default(StringOffset),
      FlatDataJp.TacticEnvironment tacticEnvironment = FlatDataJp.TacticEnvironment.None,
      long DefaultClearScore = 0,
      long MaximumScore = 0,
      long PerSecondMinusScore = 0,
      long HPPercentScore = 0,
      long MinimumAcquisitionScore = 0,
      long MaximumAcquisitionScore = 0,
      long RaidRewardGroupId = 0,
      VectorOffset BattleReadyTimelinePathOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseStartOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseEndOffset = default(VectorOffset),
      StringOffset VictoryTimelinePathOffset = default(StringOffset),
      StringOffset PhaseChangeTimelinePathOffset = default(StringOffset),
      long TimeLinePhase = 0,
      uint EnterScenarioKey = 0,
      uint ClearScenarioKey = 0,
      bool ShowSkillCard = false,
      uint BossBGInfoKey = 0,
      FlatDataJp.EchelonExtensionType echelonExtensionType = FlatDataJp.EchelonExtensionType.Base) {
    builder.StartTable(35);
    RaidStageExcel.AddTimeLinePhase(builder, TimeLinePhase);
    RaidStageExcel.AddRaidRewardGroupId(builder, RaidRewardGroupId);
    RaidStageExcel.AddMaximumAcquisitionScore(builder, MaximumAcquisitionScore);
    RaidStageExcel.AddMinimumAcquisitionScore(builder, MinimumAcquisitionScore);
    RaidStageExcel.AddHPPercentScore(builder, HPPercentScore);
    RaidStageExcel.AddPerSecondMinusScore(builder, PerSecondMinusScore);
    RaidStageExcel.AddMaximumScore(builder, MaximumScore);
    RaidStageExcel.AddDefaultClearScore(builder, DefaultClearScore);
    RaidStageExcel.AddGroundId(builder, GroundId);
    RaidStageExcel.AddBattleDuration(builder, BattleDuration);
    RaidStageExcel.AddMaxPlayerCount(builder, MaxPlayerCount);
    RaidStageExcel.AddRaidCharacterId(builder, RaidCharacterId);
    RaidStageExcel.AddId(builder, Id);
    RaidStageExcel.AddEchelonExtensionType(builder, echelonExtensionType);
    RaidStageExcel.AddBossBGInfoKey(builder, BossBGInfoKey);
    RaidStageExcel.AddClearScenarioKey(builder, ClearScenarioKey);
    RaidStageExcel.AddEnterScenarioKey(builder, EnterScenarioKey);
    RaidStageExcel.AddPhaseChangeTimelinePath(builder, PhaseChangeTimelinePathOffset);
    RaidStageExcel.AddVictoryTimelinePath(builder, VictoryTimelinePathOffset);
    RaidStageExcel.AddBattleReadyTimelinePhaseEnd(builder, BattleReadyTimelinePhaseEndOffset);
    RaidStageExcel.AddBattleReadyTimelinePhaseStart(builder, BattleReadyTimelinePhaseStartOffset);
    RaidStageExcel.AddBattleReadyTimelinePath(builder, BattleReadyTimelinePathOffset);
    RaidStageExcel.AddTacticEnvironment(builder, tacticEnvironment);
    RaidStageExcel.AddEnterTimeLine(builder, EnterTimeLineOffset);
    RaidStageExcel.AddGroundDevName(builder, GroundDevNameOffset);
    RaidStageExcel.AddRaidRoomLifeTime(builder, RaidRoomLifeTime);
    RaidStageExcel.AddDifficulty(builder, difficulty);
    RaidStageExcel.AddBossCharacterId(builder, BossCharacterIdOffset);
    RaidStageExcel.AddBGPath(builder, BGPathOffset);
    RaidStageExcel.AddPortraitPath(builder, PortraitPathOffset);
    RaidStageExcel.AddRaidBossGroup(builder, RaidBossGroupOffset);
    RaidStageExcel.AddShowSkillCard(builder, ShowSkillCard);
    RaidStageExcel.AddDifficultyOpenCondition(builder, DifficultyOpenCondition);
    RaidStageExcel.AddUseBossAIPhaseSync(builder, UseBossAIPhaseSync);
    RaidStageExcel.AddUseBossIndex(builder, UseBossIndex);
    return RaidStageExcel.EndRaidStageExcel(builder);
  }

  public static void StartRaidStageExcel(FlatBufferBuilder builder) { builder.StartTable(35); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddUseBossIndex(FlatBufferBuilder builder, bool UseBossIndex) { builder.AddBool(1, UseBossIndex, false); }
  public static void AddUseBossAIPhaseSync(FlatBufferBuilder builder, bool UseBossAIPhaseSync) { builder.AddBool(2, UseBossAIPhaseSync, false); }
  public static void AddRaidBossGroup(FlatBufferBuilder builder, StringOffset RaidBossGroupOffset) { builder.AddOffset(3, RaidBossGroupOffset.Value, 0); }
  public static void AddPortraitPath(FlatBufferBuilder builder, StringOffset PortraitPathOffset) { builder.AddOffset(4, PortraitPathOffset.Value, 0); }
  public static void AddBGPath(FlatBufferBuilder builder, StringOffset BGPathOffset) { builder.AddOffset(5, BGPathOffset.Value, 0); }
  public static void AddRaidCharacterId(FlatBufferBuilder builder, long RaidCharacterId) { builder.AddLong(6, RaidCharacterId, 0); }
  public static void AddBossCharacterId(FlatBufferBuilder builder, VectorOffset BossCharacterIdOffset) { builder.AddOffset(7, BossCharacterIdOffset.Value, 0); }
  public static VectorOffset CreateBossCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBossCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDifficulty(FlatBufferBuilder builder, FlatDataJp.Difficulty difficulty) { builder.AddInt(8, (int)difficulty, 0); }
  public static void AddDifficultyOpenCondition(FlatBufferBuilder builder, bool DifficultyOpenCondition) { builder.AddBool(9, DifficultyOpenCondition, false); }
  public static void AddMaxPlayerCount(FlatBufferBuilder builder, long MaxPlayerCount) { builder.AddLong(10, MaxPlayerCount, 0); }
  public static void AddRaidRoomLifeTime(FlatBufferBuilder builder, int RaidRoomLifeTime) { builder.AddInt(11, RaidRoomLifeTime, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(12, BattleDuration, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(13, GroundId, 0); }
  public static void AddGroundDevName(FlatBufferBuilder builder, StringOffset GroundDevNameOffset) { builder.AddOffset(14, GroundDevNameOffset.Value, 0); }
  public static void AddEnterTimeLine(FlatBufferBuilder builder, StringOffset EnterTimeLineOffset) { builder.AddOffset(15, EnterTimeLineOffset.Value, 0); }
  public static void AddTacticEnvironment(FlatBufferBuilder builder, FlatDataJp.TacticEnvironment tacticEnvironment) { builder.AddInt(16, (int)tacticEnvironment, 0); }
  public static void AddDefaultClearScore(FlatBufferBuilder builder, long DefaultClearScore) { builder.AddLong(17, DefaultClearScore, 0); }
  public static void AddMaximumScore(FlatBufferBuilder builder, long MaximumScore) { builder.AddLong(18, MaximumScore, 0); }
  public static void AddPerSecondMinusScore(FlatBufferBuilder builder, long PerSecondMinusScore) { builder.AddLong(19, PerSecondMinusScore, 0); }
  public static void AddHPPercentScore(FlatBufferBuilder builder, long HPPercentScore) { builder.AddLong(20, HPPercentScore, 0); }
  public static void AddMinimumAcquisitionScore(FlatBufferBuilder builder, long MinimumAcquisitionScore) { builder.AddLong(21, MinimumAcquisitionScore, 0); }
  public static void AddMaximumAcquisitionScore(FlatBufferBuilder builder, long MaximumAcquisitionScore) { builder.AddLong(22, MaximumAcquisitionScore, 0); }
  public static void AddRaidRewardGroupId(FlatBufferBuilder builder, long RaidRewardGroupId) { builder.AddLong(23, RaidRewardGroupId, 0); }
  public static void AddBattleReadyTimelinePath(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePathOffset) { builder.AddOffset(24, BattleReadyTimelinePathOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseStart(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseStartOffset) { builder.AddOffset(25, BattleReadyTimelinePhaseStartOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseEnd(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseEndOffset) { builder.AddOffset(26, BattleReadyTimelinePhaseEndOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVictoryTimelinePath(FlatBufferBuilder builder, StringOffset VictoryTimelinePathOffset) { builder.AddOffset(27, VictoryTimelinePathOffset.Value, 0); }
  public static void AddPhaseChangeTimelinePath(FlatBufferBuilder builder, StringOffset PhaseChangeTimelinePathOffset) { builder.AddOffset(28, PhaseChangeTimelinePathOffset.Value, 0); }
  public static void AddTimeLinePhase(FlatBufferBuilder builder, long TimeLinePhase) { builder.AddLong(29, TimeLinePhase, 0); }
  public static void AddEnterScenarioKey(FlatBufferBuilder builder, uint EnterScenarioKey) { builder.AddUint(30, EnterScenarioKey, 0); }
  public static void AddClearScenarioKey(FlatBufferBuilder builder, uint ClearScenarioKey) { builder.AddUint(31, ClearScenarioKey, 0); }
  public static void AddShowSkillCard(FlatBufferBuilder builder, bool ShowSkillCard) { builder.AddBool(32, ShowSkillCard, false); }
  public static void AddBossBGInfoKey(FlatBufferBuilder builder, uint BossBGInfoKey) { builder.AddUint(33, BossBGInfoKey, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, FlatDataJp.EchelonExtensionType echelonExtensionType) { builder.AddInt(34, (int)echelonExtensionType, 0); }
  public static Offset<FlatDataJp.RaidStageExcel> EndRaidStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.RaidStageExcel>(o);
  }
}


}
