// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideMissionOpenStageConditionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static GuideMissionOpenStageConditionExcel GetRootAsGuideMissionOpenStageConditionExcel(ByteBuffer _bb) { return GetRootAsGuideMissionOpenStageConditionExcel(_bb, new GuideMissionOpenStageConditionExcel()); }
  public static GuideMissionOpenStageConditionExcel GetRootAsGuideMissionOpenStageConditionExcel(ByteBuffer _bb, GuideMissionOpenStageConditionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideMissionOpenStageConditionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OrderNumber { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string TabLocalizeCode { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTabLocalizeCodeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTabLocalizeCodeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTabLocalizeCodeArray() { return __p.__vector_as_array<byte>(8); }
  public long ClearScenarioModeId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LockScenarioTextLocailzeCode { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLockScenarioTextLocailzeCodeBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLockScenarioTextLocailzeCodeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLockScenarioTextLocailzeCodeArray() { return __p.__vector_as_array<byte>(12); }
  public string ShortcutScenarioUI { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShortcutScenarioUIBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetShortcutScenarioUIBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetShortcutScenarioUIArray() { return __p.__vector_as_array<byte>(14); }
  public long ClearStageId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LockStageTextLocailzeCode { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLockStageTextLocailzeCodeBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetLockStageTextLocailzeCodeBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetLockStageTextLocailzeCodeArray() { return __p.__vector_as_array<byte>(18); }
  public string ShortcutStageUI { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShortcutStageUIBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetShortcutStageUIBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetShortcutStageUIArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<FlatDataGlobal.GuideMissionOpenStageConditionExcel> CreateGuideMissionOpenStageConditionExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long OrderNumber = 0,
      StringOffset TabLocalizeCodeOffset = default(StringOffset),
      long ClearScenarioModeId = 0,
      StringOffset LockScenarioTextLocailzeCodeOffset = default(StringOffset),
      StringOffset ShortcutScenarioUIOffset = default(StringOffset),
      long ClearStageId = 0,
      StringOffset LockStageTextLocailzeCodeOffset = default(StringOffset),
      StringOffset ShortcutStageUIOffset = default(StringOffset)) {
    builder.StartTable(9);
    GuideMissionOpenStageConditionExcel.AddClearStageId(builder, ClearStageId);
    GuideMissionOpenStageConditionExcel.AddClearScenarioModeId(builder, ClearScenarioModeId);
    GuideMissionOpenStageConditionExcel.AddOrderNumber(builder, OrderNumber);
    GuideMissionOpenStageConditionExcel.AddSeasonId(builder, SeasonId);
    GuideMissionOpenStageConditionExcel.AddShortcutStageUI(builder, ShortcutStageUIOffset);
    GuideMissionOpenStageConditionExcel.AddLockStageTextLocailzeCode(builder, LockStageTextLocailzeCodeOffset);
    GuideMissionOpenStageConditionExcel.AddShortcutScenarioUI(builder, ShortcutScenarioUIOffset);
    GuideMissionOpenStageConditionExcel.AddLockScenarioTextLocailzeCode(builder, LockScenarioTextLocailzeCodeOffset);
    GuideMissionOpenStageConditionExcel.AddTabLocalizeCode(builder, TabLocalizeCodeOffset);
    return GuideMissionOpenStageConditionExcel.EndGuideMissionOpenStageConditionExcel(builder);
  }

  public static void StartGuideMissionOpenStageConditionExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddSeasonId(FlatBufferBuilder builder, long SeasonId) { builder.AddLong(0, SeasonId, 0); }
  public static void AddOrderNumber(FlatBufferBuilder builder, long OrderNumber) { builder.AddLong(1, OrderNumber, 0); }
  public static void AddTabLocalizeCode(FlatBufferBuilder builder, StringOffset TabLocalizeCodeOffset) { builder.AddOffset(2, TabLocalizeCodeOffset.Value, 0); }
  public static void AddClearScenarioModeId(FlatBufferBuilder builder, long ClearScenarioModeId) { builder.AddLong(3, ClearScenarioModeId, 0); }
  public static void AddLockScenarioTextLocailzeCode(FlatBufferBuilder builder, StringOffset LockScenarioTextLocailzeCodeOffset) { builder.AddOffset(4, LockScenarioTextLocailzeCodeOffset.Value, 0); }
  public static void AddShortcutScenarioUI(FlatBufferBuilder builder, StringOffset ShortcutScenarioUIOffset) { builder.AddOffset(5, ShortcutScenarioUIOffset.Value, 0); }
  public static void AddClearStageId(FlatBufferBuilder builder, long ClearStageId) { builder.AddLong(6, ClearStageId, 0); }
  public static void AddLockStageTextLocailzeCode(FlatBufferBuilder builder, StringOffset LockStageTextLocailzeCodeOffset) { builder.AddOffset(7, LockStageTextLocailzeCodeOffset.Value, 0); }
  public static void AddShortcutStageUI(FlatBufferBuilder builder, StringOffset ShortcutStageUIOffset) { builder.AddOffset(8, ShortcutStageUIOffset.Value, 0); }
  public static Offset<FlatDataGlobal.GuideMissionOpenStageConditionExcel> EndGuideMissionOpenStageConditionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.GuideMissionOpenStageConditionExcel>(o);
  }
}


}
