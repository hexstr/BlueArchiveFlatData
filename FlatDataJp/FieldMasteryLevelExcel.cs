// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldMasteryLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FieldMasteryLevelExcel GetRootAsFieldMasteryLevelExcel(ByteBuffer _bb) { return GetRootAsFieldMasteryLevelExcel(_bb, new FieldMasteryLevelExcel()); }
  public static FieldMasteryLevelExcel GetRootAsFieldMasteryLevelExcel(ByteBuffer _bb, FieldMasteryLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldMasteryLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Id(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int IdLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetIdBytes() { return __p.__vector_as_span<long>(6, 8); }
#else
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public long[] GetIdArray() { return __p.__vector_as_array<long>(6); }
  public long Exp(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExpLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExpBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetExpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetExpArray() { return __p.__vector_as_array<long>(8); }
  public long TotalExp(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int TotalExpLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetTotalExpBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetTotalExpBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetTotalExpArray() { return __p.__vector_as_array<long>(10); }
  public long RewardId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetRewardIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetRewardIdArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<FlatDataJp.FieldMasteryLevelExcel> CreateFieldMasteryLevelExcel(FlatBufferBuilder builder,
      int Level = 0,
      VectorOffset IdOffset = default(VectorOffset),
      VectorOffset ExpOffset = default(VectorOffset),
      VectorOffset TotalExpOffset = default(VectorOffset),
      VectorOffset RewardIdOffset = default(VectorOffset)) {
    builder.StartTable(5);
    FieldMasteryLevelExcel.AddRewardId(builder, RewardIdOffset);
    FieldMasteryLevelExcel.AddTotalExp(builder, TotalExpOffset);
    FieldMasteryLevelExcel.AddExp(builder, ExpOffset);
    FieldMasteryLevelExcel.AddId(builder, IdOffset);
    FieldMasteryLevelExcel.AddLevel(builder, Level);
    return FieldMasteryLevelExcel.EndFieldMasteryLevelExcel(builder);
  }

  public static void StartFieldMasteryLevelExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(0, Level, 0); }
  public static void AddId(FlatBufferBuilder builder, VectorOffset IdOffset) { builder.AddOffset(1, IdOffset.Value, 0); }
  public static VectorOffset CreateIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExp(FlatBufferBuilder builder, VectorOffset ExpOffset) { builder.AddOffset(2, ExpOffset.Value, 0); }
  public static VectorOffset CreateExpVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExpVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExpVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddTotalExp(FlatBufferBuilder builder, VectorOffset TotalExpOffset) { builder.AddOffset(3, TotalExpOffset.Value, 0); }
  public static VectorOffset CreateTotalExpVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTotalExpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardId(FlatBufferBuilder builder, VectorOffset RewardIdOffset) { builder.AddOffset(4, RewardIdOffset.Value, 0); }
  public static VectorOffset CreateRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.FieldMasteryLevelExcel> EndFieldMasteryLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.FieldMasteryLevelExcel>(o);
  }
}


}
