// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioScriptExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ScenarioScriptExcel GetRootAsScenarioScriptExcel(ByteBuffer _bb) { return GetRootAsScenarioScriptExcel(_bb, new ScenarioScriptExcel()); }
  public static ScenarioScriptExcel GetRootAsScenarioScriptExcel(ByteBuffer _bb, ScenarioScriptExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioScriptExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public string TextTh { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextThBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetTextThBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetTextThArray() { return __p.__vector_as_array<byte>(24); }
  public string TextTw { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextTwBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetTextTwBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetTextTwArray() { return __p.__vector_as_array<byte>(26); }
  public string TextEn { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextEnBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetTextEnBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetTextEnArray() { return __p.__vector_as_array<byte>(28); }
  public uint VoiceId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool TeenMode { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.ScenarioScriptExcel> CreateScenarioScriptExcel(FlatBufferBuilder builder,
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
      StringOffset TextThOffset = default(StringOffset),
      StringOffset TextTwOffset = default(StringOffset),
      StringOffset TextEnOffset = default(StringOffset),
      uint VoiceId = 0,
      bool TeenMode = false) {
    builder.StartTable(15);
    ScenarioScriptExcel.AddBGMId(builder, BGMId);
    ScenarioScriptExcel.AddSelectionGroup(builder, SelectionGroup);
    ScenarioScriptExcel.AddGroupId(builder, GroupId);
    ScenarioScriptExcel.AddVoiceId(builder, VoiceId);
    ScenarioScriptExcel.AddTextEn(builder, TextEnOffset);
    ScenarioScriptExcel.AddTextTw(builder, TextTwOffset);
    ScenarioScriptExcel.AddTextTh(builder, TextThOffset);
    ScenarioScriptExcel.AddTextJp(builder, TextJpOffset);
    ScenarioScriptExcel.AddScriptKr(builder, ScriptKrOffset);
    ScenarioScriptExcel.AddPopupFileName(builder, PopupFileNameOffset);
    ScenarioScriptExcel.AddBGEffect(builder, BGEffect);
    ScenarioScriptExcel.AddBGName(builder, BGName);
    ScenarioScriptExcel.AddTransition(builder, Transition);
    ScenarioScriptExcel.AddSound(builder, SoundOffset);
    ScenarioScriptExcel.AddTeenMode(builder, TeenMode);
    return ScenarioScriptExcel.EndScenarioScriptExcel(builder);
  }

  public static void StartScenarioScriptExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
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
  public static void AddTextTh(FlatBufferBuilder builder, StringOffset TextThOffset) { builder.AddOffset(10, TextThOffset.Value, 0); }
  public static void AddTextTw(FlatBufferBuilder builder, StringOffset TextTwOffset) { builder.AddOffset(11, TextTwOffset.Value, 0); }
  public static void AddTextEn(FlatBufferBuilder builder, StringOffset TextEnOffset) { builder.AddOffset(12, TextEnOffset.Value, 0); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint VoiceId) { builder.AddUint(13, VoiceId, 0); }
  public static void AddTeenMode(FlatBufferBuilder builder, bool TeenMode) { builder.AddBool(14, TeenMode, false); }
  public static Offset<FlatDataGlobal.ScenarioScriptExcel> EndScenarioScriptExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ScenarioScriptExcel>(o);
  }
}


}
