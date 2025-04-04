// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ShopInfoExcel GetRootAsShopInfoExcel(ByteBuffer _bb) { return GetRootAsShopInfoExcel(_bb, new ShopInfoExcel()); }
  public static ShopInfoExcel GetRootAsShopInfoExcel(ByteBuffer _bb, ShopInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.ShopCategoryType CategoryType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ShopCategoryType.General; } }
  public bool IsRefresh { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsSoldOutDimmed { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.ParcelType CostParcelType(int j) { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int CostParcelTypeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetCostParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(10, 4); }
#else
  public ArraySegment<byte>? GetCostParcelTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public FlatDataGlobal.ParcelType[] GetCostParcelTypeArray() { int o = __p.__offset(10); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long CostParcelId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CostParcelIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCostParcelIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetCostParcelIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetCostParcelIdArray() { return __p.__vector_as_array<long>(12); }
  public long AutoRefreshCoolTime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RefreshAbleCount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoodsId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GoodsIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGoodsIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetGoodsIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetGoodsIdArray() { return __p.__vector_as_array<long>(18); }
  public string OpenPeriodFrom { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodFromBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodFromBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetOpenPeriodFromArray() { return __p.__vector_as_array<byte>(20); }
  public string OpenPeriodTo { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodToBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodToBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetOpenPeriodToArray() { return __p.__vector_as_array<byte>(22); }
  public string ShopProductUpdateTime { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShopProductUpdateTimeBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetShopProductUpdateTimeBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetShopProductUpdateTimeArray() { return __p.__vector_as_array<byte>(24); }
  public FlatDataGlobal.ParcelType DisplayParcelType { get { int o = __p.__offset(26); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long DisplayParcelId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsShopVisible { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int DisplayOrder { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateDate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId1 { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId2 { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId3 { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId4 { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId5 { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId6 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId7 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId8 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId9 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId10 { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId11 { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId12 { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.ShopInfoExcel> CreateShopInfoExcel(FlatBufferBuilder builder,
      FlatDataGlobal.ShopCategoryType CategoryType = FlatDataGlobal.ShopCategoryType.General,
      bool IsRefresh = false,
      bool IsSoldOutDimmed = false,
      VectorOffset CostParcelTypeOffset = default(VectorOffset),
      VectorOffset CostParcelIdOffset = default(VectorOffset),
      long AutoRefreshCoolTime = 0,
      long RefreshAbleCount = 0,
      VectorOffset GoodsIdOffset = default(VectorOffset),
      StringOffset OpenPeriodFromOffset = default(StringOffset),
      StringOffset OpenPeriodToOffset = default(StringOffset),
      StringOffset ShopProductUpdateTimeOffset = default(StringOffset),
      FlatDataGlobal.ParcelType DisplayParcelType = FlatDataGlobal.ParcelType.None,
      long DisplayParcelId = 0,
      bool IsShopVisible = false,
      int DisplayOrder = 0,
      int ShopUpdateDate = 0,
      int ShopUpdateGroupId1 = 0,
      int ShopUpdateGroupId2 = 0,
      int ShopUpdateGroupId3 = 0,
      int ShopUpdateGroupId4 = 0,
      int ShopUpdateGroupId5 = 0,
      int ShopUpdateGroupId6 = 0,
      int ShopUpdateGroupId7 = 0,
      int ShopUpdateGroupId8 = 0,
      int ShopUpdateGroupId9 = 0,
      int ShopUpdateGroupId10 = 0,
      int ShopUpdateGroupId11 = 0,
      int ShopUpdateGroupId12 = 0) {
    builder.StartTable(28);
    ShopInfoExcel.AddDisplayParcelId(builder, DisplayParcelId);
    ShopInfoExcel.AddRefreshAbleCount(builder, RefreshAbleCount);
    ShopInfoExcel.AddAutoRefreshCoolTime(builder, AutoRefreshCoolTime);
    ShopInfoExcel.AddShopUpdateGroupId12(builder, ShopUpdateGroupId12);
    ShopInfoExcel.AddShopUpdateGroupId11(builder, ShopUpdateGroupId11);
    ShopInfoExcel.AddShopUpdateGroupId10(builder, ShopUpdateGroupId10);
    ShopInfoExcel.AddShopUpdateGroupId9(builder, ShopUpdateGroupId9);
    ShopInfoExcel.AddShopUpdateGroupId8(builder, ShopUpdateGroupId8);
    ShopInfoExcel.AddShopUpdateGroupId7(builder, ShopUpdateGroupId7);
    ShopInfoExcel.AddShopUpdateGroupId6(builder, ShopUpdateGroupId6);
    ShopInfoExcel.AddShopUpdateGroupId5(builder, ShopUpdateGroupId5);
    ShopInfoExcel.AddShopUpdateGroupId4(builder, ShopUpdateGroupId4);
    ShopInfoExcel.AddShopUpdateGroupId3(builder, ShopUpdateGroupId3);
    ShopInfoExcel.AddShopUpdateGroupId2(builder, ShopUpdateGroupId2);
    ShopInfoExcel.AddShopUpdateGroupId1(builder, ShopUpdateGroupId1);
    ShopInfoExcel.AddShopUpdateDate(builder, ShopUpdateDate);
    ShopInfoExcel.AddDisplayOrder(builder, DisplayOrder);
    ShopInfoExcel.AddDisplayParcelType(builder, DisplayParcelType);
    ShopInfoExcel.AddShopProductUpdateTime(builder, ShopProductUpdateTimeOffset);
    ShopInfoExcel.AddOpenPeriodTo(builder, OpenPeriodToOffset);
    ShopInfoExcel.AddOpenPeriodFrom(builder, OpenPeriodFromOffset);
    ShopInfoExcel.AddGoodsId(builder, GoodsIdOffset);
    ShopInfoExcel.AddCostParcelId(builder, CostParcelIdOffset);
    ShopInfoExcel.AddCostParcelType(builder, CostParcelTypeOffset);
    ShopInfoExcel.AddCategoryType(builder, CategoryType);
    ShopInfoExcel.AddIsShopVisible(builder, IsShopVisible);
    ShopInfoExcel.AddIsSoldOutDimmed(builder, IsSoldOutDimmed);
    ShopInfoExcel.AddIsRefresh(builder, IsRefresh);
    return ShopInfoExcel.EndShopInfoExcel(builder);
  }

  public static void StartShopInfoExcel(FlatBufferBuilder builder) { builder.StartTable(28); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType CategoryType) { builder.AddInt(0, (int)CategoryType, 0); }
  public static void AddIsRefresh(FlatBufferBuilder builder, bool IsRefresh) { builder.AddBool(1, IsRefresh, false); }
  public static void AddIsSoldOutDimmed(FlatBufferBuilder builder, bool IsSoldOutDimmed) { builder.AddBool(2, IsSoldOutDimmed, false); }
  public static void AddCostParcelType(FlatBufferBuilder builder, VectorOffset CostParcelTypeOffset) { builder.AddOffset(3, CostParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateCostParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostParcelId(FlatBufferBuilder builder, VectorOffset CostParcelIdOffset) { builder.AddOffset(4, CostParcelIdOffset.Value, 0); }
  public static VectorOffset CreateCostParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAutoRefreshCoolTime(FlatBufferBuilder builder, long AutoRefreshCoolTime) { builder.AddLong(5, AutoRefreshCoolTime, 0); }
  public static void AddRefreshAbleCount(FlatBufferBuilder builder, long RefreshAbleCount) { builder.AddLong(6, RefreshAbleCount, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, VectorOffset GoodsIdOffset) { builder.AddOffset(7, GoodsIdOffset.Value, 0); }
  public static VectorOffset CreateGoodsIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGoodsIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddOpenPeriodFrom(FlatBufferBuilder builder, StringOffset OpenPeriodFromOffset) { builder.AddOffset(8, OpenPeriodFromOffset.Value, 0); }
  public static void AddOpenPeriodTo(FlatBufferBuilder builder, StringOffset OpenPeriodToOffset) { builder.AddOffset(9, OpenPeriodToOffset.Value, 0); }
  public static void AddShopProductUpdateTime(FlatBufferBuilder builder, StringOffset ShopProductUpdateTimeOffset) { builder.AddOffset(10, ShopProductUpdateTimeOffset.Value, 0); }
  public static void AddDisplayParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType DisplayParcelType) { builder.AddInt(11, (int)DisplayParcelType, 0); }
  public static void AddDisplayParcelId(FlatBufferBuilder builder, long DisplayParcelId) { builder.AddLong(12, DisplayParcelId, 0); }
  public static void AddIsShopVisible(FlatBufferBuilder builder, bool IsShopVisible) { builder.AddBool(13, IsShopVisible, false); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int DisplayOrder) { builder.AddInt(14, DisplayOrder, 0); }
  public static void AddShopUpdateDate(FlatBufferBuilder builder, int ShopUpdateDate) { builder.AddInt(15, ShopUpdateDate, 0); }
  public static void AddShopUpdateGroupId1(FlatBufferBuilder builder, int ShopUpdateGroupId1) { builder.AddInt(16, ShopUpdateGroupId1, 0); }
  public static void AddShopUpdateGroupId2(FlatBufferBuilder builder, int ShopUpdateGroupId2) { builder.AddInt(17, ShopUpdateGroupId2, 0); }
  public static void AddShopUpdateGroupId3(FlatBufferBuilder builder, int ShopUpdateGroupId3) { builder.AddInt(18, ShopUpdateGroupId3, 0); }
  public static void AddShopUpdateGroupId4(FlatBufferBuilder builder, int ShopUpdateGroupId4) { builder.AddInt(19, ShopUpdateGroupId4, 0); }
  public static void AddShopUpdateGroupId5(FlatBufferBuilder builder, int ShopUpdateGroupId5) { builder.AddInt(20, ShopUpdateGroupId5, 0); }
  public static void AddShopUpdateGroupId6(FlatBufferBuilder builder, int ShopUpdateGroupId6) { builder.AddInt(21, ShopUpdateGroupId6, 0); }
  public static void AddShopUpdateGroupId7(FlatBufferBuilder builder, int ShopUpdateGroupId7) { builder.AddInt(22, ShopUpdateGroupId7, 0); }
  public static void AddShopUpdateGroupId8(FlatBufferBuilder builder, int ShopUpdateGroupId8) { builder.AddInt(23, ShopUpdateGroupId8, 0); }
  public static void AddShopUpdateGroupId9(FlatBufferBuilder builder, int ShopUpdateGroupId9) { builder.AddInt(24, ShopUpdateGroupId9, 0); }
  public static void AddShopUpdateGroupId10(FlatBufferBuilder builder, int ShopUpdateGroupId10) { builder.AddInt(25, ShopUpdateGroupId10, 0); }
  public static void AddShopUpdateGroupId11(FlatBufferBuilder builder, int ShopUpdateGroupId11) { builder.AddInt(26, ShopUpdateGroupId11, 0); }
  public static void AddShopUpdateGroupId12(FlatBufferBuilder builder, int ShopUpdateGroupId12) { builder.AddInt(27, ShopUpdateGroupId12, 0); }
  public static Offset<FlatDataGlobal.ShopInfoExcel> EndShopInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ShopInfoExcel>(o);
  }
}


}
