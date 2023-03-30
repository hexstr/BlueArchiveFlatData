// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterStatExcel GetRootAsCharacterStatExcel(ByteBuffer _bb) { return GetRootAsCharacterStatExcel(_bb, new CharacterStatExcel()); }
  public static CharacterStatExcel GetRootAsCharacterStatExcel(ByteBuffer _bb, CharacterStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StabilityRate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StabilityPoint { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower1 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower100 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP1 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP100 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePower1 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePower100 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower1 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower100 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DodgePoint { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyPoint { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalPoint { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalResistPoint { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalDamageRate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalDamageResistRate { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BlockRate { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealEffectivenessRate { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OppressionPower { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OppressionResist { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetration1 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetration100 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetrationResist1 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetrationResist100 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceExplosionRate { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhancePierceRate { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceMysticRate { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceSiegeRate { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceNormalRate { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceLightArmorRate { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceHeavyArmorRate { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceUnarmedRate { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceStructureRate { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceNormalArmorRate { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendBuffDuration { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendDebuffDuration { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendCrowdControlDuration { get { int o = __p.__offset(78); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AmmoCount { get { int o = __p.__offset(80); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AmmoCost { get { int o = __p.__offset(82); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long IgnoreDelayCount { get { int o = __p.__offset(84); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NormalAttackSpeed { get { int o = __p.__offset(86); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Range { get { int o = __p.__offset(88); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long InitialRangeRate { get { int o = __p.__offset(90); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MoveSpeed { get { int o = __p.__offset(92); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SightPoint { get { int o = __p.__offset(94); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActiveGauge { get { int o = __p.__offset(96); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int GroggyGauge { get { int o = __p.__offset(98); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroggyTime { get { int o = __p.__offset(100); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StrategyMobility { get { int o = __p.__offset(102); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActionCount { get { int o = __p.__offset(104); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StrategySightRange { get { int o = __p.__offset(106); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamageRatio { get { int o = __p.__offset(108); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamagedRatio { get { int o = __p.__offset(110); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TerrainAdaptationStat StreetBattleAdaptation { get { int o = __p.__offset(112); return o != 0 ? (FlatDataGlobal.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TerrainAdaptationStat.D; } }
  public FlatDataGlobal.TerrainAdaptationStat OutdoorBattleAdaptation { get { int o = __p.__offset(114); return o != 0 ? (FlatDataGlobal.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TerrainAdaptationStat.D; } }
  public FlatDataGlobal.TerrainAdaptationStat IndoorBattleAdaptation { get { int o = __p.__offset(116); return o != 0 ? (FlatDataGlobal.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TerrainAdaptationStat.D; } }
  public long RegenCost { get { int o = __p.__offset(118); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.CharacterStatExcel> CreateCharacterStatExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long StabilityRate = 0,
      long StabilityPoint = 0,
      long AttackPower1 = 0,
      long AttackPower100 = 0,
      long MaxHP1 = 0,
      long MaxHP100 = 0,
      long DefensePower1 = 0,
      long DefensePower100 = 0,
      long HealPower1 = 0,
      long HealPower100 = 0,
      long DodgePoint = 0,
      long AccuracyPoint = 0,
      long CriticalPoint = 0,
      long CriticalResistPoint = 0,
      long CriticalDamageRate = 0,
      long CriticalDamageResistRate = 0,
      long BlockRate = 0,
      long HealEffectivenessRate = 0,
      long OppressionPower = 0,
      long OppressionResist = 0,
      long DefensePenetration1 = 0,
      long DefensePenetration100 = 0,
      long DefensePenetrationResist1 = 0,
      long DefensePenetrationResist100 = 0,
      long EnhanceExplosionRate = 0,
      long EnhancePierceRate = 0,
      long EnhanceMysticRate = 0,
      long EnhanceSiegeRate = 0,
      long EnhanceNormalRate = 0,
      long EnhanceLightArmorRate = 0,
      long EnhanceHeavyArmorRate = 0,
      long EnhanceUnarmedRate = 0,
      long EnhanceStructureRate = 0,
      long EnhanceNormalArmorRate = 0,
      long ExtendBuffDuration = 0,
      long ExtendDebuffDuration = 0,
      long ExtendCrowdControlDuration = 0,
      long AmmoCount = 0,
      long AmmoCost = 0,
      long IgnoreDelayCount = 0,
      long NormalAttackSpeed = 0,
      long Range = 0,
      long InitialRangeRate = 0,
      long MoveSpeed = 0,
      long SightPoint = 0,
      long ActiveGauge = 0,
      int GroggyGauge = 0,
      int GroggyTime = 0,
      long StrategyMobility = 0,
      long ActionCount = 0,
      long StrategySightRange = 0,
      long DamageRatio = 0,
      long DamagedRatio = 0,
      FlatDataGlobal.TerrainAdaptationStat StreetBattleAdaptation = FlatDataGlobal.TerrainAdaptationStat.D,
      FlatDataGlobal.TerrainAdaptationStat OutdoorBattleAdaptation = FlatDataGlobal.TerrainAdaptationStat.D,
      FlatDataGlobal.TerrainAdaptationStat IndoorBattleAdaptation = FlatDataGlobal.TerrainAdaptationStat.D,
      long RegenCost = 0) {
    builder.StartTable(58);
    CharacterStatExcel.AddRegenCost(builder, RegenCost);
    CharacterStatExcel.AddDamagedRatio(builder, DamagedRatio);
    CharacterStatExcel.AddDamageRatio(builder, DamageRatio);
    CharacterStatExcel.AddStrategySightRange(builder, StrategySightRange);
    CharacterStatExcel.AddActionCount(builder, ActionCount);
    CharacterStatExcel.AddStrategyMobility(builder, StrategyMobility);
    CharacterStatExcel.AddActiveGauge(builder, ActiveGauge);
    CharacterStatExcel.AddSightPoint(builder, SightPoint);
    CharacterStatExcel.AddMoveSpeed(builder, MoveSpeed);
    CharacterStatExcel.AddInitialRangeRate(builder, InitialRangeRate);
    CharacterStatExcel.AddRange(builder, Range);
    CharacterStatExcel.AddNormalAttackSpeed(builder, NormalAttackSpeed);
    CharacterStatExcel.AddIgnoreDelayCount(builder, IgnoreDelayCount);
    CharacterStatExcel.AddAmmoCost(builder, AmmoCost);
    CharacterStatExcel.AddAmmoCount(builder, AmmoCount);
    CharacterStatExcel.AddExtendCrowdControlDuration(builder, ExtendCrowdControlDuration);
    CharacterStatExcel.AddExtendDebuffDuration(builder, ExtendDebuffDuration);
    CharacterStatExcel.AddExtendBuffDuration(builder, ExtendBuffDuration);
    CharacterStatExcel.AddEnhanceNormalArmorRate(builder, EnhanceNormalArmorRate);
    CharacterStatExcel.AddEnhanceStructureRate(builder, EnhanceStructureRate);
    CharacterStatExcel.AddEnhanceUnarmedRate(builder, EnhanceUnarmedRate);
    CharacterStatExcel.AddEnhanceHeavyArmorRate(builder, EnhanceHeavyArmorRate);
    CharacterStatExcel.AddEnhanceLightArmorRate(builder, EnhanceLightArmorRate);
    CharacterStatExcel.AddEnhanceNormalRate(builder, EnhanceNormalRate);
    CharacterStatExcel.AddEnhanceSiegeRate(builder, EnhanceSiegeRate);
    CharacterStatExcel.AddEnhanceMysticRate(builder, EnhanceMysticRate);
    CharacterStatExcel.AddEnhancePierceRate(builder, EnhancePierceRate);
    CharacterStatExcel.AddEnhanceExplosionRate(builder, EnhanceExplosionRate);
    CharacterStatExcel.AddDefensePenetrationResist100(builder, DefensePenetrationResist100);
    CharacterStatExcel.AddDefensePenetrationResist1(builder, DefensePenetrationResist1);
    CharacterStatExcel.AddDefensePenetration100(builder, DefensePenetration100);
    CharacterStatExcel.AddDefensePenetration1(builder, DefensePenetration1);
    CharacterStatExcel.AddOppressionResist(builder, OppressionResist);
    CharacterStatExcel.AddOppressionPower(builder, OppressionPower);
    CharacterStatExcel.AddHealEffectivenessRate(builder, HealEffectivenessRate);
    CharacterStatExcel.AddBlockRate(builder, BlockRate);
    CharacterStatExcel.AddCriticalDamageResistRate(builder, CriticalDamageResistRate);
    CharacterStatExcel.AddCriticalDamageRate(builder, CriticalDamageRate);
    CharacterStatExcel.AddCriticalResistPoint(builder, CriticalResistPoint);
    CharacterStatExcel.AddCriticalPoint(builder, CriticalPoint);
    CharacterStatExcel.AddAccuracyPoint(builder, AccuracyPoint);
    CharacterStatExcel.AddDodgePoint(builder, DodgePoint);
    CharacterStatExcel.AddHealPower100(builder, HealPower100);
    CharacterStatExcel.AddHealPower1(builder, HealPower1);
    CharacterStatExcel.AddDefensePower100(builder, DefensePower100);
    CharacterStatExcel.AddDefensePower1(builder, DefensePower1);
    CharacterStatExcel.AddMaxHP100(builder, MaxHP100);
    CharacterStatExcel.AddMaxHP1(builder, MaxHP1);
    CharacterStatExcel.AddAttackPower100(builder, AttackPower100);
    CharacterStatExcel.AddAttackPower1(builder, AttackPower1);
    CharacterStatExcel.AddStabilityPoint(builder, StabilityPoint);
    CharacterStatExcel.AddStabilityRate(builder, StabilityRate);
    CharacterStatExcel.AddCharacterId(builder, CharacterId);
    CharacterStatExcel.AddIndoorBattleAdaptation(builder, IndoorBattleAdaptation);
    CharacterStatExcel.AddOutdoorBattleAdaptation(builder, OutdoorBattleAdaptation);
    CharacterStatExcel.AddStreetBattleAdaptation(builder, StreetBattleAdaptation);
    CharacterStatExcel.AddGroggyTime(builder, GroggyTime);
    CharacterStatExcel.AddGroggyGauge(builder, GroggyGauge);
    return CharacterStatExcel.EndCharacterStatExcel(builder);
  }

  public static void StartCharacterStatExcel(FlatBufferBuilder builder) { builder.StartTable(58); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddStabilityRate(FlatBufferBuilder builder, long StabilityRate) { builder.AddLong(1, StabilityRate, 0); }
  public static void AddStabilityPoint(FlatBufferBuilder builder, long StabilityPoint) { builder.AddLong(2, StabilityPoint, 0); }
  public static void AddAttackPower1(FlatBufferBuilder builder, long AttackPower1) { builder.AddLong(3, AttackPower1, 0); }
  public static void AddAttackPower100(FlatBufferBuilder builder, long AttackPower100) { builder.AddLong(4, AttackPower100, 0); }
  public static void AddMaxHP1(FlatBufferBuilder builder, long MaxHP1) { builder.AddLong(5, MaxHP1, 0); }
  public static void AddMaxHP100(FlatBufferBuilder builder, long MaxHP100) { builder.AddLong(6, MaxHP100, 0); }
  public static void AddDefensePower1(FlatBufferBuilder builder, long DefensePower1) { builder.AddLong(7, DefensePower1, 0); }
  public static void AddDefensePower100(FlatBufferBuilder builder, long DefensePower100) { builder.AddLong(8, DefensePower100, 0); }
  public static void AddHealPower1(FlatBufferBuilder builder, long HealPower1) { builder.AddLong(9, HealPower1, 0); }
  public static void AddHealPower100(FlatBufferBuilder builder, long HealPower100) { builder.AddLong(10, HealPower100, 0); }
  public static void AddDodgePoint(FlatBufferBuilder builder, long DodgePoint) { builder.AddLong(11, DodgePoint, 0); }
  public static void AddAccuracyPoint(FlatBufferBuilder builder, long AccuracyPoint) { builder.AddLong(12, AccuracyPoint, 0); }
  public static void AddCriticalPoint(FlatBufferBuilder builder, long CriticalPoint) { builder.AddLong(13, CriticalPoint, 0); }
  public static void AddCriticalResistPoint(FlatBufferBuilder builder, long CriticalResistPoint) { builder.AddLong(14, CriticalResistPoint, 0); }
  public static void AddCriticalDamageRate(FlatBufferBuilder builder, long CriticalDamageRate) { builder.AddLong(15, CriticalDamageRate, 0); }
  public static void AddCriticalDamageResistRate(FlatBufferBuilder builder, long CriticalDamageResistRate) { builder.AddLong(16, CriticalDamageResistRate, 0); }
  public static void AddBlockRate(FlatBufferBuilder builder, long BlockRate) { builder.AddLong(17, BlockRate, 0); }
  public static void AddHealEffectivenessRate(FlatBufferBuilder builder, long HealEffectivenessRate) { builder.AddLong(18, HealEffectivenessRate, 0); }
  public static void AddOppressionPower(FlatBufferBuilder builder, long OppressionPower) { builder.AddLong(19, OppressionPower, 0); }
  public static void AddOppressionResist(FlatBufferBuilder builder, long OppressionResist) { builder.AddLong(20, OppressionResist, 0); }
  public static void AddDefensePenetration1(FlatBufferBuilder builder, long DefensePenetration1) { builder.AddLong(21, DefensePenetration1, 0); }
  public static void AddDefensePenetration100(FlatBufferBuilder builder, long DefensePenetration100) { builder.AddLong(22, DefensePenetration100, 0); }
  public static void AddDefensePenetrationResist1(FlatBufferBuilder builder, long DefensePenetrationResist1) { builder.AddLong(23, DefensePenetrationResist1, 0); }
  public static void AddDefensePenetrationResist100(FlatBufferBuilder builder, long DefensePenetrationResist100) { builder.AddLong(24, DefensePenetrationResist100, 0); }
  public static void AddEnhanceExplosionRate(FlatBufferBuilder builder, long EnhanceExplosionRate) { builder.AddLong(25, EnhanceExplosionRate, 0); }
  public static void AddEnhancePierceRate(FlatBufferBuilder builder, long EnhancePierceRate) { builder.AddLong(26, EnhancePierceRate, 0); }
  public static void AddEnhanceMysticRate(FlatBufferBuilder builder, long EnhanceMysticRate) { builder.AddLong(27, EnhanceMysticRate, 0); }
  public static void AddEnhanceSiegeRate(FlatBufferBuilder builder, long EnhanceSiegeRate) { builder.AddLong(28, EnhanceSiegeRate, 0); }
  public static void AddEnhanceNormalRate(FlatBufferBuilder builder, long EnhanceNormalRate) { builder.AddLong(29, EnhanceNormalRate, 0); }
  public static void AddEnhanceLightArmorRate(FlatBufferBuilder builder, long EnhanceLightArmorRate) { builder.AddLong(30, EnhanceLightArmorRate, 0); }
  public static void AddEnhanceHeavyArmorRate(FlatBufferBuilder builder, long EnhanceHeavyArmorRate) { builder.AddLong(31, EnhanceHeavyArmorRate, 0); }
  public static void AddEnhanceUnarmedRate(FlatBufferBuilder builder, long EnhanceUnarmedRate) { builder.AddLong(32, EnhanceUnarmedRate, 0); }
  public static void AddEnhanceStructureRate(FlatBufferBuilder builder, long EnhanceStructureRate) { builder.AddLong(33, EnhanceStructureRate, 0); }
  public static void AddEnhanceNormalArmorRate(FlatBufferBuilder builder, long EnhanceNormalArmorRate) { builder.AddLong(34, EnhanceNormalArmorRate, 0); }
  public static void AddExtendBuffDuration(FlatBufferBuilder builder, long ExtendBuffDuration) { builder.AddLong(35, ExtendBuffDuration, 0); }
  public static void AddExtendDebuffDuration(FlatBufferBuilder builder, long ExtendDebuffDuration) { builder.AddLong(36, ExtendDebuffDuration, 0); }
  public static void AddExtendCrowdControlDuration(FlatBufferBuilder builder, long ExtendCrowdControlDuration) { builder.AddLong(37, ExtendCrowdControlDuration, 0); }
  public static void AddAmmoCount(FlatBufferBuilder builder, long AmmoCount) { builder.AddLong(38, AmmoCount, 0); }
  public static void AddAmmoCost(FlatBufferBuilder builder, long AmmoCost) { builder.AddLong(39, AmmoCost, 0); }
  public static void AddIgnoreDelayCount(FlatBufferBuilder builder, long IgnoreDelayCount) { builder.AddLong(40, IgnoreDelayCount, 0); }
  public static void AddNormalAttackSpeed(FlatBufferBuilder builder, long NormalAttackSpeed) { builder.AddLong(41, NormalAttackSpeed, 0); }
  public static void AddRange(FlatBufferBuilder builder, long Range) { builder.AddLong(42, Range, 0); }
  public static void AddInitialRangeRate(FlatBufferBuilder builder, long InitialRangeRate) { builder.AddLong(43, InitialRangeRate, 0); }
  public static void AddMoveSpeed(FlatBufferBuilder builder, long MoveSpeed) { builder.AddLong(44, MoveSpeed, 0); }
  public static void AddSightPoint(FlatBufferBuilder builder, long SightPoint) { builder.AddLong(45, SightPoint, 0); }
  public static void AddActiveGauge(FlatBufferBuilder builder, long ActiveGauge) { builder.AddLong(46, ActiveGauge, 0); }
  public static void AddGroggyGauge(FlatBufferBuilder builder, int GroggyGauge) { builder.AddInt(47, GroggyGauge, 0); }
  public static void AddGroggyTime(FlatBufferBuilder builder, int GroggyTime) { builder.AddInt(48, GroggyTime, 0); }
  public static void AddStrategyMobility(FlatBufferBuilder builder, long StrategyMobility) { builder.AddLong(49, StrategyMobility, 0); }
  public static void AddActionCount(FlatBufferBuilder builder, long ActionCount) { builder.AddLong(50, ActionCount, 0); }
  public static void AddStrategySightRange(FlatBufferBuilder builder, long StrategySightRange) { builder.AddLong(51, StrategySightRange, 0); }
  public static void AddDamageRatio(FlatBufferBuilder builder, long DamageRatio) { builder.AddLong(52, DamageRatio, 0); }
  public static void AddDamagedRatio(FlatBufferBuilder builder, long DamagedRatio) { builder.AddLong(53, DamagedRatio, 0); }
  public static void AddStreetBattleAdaptation(FlatBufferBuilder builder, FlatDataGlobal.TerrainAdaptationStat StreetBattleAdaptation) { builder.AddInt(54, (int)StreetBattleAdaptation, 0); }
  public static void AddOutdoorBattleAdaptation(FlatBufferBuilder builder, FlatDataGlobal.TerrainAdaptationStat OutdoorBattleAdaptation) { builder.AddInt(55, (int)OutdoorBattleAdaptation, 0); }
  public static void AddIndoorBattleAdaptation(FlatBufferBuilder builder, FlatDataGlobal.TerrainAdaptationStat IndoorBattleAdaptation) { builder.AddInt(56, (int)IndoorBattleAdaptation, 0); }
  public static void AddRegenCost(FlatBufferBuilder builder, long RegenCost) { builder.AddLong(57, RegenCost, 0); }
  public static Offset<FlatDataGlobal.CharacterStatExcel> EndCharacterStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterStatExcel>(o);
  }
}


}
