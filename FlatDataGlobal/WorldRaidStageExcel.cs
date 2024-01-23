// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WorldRaidStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static WorldRaidStageExcel GetRootAsWorldRaidStageExcel(ByteBuffer _bb) { return GetRootAsWorldRaidStageExcel(_bb, new WorldRaidStageExcel()); }
  public static WorldRaidStageExcel GetRootAsWorldRaidStageExcel(ByteBuffer _bb, WorldRaidStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseBossIndex { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool UseBossAIPhaseSync { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long WorldRaidBossGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
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
  public long AssistCharacterLimitCount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.WorldRaidDifficulty WorldRaidDifficulty { get { int o = __p.__offset(22); return o != 0 ? (FlatDataGlobal.WorldRaidDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.WorldRaidDifficulty.None; } }
  public bool DifficultyOpenCondition { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long RaidEnterAmount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ReEnterAmount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidBattleEndRewardGroupId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidRewardGroupId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BattleReadyTimelinePath(int j) { int o = __p.__offset(38); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int BattleReadyTimelinePathLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int BattleReadyTimelinePhaseStart(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseStartLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_span<int>(40, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public int[] GetBattleReadyTimelinePhaseStartArray() { return __p.__vector_as_array<int>(40); }
  public int BattleReadyTimelinePhaseEnd(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseEndLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_span<int>(42, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public int[] GetBattleReadyTimelinePhaseEndArray() { return __p.__vector_as_array<int>(42); }
  public string BeforeVictoryTimelinePath { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforeVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetBeforeVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetBeforeVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(44); }
  public string VictoryTimelinePath { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(46); }
  public string PhaseChangeTimelinePath { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetPhaseChangeTimelinePathArray() { return __p.__vector_as_array<byte>(48); }
  public long TimeLinePhase { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioKey { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearScenarioKey { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseFixedEchelon { get { int o = __p.__offset(56); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long FixedEchelonId { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsRaidScenarioBattle { get { int o = __p.__offset(60); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowSkillCard { get { int o = __p.__offset(62); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint BossBGInfoKey { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long DamageToWorldBoss { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AllyPassiveSkill(int j) { int o = __p.__offset(68); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AllyPassiveSkillLength { get { int o = __p.__offset(68); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int AllyPassiveSkillLevel(int j) { int o = __p.__offset(70); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int AllyPassiveSkillLevelLength { get { int o = __p.__offset(70); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetAllyPassiveSkillLevelBytes() { return __p.__vector_as_span<int>(70, 4); }
#else
  public ArraySegment<byte>? GetAllyPassiveSkillLevelBytes() { return __p.__vector_as_arraysegment(70); }
#endif
  public int[] GetAllyPassiveSkillLevelArray() { return __p.__vector_as_array<int>(70); }
  public bool SaveCurrentLocalBossHP { get { int o = __p.__offset(72); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.WorldRaidStageExcel> CreateWorldRaidStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool UseBossIndex = false,
      bool UseBossAIPhaseSync = false,
      long WorldRaidBossGroupId = 0,
      StringOffset PortraitPathOffset = default(StringOffset),
      StringOffset BGPathOffset = default(StringOffset),
      long RaidCharacterId = 0,
      VectorOffset BossCharacterIdOffset = default(VectorOffset),
      long AssistCharacterLimitCount = 0,
      FlatDataGlobal.WorldRaidDifficulty worldRaidDifficulty = FlatDataGlobal.WorldRaidDifficulty.None,
      bool DifficultyOpenCondition = false,
      long RaidEnterAmount = 0,
      long ReEnterAmount = 0,
      long BattleDuration = 0,
      long GroundId = 0,
      long RaidBattleEndRewardGroupId = 0,
      long RaidRewardGroupId = 0,
      VectorOffset BattleReadyTimelinePathOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseStartOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseEndOffset = default(VectorOffset),
      StringOffset BeforeVictoryTimelinePathOffset = default(StringOffset),
      StringOffset VictoryTimelinePathOffset = default(StringOffset),
      StringOffset PhaseChangeTimelinePathOffset = default(StringOffset),
      long TimeLinePhase = 0,
      long EnterScenarioKey = 0,
      long ClearScenarioKey = 0,
      bool UseFixedEchelon = false,
      long FixedEchelonId = 0,
      bool IsRaidScenarioBattle = false,
      bool ShowSkillCard = false,
      uint BossBGInfoKey = 0,
      long DamageToWorldBoss = 0,
      VectorOffset AllyPassiveSkillOffset = default(VectorOffset),
      VectorOffset AllyPassiveSkillLevelOffset = default(VectorOffset),
      bool SaveCurrentLocalBossHP = false) {
    builder.StartTable(35);
    WorldRaidStageExcel.AddDamageToWorldBoss(builder, DamageToWorldBoss);
    WorldRaidStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    WorldRaidStageExcel.AddClearScenarioKey(builder, ClearScenarioKey);
    WorldRaidStageExcel.AddEnterScenarioKey(builder, EnterScenarioKey);
    WorldRaidStageExcel.AddTimeLinePhase(builder, TimeLinePhase);
    WorldRaidStageExcel.AddRaidRewardGroupId(builder, RaidRewardGroupId);
    WorldRaidStageExcel.AddRaidBattleEndRewardGroupId(builder, RaidBattleEndRewardGroupId);
    WorldRaidStageExcel.AddGroundId(builder, GroundId);
    WorldRaidStageExcel.AddBattleDuration(builder, BattleDuration);
    WorldRaidStageExcel.AddReEnterAmount(builder, ReEnterAmount);
    WorldRaidStageExcel.AddRaidEnterAmount(builder, RaidEnterAmount);
    WorldRaidStageExcel.AddAssistCharacterLimitCount(builder, AssistCharacterLimitCount);
    WorldRaidStageExcel.AddRaidCharacterId(builder, RaidCharacterId);
    WorldRaidStageExcel.AddWorldRaidBossGroupId(builder, WorldRaidBossGroupId);
    WorldRaidStageExcel.AddId(builder, Id);
    WorldRaidStageExcel.AddAllyPassiveSkillLevel(builder, AllyPassiveSkillLevelOffset);
    WorldRaidStageExcel.AddAllyPassiveSkill(builder, AllyPassiveSkillOffset);
    WorldRaidStageExcel.AddBossBGInfoKey(builder, BossBGInfoKey);
    WorldRaidStageExcel.AddPhaseChangeTimelinePath(builder, PhaseChangeTimelinePathOffset);
    WorldRaidStageExcel.AddVictoryTimelinePath(builder, VictoryTimelinePathOffset);
    WorldRaidStageExcel.AddBeforeVictoryTimelinePath(builder, BeforeVictoryTimelinePathOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePhaseEnd(builder, BattleReadyTimelinePhaseEndOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePhaseStart(builder, BattleReadyTimelinePhaseStartOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePath(builder, BattleReadyTimelinePathOffset);
    WorldRaidStageExcel.AddWorldRaidDifficulty(builder, worldRaidDifficulty);
    WorldRaidStageExcel.AddBossCharacterId(builder, BossCharacterIdOffset);
    WorldRaidStageExcel.AddBGPath(builder, BGPathOffset);
    WorldRaidStageExcel.AddPortraitPath(builder, PortraitPathOffset);
    WorldRaidStageExcel.AddSaveCurrentLocalBossHP(builder, SaveCurrentLocalBossHP);
    WorldRaidStageExcel.AddShowSkillCard(builder, ShowSkillCard);
    WorldRaidStageExcel.AddIsRaidScenarioBattle(builder, IsRaidScenarioBattle);
    WorldRaidStageExcel.AddUseFixedEchelon(builder, UseFixedEchelon);
    WorldRaidStageExcel.AddDifficultyOpenCondition(builder, DifficultyOpenCondition);
    WorldRaidStageExcel.AddUseBossAIPhaseSync(builder, UseBossAIPhaseSync);
    WorldRaidStageExcel.AddUseBossIndex(builder, UseBossIndex);
    return WorldRaidStageExcel.EndWorldRaidStageExcel(builder);
  }

  public static void StartWorldRaidStageExcel(FlatBufferBuilder builder) { builder.StartTable(35); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddUseBossIndex(FlatBufferBuilder builder, bool UseBossIndex) { builder.AddBool(1, UseBossIndex, false); }
  public static void AddUseBossAIPhaseSync(FlatBufferBuilder builder, bool UseBossAIPhaseSync) { builder.AddBool(2, UseBossAIPhaseSync, false); }
  public static void AddWorldRaidBossGroupId(FlatBufferBuilder builder, long WorldRaidBossGroupId) { builder.AddLong(3, WorldRaidBossGroupId, 0); }
  public static void AddPortraitPath(FlatBufferBuilder builder, StringOffset PortraitPathOffset) { builder.AddOffset(4, PortraitPathOffset.Value, 0); }
  public static void AddBGPath(FlatBufferBuilder builder, StringOffset BGPathOffset) { builder.AddOffset(5, BGPathOffset.Value, 0); }
  public static void AddRaidCharacterId(FlatBufferBuilder builder, long RaidCharacterId) { builder.AddLong(6, RaidCharacterId, 0); }
  public static void AddBossCharacterId(FlatBufferBuilder builder, VectorOffset BossCharacterIdOffset) { builder.AddOffset(7, BossCharacterIdOffset.Value, 0); }
  public static VectorOffset CreateBossCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBossCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAssistCharacterLimitCount(FlatBufferBuilder builder, long AssistCharacterLimitCount) { builder.AddLong(8, AssistCharacterLimitCount, 0); }
  public static void AddWorldRaidDifficulty(FlatBufferBuilder builder, FlatDataGlobal.WorldRaidDifficulty worldRaidDifficulty) { builder.AddInt(9, (int)worldRaidDifficulty, 0); }
  public static void AddDifficultyOpenCondition(FlatBufferBuilder builder, bool DifficultyOpenCondition) { builder.AddBool(10, DifficultyOpenCondition, false); }
  public static void AddRaidEnterAmount(FlatBufferBuilder builder, long RaidEnterAmount) { builder.AddLong(11, RaidEnterAmount, 0); }
  public static void AddReEnterAmount(FlatBufferBuilder builder, long ReEnterAmount) { builder.AddLong(12, ReEnterAmount, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(13, BattleDuration, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(14, GroundId, 0); }
  public static void AddRaidBattleEndRewardGroupId(FlatBufferBuilder builder, long RaidBattleEndRewardGroupId) { builder.AddLong(15, RaidBattleEndRewardGroupId, 0); }
  public static void AddRaidRewardGroupId(FlatBufferBuilder builder, long RaidRewardGroupId) { builder.AddLong(16, RaidRewardGroupId, 0); }
  public static void AddBattleReadyTimelinePath(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePathOffset) { builder.AddOffset(17, BattleReadyTimelinePathOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseStart(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseStartOffset) { builder.AddOffset(18, BattleReadyTimelinePhaseStartOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseEnd(FlatBufferBuilder builder, VectorOffset BattleReadyTimelinePhaseEndOffset) { builder.AddOffset(19, BattleReadyTimelinePhaseEndOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBeforeVictoryTimelinePath(FlatBufferBuilder builder, StringOffset BeforeVictoryTimelinePathOffset) { builder.AddOffset(20, BeforeVictoryTimelinePathOffset.Value, 0); }
  public static void AddVictoryTimelinePath(FlatBufferBuilder builder, StringOffset VictoryTimelinePathOffset) { builder.AddOffset(21, VictoryTimelinePathOffset.Value, 0); }
  public static void AddPhaseChangeTimelinePath(FlatBufferBuilder builder, StringOffset PhaseChangeTimelinePathOffset) { builder.AddOffset(22, PhaseChangeTimelinePathOffset.Value, 0); }
  public static void AddTimeLinePhase(FlatBufferBuilder builder, long TimeLinePhase) { builder.AddLong(23, TimeLinePhase, 0); }
  public static void AddEnterScenarioKey(FlatBufferBuilder builder, long EnterScenarioKey) { builder.AddLong(24, EnterScenarioKey, 0); }
  public static void AddClearScenarioKey(FlatBufferBuilder builder, long ClearScenarioKey) { builder.AddLong(25, ClearScenarioKey, 0); }
  public static void AddUseFixedEchelon(FlatBufferBuilder builder, bool UseFixedEchelon) { builder.AddBool(26, UseFixedEchelon, false); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long FixedEchelonId) { builder.AddLong(27, FixedEchelonId, 0); }
  public static void AddIsRaidScenarioBattle(FlatBufferBuilder builder, bool IsRaidScenarioBattle) { builder.AddBool(28, IsRaidScenarioBattle, false); }
  public static void AddShowSkillCard(FlatBufferBuilder builder, bool ShowSkillCard) { builder.AddBool(29, ShowSkillCard, false); }
  public static void AddBossBGInfoKey(FlatBufferBuilder builder, uint BossBGInfoKey) { builder.AddUint(30, BossBGInfoKey, 0); }
  public static void AddDamageToWorldBoss(FlatBufferBuilder builder, long DamageToWorldBoss) { builder.AddLong(31, DamageToWorldBoss, 0); }
  public static void AddAllyPassiveSkill(FlatBufferBuilder builder, VectorOffset AllyPassiveSkillOffset) { builder.AddOffset(32, AllyPassiveSkillOffset.Value, 0); }
  public static VectorOffset CreateAllyPassiveSkillVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAllyPassiveSkillVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAllyPassiveSkillLevel(FlatBufferBuilder builder, VectorOffset AllyPassiveSkillLevelOffset) { builder.AddOffset(33, AllyPassiveSkillLevelOffset.Value, 0); }
  public static VectorOffset CreateAllyPassiveSkillLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAllyPassiveSkillLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSaveCurrentLocalBossHP(FlatBufferBuilder builder, bool SaveCurrentLocalBossHP) { builder.AddBool(34, SaveCurrentLocalBossHP, false); }
  public static Offset<FlatDataGlobal.WorldRaidStageExcel> EndWorldRaidStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.WorldRaidStageExcel>(o);
  }
}


}
