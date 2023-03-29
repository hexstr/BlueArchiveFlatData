// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GroundVector3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static GroundVector3 GetRootAsGroundVector3(ByteBuffer _bb) { return GetRootAsGroundVector3(_bb, new GroundVector3()); }
  public static GroundVector3 GetRootAsGroundVector3(ByteBuffer _bb, GroundVector3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundVector3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataJp.GroundVector3> CreateGroundVector3(FlatBufferBuilder builder,
      float X = 0.0f,
      float Y = 0.0f,
      float Z = 0.0f) {
    builder.StartTable(3);
    GroundVector3.AddZ(builder, Z);
    GroundVector3.AddY(builder, Y);
    GroundVector3.AddX(builder, X);
    return GroundVector3.EndGroundVector3(builder);
  }

  public static void StartGroundVector3(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX(FlatBufferBuilder builder, float X) { builder.AddFloat(0, X, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float Y) { builder.AddFloat(1, Y, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float Z) { builder.AddFloat(2, Z, 0.0f); }
  public static Offset<FlatDataJp.GroundVector3> EndGroundVector3(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.GroundVector3>(o);
  }
}


}
