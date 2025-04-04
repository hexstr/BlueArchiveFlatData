// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestGroupBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConquestGroupBonusExcel GetRootAsConquestGroupBonusExcel(ByteBuffer _bb) { return GetRootAsConquestGroupBonusExcel(_bb, new ConquestGroupBonusExcel()); }
  public static ConquestGroupBonusExcel GetRootAsConquestGroupBonusExcel(ByteBuffer _bb, ConquestGroupBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestGroupBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ConquestBonusId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.School School(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.School)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.School)0; }
  public int SchoolLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.School> GetSchoolBytes() { return __p.__vector_as_span<FlatDataGlobal.School>(6, 4); }
#else
  public ArraySegment<byte>? GetSchoolBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatDataGlobal.School[] GetSchoolArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.School[] a = new FlatDataGlobal.School[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.School)__p.bb.GetInt(p + i * 4); } return a; }
  public uint RecommandLocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataGlobal.ParcelType BonusParcelType(int j) { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int BonusParcelTypeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetBonusParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(10, 4); }
#else
  public ArraySegment<byte>? GetBonusParcelTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public FlatDataGlobal.ParcelType[] GetBonusParcelTypeArray() { int o = __p.__offset(10); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long BonusId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetBonusIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetBonusIdArray() { return __p.__vector_as_array<long>(12); }
  public int BonusCharacterCount1(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BonusCharacterCount1Length { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBonusCharacterCount1Bytes() { return __p.__vector_as_span<int>(14, 4); }
#else
  public ArraySegment<byte>? GetBonusCharacterCount1Bytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public int[] GetBonusCharacterCount1Array() { return __p.__vector_as_array<int>(14); }
  public long BonusPercentage1(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusPercentage1Length { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusPercentage1Bytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetBonusPercentage1Bytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetBonusPercentage1Array() { return __p.__vector_as_array<long>(16); }
  public int BonusCharacterCount2(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BonusCharacterCount2Length { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBonusCharacterCount2Bytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetBonusCharacterCount2Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetBonusCharacterCount2Array() { return __p.__vector_as_array<int>(18); }
  public long BonusPercentage2(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusPercentage2Length { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusPercentage2Bytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetBonusPercentage2Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetBonusPercentage2Array() { return __p.__vector_as_array<long>(20); }
  public int BonusCharacterCount3(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BonusCharacterCount3Length { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBonusCharacterCount3Bytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetBonusCharacterCount3Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetBonusCharacterCount3Array() { return __p.__vector_as_array<int>(22); }
  public long BonusPercentage3(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusPercentage3Length { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusPercentage3Bytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetBonusPercentage3Bytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetBonusPercentage3Array() { return __p.__vector_as_array<long>(24); }

  public static Offset<FlatDataGlobal.ConquestGroupBonusExcel> CreateConquestGroupBonusExcel(FlatBufferBuilder builder,
      long ConquestBonusId = 0,
      VectorOffset SchoolOffset = default(VectorOffset),
      uint RecommandLocalizeEtcId = 0,
      VectorOffset BonusParcelTypeOffset = default(VectorOffset),
      VectorOffset BonusIdOffset = default(VectorOffset),
      VectorOffset BonusCharacterCount1Offset = default(VectorOffset),
      VectorOffset BonusPercentage1Offset = default(VectorOffset),
      VectorOffset BonusCharacterCount2Offset = default(VectorOffset),
      VectorOffset BonusPercentage2Offset = default(VectorOffset),
      VectorOffset BonusCharacterCount3Offset = default(VectorOffset),
      VectorOffset BonusPercentage3Offset = default(VectorOffset)) {
    builder.StartTable(11);
    ConquestGroupBonusExcel.AddConquestBonusId(builder, ConquestBonusId);
    ConquestGroupBonusExcel.AddBonusPercentage3(builder, BonusPercentage3Offset);
    ConquestGroupBonusExcel.AddBonusCharacterCount3(builder, BonusCharacterCount3Offset);
    ConquestGroupBonusExcel.AddBonusPercentage2(builder, BonusPercentage2Offset);
    ConquestGroupBonusExcel.AddBonusCharacterCount2(builder, BonusCharacterCount2Offset);
    ConquestGroupBonusExcel.AddBonusPercentage1(builder, BonusPercentage1Offset);
    ConquestGroupBonusExcel.AddBonusCharacterCount1(builder, BonusCharacterCount1Offset);
    ConquestGroupBonusExcel.AddBonusId(builder, BonusIdOffset);
    ConquestGroupBonusExcel.AddBonusParcelType(builder, BonusParcelTypeOffset);
    ConquestGroupBonusExcel.AddRecommandLocalizeEtcId(builder, RecommandLocalizeEtcId);
    ConquestGroupBonusExcel.AddSchool(builder, SchoolOffset);
    return ConquestGroupBonusExcel.EndConquestGroupBonusExcel(builder);
  }

  public static void StartConquestGroupBonusExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddConquestBonusId(FlatBufferBuilder builder, long ConquestBonusId) { builder.AddLong(0, ConquestBonusId, 0); }
  public static void AddSchool(FlatBufferBuilder builder, VectorOffset SchoolOffset) { builder.AddOffset(1, SchoolOffset.Value, 0); }
  public static VectorOffset CreateSchoolVector(FlatBufferBuilder builder, FlatDataGlobal.School[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSchoolVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.School[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSchoolVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.School> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSchoolVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.School>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSchoolVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecommandLocalizeEtcId(FlatBufferBuilder builder, uint RecommandLocalizeEtcId) { builder.AddUint(2, RecommandLocalizeEtcId, 0); }
  public static void AddBonusParcelType(FlatBufferBuilder builder, VectorOffset BonusParcelTypeOffset) { builder.AddOffset(3, BonusParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateBonusParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusId(FlatBufferBuilder builder, VectorOffset BonusIdOffset) { builder.AddOffset(4, BonusIdOffset.Value, 0); }
  public static VectorOffset CreateBonusIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBonusCharacterCount1(FlatBufferBuilder builder, VectorOffset BonusCharacterCount1Offset) { builder.AddOffset(5, BonusCharacterCount1Offset.Value, 0); }
  public static VectorOffset CreateBonusCharacterCount1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusCharacterCount1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusPercentage1(FlatBufferBuilder builder, VectorOffset BonusPercentage1Offset) { builder.AddOffset(6, BonusPercentage1Offset.Value, 0); }
  public static VectorOffset CreateBonusPercentage1Vector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage1VectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage1VectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusPercentage1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBonusCharacterCount2(FlatBufferBuilder builder, VectorOffset BonusCharacterCount2Offset) { builder.AddOffset(7, BonusCharacterCount2Offset.Value, 0); }
  public static VectorOffset CreateBonusCharacterCount2Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount2VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount2VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusCharacterCount2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusPercentage2(FlatBufferBuilder builder, VectorOffset BonusPercentage2Offset) { builder.AddOffset(8, BonusPercentage2Offset.Value, 0); }
  public static VectorOffset CreateBonusPercentage2Vector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage2VectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage2VectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusPercentage2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBonusCharacterCount3(FlatBufferBuilder builder, VectorOffset BonusCharacterCount3Offset) { builder.AddOffset(9, BonusCharacterCount3Offset.Value, 0); }
  public static VectorOffset CreateBonusCharacterCount3Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount3VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount3VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusCharacterCount3VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusCharacterCount3Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusPercentage3(FlatBufferBuilder builder, VectorOffset BonusPercentage3Offset) { builder.AddOffset(10, BonusPercentage3Offset.Value, 0); }
  public static VectorOffset CreateBonusPercentage3Vector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage3VectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage3VectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentage3VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusPercentage3Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.ConquestGroupBonusExcel> EndConquestGroupBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConquestGroupBonusExcel>(o);
  }
}


}
