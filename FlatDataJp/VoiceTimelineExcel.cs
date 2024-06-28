// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct VoiceTimelineExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static VoiceTimelineExcel GetRootAsVoiceTimelineExcel(ByteBuffer _bb) { return GetRootAsVoiceTimelineExcel(_bb, new VoiceTimelineExcel()); }
  public static VoiceTimelineExcel GetRootAsVoiceTimelineExcel(ByteBuffer _bb, VoiceTimelineExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceTimelineExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.Nation Nation(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.Nation)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.Nation)0; }
  public int NationLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.Nation> GetNationBytes() { return __p.__vector_as_span<FlatDataJp.Nation>(8, 4); }
#else
  public ArraySegment<byte>? GetNationBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatDataJp.Nation[] GetNationArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.Nation[] a = new FlatDataJp.Nation[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.Nation)__p.bb.GetInt(p + i * 4); } return a; }
  public string Path(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PathLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public float SoundVolume(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SoundVolumeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSoundVolumeBytes() { return __p.__vector_as_span<float>(12, 4); }
#else
  public ArraySegment<byte>? GetSoundVolumeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public float[] GetSoundVolumeArray() { return __p.__vector_as_array<float>(12); }

  public static Offset<FlatDataJp.VoiceTimelineExcel> CreateVoiceTimelineExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      uint Id = 0,
      VectorOffset NationOffset = default(VectorOffset),
      VectorOffset PathOffset = default(VectorOffset),
      VectorOffset SoundVolumeOffset = default(VectorOffset)) {
    builder.StartTable(5);
    VoiceTimelineExcel.AddUniqueId(builder, UniqueId);
    VoiceTimelineExcel.AddSoundVolume(builder, SoundVolumeOffset);
    VoiceTimelineExcel.AddPath(builder, PathOffset);
    VoiceTimelineExcel.AddNation(builder, NationOffset);
    VoiceTimelineExcel.AddId(builder, Id);
    return VoiceTimelineExcel.EndVoiceTimelineExcel(builder);
  }

  public static void StartVoiceTimelineExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddId(FlatBufferBuilder builder, uint Id) { builder.AddUint(1, Id, 0); }
  public static void AddNation(FlatBufferBuilder builder, VectorOffset NationOffset) { builder.AddOffset(2, NationOffset.Value, 0); }
  public static VectorOffset CreateNationVector(FlatBufferBuilder builder, FlatDataJp.Nation[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNationVectorBlock(FlatBufferBuilder builder, FlatDataJp.Nation[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNationVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.Nation> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.Nation>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPath(FlatBufferBuilder builder, VectorOffset PathOffset) { builder.AddOffset(3, PathOffset.Value, 0); }
  public static VectorOffset CreatePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSoundVolume(FlatBufferBuilder builder, VectorOffset SoundVolumeOffset) { builder.AddOffset(4, SoundVolumeOffset.Value, 0); }
  public static VectorOffset CreateSoundVolumeVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSoundVolumeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.VoiceTimelineExcel> EndVoiceTimelineExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.VoiceTimelineExcel>(o);
  }
}


}
