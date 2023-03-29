// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopRefreshExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ShopRefreshExcel GetRootAsShopRefreshExcel(ByteBuffer _bb) { return GetRootAsShopRefreshExcel(_bb, new ShopRefreshExcel()); }
  public static ShopRefreshExcel GetRootAsShopRefreshExcel(ByteBuffer _bb, ShopRefreshExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopRefreshExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool IsLegacy { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GoodsId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ShopCategoryType CategoryType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ShopCategoryType.General; } }
  public int RefreshGroup { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BuyReportEventName { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuyReportEventNameBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetBuyReportEventNameBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetBuyReportEventNameArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<FlatDataGlobal.ShopRefreshExcel> CreateShopRefreshExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint LocalizeEtcId = 0,
      bool IsLegacy = false,
      long GoodsId = 0,
      long DisplayOrder = 0,
      FlatDataGlobal.ShopCategoryType CategoryType = FlatDataGlobal.ShopCategoryType.General,
      int RefreshGroup = 0,
      int Prob = 0,
      StringOffset BuyReportEventNameOffset = default(StringOffset)) {
    builder.StartTable(9);
    ShopRefreshExcel.AddDisplayOrder(builder, DisplayOrder);
    ShopRefreshExcel.AddGoodsId(builder, GoodsId);
    ShopRefreshExcel.AddId(builder, Id);
    ShopRefreshExcel.AddBuyReportEventName(builder, BuyReportEventNameOffset);
    ShopRefreshExcel.AddProb(builder, Prob);
    ShopRefreshExcel.AddRefreshGroup(builder, RefreshGroup);
    ShopRefreshExcel.AddCategoryType(builder, CategoryType);
    ShopRefreshExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    ShopRefreshExcel.AddIsLegacy(builder, IsLegacy);
    return ShopRefreshExcel.EndShopRefreshExcel(builder);
  }

  public static void StartShopRefreshExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool IsLegacy) { builder.AddBool(2, IsLegacy, false); }
  public static void AddGoodsId(FlatBufferBuilder builder, long GoodsId) { builder.AddLong(3, GoodsId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(4, DisplayOrder, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType CategoryType) { builder.AddInt(5, (int)CategoryType, 0); }
  public static void AddRefreshGroup(FlatBufferBuilder builder, int RefreshGroup) { builder.AddInt(6, RefreshGroup, 0); }
  public static void AddProb(FlatBufferBuilder builder, int Prob) { builder.AddInt(7, Prob, 0); }
  public static void AddBuyReportEventName(FlatBufferBuilder builder, StringOffset BuyReportEventNameOffset) { builder.AddOffset(8, BuyReportEventNameOffset.Value, 0); }
  public static Offset<FlatDataGlobal.ShopRefreshExcel> EndShopRefreshExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ShopRefreshExcel>(o);
  }
}


}
