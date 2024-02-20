// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DuplicateBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DuplicateBonusExcel GetRootAsDuplicateBonusExcel(ByteBuffer _bb) { return GetRootAsDuplicateBonusExcel(_bb, new DuplicateBonusExcel()); }
  public static DuplicateBonusExcel GetRootAsDuplicateBonusExcel(ByteBuffer _bb, DuplicateBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DuplicateBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ItemCategory ItemCategory { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ItemCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ItemCategory.Coin; } }
  public long ItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType RewardParcelType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.DuplicateBonusExcel> CreateDuplicateBonusExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.ItemCategory itemCategory = FlatDataJp.ItemCategory.Coin,
      long ItemId = 0,
      long CharacterId = 0,
      FlatDataJp.ParcelType RewardParcelType = FlatDataJp.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0) {
    builder.StartTable(7);
    DuplicateBonusExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    DuplicateBonusExcel.AddRewardParcelId(builder, RewardParcelId);
    DuplicateBonusExcel.AddCharacterId(builder, CharacterId);
    DuplicateBonusExcel.AddItemId(builder, ItemId);
    DuplicateBonusExcel.AddId(builder, Id);
    DuplicateBonusExcel.AddRewardParcelType(builder, RewardParcelType);
    DuplicateBonusExcel.AddItemCategory(builder, itemCategory);
    return DuplicateBonusExcel.EndDuplicateBonusExcel(builder);
  }

  public static void StartDuplicateBonusExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddItemCategory(FlatBufferBuilder builder, FlatDataJp.ItemCategory itemCategory) { builder.AddInt(1, (int)itemCategory, 0); }
  public static void AddItemId(FlatBufferBuilder builder, long ItemId) { builder.AddLong(2, ItemId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(3, CharacterId, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType RewardParcelType) { builder.AddInt(4, (int)RewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long RewardParcelId) { builder.AddLong(5, RewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long RewardParcelAmount) { builder.AddLong(6, RewardParcelAmount, 0); }
  public static Offset<FlatDataJp.DuplicateBonusExcel> EndDuplicateBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.DuplicateBonusExcel>(o);
  }
}


}
