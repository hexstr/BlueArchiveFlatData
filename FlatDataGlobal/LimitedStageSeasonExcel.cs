// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LimitedStageSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static LimitedStageSeasonExcel GetRootAsLimitedStageSeasonExcel(ByteBuffer _bb) { return GetRootAsLimitedStageSeasonExcel(_bb, new LimitedStageSeasonExcel()); }
  public static LimitedStageSeasonExcel GetRootAsLimitedStageSeasonExcel(ByteBuffer _bb, LimitedStageSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LimitedStageSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StartDate { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(6); }
  public string EndDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(8); }
  public long TypeACount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TypeBCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TypeCCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.LimitedStageSeasonExcel> CreateLimitedStageSeasonExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long TypeACount = 0,
      long TypeBCount = 0,
      long TypeCCount = 0) {
    builder.StartTable(6);
    LimitedStageSeasonExcel.AddTypeCCount(builder, TypeCCount);
    LimitedStageSeasonExcel.AddTypeBCount(builder, TypeBCount);
    LimitedStageSeasonExcel.AddTypeACount(builder, TypeACount);
    LimitedStageSeasonExcel.AddId(builder, Id);
    LimitedStageSeasonExcel.AddEndDate(builder, EndDateOffset);
    LimitedStageSeasonExcel.AddStartDate(builder, StartDateOffset);
    return LimitedStageSeasonExcel.EndLimitedStageSeasonExcel(builder);
  }

  public static void StartLimitedStageSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(1, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(2, EndDateOffset.Value, 0); }
  public static void AddTypeACount(FlatBufferBuilder builder, long TypeACount) { builder.AddLong(3, TypeACount, 0); }
  public static void AddTypeBCount(FlatBufferBuilder builder, long TypeBCount) { builder.AddLong(4, TypeBCount, 0); }
  public static void AddTypeCCount(FlatBufferBuilder builder, long TypeCCount) { builder.AddLong(5, TypeCCount, 0); }
  public static Offset<FlatDataGlobal.LimitedStageSeasonExcel> EndLimitedStageSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.LimitedStageSeasonExcel>(o);
  }
}


}
