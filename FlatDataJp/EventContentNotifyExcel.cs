// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentNotifyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb) { return GetRootAsEventContentNotifyExcel(_bb, new EventContentNotifyExcel()); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb, EventContentNotifyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentNotifyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(8); }
  public FlatDataJp.EventNotifyType EventNotifyType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.EventNotifyType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EventNotifyType.RewardIncreaseEvent; } }
  public FlatDataJp.EventTargetType EventTargetType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EventTargetType.WeekDungeon; } }
  public FlatDataJp.EventTargetType ShortcutEventTargetType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EventTargetType.WeekDungeon; } }
  public bool IsShortcutEnable { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.EventContentNotifyExcel> CreateEventContentNotifyExcel(FlatBufferBuilder builder,
      int Id = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset),
      FlatDataJp.EventNotifyType EventNotifyType = FlatDataJp.EventNotifyType.RewardIncreaseEvent,
      FlatDataJp.EventTargetType EventTargetType = FlatDataJp.EventTargetType.WeekDungeon,
      FlatDataJp.EventTargetType ShortcutEventTargetType = FlatDataJp.EventTargetType.WeekDungeon,
      bool IsShortcutEnable = false) {
    builder.StartTable(7);
    EventContentNotifyExcel.AddShortcutEventTargetType(builder, ShortcutEventTargetType);
    EventContentNotifyExcel.AddEventTargetType(builder, EventTargetType);
    EventContentNotifyExcel.AddEventNotifyType(builder, EventNotifyType);
    EventContentNotifyExcel.AddIconPath(builder, IconPathOffset);
    EventContentNotifyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentNotifyExcel.AddId(builder, Id);
    EventContentNotifyExcel.AddIsShortcutEnable(builder, IsShortcutEnable);
    return EventContentNotifyExcel.EndEventContentNotifyExcel(builder);
  }

  public static void StartEventContentNotifyExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static void AddEventNotifyType(FlatBufferBuilder builder, FlatDataJp.EventNotifyType EventNotifyType) { builder.AddInt(3, (int)EventNotifyType, 0); }
  public static void AddEventTargetType(FlatBufferBuilder builder, FlatDataJp.EventTargetType EventTargetType) { builder.AddInt(4, (int)EventTargetType, 0); }
  public static void AddShortcutEventTargetType(FlatBufferBuilder builder, FlatDataJp.EventTargetType ShortcutEventTargetType) { builder.AddInt(5, (int)ShortcutEventTargetType, 0); }
  public static void AddIsShortcutEnable(FlatBufferBuilder builder, bool IsShortcutEnable) { builder.AddBool(6, IsShortcutEnable, false); }
  public static Offset<FlatDataJp.EventContentNotifyExcel> EndEventContentNotifyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentNotifyExcel>(o);
  }
}


}
