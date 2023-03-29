// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeekDungeonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static WeekDungeonExcel GetRootAsWeekDungeonExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonExcel(_bb, new WeekDungeonExcel()); }
  public static WeekDungeonExcel GetRootAsWeekDungeonExcel(ByteBuffer _bb, WeekDungeonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.WeekDungeonType WeekDungeonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.WeekDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.WeekDungeonType.None; } }
  public int Difficulty { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long BattleDuration { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PrevStageId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType StageEnterCostType(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int StageEnterCostTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetStageEnterCostTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetStageEnterCostTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatDataJp.ParcelType[] GetStageEnterCostTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StageEnterCostId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StageEnterCostIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStageEnterCostIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetStageEnterCostIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetStageEnterCostIdArray() { return __p.__vector_as_array<long>(16); }
  public int StageEnterCostAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StageEnterCostAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStageEnterCostAmountBytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetStageEnterCostAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetStageEnterCostAmountArray() { return __p.__vector_as_array<int>(18); }
  public int GroundId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.StarGoalType StarGoal(int j) { int o = __p.__offset(22); return o != 0 ? (FlatDataJp.StarGoalType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.StarGoalType)0; }
  public int StarGoalLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.StarGoalType> GetStarGoalBytes() { return __p.__vector_as_span<FlatDataJp.StarGoalType>(22, 4); }
#else
  public ArraySegment<byte>? GetStarGoalBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public FlatDataJp.StarGoalType[] GetStarGoalArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.StarGoalType[] a = new FlatDataJp.StarGoalType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.StarGoalType)__p.bb.GetInt(p + i * 4); } return a; }
  public int StarGoalAmount(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StarGoalAmountLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStarGoalAmountBytes() { return __p.__vector_as_span<int>(24, 4); }
#else
  public ArraySegment<byte>? GetStarGoalAmountBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public int[] GetStarGoalAmountArray() { return __p.__vector_as_array<int>(24); }
  public FlatDataJp.StageTopography StageTopography { get { int o = __p.__offset(26); return o != 0 ? (FlatDataJp.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StageTopography.Street; } }
  public long RecommandLevel { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageRewardId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayTimeLimitInSeconds { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleRewardExp { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleRewardPlayerExp { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupBuffID(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GroupBuffIDLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGroupBuffIDBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetGroupBuffIDBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetGroupBuffIDArray() { return __p.__vector_as_array<long>(38); }

  public static Offset<FlatDataJp.WeekDungeonExcel> CreateWeekDungeonExcel(FlatBufferBuilder builder,
      long StageId = 0,
      FlatDataJp.WeekDungeonType WeekDungeonType = FlatDataJp.WeekDungeonType.None,
      int Difficulty = 0,
      long BattleDuration = 0,
      long PrevStageId = 0,
      VectorOffset StageEnterCostTypeOffset = default(VectorOffset),
      VectorOffset StageEnterCostIdOffset = default(VectorOffset),
      VectorOffset StageEnterCostAmountOffset = default(VectorOffset),
      int GroundId = 0,
      VectorOffset StarGoalOffset = default(VectorOffset),
      VectorOffset StarGoalAmountOffset = default(VectorOffset),
      FlatDataJp.StageTopography StageTopography = FlatDataJp.StageTopography.Street,
      long RecommandLevel = 0,
      long StageRewardId = 0,
      long PlayTimeLimitInSeconds = 0,
      long BattleRewardExp = 0,
      long BattleRewardPlayerExp = 0,
      VectorOffset GroupBuffIDOffset = default(VectorOffset)) {
    builder.StartTable(18);
    WeekDungeonExcel.AddBattleRewardPlayerExp(builder, BattleRewardPlayerExp);
    WeekDungeonExcel.AddBattleRewardExp(builder, BattleRewardExp);
    WeekDungeonExcel.AddPlayTimeLimitInSeconds(builder, PlayTimeLimitInSeconds);
    WeekDungeonExcel.AddStageRewardId(builder, StageRewardId);
    WeekDungeonExcel.AddRecommandLevel(builder, RecommandLevel);
    WeekDungeonExcel.AddPrevStageId(builder, PrevStageId);
    WeekDungeonExcel.AddBattleDuration(builder, BattleDuration);
    WeekDungeonExcel.AddStageId(builder, StageId);
    WeekDungeonExcel.AddGroupBuffID(builder, GroupBuffIDOffset);
    WeekDungeonExcel.AddStageTopography(builder, StageTopography);
    WeekDungeonExcel.AddStarGoalAmount(builder, StarGoalAmountOffset);
    WeekDungeonExcel.AddStarGoal(builder, StarGoalOffset);
    WeekDungeonExcel.AddGroundId(builder, GroundId);
    WeekDungeonExcel.AddStageEnterCostAmount(builder, StageEnterCostAmountOffset);
    WeekDungeonExcel.AddStageEnterCostId(builder, StageEnterCostIdOffset);
    WeekDungeonExcel.AddStageEnterCostType(builder, StageEnterCostTypeOffset);
    WeekDungeonExcel.AddDifficulty(builder, Difficulty);
    WeekDungeonExcel.AddWeekDungeonType(builder, WeekDungeonType);
    return WeekDungeonExcel.EndWeekDungeonExcel(builder);
  }

  public static void StartWeekDungeonExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddStageId(FlatBufferBuilder builder, long StageId) { builder.AddLong(0, StageId, 0); }
  public static void AddWeekDungeonType(FlatBufferBuilder builder, FlatDataJp.WeekDungeonType WeekDungeonType) { builder.AddInt(1, (int)WeekDungeonType, 0); }
  public static void AddDifficulty(FlatBufferBuilder builder, int Difficulty) { builder.AddInt(2, Difficulty, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long BattleDuration) { builder.AddLong(3, BattleDuration, 0); }
  public static void AddPrevStageId(FlatBufferBuilder builder, long PrevStageId) { builder.AddLong(4, PrevStageId, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, VectorOffset StageEnterCostTypeOffset) { builder.AddOffset(5, StageEnterCostTypeOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, VectorOffset StageEnterCostIdOffset) { builder.AddOffset(6, StageEnterCostIdOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, VectorOffset StageEnterCostAmountOffset) { builder.AddOffset(7, StageEnterCostAmountOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroundId(FlatBufferBuilder builder, int GroundId) { builder.AddInt(8, GroundId, 0); }
  public static void AddStarGoal(FlatBufferBuilder builder, VectorOffset StarGoalOffset) { builder.AddOffset(9, StarGoalOffset.Value, 0); }
  public static VectorOffset CreateStarGoalVector(FlatBufferBuilder builder, FlatDataJp.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, FlatDataJp.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.StarGoalType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.StarGoalType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarGoalAmount(FlatBufferBuilder builder, VectorOffset StarGoalAmountOffset) { builder.AddOffset(10, StarGoalAmountOffset.Value, 0); }
  public static VectorOffset CreateStarGoalAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatDataJp.StageTopography StageTopography) { builder.AddInt(11, (int)StageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, long RecommandLevel) { builder.AddLong(12, RecommandLevel, 0); }
  public static void AddStageRewardId(FlatBufferBuilder builder, long StageRewardId) { builder.AddLong(13, StageRewardId, 0); }
  public static void AddPlayTimeLimitInSeconds(FlatBufferBuilder builder, long PlayTimeLimitInSeconds) { builder.AddLong(14, PlayTimeLimitInSeconds, 0); }
  public static void AddBattleRewardExp(FlatBufferBuilder builder, long BattleRewardExp) { builder.AddLong(15, BattleRewardExp, 0); }
  public static void AddBattleRewardPlayerExp(FlatBufferBuilder builder, long BattleRewardPlayerExp) { builder.AddLong(16, BattleRewardPlayerExp, 0); }
  public static void AddGroupBuffID(FlatBufferBuilder builder, VectorOffset GroupBuffIDOffset) { builder.AddOffset(17, GroupBuffIDOffset.Value, 0); }
  public static VectorOffset CreateGroupBuffIDVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGroupBuffIDVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGroupBuffIDVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGroupBuffIDVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGroupBuffIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.WeekDungeonExcel> EndWeekDungeonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.WeekDungeonExcel>(o);
  }
}


}
