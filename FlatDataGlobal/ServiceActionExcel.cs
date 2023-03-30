// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ServiceActionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ServiceActionExcel GetRootAsServiceActionExcel(ByteBuffer _bb) { return GetRootAsServiceActionExcel(_bb, new ServiceActionExcel()); }
  public static ServiceActionExcel GetRootAsServiceActionExcel(ByteBuffer _bb, ServiceActionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ServiceActionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.ServiceActionType Serviceactiontype { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.ServiceActionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ServiceActionType.ClanCreate; } }
  public bool IsLegacy { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GoodsId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.ServiceActionExcel> CreateServiceActionExcel(FlatBufferBuilder builder,
      FlatDataGlobal.ServiceActionType serviceactiontype = FlatDataGlobal.ServiceActionType.ClanCreate,
      bool IsLegacy = false,
      long GoodsId = 0) {
    builder.StartTable(3);
    ServiceActionExcel.AddGoodsId(builder, GoodsId);
    ServiceActionExcel.AddServiceactiontype(builder, serviceactiontype);
    ServiceActionExcel.AddIsLegacy(builder, IsLegacy);
    return ServiceActionExcel.EndServiceActionExcel(builder);
  }

  public static void StartServiceActionExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddServiceactiontype(FlatBufferBuilder builder, FlatDataGlobal.ServiceActionType serviceactiontype) { builder.AddInt(0, (int)serviceactiontype, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool IsLegacy) { builder.AddBool(1, IsLegacy, false); }
  public static void AddGoodsId(FlatBufferBuilder builder, long GoodsId) { builder.AddLong(2, GoodsId, 0); }
  public static Offset<FlatDataGlobal.ServiceActionExcel> EndServiceActionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ServiceActionExcel>(o);
  }
}


}
