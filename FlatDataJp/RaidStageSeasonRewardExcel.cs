// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RaidStageSeasonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static RaidStageSeasonRewardExcel GetRootAsRaidStageSeasonRewardExcel(ByteBuffer _bb) { return GetRootAsRaidStageSeasonRewardExcel(_bb, new RaidStageSeasonRewardExcel()); }
  public static RaidStageSeasonRewardExcel GetRootAsRaidStageSeasonRewardExcel(ByteBuffer _bb, RaidStageSeasonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidStageSeasonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonRewardId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType SeasonRewardParcelType(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int SeasonRewardParcelTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetSeasonRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(6, 4); }
#else
  public ArraySegment<byte>? GetSeasonRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatDataJp.ParcelType[] GetSeasonRewardParcelTypeArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long SeasonRewardParcelUniqueId(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardParcelUniqueIdLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetSeasonRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(8); }
  public string SeasonRewardParcelUniqueName(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int SeasonRewardParcelUniqueNameLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long SeasonRewardAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardAmountBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetSeasonRewardAmountArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<FlatDataJp.RaidStageSeasonRewardExcel> CreateRaidStageSeasonRewardExcel(FlatBufferBuilder builder,
      long SeasonRewardId = 0,
      VectorOffset SeasonRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset SeasonRewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset SeasonRewardParcelUniqueNameOffset = default(VectorOffset),
      VectorOffset SeasonRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(5);
    RaidStageSeasonRewardExcel.AddSeasonRewardId(builder, SeasonRewardId);
    RaidStageSeasonRewardExcel.AddSeasonRewardAmount(builder, SeasonRewardAmountOffset);
    RaidStageSeasonRewardExcel.AddSeasonRewardParcelUniqueName(builder, SeasonRewardParcelUniqueNameOffset);
    RaidStageSeasonRewardExcel.AddSeasonRewardParcelUniqueId(builder, SeasonRewardParcelUniqueIdOffset);
    RaidStageSeasonRewardExcel.AddSeasonRewardParcelType(builder, SeasonRewardParcelTypeOffset);
    return RaidStageSeasonRewardExcel.EndRaidStageSeasonRewardExcel(builder);
  }

  public static void StartRaidStageSeasonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, long SeasonRewardId) { builder.AddLong(0, SeasonRewardId, 0); }
  public static void AddSeasonRewardParcelType(FlatBufferBuilder builder, VectorOffset SeasonRewardParcelTypeOffset) { builder.AddOffset(1, SeasonRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSeasonRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset SeasonRewardParcelUniqueIdOffset) { builder.AddOffset(2, SeasonRewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardParcelUniqueName(FlatBufferBuilder builder, VectorOffset SeasonRewardParcelUniqueNameOffset) { builder.AddOffset(3, SeasonRewardParcelUniqueNameOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelUniqueNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSeasonRewardAmount(FlatBufferBuilder builder, VectorOffset SeasonRewardAmountOffset) { builder.AddOffset(4, SeasonRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.RaidStageSeasonRewardExcel> EndRaidStageSeasonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.RaidStageSeasonRewardExcel>(o);
  }
}


}
