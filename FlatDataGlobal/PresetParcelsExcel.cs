// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PresetParcelsExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static PresetParcelsExcel GetRootAsPresetParcelsExcel(ByteBuffer _bb) { return GetRootAsPresetParcelsExcel(_bb, new PresetParcelsExcel()); }
  public static PresetParcelsExcel GetRootAsPresetParcelsExcel(ByteBuffer _bb, PresetParcelsExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PresetParcelsExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.ParcelType ParcelType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PresetGroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ParcelAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.PresetParcelsExcel> CreatePresetParcelsExcel(FlatBufferBuilder builder,
      FlatDataGlobal.ParcelType parcelType = FlatDataGlobal.ParcelType.None,
      long ParcelId = 0,
      long PresetGroupId = 0,
      long ParcelAmount = 0) {
    builder.StartTable(4);
    PresetParcelsExcel.AddParcelAmount(builder, ParcelAmount);
    PresetParcelsExcel.AddPresetGroupId(builder, PresetGroupId);
    PresetParcelsExcel.AddParcelId(builder, ParcelId);
    PresetParcelsExcel.AddParcelType(builder, parcelType);
    return PresetParcelsExcel.EndPresetParcelsExcel(builder);
  }

  public static void StartPresetParcelsExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType parcelType) { builder.AddInt(0, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long ParcelId) { builder.AddLong(1, ParcelId, 0); }
  public static void AddPresetGroupId(FlatBufferBuilder builder, long PresetGroupId) { builder.AddLong(2, PresetGroupId, 0); }
  public static void AddParcelAmount(FlatBufferBuilder builder, long ParcelAmount) { builder.AddLong(3, ParcelAmount, 0); }
  public static Offset<FlatDataGlobal.PresetParcelsExcel> EndPresetParcelsExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.PresetParcelsExcel>(o);
  }
}


}
