// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BattleLevelFactorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BattleLevelFactorExcel GetRootAsBattleLevelFactorExcel(ByteBuffer _bb) { return GetRootAsBattleLevelFactorExcel(_bb, new BattleLevelFactorExcel()); }
  public static BattleLevelFactorExcel GetRootAsBattleLevelFactorExcel(ByteBuffer _bb, BattleLevelFactorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BattleLevelFactorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int LevelDiff { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long DamageRate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.BattleLevelFactorExcel> CreateBattleLevelFactorExcel(FlatBufferBuilder builder,
      int LevelDiff = 0,
      long DamageRate = 0) {
    builder.StartTable(2);
    BattleLevelFactorExcel.AddDamageRate(builder, DamageRate);
    BattleLevelFactorExcel.AddLevelDiff(builder, LevelDiff);
    return BattleLevelFactorExcel.EndBattleLevelFactorExcel(builder);
  }

  public static void StartBattleLevelFactorExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLevelDiff(FlatBufferBuilder builder, int LevelDiff) { builder.AddInt(0, LevelDiff, 0); }
  public static void AddDamageRate(FlatBufferBuilder builder, long DamageRate) { builder.AddLong(1, DamageRate, 0); }
  public static Offset<FlatDataGlobal.BattleLevelFactorExcel> EndBattleLevelFactorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.BattleLevelFactorExcel>(o);
  }
}


}
