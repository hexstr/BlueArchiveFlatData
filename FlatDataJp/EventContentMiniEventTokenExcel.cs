// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentMiniEventTokenExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentMiniEventTokenExcel GetRootAsEventContentMiniEventTokenExcel(ByteBuffer _bb) { return GetRootAsEventContentMiniEventTokenExcel(_bb, new EventContentMiniEventTokenExcel()); }
  public static EventContentMiniEventTokenExcel GetRootAsEventContentMiniEventTokenExcel(ByteBuffer _bb, EventContentMiniEventTokenExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMiniEventTokenExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ItemUniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaximumAmount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.EventContentMiniEventTokenExcel> CreateEventContentMiniEventTokenExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long ItemUniqueId = 0,
      long MaximumAmount = 0) {
    builder.StartTable(3);
    EventContentMiniEventTokenExcel.AddMaximumAmount(builder, MaximumAmount);
    EventContentMiniEventTokenExcel.AddItemUniqueId(builder, ItemUniqueId);
    EventContentMiniEventTokenExcel.AddEventContentId(builder, EventContentId);
    return EventContentMiniEventTokenExcel.EndEventContentMiniEventTokenExcel(builder);
  }

  public static void StartEventContentMiniEventTokenExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddItemUniqueId(FlatBufferBuilder builder, long ItemUniqueId) { builder.AddLong(1, ItemUniqueId, 0); }
  public static void AddMaximumAmount(FlatBufferBuilder builder, long MaximumAmount) { builder.AddLong(2, MaximumAmount, 0); }
  public static Offset<FlatDataJp.EventContentMiniEventTokenExcel> EndEventContentMiniEventTokenExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentMiniEventTokenExcel>(o);
  }
}


}
