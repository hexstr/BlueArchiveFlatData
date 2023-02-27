// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentFortuneGachaExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentFortuneGachaExcel GetRootAsEventContentFortuneGachaExcel(ByteBuffer _bb) { return GetRootAsEventContentFortuneGachaExcel(_bb, new EventContentFortuneGachaExcel()); }
  public static EventContentFortuneGachaExcel GetRootAsEventContentFortuneGachaExcel(ByteBuffer _bb, EventContentFortuneGachaExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentFortuneGachaExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int FortuneGachaGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<FlatDataGlobal.EventContentFortuneGachaExcel> CreateEventContentFortuneGachaExcel(FlatBufferBuilder builder,
      int FortuneGachaGroupId = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset)) {
    builder.StartTable(3);
    EventContentFortuneGachaExcel.AddIconPath(builder, IconPathOffset);
    EventContentFortuneGachaExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentFortuneGachaExcel.AddFortuneGachaGroupId(builder, FortuneGachaGroupId);
    return EventContentFortuneGachaExcel.EndEventContentFortuneGachaExcel(builder);
  }

  public static void StartEventContentFortuneGachaExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddFortuneGachaGroupId(FlatBufferBuilder builder, int FortuneGachaGroupId) { builder.AddInt(0, FortuneGachaGroupId, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.EventContentFortuneGachaExcel> EndEventContentFortuneGachaExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentFortuneGachaExcel>(o);
  }
}


}
