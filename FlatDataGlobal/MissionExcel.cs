// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static MissionExcel GetRootAsMissionExcel(ByteBuffer _bb) { return GetRootAsMissionExcel(_bb, new MissionExcel()); }
  public static MissionExcel GetRootAsMissionExcel(ByteBuffer _bb, MissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.MissionCategory Category { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCategory.Challenge; } }
  public string Description { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public FlatDataGlobal.MissionResetType ResetType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.MissionResetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionResetType.None; } }
  public FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionToastDisplayConditionType.Always; } }
  public string ToastImagePath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetToastImagePathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetToastImagePathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetToastImagePathArray() { return __p.__vector_as_array<byte>(14); }
  public bool ViewFlag { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string StartDate { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(18); }
  public string EndDate { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(20); }
  public long EndDay { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StartableEndDate { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartableEndDateBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetStartableEndDateBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetStartableEndDateArray() { return __p.__vector_as_array<byte>(24); }
  public long DisplayOrder { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreMissionId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreMissionIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreMissionIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetPreMissionIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetPreMissionIdArray() { return __p.__vector_as_array<long>(28); }
  public FlatDataGlobal.AccountState AccountType { get { int o = __p.__offset(30); return o != 0 ? (FlatDataGlobal.AccountState)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.AccountState.WaitingSignIn; } }
  public long AccountLevel { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.SuddenMissionContentType ContentTags(int j) { int o = __p.__offset(34); return o != 0 ? (FlatDataGlobal.SuddenMissionContentType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.SuddenMissionContentType)0; }
  public int ContentTagsLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.SuddenMissionContentType> GetContentTagsBytes() { return __p.__vector_as_span<FlatDataGlobal.SuddenMissionContentType>(34, 4); }
#else
  public ArraySegment<byte>? GetContentTagsBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatDataGlobal.SuddenMissionContentType[] GetContentTagsArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.SuddenMissionContentType[] a = new FlatDataGlobal.SuddenMissionContentType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.SuddenMissionContentType)__p.bb.GetInt(p + i * 4); } return a; }
  public string ShortcutUI(int j) { int o = __p.__offset(36); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataGlobal.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(38); return o != 0 ? (FlatDataGlobal.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCompleteConditionType.None; } }
  public long CompleteConditionCount { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(42, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(42); }
  public string CompleteConditionParameterName(int j) { int o = __p.__offset(44); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CompleteConditionParameterNameLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string RewardIcon { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardIconBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetRewardIconBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetRewardIconArray() { return __p.__vector_as_array<byte>(46); }
  public FlatDataGlobal.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(48); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(48, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public FlatDataGlobal.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(48); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(50); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(50, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(50); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(52); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(52, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(52); }

  public static Offset<FlatDataGlobal.MissionExcel> CreateMissionExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.MissionCategory Category = FlatDataGlobal.MissionCategory.Challenge,
      StringOffset DescriptionOffset = default(StringOffset),
      FlatDataGlobal.MissionResetType ResetType = FlatDataGlobal.MissionResetType.None,
      FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType = FlatDataGlobal.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      bool ViewFlag = false,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long EndDay = 0,
      StringOffset StartableEndDateOffset = default(StringOffset),
      long DisplayOrder = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      FlatDataGlobal.AccountState AccountType = FlatDataGlobal.AccountState.WaitingSignIn,
      long AccountLevel = 0,
      VectorOffset ContentTagsOffset = default(VectorOffset),
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      FlatDataGlobal.MissionCompleteConditionType CompleteConditionType = FlatDataGlobal.MissionCompleteConditionType.None,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      VectorOffset CompleteConditionParameterNameOffset = default(VectorOffset),
      StringOffset RewardIconOffset = default(StringOffset),
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(25);
    MissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    MissionExcel.AddAccountLevel(builder, AccountLevel);
    MissionExcel.AddDisplayOrder(builder, DisplayOrder);
    MissionExcel.AddEndDay(builder, EndDay);
    MissionExcel.AddId(builder, Id);
    MissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    MissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    MissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    MissionExcel.AddRewardIcon(builder, RewardIconOffset);
    MissionExcel.AddCompleteConditionParameterName(builder, CompleteConditionParameterNameOffset);
    MissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    MissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    MissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    MissionExcel.AddContentTags(builder, ContentTagsOffset);
    MissionExcel.AddAccountType(builder, AccountType);
    MissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    MissionExcel.AddStartableEndDate(builder, StartableEndDateOffset);
    MissionExcel.AddEndDate(builder, EndDateOffset);
    MissionExcel.AddStartDate(builder, StartDateOffset);
    MissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    MissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    MissionExcel.AddResetType(builder, ResetType);
    MissionExcel.AddDescription(builder, DescriptionOffset);
    MissionExcel.AddCategory(builder, Category);
    MissionExcel.AddViewFlag(builder, ViewFlag);
    return MissionExcel.EndMissionExcel(builder);
  }

  public static void StartMissionExcel(FlatBufferBuilder builder) { builder.StartTable(25); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatDataGlobal.MissionCategory Category) { builder.AddInt(1, (int)Category, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset DescriptionOffset) { builder.AddOffset(2, DescriptionOffset.Value, 0); }
  public static void AddResetType(FlatBufferBuilder builder, FlatDataGlobal.MissionResetType ResetType) { builder.AddInt(3, (int)ResetType, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType) { builder.AddInt(4, (int)ToastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset ToastImagePathOffset) { builder.AddOffset(5, ToastImagePathOffset.Value, 0); }
  public static void AddViewFlag(FlatBufferBuilder builder, bool ViewFlag) { builder.AddBool(6, ViewFlag, false); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(7, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(8, EndDateOffset.Value, 0); }
  public static void AddEndDay(FlatBufferBuilder builder, long EndDay) { builder.AddLong(9, EndDay, 0); }
  public static void AddStartableEndDate(FlatBufferBuilder builder, StringOffset StartableEndDateOffset) { builder.AddOffset(10, StartableEndDateOffset.Value, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(11, DisplayOrder, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset PreMissionIdOffset) { builder.AddOffset(12, PreMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAccountType(FlatBufferBuilder builder, FlatDataGlobal.AccountState AccountType) { builder.AddInt(13, (int)AccountType, 0); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long AccountLevel) { builder.AddLong(14, AccountLevel, 0); }
  public static void AddContentTags(FlatBufferBuilder builder, VectorOffset ContentTagsOffset) { builder.AddOffset(15, ContentTagsOffset.Value, 0); }
  public static VectorOffset CreateContentTagsVector(FlatBufferBuilder builder, FlatDataGlobal.SuddenMissionContentType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.SuddenMissionContentType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.SuddenMissionContentType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.SuddenMissionContentType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartContentTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset ShortcutUIOffset) { builder.AddOffset(16, ShortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, FlatDataGlobal.MissionCompleteConditionType CompleteConditionType) { builder.AddInt(17, (int)CompleteConditionType, 0); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long CompleteConditionCount) { builder.AddLong(18, CompleteConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterOffset) { builder.AddOffset(19, CompleteConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterName(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterNameOffset) { builder.AddOffset(20, CompleteConditionParameterNameOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardIcon(FlatBufferBuilder builder, StringOffset RewardIconOffset) { builder.AddOffset(21, RewardIconOffset.Value, 0); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset MissionRewardParcelTypeOffset) { builder.AddOffset(22, MissionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset MissionRewardParcelIdOffset) { builder.AddOffset(23, MissionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset MissionRewardAmountOffset) { builder.AddOffset(24, MissionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.MissionExcel> EndMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MissionExcel>(o);
  }
}


}
