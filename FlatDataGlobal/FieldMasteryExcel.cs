// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldMasteryExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FieldMasteryExcel GetRootAsFieldMasteryExcel(ByteBuffer _bb) { return GetRootAsFieldMasteryExcel(_bb, new FieldMasteryExcel()); }
  public static FieldMasteryExcel GetRootAsFieldMasteryExcel(ByteBuffer _bb, FieldMasteryExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldMasteryExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Order { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long ExpAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType TokenType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long TokenId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TokenRequirement { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.FieldConditionType AccomplishmentConditionType { get { int o = __p.__offset(18); return o != 0 ? (FlatDataGlobal.FieldConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.FieldConditionType.Invalid; } }
  public long AccomplishmentConditionId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.FieldMasteryExcel> CreateFieldMasteryExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long SeasonId = 0,
      int Order = 0,
      long ExpAmount = 0,
      FlatDataGlobal.ParcelType TokenType = FlatDataGlobal.ParcelType.None,
      long TokenId = 0,
      long TokenRequirement = 0,
      FlatDataGlobal.FieldConditionType AccomplishmentConditionType = FlatDataGlobal.FieldConditionType.Invalid,
      long AccomplishmentConditionId = 0) {
    builder.StartTable(9);
    FieldMasteryExcel.AddAccomplishmentConditionId(builder, AccomplishmentConditionId);
    FieldMasteryExcel.AddTokenRequirement(builder, TokenRequirement);
    FieldMasteryExcel.AddTokenId(builder, TokenId);
    FieldMasteryExcel.AddExpAmount(builder, ExpAmount);
    FieldMasteryExcel.AddSeasonId(builder, SeasonId);
    FieldMasteryExcel.AddUniqueId(builder, UniqueId);
    FieldMasteryExcel.AddAccomplishmentConditionType(builder, AccomplishmentConditionType);
    FieldMasteryExcel.AddTokenType(builder, TokenType);
    FieldMasteryExcel.AddOrder(builder, Order);
    return FieldMasteryExcel.EndFieldMasteryExcel(builder);
  }

  public static void StartFieldMasteryExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, long SeasonId) { builder.AddLong(1, SeasonId, 0); }
  public static void AddOrder(FlatBufferBuilder builder, int Order) { builder.AddInt(2, Order, 0); }
  public static void AddExpAmount(FlatBufferBuilder builder, long ExpAmount) { builder.AddLong(3, ExpAmount, 0); }
  public static void AddTokenType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType TokenType) { builder.AddInt(4, (int)TokenType, 0); }
  public static void AddTokenId(FlatBufferBuilder builder, long TokenId) { builder.AddLong(5, TokenId, 0); }
  public static void AddTokenRequirement(FlatBufferBuilder builder, long TokenRequirement) { builder.AddLong(6, TokenRequirement, 0); }
  public static void AddAccomplishmentConditionType(FlatBufferBuilder builder, FlatDataGlobal.FieldConditionType AccomplishmentConditionType) { builder.AddInt(7, (int)AccomplishmentConditionType, 0); }
  public static void AddAccomplishmentConditionId(FlatBufferBuilder builder, long AccomplishmentConditionId) { builder.AddLong(8, AccomplishmentConditionId, 0); }
  public static Offset<FlatDataGlobal.FieldMasteryExcel> EndFieldMasteryExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.FieldMasteryExcel>(o);
  }
}


}
