// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DefaultParcelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DefaultParcelExcel GetRootAsDefaultParcelExcel(ByteBuffer _bb) { return GetRootAsDefaultParcelExcel(_bb, new DefaultParcelExcel()); }
  public static DefaultParcelExcel GetRootAsDefaultParcelExcel(ByteBuffer _bb, DefaultParcelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultParcelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.ParcelType ParcelType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ParcelAmount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.DefaultParcelExcel> CreateDefaultParcelExcel(FlatBufferBuilder builder,
      FlatDataJp.ParcelType parcelType = FlatDataJp.ParcelType.None,
      long ParcelId = 0,
      long ParcelAmount = 0) {
    builder.StartTable(3);
    DefaultParcelExcel.AddParcelAmount(builder, ParcelAmount);
    DefaultParcelExcel.AddParcelId(builder, ParcelId);
    DefaultParcelExcel.AddParcelType(builder, parcelType);
    return DefaultParcelExcel.EndDefaultParcelExcel(builder);
  }

  public static void StartDefaultParcelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType parcelType) { builder.AddInt(0, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long ParcelId) { builder.AddLong(1, ParcelId, 0); }
  public static void AddParcelAmount(FlatBufferBuilder builder, long ParcelAmount) { builder.AddLong(2, ParcelAmount, 0); }
  public static Offset<FlatDataJp.DefaultParcelExcel> EndDefaultParcelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.DefaultParcelExcel>(o);
  }
}


}
