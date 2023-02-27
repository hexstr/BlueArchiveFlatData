// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BuffParticleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static BuffParticleExcel GetRootAsBuffParticleExcel(ByteBuffer _bb) { return GetRootAsBuffParticleExcel(_bb, new BuffParticleExcel()); }
  public static BuffParticleExcel GetRootAsBuffParticleExcel(ByteBuffer _bb, BuffParticleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BuffParticleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string UniqueName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUniqueNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetUniqueNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetUniqueNameArray() { return __p.__vector_as_array<byte>(6); }
  public string BuffType { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffTypeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBuffTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBuffTypeArray() { return __p.__vector_as_array<byte>(8); }
  public string BuffName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetBuffNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetBuffNameArray() { return __p.__vector_as_array<byte>(10); }
  public string ResourcePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourcePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetResourcePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetResourcePathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataJp.BuffParticleExcel> CreateBuffParticleExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset UniqueNameOffset = default(StringOffset),
      StringOffset BuffTypeOffset = default(StringOffset),
      StringOffset BuffNameOffset = default(StringOffset),
      StringOffset ResourcePathOffset = default(StringOffset)) {
    builder.StartTable(5);
    BuffParticleExcel.AddUniqueId(builder, UniqueId);
    BuffParticleExcel.AddResourcePath(builder, ResourcePathOffset);
    BuffParticleExcel.AddBuffName(builder, BuffNameOffset);
    BuffParticleExcel.AddBuffType(builder, BuffTypeOffset);
    BuffParticleExcel.AddUniqueName(builder, UniqueNameOffset);
    return BuffParticleExcel.EndBuffParticleExcel(builder);
  }

  public static void StartBuffParticleExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddUniqueName(FlatBufferBuilder builder, StringOffset UniqueNameOffset) { builder.AddOffset(1, UniqueNameOffset.Value, 0); }
  public static void AddBuffType(FlatBufferBuilder builder, StringOffset BuffTypeOffset) { builder.AddOffset(2, BuffTypeOffset.Value, 0); }
  public static void AddBuffName(FlatBufferBuilder builder, StringOffset BuffNameOffset) { builder.AddOffset(3, BuffNameOffset.Value, 0); }
  public static void AddResourcePath(FlatBufferBuilder builder, StringOffset ResourcePathOffset) { builder.AddOffset(4, ResourcePathOffset.Value, 0); }
  public static Offset<FlatDataJp.BuffParticleExcel> EndBuffParticleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.BuffParticleExcel>(o);
  }
}


}
