// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentDiceRaceEffectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentDiceRaceEffectExcel GetRootAsEventContentDiceRaceEffectExcel(ByteBuffer _bb) { return GetRootAsEventContentDiceRaceEffectExcel(_bb, new EventContentDiceRaceEffectExcel()); }
  public static EventContentDiceRaceEffectExcel GetRootAsEventContentDiceRaceEffectExcel(ByteBuffer _bb, EventContentDiceRaceEffectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDiceRaceEffectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.EventContentDiceRaceResultType EventContentDiceRaceResultType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.EventContentDiceRaceResultType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentDiceRaceResultType.DiceResult1; } }
  public string EffectPrefabPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectPrefabPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetEffectPrefabPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetEffectPrefabPathArray() { return __p.__vector_as_array<byte>(8); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel> CreateEventContentDiceRaceEffectExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataGlobal.EventContentDiceRaceResultType EventContentDiceRaceResultType = FlatDataGlobal.EventContentDiceRaceResultType.DiceResult1,
      StringOffset EffectPrefabPathOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset)) {
    builder.StartTable(5);
    EventContentDiceRaceEffectExcel.AddEventContentId(builder, EventContentId);
    EventContentDiceRaceEffectExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    EventContentDiceRaceEffectExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    EventContentDiceRaceEffectExcel.AddEffectPrefabPath(builder, EffectPrefabPathOffset);
    EventContentDiceRaceEffectExcel.AddEventContentDiceRaceResultType(builder, EventContentDiceRaceResultType);
    return EventContentDiceRaceEffectExcel.EndEventContentDiceRaceEffectExcel(builder);
  }

  public static void StartEventContentDiceRaceEffectExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddEventContentDiceRaceResultType(FlatBufferBuilder builder, FlatDataGlobal.EventContentDiceRaceResultType EventContentDiceRaceResultType) { builder.AddInt(1, (int)EventContentDiceRaceResultType, 0); }
  public static void AddEffectPrefabPath(FlatBufferBuilder builder, StringOffset EffectPrefabPathOffset) { builder.AddOffset(2, EffectPrefabPathOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(3, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(4, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel> EndEventContentDiceRaceEffectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel>(o);
  }
}


}
