// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstCombatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConstCombatExcel GetRootAsConstCombatExcel(ByteBuffer _bb) { return GetRootAsConstCombatExcel(_bb, new ConstCombatExcel()); }
  public static ConstCombatExcel GetRootAsConstCombatExcel(ByteBuffer _bb, ConstCombatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstCombatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int SkillHandCount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DyingTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BuffIconBlinkTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool ShowBufficonEXSkill { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowBufficonPassiveSkill { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowBufficonExtraPassiveSkill { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowBufficonLeaderSkill { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowBufficonGroundPassiveSkill { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string SuppliesConditionStringId { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSuppliesConditionStringIdBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSuppliesConditionStringIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSuppliesConditionStringIdArray() { return __p.__vector_as_array<byte>(20); }
  public float PublicSpeechBubbleOffsetX { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PublicSpeechBubbleOffsetY { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PublicSpeechBubbleOffsetZ { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PublicSpeechDuration { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int ShowRaidListCount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long MaxFinalDamage { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxFinalHeal { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxRaidTicketCount { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxRaidBossSkillSlot { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string EngageTimelinePath { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEngageTimelinePathBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetEngageTimelinePathBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetEngageTimelinePathArray() { return __p.__vector_as_array<byte>(40); }
  public string EngageWithSupporterTimelinePath { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEngageWithSupporterTimelinePathBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetEngageWithSupporterTimelinePathBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetEngageWithSupporterTimelinePathArray() { return __p.__vector_as_array<byte>(42); }
  public string VictoryTimelinePath { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(44); }
  public long TimeLimitAlarm { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int EchelonMaxCommonCost { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EchelonInitCommonCost { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long SkillSlotCoolTime { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemyRegenCost { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ChampionRegenCost { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerRegenCostDelay { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CrowdControlFactor { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RaidOpenScenarioId { get { int o = __p.__offset(62); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRaidOpenScenarioIdBytes() { return __p.__vector_as_span<byte>(62, 1); }
#else
  public ArraySegment<byte>? GetRaidOpenScenarioIdBytes() { return __p.__vector_as_arraysegment(62); }
#endif
  public byte[] GetRaidOpenScenarioIdArray() { return __p.__vector_as_array<byte>(62); }
  public long DefenceConstA { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenceConstB { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenceConstC { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenceConstD { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyConstA { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyConstB { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyConstC { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyConstD { get { int o = __p.__offset(78); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalConstA { get { int o = __p.__offset(80); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalConstB { get { int o = __p.__offset(82); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalConstC { get { int o = __p.__offset(84); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalConstD { get { int o = __p.__offset(86); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxGroupBuffLevel { get { int o = __p.__offset(88); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EmojiDefaultTime { get { int o = __p.__offset(90); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TimeLineActionRotateSpeed { get { int o = __p.__offset(92); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BodyRotateSpeed { get { int o = __p.__offset(94); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NormalTimeScale { get { int o = __p.__offset(96); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FastTimeScale { get { int o = __p.__offset(98); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BulletTimeScale { get { int o = __p.__offset(100); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UIDisplayDelayAfterSkillCutIn { get { int o = __p.__offset(102); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseInitialRangeForCoverMove { get { int o = __p.__offset(104); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long SlowTimeScale { get { int o = __p.__offset(106); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float AimIKMinDegree { get { int o = __p.__offset(108); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AimIKMaxDegree { get { int o = __p.__offset(110); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int MinimumClearTime { get { int o = __p.__offset(112); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MinimumClearLevelGap { get { int o = __p.__offset(114); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CheckCheaterMaxUseCostNonArena { get { int o = __p.__offset(116); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CheckCheaterMaxUseCostArena { get { int o = __p.__offset(118); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long AllowedMaxTimeScale { get { int o = __p.__offset(120); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RandomAnimationOutput { get { int o = __p.__offset(122); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SummonedTeleportDistance { get { int o = __p.__offset(124); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ArenaMinimumClearTime { get { int o = __p.__offset(126); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long WORLDBOSSBATTLELITTLE { get { int o = __p.__offset(128); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WORLDBOSSBATTLEMIDDLE { get { int o = __p.__offset(130); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WORLDBOSSBATTLEHIGH { get { int o = __p.__offset(132); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WORLDBOSSBATTLEVERYHIGH { get { int o = __p.__offset(134); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WorldRaidAutoSyncTermSecond { get { int o = __p.__offset(136); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WorldRaidBossHpDecreaseTerm { get { int o = __p.__offset(138); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WorldRaidBossParcelReactionDelay { get { int o = __p.__offset(140); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidRankingJumpMinimumWaitingTime { get { int o = __p.__offset(142); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float EffectTeleportDistance { get { int o = __p.__offset(144); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataJp.ConstCombatExcel> CreateConstCombatExcel(FlatBufferBuilder builder,
      int SkillHandCount = 0,
      int DyingTime = 0,
      int BuffIconBlinkTime = 0,
      bool ShowBufficonEXSkill = false,
      bool ShowBufficonPassiveSkill = false,
      bool ShowBufficonExtraPassiveSkill = false,
      bool ShowBufficonLeaderSkill = false,
      bool ShowBufficonGroundPassiveSkill = false,
      StringOffset SuppliesConditionStringIdOffset = default(StringOffset),
      float PublicSpeechBubbleOffsetX = 0.0f,
      float PublicSpeechBubbleOffsetY = 0.0f,
      float PublicSpeechBubbleOffsetZ = 0.0f,
      float PublicSpeechDuration = 0.0f,
      int ShowRaidListCount = 0,
      long MaxFinalDamage = 0,
      long MaxFinalHeal = 0,
      long MaxRaidTicketCount = 0,
      long MaxRaidBossSkillSlot = 0,
      StringOffset EngageTimelinePathOffset = default(StringOffset),
      StringOffset EngageWithSupporterTimelinePathOffset = default(StringOffset),
      StringOffset VictoryTimelinePathOffset = default(StringOffset),
      long TimeLimitAlarm = 0,
      int EchelonMaxCommonCost = 0,
      int EchelonInitCommonCost = 0,
      long SkillSlotCoolTime = 0,
      long EnemyRegenCost = 0,
      long ChampionRegenCost = 0,
      long PlayerRegenCostDelay = 0,
      long CrowdControlFactor = 0,
      StringOffset RaidOpenScenarioIdOffset = default(StringOffset),
      long DefenceConstA = 0,
      long DefenceConstB = 0,
      long DefenceConstC = 0,
      long DefenceConstD = 0,
      long AccuracyConstA = 0,
      long AccuracyConstB = 0,
      long AccuracyConstC = 0,
      long AccuracyConstD = 0,
      long CriticalConstA = 0,
      long CriticalConstB = 0,
      long CriticalConstC = 0,
      long CriticalConstD = 0,
      int MaxGroupBuffLevel = 0,
      int EmojiDefaultTime = 0,
      long TimeLineActionRotateSpeed = 0,
      long BodyRotateSpeed = 0,
      long NormalTimeScale = 0,
      long FastTimeScale = 0,
      long BulletTimeScale = 0,
      long UIDisplayDelayAfterSkillCutIn = 0,
      bool UseInitialRangeForCoverMove = false,
      long SlowTimeScale = 0,
      float AimIKMinDegree = 0.0f,
      float AimIKMaxDegree = 0.0f,
      int MinimumClearTime = 0,
      int MinimumClearLevelGap = 0,
      int CheckCheaterMaxUseCostNonArena = 0,
      int CheckCheaterMaxUseCostArena = 0,
      long AllowedMaxTimeScale = 0,
      long RandomAnimationOutput = 0,
      long SummonedTeleportDistance = 0,
      int ArenaMinimumClearTime = 0,
      long WORLDBOSSBATTLELITTLE = 0,
      long WORLDBOSSBATTLEMIDDLE = 0,
      long WORLDBOSSBATTLEHIGH = 0,
      long WORLDBOSSBATTLEVERYHIGH = 0,
      long WorldRaidAutoSyncTermSecond = 0,
      long WorldRaidBossHpDecreaseTerm = 0,
      long WorldRaidBossParcelReactionDelay = 0,
      long RaidRankingJumpMinimumWaitingTime = 0,
      float EffectTeleportDistance = 0.0f) {
    builder.StartTable(71);
    ConstCombatExcel.AddRaidRankingJumpMinimumWaitingTime(builder, RaidRankingJumpMinimumWaitingTime);
    ConstCombatExcel.AddWorldRaidBossParcelReactionDelay(builder, WorldRaidBossParcelReactionDelay);
    ConstCombatExcel.AddWorldRaidBossHpDecreaseTerm(builder, WorldRaidBossHpDecreaseTerm);
    ConstCombatExcel.AddWorldRaidAutoSyncTermSecond(builder, WorldRaidAutoSyncTermSecond);
    ConstCombatExcel.AddWORLDBOSSBATTLEVERYHIGH(builder, WORLDBOSSBATTLEVERYHIGH);
    ConstCombatExcel.AddWORLDBOSSBATTLEHIGH(builder, WORLDBOSSBATTLEHIGH);
    ConstCombatExcel.AddWORLDBOSSBATTLEMIDDLE(builder, WORLDBOSSBATTLEMIDDLE);
    ConstCombatExcel.AddWORLDBOSSBATTLELITTLE(builder, WORLDBOSSBATTLELITTLE);
    ConstCombatExcel.AddSummonedTeleportDistance(builder, SummonedTeleportDistance);
    ConstCombatExcel.AddRandomAnimationOutput(builder, RandomAnimationOutput);
    ConstCombatExcel.AddAllowedMaxTimeScale(builder, AllowedMaxTimeScale);
    ConstCombatExcel.AddSlowTimeScale(builder, SlowTimeScale);
    ConstCombatExcel.AddUIDisplayDelayAfterSkillCutIn(builder, UIDisplayDelayAfterSkillCutIn);
    ConstCombatExcel.AddBulletTimeScale(builder, BulletTimeScale);
    ConstCombatExcel.AddFastTimeScale(builder, FastTimeScale);
    ConstCombatExcel.AddNormalTimeScale(builder, NormalTimeScale);
    ConstCombatExcel.AddBodyRotateSpeed(builder, BodyRotateSpeed);
    ConstCombatExcel.AddTimeLineActionRotateSpeed(builder, TimeLineActionRotateSpeed);
    ConstCombatExcel.AddCriticalConstD(builder, CriticalConstD);
    ConstCombatExcel.AddCriticalConstC(builder, CriticalConstC);
    ConstCombatExcel.AddCriticalConstB(builder, CriticalConstB);
    ConstCombatExcel.AddCriticalConstA(builder, CriticalConstA);
    ConstCombatExcel.AddAccuracyConstD(builder, AccuracyConstD);
    ConstCombatExcel.AddAccuracyConstC(builder, AccuracyConstC);
    ConstCombatExcel.AddAccuracyConstB(builder, AccuracyConstB);
    ConstCombatExcel.AddAccuracyConstA(builder, AccuracyConstA);
    ConstCombatExcel.AddDefenceConstD(builder, DefenceConstD);
    ConstCombatExcel.AddDefenceConstC(builder, DefenceConstC);
    ConstCombatExcel.AddDefenceConstB(builder, DefenceConstB);
    ConstCombatExcel.AddDefenceConstA(builder, DefenceConstA);
    ConstCombatExcel.AddCrowdControlFactor(builder, CrowdControlFactor);
    ConstCombatExcel.AddPlayerRegenCostDelay(builder, PlayerRegenCostDelay);
    ConstCombatExcel.AddChampionRegenCost(builder, ChampionRegenCost);
    ConstCombatExcel.AddEnemyRegenCost(builder, EnemyRegenCost);
    ConstCombatExcel.AddSkillSlotCoolTime(builder, SkillSlotCoolTime);
    ConstCombatExcel.AddTimeLimitAlarm(builder, TimeLimitAlarm);
    ConstCombatExcel.AddMaxRaidBossSkillSlot(builder, MaxRaidBossSkillSlot);
    ConstCombatExcel.AddMaxRaidTicketCount(builder, MaxRaidTicketCount);
    ConstCombatExcel.AddMaxFinalHeal(builder, MaxFinalHeal);
    ConstCombatExcel.AddMaxFinalDamage(builder, MaxFinalDamage);
    ConstCombatExcel.AddEffectTeleportDistance(builder, EffectTeleportDistance);
    ConstCombatExcel.AddArenaMinimumClearTime(builder, ArenaMinimumClearTime);
    ConstCombatExcel.AddCheckCheaterMaxUseCostArena(builder, CheckCheaterMaxUseCostArena);
    ConstCombatExcel.AddCheckCheaterMaxUseCostNonArena(builder, CheckCheaterMaxUseCostNonArena);
    ConstCombatExcel.AddMinimumClearLevelGap(builder, MinimumClearLevelGap);
    ConstCombatExcel.AddMinimumClearTime(builder, MinimumClearTime);
    ConstCombatExcel.AddAimIKMaxDegree(builder, AimIKMaxDegree);
    ConstCombatExcel.AddAimIKMinDegree(builder, AimIKMinDegree);
    ConstCombatExcel.AddEmojiDefaultTime(builder, EmojiDefaultTime);
    ConstCombatExcel.AddMaxGroupBuffLevel(builder, MaxGroupBuffLevel);
    ConstCombatExcel.AddRaidOpenScenarioId(builder, RaidOpenScenarioIdOffset);
    ConstCombatExcel.AddEchelonInitCommonCost(builder, EchelonInitCommonCost);
    ConstCombatExcel.AddEchelonMaxCommonCost(builder, EchelonMaxCommonCost);
    ConstCombatExcel.AddVictoryTimelinePath(builder, VictoryTimelinePathOffset);
    ConstCombatExcel.AddEngageWithSupporterTimelinePath(builder, EngageWithSupporterTimelinePathOffset);
    ConstCombatExcel.AddEngageTimelinePath(builder, EngageTimelinePathOffset);
    ConstCombatExcel.AddShowRaidListCount(builder, ShowRaidListCount);
    ConstCombatExcel.AddPublicSpeechDuration(builder, PublicSpeechDuration);
    ConstCombatExcel.AddPublicSpeechBubbleOffsetZ(builder, PublicSpeechBubbleOffsetZ);
    ConstCombatExcel.AddPublicSpeechBubbleOffsetY(builder, PublicSpeechBubbleOffsetY);
    ConstCombatExcel.AddPublicSpeechBubbleOffsetX(builder, PublicSpeechBubbleOffsetX);
    ConstCombatExcel.AddSuppliesConditionStringId(builder, SuppliesConditionStringIdOffset);
    ConstCombatExcel.AddBuffIconBlinkTime(builder, BuffIconBlinkTime);
    ConstCombatExcel.AddDyingTime(builder, DyingTime);
    ConstCombatExcel.AddSkillHandCount(builder, SkillHandCount);
    ConstCombatExcel.AddUseInitialRangeForCoverMove(builder, UseInitialRangeForCoverMove);
    ConstCombatExcel.AddShowBufficonGroundPassiveSkill(builder, ShowBufficonGroundPassiveSkill);
    ConstCombatExcel.AddShowBufficonLeaderSkill(builder, ShowBufficonLeaderSkill);
    ConstCombatExcel.AddShowBufficonExtraPassiveSkill(builder, ShowBufficonExtraPassiveSkill);
    ConstCombatExcel.AddShowBufficonPassiveSkill(builder, ShowBufficonPassiveSkill);
    ConstCombatExcel.AddShowBufficonEXSkill(builder, ShowBufficonEXSkill);
    return ConstCombatExcel.EndConstCombatExcel(builder);
  }

  public static void StartConstCombatExcel(FlatBufferBuilder builder) { builder.StartTable(71); }
  public static void AddSkillHandCount(FlatBufferBuilder builder, int SkillHandCount) { builder.AddInt(0, SkillHandCount, 0); }
  public static void AddDyingTime(FlatBufferBuilder builder, int DyingTime) { builder.AddInt(1, DyingTime, 0); }
  public static void AddBuffIconBlinkTime(FlatBufferBuilder builder, int BuffIconBlinkTime) { builder.AddInt(2, BuffIconBlinkTime, 0); }
  public static void AddShowBufficonEXSkill(FlatBufferBuilder builder, bool ShowBufficonEXSkill) { builder.AddBool(3, ShowBufficonEXSkill, false); }
  public static void AddShowBufficonPassiveSkill(FlatBufferBuilder builder, bool ShowBufficonPassiveSkill) { builder.AddBool(4, ShowBufficonPassiveSkill, false); }
  public static void AddShowBufficonExtraPassiveSkill(FlatBufferBuilder builder, bool ShowBufficonExtraPassiveSkill) { builder.AddBool(5, ShowBufficonExtraPassiveSkill, false); }
  public static void AddShowBufficonLeaderSkill(FlatBufferBuilder builder, bool ShowBufficonLeaderSkill) { builder.AddBool(6, ShowBufficonLeaderSkill, false); }
  public static void AddShowBufficonGroundPassiveSkill(FlatBufferBuilder builder, bool ShowBufficonGroundPassiveSkill) { builder.AddBool(7, ShowBufficonGroundPassiveSkill, false); }
  public static void AddSuppliesConditionStringId(FlatBufferBuilder builder, StringOffset SuppliesConditionStringIdOffset) { builder.AddOffset(8, SuppliesConditionStringIdOffset.Value, 0); }
  public static void AddPublicSpeechBubbleOffsetX(FlatBufferBuilder builder, float PublicSpeechBubbleOffsetX) { builder.AddFloat(9, PublicSpeechBubbleOffsetX, 0.0f); }
  public static void AddPublicSpeechBubbleOffsetY(FlatBufferBuilder builder, float PublicSpeechBubbleOffsetY) { builder.AddFloat(10, PublicSpeechBubbleOffsetY, 0.0f); }
  public static void AddPublicSpeechBubbleOffsetZ(FlatBufferBuilder builder, float PublicSpeechBubbleOffsetZ) { builder.AddFloat(11, PublicSpeechBubbleOffsetZ, 0.0f); }
  public static void AddPublicSpeechDuration(FlatBufferBuilder builder, float PublicSpeechDuration) { builder.AddFloat(12, PublicSpeechDuration, 0.0f); }
  public static void AddShowRaidListCount(FlatBufferBuilder builder, int ShowRaidListCount) { builder.AddInt(13, ShowRaidListCount, 0); }
  public static void AddMaxFinalDamage(FlatBufferBuilder builder, long MaxFinalDamage) { builder.AddLong(14, MaxFinalDamage, 0); }
  public static void AddMaxFinalHeal(FlatBufferBuilder builder, long MaxFinalHeal) { builder.AddLong(15, MaxFinalHeal, 0); }
  public static void AddMaxRaidTicketCount(FlatBufferBuilder builder, long MaxRaidTicketCount) { builder.AddLong(16, MaxRaidTicketCount, 0); }
  public static void AddMaxRaidBossSkillSlot(FlatBufferBuilder builder, long MaxRaidBossSkillSlot) { builder.AddLong(17, MaxRaidBossSkillSlot, 0); }
  public static void AddEngageTimelinePath(FlatBufferBuilder builder, StringOffset EngageTimelinePathOffset) { builder.AddOffset(18, EngageTimelinePathOffset.Value, 0); }
  public static void AddEngageWithSupporterTimelinePath(FlatBufferBuilder builder, StringOffset EngageWithSupporterTimelinePathOffset) { builder.AddOffset(19, EngageWithSupporterTimelinePathOffset.Value, 0); }
  public static void AddVictoryTimelinePath(FlatBufferBuilder builder, StringOffset VictoryTimelinePathOffset) { builder.AddOffset(20, VictoryTimelinePathOffset.Value, 0); }
  public static void AddTimeLimitAlarm(FlatBufferBuilder builder, long TimeLimitAlarm) { builder.AddLong(21, TimeLimitAlarm, 0); }
  public static void AddEchelonMaxCommonCost(FlatBufferBuilder builder, int EchelonMaxCommonCost) { builder.AddInt(22, EchelonMaxCommonCost, 0); }
  public static void AddEchelonInitCommonCost(FlatBufferBuilder builder, int EchelonInitCommonCost) { builder.AddInt(23, EchelonInitCommonCost, 0); }
  public static void AddSkillSlotCoolTime(FlatBufferBuilder builder, long SkillSlotCoolTime) { builder.AddLong(24, SkillSlotCoolTime, 0); }
  public static void AddEnemyRegenCost(FlatBufferBuilder builder, long EnemyRegenCost) { builder.AddLong(25, EnemyRegenCost, 0); }
  public static void AddChampionRegenCost(FlatBufferBuilder builder, long ChampionRegenCost) { builder.AddLong(26, ChampionRegenCost, 0); }
  public static void AddPlayerRegenCostDelay(FlatBufferBuilder builder, long PlayerRegenCostDelay) { builder.AddLong(27, PlayerRegenCostDelay, 0); }
  public static void AddCrowdControlFactor(FlatBufferBuilder builder, long CrowdControlFactor) { builder.AddLong(28, CrowdControlFactor, 0); }
  public static void AddRaidOpenScenarioId(FlatBufferBuilder builder, StringOffset RaidOpenScenarioIdOffset) { builder.AddOffset(29, RaidOpenScenarioIdOffset.Value, 0); }
  public static void AddDefenceConstA(FlatBufferBuilder builder, long DefenceConstA) { builder.AddLong(30, DefenceConstA, 0); }
  public static void AddDefenceConstB(FlatBufferBuilder builder, long DefenceConstB) { builder.AddLong(31, DefenceConstB, 0); }
  public static void AddDefenceConstC(FlatBufferBuilder builder, long DefenceConstC) { builder.AddLong(32, DefenceConstC, 0); }
  public static void AddDefenceConstD(FlatBufferBuilder builder, long DefenceConstD) { builder.AddLong(33, DefenceConstD, 0); }
  public static void AddAccuracyConstA(FlatBufferBuilder builder, long AccuracyConstA) { builder.AddLong(34, AccuracyConstA, 0); }
  public static void AddAccuracyConstB(FlatBufferBuilder builder, long AccuracyConstB) { builder.AddLong(35, AccuracyConstB, 0); }
  public static void AddAccuracyConstC(FlatBufferBuilder builder, long AccuracyConstC) { builder.AddLong(36, AccuracyConstC, 0); }
  public static void AddAccuracyConstD(FlatBufferBuilder builder, long AccuracyConstD) { builder.AddLong(37, AccuracyConstD, 0); }
  public static void AddCriticalConstA(FlatBufferBuilder builder, long CriticalConstA) { builder.AddLong(38, CriticalConstA, 0); }
  public static void AddCriticalConstB(FlatBufferBuilder builder, long CriticalConstB) { builder.AddLong(39, CriticalConstB, 0); }
  public static void AddCriticalConstC(FlatBufferBuilder builder, long CriticalConstC) { builder.AddLong(40, CriticalConstC, 0); }
  public static void AddCriticalConstD(FlatBufferBuilder builder, long CriticalConstD) { builder.AddLong(41, CriticalConstD, 0); }
  public static void AddMaxGroupBuffLevel(FlatBufferBuilder builder, int MaxGroupBuffLevel) { builder.AddInt(42, MaxGroupBuffLevel, 0); }
  public static void AddEmojiDefaultTime(FlatBufferBuilder builder, int EmojiDefaultTime) { builder.AddInt(43, EmojiDefaultTime, 0); }
  public static void AddTimeLineActionRotateSpeed(FlatBufferBuilder builder, long TimeLineActionRotateSpeed) { builder.AddLong(44, TimeLineActionRotateSpeed, 0); }
  public static void AddBodyRotateSpeed(FlatBufferBuilder builder, long BodyRotateSpeed) { builder.AddLong(45, BodyRotateSpeed, 0); }
  public static void AddNormalTimeScale(FlatBufferBuilder builder, long NormalTimeScale) { builder.AddLong(46, NormalTimeScale, 0); }
  public static void AddFastTimeScale(FlatBufferBuilder builder, long FastTimeScale) { builder.AddLong(47, FastTimeScale, 0); }
  public static void AddBulletTimeScale(FlatBufferBuilder builder, long BulletTimeScale) { builder.AddLong(48, BulletTimeScale, 0); }
  public static void AddUIDisplayDelayAfterSkillCutIn(FlatBufferBuilder builder, long UIDisplayDelayAfterSkillCutIn) { builder.AddLong(49, UIDisplayDelayAfterSkillCutIn, 0); }
  public static void AddUseInitialRangeForCoverMove(FlatBufferBuilder builder, bool UseInitialRangeForCoverMove) { builder.AddBool(50, UseInitialRangeForCoverMove, false); }
  public static void AddSlowTimeScale(FlatBufferBuilder builder, long SlowTimeScale) { builder.AddLong(51, SlowTimeScale, 0); }
  public static void AddAimIKMinDegree(FlatBufferBuilder builder, float AimIKMinDegree) { builder.AddFloat(52, AimIKMinDegree, 0.0f); }
  public static void AddAimIKMaxDegree(FlatBufferBuilder builder, float AimIKMaxDegree) { builder.AddFloat(53, AimIKMaxDegree, 0.0f); }
  public static void AddMinimumClearTime(FlatBufferBuilder builder, int MinimumClearTime) { builder.AddInt(54, MinimumClearTime, 0); }
  public static void AddMinimumClearLevelGap(FlatBufferBuilder builder, int MinimumClearLevelGap) { builder.AddInt(55, MinimumClearLevelGap, 0); }
  public static void AddCheckCheaterMaxUseCostNonArena(FlatBufferBuilder builder, int CheckCheaterMaxUseCostNonArena) { builder.AddInt(56, CheckCheaterMaxUseCostNonArena, 0); }
  public static void AddCheckCheaterMaxUseCostArena(FlatBufferBuilder builder, int CheckCheaterMaxUseCostArena) { builder.AddInt(57, CheckCheaterMaxUseCostArena, 0); }
  public static void AddAllowedMaxTimeScale(FlatBufferBuilder builder, long AllowedMaxTimeScale) { builder.AddLong(58, AllowedMaxTimeScale, 0); }
  public static void AddRandomAnimationOutput(FlatBufferBuilder builder, long RandomAnimationOutput) { builder.AddLong(59, RandomAnimationOutput, 0); }
  public static void AddSummonedTeleportDistance(FlatBufferBuilder builder, long SummonedTeleportDistance) { builder.AddLong(60, SummonedTeleportDistance, 0); }
  public static void AddArenaMinimumClearTime(FlatBufferBuilder builder, int ArenaMinimumClearTime) { builder.AddInt(61, ArenaMinimumClearTime, 0); }
  public static void AddWORLDBOSSBATTLELITTLE(FlatBufferBuilder builder, long WORLDBOSSBATTLELITTLE) { builder.AddLong(62, WORLDBOSSBATTLELITTLE, 0); }
  public static void AddWORLDBOSSBATTLEMIDDLE(FlatBufferBuilder builder, long WORLDBOSSBATTLEMIDDLE) { builder.AddLong(63, WORLDBOSSBATTLEMIDDLE, 0); }
  public static void AddWORLDBOSSBATTLEHIGH(FlatBufferBuilder builder, long WORLDBOSSBATTLEHIGH) { builder.AddLong(64, WORLDBOSSBATTLEHIGH, 0); }
  public static void AddWORLDBOSSBATTLEVERYHIGH(FlatBufferBuilder builder, long WORLDBOSSBATTLEVERYHIGH) { builder.AddLong(65, WORLDBOSSBATTLEVERYHIGH, 0); }
  public static void AddWorldRaidAutoSyncTermSecond(FlatBufferBuilder builder, long WorldRaidAutoSyncTermSecond) { builder.AddLong(66, WorldRaidAutoSyncTermSecond, 0); }
  public static void AddWorldRaidBossHpDecreaseTerm(FlatBufferBuilder builder, long WorldRaidBossHpDecreaseTerm) { builder.AddLong(67, WorldRaidBossHpDecreaseTerm, 0); }
  public static void AddWorldRaidBossParcelReactionDelay(FlatBufferBuilder builder, long WorldRaidBossParcelReactionDelay) { builder.AddLong(68, WorldRaidBossParcelReactionDelay, 0); }
  public static void AddRaidRankingJumpMinimumWaitingTime(FlatBufferBuilder builder, long RaidRankingJumpMinimumWaitingTime) { builder.AddLong(69, RaidRankingJumpMinimumWaitingTime, 0); }
  public static void AddEffectTeleportDistance(FlatBufferBuilder builder, float EffectTeleportDistance) { builder.AddFloat(70, EffectTeleportDistance, 0.0f); }
  public static Offset<FlatDataJp.ConstCombatExcel> EndConstCombatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConstCombatExcel>(o);
  }
}


}
