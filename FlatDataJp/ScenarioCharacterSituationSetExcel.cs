// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioCharacterSituationSetExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ScenarioCharacterSituationSetExcel GetRootAsScenarioCharacterSituationSetExcel(ByteBuffer _bb) { return GetRootAsScenarioCharacterSituationSetExcel(_bb, new ScenarioCharacterSituationSetExcel()); }
  public static ScenarioCharacterSituationSetExcel GetRootAsScenarioCharacterSituationSetExcel(ByteBuffer _bb, ScenarioCharacterSituationSetExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioCharacterSituationSetExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Name { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Face { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFaceBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFaceBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFaceArray() { return __p.__vector_as_array<byte>(6); }
  public string Behavior { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBehaviorBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBehaviorBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBehaviorArray() { return __p.__vector_as_array<byte>(8); }
  public string Action { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetActionBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetActionArray() { return __p.__vector_as_array<byte>(10); }
  public string Shape { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShapeBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetShapeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetShapeArray() { return __p.__vector_as_array<byte>(12); }
  public uint Effect { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Emotion { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatDataJp.ScenarioCharacterSituationSetExcel> CreateScenarioCharacterSituationSetExcel(FlatBufferBuilder builder,
      uint Name = 0,
      StringOffset FaceOffset = default(StringOffset),
      StringOffset BehaviorOffset = default(StringOffset),
      StringOffset ActionOffset = default(StringOffset),
      StringOffset ShapeOffset = default(StringOffset),
      uint Effect = 0,
      uint Emotion = 0) {
    builder.StartTable(7);
    ScenarioCharacterSituationSetExcel.AddEmotion(builder, Emotion);
    ScenarioCharacterSituationSetExcel.AddEffect(builder, Effect);
    ScenarioCharacterSituationSetExcel.AddShape(builder, ShapeOffset);
    ScenarioCharacterSituationSetExcel.AddAction(builder, ActionOffset);
    ScenarioCharacterSituationSetExcel.AddBehavior(builder, BehaviorOffset);
    ScenarioCharacterSituationSetExcel.AddFace(builder, FaceOffset);
    ScenarioCharacterSituationSetExcel.AddName(builder, Name);
    return ScenarioCharacterSituationSetExcel.EndScenarioCharacterSituationSetExcel(builder);
  }

  public static void StartScenarioCharacterSituationSetExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddName(FlatBufferBuilder builder, uint Name) { builder.AddUint(0, Name, 0); }
  public static void AddFace(FlatBufferBuilder builder, StringOffset FaceOffset) { builder.AddOffset(1, FaceOffset.Value, 0); }
  public static void AddBehavior(FlatBufferBuilder builder, StringOffset BehaviorOffset) { builder.AddOffset(2, BehaviorOffset.Value, 0); }
  public static void AddAction(FlatBufferBuilder builder, StringOffset ActionOffset) { builder.AddOffset(3, ActionOffset.Value, 0); }
  public static void AddShape(FlatBufferBuilder builder, StringOffset ShapeOffset) { builder.AddOffset(4, ShapeOffset.Value, 0); }
  public static void AddEffect(FlatBufferBuilder builder, uint Effect) { builder.AddUint(5, Effect, 0); }
  public static void AddEmotion(FlatBufferBuilder builder, uint Emotion) { builder.AddUint(6, Emotion, 0); }
  public static Offset<FlatDataJp.ScenarioCharacterSituationSetExcel> EndScenarioCharacterSituationSetExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ScenarioCharacterSituationSetExcel>(o);
  }
}


}
