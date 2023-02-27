// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CumulativeTimeRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CumulativeTimeRewardExcel GetRootAsCumulativeTimeRewardExcel(ByteBuffer _bb) { return GetRootAsCumulativeTimeRewardExcel(_bb, new CumulativeTimeRewardExcel()); }
  public static CumulativeTimeRewardExcel GetRootAsCumulativeTimeRewardExcel(ByteBuffer _bb, CumulativeTimeRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CumulativeTimeRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Description { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(6); }
  public string StartDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(8); }
  public string EndDate { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(10); }
  public long TimeCondition(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int TimeConditionLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetTimeConditionBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetTimeConditionBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetTimeConditionArray() { return __p.__vector_as_array<long>(12); }
  public FlatDataGlobal.ParcelType RewardParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatDataGlobal.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardIdArray() { return __p.__vector_as_array<long>(16); }
  public int RewardAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RewardAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRewardAmountBytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetRewardAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetRewardAmountArray() { return __p.__vector_as_array<int>(18); }

  public static Offset<FlatDataGlobal.CumulativeTimeRewardExcel> CreateCumulativeTimeRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset DescriptionOffset = default(StringOffset),
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      VectorOffset TimeConditionOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardIdOffset = default(VectorOffset),
      VectorOffset RewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(8);
    CumulativeTimeRewardExcel.AddId(builder, Id);
    CumulativeTimeRewardExcel.AddRewardAmount(builder, RewardAmountOffset);
    CumulativeTimeRewardExcel.AddRewardId(builder, RewardIdOffset);
    CumulativeTimeRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    CumulativeTimeRewardExcel.AddTimeCondition(builder, TimeConditionOffset);
    CumulativeTimeRewardExcel.AddEndDate(builder, EndDateOffset);
    CumulativeTimeRewardExcel.AddStartDate(builder, StartDateOffset);
    CumulativeTimeRewardExcel.AddDescription(builder, DescriptionOffset);
    return CumulativeTimeRewardExcel.EndCumulativeTimeRewardExcel(builder);
  }

  public static void StartCumulativeTimeRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset DescriptionOffset) { builder.AddOffset(1, DescriptionOffset.Value, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(2, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(3, EndDateOffset.Value, 0); }
  public static void AddTimeCondition(FlatBufferBuilder builder, VectorOffset TimeConditionOffset) { builder.AddOffset(4, TimeConditionOffset.Value, 0); }
  public static VectorOffset CreateTimeConditionVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTimeConditionVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTimeConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTimeConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTimeConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(5, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardId(FlatBufferBuilder builder, VectorOffset RewardIdOffset) { builder.AddOffset(6, RewardIdOffset.Value, 0); }
  public static VectorOffset CreateRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardAmount(FlatBufferBuilder builder, VectorOffset RewardAmountOffset) { builder.AddOffset(7, RewardAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.CumulativeTimeRewardExcel> EndCumulativeTimeRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CumulativeTimeRewardExcel>(o);
  }
}


}
