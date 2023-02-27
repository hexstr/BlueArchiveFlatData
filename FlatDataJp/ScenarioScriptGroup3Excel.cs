// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioScriptGroup3Excel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ScenarioScriptGroup3Excel GetRootAsScenarioScriptGroup3Excel(ByteBuffer _bb) { return GetRootAsScenarioScriptGroup3Excel(_bb, new ScenarioScriptGroup3Excel()); }
  public static ScenarioScriptGroup3Excel GetRootAsScenarioScriptGroup3Excel(ByteBuffer _bb, ScenarioScriptGroup3Excel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioScriptGroup3Excel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SelectionGroup { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BGMId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Sound { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSoundBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSoundBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSoundArray() { return __p.__vector_as_array<byte>(10); }
  public uint Transition { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint BGName { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint BGEffect { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string PopupFileName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPopupFileNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetPopupFileNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetPopupFileNameArray() { return __p.__vector_as_array<byte>(18); }
  public string ScriptKr { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetScriptKrBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetScriptKrBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetScriptKrArray() { return __p.__vector_as_array<byte>(20); }
  public string TextJp { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextJpBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetTextJpBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetTextJpArray() { return __p.__vector_as_array<byte>(22); }
  public string VoiceJp { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVoiceJpBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetVoiceJpBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetVoiceJpArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<FlatDataJp.ScenarioScriptGroup3Excel> CreateScenarioScriptGroup3Excel(FlatBufferBuilder builder,
      long GroupId = 0,
      long SelectionGroup = 0,
      long BGMId = 0,
      StringOffset SoundOffset = default(StringOffset),
      uint Transition = 0,
      uint BGName = 0,
      uint BGEffect = 0,
      StringOffset PopupFileNameOffset = default(StringOffset),
      StringOffset ScriptKrOffset = default(StringOffset),
      StringOffset TextJpOffset = default(StringOffset),
      StringOffset VoiceJpOffset = default(StringOffset)) {
    builder.StartTable(11);
    ScenarioScriptGroup3Excel.AddBGMId(builder, BGMId);
    ScenarioScriptGroup3Excel.AddSelectionGroup(builder, SelectionGroup);
    ScenarioScriptGroup3Excel.AddGroupId(builder, GroupId);
    ScenarioScriptGroup3Excel.AddVoiceJp(builder, VoiceJpOffset);
    ScenarioScriptGroup3Excel.AddTextJp(builder, TextJpOffset);
    ScenarioScriptGroup3Excel.AddScriptKr(builder, ScriptKrOffset);
    ScenarioScriptGroup3Excel.AddPopupFileName(builder, PopupFileNameOffset);
    ScenarioScriptGroup3Excel.AddBGEffect(builder, BGEffect);
    ScenarioScriptGroup3Excel.AddBGName(builder, BGName);
    ScenarioScriptGroup3Excel.AddTransition(builder, Transition);
    ScenarioScriptGroup3Excel.AddSound(builder, SoundOffset);
    return ScenarioScriptGroup3Excel.EndScenarioScriptGroup3Excel(builder);
  }

  public static void StartScenarioScriptGroup3Excel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddSelectionGroup(FlatBufferBuilder builder, long SelectionGroup) { builder.AddLong(1, SelectionGroup, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long BGMId) { builder.AddLong(2, BGMId, 0); }
  public static void AddSound(FlatBufferBuilder builder, StringOffset SoundOffset) { builder.AddOffset(3, SoundOffset.Value, 0); }
  public static void AddTransition(FlatBufferBuilder builder, uint Transition) { builder.AddUint(4, Transition, 0); }
  public static void AddBGName(FlatBufferBuilder builder, uint BGName) { builder.AddUint(5, BGName, 0); }
  public static void AddBGEffect(FlatBufferBuilder builder, uint BGEffect) { builder.AddUint(6, BGEffect, 0); }
  public static void AddPopupFileName(FlatBufferBuilder builder, StringOffset PopupFileNameOffset) { builder.AddOffset(7, PopupFileNameOffset.Value, 0); }
  public static void AddScriptKr(FlatBufferBuilder builder, StringOffset ScriptKrOffset) { builder.AddOffset(8, ScriptKrOffset.Value, 0); }
  public static void AddTextJp(FlatBufferBuilder builder, StringOffset TextJpOffset) { builder.AddOffset(9, TextJpOffset.Value, 0); }
  public static void AddVoiceJp(FlatBufferBuilder builder, StringOffset VoiceJpOffset) { builder.AddOffset(10, VoiceJpOffset.Value, 0); }
  public static Offset<FlatDataJp.ScenarioScriptGroup3Excel> EndScenarioScriptGroup3Excel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ScenarioScriptGroup3Excel>(o);
  }
}


}
