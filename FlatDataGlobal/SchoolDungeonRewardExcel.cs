// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SchoolDungeonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static SchoolDungeonRewardExcel GetRootAsSchoolDungeonRewardExcel(ByteBuffer _bb) { return GetRootAsSchoolDungeonRewardExcel(_bb, new SchoolDungeonRewardExcel()); }
  public static SchoolDungeonRewardExcel GetRootAsSchoolDungeonRewardExcel(ByteBuffer _bb, SchoolDungeonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SchoolDungeonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.SchoolDungeonType DungeonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.SchoolDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.SchoolDungeonType.SchoolA; } }
  public FlatDataGlobal.RewardTag RewardTag { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.RewardTag.Default; } }
  public FlatDataGlobal.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelProbability { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.SchoolDungeonRewardExcel> CreateSchoolDungeonRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      FlatDataGlobal.SchoolDungeonType DungeonType = FlatDataGlobal.SchoolDungeonType.SchoolA,
      FlatDataGlobal.RewardTag rewardTag = FlatDataGlobal.RewardTag.Default,
      FlatDataGlobal.ParcelType RewardParcelType = FlatDataGlobal.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0,
      long RewardParcelProbability = 0,
      bool IsDisplayed = false) {
    builder.StartTable(8);
    SchoolDungeonRewardExcel.AddRewardParcelProbability(builder, RewardParcelProbability);
    SchoolDungeonRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    SchoolDungeonRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    SchoolDungeonRewardExcel.AddGroupId(builder, GroupId);
    SchoolDungeonRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    SchoolDungeonRewardExcel.AddRewardTag(builder, rewardTag);
    SchoolDungeonRewardExcel.AddDungeonType(builder, DungeonType);
    SchoolDungeonRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return SchoolDungeonRewardExcel.EndSchoolDungeonRewardExcel(builder);
  }

  public static void StartSchoolDungeonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddDungeonType(FlatBufferBuilder builder, FlatDataGlobal.SchoolDungeonType DungeonType) { builder.AddInt(1, (int)DungeonType, 0); }
  public static void AddRewardTag(FlatBufferBuilder builder, FlatDataGlobal.RewardTag rewardTag) { builder.AddInt(2, (int)rewardTag, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType RewardParcelType) { builder.AddInt(3, (int)RewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long RewardParcelId) { builder.AddLong(4, RewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long RewardParcelAmount) { builder.AddLong(5, RewardParcelAmount, 0); }
  public static void AddRewardParcelProbability(FlatBufferBuilder builder, long RewardParcelProbability) { builder.AddLong(6, RewardParcelProbability, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool IsDisplayed) { builder.AddBool(7, IsDisplayed, false); }
  public static Offset<FlatDataGlobal.SchoolDungeonRewardExcel> EndSchoolDungeonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.SchoolDungeonRewardExcel>(o);
  }
}


}
