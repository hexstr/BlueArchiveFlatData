// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestProgressResourceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConquestProgressResourceExcel GetRootAsConquestProgressResourceExcel(ByteBuffer _bb) { return GetRootAsConquestProgressResourceExcel(_bb, new ConquestProgressResourceExcel()); }
  public static ConquestProgressResourceExcel GetRootAsConquestProgressResourceExcel(ByteBuffer _bb, ConquestProgressResourceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestProgressResourceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ConquestProgressType Group { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ConquestProgressType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ConquestProgressType.None; } }
  public string ProgressResource { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressResourceBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetProgressResourceBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetProgressResourceArray() { return __p.__vector_as_array<byte>(10); }
  public string Voice(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ProgressLocalizeCode { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressLocalizeCodeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetProgressLocalizeCodeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetProgressLocalizeCodeArray() { return __p.__vector_as_array<byte>(14); }
  public string ProgressTime { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressTimeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetProgressTimeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetProgressTimeArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatDataJp.ConquestProgressResourceExcel> CreateConquestProgressResourceExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      FlatDataJp.ConquestProgressType Group = FlatDataJp.ConquestProgressType.None,
      StringOffset ProgressResourceOffset = default(StringOffset),
      VectorOffset VoiceOffset = default(VectorOffset),
      StringOffset ProgressLocalizeCodeOffset = default(StringOffset),
      StringOffset ProgressTimeOffset = default(StringOffset)) {
    builder.StartTable(7);
    ConquestProgressResourceExcel.AddEventContentId(builder, EventContentId);
    ConquestProgressResourceExcel.AddId(builder, Id);
    ConquestProgressResourceExcel.AddProgressTime(builder, ProgressTimeOffset);
    ConquestProgressResourceExcel.AddProgressLocalizeCode(builder, ProgressLocalizeCodeOffset);
    ConquestProgressResourceExcel.AddVoice(builder, VoiceOffset);
    ConquestProgressResourceExcel.AddProgressResource(builder, ProgressResourceOffset);
    ConquestProgressResourceExcel.AddGroup(builder, Group);
    return ConquestProgressResourceExcel.EndConquestProgressResourceExcel(builder);
  }

  public static void StartConquestProgressResourceExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddGroup(FlatBufferBuilder builder, FlatDataJp.ConquestProgressType Group) { builder.AddInt(2, (int)Group, 0); }
  public static void AddProgressResource(FlatBufferBuilder builder, StringOffset ProgressResourceOffset) { builder.AddOffset(3, ProgressResourceOffset.Value, 0); }
  public static void AddVoice(FlatBufferBuilder builder, VectorOffset VoiceOffset) { builder.AddOffset(4, VoiceOffset.Value, 0); }
  public static VectorOffset CreateVoiceVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddProgressLocalizeCode(FlatBufferBuilder builder, StringOffset ProgressLocalizeCodeOffset) { builder.AddOffset(5, ProgressLocalizeCodeOffset.Value, 0); }
  public static void AddProgressTime(FlatBufferBuilder builder, StringOffset ProgressTimeOffset) { builder.AddOffset(6, ProgressTimeOffset.Value, 0); }
  public static Offset<FlatDataJp.ConquestProgressResourceExcel> EndConquestProgressResourceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConquestProgressResourceExcel>(o);
  }
}


}
