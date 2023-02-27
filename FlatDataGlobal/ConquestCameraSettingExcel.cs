// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestCameraSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConquestCameraSettingExcel GetRootAsConquestCameraSettingExcel(ByteBuffer _bb) { return GetRootAsConquestCameraSettingExcel(_bb, new ConquestCameraSettingExcel()); }
  public static ConquestCameraSettingExcel GetRootAsConquestCameraSettingExcel(ByteBuffer _bb, ConquestCameraSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestCameraSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float ConquestMapBoundaryOffsetLeft(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapBoundaryOffsetLeftLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapBoundaryOffsetLeftBytes() { return __p.__vector_as_span<float>(6, 4); }
#else
  public ArraySegment<byte>? GetConquestMapBoundaryOffsetLeftBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public float[] GetConquestMapBoundaryOffsetLeftArray() { return __p.__vector_as_array<float>(6); }
  public float ConquestMapBoundaryOffsetRight(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapBoundaryOffsetRightLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapBoundaryOffsetRightBytes() { return __p.__vector_as_span<float>(8, 4); }
#else
  public ArraySegment<byte>? GetConquestMapBoundaryOffsetRightBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public float[] GetConquestMapBoundaryOffsetRightArray() { return __p.__vector_as_array<float>(8); }
  public float ConquestMapBoundaryOffsetTop(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapBoundaryOffsetTopLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapBoundaryOffsetTopBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetConquestMapBoundaryOffsetTopBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetConquestMapBoundaryOffsetTopArray() { return __p.__vector_as_array<float>(10); }
  public float ConquestMapBoundaryOffsetBottom(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapBoundaryOffsetBottomLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapBoundaryOffsetBottomBytes() { return __p.__vector_as_span<float>(12, 4); }
#else
  public ArraySegment<byte>? GetConquestMapBoundaryOffsetBottomBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public float[] GetConquestMapBoundaryOffsetBottomArray() { return __p.__vector_as_array<float>(12); }
  public float ConquestMapCenterOffsetX(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapCenterOffsetXLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapCenterOffsetXBytes() { return __p.__vector_as_span<float>(14, 4); }
#else
  public ArraySegment<byte>? GetConquestMapCenterOffsetXBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public float[] GetConquestMapCenterOffsetXArray() { return __p.__vector_as_array<float>(14); }
  public float ConquestMapCenterOffsetY(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ConquestMapCenterOffsetYLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetConquestMapCenterOffsetYBytes() { return __p.__vector_as_span<float>(16, 4); }
#else
  public ArraySegment<byte>? GetConquestMapCenterOffsetYBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public float[] GetConquestMapCenterOffsetYArray() { return __p.__vector_as_array<float>(16); }
  public float CameraAngle { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMax { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMin { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomDefault { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataGlobal.ConquestCameraSettingExcel> CreateConquestCameraSettingExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset ConquestMapBoundaryOffsetLeftOffset = default(VectorOffset),
      VectorOffset ConquestMapBoundaryOffsetRightOffset = default(VectorOffset),
      VectorOffset ConquestMapBoundaryOffsetTopOffset = default(VectorOffset),
      VectorOffset ConquestMapBoundaryOffsetBottomOffset = default(VectorOffset),
      VectorOffset ConquestMapCenterOffsetXOffset = default(VectorOffset),
      VectorOffset ConquestMapCenterOffsetYOffset = default(VectorOffset),
      float CameraAngle = 0.0f,
      float CameraZoomMax = 0.0f,
      float CameraZoomMin = 0.0f,
      float CameraZoomDefault = 0.0f) {
    builder.StartTable(11);
    ConquestCameraSettingExcel.AddId(builder, Id);
    ConquestCameraSettingExcel.AddCameraZoomDefault(builder, CameraZoomDefault);
    ConquestCameraSettingExcel.AddCameraZoomMin(builder, CameraZoomMin);
    ConquestCameraSettingExcel.AddCameraZoomMax(builder, CameraZoomMax);
    ConquestCameraSettingExcel.AddCameraAngle(builder, CameraAngle);
    ConquestCameraSettingExcel.AddConquestMapCenterOffsetY(builder, ConquestMapCenterOffsetYOffset);
    ConquestCameraSettingExcel.AddConquestMapCenterOffsetX(builder, ConquestMapCenterOffsetXOffset);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetBottom(builder, ConquestMapBoundaryOffsetBottomOffset);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetTop(builder, ConquestMapBoundaryOffsetTopOffset);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetRight(builder, ConquestMapBoundaryOffsetRightOffset);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetLeft(builder, ConquestMapBoundaryOffsetLeftOffset);
    return ConquestCameraSettingExcel.EndConquestCameraSettingExcel(builder);
  }

  public static void StartConquestCameraSettingExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddConquestMapBoundaryOffsetLeft(FlatBufferBuilder builder, VectorOffset ConquestMapBoundaryOffsetLeftOffset) { builder.AddOffset(1, ConquestMapBoundaryOffsetLeftOffset.Value, 0); }
  public static VectorOffset CreateConquestMapBoundaryOffsetLeftVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetLeftVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetLeftVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetLeftVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapBoundaryOffsetLeftVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConquestMapBoundaryOffsetRight(FlatBufferBuilder builder, VectorOffset ConquestMapBoundaryOffsetRightOffset) { builder.AddOffset(2, ConquestMapBoundaryOffsetRightOffset.Value, 0); }
  public static VectorOffset CreateConquestMapBoundaryOffsetRightVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetRightVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetRightVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetRightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapBoundaryOffsetRightVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConquestMapBoundaryOffsetTop(FlatBufferBuilder builder, VectorOffset ConquestMapBoundaryOffsetTopOffset) { builder.AddOffset(3, ConquestMapBoundaryOffsetTopOffset.Value, 0); }
  public static VectorOffset CreateConquestMapBoundaryOffsetTopVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetTopVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetTopVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetTopVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapBoundaryOffsetTopVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConquestMapBoundaryOffsetBottom(FlatBufferBuilder builder, VectorOffset ConquestMapBoundaryOffsetBottomOffset) { builder.AddOffset(4, ConquestMapBoundaryOffsetBottomOffset.Value, 0); }
  public static VectorOffset CreateConquestMapBoundaryOffsetBottomVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetBottomVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetBottomVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapBoundaryOffsetBottomVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapBoundaryOffsetBottomVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConquestMapCenterOffsetX(FlatBufferBuilder builder, VectorOffset ConquestMapCenterOffsetXOffset) { builder.AddOffset(5, ConquestMapCenterOffsetXOffset.Value, 0); }
  public static VectorOffset CreateConquestMapCenterOffsetXVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetXVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetXVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetXVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapCenterOffsetXVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConquestMapCenterOffsetY(FlatBufferBuilder builder, VectorOffset ConquestMapCenterOffsetYOffset) { builder.AddOffset(6, ConquestMapCenterOffsetYOffset.Value, 0); }
  public static VectorOffset CreateConquestMapCenterOffsetYVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetYVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetYVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConquestMapCenterOffsetYVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConquestMapCenterOffsetYVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCameraAngle(FlatBufferBuilder builder, float CameraAngle) { builder.AddFloat(7, CameraAngle, 0.0f); }
  public static void AddCameraZoomMax(FlatBufferBuilder builder, float CameraZoomMax) { builder.AddFloat(8, CameraZoomMax, 0.0f); }
  public static void AddCameraZoomMin(FlatBufferBuilder builder, float CameraZoomMin) { builder.AddFloat(9, CameraZoomMin, 0.0f); }
  public static void AddCameraZoomDefault(FlatBufferBuilder builder, float CameraZoomDefault) { builder.AddFloat(10, CameraZoomDefault, 0.0f); }
  public static Offset<FlatDataGlobal.ConquestCameraSettingExcel> EndConquestCameraSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConquestCameraSettingExcel>(o);
  }
}


}
