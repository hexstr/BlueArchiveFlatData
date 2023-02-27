// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WorldRaidBossGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static WorldRaidBossGroupExcel GetRootAsWorldRaidBossGroupExcel(ByteBuffer _bb) { return GetRootAsWorldRaidBossGroupExcel(_bb, new WorldRaidBossGroupExcel()); }
  public static WorldRaidBossGroupExcel GetRootAsWorldRaidBossGroupExcel(ByteBuffer _bb, WorldRaidBossGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidBossGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WorldRaidBossGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string WorldBossName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWorldBossNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetWorldBossNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetWorldBossNameArray() { return __p.__vector_as_array<byte>(8); }
  public string WorldBossPopupPortrait { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWorldBossPopupPortraitBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetWorldBossPopupPortraitBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetWorldBossPopupPortraitArray() { return __p.__vector_as_array<byte>(10); }
  public string WorldBossPopupBG { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWorldBossPopupBGBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetWorldBossPopupBGBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetWorldBossPopupBGArray() { return __p.__vector_as_array<byte>(12); }
  public string WorldBossParcelPortrait { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWorldBossParcelPortraitBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetWorldBossParcelPortraitBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetWorldBossParcelPortraitArray() { return __p.__vector_as_array<byte>(14); }
  public string WorldBossListParcel { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWorldBossListParcelBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetWorldBossListParcelBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetWorldBossListParcelArray() { return __p.__vector_as_array<byte>(16); }
  public long WorldBossHP { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UIHideBeforeSpawn { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HideAnotherBossKilled { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long WorldBossClearRewardGroupId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AnotherBossKilled(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int AnotherBossKilledLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetAnotherBossKilledBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetAnotherBossKilledBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetAnotherBossKilledArray() { return __p.__vector_as_array<long>(26); }
  public long EchelonConstraintGroupId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ExclusiveOperatorBossSpawn { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExclusiveOperatorBossSpawnBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetExclusiveOperatorBossSpawnBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetExclusiveOperatorBossSpawnArray() { return __p.__vector_as_array<byte>(30); }
  public string ExclusiveOperatorBossKill { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExclusiveOperatorBossKillBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetExclusiveOperatorBossKillBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetExclusiveOperatorBossKillArray() { return __p.__vector_as_array<byte>(32); }
  public string ExclusiveOperatorScenarioBattle { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExclusiveOperatorScenarioBattleBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetExclusiveOperatorScenarioBattleBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetExclusiveOperatorScenarioBattleArray() { return __p.__vector_as_array<byte>(34); }
  public string ExclusiveOperatorBossDamaged { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExclusiveOperatorBossDamagedBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetExclusiveOperatorBossDamagedBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetExclusiveOperatorBossDamagedArray() { return __p.__vector_as_array<byte>(36); }

  public static Offset<FlatDataJp.WorldRaidBossGroupExcel> CreateWorldRaidBossGroupExcel(FlatBufferBuilder builder,
      long Id = 0,
      long WorldRaidBossGroupId = 0,
      StringOffset WorldBossNameOffset = default(StringOffset),
      StringOffset WorldBossPopupPortraitOffset = default(StringOffset),
      StringOffset WorldBossPopupBGOffset = default(StringOffset),
      StringOffset WorldBossParcelPortraitOffset = default(StringOffset),
      StringOffset WorldBossListParcelOffset = default(StringOffset),
      long WorldBossHP = 0,
      bool UIHideBeforeSpawn = false,
      bool HideAnotherBossKilled = false,
      long WorldBossClearRewardGroupId = 0,
      VectorOffset AnotherBossKilledOffset = default(VectorOffset),
      long EchelonConstraintGroupId = 0,
      StringOffset ExclusiveOperatorBossSpawnOffset = default(StringOffset),
      StringOffset ExclusiveOperatorBossKillOffset = default(StringOffset),
      StringOffset ExclusiveOperatorScenarioBattleOffset = default(StringOffset),
      StringOffset ExclusiveOperatorBossDamagedOffset = default(StringOffset)) {
    builder.StartTable(17);
    WorldRaidBossGroupExcel.AddEchelonConstraintGroupId(builder, EchelonConstraintGroupId);
    WorldRaidBossGroupExcel.AddWorldBossClearRewardGroupId(builder, WorldBossClearRewardGroupId);
    WorldRaidBossGroupExcel.AddWorldBossHP(builder, WorldBossHP);
    WorldRaidBossGroupExcel.AddWorldRaidBossGroupId(builder, WorldRaidBossGroupId);
    WorldRaidBossGroupExcel.AddId(builder, Id);
    WorldRaidBossGroupExcel.AddExclusiveOperatorBossDamaged(builder, ExclusiveOperatorBossDamagedOffset);
    WorldRaidBossGroupExcel.AddExclusiveOperatorScenarioBattle(builder, ExclusiveOperatorScenarioBattleOffset);
    WorldRaidBossGroupExcel.AddExclusiveOperatorBossKill(builder, ExclusiveOperatorBossKillOffset);
    WorldRaidBossGroupExcel.AddExclusiveOperatorBossSpawn(builder, ExclusiveOperatorBossSpawnOffset);
    WorldRaidBossGroupExcel.AddAnotherBossKilled(builder, AnotherBossKilledOffset);
    WorldRaidBossGroupExcel.AddWorldBossListParcel(builder, WorldBossListParcelOffset);
    WorldRaidBossGroupExcel.AddWorldBossParcelPortrait(builder, WorldBossParcelPortraitOffset);
    WorldRaidBossGroupExcel.AddWorldBossPopupBG(builder, WorldBossPopupBGOffset);
    WorldRaidBossGroupExcel.AddWorldBossPopupPortrait(builder, WorldBossPopupPortraitOffset);
    WorldRaidBossGroupExcel.AddWorldBossName(builder, WorldBossNameOffset);
    WorldRaidBossGroupExcel.AddHideAnotherBossKilled(builder, HideAnotherBossKilled);
    WorldRaidBossGroupExcel.AddUIHideBeforeSpawn(builder, UIHideBeforeSpawn);
    return WorldRaidBossGroupExcel.EndWorldRaidBossGroupExcel(builder);
  }

  public static void StartWorldRaidBossGroupExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddWorldRaidBossGroupId(FlatBufferBuilder builder, long WorldRaidBossGroupId) { builder.AddLong(1, WorldRaidBossGroupId, 0); }
  public static void AddWorldBossName(FlatBufferBuilder builder, StringOffset WorldBossNameOffset) { builder.AddOffset(2, WorldBossNameOffset.Value, 0); }
  public static void AddWorldBossPopupPortrait(FlatBufferBuilder builder, StringOffset WorldBossPopupPortraitOffset) { builder.AddOffset(3, WorldBossPopupPortraitOffset.Value, 0); }
  public static void AddWorldBossPopupBG(FlatBufferBuilder builder, StringOffset WorldBossPopupBGOffset) { builder.AddOffset(4, WorldBossPopupBGOffset.Value, 0); }
  public static void AddWorldBossParcelPortrait(FlatBufferBuilder builder, StringOffset WorldBossParcelPortraitOffset) { builder.AddOffset(5, WorldBossParcelPortraitOffset.Value, 0); }
  public static void AddWorldBossListParcel(FlatBufferBuilder builder, StringOffset WorldBossListParcelOffset) { builder.AddOffset(6, WorldBossListParcelOffset.Value, 0); }
  public static void AddWorldBossHP(FlatBufferBuilder builder, long WorldBossHP) { builder.AddLong(7, WorldBossHP, 0); }
  public static void AddUIHideBeforeSpawn(FlatBufferBuilder builder, bool UIHideBeforeSpawn) { builder.AddBool(8, UIHideBeforeSpawn, false); }
  public static void AddHideAnotherBossKilled(FlatBufferBuilder builder, bool HideAnotherBossKilled) { builder.AddBool(9, HideAnotherBossKilled, false); }
  public static void AddWorldBossClearRewardGroupId(FlatBufferBuilder builder, long WorldBossClearRewardGroupId) { builder.AddLong(10, WorldBossClearRewardGroupId, 0); }
  public static void AddAnotherBossKilled(FlatBufferBuilder builder, VectorOffset AnotherBossKilledOffset) { builder.AddOffset(11, AnotherBossKilledOffset.Value, 0); }
  public static VectorOffset CreateAnotherBossKilledVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAnotherBossKilledVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAnotherBossKilledVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAnotherBossKilledVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAnotherBossKilledVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddEchelonConstraintGroupId(FlatBufferBuilder builder, long EchelonConstraintGroupId) { builder.AddLong(12, EchelonConstraintGroupId, 0); }
  public static void AddExclusiveOperatorBossSpawn(FlatBufferBuilder builder, StringOffset ExclusiveOperatorBossSpawnOffset) { builder.AddOffset(13, ExclusiveOperatorBossSpawnOffset.Value, 0); }
  public static void AddExclusiveOperatorBossKill(FlatBufferBuilder builder, StringOffset ExclusiveOperatorBossKillOffset) { builder.AddOffset(14, ExclusiveOperatorBossKillOffset.Value, 0); }
  public static void AddExclusiveOperatorScenarioBattle(FlatBufferBuilder builder, StringOffset ExclusiveOperatorScenarioBattleOffset) { builder.AddOffset(15, ExclusiveOperatorScenarioBattleOffset.Value, 0); }
  public static void AddExclusiveOperatorBossDamaged(FlatBufferBuilder builder, StringOffset ExclusiveOperatorBossDamagedOffset) { builder.AddOffset(16, ExclusiveOperatorBossDamagedOffset.Value, 0); }
  public static Offset<FlatDataJp.WorldRaidBossGroupExcel> EndWorldRaidBossGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.WorldRaidBossGroupExcel>(o);
  }
}


}
