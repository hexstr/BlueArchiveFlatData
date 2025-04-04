// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Motion : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static Motion GetRootAsMotion(ByteBuffer _bb) { return GetRootAsMotion(_bb, new Motion()); }
  public static Motion GetRootAsMotion(ByteBuffer _bb, Motion obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Motion __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public FlatDataJp.Position? Positions(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.Position?)(new FlatDataJp.Position()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PositionsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.Motion> CreateMotion(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      VectorOffset PositionsOffset = default(VectorOffset)) {
    builder.StartTable(2);
    Motion.AddPositions(builder, PositionsOffset);
    Motion.AddName(builder, NameOffset);
    return Motion.EndMotion(builder);
  }

  public static void StartMotion(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(0, NameOffset.Value, 0); }
  public static void AddPositions(FlatBufferBuilder builder, VectorOffset PositionsOffset) { builder.AddOffset(1, PositionsOffset.Value, 0); }
  public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<FlatDataJp.Position>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.Position>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.Position>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.Position>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPositionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.Motion> EndMotion(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.Motion>(o);
  }
}


}
