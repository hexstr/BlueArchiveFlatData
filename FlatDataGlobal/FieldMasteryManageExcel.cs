// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldMasteryManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FieldMasteryManageExcel GetRootAsFieldMasteryManageExcel(ByteBuffer _bb) { return GetRootAsFieldMasteryManageExcel(_bb, new FieldMasteryManageExcel()); }
  public static FieldMasteryManageExcel GetRootAsFieldMasteryManageExcel(ByteBuffer _bb, FieldMasteryManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldMasteryManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FieldSeason { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtc { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string ImagePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(8); }
  public long LevelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.FieldMasteryManageExcel> CreateFieldMasteryManageExcel(FlatBufferBuilder builder,
      long FieldSeason = 0,
      uint LocalizeEtc = 0,
      StringOffset ImagePathOffset = default(StringOffset),
      long LevelId = 0) {
    builder.StartTable(4);
    FieldMasteryManageExcel.AddLevelId(builder, LevelId);
    FieldMasteryManageExcel.AddFieldSeason(builder, FieldSeason);
    FieldMasteryManageExcel.AddImagePath(builder, ImagePathOffset);
    FieldMasteryManageExcel.AddLocalizeEtc(builder, LocalizeEtc);
    return FieldMasteryManageExcel.EndFieldMasteryManageExcel(builder);
  }

  public static void StartFieldMasteryManageExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddFieldSeason(FlatBufferBuilder builder, long FieldSeason) { builder.AddLong(0, FieldSeason, 0); }
  public static void AddLocalizeEtc(FlatBufferBuilder builder, uint LocalizeEtc) { builder.AddUint(1, LocalizeEtc, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset ImagePathOffset) { builder.AddOffset(2, ImagePathOffset.Value, 0); }
  public static void AddLevelId(FlatBufferBuilder builder, long LevelId) { builder.AddLong(3, LevelId, 0); }
  public static Offset<FlatDataGlobal.FieldMasteryManageExcel> EndFieldMasteryManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.FieldMasteryManageExcel>(o);
  }
}


}
