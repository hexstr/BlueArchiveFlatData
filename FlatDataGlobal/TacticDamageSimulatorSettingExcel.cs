// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticDamageSimulatorSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TacticDamageSimulatorSettingExcel GetRootAsTacticDamageSimulatorSettingExcel(ByteBuffer _bb) { return GetRootAsTacticDamageSimulatorSettingExcel(_bb, new TacticDamageSimulatorSettingExcel()); }
  public static TacticDamageSimulatorSettingExcel GetRootAsTacticDamageSimulatorSettingExcel(ByteBuffer _bb, TacticDamageSimulatorSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticDamageSimulatorSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Order { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Repeat { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TestPreset { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TestBattleTime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StrikerSquard { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SpecialSquard { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ReplaceCharacterCostRegen { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int ReplaceCostRegenValue { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool UseAutoSkill { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GroundId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedCharacter(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int FixedCharacterLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetFixedCharacterBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetFixedCharacterBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetFixedCharacterArray() { return __p.__vector_as_array<long>(24); }

  public static Offset<FlatDataGlobal.TacticDamageSimulatorSettingExcel> CreateTacticDamageSimulatorSettingExcel(FlatBufferBuilder builder,
      int Order = 0,
      int Repeat = 0,
      long TestPreset = 0,
      long TestBattleTime = 0,
      long StrikerSquard = 0,
      long SpecialSquard = 0,
      bool ReplaceCharacterCostRegen = false,
      int ReplaceCostRegenValue = 0,
      bool UseAutoSkill = false,
      long GroundId = 0,
      VectorOffset FixedCharacterOffset = default(VectorOffset)) {
    builder.StartTable(11);
    TacticDamageSimulatorSettingExcel.AddGroundId(builder, GroundId);
    TacticDamageSimulatorSettingExcel.AddSpecialSquard(builder, SpecialSquard);
    TacticDamageSimulatorSettingExcel.AddStrikerSquard(builder, StrikerSquard);
    TacticDamageSimulatorSettingExcel.AddTestBattleTime(builder, TestBattleTime);
    TacticDamageSimulatorSettingExcel.AddTestPreset(builder, TestPreset);
    TacticDamageSimulatorSettingExcel.AddFixedCharacter(builder, FixedCharacterOffset);
    TacticDamageSimulatorSettingExcel.AddReplaceCostRegenValue(builder, ReplaceCostRegenValue);
    TacticDamageSimulatorSettingExcel.AddRepeat(builder, Repeat);
    TacticDamageSimulatorSettingExcel.AddOrder(builder, Order);
    TacticDamageSimulatorSettingExcel.AddUseAutoSkill(builder, UseAutoSkill);
    TacticDamageSimulatorSettingExcel.AddReplaceCharacterCostRegen(builder, ReplaceCharacterCostRegen);
    return TacticDamageSimulatorSettingExcel.EndTacticDamageSimulatorSettingExcel(builder);
  }

  public static void StartTacticDamageSimulatorSettingExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddOrder(FlatBufferBuilder builder, int Order) { builder.AddInt(0, Order, 0); }
  public static void AddRepeat(FlatBufferBuilder builder, int Repeat) { builder.AddInt(1, Repeat, 0); }
  public static void AddTestPreset(FlatBufferBuilder builder, long TestPreset) { builder.AddLong(2, TestPreset, 0); }
  public static void AddTestBattleTime(FlatBufferBuilder builder, long TestBattleTime) { builder.AddLong(3, TestBattleTime, 0); }
  public static void AddStrikerSquard(FlatBufferBuilder builder, long StrikerSquard) { builder.AddLong(4, StrikerSquard, 0); }
  public static void AddSpecialSquard(FlatBufferBuilder builder, long SpecialSquard) { builder.AddLong(5, SpecialSquard, 0); }
  public static void AddReplaceCharacterCostRegen(FlatBufferBuilder builder, bool ReplaceCharacterCostRegen) { builder.AddBool(6, ReplaceCharacterCostRegen, false); }
  public static void AddReplaceCostRegenValue(FlatBufferBuilder builder, int ReplaceCostRegenValue) { builder.AddInt(7, ReplaceCostRegenValue, 0); }
  public static void AddUseAutoSkill(FlatBufferBuilder builder, bool UseAutoSkill) { builder.AddBool(8, UseAutoSkill, false); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(9, GroundId, 0); }
  public static void AddFixedCharacter(FlatBufferBuilder builder, VectorOffset FixedCharacterOffset) { builder.AddOffset(10, FixedCharacterOffset.Value, 0); }
  public static VectorOffset CreateFixedCharacterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateFixedCharacterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFixedCharacterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFixedCharacterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFixedCharacterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.TacticDamageSimulatorSettingExcel> EndTacticDamageSimulatorSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.TacticDamageSimulatorSettingExcel>(o);
  }
}


}
