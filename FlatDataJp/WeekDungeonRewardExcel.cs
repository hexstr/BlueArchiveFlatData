// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeekDungeonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static WeekDungeonRewardExcel GetRootAsWeekDungeonRewardExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonRewardExcel(_bb, new WeekDungeonRewardExcel()); }
  public static WeekDungeonRewardExcel GetRootAsWeekDungeonRewardExcel(ByteBuffer _bb, WeekDungeonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.WeekDungeonType DungeonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.WeekDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.WeekDungeonType.None; } }
  public FlatDataJp.ParcelType RewardParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelProbability { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string DropItemModelPrefabPath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDropItemModelPrefabPathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetDropItemModelPrefabPathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetDropItemModelPrefabPathArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataJp.WeekDungeonRewardExcel> CreateWeekDungeonRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      FlatDataJp.WeekDungeonType DungeonType = FlatDataJp.WeekDungeonType.None,
      FlatDataJp.ParcelType RewardParcelType = FlatDataJp.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0,
      long RewardParcelProbability = 0,
      bool IsDisplayed = false,
      StringOffset DropItemModelPrefabPathOffset = default(StringOffset)) {
    builder.StartTable(8);
    WeekDungeonRewardExcel.AddRewardParcelProbability(builder, RewardParcelProbability);
    WeekDungeonRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    WeekDungeonRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    WeekDungeonRewardExcel.AddGroupId(builder, GroupId);
    WeekDungeonRewardExcel.AddDropItemModelPrefabPath(builder, DropItemModelPrefabPathOffset);
    WeekDungeonRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    WeekDungeonRewardExcel.AddDungeonType(builder, DungeonType);
    WeekDungeonRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return WeekDungeonRewardExcel.EndWeekDungeonRewardExcel(builder);
  }

  public static void StartWeekDungeonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddDungeonType(FlatBufferBuilder builder, FlatDataJp.WeekDungeonType DungeonType) { builder.AddInt(1, (int)DungeonType, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType RewardParcelType) { builder.AddInt(2, (int)RewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long RewardParcelId) { builder.AddLong(3, RewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long RewardParcelAmount) { builder.AddLong(4, RewardParcelAmount, 0); }
  public static void AddRewardParcelProbability(FlatBufferBuilder builder, long RewardParcelProbability) { builder.AddLong(5, RewardParcelProbability, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool IsDisplayed) { builder.AddBool(6, IsDisplayed, false); }
  public static void AddDropItemModelPrefabPath(FlatBufferBuilder builder, StringOffset DropItemModelPrefabPathOffset) { builder.AddOffset(7, DropItemModelPrefabPathOffset.Value, 0); }
  public static Offset<FlatDataJp.WeekDungeonRewardExcel> EndWeekDungeonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.WeekDungeonRewardExcel>(o);
  }
}


}
