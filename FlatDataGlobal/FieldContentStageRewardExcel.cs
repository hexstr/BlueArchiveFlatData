// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldContentStageRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FieldContentStageRewardExcel GetRootAsFieldContentStageRewardExcel(ByteBuffer _bb) { return GetRootAsFieldContentStageRewardExcel(_bb, new FieldContentStageRewardExcel()); }
  public static FieldContentStageRewardExcel GetRootAsFieldContentStageRewardExcel(ByteBuffer _bb, FieldContentStageRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldContentStageRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.RewardTag RewardTag { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.RewardTag.Default; } }
  public int RewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long RewardId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RewardAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.FieldContentStageRewardExcel> CreateFieldContentStageRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      FlatDataGlobal.RewardTag rewardTag = FlatDataGlobal.RewardTag.Default,
      int RewardProb = 0,
      FlatDataGlobal.ParcelType RewardParcelType = FlatDataGlobal.ParcelType.None,
      long RewardId = 0,
      int RewardAmount = 0,
      bool IsDisplayed = false) {
    builder.StartTable(7);
    FieldContentStageRewardExcel.AddRewardId(builder, RewardId);
    FieldContentStageRewardExcel.AddGroupId(builder, GroupId);
    FieldContentStageRewardExcel.AddRewardAmount(builder, RewardAmount);
    FieldContentStageRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    FieldContentStageRewardExcel.AddRewardProb(builder, RewardProb);
    FieldContentStageRewardExcel.AddRewardTag(builder, rewardTag);
    FieldContentStageRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return FieldContentStageRewardExcel.EndFieldContentStageRewardExcel(builder);
  }

  public static void StartFieldContentStageRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddRewardTag(FlatBufferBuilder builder, FlatDataGlobal.RewardTag rewardTag) { builder.AddInt(1, (int)rewardTag, 0); }
  public static void AddRewardProb(FlatBufferBuilder builder, int RewardProb) { builder.AddInt(2, RewardProb, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType RewardParcelType) { builder.AddInt(3, (int)RewardParcelType, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, long RewardId) { builder.AddLong(4, RewardId, 0); }
  public static void AddRewardAmount(FlatBufferBuilder builder, int RewardAmount) { builder.AddInt(5, RewardAmount, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool IsDisplayed) { builder.AddBool(6, IsDisplayed, false); }
  public static Offset<FlatDataGlobal.FieldContentStageRewardExcel> EndFieldContentStageRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.FieldContentStageRewardExcel>(o);
  }
}


}
