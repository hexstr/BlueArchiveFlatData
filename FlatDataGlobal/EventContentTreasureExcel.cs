// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentTreasureExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentTreasureExcel GetRootAsEventContentTreasureExcel(ByteBuffer _bb) { return GetRootAsEventContentTreasureExcel(_bb, new EventContentTreasureExcel()); }
  public static EventContentTreasureExcel GetRootAsEventContentTreasureExcel(ByteBuffer _bb, EventContentTreasureExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentTreasureExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string TitleLocalize { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleLocalizeBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTitleLocalizeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTitleLocalizeArray() { return __p.__vector_as_array<byte>(6); }
  public int LoopRound { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string UsePrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUsePrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetUsePrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetUsePrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string TreasureBGImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTreasureBGImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTreasureBGImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTreasureBGImagePathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataGlobal.EventContentTreasureExcel> CreateEventContentTreasureExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      StringOffset TitleLocalizeOffset = default(StringOffset),
      int LoopRound = 0,
      StringOffset UsePrefabNameOffset = default(StringOffset),
      StringOffset TreasureBGImagePathOffset = default(StringOffset)) {
    builder.StartTable(5);
    EventContentTreasureExcel.AddEventContentId(builder, EventContentId);
    EventContentTreasureExcel.AddTreasureBGImagePath(builder, TreasureBGImagePathOffset);
    EventContentTreasureExcel.AddUsePrefabName(builder, UsePrefabNameOffset);
    EventContentTreasureExcel.AddLoopRound(builder, LoopRound);
    EventContentTreasureExcel.AddTitleLocalize(builder, TitleLocalizeOffset);
    return EventContentTreasureExcel.EndEventContentTreasureExcel(builder);
  }

  public static void StartEventContentTreasureExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddTitleLocalize(FlatBufferBuilder builder, StringOffset TitleLocalizeOffset) { builder.AddOffset(1, TitleLocalizeOffset.Value, 0); }
  public static void AddLoopRound(FlatBufferBuilder builder, int LoopRound) { builder.AddInt(2, LoopRound, 0); }
  public static void AddUsePrefabName(FlatBufferBuilder builder, StringOffset UsePrefabNameOffset) { builder.AddOffset(3, UsePrefabNameOffset.Value, 0); }
  public static void AddTreasureBGImagePath(FlatBufferBuilder builder, StringOffset TreasureBGImagePathOffset) { builder.AddOffset(4, TreasureBGImagePathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.EventContentTreasureExcel> EndEventContentTreasureExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentTreasureExcel>(o);
  }
}


}
