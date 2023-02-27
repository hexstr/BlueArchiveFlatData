// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct StringTestExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static StringTestExcel GetRootAsStringTestExcel(ByteBuffer _bb) { return GetRootAsStringTestExcel(_bb, new StringTestExcel()); }
  public static StringTestExcel GetRootAsStringTestExcel(ByteBuffer _bb, StringTestExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StringTestExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string String(int j) { int o = __p.__offset(4); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int StringLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Sentence1 { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSentence1Bytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSentence1Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSentence1Array() { return __p.__vector_as_array<byte>(6); }
  public string Script { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetScriptBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetScriptBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetScriptArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<FlatDataJp.StringTestExcel> CreateStringTestExcel(FlatBufferBuilder builder,
      VectorOffset StringOffset = default(VectorOffset),
      StringOffset Sentence1Offset = default(StringOffset),
      StringOffset ScriptOffset = default(StringOffset)) {
    builder.StartTable(3);
    StringTestExcel.AddScript(builder, ScriptOffset);
    StringTestExcel.AddSentence1(builder, Sentence1Offset);
    StringTestExcel.AddString(builder, StringOffset);
    return StringTestExcel.EndStringTestExcel(builder);
  }

  public static void StartStringTestExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddString(FlatBufferBuilder builder, VectorOffset StringOffset) { builder.AddOffset(0, StringOffset.Value, 0); }
  public static VectorOffset CreateStringVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateStringVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStringVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStringVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStringVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSentence1(FlatBufferBuilder builder, StringOffset Sentence1Offset) { builder.AddOffset(1, Sentence1Offset.Value, 0); }
  public static void AddScript(FlatBufferBuilder builder, StringOffset ScriptOffset) { builder.AddOffset(2, ScriptOffset.Value, 0); }
  public static Offset<FlatDataJp.StringTestExcel> EndStringTestExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.StringTestExcel>(o);
  }
}


}
