// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldKeywordExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FieldKeywordExcel GetRootAsFieldKeywordExcel(ByteBuffer _bb) { return GetRootAsFieldKeywordExcel(_bb, new FieldKeywordExcel()); }
  public static FieldKeywordExcel GetRootAsFieldKeywordExcel(ByteBuffer _bb, FieldKeywordExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldKeywordExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string NameLocalizeKey { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameLocalizeKeyBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameLocalizeKeyBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameLocalizeKeyArray() { return __p.__vector_as_array<byte>(6); }
  public string DescriptionLocalizeKey { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionLocalizeKeyBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionLocalizeKeyBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionLocalizeKeyArray() { return __p.__vector_as_array<byte>(8); }
  public string ImagePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<FlatDataGlobal.FieldKeywordExcel> CreateFieldKeywordExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset NameLocalizeKeyOffset = default(StringOffset),
      StringOffset DescriptionLocalizeKeyOffset = default(StringOffset),
      StringOffset ImagePathOffset = default(StringOffset)) {
    builder.StartTable(4);
    FieldKeywordExcel.AddUniqueId(builder, UniqueId);
    FieldKeywordExcel.AddImagePath(builder, ImagePathOffset);
    FieldKeywordExcel.AddDescriptionLocalizeKey(builder, DescriptionLocalizeKeyOffset);
    FieldKeywordExcel.AddNameLocalizeKey(builder, NameLocalizeKeyOffset);
    return FieldKeywordExcel.EndFieldKeywordExcel(builder);
  }

  public static void StartFieldKeywordExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddNameLocalizeKey(FlatBufferBuilder builder, StringOffset NameLocalizeKeyOffset) { builder.AddOffset(1, NameLocalizeKeyOffset.Value, 0); }
  public static void AddDescriptionLocalizeKey(FlatBufferBuilder builder, StringOffset DescriptionLocalizeKeyOffset) { builder.AddOffset(2, DescriptionLocalizeKeyOffset.Value, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset ImagePathOffset) { builder.AddOffset(3, ImagePathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.FieldKeywordExcel> EndFieldKeywordExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.FieldKeywordExcel>(o);
  }
}


}
