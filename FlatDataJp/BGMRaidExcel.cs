// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BGMRaidExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BGMRaidExcel GetRootAsBGMRaidExcel(ByteBuffer _bb) { return GetRootAsBGMRaidExcel(_bb, new BGMRaidExcel()); }
  public static BGMRaidExcel GetRootAsBGMRaidExcel(ByteBuffer _bb, BGMRaidExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMRaidExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PhaseIndex { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BGMId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.BGMRaidExcel> CreateBGMRaidExcel(FlatBufferBuilder builder,
      long StageId = 0,
      long PhaseIndex = 0,
      long BGMId = 0) {
    builder.StartTable(3);
    BGMRaidExcel.AddBGMId(builder, BGMId);
    BGMRaidExcel.AddPhaseIndex(builder, PhaseIndex);
    BGMRaidExcel.AddStageId(builder, StageId);
    return BGMRaidExcel.EndBGMRaidExcel(builder);
  }

  public static void StartBGMRaidExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddStageId(FlatBufferBuilder builder, long StageId) { builder.AddLong(0, StageId, 0); }
  public static void AddPhaseIndex(FlatBufferBuilder builder, long PhaseIndex) { builder.AddLong(1, PhaseIndex, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(2, BGMId, 0); }
  public static Offset<FlatDataJp.BGMRaidExcel> EndBGMRaidExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.BGMRaidExcel>(o);
  }
}


}
