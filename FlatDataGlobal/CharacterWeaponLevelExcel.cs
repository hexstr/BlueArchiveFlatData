// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterWeaponLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterWeaponLevelExcel GetRootAsCharacterWeaponLevelExcel(ByteBuffer _bb) { return GetRootAsCharacterWeaponLevelExcel(_bb, new CharacterWeaponLevelExcel()); }
  public static CharacterWeaponLevelExcel GetRootAsCharacterWeaponLevelExcel(ByteBuffer _bb, CharacterWeaponLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterWeaponLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Exp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TotalExp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.CharacterWeaponLevelExcel> CreateCharacterWeaponLevelExcel(FlatBufferBuilder builder,
      int Level = 0,
      long Exp = 0,
      long TotalExp = 0) {
    builder.StartTable(3);
    CharacterWeaponLevelExcel.AddTotalExp(builder, TotalExp);
    CharacterWeaponLevelExcel.AddExp(builder, Exp);
    CharacterWeaponLevelExcel.AddLevel(builder, Level);
    return CharacterWeaponLevelExcel.EndCharacterWeaponLevelExcel(builder);
  }

  public static void StartCharacterWeaponLevelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(0, Level, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, 0); }
  public static void AddTotalExp(FlatBufferBuilder builder, long TotalExp) { builder.AddLong(2, TotalExp, 0); }
  public static Offset<FlatDataGlobal.CharacterWeaponLevelExcel> EndCharacterWeaponLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterWeaponLevelExcel>(o);
  }
}


}
