// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArenaNPCExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ArenaNPCExcel GetRootAsArenaNPCExcel(ByteBuffer _bb) { return GetRootAsArenaNPCExcel(_bb, new ArenaNPCExcel()); }
  public static ArenaNPCExcel GetRootAsArenaNPCExcel(ByteBuffer _bb, ArenaNPCExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaNPCExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Rank { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCAccountLevel { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCLevelDeviation { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCStarGrade { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.Rarity ExceptionCharacterRarities(int j) { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.Rarity)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.Rarity)0; }
  public int ExceptionCharacterRaritiesLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.Rarity> GetExceptionCharacterRaritiesBytes() { return __p.__vector_as_span<FlatDataJp.Rarity>(16, 4); }
#else
  public ArraySegment<byte>? GetExceptionCharacterRaritiesBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public FlatDataJp.Rarity[] GetExceptionCharacterRaritiesArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.Rarity[] a = new FlatDataJp.Rarity[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.Rarity)__p.bb.GetInt(p + i * 4); } return a; }
  public long ExceptionMainCharacterIds(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionMainCharacterIdsLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionMainCharacterIdsBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetExceptionMainCharacterIdsBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetExceptionMainCharacterIdsArray() { return __p.__vector_as_array<long>(18); }
  public long ExceptionSupportCharacterIds(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionSupportCharacterIdsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionSupportCharacterIdsBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetExceptionSupportCharacterIdsBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetExceptionSupportCharacterIdsArray() { return __p.__vector_as_array<long>(20); }
  public long ExceptionTSSIds(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionTSSIdsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionTSSIdsBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetExceptionTSSIdsBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetExceptionTSSIdsArray() { return __p.__vector_as_array<long>(22); }

  public static Offset<FlatDataJp.ArenaNPCExcel> CreateArenaNPCExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long Rank = 0,
      long NPCAccountLevel = 0,
      long NPCLevel = 0,
      long NPCLevelDeviation = 0,
      long NPCStarGrade = 0,
      VectorOffset ExceptionCharacterRaritiesOffset = default(VectorOffset),
      VectorOffset ExceptionMainCharacterIdsOffset = default(VectorOffset),
      VectorOffset ExceptionSupportCharacterIdsOffset = default(VectorOffset),
      VectorOffset ExceptionTSSIdsOffset = default(VectorOffset)) {
    builder.StartTable(10);
    ArenaNPCExcel.AddNPCStarGrade(builder, NPCStarGrade);
    ArenaNPCExcel.AddNPCLevelDeviation(builder, NPCLevelDeviation);
    ArenaNPCExcel.AddNPCLevel(builder, NPCLevel);
    ArenaNPCExcel.AddNPCAccountLevel(builder, NPCAccountLevel);
    ArenaNPCExcel.AddRank(builder, Rank);
    ArenaNPCExcel.AddUniqueId(builder, UniqueId);
    ArenaNPCExcel.AddExceptionTSSIds(builder, ExceptionTSSIdsOffset);
    ArenaNPCExcel.AddExceptionSupportCharacterIds(builder, ExceptionSupportCharacterIdsOffset);
    ArenaNPCExcel.AddExceptionMainCharacterIds(builder, ExceptionMainCharacterIdsOffset);
    ArenaNPCExcel.AddExceptionCharacterRarities(builder, ExceptionCharacterRaritiesOffset);
    return ArenaNPCExcel.EndArenaNPCExcel(builder);
  }

  public static void StartArenaNPCExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddRank(FlatBufferBuilder builder, long Rank) { builder.AddLong(1, Rank, 0); }
  public static void AddNPCAccountLevel(FlatBufferBuilder builder, long NPCAccountLevel) { builder.AddLong(2, NPCAccountLevel, 0); }
  public static void AddNPCLevel(FlatBufferBuilder builder, long NPCLevel) { builder.AddLong(3, NPCLevel, 0); }
  public static void AddNPCLevelDeviation(FlatBufferBuilder builder, long NPCLevelDeviation) { builder.AddLong(4, NPCLevelDeviation, 0); }
  public static void AddNPCStarGrade(FlatBufferBuilder builder, long NPCStarGrade) { builder.AddLong(5, NPCStarGrade, 0); }
  public static void AddExceptionCharacterRarities(FlatBufferBuilder builder, VectorOffset ExceptionCharacterRaritiesOffset) { builder.AddOffset(6, ExceptionCharacterRaritiesOffset.Value, 0); }
  public static VectorOffset CreateExceptionCharacterRaritiesVector(FlatBufferBuilder builder, FlatDataJp.Rarity[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, FlatDataJp.Rarity[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.Rarity> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.Rarity>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionCharacterRaritiesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExceptionMainCharacterIds(FlatBufferBuilder builder, VectorOffset ExceptionMainCharacterIdsOffset) { builder.AddOffset(7, ExceptionMainCharacterIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionMainCharacterIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionMainCharacterIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExceptionSupportCharacterIds(FlatBufferBuilder builder, VectorOffset ExceptionSupportCharacterIdsOffset) { builder.AddOffset(8, ExceptionSupportCharacterIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionSupportCharacterIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExceptionTSSIds(FlatBufferBuilder builder, VectorOffset ExceptionTSSIdsOffset) { builder.AddOffset(9, ExceptionTSSIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionTSSIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionTSSIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.ArenaNPCExcel> EndArenaNPCExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ArenaNPCExcel>(o);
  }
}


}
