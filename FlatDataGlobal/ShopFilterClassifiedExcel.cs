// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopFilterClassifiedExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ShopFilterClassifiedExcel GetRootAsShopFilterClassifiedExcel(ByteBuffer _bb) { return GetRootAsShopFilterClassifiedExcel(_bb, new ShopFilterClassifiedExcel()); }
  public static ShopFilterClassifiedExcel GetRootAsShopFilterClassifiedExcel(ByteBuffer _bb, ShopFilterClassifiedExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopFilterClassifiedExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ShopCategoryType CategoryType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ShopCategoryType.General; } }
  public FlatDataGlobal.ParcelType ConsumeParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long ConsumeParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ShopFilterType ShopFilterType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ShopFilterType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ShopFilterType.GachaTicket; } }
  public long GoodsId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.ShopFilterClassifiedExcel> CreateShopFilterClassifiedExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.ShopCategoryType CategoryType = FlatDataGlobal.ShopCategoryType.General,
      FlatDataGlobal.ParcelType ConsumeParcelType = FlatDataGlobal.ParcelType.None,
      long ConsumeParcelId = 0,
      FlatDataGlobal.ShopFilterType shopFilterType = FlatDataGlobal.ShopFilterType.GachaTicket,
      long GoodsId = 0) {
    builder.StartTable(6);
    ShopFilterClassifiedExcel.AddGoodsId(builder, GoodsId);
    ShopFilterClassifiedExcel.AddConsumeParcelId(builder, ConsumeParcelId);
    ShopFilterClassifiedExcel.AddId(builder, Id);
    ShopFilterClassifiedExcel.AddShopFilterType(builder, shopFilterType);
    ShopFilterClassifiedExcel.AddConsumeParcelType(builder, ConsumeParcelType);
    ShopFilterClassifiedExcel.AddCategoryType(builder, CategoryType);
    return ShopFilterClassifiedExcel.EndShopFilterClassifiedExcel(builder);
  }

  public static void StartShopFilterClassifiedExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType CategoryType) { builder.AddInt(1, (int)CategoryType, 0); }
  public static void AddConsumeParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType ConsumeParcelType) { builder.AddInt(2, (int)ConsumeParcelType, 0); }
  public static void AddConsumeParcelId(FlatBufferBuilder builder, long ConsumeParcelId) { builder.AddLong(3, ConsumeParcelId, 0); }
  public static void AddShopFilterType(FlatBufferBuilder builder, FlatDataGlobal.ShopFilterType shopFilterType) { builder.AddInt(4, (int)shopFilterType, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, long GoodsId) { builder.AddLong(5, GoodsId, 0); }
  public static Offset<FlatDataGlobal.ShopFilterClassifiedExcel> EndShopFilterClassifiedExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ShopFilterClassifiedExcel>(o);
  }
}


}
