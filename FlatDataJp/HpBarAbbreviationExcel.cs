// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct HpBarAbbreviationExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static HpBarAbbreviationExcel GetRootAsHpBarAbbreviationExcel(ByteBuffer _bb) { return GetRootAsHpBarAbbreviationExcel(_bb, new HpBarAbbreviationExcel()); }
  public static HpBarAbbreviationExcel GetRootAsHpBarAbbreviationExcel(ByteBuffer _bb, HpBarAbbreviationExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HpBarAbbreviationExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int MonsterLv { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StandardHpBar { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RaidBossHpBar { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.HpBarAbbreviationExcel> CreateHpBarAbbreviationExcel(FlatBufferBuilder builder,
      int MonsterLv = 0,
      int StandardHpBar = 0,
      int RaidBossHpBar = 0) {
    builder.StartTable(3);
    HpBarAbbreviationExcel.AddRaidBossHpBar(builder, RaidBossHpBar);
    HpBarAbbreviationExcel.AddStandardHpBar(builder, StandardHpBar);
    HpBarAbbreviationExcel.AddMonsterLv(builder, MonsterLv);
    return HpBarAbbreviationExcel.EndHpBarAbbreviationExcel(builder);
  }

  public static void StartHpBarAbbreviationExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddMonsterLv(FlatBufferBuilder builder, int MonsterLv) { builder.AddInt(0, MonsterLv, 0); }
  public static void AddStandardHpBar(FlatBufferBuilder builder, int StandardHpBar) { builder.AddInt(1, StandardHpBar, 0); }
  public static void AddRaidBossHpBar(FlatBufferBuilder builder, int RaidBossHpBar) { builder.AddInt(2, RaidBossHpBar, 0); }
  public static Offset<FlatDataJp.HpBarAbbreviationExcel> EndHpBarAbbreviationExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.HpBarAbbreviationExcel>(o);
  }
}


}
