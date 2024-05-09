// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentMissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentMissionExcel GetRootAsEventContentMissionExcel(ByteBuffer _bb) { return GetRootAsEventContentMissionExcel(_bb, new EventContentMissionExcel()); }
  public static EventContentMissionExcel GetRootAsEventContentMissionExcel(ByteBuffer _bb, EventContentMissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public FlatDataGlobal.MissionCategory Category { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCategory.Challenge; } }
  public string Description { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(14); }
  public FlatDataGlobal.MissionResetType ResetType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataGlobal.MissionResetType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionResetType.None; } }
  public FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(18); return o != 0 ? (FlatDataGlobal.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionToastDisplayConditionType.Always; } }
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
  public FlatDataGlobal.AccountState AccountType { get { int o = __p.__offset(28); return o != 0 ? (FlatDataGlobal.AccountState)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.AccountState.WaitingSignIn; } }
  public long AccountLevel { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ShortcutUI(int j) { int o = __p.__offset(32); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long ChallengeStageShortcut { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(36); return o != 0 ? (FlatDataGlobal.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCompleteConditionType.None; } }
  public bool IsCompleteExtensionTime { get { int o = __p.__offset(38); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CompleteConditionCount { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(42, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(42); }
  public FlatDataGlobal.Tag CompleteConditionParameterTag(int j) { int o = __p.__offset(44); return o != 0 ? (FlatDataGlobal.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.Tag)0; }
  public int CompleteConditionParameterTagLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.Tag> GetCompleteConditionParameterTagBytes() { return __p.__vector_as_span<FlatDataGlobal.Tag>(44, 4); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterTagBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public FlatDataGlobal.Tag[] GetCompleteConditionParameterTagArray() { int o = __p.__offset(44); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.Tag[] a = new FlatDataGlobal.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public string RewardIcon { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardIconBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetRewardIconBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetRewardIconArray() { return __p.__vector_as_array<byte>(46); }
  public long CompleteConditionMissionId(int j) { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionMissionIdLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionMissionIdBytes() { return __p.__vector_as_span<long>(48, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionMissionIdBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public long[] GetCompleteConditionMissionIdArray() { return __p.__vector_as_array<long>(48); }
  public long CompleteConditionMissionCount { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(52); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(52); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(52, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public FlatDataGlobal.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(52); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(54); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(54, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(54); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(56, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(56); }
  public FlatDataGlobal.ParcelType ConditionRewardParcelType(int j) { int o = __p.__offset(58); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int ConditionRewardParcelTypeLength { get { int o = __p.__offset(58); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetConditionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(58, 4); }
#else
  public ArraySegment<byte>? GetConditionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public FlatDataGlobal.ParcelType[] GetConditionRewardParcelTypeArray() { int o = __p.__offset(58); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ConditionRewardParcelId(int j) { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionRewardParcelIdLength { get { int o = __p.__offset(60); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionRewardParcelIdBytes() { return __p.__vector_as_span<long>(60, 8); }
#else
  public ArraySegment<byte>? GetConditionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public long[] GetConditionRewardParcelIdArray() { return __p.__vector_as_array<long>(60); }
  public int ConditionRewardAmount(int j) { int o = __p.__offset(62); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ConditionRewardAmountLength { get { int o = __p.__offset(62); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetConditionRewardAmountBytes() { return __p.__vector_as_span<int>(62, 4); }
#else
  public ArraySegment<byte>? GetConditionRewardAmountBytes() { return __p.__vector_as_arraysegment(62); }
#endif
  public int[] GetConditionRewardAmountArray() { return __p.__vector_as_array<int>(62); }

  public static Offset<FlatDataGlobal.EventContentMissionExcel> CreateEventContentMissionExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long GroupId = 0,
      StringOffset GroupNameOffset = default(StringOffset),
      FlatDataGlobal.MissionCategory Category = FlatDataGlobal.MissionCategory.Challenge,
      StringOffset DescriptionOffset = default(StringOffset),
      FlatDataGlobal.MissionResetType ResetType = FlatDataGlobal.MissionResetType.None,
      FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType = FlatDataGlobal.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      bool ViewFlag = false,
      long DisplayOrder = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      FlatDataGlobal.AccountState AccountType = FlatDataGlobal.AccountState.WaitingSignIn,
      long AccountLevel = 0,
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      long ChallengeStageShortcut = 0,
      FlatDataGlobal.MissionCompleteConditionType CompleteConditionType = FlatDataGlobal.MissionCompleteConditionType.None,
      bool IsCompleteExtensionTime = false,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      VectorOffset CompleteConditionParameterTagOffset = default(VectorOffset),
      StringOffset RewardIconOffset = default(StringOffset),
      VectorOffset CompleteConditionMissionIdOffset = default(VectorOffset),
      long CompleteConditionMissionCount = 0,
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset),
      VectorOffset ConditionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset ConditionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset ConditionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(30);
    EventContentMissionExcel.AddCompleteConditionMissionCount(builder, CompleteConditionMissionCount);
    EventContentMissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    EventContentMissionExcel.AddChallengeStageShortcut(builder, ChallengeStageShortcut);
    EventContentMissionExcel.AddAccountLevel(builder, AccountLevel);
    EventContentMissionExcel.AddDisplayOrder(builder, DisplayOrder);
    EventContentMissionExcel.AddGroupId(builder, GroupId);
    EventContentMissionExcel.AddEventContentId(builder, EventContentId);
    EventContentMissionExcel.AddId(builder, Id);
    EventContentMissionExcel.AddConditionRewardAmount(builder, ConditionRewardAmountOffset);
    EventContentMissionExcel.AddConditionRewardParcelId(builder, ConditionRewardParcelIdOffset);
    EventContentMissionExcel.AddConditionRewardParcelType(builder, ConditionRewardParcelTypeOffset);
    EventContentMissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    EventContentMissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    EventContentMissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    EventContentMissionExcel.AddCompleteConditionMissionId(builder, CompleteConditionMissionIdOffset);
    EventContentMissionExcel.AddRewardIcon(builder, RewardIconOffset);
    EventContentMissionExcel.AddCompleteConditionParameterTag(builder, CompleteConditionParameterTagOffset);
    EventContentMissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    EventContentMissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    EventContentMissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    EventContentMissionExcel.AddAccountType(builder, AccountType);
    EventContentMissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    EventContentMissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    EventContentMissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    EventContentMissionExcel.AddResetType(builder, ResetType);
    EventContentMissionExcel.AddDescription(builder, DescriptionOffset);
    EventContentMissionExcel.AddCategory(builder, Category);
    EventContentMissionExcel.AddGroupName(builder, GroupNameOffset);
    EventContentMissionExcel.AddIsCompleteExtensionTime(builder, IsCompleteExtensionTime);
    EventContentMissionExcel.AddViewFlag(builder, ViewFlag);
    return EventContentMissionExcel.EndEventContentMissionExcel(builder);
  }

  public static void StartEventContentMissionExcel(FlatBufferBuilder builder) { builder.StartTable(30); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(2, GroupId, 0); }
  public static void AddGroupName(FlatBufferBuilder builder, StringOffset GroupNameOffset) { builder.AddOffset(3, GroupNameOffset.Value, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatDataGlobal.MissionCategory Category) { builder.AddInt(4, (int)Category, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset DescriptionOffset) { builder.AddOffset(5, DescriptionOffset.Value, 0); }
  public static void AddResetType(FlatBufferBuilder builder, FlatDataGlobal.MissionResetType ResetType) { builder.AddInt(6, (int)ResetType, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType) { builder.AddInt(7, (int)ToastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset ToastImagePathOffset) { builder.AddOffset(8, ToastImagePathOffset.Value, 0); }
  public static void AddViewFlag(FlatBufferBuilder builder, bool ViewFlag) { builder.AddBool(9, ViewFlag, false); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(10, DisplayOrder, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset PreMissionIdOffset) { builder.AddOffset(11, PreMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAccountType(FlatBufferBuilder builder, FlatDataGlobal.AccountState AccountType) { builder.AddInt(12, (int)AccountType, 0); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long AccountLevel) { builder.AddLong(13, AccountLevel, 0); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset ShortcutUIOffset) { builder.AddOffset(14, ShortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChallengeStageShortcut(FlatBufferBuilder builder, long ChallengeStageShortcut) { builder.AddLong(15, ChallengeStageShortcut, 0); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, FlatDataGlobal.MissionCompleteConditionType CompleteConditionType) { builder.AddInt(16, (int)CompleteConditionType, 0); }
  public static void AddIsCompleteExtensionTime(FlatBufferBuilder builder, bool IsCompleteExtensionTime) { builder.AddBool(17, IsCompleteExtensionTime, false); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long CompleteConditionCount) { builder.AddLong(18, CompleteConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterOffset) { builder.AddOffset(19, CompleteConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterTag(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterTagOffset) { builder.AddOffset(20, CompleteConditionParameterTagOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterTagVector(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterTagVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardIcon(FlatBufferBuilder builder, StringOffset RewardIconOffset) { builder.AddOffset(21, RewardIconOffset.Value, 0); }
  public static void AddCompleteConditionMissionId(FlatBufferBuilder builder, VectorOffset CompleteConditionMissionIdOffset) { builder.AddOffset(22, CompleteConditionMissionIdOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionMissionCount(FlatBufferBuilder builder, long CompleteConditionMissionCount) { builder.AddLong(23, CompleteConditionMissionCount, 0); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset MissionRewardParcelTypeOffset) { builder.AddOffset(24, MissionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset MissionRewardParcelIdOffset) { builder.AddOffset(25, MissionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset MissionRewardAmountOffset) { builder.AddOffset(26, MissionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConditionRewardParcelType(FlatBufferBuilder builder, VectorOffset ConditionRewardParcelTypeOffset) { builder.AddOffset(27, ConditionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateConditionRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConditionRewardParcelId(FlatBufferBuilder builder, VectorOffset ConditionRewardParcelIdOffset) { builder.AddOffset(28, ConditionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateConditionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionRewardAmount(FlatBufferBuilder builder, VectorOffset ConditionRewardAmountOffset) { builder.AddOffset(29, ConditionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateConditionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.EventContentMissionExcel> EndEventContentMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentMissionExcel>(o);
  }
}


}
