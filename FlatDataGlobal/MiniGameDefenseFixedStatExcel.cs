// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameDefenseFixedStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MiniGameDefenseFixedStatExcel GetRootAsMiniGameDefenseFixedStatExcel(ByteBuffer _bb) { return GetRootAsMiniGameDefenseFixedStatExcel(_bb, new MiniGameDefenseFixedStatExcel()); }
  public static MiniGameDefenseFixedStatExcel GetRootAsMiniGameDefenseFixedStatExcel(ByteBuffer _bb, MiniGameDefenseFixedStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameDefenseFixedStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long MinigameDefenseFixedStatId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Grade { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExSkillLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NoneExSkillLevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment1Tier { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment1Level { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment2Tier { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment2Level { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment3Tier { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Equipment3Level { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterWeaponGrade { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterWeaponLevel { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterGearTier { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterGearLevel { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.MiniGameDefenseFixedStatExcel> CreateMiniGameDefenseFixedStatExcel(FlatBufferBuilder builder,
      long MinigameDefenseFixedStatId = 0,
      int Level = 0,
      int Grade = 0,
      int ExSkillLevel = 0,
      int NoneExSkillLevel = 0,
      int Equipment1Tier = 0,
      int Equipment1Level = 0,
      int Equipment2Tier = 0,
      int Equipment2Level = 0,
      int Equipment3Tier = 0,
      int Equipment3Level = 0,
      int CharacterWeaponGrade = 0,
      int CharacterWeaponLevel = 0,
      int CharacterGearTier = 0,
      int CharacterGearLevel = 0) {
    builder.StartTable(15);
    MiniGameDefenseFixedStatExcel.AddMinigameDefenseFixedStatId(builder, MinigameDefenseFixedStatId);
    MiniGameDefenseFixedStatExcel.AddCharacterGearLevel(builder, CharacterGearLevel);
    MiniGameDefenseFixedStatExcel.AddCharacterGearTier(builder, CharacterGearTier);
    MiniGameDefenseFixedStatExcel.AddCharacterWeaponLevel(builder, CharacterWeaponLevel);
    MiniGameDefenseFixedStatExcel.AddCharacterWeaponGrade(builder, CharacterWeaponGrade);
    MiniGameDefenseFixedStatExcel.AddEquipment3Level(builder, Equipment3Level);
    MiniGameDefenseFixedStatExcel.AddEquipment3Tier(builder, Equipment3Tier);
    MiniGameDefenseFixedStatExcel.AddEquipment2Level(builder, Equipment2Level);
    MiniGameDefenseFixedStatExcel.AddEquipment2Tier(builder, Equipment2Tier);
    MiniGameDefenseFixedStatExcel.AddEquipment1Level(builder, Equipment1Level);
    MiniGameDefenseFixedStatExcel.AddEquipment1Tier(builder, Equipment1Tier);
    MiniGameDefenseFixedStatExcel.AddNoneExSkillLevel(builder, NoneExSkillLevel);
    MiniGameDefenseFixedStatExcel.AddExSkillLevel(builder, ExSkillLevel);
    MiniGameDefenseFixedStatExcel.AddGrade(builder, Grade);
    MiniGameDefenseFixedStatExcel.AddLevel(builder, Level);
    return MiniGameDefenseFixedStatExcel.EndMiniGameDefenseFixedStatExcel(builder);
  }

  public static void StartMiniGameDefenseFixedStatExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddMinigameDefenseFixedStatId(FlatBufferBuilder builder, long MinigameDefenseFixedStatId) { builder.AddLong(0, MinigameDefenseFixedStatId, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, 0); }
  public static void AddGrade(FlatBufferBuilder builder, int Grade) { builder.AddInt(2, Grade, 0); }
  public static void AddExSkillLevel(FlatBufferBuilder builder, int ExSkillLevel) { builder.AddInt(3, ExSkillLevel, 0); }
  public static void AddNoneExSkillLevel(FlatBufferBuilder builder, int NoneExSkillLevel) { builder.AddInt(4, NoneExSkillLevel, 0); }
  public static void AddEquipment1Tier(FlatBufferBuilder builder, int Equipment1Tier) { builder.AddInt(5, Equipment1Tier, 0); }
  public static void AddEquipment1Level(FlatBufferBuilder builder, int Equipment1Level) { builder.AddInt(6, Equipment1Level, 0); }
  public static void AddEquipment2Tier(FlatBufferBuilder builder, int Equipment2Tier) { builder.AddInt(7, Equipment2Tier, 0); }
  public static void AddEquipment2Level(FlatBufferBuilder builder, int Equipment2Level) { builder.AddInt(8, Equipment2Level, 0); }
  public static void AddEquipment3Tier(FlatBufferBuilder builder, int Equipment3Tier) { builder.AddInt(9, Equipment3Tier, 0); }
  public static void AddEquipment3Level(FlatBufferBuilder builder, int Equipment3Level) { builder.AddInt(10, Equipment3Level, 0); }
  public static void AddCharacterWeaponGrade(FlatBufferBuilder builder, int CharacterWeaponGrade) { builder.AddInt(11, CharacterWeaponGrade, 0); }
  public static void AddCharacterWeaponLevel(FlatBufferBuilder builder, int CharacterWeaponLevel) { builder.AddInt(12, CharacterWeaponLevel, 0); }
  public static void AddCharacterGearTier(FlatBufferBuilder builder, int CharacterGearTier) { builder.AddInt(13, CharacterGearTier, 0); }
  public static void AddCharacterGearLevel(FlatBufferBuilder builder, int CharacterGearLevel) { builder.AddInt(14, CharacterGearLevel, 0); }
  public static Offset<FlatDataGlobal.MiniGameDefenseFixedStatExcel> EndMiniGameDefenseFixedStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MiniGameDefenseFixedStatExcel>(o);
  }
}


}
