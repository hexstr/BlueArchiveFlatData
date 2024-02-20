// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignStageRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CampaignStageRewardExcel GetRootAsCampaignStageRewardExcel(ByteBuffer _bb) { return GetRootAsCampaignStageRewardExcel(_bb, new CampaignStageRewardExcel()); }
  public static CampaignStageRewardExcel GetRootAsCampaignStageRewardExcel(ByteBuffer _bb, CampaignStageRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStageRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.RewardTag RewardTag { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.RewardTag.Default; } }
  public int StageRewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ParcelType StageRewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long StageRewardId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageRewardAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.CampaignStageRewardExcel> CreateCampaignStageRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      FlatDataJp.RewardTag rewardTag = FlatDataJp.RewardTag.Default,
      int StageRewardProb = 0,
      FlatDataJp.ParcelType StageRewardParcelType = FlatDataJp.ParcelType.None,
      long StageRewardId = 0,
      int StageRewardAmount = 0,
      bool IsDisplayed = false) {
    builder.StartTable(7);
    CampaignStageRewardExcel.AddStageRewardId(builder, StageRewardId);
    CampaignStageRewardExcel.AddGroupId(builder, GroupId);
    CampaignStageRewardExcel.AddStageRewardAmount(builder, StageRewardAmount);
    CampaignStageRewardExcel.AddStageRewardParcelType(builder, StageRewardParcelType);
    CampaignStageRewardExcel.AddStageRewardProb(builder, StageRewardProb);
    CampaignStageRewardExcel.AddRewardTag(builder, rewardTag);
    CampaignStageRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return CampaignStageRewardExcel.EndCampaignStageRewardExcel(builder);
  }

  public static void StartCampaignStageRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddRewardTag(FlatBufferBuilder builder, FlatDataJp.RewardTag rewardTag) { builder.AddInt(1, (int)rewardTag, 0); }
  public static void AddStageRewardProb(FlatBufferBuilder builder, int StageRewardProb) { builder.AddInt(2, StageRewardProb, 0); }
  public static void AddStageRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType StageRewardParcelType) { builder.AddInt(3, (int)StageRewardParcelType, 0); }
  public static void AddStageRewardId(FlatBufferBuilder builder, long StageRewardId) { builder.AddLong(4, StageRewardId, 0); }
  public static void AddStageRewardAmount(FlatBufferBuilder builder, int StageRewardAmount) { builder.AddInt(5, StageRewardAmount, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool IsDisplayed) { builder.AddBool(6, IsDisplayed, false); }
  public static Offset<FlatDataJp.CampaignStageRewardExcel> EndCampaignStageRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CampaignStageRewardExcel>(o);
  }
}


}
