// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGThemaExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MinigameTBGThemaExcel GetRootAsMinigameTBGThemaExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGThemaExcel(_bb, new MinigameTBGThemaExcel()); }
  public static MinigameTBGThemaExcel GetRootAsMinigameTBGThemaExcel(ByteBuffer _bb, MinigameTBGThemaExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGThemaExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ThemaIndex { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.TBGThemaType ThemaType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.TBGThemaType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TBGThemaType.None; } }
  public string ThemaMap { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaMapBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetThemaMapBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetThemaMapArray() { return __p.__vector_as_array<byte>(12); }
  public string ThemaMapBG { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaMapBGBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetThemaMapBGBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetThemaMapBGArray() { return __p.__vector_as_array<byte>(14); }
  public FlatDataJp.TBGPortalCondition PortalCondition(int j) { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.TBGPortalCondition)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.TBGPortalCondition)0; }
  public int PortalConditionLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.TBGPortalCondition> GetPortalConditionBytes() { return __p.__vector_as_span<FlatDataJp.TBGPortalCondition>(16, 4); }
#else
  public ArraySegment<byte>? GetPortalConditionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public FlatDataJp.TBGPortalCondition[] GetPortalConditionArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.TBGPortalCondition[] a = new FlatDataJp.TBGPortalCondition[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.TBGPortalCondition)__p.bb.GetInt(p + i * 4); } return a; }
  public string PortalConditionParameter(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PortalConditionParameterLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ThemaNameLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaNameLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetThemaNameLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetThemaNameLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public string ThemaLoadingImage { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaLoadingImageBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetThemaLoadingImageBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetThemaLoadingImageArray() { return __p.__vector_as_array<byte>(22); }
  public string ThemaPlayerPrefab { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaPlayerPrefabBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetThemaPlayerPrefabBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetThemaPlayerPrefabArray() { return __p.__vector_as_array<byte>(24); }
  public long ThemaLeaderId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ThemaGoalLocalize { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaGoalLocalizeBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetThemaGoalLocalizeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetThemaGoalLocalizeArray() { return __p.__vector_as_array<byte>(28); }
  public long InstantClearCostAmount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.MinigameTBGThemaExcel> CreateMinigameTBGThemaExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long UniqueId = 0,
      int ThemaIndex = 0,
      FlatDataJp.TBGThemaType ThemaType = FlatDataJp.TBGThemaType.None,
      StringOffset ThemaMapOffset = default(StringOffset),
      StringOffset ThemaMapBGOffset = default(StringOffset),
      VectorOffset PortalConditionOffset = default(VectorOffset),
      VectorOffset PortalConditionParameterOffset = default(VectorOffset),
      StringOffset ThemaNameLocalizeOffset = default(StringOffset),
      StringOffset ThemaLoadingImageOffset = default(StringOffset),
      StringOffset ThemaPlayerPrefabOffset = default(StringOffset),
      long ThemaLeaderId = 0,
      StringOffset ThemaGoalLocalizeOffset = default(StringOffset),
      long InstantClearCostAmount = 0) {
    builder.StartTable(14);
    MinigameTBGThemaExcel.AddInstantClearCostAmount(builder, InstantClearCostAmount);
    MinigameTBGThemaExcel.AddThemaLeaderId(builder, ThemaLeaderId);
    MinigameTBGThemaExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGThemaExcel.AddEventContentId(builder, EventContentId);
    MinigameTBGThemaExcel.AddThemaGoalLocalize(builder, ThemaGoalLocalizeOffset);
    MinigameTBGThemaExcel.AddThemaPlayerPrefab(builder, ThemaPlayerPrefabOffset);
    MinigameTBGThemaExcel.AddThemaLoadingImage(builder, ThemaLoadingImageOffset);
    MinigameTBGThemaExcel.AddThemaNameLocalize(builder, ThemaNameLocalizeOffset);
    MinigameTBGThemaExcel.AddPortalConditionParameter(builder, PortalConditionParameterOffset);
    MinigameTBGThemaExcel.AddPortalCondition(builder, PortalConditionOffset);
    MinigameTBGThemaExcel.AddThemaMapBG(builder, ThemaMapBGOffset);
    MinigameTBGThemaExcel.AddThemaMap(builder, ThemaMapOffset);
    MinigameTBGThemaExcel.AddThemaType(builder, ThemaType);
    MinigameTBGThemaExcel.AddThemaIndex(builder, ThemaIndex);
    return MinigameTBGThemaExcel.EndMinigameTBGThemaExcel(builder);
  }

  public static void StartMinigameTBGThemaExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(1, UniqueId, 0); }
  public static void AddThemaIndex(FlatBufferBuilder builder, int ThemaIndex) { builder.AddInt(2, ThemaIndex, 0); }
  public static void AddThemaType(FlatBufferBuilder builder, FlatDataJp.TBGThemaType ThemaType) { builder.AddInt(3, (int)ThemaType, 0); }
  public static void AddThemaMap(FlatBufferBuilder builder, StringOffset ThemaMapOffset) { builder.AddOffset(4, ThemaMapOffset.Value, 0); }
  public static void AddThemaMapBG(FlatBufferBuilder builder, StringOffset ThemaMapBGOffset) { builder.AddOffset(5, ThemaMapBGOffset.Value, 0); }
  public static void AddPortalCondition(FlatBufferBuilder builder, VectorOffset PortalConditionOffset) { builder.AddOffset(6, PortalConditionOffset.Value, 0); }
  public static VectorOffset CreatePortalConditionVector(FlatBufferBuilder builder, FlatDataJp.TBGPortalCondition[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, FlatDataJp.TBGPortalCondition[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.TBGPortalCondition> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.TBGPortalCondition>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPortalConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPortalConditionParameter(FlatBufferBuilder builder, VectorOffset PortalConditionParameterOffset) { builder.AddOffset(7, PortalConditionParameterOffset.Value, 0); }
  public static VectorOffset CreatePortalConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPortalConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddThemaNameLocalize(FlatBufferBuilder builder, StringOffset ThemaNameLocalizeOffset) { builder.AddOffset(8, ThemaNameLocalizeOffset.Value, 0); }
  public static void AddThemaLoadingImage(FlatBufferBuilder builder, StringOffset ThemaLoadingImageOffset) { builder.AddOffset(9, ThemaLoadingImageOffset.Value, 0); }
  public static void AddThemaPlayerPrefab(FlatBufferBuilder builder, StringOffset ThemaPlayerPrefabOffset) { builder.AddOffset(10, ThemaPlayerPrefabOffset.Value, 0); }
  public static void AddThemaLeaderId(FlatBufferBuilder builder, long ThemaLeaderId) { builder.AddLong(11, ThemaLeaderId, 0); }
  public static void AddThemaGoalLocalize(FlatBufferBuilder builder, StringOffset ThemaGoalLocalizeOffset) { builder.AddOffset(12, ThemaGoalLocalizeOffset.Value, 0); }
  public static void AddInstantClearCostAmount(FlatBufferBuilder builder, long InstantClearCostAmount) { builder.AddLong(13, InstantClearCostAmount, 0); }
  public static Offset<FlatDataJp.MinigameTBGThemaExcel> EndMinigameTBGThemaExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.MinigameTBGThemaExcel>(o);
  }
}


}
