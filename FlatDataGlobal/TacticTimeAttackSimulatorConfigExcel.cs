// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticTimeAttackSimulatorConfigExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TacticTimeAttackSimulatorConfigExcel GetRootAsTacticTimeAttackSimulatorConfigExcel(ByteBuffer _bb) { return GetRootAsTacticTimeAttackSimulatorConfigExcel(_bb, new TacticTimeAttackSimulatorConfigExcel()); }
  public static TacticTimeAttackSimulatorConfigExcel GetRootAsTacticTimeAttackSimulatorConfigExcel(ByteBuffer _bb, TacticTimeAttackSimulatorConfigExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticTimeAttackSimulatorConfigExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Order { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Repeat { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PresetGroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackStrikerNum { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackSpecialNum { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GeasId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.TacticTimeAttackSimulatorConfigExcel> CreateTacticTimeAttackSimulatorConfigExcel(FlatBufferBuilder builder,
      long Order = 0,
      long Repeat = 0,
      long PresetGroupId = 0,
      long AttackStrikerNum = 0,
      long AttackSpecialNum = 0,
      long GeasId = 0) {
    builder.StartTable(6);
    TacticTimeAttackSimulatorConfigExcel.AddGeasId(builder, GeasId);
    TacticTimeAttackSimulatorConfigExcel.AddAttackSpecialNum(builder, AttackSpecialNum);
    TacticTimeAttackSimulatorConfigExcel.AddAttackStrikerNum(builder, AttackStrikerNum);
    TacticTimeAttackSimulatorConfigExcel.AddPresetGroupId(builder, PresetGroupId);
    TacticTimeAttackSimulatorConfigExcel.AddRepeat(builder, Repeat);
    TacticTimeAttackSimulatorConfigExcel.AddOrder(builder, Order);
    return TacticTimeAttackSimulatorConfigExcel.EndTacticTimeAttackSimulatorConfigExcel(builder);
  }

  public static void StartTacticTimeAttackSimulatorConfigExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddOrder(FlatBufferBuilder builder, long Order) { builder.AddLong(0, Order, 0); }
  public static void AddRepeat(FlatBufferBuilder builder, long Repeat) { builder.AddLong(1, Repeat, 0); }
  public static void AddPresetGroupId(FlatBufferBuilder builder, long PresetGroupId) { builder.AddLong(2, PresetGroupId, 0); }
  public static void AddAttackStrikerNum(FlatBufferBuilder builder, long AttackStrikerNum) { builder.AddLong(3, AttackStrikerNum, 0); }
  public static void AddAttackSpecialNum(FlatBufferBuilder builder, long AttackSpecialNum) { builder.AddLong(4, AttackSpecialNum, 0); }
  public static void AddGeasId(FlatBufferBuilder builder, long GeasId) { builder.AddLong(5, GeasId, 0); }
  public static Offset<FlatDataGlobal.TacticTimeAttackSimulatorConfigExcel> EndTacticTimeAttackSimulatorConfigExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.TacticTimeAttackSimulatorConfigExcel>(o);
  }
}


}
