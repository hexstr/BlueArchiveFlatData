// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestPlayGuideExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConquestPlayGuideExcel GetRootAsConquestPlayGuideExcel(ByteBuffer _bb) { return GetRootAsConquestPlayGuideExcel(_bb, new ConquestPlayGuideExcel()); }
  public static ConquestPlayGuideExcel GetRootAsConquestPlayGuideExcel(ByteBuffer _bb, ConquestPlayGuideExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestPlayGuideExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string GuideTitle { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideTitleBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetGuideTitleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetGuideTitleArray() { return __p.__vector_as_array<byte>(10); }
  public string GuideImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetGuideImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetGuideImagePathArray() { return __p.__vector_as_array<byte>(12); }
  public string GuideText { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideTextBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetGuideTextBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetGuideTextArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatDataGlobal.ConquestPlayGuideExcel> CreateConquestPlayGuideExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      int DisplayOrder = 0,
      StringOffset GuideTitleOffset = default(StringOffset),
      StringOffset GuideImagePathOffset = default(StringOffset),
      StringOffset GuideTextOffset = default(StringOffset)) {
    builder.StartTable(6);
    ConquestPlayGuideExcel.AddEventContentId(builder, EventContentId);
    ConquestPlayGuideExcel.AddId(builder, Id);
    ConquestPlayGuideExcel.AddGuideText(builder, GuideTextOffset);
    ConquestPlayGuideExcel.AddGuideImagePath(builder, GuideImagePathOffset);
    ConquestPlayGuideExcel.AddGuideTitle(builder, GuideTitleOffset);
    ConquestPlayGuideExcel.AddDisplayOrder(builder, DisplayOrder);
    return ConquestPlayGuideExcel.EndConquestPlayGuideExcel(builder);
  }

  public static void StartConquestPlayGuideExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int DisplayOrder) { builder.AddInt(2, DisplayOrder, 0); }
  public static void AddGuideTitle(FlatBufferBuilder builder, StringOffset GuideTitleOffset) { builder.AddOffset(3, GuideTitleOffset.Value, 0); }
  public static void AddGuideImagePath(FlatBufferBuilder builder, StringOffset GuideImagePathOffset) { builder.AddOffset(4, GuideImagePathOffset.Value, 0); }
  public static void AddGuideText(FlatBufferBuilder builder, StringOffset GuideTextOffset) { builder.AddOffset(5, GuideTextOffset.Value, 0); }
  public static Offset<FlatDataGlobal.ConquestPlayGuideExcel> EndConquestPlayGuideExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConquestPlayGuideExcel>(o);
  }
}


}
