// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterLevelExcel GetRootAsCharacterLevelExcel(ByteBuffer _bb) { return GetRootAsCharacterLevelExcel(_bb, new CharacterLevelExcel()); }
  public static CharacterLevelExcel GetRootAsCharacterLevelExcel(ByteBuffer _bb, CharacterLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Exp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TotalExp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.CharacterLevelExcel> CreateCharacterLevelExcel(FlatBufferBuilder builder,
      int Level = 0,
      long Exp = 0,
      long TotalExp = 0) {
    builder.StartTable(3);
    CharacterLevelExcel.AddTotalExp(builder, TotalExp);
    CharacterLevelExcel.AddExp(builder, Exp);
    CharacterLevelExcel.AddLevel(builder, Level);
    return CharacterLevelExcel.EndCharacterLevelExcel(builder);
  }

  public static void StartCharacterLevelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(0, Level, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, 0); }
  public static void AddTotalExp(FlatBufferBuilder builder, long TotalExp) { builder.AddLong(2, TotalExp, 0); }
  public static Offset<FlatDataJp.CharacterLevelExcel> EndCharacterLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterLevelExcel>(o);
  }
}


}
