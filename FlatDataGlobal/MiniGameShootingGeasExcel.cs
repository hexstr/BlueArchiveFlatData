// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameShootingGeasExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MiniGameShootingGeasExcel GetRootAsMiniGameShootingGeasExcel(ByteBuffer _bb) { return GetRootAsMiniGameShootingGeasExcel(_bb, new MiniGameShootingGeasExcel()); }
  public static MiniGameShootingGeasExcel GetRootAsMiniGameShootingGeasExcel(ByteBuffer _bb, MiniGameShootingGeasExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameShootingGeasExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.Geas GeasType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.Geas)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.Geas.ForwardProjectile; } }
  public string Icon { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(8); }
  public long Probability { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxOverlapCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string GeasData { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGeasDataBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetGeasDataBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetGeasDataArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatDataGlobal.MiniGameShootingGeasExcel> CreateMiniGameShootingGeasExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      FlatDataGlobal.Geas GeasType = FlatDataGlobal.Geas.ForwardProjectile,
      StringOffset IconOffset = default(StringOffset),
      long Probability = 0,
      int MaxOverlapCount = 0,
      StringOffset GeasDataOffset = default(StringOffset)) {
    builder.StartTable(6);
    MiniGameShootingGeasExcel.AddProbability(builder, Probability);
    MiniGameShootingGeasExcel.AddUniqueId(builder, UniqueId);
    MiniGameShootingGeasExcel.AddGeasData(builder, GeasDataOffset);
    MiniGameShootingGeasExcel.AddMaxOverlapCount(builder, MaxOverlapCount);
    MiniGameShootingGeasExcel.AddIcon(builder, IconOffset);
    MiniGameShootingGeasExcel.AddGeasType(builder, GeasType);
    return MiniGameShootingGeasExcel.EndMiniGameShootingGeasExcel(builder);
  }

  public static void StartMiniGameShootingGeasExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddGeasType(FlatBufferBuilder builder, FlatDataGlobal.Geas GeasType) { builder.AddInt(1, (int)GeasType, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddProbability(FlatBufferBuilder builder, long Probability) { builder.AddLong(3, Probability, 0); }
  public static void AddMaxOverlapCount(FlatBufferBuilder builder, int MaxOverlapCount) { builder.AddInt(4, MaxOverlapCount, 0); }
  public static void AddGeasData(FlatBufferBuilder builder, StringOffset GeasDataOffset) { builder.AddOffset(5, GeasDataOffset.Value, 0); }
  public static Offset<FlatDataGlobal.MiniGameShootingGeasExcel> EndMiniGameShootingGeasExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MiniGameShootingGeasExcel>(o);
  }
}


}
