// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ObstacleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ObstacleExcel GetRootAsObstacleExcel(ByteBuffer _bb) { return GetRootAsObstacleExcel(_bb, new ObstacleExcel()); }
  public static ObstacleExcel GetRootAsObstacleExcel(ByteBuffer _bb, ObstacleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObstacleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PrefabName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(6); }
  public bool JumpAble { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float SubOffset(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SubOffsetLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSubOffsetBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetSubOffsetBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetSubOffsetArray() { return __p.__vector_as_array<float>(10); }
  public float X { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long Hp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHp { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int BlockRate { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EvasionRate { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.ObstacleDestroyType DestroyType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataGlobal.ObstacleDestroyType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ObstacleDestroyType.Remain; } }
  public float Point1Offeset(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Point1OffesetLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetPoint1OffesetBytes() { return __p.__vector_as_span<float>(26, 4); }
#else
  public ArraySegment<byte>? GetPoint1OffesetBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public float[] GetPoint1OffesetArray() { return __p.__vector_as_array<float>(26); }
  public float EnemyPoint1Osset(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int EnemyPoint1OssetLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetEnemyPoint1OssetBytes() { return __p.__vector_as_span<float>(28, 4); }
#else
  public ArraySegment<byte>? GetEnemyPoint1OssetBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public float[] GetEnemyPoint1OssetArray() { return __p.__vector_as_array<float>(28); }
  public float Point2Offeset(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Point2OffesetLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetPoint2OffesetBytes() { return __p.__vector_as_span<float>(30, 4); }
#else
  public ArraySegment<byte>? GetPoint2OffesetBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public float[] GetPoint2OffesetArray() { return __p.__vector_as_array<float>(30); }
  public float EnemyPoint2Osset(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int EnemyPoint2OssetLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetEnemyPoint2OssetBytes() { return __p.__vector_as_span<float>(32, 4); }
#else
  public ArraySegment<byte>? GetEnemyPoint2OssetBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public float[] GetEnemyPoint2OssetArray() { return __p.__vector_as_array<float>(32); }
  public long SubObstacleID(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SubObstacleIDLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSubObstacleIDBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetSubObstacleIDBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetSubObstacleIDArray() { return __p.__vector_as_array<long>(34); }

  public static Offset<FlatDataGlobal.ObstacleExcel> CreateObstacleExcel(FlatBufferBuilder builder,
      long Index = 0,
      StringOffset PrefabNameOffset = default(StringOffset),
      bool JumpAble = false,
      VectorOffset SubOffsetOffset = default(VectorOffset),
      float X = 0.0f,
      float Z = 0.0f,
      long Hp = 0,
      long MaxHp = 0,
      int BlockRate = 0,
      int EvasionRate = 0,
      FlatDataGlobal.ObstacleDestroyType DestroyType = FlatDataGlobal.ObstacleDestroyType.Remain,
      VectorOffset Point1OffesetOffset = default(VectorOffset),
      VectorOffset EnemyPoint1OssetOffset = default(VectorOffset),
      VectorOffset Point2OffesetOffset = default(VectorOffset),
      VectorOffset EnemyPoint2OssetOffset = default(VectorOffset),
      VectorOffset SubObstacleIDOffset = default(VectorOffset)) {
    builder.StartTable(16);
    ObstacleExcel.AddMaxHp(builder, MaxHp);
    ObstacleExcel.AddHp(builder, Hp);
    ObstacleExcel.AddIndex(builder, Index);
    ObstacleExcel.AddSubObstacleID(builder, SubObstacleIDOffset);
    ObstacleExcel.AddEnemyPoint2Osset(builder, EnemyPoint2OssetOffset);
    ObstacleExcel.AddPoint2Offeset(builder, Point2OffesetOffset);
    ObstacleExcel.AddEnemyPoint1Osset(builder, EnemyPoint1OssetOffset);
    ObstacleExcel.AddPoint1Offeset(builder, Point1OffesetOffset);
    ObstacleExcel.AddDestroyType(builder, DestroyType);
    ObstacleExcel.AddEvasionRate(builder, EvasionRate);
    ObstacleExcel.AddBlockRate(builder, BlockRate);
    ObstacleExcel.AddZ(builder, Z);
    ObstacleExcel.AddX(builder, X);
    ObstacleExcel.AddSubOffset(builder, SubOffsetOffset);
    ObstacleExcel.AddPrefabName(builder, PrefabNameOffset);
    ObstacleExcel.AddJumpAble(builder, JumpAble);
    return ObstacleExcel.EndObstacleExcel(builder);
  }

  public static void StartObstacleExcel(FlatBufferBuilder builder) { builder.StartTable(16); }
  public static void AddIndex(FlatBufferBuilder builder, long Index) { builder.AddLong(0, Index, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset PrefabNameOffset) { builder.AddOffset(1, PrefabNameOffset.Value, 0); }
  public static void AddJumpAble(FlatBufferBuilder builder, bool JumpAble) { builder.AddBool(2, JumpAble, false); }
  public static void AddSubOffset(FlatBufferBuilder builder, VectorOffset SubOffsetOffset) { builder.AddOffset(3, SubOffsetOffset.Value, 0); }
  public static VectorOffset CreateSubOffsetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSubOffsetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddX(FlatBufferBuilder builder, float X) { builder.AddFloat(4, X, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float Z) { builder.AddFloat(5, Z, 0.0f); }
  public static void AddHp(FlatBufferBuilder builder, long Hp) { builder.AddLong(6, Hp, 0); }
  public static void AddMaxHp(FlatBufferBuilder builder, long MaxHp) { builder.AddLong(7, MaxHp, 0); }
  public static void AddBlockRate(FlatBufferBuilder builder, int BlockRate) { builder.AddInt(8, BlockRate, 0); }
  public static void AddEvasionRate(FlatBufferBuilder builder, int EvasionRate) { builder.AddInt(9, EvasionRate, 0); }
  public static void AddDestroyType(FlatBufferBuilder builder, FlatDataGlobal.ObstacleDestroyType DestroyType) { builder.AddInt(10, (int)DestroyType, 0); }
  public static void AddPoint1Offeset(FlatBufferBuilder builder, VectorOffset Point1OffesetOffset) { builder.AddOffset(11, Point1OffesetOffset.Value, 0); }
  public static VectorOffset CreatePoint1OffesetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPoint1OffesetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnemyPoint1Osset(FlatBufferBuilder builder, VectorOffset EnemyPoint1OssetOffset) { builder.AddOffset(12, EnemyPoint1OssetOffset.Value, 0); }
  public static VectorOffset CreateEnemyPoint1OssetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnemyPoint1OssetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPoint2Offeset(FlatBufferBuilder builder, VectorOffset Point2OffesetOffset) { builder.AddOffset(13, Point2OffesetOffset.Value, 0); }
  public static VectorOffset CreatePoint2OffesetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPoint2OffesetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnemyPoint2Osset(FlatBufferBuilder builder, VectorOffset EnemyPoint2OssetOffset) { builder.AddOffset(14, EnemyPoint2OssetOffset.Value, 0); }
  public static VectorOffset CreateEnemyPoint2OssetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnemyPoint2OssetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSubObstacleID(FlatBufferBuilder builder, VectorOffset SubObstacleIDOffset) { builder.AddOffset(15, SubObstacleIDOffset.Value, 0); }
  public static VectorOffset CreateSubObstacleIDVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSubObstacleIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.ObstacleExcel> EndObstacleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ObstacleExcel>(o);
  }
}


}
