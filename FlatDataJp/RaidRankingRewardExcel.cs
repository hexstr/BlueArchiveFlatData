// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RaidRankingRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static RaidRankingRewardExcel GetRootAsRaidRankingRewardExcel(ByteBuffer _bb) { return GetRootAsRaidRankingRewardExcel(_bb, new RaidRankingRewardExcel()); }
  public static RaidRankingRewardExcel GetRootAsRaidRankingRewardExcel(ByteBuffer _bb, RaidRankingRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidRankingRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long RankingRewardGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RankStart { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RankEnd { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PercentRankStart { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PercentRankEnd { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Tier { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ParcelType RewardParcelType(int j) { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(18, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public FlatDataJp.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(18); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelUniqueId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelUniqueIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(20); }
  public string RewardParcelUniqueName(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int RewardParcelUniqueNameLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long RewardParcelAmount(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(24); }

  public static Offset<FlatDataJp.RaidRankingRewardExcel> CreateRaidRankingRewardExcel(FlatBufferBuilder builder,
      long RankingRewardGroupId = 0,
      long Id = 0,
      long RankStart = 0,
      long RankEnd = 0,
      long PercentRankStart = 0,
      long PercentRankEnd = 0,
      int Tier = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueNameOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(11);
    RaidRankingRewardExcel.AddPercentRankEnd(builder, PercentRankEnd);
    RaidRankingRewardExcel.AddPercentRankStart(builder, PercentRankStart);
    RaidRankingRewardExcel.AddRankEnd(builder, RankEnd);
    RaidRankingRewardExcel.AddRankStart(builder, RankStart);
    RaidRankingRewardExcel.AddId(builder, Id);
    RaidRankingRewardExcel.AddRankingRewardGroupId(builder, RankingRewardGroupId);
    RaidRankingRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    RaidRankingRewardExcel.AddRewardParcelUniqueName(builder, RewardParcelUniqueNameOffset);
    RaidRankingRewardExcel.AddRewardParcelUniqueId(builder, RewardParcelUniqueIdOffset);
    RaidRankingRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    RaidRankingRewardExcel.AddTier(builder, Tier);
    return RaidRankingRewardExcel.EndRaidRankingRewardExcel(builder);
  }

  public static void StartRaidRankingRewardExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddRankingRewardGroupId(FlatBufferBuilder builder, long RankingRewardGroupId) { builder.AddLong(0, RankingRewardGroupId, 0); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(1, Id, 0); }
  public static void AddRankStart(FlatBufferBuilder builder, long RankStart) { builder.AddLong(2, RankStart, 0); }
  public static void AddRankEnd(FlatBufferBuilder builder, long RankEnd) { builder.AddLong(3, RankEnd, 0); }
  public static void AddPercentRankStart(FlatBufferBuilder builder, long PercentRankStart) { builder.AddLong(4, PercentRankStart, 0); }
  public static void AddPercentRankEnd(FlatBufferBuilder builder, long PercentRankEnd) { builder.AddLong(5, PercentRankEnd, 0); }
  public static void AddTier(FlatBufferBuilder builder, int Tier) { builder.AddInt(6, Tier, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(7, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset RewardParcelUniqueIdOffset) { builder.AddOffset(8, RewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelUniqueName(FlatBufferBuilder builder, VectorOffset RewardParcelUniqueNameOffset) { builder.AddOffset(9, RewardParcelUniqueNameOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset RewardParcelAmountOffset) { builder.AddOffset(10, RewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.RaidRankingRewardExcel> EndRaidRankingRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.RaidRankingRewardExcel>(o);
  }
}


}
