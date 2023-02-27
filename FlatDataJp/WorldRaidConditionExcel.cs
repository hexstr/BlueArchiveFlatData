// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WorldRaidConditionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static WorldRaidConditionExcel GetRootAsWorldRaidConditionExcel(ByteBuffer _bb) { return GetRootAsWorldRaidConditionExcel(_bb, new WorldRaidConditionExcel()); }
  public static WorldRaidConditionExcel GetRootAsWorldRaidConditionExcel(ByteBuffer _bb, WorldRaidConditionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidConditionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LockUI(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LockUILength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool HideWhenLocked { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ScenarioModeIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetScenarioModeIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetScenarioModeIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetScenarioModeIdArray() { return __p.__vector_as_array<long>(12); }
  public long CampaignStageID(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CampaignStageIDLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCampaignStageIDBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetCampaignStageIDBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetCampaignStageIDArray() { return __p.__vector_as_array<long>(14); }
  public FlatDataJp.MultipleConditionCheckType MultipleConditionCheckType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.MultipleConditionCheckType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MultipleConditionCheckType.And; } }
  public string AfterWhenDate { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAfterWhenDateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetAfterWhenDateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetAfterWhenDateArray() { return __p.__vector_as_array<byte>(18); }
  public long WorldRaidBossKill(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int WorldRaidBossKillLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetWorldRaidBossKillBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetWorldRaidBossKillBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetWorldRaidBossKillArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<FlatDataJp.WorldRaidConditionExcel> CreateWorldRaidConditionExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset LockUIOffset = default(VectorOffset),
      bool HideWhenLocked = false,
      long AccountLevel = 0,
      VectorOffset ScenarioModeIdOffset = default(VectorOffset),
      VectorOffset CampaignStageIDOffset = default(VectorOffset),
      FlatDataJp.MultipleConditionCheckType MultipleConditionCheckType = FlatDataJp.MultipleConditionCheckType.And,
      StringOffset AfterWhenDateOffset = default(StringOffset),
      VectorOffset WorldRaidBossKillOffset = default(VectorOffset)) {
    builder.StartTable(9);
    WorldRaidConditionExcel.AddAccountLevel(builder, AccountLevel);
    WorldRaidConditionExcel.AddId(builder, Id);
    WorldRaidConditionExcel.AddWorldRaidBossKill(builder, WorldRaidBossKillOffset);
    WorldRaidConditionExcel.AddAfterWhenDate(builder, AfterWhenDateOffset);
    WorldRaidConditionExcel.AddMultipleConditionCheckType(builder, MultipleConditionCheckType);
    WorldRaidConditionExcel.AddCampaignStageID(builder, CampaignStageIDOffset);
    WorldRaidConditionExcel.AddScenarioModeId(builder, ScenarioModeIdOffset);
    WorldRaidConditionExcel.AddLockUI(builder, LockUIOffset);
    WorldRaidConditionExcel.AddHideWhenLocked(builder, HideWhenLocked);
    return WorldRaidConditionExcel.EndWorldRaidConditionExcel(builder);
  }

  public static void StartWorldRaidConditionExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddLockUI(FlatBufferBuilder builder, VectorOffset LockUIOffset) { builder.AddOffset(1, LockUIOffset.Value, 0); }
  public static VectorOffset CreateLockUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLockUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHideWhenLocked(FlatBufferBuilder builder, bool HideWhenLocked) { builder.AddBool(2, HideWhenLocked, false); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long AccountLevel) { builder.AddLong(3, AccountLevel, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, VectorOffset ScenarioModeIdOffset) { builder.AddOffset(4, ScenarioModeIdOffset.Value, 0); }
  public static VectorOffset CreateScenarioModeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScenarioModeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCampaignStageID(FlatBufferBuilder builder, VectorOffset CampaignStageIDOffset) { builder.AddOffset(5, CampaignStageIDOffset.Value, 0); }
  public static VectorOffset CreateCampaignStageIDVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCampaignStageIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMultipleConditionCheckType(FlatBufferBuilder builder, FlatDataJp.MultipleConditionCheckType MultipleConditionCheckType) { builder.AddInt(6, (int)MultipleConditionCheckType, 0); }
  public static void AddAfterWhenDate(FlatBufferBuilder builder, StringOffset AfterWhenDateOffset) { builder.AddOffset(7, AfterWhenDateOffset.Value, 0); }
  public static void AddWorldRaidBossKill(FlatBufferBuilder builder, VectorOffset WorldRaidBossKillOffset) { builder.AddOffset(8, WorldRaidBossKillOffset.Value, 0); }
  public static VectorOffset CreateWorldRaidBossKillVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartWorldRaidBossKillVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.WorldRaidConditionExcel> EndWorldRaidConditionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.WorldRaidConditionExcel>(o);
  }
}


}
