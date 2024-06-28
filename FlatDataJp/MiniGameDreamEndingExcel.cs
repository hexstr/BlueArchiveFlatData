// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameDreamEndingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MiniGameDreamEndingExcel GetRootAsMiniGameDreamEndingExcel(ByteBuffer _bb) { return GetRootAsMiniGameDreamEndingExcel(_bb, new MiniGameDreamEndingExcel()); }
  public static MiniGameDreamEndingExcel GetRootAsMiniGameDreamEndingExcel(ByteBuffer _bb, MiniGameDreamEndingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameDreamEndingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EndingId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.DreamMakerEndingType DreamMakerEndingType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.DreamMakerEndingType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.DreamMakerEndingType.None; } }
  public int Order { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long ScenarioGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.DreamMakerEndingCondition EndingCondition(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.DreamMakerEndingCondition)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.DreamMakerEndingCondition)0; }
  public int EndingConditionLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.DreamMakerEndingCondition> GetEndingConditionBytes() { return __p.__vector_as_span<FlatDataJp.DreamMakerEndingCondition>(14, 4); }
#else
  public ArraySegment<byte>? GetEndingConditionBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatDataJp.DreamMakerEndingCondition[] GetEndingConditionArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.DreamMakerEndingCondition[] a = new FlatDataJp.DreamMakerEndingCondition[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.DreamMakerEndingCondition)__p.bb.GetInt(p + i * 4); } return a; }
  public long EndingConditionValue(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EndingConditionValueLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEndingConditionValueBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetEndingConditionValueBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetEndingConditionValueArray() { return __p.__vector_as_array<long>(16); }

  public static Offset<FlatDataJp.MiniGameDreamEndingExcel> CreateMiniGameDreamEndingExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long EndingId = 0,
      FlatDataJp.DreamMakerEndingType dreamMakerEndingType = FlatDataJp.DreamMakerEndingType.None,
      int Order = 0,
      long ScenarioGroupId = 0,
      VectorOffset EndingConditionOffset = default(VectorOffset),
      VectorOffset EndingConditionValueOffset = default(VectorOffset)) {
    builder.StartTable(7);
    MiniGameDreamEndingExcel.AddScenarioGroupId(builder, ScenarioGroupId);
    MiniGameDreamEndingExcel.AddEndingId(builder, EndingId);
    MiniGameDreamEndingExcel.AddEventContentId(builder, EventContentId);
    MiniGameDreamEndingExcel.AddEndingConditionValue(builder, EndingConditionValueOffset);
    MiniGameDreamEndingExcel.AddEndingCondition(builder, EndingConditionOffset);
    MiniGameDreamEndingExcel.AddOrder(builder, Order);
    MiniGameDreamEndingExcel.AddDreamMakerEndingType(builder, dreamMakerEndingType);
    return MiniGameDreamEndingExcel.EndMiniGameDreamEndingExcel(builder);
  }

  public static void StartMiniGameDreamEndingExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddEndingId(FlatBufferBuilder builder, long EndingId) { builder.AddLong(1, EndingId, 0); }
  public static void AddDreamMakerEndingType(FlatBufferBuilder builder, FlatDataJp.DreamMakerEndingType dreamMakerEndingType) { builder.AddInt(2, (int)dreamMakerEndingType, 0); }
  public static void AddOrder(FlatBufferBuilder builder, int Order) { builder.AddInt(3, Order, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, long ScenarioGroupId) { builder.AddLong(4, ScenarioGroupId, 0); }
  public static void AddEndingCondition(FlatBufferBuilder builder, VectorOffset EndingConditionOffset) { builder.AddOffset(5, EndingConditionOffset.Value, 0); }
  public static VectorOffset CreateEndingConditionVector(FlatBufferBuilder builder, FlatDataJp.DreamMakerEndingCondition[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionVectorBlock(FlatBufferBuilder builder, FlatDataJp.DreamMakerEndingCondition[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.DreamMakerEndingCondition> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.DreamMakerEndingCondition>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEndingConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndingConditionValue(FlatBufferBuilder builder, VectorOffset EndingConditionValueOffset) { builder.AddOffset(6, EndingConditionValueOffset.Value, 0); }
  public static VectorOffset CreateEndingConditionValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndingConditionValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEndingConditionValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.MiniGameDreamEndingExcel> EndMiniGameDreamEndingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.MiniGameDreamEndingExcel>(o);
  }
}


}
