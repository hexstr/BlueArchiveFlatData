// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterAIExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterAIExcel GetRootAsCharacterAIExcel(ByteBuffer _bb) { return GetRootAsCharacterAIExcel(_bb, new CharacterAIExcel()); }
  public static CharacterAIExcel GetRootAsCharacterAIExcel(ByteBuffer _bb, CharacterAIExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterAIExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.EngageType EngageType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.EngageType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EngageType.SearchAndMove; } }
  public FlatDataGlobal.PositioningType Positioning { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.PositioningType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.PositioningType.CloseToObstacle; } }
  public bool CheckCanUseAutoSkill { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long DistanceReduceRatioObstaclePath { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceObstaclePath { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceRatioFormationPath { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceFormationPath { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MinimumPositionGap { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CanUseObstacleOfKneelMotion { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool CanUseObstacleOfStandMotion { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HasTargetSwitchingMotion { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.CharacterAIExcel> CreateCharacterAIExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataGlobal.EngageType engageType = FlatDataGlobal.EngageType.SearchAndMove,
      FlatDataGlobal.PositioningType Positioning = FlatDataGlobal.PositioningType.CloseToObstacle,
      bool CheckCanUseAutoSkill = false,
      long DistanceReduceRatioObstaclePath = 0,
      long DistanceReduceObstaclePath = 0,
      long DistanceReduceRatioFormationPath = 0,
      long DistanceReduceFormationPath = 0,
      long MinimumPositionGap = 0,
      bool CanUseObstacleOfKneelMotion = false,
      bool CanUseObstacleOfStandMotion = false,
      bool HasTargetSwitchingMotion = false) {
    builder.StartTable(12);
    CharacterAIExcel.AddMinimumPositionGap(builder, MinimumPositionGap);
    CharacterAIExcel.AddDistanceReduceFormationPath(builder, DistanceReduceFormationPath);
    CharacterAIExcel.AddDistanceReduceRatioFormationPath(builder, DistanceReduceRatioFormationPath);
    CharacterAIExcel.AddDistanceReduceObstaclePath(builder, DistanceReduceObstaclePath);
    CharacterAIExcel.AddDistanceReduceRatioObstaclePath(builder, DistanceReduceRatioObstaclePath);
    CharacterAIExcel.AddId(builder, Id);
    CharacterAIExcel.AddPositioning(builder, Positioning);
    CharacterAIExcel.AddEngageType(builder, engageType);
    CharacterAIExcel.AddHasTargetSwitchingMotion(builder, HasTargetSwitchingMotion);
    CharacterAIExcel.AddCanUseObstacleOfStandMotion(builder, CanUseObstacleOfStandMotion);
    CharacterAIExcel.AddCanUseObstacleOfKneelMotion(builder, CanUseObstacleOfKneelMotion);
    CharacterAIExcel.AddCheckCanUseAutoSkill(builder, CheckCanUseAutoSkill);
    return CharacterAIExcel.EndCharacterAIExcel(builder);
  }

  public static void StartCharacterAIExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEngageType(FlatBufferBuilder builder, FlatDataGlobal.EngageType engageType) { builder.AddInt(1, (int)engageType, 0); }
  public static void AddPositioning(FlatBufferBuilder builder, FlatDataGlobal.PositioningType Positioning) { builder.AddInt(2, (int)Positioning, 0); }
  public static void AddCheckCanUseAutoSkill(FlatBufferBuilder builder, bool CheckCanUseAutoSkill) { builder.AddBool(3, CheckCanUseAutoSkill, false); }
  public static void AddDistanceReduceRatioObstaclePath(FlatBufferBuilder builder, long DistanceReduceRatioObstaclePath) { builder.AddLong(4, DistanceReduceRatioObstaclePath, 0); }
  public static void AddDistanceReduceObstaclePath(FlatBufferBuilder builder, long DistanceReduceObstaclePath) { builder.AddLong(5, DistanceReduceObstaclePath, 0); }
  public static void AddDistanceReduceRatioFormationPath(FlatBufferBuilder builder, long DistanceReduceRatioFormationPath) { builder.AddLong(6, DistanceReduceRatioFormationPath, 0); }
  public static void AddDistanceReduceFormationPath(FlatBufferBuilder builder, long DistanceReduceFormationPath) { builder.AddLong(7, DistanceReduceFormationPath, 0); }
  public static void AddMinimumPositionGap(FlatBufferBuilder builder, long MinimumPositionGap) { builder.AddLong(8, MinimumPositionGap, 0); }
  public static void AddCanUseObstacleOfKneelMotion(FlatBufferBuilder builder, bool CanUseObstacleOfKneelMotion) { builder.AddBool(9, CanUseObstacleOfKneelMotion, false); }
  public static void AddCanUseObstacleOfStandMotion(FlatBufferBuilder builder, bool CanUseObstacleOfStandMotion) { builder.AddBool(10, CanUseObstacleOfStandMotion, false); }
  public static void AddHasTargetSwitchingMotion(FlatBufferBuilder builder, bool HasTargetSwitchingMotion) { builder.AddBool(11, HasTargetSwitchingMotion, false); }
  public static Offset<FlatDataGlobal.CharacterAIExcel> EndCharacterAIExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterAIExcel>(o);
  }
}


}
