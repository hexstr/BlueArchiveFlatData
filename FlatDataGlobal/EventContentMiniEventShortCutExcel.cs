// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentMiniEventShortCutExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentMiniEventShortCutExcel GetRootAsEventContentMiniEventShortCutExcel(ByteBuffer _bb) { return GetRootAsEventContentMiniEventShortCutExcel(_bb, new EventContentMiniEventShortCutExcel()); }
  public static EventContentMiniEventShortCutExcel GetRootAsEventContentMiniEventShortCutExcel(ByteBuffer _bb, EventContentMiniEventShortCutExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMiniEventShortCutExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataGlobal.EventTargetType ShorcutContentType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventTargetType.WeekDungeon; } }

  public static Offset<FlatDataGlobal.EventContentMiniEventShortCutExcel> CreateEventContentMiniEventShortCutExcel(FlatBufferBuilder builder,
      int Id = 0,
      uint LocalizeEtcId = 0,
      FlatDataGlobal.EventTargetType ShorcutContentType = FlatDataGlobal.EventTargetType.WeekDungeon) {
    builder.StartTable(3);
    EventContentMiniEventShortCutExcel.AddShorcutContentType(builder, ShorcutContentType);
    EventContentMiniEventShortCutExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentMiniEventShortCutExcel.AddId(builder, Id);
    return EventContentMiniEventShortCutExcel.EndEventContentMiniEventShortCutExcel(builder);
  }

  public static void StartEventContentMiniEventShortCutExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddShorcutContentType(FlatBufferBuilder builder, FlatDataGlobal.EventTargetType ShorcutContentType) { builder.AddInt(2, (int)ShorcutContentType, 0); }
  public static Offset<FlatDataGlobal.EventContentMiniEventShortCutExcel> EndEventContentMiniEventShortCutExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentMiniEventShortCutExcel>(o);
  }
}


}
