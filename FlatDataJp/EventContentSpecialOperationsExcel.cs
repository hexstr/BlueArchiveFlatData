// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentSpecialOperationsExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentSpecialOperationsExcel GetRootAsEventContentSpecialOperationsExcel(ByteBuffer _bb) { return GetRootAsEventContentSpecialOperationsExcel(_bb, new EventContentSpecialOperationsExcel()); }
  public static EventContentSpecialOperationsExcel GetRootAsEventContentSpecialOperationsExcel(ByteBuffer _bb, EventContentSpecialOperationsExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentSpecialOperationsExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PointItemId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.EventContentSpecialOperationsExcel> CreateEventContentSpecialOperationsExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long PointItemId = 0) {
    builder.StartTable(2);
    EventContentSpecialOperationsExcel.AddPointItemId(builder, PointItemId);
    EventContentSpecialOperationsExcel.AddEventContentId(builder, EventContentId);
    return EventContentSpecialOperationsExcel.EndEventContentSpecialOperationsExcel(builder);
  }

  public static void StartEventContentSpecialOperationsExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddPointItemId(FlatBufferBuilder builder, long PointItemId) { builder.AddLong(1, PointItemId, 0); }
  public static Offset<FlatDataJp.EventContentSpecialOperationsExcel> EndEventContentSpecialOperationsExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentSpecialOperationsExcel>(o);
  }
}


}
