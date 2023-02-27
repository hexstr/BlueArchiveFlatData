// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameMissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static MiniGameMissionExcel GetRootAsMiniGameMissionExcel(ByteBuffer _bb) { return GetRootAsMiniGameMissionExcel(_bb, new MiniGameMissionExcel()); }
  public static MiniGameMissionExcel GetRootAsMiniGameMissionExcel(ByteBuffer _bb, MiniGameMissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameMissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GroupName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroupNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetGroupNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetGroupNameArray() { return __p.__vector_as_array<byte>(10); }
  public FlatDataJp.MissionCategory Category { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MissionCategory.Challenge; } }
  public string Description { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(14); }
  public FlatDataJp.MissionResetType ResetType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.MissionResetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MissionResetType.None; } }
  public FlatDataJp.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MissionToastDisplayConditionType.Always; } }
  public string ToastImagePath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetToastImagePathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetToastImagePathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetToastImagePathArray() { return __p.__vector_as_array<byte>(20); }
  public bool ViewFlag { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long DisplayOrder { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreMissionId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreMissionIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreMissionIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetPreMissionIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetPreMissionIdArray() { return __p.__vector_as_array<long>(26); }
  public FlatDataJp.AccountState AccountType { get { int o = __p.__offset(28); return o != 0 ? (FlatDataJp.AccountState)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.AccountState.WaitingSignIn; } }
  public long AccountLevel { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ShortcutUI(int j) { int o = __p.__offset(32); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataJp.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(34); return o != 0 ? (FlatDataJp.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MissionCompleteConditionType.None; } }
  public bool IsCompleteExtensionTime { get { int o = __p.__offset(36); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CompleteConditionCount { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(40, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(40); }
  public string CompleteConditionParameterName(int j) { int o = __p.__offset(42); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CompleteConditionParameterNameLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string RewardIcon { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardIconBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetRewardIconBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetRewardIconArray() { return __p.__vector_as_array<byte>(44); }
  public FlatDataJp.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(46); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(46, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public FlatDataJp.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(46); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(48, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(48); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(50); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(50, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(50); }

  public static Offset<FlatDataJp.MiniGameMissionExcel> CreateMiniGameMissionExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long GroupId = 0,
      StringOffset GroupNameOffset = default(StringOffset),
      FlatDataJp.MissionCategory Category = FlatDataJp.MissionCategory.Challenge,
      StringOffset DescriptionOffset = default(StringOffset),
      FlatDataJp.MissionResetType ResetType = FlatDataJp.MissionResetType.None,
      FlatDataJp.MissionToastDisplayConditionType ToastDisplayType = FlatDataJp.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      bool ViewFlag = false,
      long DisplayOrder = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      FlatDataJp.AccountState AccountType = FlatDataJp.AccountState.WaitingSignIn,
      long AccountLevel = 0,
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      FlatDataJp.MissionCompleteConditionType CompleteConditionType = FlatDataJp.MissionCompleteConditionType.None,
      bool IsCompleteExtensionTime = false,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      VectorOffset CompleteConditionParameterNameOffset = default(VectorOffset),
      StringOffset RewardIconOffset = default(StringOffset),
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(24);
    MiniGameMissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    MiniGameMissionExcel.AddAccountLevel(builder, AccountLevel);
    MiniGameMissionExcel.AddDisplayOrder(builder, DisplayOrder);
    MiniGameMissionExcel.AddGroupId(builder, GroupId);
    MiniGameMissionExcel.AddEventContentId(builder, EventContentId);
    MiniGameMissionExcel.AddId(builder, Id);
    MiniGameMissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    MiniGameMissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    MiniGameMissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    MiniGameMissionExcel.AddRewardIcon(builder, RewardIconOffset);
    MiniGameMissionExcel.AddCompleteConditionParameterName(builder, CompleteConditionParameterNameOffset);
    MiniGameMissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    MiniGameMissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    MiniGameMissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    MiniGameMissionExcel.AddAccountType(builder, AccountType);
    MiniGameMissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    MiniGameMissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    MiniGameMissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    MiniGameMissionExcel.AddResetType(builder, ResetType);
    MiniGameMissionExcel.AddDescription(builder, DescriptionOffset);
    MiniGameMissionExcel.AddCategory(builder, Category);
    MiniGameMissionExcel.AddGroupName(builder, GroupNameOffset);
    MiniGameMissionExcel.AddIsCompleteExtensionTime(builder, IsCompleteExtensionTime);
    MiniGameMissionExcel.AddViewFlag(builder, ViewFlag);
    return MiniGameMissionExcel.EndMiniGameMissionExcel(builder);
  }

  public static void StartMiniGameMissionExcel(FlatBufferBuilder builder) { builder.StartTable(24); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(2, GroupId, 0); }
  public static void AddGroupName(FlatBufferBuilder builder, StringOffset GroupNameOffset) { builder.AddOffset(3, GroupNameOffset.Value, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatDataJp.MissionCategory Category) { builder.AddInt(4, (int)Category, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset DescriptionOffset) { builder.AddOffset(5, DescriptionOffset.Value, 0); }
  public static void AddResetType(FlatBufferBuilder builder, FlatDataJp.MissionResetType ResetType) { builder.AddInt(6, (int)ResetType, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, FlatDataJp.MissionToastDisplayConditionType ToastDisplayType) { builder.AddInt(7, (int)ToastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset ToastImagePathOffset) { builder.AddOffset(8, ToastImagePathOffset.Value, 0); }
  public static void AddViewFlag(FlatBufferBuilder builder, bool ViewFlag) { builder.AddBool(9, ViewFlag, false); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(10, DisplayOrder, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset PreMissionIdOffset) { builder.AddOffset(11, PreMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAccountType(FlatBufferBuilder builder, FlatDataJp.AccountState AccountType) { builder.AddInt(12, (int)AccountType, 0); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long AccountLevel) { builder.AddLong(13, AccountLevel, 0); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset ShortcutUIOffset) { builder.AddOffset(14, ShortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, FlatDataJp.MissionCompleteConditionType CompleteConditionType) { builder.AddInt(15, (int)CompleteConditionType, 0); }
  public static void AddIsCompleteExtensionTime(FlatBufferBuilder builder, bool IsCompleteExtensionTime) { builder.AddBool(16, IsCompleteExtensionTime, false); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long CompleteConditionCount) { builder.AddLong(17, CompleteConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterOffset) { builder.AddOffset(18, CompleteConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterName(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterNameOffset) { builder.AddOffset(19, CompleteConditionParameterNameOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardIcon(FlatBufferBuilder builder, StringOffset RewardIconOffset) { builder.AddOffset(20, RewardIconOffset.Value, 0); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset MissionRewardParcelTypeOffset) { builder.AddOffset(21, MissionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset MissionRewardParcelIdOffset) { builder.AddOffset(22, MissionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset MissionRewardAmountOffset) { builder.AddOffset(23, MissionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.MiniGameMissionExcel> EndMiniGameMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.MiniGameMissionExcel>(o);
  }
}


}
