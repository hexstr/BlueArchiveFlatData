// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct IdCardBackgroundExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static IdCardBackgroundExcel GetRootAsIdCardBackgroundExcel(ByteBuffer _bb) { return GetRootAsIdCardBackgroundExcel(_bb, new IdCardBackgroundExcel()); }
  public static IdCardBackgroundExcel GetRootAsIdCardBackgroundExcel(ByteBuffer _bb, IdCardBackgroundExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public IdCardBackgroundExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.Rarity Rarity { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Rarity.N; } }
  public long DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CollectionVisible { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsDefault { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string BgPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetBgPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetBgPathArray() { return __p.__vector_as_array<byte>(14); }
  public uint LocalizeEtcId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Icon { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataJp.IdCardBackgroundExcel> CreateIdCardBackgroundExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.Rarity Rarity = FlatDataJp.Rarity.N,
      long DisplayOrder = 0,
      bool CollectionVisible = false,
      bool IsDefault = false,
      StringOffset BgPathOffset = default(StringOffset),
      uint LocalizeEtcId = 0,
      StringOffset IconOffset = default(StringOffset)) {
    builder.StartTable(8);
    IdCardBackgroundExcel.AddDisplayOrder(builder, DisplayOrder);
    IdCardBackgroundExcel.AddId(builder, Id);
    IdCardBackgroundExcel.AddIcon(builder, IconOffset);
    IdCardBackgroundExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    IdCardBackgroundExcel.AddBgPath(builder, BgPathOffset);
    IdCardBackgroundExcel.AddRarity(builder, Rarity);
    IdCardBackgroundExcel.AddIsDefault(builder, IsDefault);
    IdCardBackgroundExcel.AddCollectionVisible(builder, CollectionVisible);
    return IdCardBackgroundExcel.EndIdCardBackgroundExcel(builder);
  }

  public static void StartIdCardBackgroundExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatDataJp.Rarity Rarity) { builder.AddInt(1, (int)Rarity, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(2, DisplayOrder, 0); }
  public static void AddCollectionVisible(FlatBufferBuilder builder, bool CollectionVisible) { builder.AddBool(3, CollectionVisible, false); }
  public static void AddIsDefault(FlatBufferBuilder builder, bool IsDefault) { builder.AddBool(4, IsDefault, false); }
  public static void AddBgPath(FlatBufferBuilder builder, StringOffset BgPathOffset) { builder.AddOffset(5, BgPathOffset.Value, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(6, LocalizeEtcId, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(7, IconOffset.Value, 0); }
  public static Offset<FlatDataJp.IdCardBackgroundExcel> EndIdCardBackgroundExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.IdCardBackgroundExcel>(o);
  }
}


}
