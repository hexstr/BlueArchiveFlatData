// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentCharacterBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentCharacterBonusExcel GetRootAsEventContentCharacterBonusExcel(ByteBuffer _bb) { return GetRootAsEventContentCharacterBonusExcel(_bb, new EventContentCharacterBonusExcel()); }
  public static EventContentCharacterBonusExcel GetRootAsEventContentCharacterBonusExcel(ByteBuffer _bb, EventContentCharacterBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentCharacterBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EventContentItemType EventContentItemType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.EventContentItemType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.EventContentItemType)0; }
  public int EventContentItemTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.EventContentItemType> GetEventContentItemTypeBytes() { return __p.__vector_as_span<FlatDataJp.EventContentItemType>(8, 4); }
#else
  public ArraySegment<byte>? GetEventContentItemTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatDataJp.EventContentItemType[] GetEventContentItemTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.EventContentItemType[] a = new FlatDataJp.EventContentItemType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.EventContentItemType)__p.bb.GetInt(p + i * 4); } return a; }
  public long BonusPercentage(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusPercentageLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusPercentageBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetBonusPercentageBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetBonusPercentageArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<FlatDataJp.EventContentCharacterBonusExcel> CreateEventContentCharacterBonusExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long CharacterId = 0,
      VectorOffset EventContentItemTypeOffset = default(VectorOffset),
      VectorOffset BonusPercentageOffset = default(VectorOffset)) {
    builder.StartTable(4);
    EventContentCharacterBonusExcel.AddCharacterId(builder, CharacterId);
    EventContentCharacterBonusExcel.AddEventContentId(builder, EventContentId);
    EventContentCharacterBonusExcel.AddBonusPercentage(builder, BonusPercentageOffset);
    EventContentCharacterBonusExcel.AddEventContentItemType(builder, EventContentItemTypeOffset);
    return EventContentCharacterBonusExcel.EndEventContentCharacterBonusExcel(builder);
  }

  public static void StartEventContentCharacterBonusExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(1, CharacterId, 0); }
  public static void AddEventContentItemType(FlatBufferBuilder builder, VectorOffset EventContentItemTypeOffset) { builder.AddOffset(2, EventContentItemTypeOffset.Value, 0); }
  public static VectorOffset CreateEventContentItemTypeVector(FlatBufferBuilder builder, FlatDataJp.EventContentItemType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.EventContentItemType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.EventContentItemType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.EventContentItemType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEventContentItemTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusPercentage(FlatBufferBuilder builder, VectorOffset BonusPercentageOffset) { builder.AddOffset(3, BonusPercentageOffset.Value, 0); }
  public static VectorOffset CreateBonusPercentageVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusPercentageVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.EventContentCharacterBonusExcel> EndEventContentCharacterBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentCharacterBonusExcel>(o);
  }
}


}
