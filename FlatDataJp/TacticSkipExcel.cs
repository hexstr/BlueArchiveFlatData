// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticSkipExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TacticSkipExcel GetRootAsTacticSkipExcel(ByteBuffer _bb) { return GetRootAsTacticSkipExcel(_bb, new TacticSkipExcel()); }
  public static TacticSkipExcel GetRootAsTacticSkipExcel(ByteBuffer _bb, TacticSkipExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticSkipExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int LevelDiff { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long HPResult { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.TacticSkipExcel> CreateTacticSkipExcel(FlatBufferBuilder builder,
      int LevelDiff = 0,
      long HPResult = 0) {
    builder.StartTable(2);
    TacticSkipExcel.AddHPResult(builder, HPResult);
    TacticSkipExcel.AddLevelDiff(builder, LevelDiff);
    return TacticSkipExcel.EndTacticSkipExcel(builder);
  }

  public static void StartTacticSkipExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLevelDiff(FlatBufferBuilder builder, int LevelDiff) { builder.AddInt(0, LevelDiff, 0); }
  public static void AddHPResult(FlatBufferBuilder builder, long HPResult) { builder.AddLong(1, HPResult, 0); }
  public static Offset<FlatDataJp.TacticSkipExcel> EndTacticSkipExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.TacticSkipExcel>(o);
  }
}


}
