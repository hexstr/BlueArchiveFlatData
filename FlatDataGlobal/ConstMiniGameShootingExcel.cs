// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstMiniGameShootingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConstMiniGameShootingExcel GetRootAsConstMiniGameShootingExcel(ByteBuffer _bb) { return GetRootAsConstMiniGameShootingExcel(_bb, new ConstMiniGameShootingExcel()); }
  public static ConstMiniGameShootingExcel GetRootAsConstMiniGameShootingExcel(ByteBuffer _bb, ConstMiniGameShootingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstMiniGameShootingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long NormalStageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int NormalSectionCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long HardStageId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int HardSectionCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long LeftPlayerCharacterId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RightPlayerCharacterId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HiddenPlayerCharacterId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float CameraSmoothTime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string SpawnEffectPath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpawnEffectPathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSpawnEffectPathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSpawnEffectPathArray() { return __p.__vector_as_array<byte>(20); }
  public float WaitTimeAfterSpawn { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataGlobal.ConstMiniGameShootingExcel> CreateConstMiniGameShootingExcel(FlatBufferBuilder builder,
      long NormalStageId = 0,
      int NormalSectionCount = 0,
      long HardStageId = 0,
      int HardSectionCount = 0,
      long LeftPlayerCharacterId = 0,
      long RightPlayerCharacterId = 0,
      long HiddenPlayerCharacterId = 0,
      float CameraSmoothTime = 0.0f,
      StringOffset SpawnEffectPathOffset = default(StringOffset),
      float WaitTimeAfterSpawn = 0.0f) {
    builder.StartTable(10);
    ConstMiniGameShootingExcel.AddHiddenPlayerCharacterId(builder, HiddenPlayerCharacterId);
    ConstMiniGameShootingExcel.AddRightPlayerCharacterId(builder, RightPlayerCharacterId);
    ConstMiniGameShootingExcel.AddLeftPlayerCharacterId(builder, LeftPlayerCharacterId);
    ConstMiniGameShootingExcel.AddHardStageId(builder, HardStageId);
    ConstMiniGameShootingExcel.AddNormalStageId(builder, NormalStageId);
    ConstMiniGameShootingExcel.AddWaitTimeAfterSpawn(builder, WaitTimeAfterSpawn);
    ConstMiniGameShootingExcel.AddSpawnEffectPath(builder, SpawnEffectPathOffset);
    ConstMiniGameShootingExcel.AddCameraSmoothTime(builder, CameraSmoothTime);
    ConstMiniGameShootingExcel.AddHardSectionCount(builder, HardSectionCount);
    ConstMiniGameShootingExcel.AddNormalSectionCount(builder, NormalSectionCount);
    return ConstMiniGameShootingExcel.EndConstMiniGameShootingExcel(builder);
  }

  public static void StartConstMiniGameShootingExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddNormalStageId(FlatBufferBuilder builder, long NormalStageId) { builder.AddLong(0, NormalStageId, 0); }
  public static void AddNormalSectionCount(FlatBufferBuilder builder, int NormalSectionCount) { builder.AddInt(1, NormalSectionCount, 0); }
  public static void AddHardStageId(FlatBufferBuilder builder, long HardStageId) { builder.AddLong(2, HardStageId, 0); }
  public static void AddHardSectionCount(FlatBufferBuilder builder, int HardSectionCount) { builder.AddInt(3, HardSectionCount, 0); }
  public static void AddLeftPlayerCharacterId(FlatBufferBuilder builder, long LeftPlayerCharacterId) { builder.AddLong(4, LeftPlayerCharacterId, 0); }
  public static void AddRightPlayerCharacterId(FlatBufferBuilder builder, long RightPlayerCharacterId) { builder.AddLong(5, RightPlayerCharacterId, 0); }
  public static void AddHiddenPlayerCharacterId(FlatBufferBuilder builder, long HiddenPlayerCharacterId) { builder.AddLong(6, HiddenPlayerCharacterId, 0); }
  public static void AddCameraSmoothTime(FlatBufferBuilder builder, float CameraSmoothTime) { builder.AddFloat(7, CameraSmoothTime, 0.0f); }
  public static void AddSpawnEffectPath(FlatBufferBuilder builder, StringOffset SpawnEffectPathOffset) { builder.AddOffset(8, SpawnEffectPathOffset.Value, 0); }
  public static void AddWaitTimeAfterSpawn(FlatBufferBuilder builder, float WaitTimeAfterSpawn) { builder.AddFloat(9, WaitTimeAfterSpawn, 0.0f); }
  public static Offset<FlatDataGlobal.ConstMiniGameShootingExcel> EndConstMiniGameShootingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConstMiniGameShootingExcel>(o);
  }
}


}
