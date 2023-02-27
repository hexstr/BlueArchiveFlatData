// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct VoiceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static VoiceExcel GetRootAsVoiceExcel(ByteBuffer _bb) { return GetRootAsVoiceExcel(_bb, new VoiceExcel()); }
  public static VoiceExcel GetRootAsVoiceExcel(ByteBuffer _bb, VoiceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint NameHash { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool OnlyOne { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float VolumeJp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayJp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int Priority { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AudioClipJp { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipJpBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetAudioClipJpBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetAudioClipJpArray() { return __p.__vector_as_array<byte>(14); }
  public float VolumeKr { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayKr { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string AudioClipKr { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipKrBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetAudioClipKrBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetAudioClipKrArray() { return __p.__vector_as_array<byte>(20); }
  public float VolumeTh { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayTh { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string AudioClipTh { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipThBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetAudioClipThBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetAudioClipThArray() { return __p.__vector_as_array<byte>(26); }
  public float VolumeTw { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayTw { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string AudioClipTw { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipTwBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetAudioClipTwBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetAudioClipTwArray() { return __p.__vector_as_array<byte>(32); }
  public float VolumeEn { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayEn { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string AudioClipEn { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipEnBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetAudioClipEnBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetAudioClipEnArray() { return __p.__vector_as_array<byte>(38); }

  public static Offset<FlatDataGlobal.VoiceExcel> CreateVoiceExcel(FlatBufferBuilder builder,
      uint NameHash = 0,
      bool OnlyOne = false,
      float VolumeJp = 0.0f,
      float DelayJp = 0.0f,
      int Priority = 0,
      StringOffset AudioClipJpOffset = default(StringOffset),
      float VolumeKr = 0.0f,
      float DelayKr = 0.0f,
      StringOffset AudioClipKrOffset = default(StringOffset),
      float VolumeTh = 0.0f,
      float DelayTh = 0.0f,
      StringOffset AudioClipThOffset = default(StringOffset),
      float VolumeTw = 0.0f,
      float DelayTw = 0.0f,
      StringOffset AudioClipTwOffset = default(StringOffset),
      float VolumeEn = 0.0f,
      float DelayEn = 0.0f,
      StringOffset AudioClipEnOffset = default(StringOffset)) {
    builder.StartTable(18);
    VoiceExcel.AddAudioClipEn(builder, AudioClipEnOffset);
    VoiceExcel.AddDelayEn(builder, DelayEn);
    VoiceExcel.AddVolumeEn(builder, VolumeEn);
    VoiceExcel.AddAudioClipTw(builder, AudioClipTwOffset);
    VoiceExcel.AddDelayTw(builder, DelayTw);
    VoiceExcel.AddVolumeTw(builder, VolumeTw);
    VoiceExcel.AddAudioClipTh(builder, AudioClipThOffset);
    VoiceExcel.AddDelayTh(builder, DelayTh);
    VoiceExcel.AddVolumeTh(builder, VolumeTh);
    VoiceExcel.AddAudioClipKr(builder, AudioClipKrOffset);
    VoiceExcel.AddDelayKr(builder, DelayKr);
    VoiceExcel.AddVolumeKr(builder, VolumeKr);
    VoiceExcel.AddAudioClipJp(builder, AudioClipJpOffset);
    VoiceExcel.AddPriority(builder, Priority);
    VoiceExcel.AddDelayJp(builder, DelayJp);
    VoiceExcel.AddVolumeJp(builder, VolumeJp);
    VoiceExcel.AddNameHash(builder, NameHash);
    VoiceExcel.AddOnlyOne(builder, OnlyOne);
    return VoiceExcel.EndVoiceExcel(builder);
  }

  public static void StartVoiceExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddNameHash(FlatBufferBuilder builder, uint NameHash) { builder.AddUint(0, NameHash, 0); }
  public static void AddOnlyOne(FlatBufferBuilder builder, bool OnlyOne) { builder.AddBool(1, OnlyOne, false); }
  public static void AddVolumeJp(FlatBufferBuilder builder, float VolumeJp) { builder.AddFloat(2, VolumeJp, 0.0f); }
  public static void AddDelayJp(FlatBufferBuilder builder, float DelayJp) { builder.AddFloat(3, DelayJp, 0.0f); }
  public static void AddPriority(FlatBufferBuilder builder, int Priority) { builder.AddInt(4, Priority, 0); }
  public static void AddAudioClipJp(FlatBufferBuilder builder, StringOffset AudioClipJpOffset) { builder.AddOffset(5, AudioClipJpOffset.Value, 0); }
  public static void AddVolumeKr(FlatBufferBuilder builder, float VolumeKr) { builder.AddFloat(6, VolumeKr, 0.0f); }
  public static void AddDelayKr(FlatBufferBuilder builder, float DelayKr) { builder.AddFloat(7, DelayKr, 0.0f); }
  public static void AddAudioClipKr(FlatBufferBuilder builder, StringOffset AudioClipKrOffset) { builder.AddOffset(8, AudioClipKrOffset.Value, 0); }
  public static void AddVolumeTh(FlatBufferBuilder builder, float VolumeTh) { builder.AddFloat(9, VolumeTh, 0.0f); }
  public static void AddDelayTh(FlatBufferBuilder builder, float DelayTh) { builder.AddFloat(10, DelayTh, 0.0f); }
  public static void AddAudioClipTh(FlatBufferBuilder builder, StringOffset AudioClipThOffset) { builder.AddOffset(11, AudioClipThOffset.Value, 0); }
  public static void AddVolumeTw(FlatBufferBuilder builder, float VolumeTw) { builder.AddFloat(12, VolumeTw, 0.0f); }
  public static void AddDelayTw(FlatBufferBuilder builder, float DelayTw) { builder.AddFloat(13, DelayTw, 0.0f); }
  public static void AddAudioClipTw(FlatBufferBuilder builder, StringOffset AudioClipTwOffset) { builder.AddOffset(14, AudioClipTwOffset.Value, 0); }
  public static void AddVolumeEn(FlatBufferBuilder builder, float VolumeEn) { builder.AddFloat(15, VolumeEn, 0.0f); }
  public static void AddDelayEn(FlatBufferBuilder builder, float DelayEn) { builder.AddFloat(16, DelayEn, 0.0f); }
  public static void AddAudioClipEn(FlatBufferBuilder builder, StringOffset AudioClipEnOffset) { builder.AddOffset(17, AudioClipEnOffset.Value, 0); }
  public static Offset<FlatDataGlobal.VoiceExcel> EndVoiceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.VoiceExcel>(o);
  }
}


}
