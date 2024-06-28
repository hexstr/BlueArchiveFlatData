// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AudioAnimatorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static AudioAnimatorExcel GetRootAsAudioAnimatorExcel(ByteBuffer _bb) { return GetRootAsAudioAnimatorExcel(_bb, new AudioAnimatorExcel()); }
  public static AudioAnimatorExcel GetRootAsAudioAnimatorExcel(ByteBuffer _bb, AudioAnimatorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioAnimatorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint ControllerNameHash { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string VoiceNamePrefix { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVoiceNamePrefixBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetVoiceNamePrefixBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetVoiceNamePrefixArray() { return __p.__vector_as_array<byte>(6); }
  public uint StateNameHash { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string StateName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStateNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStateNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStateNameArray() { return __p.__vector_as_array<byte>(10); }
  public bool IgnoreInterruptDelay { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IgnoreInterruptPlay { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Volume { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Delay { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int RandomPitchMin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RandomPitchMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AudioPriority { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AudioClipPath(int j) { int o = __p.__offset(26); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AudioClipPathLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public uint VoiceHash(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(28, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(28); }

  public static Offset<FlatDataJp.AudioAnimatorExcel> CreateAudioAnimatorExcel(FlatBufferBuilder builder,
      uint ControllerNameHash = 0,
      StringOffset VoiceNamePrefixOffset = default(StringOffset),
      uint StateNameHash = 0,
      StringOffset StateNameOffset = default(StringOffset),
      bool IgnoreInterruptDelay = false,
      bool IgnoreInterruptPlay = false,
      float Volume = 0.0f,
      float Delay = 0.0f,
      int RandomPitchMin = 0,
      int RandomPitchMax = 0,
      int AudioPriority = 0,
      VectorOffset AudioClipPathOffset = default(VectorOffset),
      VectorOffset VoiceHashOffset = default(VectorOffset)) {
    builder.StartTable(13);
    AudioAnimatorExcel.AddVoiceHash(builder, VoiceHashOffset);
    AudioAnimatorExcel.AddAudioClipPath(builder, AudioClipPathOffset);
    AudioAnimatorExcel.AddAudioPriority(builder, AudioPriority);
    AudioAnimatorExcel.AddRandomPitchMax(builder, RandomPitchMax);
    AudioAnimatorExcel.AddRandomPitchMin(builder, RandomPitchMin);
    AudioAnimatorExcel.AddDelay(builder, Delay);
    AudioAnimatorExcel.AddVolume(builder, Volume);
    AudioAnimatorExcel.AddStateName(builder, StateNameOffset);
    AudioAnimatorExcel.AddStateNameHash(builder, StateNameHash);
    AudioAnimatorExcel.AddVoiceNamePrefix(builder, VoiceNamePrefixOffset);
    AudioAnimatorExcel.AddControllerNameHash(builder, ControllerNameHash);
    AudioAnimatorExcel.AddIgnoreInterruptPlay(builder, IgnoreInterruptPlay);
    AudioAnimatorExcel.AddIgnoreInterruptDelay(builder, IgnoreInterruptDelay);
    return AudioAnimatorExcel.EndAudioAnimatorExcel(builder);
  }

  public static void StartAudioAnimatorExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddControllerNameHash(FlatBufferBuilder builder, uint ControllerNameHash) { builder.AddUint(0, ControllerNameHash, 0); }
  public static void AddVoiceNamePrefix(FlatBufferBuilder builder, StringOffset VoiceNamePrefixOffset) { builder.AddOffset(1, VoiceNamePrefixOffset.Value, 0); }
  public static void AddStateNameHash(FlatBufferBuilder builder, uint StateNameHash) { builder.AddUint(2, StateNameHash, 0); }
  public static void AddStateName(FlatBufferBuilder builder, StringOffset StateNameOffset) { builder.AddOffset(3, StateNameOffset.Value, 0); }
  public static void AddIgnoreInterruptDelay(FlatBufferBuilder builder, bool IgnoreInterruptDelay) { builder.AddBool(4, IgnoreInterruptDelay, false); }
  public static void AddIgnoreInterruptPlay(FlatBufferBuilder builder, bool IgnoreInterruptPlay) { builder.AddBool(5, IgnoreInterruptPlay, false); }
  public static void AddVolume(FlatBufferBuilder builder, float Volume) { builder.AddFloat(6, Volume, 0.0f); }
  public static void AddDelay(FlatBufferBuilder builder, float Delay) { builder.AddFloat(7, Delay, 0.0f); }
  public static void AddRandomPitchMin(FlatBufferBuilder builder, int RandomPitchMin) { builder.AddInt(8, RandomPitchMin, 0); }
  public static void AddRandomPitchMax(FlatBufferBuilder builder, int RandomPitchMax) { builder.AddInt(9, RandomPitchMax, 0); }
  public static void AddAudioPriority(FlatBufferBuilder builder, int AudioPriority) { builder.AddInt(10, AudioPriority, 0); }
  public static void AddAudioClipPath(FlatBufferBuilder builder, VectorOffset AudioClipPathOffset) { builder.AddOffset(11, AudioClipPathOffset.Value, 0); }
  public static VectorOffset CreateAudioClipPathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAudioClipPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset VoiceHashOffset) { builder.AddOffset(12, VoiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.AudioAnimatorExcel> EndAudioAnimatorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.AudioAnimatorExcel>(o);
  }
}


}
