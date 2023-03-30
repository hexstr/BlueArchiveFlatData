// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterWeaponExpBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterWeaponExpBonusExcel GetRootAsCharacterWeaponExpBonusExcel(ByteBuffer _bb) { return GetRootAsCharacterWeaponExpBonusExcel(_bb, new CharacterWeaponExpBonusExcel()); }
  public static CharacterWeaponExpBonusExcel GetRootAsCharacterWeaponExpBonusExcel(ByteBuffer _bb, CharacterWeaponExpBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterWeaponExpBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.WeaponType Weapontype { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.WeaponType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.WeaponType.None; } }
  public int WeaponExpGrowthA { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthB { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthC { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthZ { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.CharacterWeaponExpBonusExcel> CreateCharacterWeaponExpBonusExcel(FlatBufferBuilder builder,
      FlatDataGlobal.WeaponType weapontype = FlatDataGlobal.WeaponType.None,
      int WeaponExpGrowthA = 0,
      int WeaponExpGrowthB = 0,
      int WeaponExpGrowthC = 0,
      int WeaponExpGrowthZ = 0) {
    builder.StartTable(5);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthZ(builder, WeaponExpGrowthZ);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthC(builder, WeaponExpGrowthC);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthB(builder, WeaponExpGrowthB);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthA(builder, WeaponExpGrowthA);
    CharacterWeaponExpBonusExcel.AddWeapontype(builder, weapontype);
    return CharacterWeaponExpBonusExcel.EndCharacterWeaponExpBonusExcel(builder);
  }

  public static void StartCharacterWeaponExpBonusExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddWeapontype(FlatBufferBuilder builder, FlatDataGlobal.WeaponType weapontype) { builder.AddInt(0, (int)weapontype, 0); }
  public static void AddWeaponExpGrowthA(FlatBufferBuilder builder, int WeaponExpGrowthA) { builder.AddInt(1, WeaponExpGrowthA, 0); }
  public static void AddWeaponExpGrowthB(FlatBufferBuilder builder, int WeaponExpGrowthB) { builder.AddInt(2, WeaponExpGrowthB, 0); }
  public static void AddWeaponExpGrowthC(FlatBufferBuilder builder, int WeaponExpGrowthC) { builder.AddInt(3, WeaponExpGrowthC, 0); }
  public static void AddWeaponExpGrowthZ(FlatBufferBuilder builder, int WeaponExpGrowthZ) { builder.AddInt(4, WeaponExpGrowthZ, 0); }
  public static Offset<FlatDataGlobal.CharacterWeaponExpBonusExcel> EndCharacterWeaponExpBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterWeaponExpBonusExcel>(o);
  }
}


}
