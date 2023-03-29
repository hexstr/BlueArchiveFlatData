// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstNewbieContentExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConstNewbieContentExcel GetRootAsConstNewbieContentExcel(ByteBuffer _bb) { return GetRootAsConstNewbieContentExcel(_bb, new ConstNewbieContentExcel()); }
  public static ConstNewbieContentExcel GetRootAsConstNewbieContentExcel(ByteBuffer _bb, ConstNewbieContentExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstNewbieContentExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string NewbieGachaReleaseDate { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNewbieGachaReleaseDateBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNewbieGachaReleaseDateBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNewbieGachaReleaseDateArray() { return __p.__vector_as_array<byte>(4); }
  public int NewbieGachaCheckDays { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NewbieGachaTokenGraceTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string NewbieAttendanceReleaseDate { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNewbieAttendanceReleaseDateBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNewbieAttendanceReleaseDateBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNewbieAttendanceReleaseDateArray() { return __p.__vector_as_array<byte>(10); }
  public int NewbieAttendanceStartableEndDay { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NewbieAttendanceEndDay { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.ConstNewbieContentExcel> CreateConstNewbieContentExcel(FlatBufferBuilder builder,
      StringOffset NewbieGachaReleaseDateOffset = default(StringOffset),
      int NewbieGachaCheckDays = 0,
      int NewbieGachaTokenGraceTime = 0,
      StringOffset NewbieAttendanceReleaseDateOffset = default(StringOffset),
      int NewbieAttendanceStartableEndDay = 0,
      int NewbieAttendanceEndDay = 0) {
    builder.StartTable(6);
    ConstNewbieContentExcel.AddNewbieAttendanceEndDay(builder, NewbieAttendanceEndDay);
    ConstNewbieContentExcel.AddNewbieAttendanceStartableEndDay(builder, NewbieAttendanceStartableEndDay);
    ConstNewbieContentExcel.AddNewbieAttendanceReleaseDate(builder, NewbieAttendanceReleaseDateOffset);
    ConstNewbieContentExcel.AddNewbieGachaTokenGraceTime(builder, NewbieGachaTokenGraceTime);
    ConstNewbieContentExcel.AddNewbieGachaCheckDays(builder, NewbieGachaCheckDays);
    ConstNewbieContentExcel.AddNewbieGachaReleaseDate(builder, NewbieGachaReleaseDateOffset);
    return ConstNewbieContentExcel.EndConstNewbieContentExcel(builder);
  }

  public static void StartConstNewbieContentExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddNewbieGachaReleaseDate(FlatBufferBuilder builder, StringOffset NewbieGachaReleaseDateOffset) { builder.AddOffset(0, NewbieGachaReleaseDateOffset.Value, 0); }
  public static void AddNewbieGachaCheckDays(FlatBufferBuilder builder, int NewbieGachaCheckDays) { builder.AddInt(1, NewbieGachaCheckDays, 0); }
  public static void AddNewbieGachaTokenGraceTime(FlatBufferBuilder builder, int NewbieGachaTokenGraceTime) { builder.AddInt(2, NewbieGachaTokenGraceTime, 0); }
  public static void AddNewbieAttendanceReleaseDate(FlatBufferBuilder builder, StringOffset NewbieAttendanceReleaseDateOffset) { builder.AddOffset(3, NewbieAttendanceReleaseDateOffset.Value, 0); }
  public static void AddNewbieAttendanceStartableEndDay(FlatBufferBuilder builder, int NewbieAttendanceStartableEndDay) { builder.AddInt(4, NewbieAttendanceStartableEndDay, 0); }
  public static void AddNewbieAttendanceEndDay(FlatBufferBuilder builder, int NewbieAttendanceEndDay) { builder.AddInt(5, NewbieAttendanceEndDay, 0); }
  public static Offset<FlatDataJp.ConstNewbieContentExcel> EndConstNewbieContentExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConstNewbieContentExcel>(o);
  }
}


}
