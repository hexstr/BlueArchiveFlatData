// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatLimitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb) { return GetRootAsCharacterStatLimitExcel(_bb, new CharacterStatLimitExcel()); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb, CharacterStatLimitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatLimitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TacticEntityType.None; } }
  public FlatDataGlobal.StatType StatType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.StatType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StatType.None; } }
  public long StatMinValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatMaxValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMinValue { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMaxValue { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.CharacterStatLimitExcel> CreateCharacterStatLimitExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.TacticEntityType tacticEntityType = FlatDataGlobal.TacticEntityType.None,
      FlatDataGlobal.StatType statType = FlatDataGlobal.StatType.None,
      long StatMinValue = 0,
      long StatMaxValue = 0,
      long StatRatioMinValue = 0,
      long StatRatioMaxValue = 0) {
    builder.StartTable(7);
    CharacterStatLimitExcel.AddStatRatioMaxValue(builder, StatRatioMaxValue);
    CharacterStatLimitExcel.AddStatRatioMinValue(builder, StatRatioMinValue);
    CharacterStatLimitExcel.AddStatMaxValue(builder, StatMaxValue);
    CharacterStatLimitExcel.AddStatMinValue(builder, StatMinValue);
    CharacterStatLimitExcel.AddId(builder, Id);
    CharacterStatLimitExcel.AddStatType(builder, statType);
    CharacterStatLimitExcel.AddTacticEntityType(builder, tacticEntityType);
    return CharacterStatLimitExcel.EndCharacterStatLimitExcel(builder);
  }

  public static void StartCharacterStatLimitExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, FlatDataGlobal.TacticEntityType tacticEntityType) { builder.AddInt(1, (int)tacticEntityType, 0); }
  public static void AddStatType(FlatBufferBuilder builder, FlatDataGlobal.StatType statType) { builder.AddInt(2, (int)statType, 0); }
  public static void AddStatMinValue(FlatBufferBuilder builder, long StatMinValue) { builder.AddLong(3, StatMinValue, 0); }
  public static void AddStatMaxValue(FlatBufferBuilder builder, long StatMaxValue) { builder.AddLong(4, StatMaxValue, 0); }
  public static void AddStatRatioMinValue(FlatBufferBuilder builder, long StatRatioMinValue) { builder.AddLong(5, StatRatioMinValue, 0); }
  public static void AddStatRatioMaxValue(FlatBufferBuilder builder, long StatRatioMaxValue) { builder.AddLong(6, StatRatioMaxValue, 0); }
  public static Offset<FlatDataGlobal.CharacterStatLimitExcel> EndCharacterStatLimitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterStatLimitExcel>(o);
  }
}


}
