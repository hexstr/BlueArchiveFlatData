// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatLimitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb) { return GetRootAsCharacterStatLimitExcel(_bb, new CharacterStatLimitExcel()); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb, CharacterStatLimitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatLimitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticEntityType.None; } }
  public FlatDataJp.StatType StatType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.StatType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StatType.None; } }
  public long StatMinValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatMaxValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMinValue { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMaxValue { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.CharacterStatLimitExcel> CreateCharacterStatLimitExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.TacticEntityType TacticEntityType = FlatDataJp.TacticEntityType.None,
      FlatDataJp.StatType StatType = FlatDataJp.StatType.None,
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
    CharacterStatLimitExcel.AddStatType(builder, StatType);
    CharacterStatLimitExcel.AddTacticEntityType(builder, TacticEntityType);
    return CharacterStatLimitExcel.EndCharacterStatLimitExcel(builder);
  }

  public static void StartCharacterStatLimitExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, FlatDataJp.TacticEntityType TacticEntityType) { builder.AddInt(1, (int)TacticEntityType, 0); }
  public static void AddStatType(FlatBufferBuilder builder, FlatDataJp.StatType StatType) { builder.AddInt(2, (int)StatType, 0); }
  public static void AddStatMinValue(FlatBufferBuilder builder, long StatMinValue) { builder.AddLong(3, StatMinValue, 0); }
  public static void AddStatMaxValue(FlatBufferBuilder builder, long StatMaxValue) { builder.AddLong(4, StatMaxValue, 0); }
  public static void AddStatRatioMinValue(FlatBufferBuilder builder, long StatRatioMinValue) { builder.AddLong(5, StatRatioMinValue, 0); }
  public static void AddStatRatioMaxValue(FlatBufferBuilder builder, long StatRatioMaxValue) { builder.AddLong(6, StatRatioMaxValue, 0); }
  public static Offset<FlatDataJp.CharacterStatLimitExcel> EndCharacterStatLimitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterStatLimitExcel>(o);
  }
}


}
