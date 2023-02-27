// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LoadingImageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static LoadingImageExcel GetRootAsLoadingImageExcel(ByteBuffer _bb) { return GetRootAsLoadingImageExcel(_bb, new LoadingImageExcel()); }
  public static LoadingImageExcel GetRootAsLoadingImageExcel(ByteBuffer _bb, LoadingImageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LoadingImageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ImagePathKr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetImagePathKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetImagePathKrArray() { return __p.__vector_as_array<byte>(6); }
  public string ImagePathJp { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathJpBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetImagePathJpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetImagePathJpArray() { return __p.__vector_as_array<byte>(8); }
  public int DisplayWeight { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.LoadingImageExcel> CreateLoadingImageExcel(FlatBufferBuilder builder,
      long ID = 0,
      StringOffset ImagePathKrOffset = default(StringOffset),
      StringOffset ImagePathJpOffset = default(StringOffset),
      int DisplayWeight = 0) {
    builder.StartTable(4);
    LoadingImageExcel.AddID(builder, ID);
    LoadingImageExcel.AddDisplayWeight(builder, DisplayWeight);
    LoadingImageExcel.AddImagePathJp(builder, ImagePathJpOffset);
    LoadingImageExcel.AddImagePathKr(builder, ImagePathKrOffset);
    return LoadingImageExcel.EndLoadingImageExcel(builder);
  }

  public static void StartLoadingImageExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddID(FlatBufferBuilder builder, long ID) { builder.AddLong(0, ID, 0); }
  public static void AddImagePathKr(FlatBufferBuilder builder, StringOffset ImagePathKrOffset) { builder.AddOffset(1, ImagePathKrOffset.Value, 0); }
  public static void AddImagePathJp(FlatBufferBuilder builder, StringOffset ImagePathJpOffset) { builder.AddOffset(2, ImagePathJpOffset.Value, 0); }
  public static void AddDisplayWeight(FlatBufferBuilder builder, int DisplayWeight) { builder.AddInt(3, DisplayWeight, 0); }
  public static Offset<FlatDataJp.LoadingImageExcel> EndLoadingImageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.LoadingImageExcel>(o);
  }
}


}
