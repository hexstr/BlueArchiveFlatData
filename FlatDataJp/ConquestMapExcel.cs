// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestMapExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConquestMapExcel GetRootAsConquestMapExcel(ByteBuffer _bb) { return GetRootAsConquestMapExcel(_bb, new ConquestMapExcel()); }
  public static ConquestMapExcel GetRootAsConquestMapExcel(ByteBuffer _bb, ConquestMapExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestMapExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(6); }
  public FlatDataJp.StageDifficulty MapDifficulty { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageDifficulty.None; } }
  public int StepIndex { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ConquestMap { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetConquestMapBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetConquestMapBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetConquestMapArray() { return __p.__vector_as_array<byte>(12); }
  public long StepEnterScenarioGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ConquestConditionType StepOpenConditionType(int j) { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ConquestConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ConquestConditionType)0; }
  public int StepOpenConditionTypeLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ConquestConditionType> GetStepOpenConditionTypeBytes() { return __p.__vector_as_span<FlatDataJp.ConquestConditionType>(16, 4); }
#else
  public ArraySegment<byte>? GetStepOpenConditionTypeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public FlatDataJp.ConquestConditionType[] GetStepOpenConditionTypeArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ConquestConditionType[] a = new FlatDataJp.ConquestConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ConquestConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public string StepOpenConditionParameter(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int StepOpenConditionParameterLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string MapGoalLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMapGoalLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetMapGoalLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetMapGoalLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public string StepGoalLocalize { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepGoalLocalizeBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetStepGoalLocalizeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetStepGoalLocalizeArray() { return __p.__vector_as_array<byte>(22); }
  public string StepNameLocalize { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepNameLocalizeBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetStepNameLocalizeBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetStepNameLocalizeArray() { return __p.__vector_as_array<byte>(24); }
  public string ConquestMapBG { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetConquestMapBGBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetConquestMapBGBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetConquestMapBGArray() { return __p.__vector_as_array<byte>(26); }
  public long CameraSettingId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ConquestMapExcel> CreateConquestMapExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      StringOffset DevNameOffset = default(StringOffset),
      FlatDataJp.StageDifficulty MapDifficulty = FlatDataJp.StageDifficulty.None,
      int StepIndex = 0,
      StringOffset ConquestMapOffset = default(StringOffset),
      long StepEnterScenarioGroupId = 0,
      VectorOffset StepOpenConditionTypeOffset = default(VectorOffset),
      VectorOffset StepOpenConditionParameterOffset = default(VectorOffset),
      StringOffset MapGoalLocalizeOffset = default(StringOffset),
      StringOffset StepGoalLocalizeOffset = default(StringOffset),
      StringOffset StepNameLocalizeOffset = default(StringOffset),
      StringOffset ConquestMapBGOffset = default(StringOffset),
      long CameraSettingId = 0) {
    builder.StartTable(13);
    ConquestMapExcel.AddCameraSettingId(builder, CameraSettingId);
    ConquestMapExcel.AddStepEnterScenarioGroupId(builder, StepEnterScenarioGroupId);
    ConquestMapExcel.AddEventContentId(builder, EventContentId);
    ConquestMapExcel.AddConquestMapBG(builder, ConquestMapBGOffset);
    ConquestMapExcel.AddStepNameLocalize(builder, StepNameLocalizeOffset);
    ConquestMapExcel.AddStepGoalLocalize(builder, StepGoalLocalizeOffset);
    ConquestMapExcel.AddMapGoalLocalize(builder, MapGoalLocalizeOffset);
    ConquestMapExcel.AddStepOpenConditionParameter(builder, StepOpenConditionParameterOffset);
    ConquestMapExcel.AddStepOpenConditionType(builder, StepOpenConditionTypeOffset);
    ConquestMapExcel.AddConquestMap(builder, ConquestMapOffset);
    ConquestMapExcel.AddStepIndex(builder, StepIndex);
    ConquestMapExcel.AddMapDifficulty(builder, MapDifficulty);
    ConquestMapExcel.AddDevName(builder, DevNameOffset);
    return ConquestMapExcel.EndConquestMapExcel(builder);
  }

  public static void StartConquestMapExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset DevNameOffset) { builder.AddOffset(1, DevNameOffset.Value, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, FlatDataJp.StageDifficulty MapDifficulty) { builder.AddInt(2, (int)MapDifficulty, 0); }
  public static void AddStepIndex(FlatBufferBuilder builder, int StepIndex) { builder.AddInt(3, StepIndex, 0); }
  public static void AddConquestMap(FlatBufferBuilder builder, StringOffset ConquestMapOffset) { builder.AddOffset(4, ConquestMapOffset.Value, 0); }
  public static void AddStepEnterScenarioGroupId(FlatBufferBuilder builder, long StepEnterScenarioGroupId) { builder.AddLong(5, StepEnterScenarioGroupId, 0); }
  public static void AddStepOpenConditionType(FlatBufferBuilder builder, VectorOffset StepOpenConditionTypeOffset) { builder.AddOffset(6, StepOpenConditionTypeOffset.Value, 0); }
  public static VectorOffset CreateStepOpenConditionTypeVector(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ConquestConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ConquestConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepOpenConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStepOpenConditionParameter(FlatBufferBuilder builder, VectorOffset StepOpenConditionParameterOffset) { builder.AddOffset(7, StepOpenConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateStepOpenConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepOpenConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMapGoalLocalize(FlatBufferBuilder builder, StringOffset MapGoalLocalizeOffset) { builder.AddOffset(8, MapGoalLocalizeOffset.Value, 0); }
  public static void AddStepGoalLocalize(FlatBufferBuilder builder, StringOffset StepGoalLocalizeOffset) { builder.AddOffset(9, StepGoalLocalizeOffset.Value, 0); }
  public static void AddStepNameLocalize(FlatBufferBuilder builder, StringOffset StepNameLocalizeOffset) { builder.AddOffset(10, StepNameLocalizeOffset.Value, 0); }
  public static void AddConquestMapBG(FlatBufferBuilder builder, StringOffset ConquestMapBGOffset) { builder.AddOffset(11, ConquestMapBGOffset.Value, 0); }
  public static void AddCameraSettingId(FlatBufferBuilder builder, long CameraSettingId) { builder.AddLong(12, CameraSettingId, 0); }
  public static Offset<FlatDataJp.ConquestMapExcel> EndConquestMapExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConquestMapExcel>(o);
  }
}


}
