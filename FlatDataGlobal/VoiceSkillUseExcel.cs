// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct VoiceSkillUseExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static VoiceSkillUseExcel GetRootAsVoiceSkillUseExcel(ByteBuffer _bb) { return GetRootAsVoiceSkillUseExcel(_bb, new VoiceSkillUseExcel()); }
  public static VoiceSkillUseExcel GetRootAsVoiceSkillUseExcel(ByteBuffer _bb, VoiceSkillUseExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceSkillUseExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public uint VoiceHash(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(6, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(6); }

  public static Offset<FlatDataGlobal.VoiceSkillUseExcel> CreateVoiceSkillUseExcel(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      VectorOffset VoiceHashOffset = default(VectorOffset)) {
    builder.StartTable(2);
    VoiceSkillUseExcel.AddVoiceHash(builder, VoiceHashOffset);
    VoiceSkillUseExcel.AddName(builder, NameOffset);
    return VoiceSkillUseExcel.EndVoiceSkillUseExcel(builder);
  }

  public static void StartVoiceSkillUseExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(0, NameOffset.Value, 0); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset VoiceHashOffset) { builder.AddOffset(1, VoiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.VoiceSkillUseExcel> EndVoiceSkillUseExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.VoiceSkillUseExcel>(o);
  }
}


}
