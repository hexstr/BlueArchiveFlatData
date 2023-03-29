// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ClanRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb) { return GetRootAsClanRewardExcel(_bb, new ClanRewardExcel()); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb, ClanRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.ClanRewardType ClanRewardType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.ClanRewardType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ClanRewardType.None; } }
  public FlatDataGlobal.EchelonType EchelonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.EchelonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EchelonType.None; } }
  public FlatDataGlobal.ParcelType RewardParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.ClanRewardExcel> CreateClanRewardExcel(FlatBufferBuilder builder,
      FlatDataGlobal.ClanRewardType ClanRewardType = FlatDataGlobal.ClanRewardType.None,
      FlatDataGlobal.EchelonType EchelonType = FlatDataGlobal.EchelonType.None,
      FlatDataGlobal.ParcelType RewardParcelType = FlatDataGlobal.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0) {
    builder.StartTable(5);
    ClanRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    ClanRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    ClanRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    ClanRewardExcel.AddEchelonType(builder, EchelonType);
    ClanRewardExcel.AddClanRewardType(builder, ClanRewardType);
    return ClanRewardExcel.EndClanRewardExcel(builder);
  }

  public static void StartClanRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddClanRewardType(FlatBufferBuilder builder, FlatDataGlobal.ClanRewardType ClanRewardType) { builder.AddInt(0, (int)ClanRewardType, 0); }
  public static void AddEchelonType(FlatBufferBuilder builder, FlatDataGlobal.EchelonType EchelonType) { builder.AddInt(1, (int)EchelonType, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType RewardParcelType) { builder.AddInt(2, (int)RewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long RewardParcelId) { builder.AddLong(3, RewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long RewardParcelAmount) { builder.AddLong(4, RewardParcelAmount, 0); }
  public static Offset<FlatDataGlobal.ClanRewardExcel> EndClanRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ClanRewardExcel>(o);
  }
}


}
