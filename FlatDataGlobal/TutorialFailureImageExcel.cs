// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TutorialFailureImageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static TutorialFailureImageExcel GetRootAsTutorialFailureImageExcel(ByteBuffer _bb) { return GetRootAsTutorialFailureImageExcel(_bb, new TutorialFailureImageExcel()); }
  public static TutorialFailureImageExcel GetRootAsTutorialFailureImageExcel(ByteBuffer _bb, TutorialFailureImageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TutorialFailureImageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TutorialFailureContentType Contents { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.TutorialFailureContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TutorialFailureContentType.None; } }
  public string Type { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTypeArray() { return __p.__vector_as_array<byte>(8); }
  public string ImagePathKr { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathKrBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImagePathKrBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImagePathKrArray() { return __p.__vector_as_array<byte>(10); }
  public string ImagePathJp { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathJpBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetImagePathJpBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetImagePathJpArray() { return __p.__vector_as_array<byte>(12); }
  public string ImagePathTh { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathThBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetImagePathThBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetImagePathThArray() { return __p.__vector_as_array<byte>(14); }
  public string ImagePathTw { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathTwBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetImagePathTwBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetImagePathTwArray() { return __p.__vector_as_array<byte>(16); }
  public string ImagePathEn { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathEnBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetImagePathEnBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetImagePathEnArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataGlobal.TutorialFailureImageExcel> CreateTutorialFailureImageExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.TutorialFailureContentType Contents = FlatDataGlobal.TutorialFailureContentType.None,
      StringOffset TypeOffset = default(StringOffset),
      StringOffset ImagePathKrOffset = default(StringOffset),
      StringOffset ImagePathJpOffset = default(StringOffset),
      StringOffset ImagePathThOffset = default(StringOffset),
      StringOffset ImagePathTwOffset = default(StringOffset),
      StringOffset ImagePathEnOffset = default(StringOffset)) {
    builder.StartTable(8);
    TutorialFailureImageExcel.AddId(builder, Id);
    TutorialFailureImageExcel.AddImagePathEn(builder, ImagePathEnOffset);
    TutorialFailureImageExcel.AddImagePathTw(builder, ImagePathTwOffset);
    TutorialFailureImageExcel.AddImagePathTh(builder, ImagePathThOffset);
    TutorialFailureImageExcel.AddImagePathJp(builder, ImagePathJpOffset);
    TutorialFailureImageExcel.AddImagePathKr(builder, ImagePathKrOffset);
    TutorialFailureImageExcel.AddType(builder, TypeOffset);
    TutorialFailureImageExcel.AddContents(builder, Contents);
    return TutorialFailureImageExcel.EndTutorialFailureImageExcel(builder);
  }

  public static void StartTutorialFailureImageExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddContents(FlatBufferBuilder builder, FlatDataGlobal.TutorialFailureContentType Contents) { builder.AddInt(1, (int)Contents, 0); }
  public static void AddType(FlatBufferBuilder builder, StringOffset TypeOffset) { builder.AddOffset(2, TypeOffset.Value, 0); }
  public static void AddImagePathKr(FlatBufferBuilder builder, StringOffset ImagePathKrOffset) { builder.AddOffset(3, ImagePathKrOffset.Value, 0); }
  public static void AddImagePathJp(FlatBufferBuilder builder, StringOffset ImagePathJpOffset) { builder.AddOffset(4, ImagePathJpOffset.Value, 0); }
  public static void AddImagePathTh(FlatBufferBuilder builder, StringOffset ImagePathThOffset) { builder.AddOffset(5, ImagePathThOffset.Value, 0); }
  public static void AddImagePathTw(FlatBufferBuilder builder, StringOffset ImagePathTwOffset) { builder.AddOffset(6, ImagePathTwOffset.Value, 0); }
  public static void AddImagePathEn(FlatBufferBuilder builder, StringOffset ImagePathEnOffset) { builder.AddOffset(7, ImagePathEnOffset.Value, 0); }
  public static Offset<FlatDataGlobal.TutorialFailureImageExcel> EndTutorialFailureImageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.TutorialFailureImageExcel>(o);
  }
}


}
