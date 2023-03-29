// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ShopExcel GetRootAsShopExcel(ByteBuffer _bb) { return GetRootAsShopExcel(_bb, new ShopExcel()); }
  public static ShopExcel GetRootAsShopExcel(ByteBuffer _bb, ShopExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.ShopCategoryType CategoryType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ShopCategoryType.General; } }
  public bool IsLegacy { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GoodsId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GoodsIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGoodsIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetGoodsIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetGoodsIdArray() { return __p.__vector_as_array<long>(12); }
  public long DisplayOrder { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SalePeriodFrom { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSalePeriodFromBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetSalePeriodFromBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetSalePeriodFromArray() { return __p.__vector_as_array<byte>(16); }
  public string SalePeriodTo { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSalePeriodToBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSalePeriodToBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSalePeriodToArray() { return __p.__vector_as_array<byte>(18); }
  public long PurchaseCooltimeMin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PurchaseCountLimit { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.PurchaseCountResetType PurchaseCountResetType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataJp.PurchaseCountResetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.PurchaseCountResetType.None; } }
  public string BuyReportEventName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuyReportEventNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetBuyReportEventNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetBuyReportEventNameArray() { return __p.__vector_as_array<byte>(26); }
  public bool RestrictBuyWhenInventoryFull { get { int o = __p.__offset(28); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.ShopExcel> CreateShopExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint LocalizeEtcId = 0,
      FlatDataJp.ShopCategoryType CategoryType = FlatDataJp.ShopCategoryType.General,
      bool IsLegacy = false,
      VectorOffset GoodsIdOffset = default(VectorOffset),
      long DisplayOrder = 0,
      StringOffset SalePeriodFromOffset = default(StringOffset),
      StringOffset SalePeriodToOffset = default(StringOffset),
      long PurchaseCooltimeMin = 0,
      long PurchaseCountLimit = 0,
      FlatDataJp.PurchaseCountResetType PurchaseCountResetType = FlatDataJp.PurchaseCountResetType.None,
      StringOffset BuyReportEventNameOffset = default(StringOffset),
      bool RestrictBuyWhenInventoryFull = false) {
    builder.StartTable(13);
    ShopExcel.AddPurchaseCountLimit(builder, PurchaseCountLimit);
    ShopExcel.AddPurchaseCooltimeMin(builder, PurchaseCooltimeMin);
    ShopExcel.AddDisplayOrder(builder, DisplayOrder);
    ShopExcel.AddId(builder, Id);
    ShopExcel.AddBuyReportEventName(builder, BuyReportEventNameOffset);
    ShopExcel.AddPurchaseCountResetType(builder, PurchaseCountResetType);
    ShopExcel.AddSalePeriodTo(builder, SalePeriodToOffset);
    ShopExcel.AddSalePeriodFrom(builder, SalePeriodFromOffset);
    ShopExcel.AddGoodsId(builder, GoodsIdOffset);
    ShopExcel.AddCategoryType(builder, CategoryType);
    ShopExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    ShopExcel.AddRestrictBuyWhenInventoryFull(builder, RestrictBuyWhenInventoryFull);
    ShopExcel.AddIsLegacy(builder, IsLegacy);
    return ShopExcel.EndShopExcel(builder);
  }

  public static void StartShopExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatDataJp.ShopCategoryType CategoryType) { builder.AddInt(2, (int)CategoryType, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool IsLegacy) { builder.AddBool(3, IsLegacy, false); }
  public static void AddGoodsId(FlatBufferBuilder builder, VectorOffset GoodsIdOffset) { builder.AddOffset(4, GoodsIdOffset.Value, 0); }
  public static VectorOffset CreateGoodsIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGoodsIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(5, DisplayOrder, 0); }
  public static void AddSalePeriodFrom(FlatBufferBuilder builder, StringOffset SalePeriodFromOffset) { builder.AddOffset(6, SalePeriodFromOffset.Value, 0); }
  public static void AddSalePeriodTo(FlatBufferBuilder builder, StringOffset SalePeriodToOffset) { builder.AddOffset(7, SalePeriodToOffset.Value, 0); }
  public static void AddPurchaseCooltimeMin(FlatBufferBuilder builder, long PurchaseCooltimeMin) { builder.AddLong(8, PurchaseCooltimeMin, 0); }
  public static void AddPurchaseCountLimit(FlatBufferBuilder builder, long PurchaseCountLimit) { builder.AddLong(9, PurchaseCountLimit, 0); }
  public static void AddPurchaseCountResetType(FlatBufferBuilder builder, FlatDataJp.PurchaseCountResetType PurchaseCountResetType) { builder.AddInt(10, (int)PurchaseCountResetType, 0); }
  public static void AddBuyReportEventName(FlatBufferBuilder builder, StringOffset BuyReportEventNameOffset) { builder.AddOffset(11, BuyReportEventNameOffset.Value, 0); }
  public static void AddRestrictBuyWhenInventoryFull(FlatBufferBuilder builder, bool RestrictBuyWhenInventoryFull) { builder.AddBool(12, RestrictBuyWhenInventoryFull, false); }
  public static Offset<FlatDataJp.ShopExcel> EndShopExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ShopExcel>(o);
  }
}


}
