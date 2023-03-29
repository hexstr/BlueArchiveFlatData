// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BlendData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BlendData GetRootAsBlendData(ByteBuffer _bb) { return GetRootAsBlendData(_bb, new BlendData()); }
  public static BlendData GetRootAsBlendData(ByteBuffer _bb, BlendData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BlendData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Type { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.BlendInfo? InfoList(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.BlendInfo?)(new FlatDataJp.BlendInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int InfoListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.BlendData> CreateBlendData(FlatBufferBuilder builder,
      int Type = 0,
      VectorOffset InfoListOffset = default(VectorOffset)) {
    builder.StartTable(2);
    BlendData.AddInfoList(builder, InfoListOffset);
    BlendData.AddType(builder, Type);
    return BlendData.EndBlendData(builder);
  }

  public static void StartBlendData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(0, Type, 0); }
  public static void AddInfoList(FlatBufferBuilder builder, VectorOffset InfoListOffset) { builder.AddOffset(1, InfoListOffset.Value, 0); }
  public static VectorOffset CreateInfoListVector(FlatBufferBuilder builder, Offset<FlatDataJp.BlendInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateInfoListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.BlendInfo>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInfoListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.BlendInfo>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInfoListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.BlendInfo>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInfoListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.BlendData> EndBlendData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.BlendData>(o);
  }
}


}
