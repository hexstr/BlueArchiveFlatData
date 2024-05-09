// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatsTransExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterStatsTransExcel GetRootAsCharacterStatsTransExcel(ByteBuffer _bb) { return GetRootAsCharacterStatsTransExcel(_bb, new CharacterStatsTransExcel()); }
  public static CharacterStatsTransExcel GetRootAsCharacterStatsTransExcel(ByteBuffer _bb, CharacterStatsTransExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatsTransExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.StatType TransSupportStats { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.StatType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StatType.None; } }
  public int TransSupportStatsFactor { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.StatTransType StatTransType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.StatTransType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StatTransType.SpecialTransStat; } }

  public static Offset<FlatDataGlobal.CharacterStatsTransExcel> CreateCharacterStatsTransExcel(FlatBufferBuilder builder,
      FlatDataGlobal.StatType TransSupportStats = FlatDataGlobal.StatType.None,
      int TransSupportStatsFactor = 0,
      FlatDataGlobal.StatTransType statTransType = FlatDataGlobal.StatTransType.SpecialTransStat) {
    builder.StartTable(3);
    CharacterStatsTransExcel.AddStatTransType(builder, statTransType);
    CharacterStatsTransExcel.AddTransSupportStatsFactor(builder, TransSupportStatsFactor);
    CharacterStatsTransExcel.AddTransSupportStats(builder, TransSupportStats);
    return CharacterStatsTransExcel.EndCharacterStatsTransExcel(builder);
  }

  public static void StartCharacterStatsTransExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddTransSupportStats(FlatBufferBuilder builder, FlatDataGlobal.StatType TransSupportStats) { builder.AddInt(0, (int)TransSupportStats, 0); }
  public static void AddTransSupportStatsFactor(FlatBufferBuilder builder, int TransSupportStatsFactor) { builder.AddInt(1, TransSupportStatsFactor, 0); }
  public static void AddStatTransType(FlatBufferBuilder builder, FlatDataGlobal.StatTransType statTransType) { builder.AddInt(2, (int)statTransType, 0); }
  public static Offset<FlatDataGlobal.CharacterStatsTransExcel> EndCharacterStatsTransExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterStatsTransExcel>(o);
  }
}


}
