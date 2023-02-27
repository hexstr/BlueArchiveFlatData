// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LocalizeScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static LocalizeScenarioExcel GetRootAsLocalizeScenarioExcel(ByteBuffer _bb) { return GetRootAsLocalizeScenarioExcel(_bb, new LocalizeScenarioExcel()); }
  public static LocalizeScenarioExcel GetRootAsLocalizeScenarioExcel(ByteBuffer _bb, LocalizeScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Kr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKrArray() { return __p.__vector_as_array<byte>(6); }
  public string Jp { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetJpBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetJpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetJpArray() { return __p.__vector_as_array<byte>(8); }
  public string Th { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetThBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetThArray() { return __p.__vector_as_array<byte>(10); }
  public string Tw { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTwBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTwBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTwArray() { return __p.__vector_as_array<byte>(12); }
  public string En { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetEnBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetEnArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatDataGlobal.LocalizeScenarioExcel> CreateLocalizeScenarioExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset KrOffset = default(StringOffset),
      StringOffset JpOffset = default(StringOffset),
      StringOffset ThOffset = default(StringOffset),
      StringOffset TwOffset = default(StringOffset),
      StringOffset EnOffset = default(StringOffset)) {
    builder.StartTable(6);
    LocalizeScenarioExcel.AddEn(builder, EnOffset);
    LocalizeScenarioExcel.AddTw(builder, TwOffset);
    LocalizeScenarioExcel.AddTh(builder, ThOffset);
    LocalizeScenarioExcel.AddJp(builder, JpOffset);
    LocalizeScenarioExcel.AddKr(builder, KrOffset);
    LocalizeScenarioExcel.AddKey(builder, Key);
    return LocalizeScenarioExcel.EndLocalizeScenarioExcel(builder);
  }

  public static void StartLocalizeScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddKey(FlatBufferBuilder builder, uint Key) { builder.AddUint(0, Key, 0); }
  public static void AddKr(FlatBufferBuilder builder, StringOffset KrOffset) { builder.AddOffset(1, KrOffset.Value, 0); }
  public static void AddJp(FlatBufferBuilder builder, StringOffset JpOffset) { builder.AddOffset(2, JpOffset.Value, 0); }
  public static void AddTh(FlatBufferBuilder builder, StringOffset ThOffset) { builder.AddOffset(3, ThOffset.Value, 0); }
  public static void AddTw(FlatBufferBuilder builder, StringOffset TwOffset) { builder.AddOffset(4, TwOffset.Value, 0); }
  public static void AddEn(FlatBufferBuilder builder, StringOffset EnOffset) { builder.AddOffset(5, EnOffset.Value, 0); }
  public static Offset<FlatDataGlobal.LocalizeScenarioExcel> EndLocalizeScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.LocalizeScenarioExcel>(o);
  }
}


}
