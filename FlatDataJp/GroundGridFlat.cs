// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GroundGridFlat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static GroundGridFlat GetRootAsGroundGridFlat(ByteBuffer _bb) { return GetRootAsGroundGridFlat(_bb, new GroundGridFlat()); }
  public static GroundGridFlat GetRootAsGroundGridFlat(ByteBuffer _bb, GroundGridFlat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundGridFlat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float StartX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float StartY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Gap { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public FlatDataJp.GroundNodeFlat? Nodes(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.GroundNodeFlat?)(new FlatDataJp.GroundNodeFlat()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int NodesLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Version { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVersionBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetVersionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetVersionArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatDataJp.GroundGridFlat> CreateGroundGridFlat(FlatBufferBuilder builder,
      int X = 0,
      int Y = 0,
      float StartX = 0.0f,
      float StartY = 0.0f,
      float Gap = 0.0f,
      VectorOffset NodesOffset = default(VectorOffset),
      StringOffset VersionOffset = default(StringOffset)) {
    builder.StartTable(7);
    GroundGridFlat.AddVersion(builder, VersionOffset);
    GroundGridFlat.AddNodes(builder, NodesOffset);
    GroundGridFlat.AddGap(builder, Gap);
    GroundGridFlat.AddStartY(builder, StartY);
    GroundGridFlat.AddStartX(builder, StartX);
    GroundGridFlat.AddY(builder, Y);
    GroundGridFlat.AddX(builder, X);
    return GroundGridFlat.EndGroundGridFlat(builder);
  }

  public static void StartGroundGridFlat(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddX(FlatBufferBuilder builder, int X) { builder.AddInt(0, X, 0); }
  public static void AddY(FlatBufferBuilder builder, int Y) { builder.AddInt(1, Y, 0); }
  public static void AddStartX(FlatBufferBuilder builder, float StartX) { builder.AddFloat(2, StartX, 0.0f); }
  public static void AddStartY(FlatBufferBuilder builder, float StartY) { builder.AddFloat(3, StartY, 0.0f); }
  public static void AddGap(FlatBufferBuilder builder, float Gap) { builder.AddFloat(4, Gap, 0.0f); }
  public static void AddNodes(FlatBufferBuilder builder, VectorOffset NodesOffset) { builder.AddOffset(5, NodesOffset.Value, 0); }
  public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<FlatDataJp.GroundNodeFlat>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.GroundNodeFlat>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.GroundNodeFlat>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.GroundNodeFlat>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNodesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVersion(FlatBufferBuilder builder, StringOffset VersionOffset) { builder.AddOffset(6, VersionOffset.Value, 0); }
  public static Offset<FlatDataJp.GroundGridFlat> EndGroundGridFlat(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.GroundGridFlat>(o);
  }
}


}
