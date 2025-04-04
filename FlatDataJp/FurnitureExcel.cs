// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FurnitureExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FurnitureExcel GetRootAsFurnitureExcel(ByteBuffer _bb) { return GetRootAsFurnitureExcel(_bb, new FurnitureExcel()); }
  public static FurnitureExcel GetRootAsFurnitureExcel(ByteBuffer _bb, FurnitureExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FurnitureExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ProductionStep ProductionStep { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ProductionStep.ToDo; } }
  public FlatDataJp.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Rarity.N; } }
  public FlatDataJp.FurnitureCategory Category { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.FurnitureCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.FurnitureCategory.Furnitures; } }
  public FlatDataJp.FurnitureSubCategory SubCategory { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.FurnitureSubCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.FurnitureSubCategory.Table; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public int StarGradeInit { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Tier { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Icon { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(20); }
  public int SizeWidth { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SizeHeight { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int OtherSize { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExpandWidth { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool Enable { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ReverseRotation { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Prefab { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetPrefabBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetPrefabArray() { return __p.__vector_as_array<byte>(34); }
  public string PrefabExpand { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabExpandBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetPrefabExpandBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetPrefabExpandArray() { return __p.__vector_as_array<byte>(36); }
  public string SubPrefab { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubPrefabBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetSubPrefabBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetSubPrefabArray() { return __p.__vector_as_array<byte>(38); }
  public string SubExpandPrefab { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubExpandPrefabBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetSubExpandPrefabBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetSubExpandPrefabArray() { return __p.__vector_as_array<byte>(40); }
  public string CornerPrefab { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCornerPrefabBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetCornerPrefabBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetCornerPrefabArray() { return __p.__vector_as_array<byte>(42); }
  public long StackableMax { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeCraftId { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SetGroudpId { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ComfortBonus { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long VisitOperationType { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long VisitBonusOperationType { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.Tag Tags(int j) { int o = __p.__offset(56); return o != 0 ? (FlatDataJp.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.Tag> GetTagsBytes() { return __p.__vector_as_span<FlatDataJp.Tag>(56, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public FlatDataJp.Tag[] GetTagsArray() { int o = __p.__offset(56); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.Tag[] a = new FlatDataJp.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long CraftQualityTier0 { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier1 { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier2 { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShiftingCraftQuality { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.FurnitureFunctionType FurnitureFunctionType { get { int o = __p.__offset(66); return o != 0 ? (FlatDataJp.FurnitureFunctionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.FurnitureFunctionType.None; } }
  public long FurnitureFunctionParameter { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long VideoId { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventCollectionId { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FurnitureBubbleOffsetX { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FurnitureBubbleOffsetY { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string CafeCharacterStateReq(int j) { int o = __p.__offset(78); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CafeCharacterStateReqLength { get { int o = __p.__offset(78); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string CafeCharacterStateAdd(int j) { int o = __p.__offset(80); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CafeCharacterStateAddLength { get { int o = __p.__offset(80); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string CafeCharacterStateMake(int j) { int o = __p.__offset(82); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CafeCharacterStateMakeLength { get { int o = __p.__offset(82); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string CafeCharacterStateOnly(int j) { int o = __p.__offset(84); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CafeCharacterStateOnlyLength { get { int o = __p.__offset(84); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.FurnitureExcel> CreateFurnitureExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.ProductionStep productionStep = FlatDataJp.ProductionStep.ToDo,
      FlatDataJp.Rarity rarity = FlatDataJp.Rarity.N,
      FlatDataJp.FurnitureCategory Category = FlatDataJp.FurnitureCategory.Furnitures,
      FlatDataJp.FurnitureSubCategory SubCategory = FlatDataJp.FurnitureSubCategory.Table,
      uint LocalizeEtcId = 0,
      int StarGradeInit = 0,
      long Tier = 0,
      StringOffset IconOffset = default(StringOffset),
      int SizeWidth = 0,
      int SizeHeight = 0,
      int OtherSize = 0,
      int ExpandWidth = 0,
      bool Enable = false,
      bool ReverseRotation = false,
      StringOffset PrefabOffset = default(StringOffset),
      StringOffset PrefabExpandOffset = default(StringOffset),
      StringOffset SubPrefabOffset = default(StringOffset),
      StringOffset SubExpandPrefabOffset = default(StringOffset),
      StringOffset CornerPrefabOffset = default(StringOffset),
      long StackableMax = 0,
      long RecipeCraftId = 0,
      long SetGroudpId = 0,
      long ComfortBonus = 0,
      long VisitOperationType = 0,
      long VisitBonusOperationType = 0,
      VectorOffset TagsOffset = default(VectorOffset),
      long CraftQualityTier0 = 0,
      long CraftQualityTier1 = 0,
      long CraftQualityTier2 = 0,
      long ShiftingCraftQuality = 0,
      FlatDataJp.FurnitureFunctionType furnitureFunctionType = FlatDataJp.FurnitureFunctionType.None,
      long FurnitureFunctionParameter = 0,
      long VideoId = 0,
      long EventCollectionId = 0,
      long FurnitureBubbleOffsetX = 0,
      long FurnitureBubbleOffsetY = 0,
      VectorOffset CafeCharacterStateReqOffset = default(VectorOffset),
      VectorOffset CafeCharacterStateAddOffset = default(VectorOffset),
      VectorOffset CafeCharacterStateMakeOffset = default(VectorOffset),
      VectorOffset CafeCharacterStateOnlyOffset = default(VectorOffset)) {
    builder.StartTable(41);
    FurnitureExcel.AddFurnitureBubbleOffsetY(builder, FurnitureBubbleOffsetY);
    FurnitureExcel.AddFurnitureBubbleOffsetX(builder, FurnitureBubbleOffsetX);
    FurnitureExcel.AddEventCollectionId(builder, EventCollectionId);
    FurnitureExcel.AddVideoId(builder, VideoId);
    FurnitureExcel.AddFurnitureFunctionParameter(builder, FurnitureFunctionParameter);
    FurnitureExcel.AddShiftingCraftQuality(builder, ShiftingCraftQuality);
    FurnitureExcel.AddCraftQualityTier2(builder, CraftQualityTier2);
    FurnitureExcel.AddCraftQualityTier1(builder, CraftQualityTier1);
    FurnitureExcel.AddCraftQualityTier0(builder, CraftQualityTier0);
    FurnitureExcel.AddVisitBonusOperationType(builder, VisitBonusOperationType);
    FurnitureExcel.AddVisitOperationType(builder, VisitOperationType);
    FurnitureExcel.AddComfortBonus(builder, ComfortBonus);
    FurnitureExcel.AddSetGroudpId(builder, SetGroudpId);
    FurnitureExcel.AddRecipeCraftId(builder, RecipeCraftId);
    FurnitureExcel.AddStackableMax(builder, StackableMax);
    FurnitureExcel.AddTier(builder, Tier);
    FurnitureExcel.AddId(builder, Id);
    FurnitureExcel.AddCafeCharacterStateOnly(builder, CafeCharacterStateOnlyOffset);
    FurnitureExcel.AddCafeCharacterStateMake(builder, CafeCharacterStateMakeOffset);
    FurnitureExcel.AddCafeCharacterStateAdd(builder, CafeCharacterStateAddOffset);
    FurnitureExcel.AddCafeCharacterStateReq(builder, CafeCharacterStateReqOffset);
    FurnitureExcel.AddFurnitureFunctionType(builder, furnitureFunctionType);
    FurnitureExcel.AddTags(builder, TagsOffset);
    FurnitureExcel.AddCornerPrefab(builder, CornerPrefabOffset);
    FurnitureExcel.AddSubExpandPrefab(builder, SubExpandPrefabOffset);
    FurnitureExcel.AddSubPrefab(builder, SubPrefabOffset);
    FurnitureExcel.AddPrefabExpand(builder, PrefabExpandOffset);
    FurnitureExcel.AddPrefab(builder, PrefabOffset);
    FurnitureExcel.AddExpandWidth(builder, ExpandWidth);
    FurnitureExcel.AddOtherSize(builder, OtherSize);
    FurnitureExcel.AddSizeHeight(builder, SizeHeight);
    FurnitureExcel.AddSizeWidth(builder, SizeWidth);
    FurnitureExcel.AddIcon(builder, IconOffset);
    FurnitureExcel.AddStarGradeInit(builder, StarGradeInit);
    FurnitureExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    FurnitureExcel.AddSubCategory(builder, SubCategory);
    FurnitureExcel.AddCategory(builder, Category);
    FurnitureExcel.AddRarity(builder, rarity);
    FurnitureExcel.AddProductionStep(builder, productionStep);
    FurnitureExcel.AddReverseRotation(builder, ReverseRotation);
    FurnitureExcel.AddEnable(builder, Enable);
    return FurnitureExcel.EndFurnitureExcel(builder);
  }

  public static void StartFurnitureExcel(FlatBufferBuilder builder) { builder.StartTable(41); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, FlatDataJp.ProductionStep productionStep) { builder.AddInt(1, (int)productionStep, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatDataJp.Rarity rarity) { builder.AddInt(2, (int)rarity, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatDataJp.FurnitureCategory Category) { builder.AddInt(3, (int)Category, 0); }
  public static void AddSubCategory(FlatBufferBuilder builder, FlatDataJp.FurnitureSubCategory SubCategory) { builder.AddInt(4, (int)SubCategory, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(5, LocalizeEtcId, 0); }
  public static void AddStarGradeInit(FlatBufferBuilder builder, int StarGradeInit) { builder.AddInt(6, StarGradeInit, 0); }
  public static void AddTier(FlatBufferBuilder builder, long Tier) { builder.AddLong(7, Tier, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(8, IconOffset.Value, 0); }
  public static void AddSizeWidth(FlatBufferBuilder builder, int SizeWidth) { builder.AddInt(9, SizeWidth, 0); }
  public static void AddSizeHeight(FlatBufferBuilder builder, int SizeHeight) { builder.AddInt(10, SizeHeight, 0); }
  public static void AddOtherSize(FlatBufferBuilder builder, int OtherSize) { builder.AddInt(11, OtherSize, 0); }
  public static void AddExpandWidth(FlatBufferBuilder builder, int ExpandWidth) { builder.AddInt(12, ExpandWidth, 0); }
  public static void AddEnable(FlatBufferBuilder builder, bool Enable) { builder.AddBool(13, Enable, false); }
  public static void AddReverseRotation(FlatBufferBuilder builder, bool ReverseRotation) { builder.AddBool(14, ReverseRotation, false); }
  public static void AddPrefab(FlatBufferBuilder builder, StringOffset PrefabOffset) { builder.AddOffset(15, PrefabOffset.Value, 0); }
  public static void AddPrefabExpand(FlatBufferBuilder builder, StringOffset PrefabExpandOffset) { builder.AddOffset(16, PrefabExpandOffset.Value, 0); }
  public static void AddSubPrefab(FlatBufferBuilder builder, StringOffset SubPrefabOffset) { builder.AddOffset(17, SubPrefabOffset.Value, 0); }
  public static void AddSubExpandPrefab(FlatBufferBuilder builder, StringOffset SubExpandPrefabOffset) { builder.AddOffset(18, SubExpandPrefabOffset.Value, 0); }
  public static void AddCornerPrefab(FlatBufferBuilder builder, StringOffset CornerPrefabOffset) { builder.AddOffset(19, CornerPrefabOffset.Value, 0); }
  public static void AddStackableMax(FlatBufferBuilder builder, long StackableMax) { builder.AddLong(20, StackableMax, 0); }
  public static void AddRecipeCraftId(FlatBufferBuilder builder, long RecipeCraftId) { builder.AddLong(21, RecipeCraftId, 0); }
  public static void AddSetGroudpId(FlatBufferBuilder builder, long SetGroudpId) { builder.AddLong(22, SetGroudpId, 0); }
  public static void AddComfortBonus(FlatBufferBuilder builder, long ComfortBonus) { builder.AddLong(23, ComfortBonus, 0); }
  public static void AddVisitOperationType(FlatBufferBuilder builder, long VisitOperationType) { builder.AddLong(24, VisitOperationType, 0); }
  public static void AddVisitBonusOperationType(FlatBufferBuilder builder, long VisitBonusOperationType) { builder.AddLong(25, VisitBonusOperationType, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset TagsOffset) { builder.AddOffset(26, TagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, FlatDataJp.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, FlatDataJp.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCraftQualityTier0(FlatBufferBuilder builder, long CraftQualityTier0) { builder.AddLong(27, CraftQualityTier0, 0); }
  public static void AddCraftQualityTier1(FlatBufferBuilder builder, long CraftQualityTier1) { builder.AddLong(28, CraftQualityTier1, 0); }
  public static void AddCraftQualityTier2(FlatBufferBuilder builder, long CraftQualityTier2) { builder.AddLong(29, CraftQualityTier2, 0); }
  public static void AddShiftingCraftQuality(FlatBufferBuilder builder, long ShiftingCraftQuality) { builder.AddLong(30, ShiftingCraftQuality, 0); }
  public static void AddFurnitureFunctionType(FlatBufferBuilder builder, FlatDataJp.FurnitureFunctionType furnitureFunctionType) { builder.AddInt(31, (int)furnitureFunctionType, 0); }
  public static void AddFurnitureFunctionParameter(FlatBufferBuilder builder, long FurnitureFunctionParameter) { builder.AddLong(32, FurnitureFunctionParameter, 0); }
  public static void AddVideoId(FlatBufferBuilder builder, long VideoId) { builder.AddLong(33, VideoId, 0); }
  public static void AddEventCollectionId(FlatBufferBuilder builder, long EventCollectionId) { builder.AddLong(34, EventCollectionId, 0); }
  public static void AddFurnitureBubbleOffsetX(FlatBufferBuilder builder, long FurnitureBubbleOffsetX) { builder.AddLong(35, FurnitureBubbleOffsetX, 0); }
  public static void AddFurnitureBubbleOffsetY(FlatBufferBuilder builder, long FurnitureBubbleOffsetY) { builder.AddLong(36, FurnitureBubbleOffsetY, 0); }
  public static void AddCafeCharacterStateReq(FlatBufferBuilder builder, VectorOffset CafeCharacterStateReqOffset) { builder.AddOffset(37, CafeCharacterStateReqOffset.Value, 0); }
  public static VectorOffset CreateCafeCharacterStateReqVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateReqVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateReqVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateReqVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeCharacterStateReqVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCafeCharacterStateAdd(FlatBufferBuilder builder, VectorOffset CafeCharacterStateAddOffset) { builder.AddOffset(38, CafeCharacterStateAddOffset.Value, 0); }
  public static VectorOffset CreateCafeCharacterStateAddVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateAddVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateAddVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateAddVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeCharacterStateAddVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCafeCharacterStateMake(FlatBufferBuilder builder, VectorOffset CafeCharacterStateMakeOffset) { builder.AddOffset(39, CafeCharacterStateMakeOffset.Value, 0); }
  public static VectorOffset CreateCafeCharacterStateMakeVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateMakeVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateMakeVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateMakeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeCharacterStateMakeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCafeCharacterStateOnly(FlatBufferBuilder builder, VectorOffset CafeCharacterStateOnlyOffset) { builder.AddOffset(40, CafeCharacterStateOnlyOffset.Value, 0); }
  public static VectorOffset CreateCafeCharacterStateOnlyVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateOnlyVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateOnlyVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateOnlyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeCharacterStateOnlyVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.FurnitureExcel> EndFurnitureExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.FurnitureExcel>(o);
  }
}


}
