// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LocalizeEtcExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static LocalizeEtcExcel GetRootAsLocalizeEtcExcel(ByteBuffer _bb) { return GetRootAsLocalizeEtcExcel(_bb, new LocalizeEtcExcel()); }
  public static LocalizeEtcExcel GetRootAsLocalizeEtcExcel(ByteBuffer _bb, LocalizeEtcExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeEtcExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string NameKr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameKrArray() { return __p.__vector_as_array<byte>(6); }
  public string DescriptionKr { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionKrBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionKrBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionKrArray() { return __p.__vector_as_array<byte>(8); }
  public string NameJp { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameJpBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNameJpBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNameJpArray() { return __p.__vector_as_array<byte>(10); }
  public string DescriptionJp { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionJpBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDescriptionJpBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDescriptionJpArray() { return __p.__vector_as_array<byte>(12); }
  public string NameTh { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameThBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetNameThBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetNameThArray() { return __p.__vector_as_array<byte>(14); }
  public string DescriptionTh { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionThBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetDescriptionThBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetDescriptionThArray() { return __p.__vector_as_array<byte>(16); }
  public string NameTw { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameTwBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetNameTwBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetNameTwArray() { return __p.__vector_as_array<byte>(18); }
  public string DescriptionTw { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionTwBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetDescriptionTwBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetDescriptionTwArray() { return __p.__vector_as_array<byte>(20); }
  public string NameEn { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameEnBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetNameEnBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetNameEnArray() { return __p.__vector_as_array<byte>(22); }
  public string DescriptionEn { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionEnBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetDescriptionEnBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetDescriptionEnArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<FlatDataGlobal.LocalizeEtcExcel> CreateLocalizeEtcExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset NameKrOffset = default(StringOffset),
      StringOffset DescriptionKrOffset = default(StringOffset),
      StringOffset NameJpOffset = default(StringOffset),
      StringOffset DescriptionJpOffset = default(StringOffset),
      StringOffset NameThOffset = default(StringOffset),
      StringOffset DescriptionThOffset = default(StringOffset),
      StringOffset NameTwOffset = default(StringOffset),
      StringOffset DescriptionTwOffset = default(StringOffset),
      StringOffset NameEnOffset = default(StringOffset),
      StringOffset DescriptionEnOffset = default(StringOffset)) {
    builder.StartTable(11);
    LocalizeEtcExcel.AddDescriptionEn(builder, DescriptionEnOffset);
    LocalizeEtcExcel.AddNameEn(builder, NameEnOffset);
    LocalizeEtcExcel.AddDescriptionTw(builder, DescriptionTwOffset);
    LocalizeEtcExcel.AddNameTw(builder, NameTwOffset);
    LocalizeEtcExcel.AddDescriptionTh(builder, DescriptionThOffset);
    LocalizeEtcExcel.AddNameTh(builder, NameThOffset);
    LocalizeEtcExcel.AddDescriptionJp(builder, DescriptionJpOffset);
    LocalizeEtcExcel.AddNameJp(builder, NameJpOffset);
    LocalizeEtcExcel.AddDescriptionKr(builder, DescriptionKrOffset);
    LocalizeEtcExcel.AddNameKr(builder, NameKrOffset);
    LocalizeEtcExcel.AddKey(builder, Key);
    return LocalizeEtcExcel.EndLocalizeEtcExcel(builder);
  }

  public static void StartLocalizeEtcExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddKey(FlatBufferBuilder builder, uint Key) { builder.AddUint(0, Key, 0); }
  public static void AddNameKr(FlatBufferBuilder builder, StringOffset NameKrOffset) { builder.AddOffset(1, NameKrOffset.Value, 0); }
  public static void AddDescriptionKr(FlatBufferBuilder builder, StringOffset DescriptionKrOffset) { builder.AddOffset(2, DescriptionKrOffset.Value, 0); }
  public static void AddNameJp(FlatBufferBuilder builder, StringOffset NameJpOffset) { builder.AddOffset(3, NameJpOffset.Value, 0); }
  public static void AddDescriptionJp(FlatBufferBuilder builder, StringOffset DescriptionJpOffset) { builder.AddOffset(4, DescriptionJpOffset.Value, 0); }
  public static void AddNameTh(FlatBufferBuilder builder, StringOffset NameThOffset) { builder.AddOffset(5, NameThOffset.Value, 0); }
  public static void AddDescriptionTh(FlatBufferBuilder builder, StringOffset DescriptionThOffset) { builder.AddOffset(6, DescriptionThOffset.Value, 0); }
  public static void AddNameTw(FlatBufferBuilder builder, StringOffset NameTwOffset) { builder.AddOffset(7, NameTwOffset.Value, 0); }
  public static void AddDescriptionTw(FlatBufferBuilder builder, StringOffset DescriptionTwOffset) { builder.AddOffset(8, DescriptionTwOffset.Value, 0); }
  public static void AddNameEn(FlatBufferBuilder builder, StringOffset NameEnOffset) { builder.AddOffset(9, NameEnOffset.Value, 0); }
  public static void AddDescriptionEn(FlatBufferBuilder builder, StringOffset DescriptionEnOffset) { builder.AddOffset(10, DescriptionEnOffset.Value, 0); }
  public static Offset<FlatDataGlobal.LocalizeEtcExcel> EndLocalizeEtcExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.LocalizeEtcExcel>(o);
  }
}


}
