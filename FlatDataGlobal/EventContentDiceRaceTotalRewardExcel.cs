// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentDiceRaceTotalRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentDiceRaceTotalRewardExcel GetRootAsEventContentDiceRaceTotalRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentDiceRaceTotalRewardExcel(_bb, new EventContentDiceRaceTotalRewardExcel()); }
  public static EventContentDiceRaceTotalRewardExcel GetRootAsEventContentDiceRaceTotalRewardExcel(ByteBuffer _bb, EventContentDiceRaceTotalRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDiceRaceTotalRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RequiredLapFinishCount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DisplayLapFinishCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.ParcelType RewardParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatDataGlobal.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(16); }

  public static Offset<FlatDataGlobal.EventContentDiceRaceTotalRewardExcel> CreateEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long RewardID = 0,
      int RequiredLapFinishCount = 0,
      int DisplayLapFinishCount = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(7);
    EventContentDiceRaceTotalRewardExcel.AddRewardID(builder, RewardID);
    EventContentDiceRaceTotalRewardExcel.AddEventContentId(builder, EventContentId);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentDiceRaceTotalRewardExcel.AddDisplayLapFinishCount(builder, DisplayLapFinishCount);
    EventContentDiceRaceTotalRewardExcel.AddRequiredLapFinishCount(builder, RequiredLapFinishCount);
    return EventContentDiceRaceTotalRewardExcel.EndEventContentDiceRaceTotalRewardExcel(builder);
  }

  public static void StartEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddRewardID(FlatBufferBuilder builder, long RewardID) { builder.AddLong(1, RewardID, 0); }
  public static void AddRequiredLapFinishCount(FlatBufferBuilder builder, int RequiredLapFinishCount) { builder.AddInt(2, RequiredLapFinishCount, 0); }
  public static void AddDisplayLapFinishCount(FlatBufferBuilder builder, int DisplayLapFinishCount) { builder.AddInt(3, DisplayLapFinishCount, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(4, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset RewardParcelIdOffset) { builder.AddOffset(5, RewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset RewardParcelAmountOffset) { builder.AddOffset(6, RewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.EventContentDiceRaceTotalRewardExcel> EndEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentDiceRaceTotalRewardExcel>(o);
  }
}


}
