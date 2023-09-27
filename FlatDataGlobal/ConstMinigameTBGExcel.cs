// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstMinigameTBGExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConstMinigameTBGExcel GetRootAsConstMinigameTBGExcel(ByteBuffer _bb) { return GetRootAsConstMinigameTBGExcel(_bb, new ConstMinigameTBGExcel()); }
  public static ConstMinigameTBGExcel GetRootAsConstMinigameTBGExcel(ByteBuffer _bb, ConstMinigameTBGExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstMinigameTBGExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float ConquestMapBoundaryOffsetLeft { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetRight { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetTop { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetBottom { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetX { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetY { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraAngle { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMax { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomDefault { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataGlobal.ConstMinigameTBGExcel> CreateConstMinigameTBGExcel(FlatBufferBuilder builder,
      float ConquestMapBoundaryOffsetLeft = 0.0f,
      float ConquestMapBoundaryOffsetRight = 0.0f,
      float ConquestMapBoundaryOffsetTop = 0.0f,
      float ConquestMapBoundaryOffsetBottom = 0.0f,
      float ConquestMapCenterOffsetX = 0.0f,
      float ConquestMapCenterOffsetY = 0.0f,
      float CameraAngle = 0.0f,
      float CameraZoomMax = 0.0f,
      float CameraZoomMin = 0.0f,
      float CameraZoomDefault = 0.0f) {
    builder.StartTable(10);
    ConstMinigameTBGExcel.AddCameraZoomDefault(builder, CameraZoomDefault);
    ConstMinigameTBGExcel.AddCameraZoomMin(builder, CameraZoomMin);
    ConstMinigameTBGExcel.AddCameraZoomMax(builder, CameraZoomMax);
    ConstMinigameTBGExcel.AddCameraAngle(builder, CameraAngle);
    ConstMinigameTBGExcel.AddConquestMapCenterOffsetY(builder, ConquestMapCenterOffsetY);
    ConstMinigameTBGExcel.AddConquestMapCenterOffsetX(builder, ConquestMapCenterOffsetX);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetBottom(builder, ConquestMapBoundaryOffsetBottom);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetTop(builder, ConquestMapBoundaryOffsetTop);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetRight(builder, ConquestMapBoundaryOffsetRight);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetLeft(builder, ConquestMapBoundaryOffsetLeft);
    return ConstMinigameTBGExcel.EndConstMinigameTBGExcel(builder);
  }

  public static void StartConstMinigameTBGExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddConquestMapBoundaryOffsetLeft(FlatBufferBuilder builder, float ConquestMapBoundaryOffsetLeft) { builder.AddFloat(0, ConquestMapBoundaryOffsetLeft, 0.0f); }
  public static void AddConquestMapBoundaryOffsetRight(FlatBufferBuilder builder, float ConquestMapBoundaryOffsetRight) { builder.AddFloat(1, ConquestMapBoundaryOffsetRight, 0.0f); }
  public static void AddConquestMapBoundaryOffsetTop(FlatBufferBuilder builder, float ConquestMapBoundaryOffsetTop) { builder.AddFloat(2, ConquestMapBoundaryOffsetTop, 0.0f); }
  public static void AddConquestMapBoundaryOffsetBottom(FlatBufferBuilder builder, float ConquestMapBoundaryOffsetBottom) { builder.AddFloat(3, ConquestMapBoundaryOffsetBottom, 0.0f); }
  public static void AddConquestMapCenterOffsetX(FlatBufferBuilder builder, float ConquestMapCenterOffsetX) { builder.AddFloat(4, ConquestMapCenterOffsetX, 0.0f); }
  public static void AddConquestMapCenterOffsetY(FlatBufferBuilder builder, float ConquestMapCenterOffsetY) { builder.AddFloat(5, ConquestMapCenterOffsetY, 0.0f); }
  public static void AddCameraAngle(FlatBufferBuilder builder, float CameraAngle) { builder.AddFloat(6, CameraAngle, 0.0f); }
  public static void AddCameraZoomMax(FlatBufferBuilder builder, float CameraZoomMax) { builder.AddFloat(7, CameraZoomMax, 0.0f); }
  public static void AddCameraZoomMin(FlatBufferBuilder builder, float CameraZoomMin) { builder.AddFloat(8, CameraZoomMin, 0.0f); }
  public static void AddCameraZoomDefault(FlatBufferBuilder builder, float CameraZoomDefault) { builder.AddFloat(9, CameraZoomDefault, 0.0f); }
  public static Offset<FlatDataGlobal.ConstMinigameTBGExcel> EndConstMinigameTBGExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConstMinigameTBGExcel>(o);
  }
}


}
