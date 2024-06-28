// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstStrategyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConstStrategyExcel GetRootAsConstStrategyExcel(ByteBuffer _bb) { return GetRootAsConstStrategyExcel(_bb, new ConstStrategyExcel()); }
  public static ConstStrategyExcel GetRootAsConstStrategyExcel(ByteBuffer _bb, ConstStrategyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstStrategyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float HexaMapBoundaryOffset { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float HexaMapStartCameraOffset { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMax { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMin { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomDefault { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public FlatDataJp.CurrencyTypes HealCostType { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CurrencyTypes.Invalid; } }
  public long HealCostAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int HealCostAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetHealCostAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetHealCostAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetHealCostAmountArray() { return __p.__vector_as_array<long>(16); }
  public int CanHealHpRate { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long PlayTimeLimitInSeconds { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int AdventureEchelonCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RaidEchelonCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DefaultEchelonCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EventContentEchelonCount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TimeAttackDungeonEchelonCount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WorldRaidEchelonCount { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TacticSkipClearTimeSeconds { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TacticSkipFramePerSecond { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ConquestEchelonCount { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StoryEchelonCount { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MultiSweepPresetCount { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MultiSweepPresetNameMaxLength { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MultiSweepPresetSelectStageMaxCount { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MultiSweepPresetMaxSweepCount { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MultiSweepPresetSelectParcelMaxCount { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.ConstStrategyExcel> CreateConstStrategyExcel(FlatBufferBuilder builder,
      float HexaMapBoundaryOffset = 0.0f,
      float HexaMapStartCameraOffset = 0.0f,
      float CameraZoomMax = 0.0f,
      float CameraZoomMin = 0.0f,
      float CameraZoomDefault = 0.0f,
      FlatDataJp.CurrencyTypes HealCostType = FlatDataJp.CurrencyTypes.Invalid,
      VectorOffset HealCostAmountOffset = default(VectorOffset),
      int CanHealHpRate = 0,
      long PlayTimeLimitInSeconds = 0,
      int AdventureEchelonCount = 0,
      int RaidEchelonCount = 0,
      int DefaultEchelonCount = 0,
      int EventContentEchelonCount = 0,
      int TimeAttackDungeonEchelonCount = 0,
      int WorldRaidEchelonCount = 0,
      int TacticSkipClearTimeSeconds = 0,
      int TacticSkipFramePerSecond = 0,
      int ConquestEchelonCount = 0,
      int StoryEchelonCount = 0,
      int MultiSweepPresetCount = 0,
      int MultiSweepPresetNameMaxLength = 0,
      int MultiSweepPresetSelectStageMaxCount = 0,
      int MultiSweepPresetMaxSweepCount = 0,
      int MultiSweepPresetSelectParcelMaxCount = 0) {
    builder.StartTable(24);
    ConstStrategyExcel.AddPlayTimeLimitInSeconds(builder, PlayTimeLimitInSeconds);
    ConstStrategyExcel.AddMultiSweepPresetSelectParcelMaxCount(builder, MultiSweepPresetSelectParcelMaxCount);
    ConstStrategyExcel.AddMultiSweepPresetMaxSweepCount(builder, MultiSweepPresetMaxSweepCount);
    ConstStrategyExcel.AddMultiSweepPresetSelectStageMaxCount(builder, MultiSweepPresetSelectStageMaxCount);
    ConstStrategyExcel.AddMultiSweepPresetNameMaxLength(builder, MultiSweepPresetNameMaxLength);
    ConstStrategyExcel.AddMultiSweepPresetCount(builder, MultiSweepPresetCount);
    ConstStrategyExcel.AddStoryEchelonCount(builder, StoryEchelonCount);
    ConstStrategyExcel.AddConquestEchelonCount(builder, ConquestEchelonCount);
    ConstStrategyExcel.AddTacticSkipFramePerSecond(builder, TacticSkipFramePerSecond);
    ConstStrategyExcel.AddTacticSkipClearTimeSeconds(builder, TacticSkipClearTimeSeconds);
    ConstStrategyExcel.AddWorldRaidEchelonCount(builder, WorldRaidEchelonCount);
    ConstStrategyExcel.AddTimeAttackDungeonEchelonCount(builder, TimeAttackDungeonEchelonCount);
    ConstStrategyExcel.AddEventContentEchelonCount(builder, EventContentEchelonCount);
    ConstStrategyExcel.AddDefaultEchelonCount(builder, DefaultEchelonCount);
    ConstStrategyExcel.AddRaidEchelonCount(builder, RaidEchelonCount);
    ConstStrategyExcel.AddAdventureEchelonCount(builder, AdventureEchelonCount);
    ConstStrategyExcel.AddCanHealHpRate(builder, CanHealHpRate);
    ConstStrategyExcel.AddHealCostAmount(builder, HealCostAmountOffset);
    ConstStrategyExcel.AddHealCostType(builder, HealCostType);
    ConstStrategyExcel.AddCameraZoomDefault(builder, CameraZoomDefault);
    ConstStrategyExcel.AddCameraZoomMin(builder, CameraZoomMin);
    ConstStrategyExcel.AddCameraZoomMax(builder, CameraZoomMax);
    ConstStrategyExcel.AddHexaMapStartCameraOffset(builder, HexaMapStartCameraOffset);
    ConstStrategyExcel.AddHexaMapBoundaryOffset(builder, HexaMapBoundaryOffset);
    return ConstStrategyExcel.EndConstStrategyExcel(builder);
  }

  public static void StartConstStrategyExcel(FlatBufferBuilder builder) { builder.StartTable(24); }
  public static void AddHexaMapBoundaryOffset(FlatBufferBuilder builder, float HexaMapBoundaryOffset) { builder.AddFloat(0, HexaMapBoundaryOffset, 0.0f); }
  public static void AddHexaMapStartCameraOffset(FlatBufferBuilder builder, float HexaMapStartCameraOffset) { builder.AddFloat(1, HexaMapStartCameraOffset, 0.0f); }
  public static void AddCameraZoomMax(FlatBufferBuilder builder, float CameraZoomMax) { builder.AddFloat(2, CameraZoomMax, 0.0f); }
  public static void AddCameraZoomMin(FlatBufferBuilder builder, float CameraZoomMin) { builder.AddFloat(3, CameraZoomMin, 0.0f); }
  public static void AddCameraZoomDefault(FlatBufferBuilder builder, float CameraZoomDefault) { builder.AddFloat(4, CameraZoomDefault, 0.0f); }
  public static void AddHealCostType(FlatBufferBuilder builder, FlatDataJp.CurrencyTypes HealCostType) { builder.AddInt(5, (int)HealCostType, 0); }
  public static void AddHealCostAmount(FlatBufferBuilder builder, VectorOffset HealCostAmountOffset) { builder.AddOffset(6, HealCostAmountOffset.Value, 0); }
  public static VectorOffset CreateHealCostAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateHealCostAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHealCostAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHealCostAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartHealCostAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCanHealHpRate(FlatBufferBuilder builder, int CanHealHpRate) { builder.AddInt(7, CanHealHpRate, 0); }
  public static void AddPlayTimeLimitInSeconds(FlatBufferBuilder builder, long PlayTimeLimitInSeconds) { builder.AddLong(8, PlayTimeLimitInSeconds, 0); }
  public static void AddAdventureEchelonCount(FlatBufferBuilder builder, int AdventureEchelonCount) { builder.AddInt(9, AdventureEchelonCount, 0); }
  public static void AddRaidEchelonCount(FlatBufferBuilder builder, int RaidEchelonCount) { builder.AddInt(10, RaidEchelonCount, 0); }
  public static void AddDefaultEchelonCount(FlatBufferBuilder builder, int DefaultEchelonCount) { builder.AddInt(11, DefaultEchelonCount, 0); }
  public static void AddEventContentEchelonCount(FlatBufferBuilder builder, int EventContentEchelonCount) { builder.AddInt(12, EventContentEchelonCount, 0); }
  public static void AddTimeAttackDungeonEchelonCount(FlatBufferBuilder builder, int TimeAttackDungeonEchelonCount) { builder.AddInt(13, TimeAttackDungeonEchelonCount, 0); }
  public static void AddWorldRaidEchelonCount(FlatBufferBuilder builder, int WorldRaidEchelonCount) { builder.AddInt(14, WorldRaidEchelonCount, 0); }
  public static void AddTacticSkipClearTimeSeconds(FlatBufferBuilder builder, int TacticSkipClearTimeSeconds) { builder.AddInt(15, TacticSkipClearTimeSeconds, 0); }
  public static void AddTacticSkipFramePerSecond(FlatBufferBuilder builder, int TacticSkipFramePerSecond) { builder.AddInt(16, TacticSkipFramePerSecond, 0); }
  public static void AddConquestEchelonCount(FlatBufferBuilder builder, int ConquestEchelonCount) { builder.AddInt(17, ConquestEchelonCount, 0); }
  public static void AddStoryEchelonCount(FlatBufferBuilder builder, int StoryEchelonCount) { builder.AddInt(18, StoryEchelonCount, 0); }
  public static void AddMultiSweepPresetCount(FlatBufferBuilder builder, int MultiSweepPresetCount) { builder.AddInt(19, MultiSweepPresetCount, 0); }
  public static void AddMultiSweepPresetNameMaxLength(FlatBufferBuilder builder, int MultiSweepPresetNameMaxLength) { builder.AddInt(20, MultiSweepPresetNameMaxLength, 0); }
  public static void AddMultiSweepPresetSelectStageMaxCount(FlatBufferBuilder builder, int MultiSweepPresetSelectStageMaxCount) { builder.AddInt(21, MultiSweepPresetSelectStageMaxCount, 0); }
  public static void AddMultiSweepPresetMaxSweepCount(FlatBufferBuilder builder, int MultiSweepPresetMaxSweepCount) { builder.AddInt(22, MultiSweepPresetMaxSweepCount, 0); }
  public static void AddMultiSweepPresetSelectParcelMaxCount(FlatBufferBuilder builder, int MultiSweepPresetSelectParcelMaxCount) { builder.AddInt(23, MultiSweepPresetSelectParcelMaxCount, 0); }
  public static Offset<FlatDataJp.ConstStrategyExcel> EndConstStrategyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConstStrategyExcel>(o);
  }
}


}
