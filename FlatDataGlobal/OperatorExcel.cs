// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct OperatorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static OperatorExcel GetRootAsOperatorExcel(ByteBuffer _bb) { return GetRootAsOperatorExcel(_bb, new OperatorExcel()); }
  public static OperatorExcel GetRootAsOperatorExcel(ByteBuffer _bb, OperatorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OperatorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GroupId { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroupIdBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetGroupIdBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetGroupIdArray() { return __p.__vector_as_array<byte>(6); }
  public FlatDataGlobal.OperatorCondition OperatorCondition { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.OperatorCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.OperatorCondition.None; } }
  public int OutputSequence { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RandomWeight { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int OutputDelay { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Duration { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string PortraitPath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPortraitPathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetPortraitPathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetPortraitPathArray() { return __p.__vector_as_array<byte>(18); }
  public string TextLocalizeKey { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextLocalizeKeyBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetTextLocalizeKeyBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetTextLocalizeKeyArray() { return __p.__vector_as_array<byte>(20); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(24); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsTh(int j) { int o = __p.__offset(26); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsThLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsTw(int j) { int o = __p.__offset(28); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsTwLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsEn(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsEnLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.OperatorExcel> CreateOperatorExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset GroupIdOffset = default(StringOffset),
      FlatDataGlobal.OperatorCondition OperatorCondition = FlatDataGlobal.OperatorCondition.None,
      int OutputSequence = 0,
      int RandomWeight = 0,
      int OutputDelay = 0,
      int Duration = 0,
      StringOffset PortraitPathOffset = default(StringOffset),
      StringOffset TextLocalizeKeyOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset),
      VectorOffset VoiceClipsThOffset = default(VectorOffset),
      VectorOffset VoiceClipsTwOffset = default(VectorOffset),
      VectorOffset VoiceClipsEnOffset = default(VectorOffset)) {
    builder.StartTable(14);
    OperatorExcel.AddUniqueId(builder, UniqueId);
    OperatorExcel.AddVoiceClipsEn(builder, VoiceClipsEnOffset);
    OperatorExcel.AddVoiceClipsTw(builder, VoiceClipsTwOffset);
    OperatorExcel.AddVoiceClipsTh(builder, VoiceClipsThOffset);
    OperatorExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    OperatorExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    OperatorExcel.AddTextLocalizeKey(builder, TextLocalizeKeyOffset);
    OperatorExcel.AddPortraitPath(builder, PortraitPathOffset);
    OperatorExcel.AddDuration(builder, Duration);
    OperatorExcel.AddOutputDelay(builder, OutputDelay);
    OperatorExcel.AddRandomWeight(builder, RandomWeight);
    OperatorExcel.AddOutputSequence(builder, OutputSequence);
    OperatorExcel.AddOperatorCondition(builder, OperatorCondition);
    OperatorExcel.AddGroupId(builder, GroupIdOffset);
    return OperatorExcel.EndOperatorExcel(builder);
  }

  public static void StartOperatorExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, StringOffset GroupIdOffset) { builder.AddOffset(1, GroupIdOffset.Value, 0); }
  public static void AddOperatorCondition(FlatBufferBuilder builder, FlatDataGlobal.OperatorCondition OperatorCondition) { builder.AddInt(2, (int)OperatorCondition, 0); }
  public static void AddOutputSequence(FlatBufferBuilder builder, int OutputSequence) { builder.AddInt(3, OutputSequence, 0); }
  public static void AddRandomWeight(FlatBufferBuilder builder, int RandomWeight) { builder.AddInt(4, RandomWeight, 0); }
  public static void AddOutputDelay(FlatBufferBuilder builder, int OutputDelay) { builder.AddInt(5, OutputDelay, 0); }
  public static void AddDuration(FlatBufferBuilder builder, int Duration) { builder.AddInt(6, Duration, 0); }
  public static void AddPortraitPath(FlatBufferBuilder builder, StringOffset PortraitPathOffset) { builder.AddOffset(7, PortraitPathOffset.Value, 0); }
  public static void AddTextLocalizeKey(FlatBufferBuilder builder, StringOffset TextLocalizeKeyOffset) { builder.AddOffset(8, TextLocalizeKeyOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(9, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(10, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsTh(FlatBufferBuilder builder, VectorOffset VoiceClipsThOffset) { builder.AddOffset(11, VoiceClipsThOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsThVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsThVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsThVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsTw(FlatBufferBuilder builder, VectorOffset VoiceClipsTwOffset) { builder.AddOffset(12, VoiceClipsTwOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsTwVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsTwVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsTwVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsEn(FlatBufferBuilder builder, VectorOffset VoiceClipsEnOffset) { builder.AddOffset(13, VoiceClipsEnOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsEnVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsEnVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsEnVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.OperatorExcel> EndOperatorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.OperatorExcel>(o);
  }
}


}
