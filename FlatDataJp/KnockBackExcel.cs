// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KnockBackExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static KnockBackExcel GetRootAsKnockBackExcel(ByteBuffer _bb) { return GetRootAsKnockBackExcel(_bb, new KnockBackExcel()); }
  public static KnockBackExcel GetRootAsKnockBackExcel(ByteBuffer _bb, KnockBackExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KnockBackExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float Dist { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Speed { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataJp.KnockBackExcel> CreateKnockBackExcel(FlatBufferBuilder builder,
      long Index = 0,
      float Dist = 0.0f,
      float Speed = 0.0f) {
    builder.StartTable(3);
    KnockBackExcel.AddIndex(builder, Index);
    KnockBackExcel.AddSpeed(builder, Speed);
    KnockBackExcel.AddDist(builder, Dist);
    return KnockBackExcel.EndKnockBackExcel(builder);
  }

  public static void StartKnockBackExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddIndex(FlatBufferBuilder builder, long Index) { builder.AddLong(0, Index, 0); }
  public static void AddDist(FlatBufferBuilder builder, float Dist) { builder.AddFloat(1, Dist, 0.0f); }
  public static void AddSpeed(FlatBufferBuilder builder, float Speed) { builder.AddFloat(2, Speed, 0.0f); }
  public static Offset<FlatDataJp.KnockBackExcel> EndKnockBackExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.KnockBackExcel>(o);
  }
}


}
