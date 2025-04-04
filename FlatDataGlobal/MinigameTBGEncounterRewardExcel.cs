// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGEncounterRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGEncounterRewardExcel(_bb, new MinigameTBGEncounterRewardExcel()); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb, MinigameTBGEncounterRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGEncounterRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TBGOptionSuccessType TBGOptionSuccessType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.TBGOptionSuccessType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TBGOptionSuccessType.None; } }
  public long Paremeter { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType ParcelType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Amount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Prob { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.MinigameTBGEncounterRewardExcel> CreateMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      long UniqueId = 0,
      FlatDataGlobal.TBGOptionSuccessType tBGOptionSuccessType = FlatDataGlobal.TBGOptionSuccessType.None,
      long Paremeter = 0,
      FlatDataGlobal.ParcelType parcelType = FlatDataGlobal.ParcelType.None,
      long ParcelId = 0,
      long Amount = 0,
      int Prob = 0) {
    builder.StartTable(8);
    MinigameTBGEncounterRewardExcel.AddAmount(builder, Amount);
    MinigameTBGEncounterRewardExcel.AddParcelId(builder, ParcelId);
    MinigameTBGEncounterRewardExcel.AddParemeter(builder, Paremeter);
    MinigameTBGEncounterRewardExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGEncounterRewardExcel.AddGroupId(builder, GroupId);
    MinigameTBGEncounterRewardExcel.AddProb(builder, Prob);
    MinigameTBGEncounterRewardExcel.AddParcelType(builder, parcelType);
    MinigameTBGEncounterRewardExcel.AddTBGOptionSuccessType(builder, tBGOptionSuccessType);
    return MinigameTBGEncounterRewardExcel.EndMinigameTBGEncounterRewardExcel(builder);
  }

  public static void StartMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(1, UniqueId, 0); }
  public static void AddTBGOptionSuccessType(FlatBufferBuilder builder, FlatDataGlobal.TBGOptionSuccessType tBGOptionSuccessType) { builder.AddInt(2, (int)tBGOptionSuccessType, 0); }
  public static void AddParemeter(FlatBufferBuilder builder, long Paremeter) { builder.AddLong(3, Paremeter, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType parcelType) { builder.AddInt(4, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long ParcelId) { builder.AddLong(5, ParcelId, 0); }
  public static void AddAmount(FlatBufferBuilder builder, long Amount) { builder.AddLong(6, Amount, 0); }
  public static void AddProb(FlatBufferBuilder builder, int Prob) { builder.AddInt(7, Prob, 0); }
  public static Offset<FlatDataGlobal.MinigameTBGEncounterRewardExcel> EndMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MinigameTBGEncounterRewardExcel>(o);
  }
}


}
