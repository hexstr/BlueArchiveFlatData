// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ClanAssistSlotExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ClanAssistSlotExcel GetRootAsClanAssistSlotExcel(ByteBuffer _bb) { return GetRootAsClanAssistSlotExcel(_bb, new ClanAssistSlotExcel()); }
  public static ClanAssistSlotExcel GetRootAsClanAssistSlotExcel(ByteBuffer _bb, ClanAssistSlotExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanAssistSlotExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SlotId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EchelonType EchelonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.EchelonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EchelonType.None; } }
  public long SlotNumber { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistTermRewardPeriodFromSec { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRewardLimit { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentRewardDailyMaxCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentalFeeAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentalFeeAmountStranger { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ClanAssistSlotExcel> CreateClanAssistSlotExcel(FlatBufferBuilder builder,
      long SlotId = 0,
      FlatDataJp.EchelonType echelonType = FlatDataJp.EchelonType.None,
      long SlotNumber = 0,
      long AssistTermRewardPeriodFromSec = 0,
      long AssistRewardLimit = 0,
      long AssistRentRewardDailyMaxCount = 0,
      long AssistRentalFeeAmount = 0,
      long AssistRentalFeeAmountStranger = 0) {
    builder.StartTable(8);
    ClanAssistSlotExcel.AddAssistRentalFeeAmountStranger(builder, AssistRentalFeeAmountStranger);
    ClanAssistSlotExcel.AddAssistRentalFeeAmount(builder, AssistRentalFeeAmount);
    ClanAssistSlotExcel.AddAssistRentRewardDailyMaxCount(builder, AssistRentRewardDailyMaxCount);
    ClanAssistSlotExcel.AddAssistRewardLimit(builder, AssistRewardLimit);
    ClanAssistSlotExcel.AddAssistTermRewardPeriodFromSec(builder, AssistTermRewardPeriodFromSec);
    ClanAssistSlotExcel.AddSlotNumber(builder, SlotNumber);
    ClanAssistSlotExcel.AddSlotId(builder, SlotId);
    ClanAssistSlotExcel.AddEchelonType(builder, echelonType);
    return ClanAssistSlotExcel.EndClanAssistSlotExcel(builder);
  }

  public static void StartClanAssistSlotExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddSlotId(FlatBufferBuilder builder, long SlotId) { builder.AddLong(0, SlotId, 0); }
  public static void AddEchelonType(FlatBufferBuilder builder, FlatDataJp.EchelonType echelonType) { builder.AddInt(1, (int)echelonType, 0); }
  public static void AddSlotNumber(FlatBufferBuilder builder, long SlotNumber) { builder.AddLong(2, SlotNumber, 0); }
  public static void AddAssistTermRewardPeriodFromSec(FlatBufferBuilder builder, long AssistTermRewardPeriodFromSec) { builder.AddLong(3, AssistTermRewardPeriodFromSec, 0); }
  public static void AddAssistRewardLimit(FlatBufferBuilder builder, long AssistRewardLimit) { builder.AddLong(4, AssistRewardLimit, 0); }
  public static void AddAssistRentRewardDailyMaxCount(FlatBufferBuilder builder, long AssistRentRewardDailyMaxCount) { builder.AddLong(5, AssistRentRewardDailyMaxCount, 0); }
  public static void AddAssistRentalFeeAmount(FlatBufferBuilder builder, long AssistRentalFeeAmount) { builder.AddLong(6, AssistRentalFeeAmount, 0); }
  public static void AddAssistRentalFeeAmountStranger(FlatBufferBuilder builder, long AssistRentalFeeAmountStranger) { builder.AddLong(7, AssistRentalFeeAmountStranger, 0); }
  public static Offset<FlatDataJp.ClanAssistSlotExcel> EndClanAssistSlotExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ClanAssistSlotExcel>(o);
  }
}


}
