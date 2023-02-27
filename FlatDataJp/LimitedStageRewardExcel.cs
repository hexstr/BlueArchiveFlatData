// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LimitedStageRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static LimitedStageRewardExcel GetRootAsLimitedStageRewardExcel(ByteBuffer _bb) { return GetRootAsLimitedStageRewardExcel(_bb, new LimitedStageRewardExcel()); }
  public static LimitedStageRewardExcel GetRootAsLimitedStageRewardExcel(ByteBuffer _bb, LimitedStageRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LimitedStageRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.RewardTag RewardTag { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.RewardTag.Default; } }
  public int RewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long RewardId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RewardAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.LimitedStageRewardExcel> CreateLimitedStageRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      FlatDataJp.RewardTag RewardTag = FlatDataJp.RewardTag.Default,
      int RewardProb = 0,
      FlatDataJp.ParcelType RewardParcelType = FlatDataJp.ParcelType.None,
      long RewardId = 0,
      int RewardAmount = 0,
      bool IsDisplayed = false) {
    builder.StartTable(7);
    LimitedStageRewardExcel.AddRewardId(builder, RewardId);
    LimitedStageRewardExcel.AddGroupId(builder, GroupId);
    LimitedStageRewardExcel.AddRewardAmount(builder, RewardAmount);
    LimitedStageRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    LimitedStageRewardExcel.AddRewardProb(builder, RewardProb);
    LimitedStageRewardExcel.AddRewardTag(builder, RewardTag);
    LimitedStageRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return LimitedStageRewardExcel.EndLimitedStageRewardExcel(builder);
  }

  public static void StartLimitedStageRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddRewardTag(FlatBufferBuilder builder, FlatDataJp.RewardTag RewardTag) { builder.AddInt(1, (int)RewardTag, 0); }
  public static void AddRewardProb(FlatBufferBuilder builder, int RewardProb) { builder.AddInt(2, RewardProb, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType RewardParcelType) { builder.AddInt(3, (int)RewardParcelType, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, long RewardId) { builder.AddLong(4, RewardId, 0); }
  public static void AddRewardAmount(FlatBufferBuilder builder, int RewardAmount) { builder.AddInt(5, RewardAmount, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool IsDisplayed) { builder.AddBool(6, IsDisplayed, false); }
  public static Offset<FlatDataJp.LimitedStageRewardExcel> EndLimitedStageRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.LimitedStageRewardExcel>(o);
  }
}


}
