// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EquipmentExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb) { return GetRootAsEquipmentExcel(_bb, new EquipmentExcel()); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb, EquipmentExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.EquipmentCategory EquipmentCategory { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.EquipmentCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EquipmentCategory.Unable; } }
  public FlatDataGlobal.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.Rarity.N; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Wear { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int MaxLevel { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecipeId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TierInit { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextTierEquipment { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StackableMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Icon { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(24); }
  public string ImageName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImageNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetImageNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetImageNameArray() { return __p.__vector_as_array<byte>(26); }
  public FlatDataGlobal.Tag Tags(int j) { int o = __p.__offset(28); return o != 0 ? (FlatDataGlobal.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.Tag> GetTagsBytes() { return __p.__vector_as_span<FlatDataGlobal.Tag>(28, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public FlatDataGlobal.Tag[] GetTagsArray() { int o = __p.__offset(28); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.Tag[] a = new FlatDataGlobal.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long CraftQuality { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShiftingCraftQuality { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ShopCategoryType ShopCategory(int j) { int o = __p.__offset(34); return o != 0 ? (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ShopCategoryType)0; }
  public int ShopCategoryLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ShopCategoryType> GetShopCategoryBytes() { return __p.__vector_as_span<FlatDataGlobal.ShopCategoryType>(34, 4); }
#else
  public ArraySegment<byte>? GetShopCategoryBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatDataGlobal.ShopCategoryType[] GetShopCategoryArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ShopCategoryType[] a = new FlatDataGlobal.ShopCategoryType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ShopCategoryType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ShortcutTypeId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.EquipmentExcel> CreateEquipmentExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.EquipmentCategory EquipmentCategory = FlatDataGlobal.EquipmentCategory.Unable,
      FlatDataGlobal.Rarity Rarity = FlatDataGlobal.Rarity.N,
      uint LocalizeEtcId = 0,
      bool Wear = false,
      int MaxLevel = 0,
      int RecipeId = 0,
      long TierInit = 0,
      long NextTierEquipment = 0,
      int StackableMax = 0,
      StringOffset IconOffset = default(StringOffset),
      StringOffset ImageNameOffset = default(StringOffset),
      VectorOffset TagsOffset = default(VectorOffset),
      long CraftQuality = 0,
      long ShiftingCraftQuality = 0,
      VectorOffset ShopCategoryOffset = default(VectorOffset),
      long ShortcutTypeId = 0) {
    builder.StartTable(17);
    EquipmentExcel.AddShortcutTypeId(builder, ShortcutTypeId);
    EquipmentExcel.AddShiftingCraftQuality(builder, ShiftingCraftQuality);
    EquipmentExcel.AddCraftQuality(builder, CraftQuality);
    EquipmentExcel.AddNextTierEquipment(builder, NextTierEquipment);
    EquipmentExcel.AddTierInit(builder, TierInit);
    EquipmentExcel.AddId(builder, Id);
    EquipmentExcel.AddShopCategory(builder, ShopCategoryOffset);
    EquipmentExcel.AddTags(builder, TagsOffset);
    EquipmentExcel.AddImageName(builder, ImageNameOffset);
    EquipmentExcel.AddIcon(builder, IconOffset);
    EquipmentExcel.AddStackableMax(builder, StackableMax);
    EquipmentExcel.AddRecipeId(builder, RecipeId);
    EquipmentExcel.AddMaxLevel(builder, MaxLevel);
    EquipmentExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EquipmentExcel.AddRarity(builder, Rarity);
    EquipmentExcel.AddEquipmentCategory(builder, EquipmentCategory);
    EquipmentExcel.AddWear(builder, Wear);
    return EquipmentExcel.EndEquipmentExcel(builder);
  }

  public static void StartEquipmentExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEquipmentCategory(FlatBufferBuilder builder, FlatDataGlobal.EquipmentCategory EquipmentCategory) { builder.AddInt(1, (int)EquipmentCategory, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatDataGlobal.Rarity Rarity) { builder.AddInt(2, (int)Rarity, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(3, LocalizeEtcId, 0); }
  public static void AddWear(FlatBufferBuilder builder, bool Wear) { builder.AddBool(4, Wear, false); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(5, MaxLevel, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, int RecipeId) { builder.AddInt(6, RecipeId, 0); }
  public static void AddTierInit(FlatBufferBuilder builder, long TierInit) { builder.AddLong(7, TierInit, 0); }
  public static void AddNextTierEquipment(FlatBufferBuilder builder, long NextTierEquipment) { builder.AddLong(8, NextTierEquipment, 0); }
  public static void AddStackableMax(FlatBufferBuilder builder, int StackableMax) { builder.AddInt(9, StackableMax, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(10, IconOffset.Value, 0); }
  public static void AddImageName(FlatBufferBuilder builder, StringOffset ImageNameOffset) { builder.AddOffset(11, ImageNameOffset.Value, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset TagsOffset) { builder.AddOffset(12, TagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCraftQuality(FlatBufferBuilder builder, long CraftQuality) { builder.AddLong(13, CraftQuality, 0); }
  public static void AddShiftingCraftQuality(FlatBufferBuilder builder, long ShiftingCraftQuality) { builder.AddLong(14, ShiftingCraftQuality, 0); }
  public static void AddShopCategory(FlatBufferBuilder builder, VectorOffset ShopCategoryOffset) { builder.AddOffset(15, ShopCategoryOffset.Value, 0); }
  public static VectorOffset CreateShopCategoryVector(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ShopCategoryType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ShopCategoryType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShopCategoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutTypeId(FlatBufferBuilder builder, long ShortcutTypeId) { builder.AddLong(16, ShortcutTypeId, 0); }
  public static Offset<FlatDataGlobal.EquipmentExcel> EndEquipmentExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EquipmentExcel>(o);
  }
}


}
