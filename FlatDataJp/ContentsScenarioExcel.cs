// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ContentsScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ContentsScenarioExcel GetRootAsContentsScenarioExcel(ByteBuffer _bb) { return GetRootAsContentsScenarioExcel(_bb, new ContentsScenarioExcel()); }
  public static ContentsScenarioExcel GetRootAsContentsScenarioExcel(ByteBuffer _bb, ContentsScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ContentsScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.ScenarioContentType Scenariocontenttype { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ScenarioContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ScenarioContentType.Prologue; } }
  public long ScenarioGroupId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ScenarioGroupIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetScenarioGroupIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetScenarioGroupIdArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<FlatDataJp.ContentsScenarioExcel> CreateContentsScenarioExcel(FlatBufferBuilder builder,
      uint Id = 0,
      uint LocalizeId = 0,
      FlatDataJp.ScenarioContentType scenariocontenttype = FlatDataJp.ScenarioContentType.Prologue,
      VectorOffset ScenarioGroupIdOffset = default(VectorOffset)) {
    builder.StartTable(4);
    ContentsScenarioExcel.AddScenarioGroupId(builder, ScenarioGroupIdOffset);
    ContentsScenarioExcel.AddScenariocontenttype(builder, scenariocontenttype);
    ContentsScenarioExcel.AddLocalizeId(builder, LocalizeId);
    ContentsScenarioExcel.AddId(builder, Id);
    return ContentsScenarioExcel.EndContentsScenarioExcel(builder);
  }

  public static void StartContentsScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, uint Id) { builder.AddUint(0, Id, 0); }
  public static void AddLocalizeId(FlatBufferBuilder builder, uint LocalizeId) { builder.AddUint(1, LocalizeId, 0); }
  public static void AddScenariocontenttype(FlatBufferBuilder builder, FlatDataJp.ScenarioContentType scenariocontenttype) { builder.AddInt(2, (int)scenariocontenttype, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, VectorOffset ScenarioGroupIdOffset) { builder.AddOffset(3, ScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.ContentsScenarioExcel> EndContentsScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ContentsScenarioExcel>(o);
  }
}


}
