// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CameraExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CameraExcel GetRootAsCameraExcel(ByteBuffer _bb) { return GetRootAsCameraExcel(_bb, new CameraExcel()); }
  public static CameraExcel GetRootAsCameraExcel(ByteBuffer _bb, CameraExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CameraExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float MinDistance { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MaxDistance { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float RotationX { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float RotationY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool MoveInstantly { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float LeftMargin { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float BottomMargin { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IgnoreEnemies { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool UseRailPointCompensation { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.CameraExcel> CreateCameraExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      float MinDistance = 0.0f,
      float MaxDistance = 0.0f,
      float RotationX = 0.0f,
      float RotationY = 0.0f,
      bool MoveInstantly = false,
      float LeftMargin = 0.0f,
      float BottomMargin = 0.0f,
      bool IgnoreEnemies = false,
      bool UseRailPointCompensation = false) {
    builder.StartTable(10);
    CameraExcel.AddUniqueId(builder, UniqueId);
    CameraExcel.AddBottomMargin(builder, BottomMargin);
    CameraExcel.AddLeftMargin(builder, LeftMargin);
    CameraExcel.AddRotationY(builder, RotationY);
    CameraExcel.AddRotationX(builder, RotationX);
    CameraExcel.AddMaxDistance(builder, MaxDistance);
    CameraExcel.AddMinDistance(builder, MinDistance);
    CameraExcel.AddUseRailPointCompensation(builder, UseRailPointCompensation);
    CameraExcel.AddIgnoreEnemies(builder, IgnoreEnemies);
    CameraExcel.AddMoveInstantly(builder, MoveInstantly);
    return CameraExcel.EndCameraExcel(builder);
  }

  public static void StartCameraExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddMinDistance(FlatBufferBuilder builder, float MinDistance) { builder.AddFloat(1, MinDistance, 0.0f); }
  public static void AddMaxDistance(FlatBufferBuilder builder, float MaxDistance) { builder.AddFloat(2, MaxDistance, 0.0f); }
  public static void AddRotationX(FlatBufferBuilder builder, float RotationX) { builder.AddFloat(3, RotationX, 0.0f); }
  public static void AddRotationY(FlatBufferBuilder builder, float RotationY) { builder.AddFloat(4, RotationY, 0.0f); }
  public static void AddMoveInstantly(FlatBufferBuilder builder, bool MoveInstantly) { builder.AddBool(5, MoveInstantly, false); }
  public static void AddLeftMargin(FlatBufferBuilder builder, float LeftMargin) { builder.AddFloat(6, LeftMargin, 0.0f); }
  public static void AddBottomMargin(FlatBufferBuilder builder, float BottomMargin) { builder.AddFloat(7, BottomMargin, 0.0f); }
  public static void AddIgnoreEnemies(FlatBufferBuilder builder, bool IgnoreEnemies) { builder.AddBool(8, IgnoreEnemies, false); }
  public static void AddUseRailPointCompensation(FlatBufferBuilder builder, bool UseRailPointCompensation) { builder.AddBool(9, UseRailPointCompensation, false); }
  public static Offset<FlatDataJp.CameraExcel> EndCameraExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CameraExcel>(o);
  }
}


}
