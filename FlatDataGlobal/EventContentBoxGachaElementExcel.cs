// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentBoxGachaElementExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentBoxGachaElementExcel GetRootAsEventContentBoxGachaElementExcel(ByteBuffer _bb) { return GetRootAsEventContentBoxGachaElementExcel(_bb, new EventContentBoxGachaElementExcel()); }
  public static EventContentBoxGachaElementExcel GetRootAsEventContentBoxGachaElementExcel(ByteBuffer _bb, EventContentBoxGachaElementExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentBoxGachaElementExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Round { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.EventContentBoxGachaElementExcel> CreateEventContentBoxGachaElementExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Id = 0,
      long Round = 0,
      long GroupId = 0) {
    builder.StartTable(4);
    EventContentBoxGachaElementExcel.AddGroupId(builder, GroupId);
    EventContentBoxGachaElementExcel.AddRound(builder, Round);
    EventContentBoxGachaElementExcel.AddId(builder, Id);
    EventContentBoxGachaElementExcel.AddEventContentId(builder, EventContentId);
    return EventContentBoxGachaElementExcel.EndEventContentBoxGachaElementExcel(builder);
  }

  public static void StartEventContentBoxGachaElementExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(1, Id, 0); }
  public static void AddRound(FlatBufferBuilder builder, long Round) { builder.AddLong(2, Round, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(3, GroupId, 0); }
  public static Offset<FlatDataGlobal.EventContentBoxGachaElementExcel> EndEventContentBoxGachaElementExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentBoxGachaElementExcel>(o);
  }
}


}
