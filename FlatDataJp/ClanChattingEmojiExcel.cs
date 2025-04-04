// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ClanChattingEmojiExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ClanChattingEmojiExcel GetRootAsClanChattingEmojiExcel(ByteBuffer _bb) { return GetRootAsClanChattingEmojiExcel(_bb, new ClanChattingEmojiExcel()); }
  public static ClanChattingEmojiExcel GetRootAsClanChattingEmojiExcel(ByteBuffer _bb, ClanChattingEmojiExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanChattingEmojiExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TabGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
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

  public static Offset<FlatDataJp.ClanChattingEmojiExcel> CreateClanChattingEmojiExcel(FlatBufferBuilder builder,
      long Id = 0,
      int TabGroupId = 0,
      int DisplayOrder = 0,
      StringOffset ImagePathKrOffset = default(StringOffset),
      StringOffset ImagePathJpOffset = default(StringOffset)) {
    builder.StartTable(5);
    ClanChattingEmojiExcel.AddId(builder, Id);
    ClanChattingEmojiExcel.AddImagePathJp(builder, ImagePathJpOffset);
    ClanChattingEmojiExcel.AddImagePathKr(builder, ImagePathKrOffset);
    ClanChattingEmojiExcel.AddDisplayOrder(builder, DisplayOrder);
    ClanChattingEmojiExcel.AddTabGroupId(builder, TabGroupId);
    return ClanChattingEmojiExcel.EndClanChattingEmojiExcel(builder);
  }

  public static void StartClanChattingEmojiExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddTabGroupId(FlatBufferBuilder builder, int TabGroupId) { builder.AddInt(1, TabGroupId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int DisplayOrder) { builder.AddInt(2, DisplayOrder, 0); }
  public static void AddImagePathKr(FlatBufferBuilder builder, StringOffset ImagePathKrOffset) { builder.AddOffset(3, ImagePathKrOffset.Value, 0); }
  public static void AddImagePathJp(FlatBufferBuilder builder, StringOffset ImagePathJpOffset) { builder.AddOffset(4, ImagePathJpOffset.Value, 0); }
  public static Offset<FlatDataJp.ClanChattingEmojiExcel> EndClanChattingEmojiExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ClanChattingEmojiExcel>(o);
  }
}


}
