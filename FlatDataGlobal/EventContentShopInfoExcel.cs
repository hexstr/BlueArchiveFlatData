// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentShopInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentShopInfoExcel GetRootAsEventContentShopInfoExcel(ByteBuffer _bb) { return GetRootAsEventContentShopInfoExcel(_bb, new EventContentShopInfoExcel()); }
  public static EventContentShopInfoExcel GetRootAsEventContentShopInfoExcel(ByteBuffer _bb, EventContentShopInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentShopInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ShopCategoryType CategoryType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ShopCategoryType.General; } }
  public uint LocalizeCode { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
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
  public bool IsRefresh { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsSoldOutDimmed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AutoRefreshCoolTime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RefreshAbleCount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoodsId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GoodsIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGoodsIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetGoodsIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetGoodsIdArray() { return __p.__vector_as_array<long>(22); }
  public string OpenPeriodFrom { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodFromBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodFromBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetOpenPeriodFromArray() { return __p.__vector_as_array<byte>(24); }
  public string OpenPeriodTo { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodToBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodToBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetOpenPeriodToArray() { return __p.__vector_as_array<byte>(26); }
  public string ShopProductUpdateDate { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShopProductUpdateDateBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetShopProductUpdateDateBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetShopProductUpdateDateArray() { return __p.__vector_as_array<byte>(28); }

  public static Offset<FlatDataGlobal.EventContentShopInfoExcel> CreateEventContentShopInfoExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataGlobal.ShopCategoryType CategoryType = FlatDataGlobal.ShopCategoryType.General,
      uint LocalizeCode = 0,
      VectorOffset CostParcelTypeOffset = default(VectorOffset),
      VectorOffset CostParcelIdOffset = default(VectorOffset),
      bool IsRefresh = false,
      bool IsSoldOutDimmed = false,
      long AutoRefreshCoolTime = 0,
      long RefreshAbleCount = 0,
      VectorOffset GoodsIdOffset = default(VectorOffset),
      StringOffset OpenPeriodFromOffset = default(StringOffset),
      StringOffset OpenPeriodToOffset = default(StringOffset),
      StringOffset ShopProductUpdateDateOffset = default(StringOffset)) {
    builder.StartTable(13);
    EventContentShopInfoExcel.AddRefreshAbleCount(builder, RefreshAbleCount);
    EventContentShopInfoExcel.AddAutoRefreshCoolTime(builder, AutoRefreshCoolTime);
    EventContentShopInfoExcel.AddEventContentId(builder, EventContentId);
    EventContentShopInfoExcel.AddShopProductUpdateDate(builder, ShopProductUpdateDateOffset);
    EventContentShopInfoExcel.AddOpenPeriodTo(builder, OpenPeriodToOffset);
    EventContentShopInfoExcel.AddOpenPeriodFrom(builder, OpenPeriodFromOffset);
    EventContentShopInfoExcel.AddGoodsId(builder, GoodsIdOffset);
    EventContentShopInfoExcel.AddCostParcelId(builder, CostParcelIdOffset);
    EventContentShopInfoExcel.AddCostParcelType(builder, CostParcelTypeOffset);
    EventContentShopInfoExcel.AddLocalizeCode(builder, LocalizeCode);
    EventContentShopInfoExcel.AddCategoryType(builder, CategoryType);
    EventContentShopInfoExcel.AddIsSoldOutDimmed(builder, IsSoldOutDimmed);
    EventContentShopInfoExcel.AddIsRefresh(builder, IsRefresh);
    return EventContentShopInfoExcel.EndEventContentShopInfoExcel(builder);
  }

  public static void StartEventContentShopInfoExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType CategoryType) { builder.AddInt(1, (int)CategoryType, 0); }
  public static void AddLocalizeCode(FlatBufferBuilder builder, uint LocalizeCode) { builder.AddUint(2, LocalizeCode, 0); }
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
  public static void AddIsRefresh(FlatBufferBuilder builder, bool IsRefresh) { builder.AddBool(5, IsRefresh, false); }
  public static void AddIsSoldOutDimmed(FlatBufferBuilder builder, bool IsSoldOutDimmed) { builder.AddBool(6, IsSoldOutDimmed, false); }
  public static void AddAutoRefreshCoolTime(FlatBufferBuilder builder, long AutoRefreshCoolTime) { builder.AddLong(7, AutoRefreshCoolTime, 0); }
  public static void AddRefreshAbleCount(FlatBufferBuilder builder, long RefreshAbleCount) { builder.AddLong(8, RefreshAbleCount, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, VectorOffset GoodsIdOffset) { builder.AddOffset(9, GoodsIdOffset.Value, 0); }
  public static VectorOffset CreateGoodsIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGoodsIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddOpenPeriodFrom(FlatBufferBuilder builder, StringOffset OpenPeriodFromOffset) { builder.AddOffset(10, OpenPeriodFromOffset.Value, 0); }
  public static void AddOpenPeriodTo(FlatBufferBuilder builder, StringOffset OpenPeriodToOffset) { builder.AddOffset(11, OpenPeriodToOffset.Value, 0); }
  public static void AddShopProductUpdateDate(FlatBufferBuilder builder, StringOffset ShopProductUpdateDateOffset) { builder.AddOffset(12, ShopProductUpdateDateOffset.Value, 0); }
  public static Offset<FlatDataGlobal.EventContentShopInfoExcel> EndEventContentShopInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentShopInfoExcel>(o);
  }
}


}
