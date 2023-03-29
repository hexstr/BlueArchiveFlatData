// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArenaSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ArenaSeasonExcel GetRootAsArenaSeasonExcel(ByteBuffer _bb) { return GetRootAsArenaSeasonExcel(_bb, new ArenaSeasonExcel()); }
  public static ArenaSeasonExcel GetRootAsArenaSeasonExcel(ByteBuffer _bb, ArenaSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SeasonStartDate { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonStartDateBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSeasonStartDateBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSeasonStartDateArray() { return __p.__vector_as_array<byte>(6); }
  public string SeasonEndDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonEndDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSeasonEndDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSeasonEndDateArray() { return __p.__vector_as_array<byte>(8); }
  public long SeasonGroupLimit { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PrevSeasonId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ArenaSeasonExcel> CreateArenaSeasonExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset SeasonStartDateOffset = default(StringOffset),
      StringOffset SeasonEndDateOffset = default(StringOffset),
      long SeasonGroupLimit = 0,
      long PrevSeasonId = 0) {
    builder.StartTable(5);
    ArenaSeasonExcel.AddPrevSeasonId(builder, PrevSeasonId);
    ArenaSeasonExcel.AddSeasonGroupLimit(builder, SeasonGroupLimit);
    ArenaSeasonExcel.AddUniqueId(builder, UniqueId);
    ArenaSeasonExcel.AddSeasonEndDate(builder, SeasonEndDateOffset);
    ArenaSeasonExcel.AddSeasonStartDate(builder, SeasonStartDateOffset);
    return ArenaSeasonExcel.EndArenaSeasonExcel(builder);
  }

  public static void StartArenaSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddSeasonStartDate(FlatBufferBuilder builder, StringOffset SeasonStartDateOffset) { builder.AddOffset(1, SeasonStartDateOffset.Value, 0); }
  public static void AddSeasonEndDate(FlatBufferBuilder builder, StringOffset SeasonEndDateOffset) { builder.AddOffset(2, SeasonEndDateOffset.Value, 0); }
  public static void AddSeasonGroupLimit(FlatBufferBuilder builder, long SeasonGroupLimit) { builder.AddLong(3, SeasonGroupLimit, 0); }
  public static void AddPrevSeasonId(FlatBufferBuilder builder, long PrevSeasonId) { builder.AddLong(4, PrevSeasonId, 0); }
  public static Offset<FlatDataJp.ArenaSeasonExcel> EndArenaSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ArenaSeasonExcel>(o);
  }
}


}
