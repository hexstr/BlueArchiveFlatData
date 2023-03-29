// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentFortuneGachaModifyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentFortuneGachaModifyExcel GetRootAsEventContentFortuneGachaModifyExcel(ByteBuffer _bb) { return GetRootAsEventContentFortuneGachaModifyExcel(_bb, new EventContentFortuneGachaModifyExcel()); }
  public static EventContentFortuneGachaModifyExcel GetRootAsEventContentFortuneGachaModifyExcel(ByteBuffer _bb, EventContentFortuneGachaModifyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentFortuneGachaModifyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TargetGrade { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ProbModifyStartCount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string UsePrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUsePrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetUsePrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetUsePrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string BucketImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBucketImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetBucketImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetBucketImagePathArray() { return __p.__vector_as_array<byte>(12); }
  public string ShopBgImagePath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShopBgImagePathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetShopBgImagePathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetShopBgImagePathArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatDataJp.EventContentFortuneGachaModifyExcel> CreateEventContentFortuneGachaModifyExcel(FlatBufferBuilder builder,
      int EventContentId = 0,
      int TargetGrade = 0,
      int ProbModifyStartCount = 0,
      StringOffset UsePrefabNameOffset = default(StringOffset),
      StringOffset BucketImagePathOffset = default(StringOffset),
      StringOffset ShopBgImagePathOffset = default(StringOffset)) {
    builder.StartTable(6);
    EventContentFortuneGachaModifyExcel.AddShopBgImagePath(builder, ShopBgImagePathOffset);
    EventContentFortuneGachaModifyExcel.AddBucketImagePath(builder, BucketImagePathOffset);
    EventContentFortuneGachaModifyExcel.AddUsePrefabName(builder, UsePrefabNameOffset);
    EventContentFortuneGachaModifyExcel.AddProbModifyStartCount(builder, ProbModifyStartCount);
    EventContentFortuneGachaModifyExcel.AddTargetGrade(builder, TargetGrade);
    EventContentFortuneGachaModifyExcel.AddEventContentId(builder, EventContentId);
    return EventContentFortuneGachaModifyExcel.EndEventContentFortuneGachaModifyExcel(builder);
  }

  public static void StartEventContentFortuneGachaModifyExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddEventContentId(FlatBufferBuilder builder, int EventContentId) { builder.AddInt(0, EventContentId, 0); }
  public static void AddTargetGrade(FlatBufferBuilder builder, int TargetGrade) { builder.AddInt(1, TargetGrade, 0); }
  public static void AddProbModifyStartCount(FlatBufferBuilder builder, int ProbModifyStartCount) { builder.AddInt(2, ProbModifyStartCount, 0); }
  public static void AddUsePrefabName(FlatBufferBuilder builder, StringOffset UsePrefabNameOffset) { builder.AddOffset(3, UsePrefabNameOffset.Value, 0); }
  public static void AddBucketImagePath(FlatBufferBuilder builder, StringOffset BucketImagePathOffset) { builder.AddOffset(4, BucketImagePathOffset.Value, 0); }
  public static void AddShopBgImagePath(FlatBufferBuilder builder, StringOffset ShopBgImagePathOffset) { builder.AddOffset(5, ShopBgImagePathOffset.Value, 0); }
  public static Offset<FlatDataJp.EventContentFortuneGachaModifyExcel> EndEventContentFortuneGachaModifyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentFortuneGachaModifyExcel>(o);
  }
}


}
