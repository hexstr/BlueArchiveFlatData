// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticalSupportSystemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static TacticalSupportSystemExcel GetRootAsTacticalSupportSystemExcel(ByteBuffer _bb) { return GetRootAsTacticalSupportSystemExcel(_bb, new TacticalSupportSystemExcel()); }
  public static TacticalSupportSystemExcel GetRootAsTacticalSupportSystemExcel(ByteBuffer _bb, TacticalSupportSystemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticalSupportSystemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SummonedTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefaultPersonalityId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CanTargeting { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool CanCover { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ObstacleUniqueName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetObstacleUniqueNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetObstacleUniqueNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetObstacleUniqueNameArray() { return __p.__vector_as_array<byte>(14); }
  public long ObstacleCoverRange { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SummonSkilllGroupId { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSummonSkilllGroupIdBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSummonSkilllGroupIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSummonSkilllGroupIdArray() { return __p.__vector_as_array<byte>(18); }
  public long CrashObstacleOBBWidth { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CrashObstacleOBBHeight { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsTSSBlockedNodeCheck { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int NumberOfUses { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float InventoryOffsetX { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float InventoryOffsetY { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float InventoryOffsetZ { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long InteractionChar(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int InteractionCharLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetInteractionCharBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetInteractionCharBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetInteractionCharArray() { return __p.__vector_as_array<long>(34); }
  public long CharacterInteractionStartDelay { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GetOnStartEffectPath { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGetOnStartEffectPathBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetGetOnStartEffectPathBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetGetOnStartEffectPathArray() { return __p.__vector_as_array<byte>(38); }
  public string GetOnEndEffectPath { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGetOnEndEffectPathBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetGetOnEndEffectPathBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetGetOnEndEffectPathArray() { return __p.__vector_as_array<byte>(40); }

  public static Offset<FlatDataGlobal.TacticalSupportSystemExcel> CreateTacticalSupportSystemExcel(FlatBufferBuilder builder,
      long Id = 0,
      long SummonedTime = 0,
      long DefaultPersonalityId = 0,
      bool CanTargeting = false,
      bool CanCover = false,
      StringOffset ObstacleUniqueNameOffset = default(StringOffset),
      long ObstacleCoverRange = 0,
      StringOffset SummonSkilllGroupIdOffset = default(StringOffset),
      long CrashObstacleOBBWidth = 0,
      long CrashObstacleOBBHeight = 0,
      bool IsTSSBlockedNodeCheck = false,
      int NumberOfUses = 0,
      float InventoryOffsetX = 0.0f,
      float InventoryOffsetY = 0.0f,
      float InventoryOffsetZ = 0.0f,
      VectorOffset InteractionCharOffset = default(VectorOffset),
      long CharacterInteractionStartDelay = 0,
      StringOffset GetOnStartEffectPathOffset = default(StringOffset),
      StringOffset GetOnEndEffectPathOffset = default(StringOffset)) {
    builder.StartTable(19);
    TacticalSupportSystemExcel.AddCharacterInteractionStartDelay(builder, CharacterInteractionStartDelay);
    TacticalSupportSystemExcel.AddCrashObstacleOBBHeight(builder, CrashObstacleOBBHeight);
    TacticalSupportSystemExcel.AddCrashObstacleOBBWidth(builder, CrashObstacleOBBWidth);
    TacticalSupportSystemExcel.AddObstacleCoverRange(builder, ObstacleCoverRange);
    TacticalSupportSystemExcel.AddDefaultPersonalityId(builder, DefaultPersonalityId);
    TacticalSupportSystemExcel.AddSummonedTime(builder, SummonedTime);
    TacticalSupportSystemExcel.AddId(builder, Id);
    TacticalSupportSystemExcel.AddGetOnEndEffectPath(builder, GetOnEndEffectPathOffset);
    TacticalSupportSystemExcel.AddGetOnStartEffectPath(builder, GetOnStartEffectPathOffset);
    TacticalSupportSystemExcel.AddInteractionChar(builder, InteractionCharOffset);
    TacticalSupportSystemExcel.AddInventoryOffsetZ(builder, InventoryOffsetZ);
    TacticalSupportSystemExcel.AddInventoryOffsetY(builder, InventoryOffsetY);
    TacticalSupportSystemExcel.AddInventoryOffsetX(builder, InventoryOffsetX);
    TacticalSupportSystemExcel.AddNumberOfUses(builder, NumberOfUses);
    TacticalSupportSystemExcel.AddSummonSkilllGroupId(builder, SummonSkilllGroupIdOffset);
    TacticalSupportSystemExcel.AddObstacleUniqueName(builder, ObstacleUniqueNameOffset);
    TacticalSupportSystemExcel.AddIsTSSBlockedNodeCheck(builder, IsTSSBlockedNodeCheck);
    TacticalSupportSystemExcel.AddCanCover(builder, CanCover);
    TacticalSupportSystemExcel.AddCanTargeting(builder, CanTargeting);
    return TacticalSupportSystemExcel.EndTacticalSupportSystemExcel(builder);
  }

  public static void StartTacticalSupportSystemExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddSummonedTime(FlatBufferBuilder builder, long SummonedTime) { builder.AddLong(1, SummonedTime, 0); }
  public static void AddDefaultPersonalityId(FlatBufferBuilder builder, long DefaultPersonalityId) { builder.AddLong(2, DefaultPersonalityId, 0); }
  public static void AddCanTargeting(FlatBufferBuilder builder, bool CanTargeting) { builder.AddBool(3, CanTargeting, false); }
  public static void AddCanCover(FlatBufferBuilder builder, bool CanCover) { builder.AddBool(4, CanCover, false); }
  public static void AddObstacleUniqueName(FlatBufferBuilder builder, StringOffset ObstacleUniqueNameOffset) { builder.AddOffset(5, ObstacleUniqueNameOffset.Value, 0); }
  public static void AddObstacleCoverRange(FlatBufferBuilder builder, long ObstacleCoverRange) { builder.AddLong(6, ObstacleCoverRange, 0); }
  public static void AddSummonSkilllGroupId(FlatBufferBuilder builder, StringOffset SummonSkilllGroupIdOffset) { builder.AddOffset(7, SummonSkilllGroupIdOffset.Value, 0); }
  public static void AddCrashObstacleOBBWidth(FlatBufferBuilder builder, long CrashObstacleOBBWidth) { builder.AddLong(8, CrashObstacleOBBWidth, 0); }
  public static void AddCrashObstacleOBBHeight(FlatBufferBuilder builder, long CrashObstacleOBBHeight) { builder.AddLong(9, CrashObstacleOBBHeight, 0); }
  public static void AddIsTSSBlockedNodeCheck(FlatBufferBuilder builder, bool IsTSSBlockedNodeCheck) { builder.AddBool(10, IsTSSBlockedNodeCheck, false); }
  public static void AddNumberOfUses(FlatBufferBuilder builder, int NumberOfUses) { builder.AddInt(11, NumberOfUses, 0); }
  public static void AddInventoryOffsetX(FlatBufferBuilder builder, float InventoryOffsetX) { builder.AddFloat(12, InventoryOffsetX, 0.0f); }
  public static void AddInventoryOffsetY(FlatBufferBuilder builder, float InventoryOffsetY) { builder.AddFloat(13, InventoryOffsetY, 0.0f); }
  public static void AddInventoryOffsetZ(FlatBufferBuilder builder, float InventoryOffsetZ) { builder.AddFloat(14, InventoryOffsetZ, 0.0f); }
  public static void AddInteractionChar(FlatBufferBuilder builder, VectorOffset InteractionCharOffset) { builder.AddOffset(15, InteractionCharOffset.Value, 0); }
  public static VectorOffset CreateInteractionCharVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInteractionCharVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionCharVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionCharVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInteractionCharVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCharacterInteractionStartDelay(FlatBufferBuilder builder, long CharacterInteractionStartDelay) { builder.AddLong(16, CharacterInteractionStartDelay, 0); }
  public static void AddGetOnStartEffectPath(FlatBufferBuilder builder, StringOffset GetOnStartEffectPathOffset) { builder.AddOffset(17, GetOnStartEffectPathOffset.Value, 0); }
  public static void AddGetOnEndEffectPath(FlatBufferBuilder builder, StringOffset GetOnEndEffectPathOffset) { builder.AddOffset(18, GetOnEndEffectPathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.TacticalSupportSystemExcel> EndTacticalSupportSystemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.TacticalSupportSystemExcel>(o);
  }
}


}
