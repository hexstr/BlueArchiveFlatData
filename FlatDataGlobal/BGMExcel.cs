// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BGMExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BGMExcel GetRootAsBGMExcel(ByteBuffer _bb) { return GetRootAsBGMExcel(_bb, new BGMExcel()); }
  public static BGMExcel GetRootAsBGMExcel(ByteBuffer _bb, BGMExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ProductionStep Productionstep { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ProductionStep.ToDo; } }
  public string Path { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPathArray() { return __p.__vector_as_array<byte>(8); }
  public float Volume { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LoopStartTime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LoopEndTime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LoopTranstionTime { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LoopOffsetTime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataGlobal.BGMExcel> CreateBGMExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.ProductionStep productionstep = FlatDataGlobal.ProductionStep.ToDo,
      StringOffset PathOffset = default(StringOffset),
      float Volume = 0.0f,
      float LoopStartTime = 0.0f,
      float LoopEndTime = 0.0f,
      float LoopTranstionTime = 0.0f,
      float LoopOffsetTime = 0.0f) {
    builder.StartTable(8);
    BGMExcel.AddId(builder, Id);
    BGMExcel.AddLoopOffsetTime(builder, LoopOffsetTime);
    BGMExcel.AddLoopTranstionTime(builder, LoopTranstionTime);
    BGMExcel.AddLoopEndTime(builder, LoopEndTime);
    BGMExcel.AddLoopStartTime(builder, LoopStartTime);
    BGMExcel.AddVolume(builder, Volume);
    BGMExcel.AddPath(builder, PathOffset);
    BGMExcel.AddProductionstep(builder, productionstep);
    return BGMExcel.EndBGMExcel(builder);
  }

  public static void StartBGMExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddProductionstep(FlatBufferBuilder builder, FlatDataGlobal.ProductionStep productionstep) { builder.AddInt(1, (int)productionstep, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(2, PathOffset.Value, 0); }
  public static void AddVolume(FlatBufferBuilder builder, float Volume) { builder.AddFloat(3, Volume, 0.0f); }
  public static void AddLoopStartTime(FlatBufferBuilder builder, float LoopStartTime) { builder.AddFloat(4, LoopStartTime, 0.0f); }
  public static void AddLoopEndTime(FlatBufferBuilder builder, float LoopEndTime) { builder.AddFloat(5, LoopEndTime, 0.0f); }
  public static void AddLoopTranstionTime(FlatBufferBuilder builder, float LoopTranstionTime) { builder.AddFloat(6, LoopTranstionTime, 0.0f); }
  public static void AddLoopOffsetTime(FlatBufferBuilder builder, float LoopOffsetTime) { builder.AddFloat(7, LoopOffsetTime, 0.0f); }
  public static Offset<FlatDataGlobal.BGMExcel> EndBGMExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.BGMExcel>(o);
  }
}


}
