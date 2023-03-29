// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignChapterExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CampaignChapterExcel GetRootAsCampaignChapterExcel(ByteBuffer _bb) { return GetRootAsCampaignChapterExcel(_bb, new CampaignChapterExcel()); }
  public static CampaignChapterExcel GetRootAsCampaignChapterExcel(ByteBuffer _bb, CampaignChapterExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignChapterExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string NormalImagePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNormalImagePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNormalImagePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNormalImagePathArray() { return __p.__vector_as_array<byte>(8); }
  public string HardImagePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetHardImagePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetHardImagePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetHardImagePathArray() { return __p.__vector_as_array<byte>(10); }
  public long Order { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreChapterId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreChapterIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreChapterIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetPreChapterIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetPreChapterIdArray() { return __p.__vector_as_array<long>(14); }
  public long ChapterRewardId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ChapterHardRewardId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ChapterVeryHardRewardId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NormalCampaignStageId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int NormalCampaignStageIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetNormalCampaignStageIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetNormalCampaignStageIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetNormalCampaignStageIdArray() { return __p.__vector_as_array<long>(22); }
  public long NormalExtraStageId(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int NormalExtraStageIdLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetNormalExtraStageIdBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetNormalExtraStageIdBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetNormalExtraStageIdArray() { return __p.__vector_as_array<long>(24); }
  public long HardCampaignStageId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int HardCampaignStageIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetHardCampaignStageIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetHardCampaignStageIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetHardCampaignStageIdArray() { return __p.__vector_as_array<long>(26); }
  public long VeryHardCampaignStageId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int VeryHardCampaignStageIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetVeryHardCampaignStageIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetVeryHardCampaignStageIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetVeryHardCampaignStageIdArray() { return __p.__vector_as_array<long>(28); }
  public bool IsTacticSkip { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.CampaignChapterExcel> CreateCampaignChapterExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset NormalImagePathOffset = default(StringOffset),
      StringOffset HardImagePathOffset = default(StringOffset),
      long Order = 0,
      VectorOffset PreChapterIdOffset = default(VectorOffset),
      long ChapterRewardId = 0,
      long ChapterHardRewardId = 0,
      long ChapterVeryHardRewardId = 0,
      VectorOffset NormalCampaignStageIdOffset = default(VectorOffset),
      VectorOffset NormalExtraStageIdOffset = default(VectorOffset),
      VectorOffset HardCampaignStageIdOffset = default(VectorOffset),
      VectorOffset VeryHardCampaignStageIdOffset = default(VectorOffset),
      bool IsTacticSkip = false) {
    builder.StartTable(14);
    CampaignChapterExcel.AddChapterVeryHardRewardId(builder, ChapterVeryHardRewardId);
    CampaignChapterExcel.AddChapterHardRewardId(builder, ChapterHardRewardId);
    CampaignChapterExcel.AddChapterRewardId(builder, ChapterRewardId);
    CampaignChapterExcel.AddOrder(builder, Order);
    CampaignChapterExcel.AddId(builder, Id);
    CampaignChapterExcel.AddVeryHardCampaignStageId(builder, VeryHardCampaignStageIdOffset);
    CampaignChapterExcel.AddHardCampaignStageId(builder, HardCampaignStageIdOffset);
    CampaignChapterExcel.AddNormalExtraStageId(builder, NormalExtraStageIdOffset);
    CampaignChapterExcel.AddNormalCampaignStageId(builder, NormalCampaignStageIdOffset);
    CampaignChapterExcel.AddPreChapterId(builder, PreChapterIdOffset);
    CampaignChapterExcel.AddHardImagePath(builder, HardImagePathOffset);
    CampaignChapterExcel.AddNormalImagePath(builder, NormalImagePathOffset);
    CampaignChapterExcel.AddName(builder, NameOffset);
    CampaignChapterExcel.AddIsTacticSkip(builder, IsTacticSkip);
    return CampaignChapterExcel.EndCampaignChapterExcel(builder);
  }

  public static void StartCampaignChapterExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNormalImagePath(FlatBufferBuilder builder, StringOffset NormalImagePathOffset) { builder.AddOffset(2, NormalImagePathOffset.Value, 0); }
  public static void AddHardImagePath(FlatBufferBuilder builder, StringOffset HardImagePathOffset) { builder.AddOffset(3, HardImagePathOffset.Value, 0); }
  public static void AddOrder(FlatBufferBuilder builder, long Order) { builder.AddLong(4, Order, 0); }
  public static void AddPreChapterId(FlatBufferBuilder builder, VectorOffset PreChapterIdOffset) { builder.AddOffset(5, PreChapterIdOffset.Value, 0); }
  public static VectorOffset CreatePreChapterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreChapterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreChapterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreChapterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreChapterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddChapterRewardId(FlatBufferBuilder builder, long ChapterRewardId) { builder.AddLong(6, ChapterRewardId, 0); }
  public static void AddChapterHardRewardId(FlatBufferBuilder builder, long ChapterHardRewardId) { builder.AddLong(7, ChapterHardRewardId, 0); }
  public static void AddChapterVeryHardRewardId(FlatBufferBuilder builder, long ChapterVeryHardRewardId) { builder.AddLong(8, ChapterVeryHardRewardId, 0); }
  public static void AddNormalCampaignStageId(FlatBufferBuilder builder, VectorOffset NormalCampaignStageIdOffset) { builder.AddOffset(9, NormalCampaignStageIdOffset.Value, 0); }
  public static VectorOffset CreateNormalCampaignStageIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNormalCampaignStageIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalCampaignStageIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalCampaignStageIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNormalCampaignStageIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddNormalExtraStageId(FlatBufferBuilder builder, VectorOffset NormalExtraStageIdOffset) { builder.AddOffset(10, NormalExtraStageIdOffset.Value, 0); }
  public static VectorOffset CreateNormalExtraStageIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNormalExtraStageIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalExtraStageIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalExtraStageIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNormalExtraStageIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddHardCampaignStageId(FlatBufferBuilder builder, VectorOffset HardCampaignStageIdOffset) { builder.AddOffset(11, HardCampaignStageIdOffset.Value, 0); }
  public static VectorOffset CreateHardCampaignStageIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartHardCampaignStageIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddVeryHardCampaignStageId(FlatBufferBuilder builder, VectorOffset VeryHardCampaignStageIdOffset) { builder.AddOffset(12, VeryHardCampaignStageIdOffset.Value, 0); }
  public static VectorOffset CreateVeryHardCampaignStageIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVeryHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVeryHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVeryHardCampaignStageIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVeryHardCampaignStageIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIsTacticSkip(FlatBufferBuilder builder, bool IsTacticSkip) { builder.AddBool(13, IsTacticSkip, false); }
  public static Offset<FlatDataJp.CampaignChapterExcel> EndCampaignChapterExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CampaignChapterExcel>(o);
  }
}


}
