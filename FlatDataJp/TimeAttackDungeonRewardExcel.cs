// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TimeAttackDungeonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TimeAttackDungeonRewardExcel GetRootAsTimeAttackDungeonRewardExcel(ByteBuffer _bb) { return GetRootAsTimeAttackDungeonRewardExcel(_bb, new TimeAttackDungeonRewardExcel()); }
  public static TimeAttackDungeonRewardExcel GetRootAsTimeAttackDungeonRewardExcel(ByteBuffer _bb, TimeAttackDungeonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TimeAttackDungeonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardMaxPoint { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.TimeAttackDungeonRewardType RewardType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.TimeAttackDungeonRewardType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.TimeAttackDungeonRewardType)0; }
  public int RewardTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.TimeAttackDungeonRewardType> GetRewardTypeBytes() { return __p.__vector_as_span<FlatDataJp.TimeAttackDungeonRewardType>(8, 4); }
#else
  public ArraySegment<byte>? GetRewardTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatDataJp.TimeAttackDungeonRewardType[] GetRewardTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.TimeAttackDungeonRewardType[] a = new FlatDataJp.TimeAttackDungeonRewardType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.TimeAttackDungeonRewardType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardMinPoint(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardMinPointLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardMinPointBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetRewardMinPointBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetRewardMinPointArray() { return __p.__vector_as_array<long>(10); }
  public FlatDataJp.ParcelType RewardParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatDataJp.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long RewardParcelDefaultAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelDefaultAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelDefaultAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelDefaultAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelDefaultAmountArray() { return __p.__vector_as_array<long>(16); }
  public long RewardParcelMaxAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelMaxAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelMaxAmountBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelMaxAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetRewardParcelMaxAmountArray() { return __p.__vector_as_array<long>(18); }

  public static Offset<FlatDataJp.TimeAttackDungeonRewardExcel> CreateTimeAttackDungeonRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      long RewardMaxPoint = 0,
      VectorOffset RewardTypeOffset = default(VectorOffset),
      VectorOffset RewardMinPointOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelDefaultAmountOffset = default(VectorOffset),
      VectorOffset RewardParcelMaxAmountOffset = default(VectorOffset)) {
    builder.StartTable(8);
    TimeAttackDungeonRewardExcel.AddRewardMaxPoint(builder, RewardMaxPoint);
    TimeAttackDungeonRewardExcel.AddId(builder, Id);
    TimeAttackDungeonRewardExcel.AddRewardParcelMaxAmount(builder, RewardParcelMaxAmountOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelDefaultAmount(builder, RewardParcelDefaultAmountOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    TimeAttackDungeonRewardExcel.AddRewardMinPoint(builder, RewardMinPointOffset);
    TimeAttackDungeonRewardExcel.AddRewardType(builder, RewardTypeOffset);
    return TimeAttackDungeonRewardExcel.EndTimeAttackDungeonRewardExcel(builder);
  }

  public static void StartTimeAttackDungeonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddRewardMaxPoint(FlatBufferBuilder builder, long RewardMaxPoint) { builder.AddLong(1, RewardMaxPoint, 0); }
  public static void AddRewardType(FlatBufferBuilder builder, VectorOffset RewardTypeOffset) { builder.AddOffset(2, RewardTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardTypeVector(FlatBufferBuilder builder, FlatDataJp.TimeAttackDungeonRewardType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.TimeAttackDungeonRewardType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.TimeAttackDungeonRewardType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.TimeAttackDungeonRewardType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardMinPoint(FlatBufferBuilder builder, VectorOffset RewardMinPointOffset) { builder.AddOffset(3, RewardMinPointOffset.Value, 0); }
  public static VectorOffset CreateRewardMinPointVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardMinPointVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(4, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset RewardParcelIdOffset) { builder.AddOffset(5, RewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelDefaultAmount(FlatBufferBuilder builder, VectorOffset RewardParcelDefaultAmountOffset) { builder.AddOffset(6, RewardParcelDefaultAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelDefaultAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelDefaultAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelMaxAmount(FlatBufferBuilder builder, VectorOffset RewardParcelMaxAmountOffset) { builder.AddOffset(7, RewardParcelMaxAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelMaxAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelMaxAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.TimeAttackDungeonRewardExcel> EndTimeAttackDungeonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.TimeAttackDungeonRewardExcel>(o);
  }
}


}
