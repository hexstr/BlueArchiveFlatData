// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GroundExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static GroundExcel GetRootAsGroundExcel(ByteBuffer _bb) { return GetRootAsGroundExcel(_bb, new GroundExcel()); }
  public static GroundExcel GetRootAsGroundExcel(ByteBuffer _bb, GroundExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StageFileName(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int StageFileNameLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string GroundSceneName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroundSceneNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetGroundSceneNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetGroundSceneNameArray() { return __p.__vector_as_array<byte>(8); }
  public long FormationGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.StageTopography StageTopography { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageTopography.Street; } }
  public FlatDataJp.BulletType EnemyBulletType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.BulletType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.BulletType.Normal; } }
  public FlatDataJp.ArmorType EnemyArmorType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ArmorType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ArmorType.LightArmor; } }
  public long LevelNPC { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LevelMinion { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LevelElite { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LevelChampion { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LevelBoss { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ObstacleLevel { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GradeNPC { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GradeMinion { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GradeElite { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GradeChampion { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GradeBoss { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerSightPointAdd { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerSightPointRate { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerAttackRangeAdd { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerAttackRangeRate { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemySightPointAdd { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemySightPointRate { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemyAttackRangeAdd { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemyAttackRangeRate { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerSkillRangeAdd { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayerSkillRangeRate { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemySkillRangeAdd { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnemySkillRangeRate { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool PlayerSightRangeMax { get { int o = __p.__offset(64); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EnemySightRangeMax { get { int o = __p.__offset(66); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long TSSAirUnitHeight { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsRaid { get { int o = __p.__offset(70); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long BGMId { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool WarningUI { get { int o = __p.__offset(74); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool TSSHatchOpen { get { int o = __p.__offset(76); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataJp.TacticSpeed ForcedTacticSpeed { get { int o = __p.__offset(78); return o != 0 ? (FlatDataJp.TacticSpeed)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticSpeed.None; } }
  public FlatDataJp.TacticSkillUse ForcedSkillUse { get { int o = __p.__offset(80); return o != 0 ? (FlatDataJp.TacticSkillUse)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticSkillUse.None; } }
  public FlatDataJp.ShowSkillCutIn ShowNPCSkillCutIn { get { int o = __p.__offset(82); return o != 0 ? (FlatDataJp.ShowSkillCutIn)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ShowSkillCutIn.None; } }

  public static Offset<FlatDataJp.GroundExcel> CreateGroundExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset StageFileNameOffset = default(VectorOffset),
      StringOffset GroundSceneNameOffset = default(StringOffset),
      long FormationGroupId = 0,
      FlatDataJp.StageTopography StageTopography = FlatDataJp.StageTopography.Street,
      FlatDataJp.BulletType EnemyBulletType = FlatDataJp.BulletType.Normal,
      FlatDataJp.ArmorType EnemyArmorType = FlatDataJp.ArmorType.LightArmor,
      long LevelNPC = 0,
      long LevelMinion = 0,
      long LevelElite = 0,
      long LevelChampion = 0,
      long LevelBoss = 0,
      long ObstacleLevel = 0,
      long GradeNPC = 0,
      long GradeMinion = 0,
      long GradeElite = 0,
      long GradeChampion = 0,
      long GradeBoss = 0,
      long PlayerSightPointAdd = 0,
      long PlayerSightPointRate = 0,
      long PlayerAttackRangeAdd = 0,
      long PlayerAttackRangeRate = 0,
      long EnemySightPointAdd = 0,
      long EnemySightPointRate = 0,
      long EnemyAttackRangeAdd = 0,
      long EnemyAttackRangeRate = 0,
      long PlayerSkillRangeAdd = 0,
      long PlayerSkillRangeRate = 0,
      long EnemySkillRangeAdd = 0,
      long EnemySkillRangeRate = 0,
      bool PlayerSightRangeMax = false,
      bool EnemySightRangeMax = false,
      long TSSAirUnitHeight = 0,
      bool IsRaid = false,
      long BGMId = 0,
      bool WarningUI = false,
      bool TSSHatchOpen = false,
      FlatDataJp.TacticSpeed ForcedTacticSpeed = FlatDataJp.TacticSpeed.None,
      FlatDataJp.TacticSkillUse ForcedSkillUse = FlatDataJp.TacticSkillUse.None,
      FlatDataJp.ShowSkillCutIn ShowNPCSkillCutIn = FlatDataJp.ShowSkillCutIn.None) {
    builder.StartTable(40);
    GroundExcel.AddBGMId(builder, BGMId);
    GroundExcel.AddTSSAirUnitHeight(builder, TSSAirUnitHeight);
    GroundExcel.AddEnemySkillRangeRate(builder, EnemySkillRangeRate);
    GroundExcel.AddEnemySkillRangeAdd(builder, EnemySkillRangeAdd);
    GroundExcel.AddPlayerSkillRangeRate(builder, PlayerSkillRangeRate);
    GroundExcel.AddPlayerSkillRangeAdd(builder, PlayerSkillRangeAdd);
    GroundExcel.AddEnemyAttackRangeRate(builder, EnemyAttackRangeRate);
    GroundExcel.AddEnemyAttackRangeAdd(builder, EnemyAttackRangeAdd);
    GroundExcel.AddEnemySightPointRate(builder, EnemySightPointRate);
    GroundExcel.AddEnemySightPointAdd(builder, EnemySightPointAdd);
    GroundExcel.AddPlayerAttackRangeRate(builder, PlayerAttackRangeRate);
    GroundExcel.AddPlayerAttackRangeAdd(builder, PlayerAttackRangeAdd);
    GroundExcel.AddPlayerSightPointRate(builder, PlayerSightPointRate);
    GroundExcel.AddPlayerSightPointAdd(builder, PlayerSightPointAdd);
    GroundExcel.AddGradeBoss(builder, GradeBoss);
    GroundExcel.AddGradeChampion(builder, GradeChampion);
    GroundExcel.AddGradeElite(builder, GradeElite);
    GroundExcel.AddGradeMinion(builder, GradeMinion);
    GroundExcel.AddGradeNPC(builder, GradeNPC);
    GroundExcel.AddObstacleLevel(builder, ObstacleLevel);
    GroundExcel.AddLevelBoss(builder, LevelBoss);
    GroundExcel.AddLevelChampion(builder, LevelChampion);
    GroundExcel.AddLevelElite(builder, LevelElite);
    GroundExcel.AddLevelMinion(builder, LevelMinion);
    GroundExcel.AddLevelNPC(builder, LevelNPC);
    GroundExcel.AddFormationGroupId(builder, FormationGroupId);
    GroundExcel.AddId(builder, Id);
    GroundExcel.AddShowNPCSkillCutIn(builder, ShowNPCSkillCutIn);
    GroundExcel.AddForcedSkillUse(builder, ForcedSkillUse);
    GroundExcel.AddForcedTacticSpeed(builder, ForcedTacticSpeed);
    GroundExcel.AddEnemyArmorType(builder, EnemyArmorType);
    GroundExcel.AddEnemyBulletType(builder, EnemyBulletType);
    GroundExcel.AddStageTopography(builder, StageTopography);
    GroundExcel.AddGroundSceneName(builder, GroundSceneNameOffset);
    GroundExcel.AddStageFileName(builder, StageFileNameOffset);
    GroundExcel.AddTSSHatchOpen(builder, TSSHatchOpen);
    GroundExcel.AddWarningUI(builder, WarningUI);
    GroundExcel.AddIsRaid(builder, IsRaid);
    GroundExcel.AddEnemySightRangeMax(builder, EnemySightRangeMax);
    GroundExcel.AddPlayerSightRangeMax(builder, PlayerSightRangeMax);
    return GroundExcel.EndGroundExcel(builder);
  }

  public static void StartGroundExcel(FlatBufferBuilder builder) { builder.StartTable(40); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddStageFileName(FlatBufferBuilder builder, VectorOffset StageFileNameOffset) { builder.AddOffset(1, StageFileNameOffset.Value, 0); }
  public static VectorOffset CreateStageFileNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateStageFileNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageFileNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageFileNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageFileNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroundSceneName(FlatBufferBuilder builder, StringOffset GroundSceneNameOffset) { builder.AddOffset(2, GroundSceneNameOffset.Value, 0); }
  public static void AddFormationGroupId(FlatBufferBuilder builder, long FormationGroupId) { builder.AddLong(3, FormationGroupId, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatDataJp.StageTopography StageTopography) { builder.AddInt(4, (int)StageTopography, 0); }
  public static void AddEnemyBulletType(FlatBufferBuilder builder, FlatDataJp.BulletType EnemyBulletType) { builder.AddInt(5, (int)EnemyBulletType, 0); }
  public static void AddEnemyArmorType(FlatBufferBuilder builder, FlatDataJp.ArmorType EnemyArmorType) { builder.AddInt(6, (int)EnemyArmorType, 0); }
  public static void AddLevelNPC(FlatBufferBuilder builder, long LevelNPC) { builder.AddLong(7, LevelNPC, 0); }
  public static void AddLevelMinion(FlatBufferBuilder builder, long LevelMinion) { builder.AddLong(8, LevelMinion, 0); }
  public static void AddLevelElite(FlatBufferBuilder builder, long LevelElite) { builder.AddLong(9, LevelElite, 0); }
  public static void AddLevelChampion(FlatBufferBuilder builder, long LevelChampion) { builder.AddLong(10, LevelChampion, 0); }
  public static void AddLevelBoss(FlatBufferBuilder builder, long LevelBoss) { builder.AddLong(11, LevelBoss, 0); }
  public static void AddObstacleLevel(FlatBufferBuilder builder, long ObstacleLevel) { builder.AddLong(12, ObstacleLevel, 0); }
  public static void AddGradeNPC(FlatBufferBuilder builder, long GradeNPC) { builder.AddLong(13, GradeNPC, 0); }
  public static void AddGradeMinion(FlatBufferBuilder builder, long GradeMinion) { builder.AddLong(14, GradeMinion, 0); }
  public static void AddGradeElite(FlatBufferBuilder builder, long GradeElite) { builder.AddLong(15, GradeElite, 0); }
  public static void AddGradeChampion(FlatBufferBuilder builder, long GradeChampion) { builder.AddLong(16, GradeChampion, 0); }
  public static void AddGradeBoss(FlatBufferBuilder builder, long GradeBoss) { builder.AddLong(17, GradeBoss, 0); }
  public static void AddPlayerSightPointAdd(FlatBufferBuilder builder, long PlayerSightPointAdd) { builder.AddLong(18, PlayerSightPointAdd, 0); }
  public static void AddPlayerSightPointRate(FlatBufferBuilder builder, long PlayerSightPointRate) { builder.AddLong(19, PlayerSightPointRate, 0); }
  public static void AddPlayerAttackRangeAdd(FlatBufferBuilder builder, long PlayerAttackRangeAdd) { builder.AddLong(20, PlayerAttackRangeAdd, 0); }
  public static void AddPlayerAttackRangeRate(FlatBufferBuilder builder, long PlayerAttackRangeRate) { builder.AddLong(21, PlayerAttackRangeRate, 0); }
  public static void AddEnemySightPointAdd(FlatBufferBuilder builder, long EnemySightPointAdd) { builder.AddLong(22, EnemySightPointAdd, 0); }
  public static void AddEnemySightPointRate(FlatBufferBuilder builder, long EnemySightPointRate) { builder.AddLong(23, EnemySightPointRate, 0); }
  public static void AddEnemyAttackRangeAdd(FlatBufferBuilder builder, long EnemyAttackRangeAdd) { builder.AddLong(24, EnemyAttackRangeAdd, 0); }
  public static void AddEnemyAttackRangeRate(FlatBufferBuilder builder, long EnemyAttackRangeRate) { builder.AddLong(25, EnemyAttackRangeRate, 0); }
  public static void AddPlayerSkillRangeAdd(FlatBufferBuilder builder, long PlayerSkillRangeAdd) { builder.AddLong(26, PlayerSkillRangeAdd, 0); }
  public static void AddPlayerSkillRangeRate(FlatBufferBuilder builder, long PlayerSkillRangeRate) { builder.AddLong(27, PlayerSkillRangeRate, 0); }
  public static void AddEnemySkillRangeAdd(FlatBufferBuilder builder, long EnemySkillRangeAdd) { builder.AddLong(28, EnemySkillRangeAdd, 0); }
  public static void AddEnemySkillRangeRate(FlatBufferBuilder builder, long EnemySkillRangeRate) { builder.AddLong(29, EnemySkillRangeRate, 0); }
  public static void AddPlayerSightRangeMax(FlatBufferBuilder builder, bool PlayerSightRangeMax) { builder.AddBool(30, PlayerSightRangeMax, false); }
  public static void AddEnemySightRangeMax(FlatBufferBuilder builder, bool EnemySightRangeMax) { builder.AddBool(31, EnemySightRangeMax, false); }
  public static void AddTSSAirUnitHeight(FlatBufferBuilder builder, long TSSAirUnitHeight) { builder.AddLong(32, TSSAirUnitHeight, 0); }
  public static void AddIsRaid(FlatBufferBuilder builder, bool IsRaid) { builder.AddBool(33, IsRaid, false); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(34, BGMId, 0); }
  public static void AddWarningUI(FlatBufferBuilder builder, bool WarningUI) { builder.AddBool(35, WarningUI, false); }
  public static void AddTSSHatchOpen(FlatBufferBuilder builder, bool TSSHatchOpen) { builder.AddBool(36, TSSHatchOpen, false); }
  public static void AddForcedTacticSpeed(FlatBufferBuilder builder, FlatDataJp.TacticSpeed ForcedTacticSpeed) { builder.AddInt(37, (int)ForcedTacticSpeed, 0); }
  public static void AddForcedSkillUse(FlatBufferBuilder builder, FlatDataJp.TacticSkillUse ForcedSkillUse) { builder.AddInt(38, (int)ForcedSkillUse, 0); }
  public static void AddShowNPCSkillCutIn(FlatBufferBuilder builder, FlatDataJp.ShowSkillCutIn ShowNPCSkillCutIn) { builder.AddInt(39, (int)ShowNPCSkillCutIn, 0); }
  public static Offset<FlatDataJp.GroundExcel> EndGroundExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.GroundExcel>(o);
  }
}


}
