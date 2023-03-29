// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideMissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static GuideMissionExcel GetRootAsGuideMissionExcel(ByteBuffer _bb) { return GetRootAsGuideMissionExcel(_bb, new GuideMissionExcel()); }
  public static GuideMissionExcel GetRootAsGuideMissionExcel(ByteBuffer _bb, GuideMissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideMissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.MissionCategory Category { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCategory.Challenge; } }
  public bool IsLegacy { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long LoginCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreMissionId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreMissionIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreMissionIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetPreMissionIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetPreMissionIdArray() { return __p.__vector_as_array<long>(14); }
  public string Description { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(16); }
  public FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(18); return o != 0 ? (FlatDataGlobal.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionToastDisplayConditionType.Always; } }
  public string ToastImagePath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetToastImagePathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetToastImagePathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetToastImagePathArray() { return __p.__vector_as_array<byte>(20); }
  public string ShortcutUI(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataGlobal.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataGlobal.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MissionCompleteConditionType.None; } }
  public long CompleteConditionCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(28); }
  public string CompleteConditionParameterName { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCompleteConditionParameterNameBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterNameBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetCompleteConditionParameterNameArray() { return __p.__vector_as_array<byte>(30); }
  public FlatDataGlobal.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(32); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(32, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public FlatDataGlobal.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(32); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(34); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(36, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(36); }

  public static Offset<FlatDataGlobal.GuideMissionExcel> CreateGuideMissionExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long Id = 0,
      FlatDataGlobal.MissionCategory Category = FlatDataGlobal.MissionCategory.Challenge,
      bool IsLegacy = false,
      long LoginCount = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      StringOffset DescriptionOffset = default(StringOffset),
      FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType = FlatDataGlobal.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      FlatDataGlobal.MissionCompleteConditionType CompleteConditionType = FlatDataGlobal.MissionCompleteConditionType.None,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      StringOffset CompleteConditionParameterNameOffset = default(StringOffset),
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(17);
    GuideMissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    GuideMissionExcel.AddLoginCount(builder, LoginCount);
    GuideMissionExcel.AddId(builder, Id);
    GuideMissionExcel.AddSeasonId(builder, SeasonId);
    GuideMissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    GuideMissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    GuideMissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    GuideMissionExcel.AddCompleteConditionParameterName(builder, CompleteConditionParameterNameOffset);
    GuideMissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    GuideMissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    GuideMissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    GuideMissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    GuideMissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    GuideMissionExcel.AddDescription(builder, DescriptionOffset);
    GuideMissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    GuideMissionExcel.AddCategory(builder, Category);
    GuideMissionExcel.AddIsLegacy(builder, IsLegacy);
    return GuideMissionExcel.EndGuideMissionExcel(builder);
  }

  public static void StartGuideMissionExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddSeasonId(FlatBufferBuilder builder, long SeasonId) { builder.AddLong(0, SeasonId, 0); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(1, Id, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatDataGlobal.MissionCategory Category) { builder.AddInt(2, (int)Category, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool IsLegacy) { builder.AddBool(3, IsLegacy, false); }
  public static void AddLoginCount(FlatBufferBuilder builder, long LoginCount) { builder.AddLong(4, LoginCount, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset PreMissionIdOffset) { builder.AddOffset(5, PreMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset DescriptionOffset) { builder.AddOffset(6, DescriptionOffset.Value, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, FlatDataGlobal.MissionToastDisplayConditionType ToastDisplayType) { builder.AddInt(7, (int)ToastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset ToastImagePathOffset) { builder.AddOffset(8, ToastImagePathOffset.Value, 0); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset ShortcutUIOffset) { builder.AddOffset(9, ShortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, FlatDataGlobal.MissionCompleteConditionType CompleteConditionType) { builder.AddInt(10, (int)CompleteConditionType, 0); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long CompleteConditionCount) { builder.AddLong(11, CompleteConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset CompleteConditionParameterOffset) { builder.AddOffset(12, CompleteConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterName(FlatBufferBuilder builder, StringOffset CompleteConditionParameterNameOffset) { builder.AddOffset(13, CompleteConditionParameterNameOffset.Value, 0); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset MissionRewardParcelTypeOffset) { builder.AddOffset(14, MissionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset MissionRewardParcelIdOffset) { builder.AddOffset(15, MissionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset MissionRewardAmountOffset) { builder.AddOffset(16, MissionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.GuideMissionExcel> EndGuideMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.GuideMissionExcel>(o);
  }
}


}
