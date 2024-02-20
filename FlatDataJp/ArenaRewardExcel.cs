// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArenaRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ArenaRewardExcel GetRootAsArenaRewardExcel(ByteBuffer _bb) { return GetRootAsArenaRewardExcel(_bb, new ArenaRewardExcel()); }
  public static ArenaRewardExcel GetRootAsArenaRewardExcel(ByteBuffer _bb, ArenaRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ArenaRewardType ArenaRewardType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ArenaRewardType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ArenaRewardType.None; } }
  public long RankStart { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RankEnd { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RankIconPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRankIconPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetRankIconPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetRankIconPathArray() { return __p.__vector_as_array<byte>(12); }
  public FlatDataJp.ParcelType RewardParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatDataJp.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelUniqueId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelUniqueIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(16); }
  public string RewardParcelUniqueName(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int RewardParcelUniqueNameLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long RewardParcelAmount(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<FlatDataJp.ArenaRewardExcel> CreateArenaRewardExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      FlatDataJp.ArenaRewardType arenaRewardType = FlatDataJp.ArenaRewardType.None,
      long RankStart = 0,
      long RankEnd = 0,
      StringOffset RankIconPathOffset = default(StringOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueNameOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(9);
    ArenaRewardExcel.AddRankEnd(builder, RankEnd);
    ArenaRewardExcel.AddRankStart(builder, RankStart);
    ArenaRewardExcel.AddUniqueId(builder, UniqueId);
    ArenaRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    ArenaRewardExcel.AddRewardParcelUniqueName(builder, RewardParcelUniqueNameOffset);
    ArenaRewardExcel.AddRewardParcelUniqueId(builder, RewardParcelUniqueIdOffset);
    ArenaRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    ArenaRewardExcel.AddRankIconPath(builder, RankIconPathOffset);
    ArenaRewardExcel.AddArenaRewardType(builder, arenaRewardType);
    return ArenaRewardExcel.EndArenaRewardExcel(builder);
  }

  public static void StartArenaRewardExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddArenaRewardType(FlatBufferBuilder builder, FlatDataJp.ArenaRewardType arenaRewardType) { builder.AddInt(1, (int)arenaRewardType, 0); }
  public static void AddRankStart(FlatBufferBuilder builder, long RankStart) { builder.AddLong(2, RankStart, 0); }
  public static void AddRankEnd(FlatBufferBuilder builder, long RankEnd) { builder.AddLong(3, RankEnd, 0); }
  public static void AddRankIconPath(FlatBufferBuilder builder, StringOffset RankIconPathOffset) { builder.AddOffset(4, RankIconPathOffset.Value, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(5, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset RewardParcelUniqueIdOffset) { builder.AddOffset(6, RewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelUniqueName(FlatBufferBuilder builder, VectorOffset RewardParcelUniqueNameOffset) { builder.AddOffset(7, RewardParcelUniqueNameOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset RewardParcelAmountOffset) { builder.AddOffset(8, RewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.ArenaRewardExcel> EndArenaRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ArenaRewardExcel>(o);
  }
}


}
