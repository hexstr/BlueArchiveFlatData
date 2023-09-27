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
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentDiceRaceEffectExcel GetRootAsEventContentDiceRaceEffectExcel(ByteBuffer _bb) { return GetRootAsEventContentDiceRaceEffectExcel(_bb, new EventContentDiceRaceEffectExcel()); }
  public static EventContentDiceRaceEffectExcel GetRootAsEventContentDiceRaceEffectExcel(ByteBuffer _bb, EventContentDiceRaceEffectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDiceRaceEffectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.EventContentDiceRaceResultType Eventcontentdiceraceresulttype { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.EventContentDiceRaceResultType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentDiceRaceResultType.DiceResult1; } }
  public bool IsDiceResult { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string AniClip { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAniClipBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetAniClipBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetAniClipArray() { return __p.__vector_as_array<byte>(10); }
  public string VoiceClips(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel> CreateEventContentDiceRaceEffectExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataGlobal.EventContentDiceRaceResultType eventcontentdiceraceresulttype = FlatDataGlobal.EventContentDiceRaceResultType.DiceResult1,
      bool IsDiceResult = false,
      StringOffset AniClipOffset = default(StringOffset),
      VectorOffset VoiceClipsOffset = default(VectorOffset)) {
    builder.StartTable(5);
    EventContentDiceRaceEffectExcel.AddEventContentId(builder, EventContentId);
    EventContentDiceRaceEffectExcel.AddVoiceClips(builder, VoiceClipsOffset);
    EventContentDiceRaceEffectExcel.AddAniClip(builder, AniClipOffset);
    EventContentDiceRaceEffectExcel.AddEventcontentdiceraceresulttype(builder, eventcontentdiceraceresulttype);
    EventContentDiceRaceEffectExcel.AddIsDiceResult(builder, IsDiceResult);
    return EventContentDiceRaceEffectExcel.EndEventContentDiceRaceEffectExcel(builder);
  }

  public static void StartEventContentDiceRaceEffectExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddEventcontentdiceraceresulttype(FlatBufferBuilder builder, FlatDataGlobal.EventContentDiceRaceResultType eventcontentdiceraceresulttype) { builder.AddInt(1, (int)eventcontentdiceraceresulttype, 0); }
  public static void AddIsDiceResult(FlatBufferBuilder builder, bool IsDiceResult) { builder.AddBool(2, IsDiceResult, false); }
  public static void AddAniClip(FlatBufferBuilder builder, StringOffset AniClipOffset) { builder.AddOffset(3, AniClipOffset.Value, 0); }
  public static void AddVoiceClips(FlatBufferBuilder builder, VectorOffset VoiceClipsOffset) { builder.AddOffset(4, VoiceClipsOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel> EndEventContentDiceRaceEffectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentDiceRaceEffectExcel>(o);
  }
}


}
