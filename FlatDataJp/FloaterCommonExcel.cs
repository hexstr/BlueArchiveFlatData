// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FloaterCommonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FloaterCommonExcel GetRootAsFloaterCommonExcel(ByteBuffer _bb) { return GetRootAsFloaterCommonExcel(_bb, new FloaterCommonExcel()); }
  public static FloaterCommonExcel GetRootAsFloaterCommonExcel(ByteBuffer _bb, FloaterCommonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FloaterCommonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticEntityType.None; } }
  public int FloaterOffsetPosX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterOffsetPosY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterRandomPosRangeX { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterRandomPosRangeY { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.FloaterCommonExcel> CreateFloaterCommonExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.TacticEntityType tacticEntityType = FlatDataJp.TacticEntityType.None,
      int FloaterOffsetPosX = 0,
      int FloaterOffsetPosY = 0,
      int FloaterRandomPosRangeX = 0,
      int FloaterRandomPosRangeY = 0) {
    builder.StartTable(6);
    FloaterCommonExcel.AddId(builder, Id);
    FloaterCommonExcel.AddFloaterRandomPosRangeY(builder, FloaterRandomPosRangeY);
    FloaterCommonExcel.AddFloaterRandomPosRangeX(builder, FloaterRandomPosRangeX);
    FloaterCommonExcel.AddFloaterOffsetPosY(builder, FloaterOffsetPosY);
    FloaterCommonExcel.AddFloaterOffsetPosX(builder, FloaterOffsetPosX);
    FloaterCommonExcel.AddTacticEntityType(builder, tacticEntityType);
    return FloaterCommonExcel.EndFloaterCommonExcel(builder);
  }

  public static void StartFloaterCommonExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, FlatDataJp.TacticEntityType tacticEntityType) { builder.AddInt(1, (int)tacticEntityType, 0); }
  public static void AddFloaterOffsetPosX(FlatBufferBuilder builder, int FloaterOffsetPosX) { builder.AddInt(2, FloaterOffsetPosX, 0); }
  public static void AddFloaterOffsetPosY(FlatBufferBuilder builder, int FloaterOffsetPosY) { builder.AddInt(3, FloaterOffsetPosY, 0); }
  public static void AddFloaterRandomPosRangeX(FlatBufferBuilder builder, int FloaterRandomPosRangeX) { builder.AddInt(4, FloaterRandomPosRangeX, 0); }
  public static void AddFloaterRandomPosRangeY(FlatBufferBuilder builder, int FloaterRandomPosRangeY) { builder.AddInt(5, FloaterRandomPosRangeY, 0); }
  public static Offset<FlatDataJp.FloaterCommonExcel> EndFloaterCommonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.FloaterCommonExcel>(o);
  }
}


}
