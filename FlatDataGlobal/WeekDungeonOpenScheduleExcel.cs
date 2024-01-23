// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeekDungeonOpenScheduleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static WeekDungeonOpenScheduleExcel GetRootAsWeekDungeonOpenScheduleExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonOpenScheduleExcel(_bb, new WeekDungeonOpenScheduleExcel()); }
  public static WeekDungeonOpenScheduleExcel GetRootAsWeekDungeonOpenScheduleExcel(ByteBuffer _bb, WeekDungeonOpenScheduleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonOpenScheduleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.WeekDay WeekDay { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.WeekDay)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.WeekDay.Sunday; } }
  public FlatDataGlobal.WeekDungeonType Open(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.WeekDungeonType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.WeekDungeonType)0; }
  public int OpenLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.WeekDungeonType> GetOpenBytes() { return __p.__vector_as_span<FlatDataGlobal.WeekDungeonType>(6, 4); }
#else
  public ArraySegment<byte>? GetOpenBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatDataGlobal.WeekDungeonType[] GetOpenArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.WeekDungeonType[] a = new FlatDataGlobal.WeekDungeonType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.WeekDungeonType)__p.bb.GetInt(p + i * 4); } return a; }

  public static Offset<FlatDataGlobal.WeekDungeonOpenScheduleExcel> CreateWeekDungeonOpenScheduleExcel(FlatBufferBuilder builder,
      FlatDataGlobal.WeekDay weekDay = FlatDataGlobal.WeekDay.Sunday,
      VectorOffset OpenOffset = default(VectorOffset)) {
    builder.StartTable(2);
    WeekDungeonOpenScheduleExcel.AddOpen(builder, OpenOffset);
    WeekDungeonOpenScheduleExcel.AddWeekDay(builder, weekDay);
    return WeekDungeonOpenScheduleExcel.EndWeekDungeonOpenScheduleExcel(builder);
  }

  public static void StartWeekDungeonOpenScheduleExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddWeekDay(FlatBufferBuilder builder, FlatDataGlobal.WeekDay weekDay) { builder.AddInt(0, (int)weekDay, 0); }
  public static void AddOpen(FlatBufferBuilder builder, VectorOffset OpenOffset) { builder.AddOffset(1, OpenOffset.Value, 0); }
  public static VectorOffset CreateOpenVector(FlatBufferBuilder builder, FlatDataGlobal.WeekDungeonType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOpenVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.WeekDungeonType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.WeekDungeonType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.WeekDungeonType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOpenVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.WeekDungeonOpenScheduleExcel> EndWeekDungeonOpenScheduleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.WeekDungeonOpenScheduleExcel>(o);
  }
}


}
