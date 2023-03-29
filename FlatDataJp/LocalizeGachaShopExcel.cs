// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LocalizeGachaShopExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static LocalizeGachaShopExcel GetRootAsLocalizeGachaShopExcel(ByteBuffer _bb) { return GetRootAsLocalizeGachaShopExcel(_bb, new LocalizeGachaShopExcel()); }
  public static LocalizeGachaShopExcel GetRootAsLocalizeGachaShopExcel(ByteBuffer _bb, LocalizeGachaShopExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeGachaShopExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GachaShopId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string TabNameKr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTabNameKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTabNameKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTabNameKrArray() { return __p.__vector_as_array<byte>(6); }
  public string TabNameJp { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTabNameJpBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTabNameJpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTabNameJpArray() { return __p.__vector_as_array<byte>(8); }
  public string TitleNameKr { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleNameKrBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetTitleNameKrBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetTitleNameKrArray() { return __p.__vector_as_array<byte>(10); }
  public string TitleNameJp { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleNameJpBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTitleNameJpBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTitleNameJpArray() { return __p.__vector_as_array<byte>(12); }
  public string SubTitleKr { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubTitleKrBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSubTitleKrBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSubTitleKrArray() { return __p.__vector_as_array<byte>(14); }
  public string SubTitleJp { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubTitleJpBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetSubTitleJpBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetSubTitleJpArray() { return __p.__vector_as_array<byte>(16); }
  public string GachaDescriptionKr { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGachaDescriptionKrBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetGachaDescriptionKrBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetGachaDescriptionKrArray() { return __p.__vector_as_array<byte>(18); }
  public string GachaDescriptionJp { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGachaDescriptionJpBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetGachaDescriptionJpBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetGachaDescriptionJpArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<FlatDataJp.LocalizeGachaShopExcel> CreateLocalizeGachaShopExcel(FlatBufferBuilder builder,
      long GachaShopId = 0,
      StringOffset TabNameKrOffset = default(StringOffset),
      StringOffset TabNameJpOffset = default(StringOffset),
      StringOffset TitleNameKrOffset = default(StringOffset),
      StringOffset TitleNameJpOffset = default(StringOffset),
      StringOffset SubTitleKrOffset = default(StringOffset),
      StringOffset SubTitleJpOffset = default(StringOffset),
      StringOffset GachaDescriptionKrOffset = default(StringOffset),
      StringOffset GachaDescriptionJpOffset = default(StringOffset)) {
    builder.StartTable(9);
    LocalizeGachaShopExcel.AddGachaShopId(builder, GachaShopId);
    LocalizeGachaShopExcel.AddGachaDescriptionJp(builder, GachaDescriptionJpOffset);
    LocalizeGachaShopExcel.AddGachaDescriptionKr(builder, GachaDescriptionKrOffset);
    LocalizeGachaShopExcel.AddSubTitleJp(builder, SubTitleJpOffset);
    LocalizeGachaShopExcel.AddSubTitleKr(builder, SubTitleKrOffset);
    LocalizeGachaShopExcel.AddTitleNameJp(builder, TitleNameJpOffset);
    LocalizeGachaShopExcel.AddTitleNameKr(builder, TitleNameKrOffset);
    LocalizeGachaShopExcel.AddTabNameJp(builder, TabNameJpOffset);
    LocalizeGachaShopExcel.AddTabNameKr(builder, TabNameKrOffset);
    return LocalizeGachaShopExcel.EndLocalizeGachaShopExcel(builder);
  }

  public static void StartLocalizeGachaShopExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddGachaShopId(FlatBufferBuilder builder, long GachaShopId) { builder.AddLong(0, GachaShopId, 0); }
  public static void AddTabNameKr(FlatBufferBuilder builder, StringOffset TabNameKrOffset) { builder.AddOffset(1, TabNameKrOffset.Value, 0); }
  public static void AddTabNameJp(FlatBufferBuilder builder, StringOffset TabNameJpOffset) { builder.AddOffset(2, TabNameJpOffset.Value, 0); }
  public static void AddTitleNameKr(FlatBufferBuilder builder, StringOffset TitleNameKrOffset) { builder.AddOffset(3, TitleNameKrOffset.Value, 0); }
  public static void AddTitleNameJp(FlatBufferBuilder builder, StringOffset TitleNameJpOffset) { builder.AddOffset(4, TitleNameJpOffset.Value, 0); }
  public static void AddSubTitleKr(FlatBufferBuilder builder, StringOffset SubTitleKrOffset) { builder.AddOffset(5, SubTitleKrOffset.Value, 0); }
  public static void AddSubTitleJp(FlatBufferBuilder builder, StringOffset SubTitleJpOffset) { builder.AddOffset(6, SubTitleJpOffset.Value, 0); }
  public static void AddGachaDescriptionKr(FlatBufferBuilder builder, StringOffset GachaDescriptionKrOffset) { builder.AddOffset(7, GachaDescriptionKrOffset.Value, 0); }
  public static void AddGachaDescriptionJp(FlatBufferBuilder builder, StringOffset GachaDescriptionJpOffset) { builder.AddOffset(8, GachaDescriptionJpOffset.Value, 0); }
  public static Offset<FlatDataJp.LocalizeGachaShopExcel> EndLocalizeGachaShopExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.LocalizeGachaShopExcel>(o);
  }
}


}
