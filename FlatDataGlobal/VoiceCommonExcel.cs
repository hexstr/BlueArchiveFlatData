// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct VoiceCommonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static VoiceCommonExcel GetRootAsVoiceCommonExcel(ByteBuffer _bb) { return GetRootAsVoiceCommonExcel(_bb, new VoiceCommonExcel()); }
  public static VoiceCommonExcel GetRootAsVoiceCommonExcel(ByteBuffer _bb, VoiceCommonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceCommonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.VoiceEvent VoiceEvent { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.VoiceEvent.OnTSA; } }
  public long Rate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint VoiceHash(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(8, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(8); }

  public static Offset<FlatDataGlobal.VoiceCommonExcel> CreateVoiceCommonExcel(FlatBufferBuilder builder,
      FlatDataGlobal.VoiceEvent voiceEvent = FlatDataGlobal.VoiceEvent.OnTSA,
      long Rate = 0,
      VectorOffset VoiceHashOffset = default(VectorOffset)) {
    builder.StartTable(3);
    VoiceCommonExcel.AddRate(builder, Rate);
    VoiceCommonExcel.AddVoiceHash(builder, VoiceHashOffset);
    VoiceCommonExcel.AddVoiceEvent(builder, voiceEvent);
    return VoiceCommonExcel.EndVoiceCommonExcel(builder);
  }

  public static void StartVoiceCommonExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddVoiceEvent(FlatBufferBuilder builder, FlatDataGlobal.VoiceEvent voiceEvent) { builder.AddInt(0, (int)voiceEvent, 0); }
  public static void AddRate(FlatBufferBuilder builder, long Rate) { builder.AddLong(1, Rate, 0); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset VoiceHashOffset) { builder.AddOffset(2, VoiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.VoiceCommonExcel> EndVoiceCommonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.VoiceCommonExcel>(o);
  }
}


}
