// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CheatCodeListExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CheatCodeListExcel GetRootAsCheatCodeListExcel(ByteBuffer _bb) { return GetRootAsCheatCodeListExcel(_bb, new CheatCodeListExcel()); }
  public static CheatCodeListExcel GetRootAsCheatCodeListExcel(ByteBuffer _bb, CheatCodeListExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CheatCodeListExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string CheatCode(int j) { int o = __p.__offset(4); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CheatCodeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string InputTitle(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int InputTitleLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Desc { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<FlatDataGlobal.CheatCodeListExcel> CreateCheatCodeListExcel(FlatBufferBuilder builder,
      VectorOffset CheatCodeOffset = default(VectorOffset),
      VectorOffset InputTitleOffset = default(VectorOffset),
      StringOffset DescOffset = default(StringOffset)) {
    builder.StartTable(3);
    CheatCodeListExcel.AddDesc(builder, DescOffset);
    CheatCodeListExcel.AddInputTitle(builder, InputTitleOffset);
    CheatCodeListExcel.AddCheatCode(builder, CheatCodeOffset);
    return CheatCodeListExcel.EndCheatCodeListExcel(builder);
  }

  public static void StartCheatCodeListExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddCheatCode(FlatBufferBuilder builder, VectorOffset CheatCodeOffset) { builder.AddOffset(0, CheatCodeOffset.Value, 0); }
  public static VectorOffset CreateCheatCodeVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCheatCodeVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCheatCodeVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCheatCodeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCheatCodeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInputTitle(FlatBufferBuilder builder, VectorOffset InputTitleOffset) { builder.AddOffset(1, InputTitleOffset.Value, 0); }
  public static VectorOffset CreateInputTitleVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateInputTitleVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInputTitleVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInputTitleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInputTitleVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset DescOffset) { builder.AddOffset(2, DescOffset.Value, 0); }
  public static Offset<FlatDataGlobal.CheatCodeListExcel> EndCheatCodeListExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CheatCodeListExcel>(o);
  }
}


}
