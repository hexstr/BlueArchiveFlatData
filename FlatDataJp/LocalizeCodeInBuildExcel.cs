// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LocalizeCodeInBuildExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static LocalizeCodeInBuildExcel GetRootAsLocalizeCodeInBuildExcel(ByteBuffer _bb) { return GetRootAsLocalizeCodeInBuildExcel(_bb, new LocalizeCodeInBuildExcel()); }
  public static LocalizeCodeInBuildExcel GetRootAsLocalizeCodeInBuildExcel(ByteBuffer _bb, LocalizeCodeInBuildExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeCodeInBuildExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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

  public static Offset<FlatDataJp.LocalizeCodeInBuildExcel> CreateLocalizeCodeInBuildExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset KrOffset = default(StringOffset),
      StringOffset JpOffset = default(StringOffset)) {
    builder.StartTable(3);
    LocalizeCodeInBuildExcel.AddJp(builder, JpOffset);
    LocalizeCodeInBuildExcel.AddKr(builder, KrOffset);
    LocalizeCodeInBuildExcel.AddKey(builder, Key);
    return LocalizeCodeInBuildExcel.EndLocalizeCodeInBuildExcel(builder);
  }

  public static void StartLocalizeCodeInBuildExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddKey(FlatBufferBuilder builder, uint Key) { builder.AddUint(0, Key, 0); }
  public static void AddKr(FlatBufferBuilder builder, StringOffset KrOffset) { builder.AddOffset(1, KrOffset.Value, 0); }
  public static void AddJp(FlatBufferBuilder builder, StringOffset JpOffset) { builder.AddOffset(2, JpOffset.Value, 0); }
  public static Offset<FlatDataJp.LocalizeCodeInBuildExcel> EndLocalizeCodeInBuildExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.LocalizeCodeInBuildExcel>(o);
  }
}


}
