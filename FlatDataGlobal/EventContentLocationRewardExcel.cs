// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentLocationRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentLocationRewardExcel GetRootAsEventContentLocationRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentLocationRewardExcel(_bb, new EventContentLocationRewardExcel()); }
  public static EventContentLocationRewardExcel GetRootAsEventContentLocationRewardExcel(ByteBuffer _bb, EventContentLocationRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentLocationRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Location { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocationBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLocationBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLocationArray() { return __p.__vector_as_array<byte>(4); }
  public long ScheduleGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OrderInGroup { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ProgressTexture { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressTextureBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetProgressTextureBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetProgressTextureArray() { return __p.__vector_as_array<byte>(12); }
  public string VoiceClipsKr(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsKrLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string VoiceClipsJp(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int VoiceClipsJpLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long LocationRank { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FavorExp { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SecretStoneAmount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SecretStoneProb { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtraFavorExp { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtraFavorExpProb { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType ExtraRewardParcelType(int j) { int o = __p.__offset(32); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int ExtraRewardParcelTypeLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetExtraRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(32, 4); }
#else
  public ArraySegment<byte>? GetExtraRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public FlatDataGlobal.ParcelType[] GetExtraRewardParcelTypeArray() { int o = __p.__offset(32); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ExtraRewardParcelId(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardParcelIdLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardParcelIdBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardParcelIdBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetExtraRewardParcelIdArray() { return __p.__vector_as_array<long>(34); }
  public long ExtraRewardAmount(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardAmountLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardAmountBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardAmountBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetExtraRewardAmountArray() { return __p.__vector_as_array<long>(36); }
  public long ExtraRewardProb(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardProbLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardProbBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardProbBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetExtraRewardProbArray() { return __p.__vector_as_array<long>(38); }
  public bool IsExtraRewardDisplayed(int j) { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int IsExtraRewardDisplayedLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetIsExtraRewardDisplayedBytes() { return __p.__vector_as_span<bool>(40, 1); }
#else
  public ArraySegment<byte>? GetIsExtraRewardDisplayedBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public bool[] GetIsExtraRewardDisplayedArray() { return __p.__vector_as_array<bool>(40); }
  public FlatDataGlobal.ParcelType RewardParcelType(int j) { int o = __p.__offset(42); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(42, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public FlatDataGlobal.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(42); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(44, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(44); }
  public long RewardAmount(int j) { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardAmountLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardAmountBytes() { return __p.__vector_as_span<long>(46, 8); }
#else
  public ArraySegment<byte>? GetRewardAmountBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public long[] GetRewardAmountArray() { return __p.__vector_as_array<long>(46); }

  public static Offset<FlatDataGlobal.EventContentLocationRewardExcel> CreateEventContentLocationRewardExcel(FlatBufferBuilder builder,
      StringOffset LocationOffset = default(StringOffset),
      long ScheduleGroupId = 0,
      long OrderInGroup = 0,
      long Id = 0,
      StringOffset ProgressTextureOffset = default(StringOffset),
      VectorOffset VoiceClipsKrOffset = default(VectorOffset),
      VectorOffset VoiceClipsJpOffset = default(VectorOffset),
      uint LocalizeEtcId = 0,
      long LocationRank = 0,
      long FavorExp = 0,
      long SecretStoneAmount = 0,
      long SecretStoneProb = 0,
      long ExtraFavorExp = 0,
      long ExtraFavorExpProb = 0,
      VectorOffset ExtraRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset ExtraRewardParcelIdOffset = default(VectorOffset),
      VectorOffset ExtraRewardAmountOffset = default(VectorOffset),
      VectorOffset ExtraRewardProbOffset = default(VectorOffset),
      VectorOffset IsExtraRewardDisplayedOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(22);
    EventContentLocationRewardExcel.AddExtraFavorExpProb(builder, ExtraFavorExpProb);
    EventContentLocationRewardExcel.AddExtraFavorExp(builder, ExtraFavorExp);
    EventContentLocationRewardExcel.AddSecretStoneProb(builder, SecretStoneProb);
    EventContentLocationRewardExcel.AddSecretStoneAmount(builder, SecretStoneAmount);
    EventContentLocationRewardExcel.AddFavorExp(builder, FavorExp);
    EventContentLocationRewardExcel.AddLocationRank(builder, LocationRank);
    EventContentLocationRewardExcel.AddId(builder, Id);
    EventContentLocationRewardExcel.AddOrderInGroup(builder, OrderInGroup);
    EventContentLocationRewardExcel.AddScheduleGroupId(builder, ScheduleGroupId);
    EventContentLocationRewardExcel.AddRewardAmount(builder, RewardAmountOffset);
    EventContentLocationRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentLocationRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentLocationRewardExcel.AddIsExtraRewardDisplayed(builder, IsExtraRewardDisplayedOffset);
    EventContentLocationRewardExcel.AddExtraRewardProb(builder, ExtraRewardProbOffset);
    EventContentLocationRewardExcel.AddExtraRewardAmount(builder, ExtraRewardAmountOffset);
    EventContentLocationRewardExcel.AddExtraRewardParcelId(builder, ExtraRewardParcelIdOffset);
    EventContentLocationRewardExcel.AddExtraRewardParcelType(builder, ExtraRewardParcelTypeOffset);
    EventContentLocationRewardExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentLocationRewardExcel.AddVoiceClipsJp(builder, VoiceClipsJpOffset);
    EventContentLocationRewardExcel.AddVoiceClipsKr(builder, VoiceClipsKrOffset);
    EventContentLocationRewardExcel.AddProgressTexture(builder, ProgressTextureOffset);
    EventContentLocationRewardExcel.AddLocation(builder, LocationOffset);
    return EventContentLocationRewardExcel.EndEventContentLocationRewardExcel(builder);
  }

  public static void StartEventContentLocationRewardExcel(FlatBufferBuilder builder) { builder.StartTable(22); }
  public static void AddLocation(FlatBufferBuilder builder, StringOffset LocationOffset) { builder.AddOffset(0, LocationOffset.Value, 0); }
  public static void AddScheduleGroupId(FlatBufferBuilder builder, long ScheduleGroupId) { builder.AddLong(1, ScheduleGroupId, 0); }
  public static void AddOrderInGroup(FlatBufferBuilder builder, long OrderInGroup) { builder.AddLong(2, OrderInGroup, 0); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(3, Id, 0); }
  public static void AddProgressTexture(FlatBufferBuilder builder, StringOffset ProgressTextureOffset) { builder.AddOffset(4, ProgressTextureOffset.Value, 0); }
  public static void AddVoiceClipsKr(FlatBufferBuilder builder, VectorOffset VoiceClipsKrOffset) { builder.AddOffset(5, VoiceClipsKrOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsKrVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsKrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsKrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceClipsJp(FlatBufferBuilder builder, VectorOffset VoiceClipsJpOffset) { builder.AddOffset(6, VoiceClipsJpOffset.Value, 0); }
  public static VectorOffset CreateVoiceClipsJpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceClipsJpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceClipsJpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(7, LocalizeEtcId, 0); }
  public static void AddLocationRank(FlatBufferBuilder builder, long LocationRank) { builder.AddLong(8, LocationRank, 0); }
  public static void AddFavorExp(FlatBufferBuilder builder, long FavorExp) { builder.AddLong(9, FavorExp, 0); }
  public static void AddSecretStoneAmount(FlatBufferBuilder builder, long SecretStoneAmount) { builder.AddLong(10, SecretStoneAmount, 0); }
  public static void AddSecretStoneProb(FlatBufferBuilder builder, long SecretStoneProb) { builder.AddLong(11, SecretStoneProb, 0); }
  public static void AddExtraFavorExp(FlatBufferBuilder builder, long ExtraFavorExp) { builder.AddLong(12, ExtraFavorExp, 0); }
  public static void AddExtraFavorExpProb(FlatBufferBuilder builder, long ExtraFavorExpProb) { builder.AddLong(13, ExtraFavorExpProb, 0); }
  public static void AddExtraRewardParcelType(FlatBufferBuilder builder, VectorOffset ExtraRewardParcelTypeOffset) { builder.AddOffset(14, ExtraRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraRewardParcelId(FlatBufferBuilder builder, VectorOffset ExtraRewardParcelIdOffset) { builder.AddOffset(15, ExtraRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExtraRewardAmount(FlatBufferBuilder builder, VectorOffset ExtraRewardAmountOffset) { builder.AddOffset(16, ExtraRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExtraRewardProb(FlatBufferBuilder builder, VectorOffset ExtraRewardProbOffset) { builder.AddOffset(17, ExtraRewardProbOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardProbVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardProbVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIsExtraRewardDisplayed(FlatBufferBuilder builder, VectorOffset IsExtraRewardDisplayedOffset) { builder.AddOffset(18, IsExtraRewardDisplayedOffset.Value, 0); }
  public static VectorOffset CreateIsExtraRewardDisplayedVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIsExtraRewardDisplayedVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset RewardParcelTypeOffset) { builder.AddOffset(19, RewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset RewardParcelIdOffset) { builder.AddOffset(20, RewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardAmount(FlatBufferBuilder builder, VectorOffset RewardAmountOffset) { builder.AddOffset(21, RewardAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.EventContentLocationRewardExcel> EndEventContentLocationRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentLocationRewardExcel>(o);
  }
}


}
