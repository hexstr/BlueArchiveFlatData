// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AnimatorData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static AnimatorData GetRootAsAnimatorData(ByteBuffer _bb) { return GetRootAsAnimatorData(_bb, new AnimatorData()); }
  public static AnimatorData GetRootAsAnimatorData(ByteBuffer _bb, AnimatorData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimatorData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DefaultStateName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefaultStateNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDefaultStateNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDefaultStateNameArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public FlatDataJp.AniStateData? DataList(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.AniStateData?)(new FlatDataJp.AniStateData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.AnimatorData> CreateAnimatorData(FlatBufferBuilder builder,
      StringOffset DefaultStateNameOffset = default(StringOffset),
      StringOffset NameOffset = default(StringOffset),
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(3);
    AnimatorData.AddDataList(builder, DataListOffset);
    AnimatorData.AddName(builder, NameOffset);
    AnimatorData.AddDefaultStateName(builder, DefaultStateNameOffset);
    return AnimatorData.EndAnimatorData(builder);
  }

  public static void StartAnimatorData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddDefaultStateName(FlatBufferBuilder builder, StringOffset DefaultStateNameOffset) { builder.AddOffset(0, DefaultStateNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset DataListOffset) { builder.AddOffset(2, DataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatDataJp.AniStateData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.AniStateData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.AniStateData>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.AniStateData>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.AnimatorData> EndAnimatorData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.AnimatorData>(o);
  }
}


}
