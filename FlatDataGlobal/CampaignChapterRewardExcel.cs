// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignChapterRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CampaignChapterRewardExcel GetRootAsCampaignChapterRewardExcel(ByteBuffer _bb) { return GetRootAsCampaignChapterRewardExcel(_bb, new CampaignChapterRewardExcel()); }
  public static CampaignChapterRewardExcel GetRootAsCampaignChapterRewardExcel(ByteBuffer _bb, CampaignChapterRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignChapterRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CampaignChapterStar { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType ChapterRewardParcelType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int ChapterRewardParcelTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetChapterRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(8, 4); }
#else
  public ArraySegment<byte>? GetChapterRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatDataGlobal.ParcelType[] GetChapterRewardParcelTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ChapterRewardId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ChapterRewardIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetChapterRewardIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetChapterRewardIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetChapterRewardIdArray() { return __p.__vector_as_array<long>(10); }
  public int ChapterRewardAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ChapterRewardAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetChapterRewardAmountBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetChapterRewardAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetChapterRewardAmountArray() { return __p.__vector_as_array<int>(12); }

  public static Offset<FlatDataGlobal.CampaignChapterRewardExcel> CreateCampaignChapterRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      long CampaignChapterStar = 0,
      VectorOffset ChapterRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset ChapterRewardIdOffset = default(VectorOffset),
      VectorOffset ChapterRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(5);
    CampaignChapterRewardExcel.AddCampaignChapterStar(builder, CampaignChapterStar);
    CampaignChapterRewardExcel.AddId(builder, Id);
    CampaignChapterRewardExcel.AddChapterRewardAmount(builder, ChapterRewardAmountOffset);
    CampaignChapterRewardExcel.AddChapterRewardId(builder, ChapterRewardIdOffset);
    CampaignChapterRewardExcel.AddChapterRewardParcelType(builder, ChapterRewardParcelTypeOffset);
    return CampaignChapterRewardExcel.EndCampaignChapterRewardExcel(builder);
  }

  public static void StartCampaignChapterRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddCampaignChapterStar(FlatBufferBuilder builder, long CampaignChapterStar) { builder.AddLong(1, CampaignChapterStar, 0); }
  public static void AddChapterRewardParcelType(FlatBufferBuilder builder, VectorOffset ChapterRewardParcelTypeOffset) { builder.AddOffset(2, ChapterRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChapterRewardId(FlatBufferBuilder builder, VectorOffset ChapterRewardIdOffset) { builder.AddOffset(3, ChapterRewardIdOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddChapterRewardAmount(FlatBufferBuilder builder, VectorOffset ChapterRewardAmountOffset) { builder.AddOffset(4, ChapterRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.CampaignChapterRewardExcel> EndCampaignChapterRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CampaignChapterRewardExcel>(o);
  }
}


}
