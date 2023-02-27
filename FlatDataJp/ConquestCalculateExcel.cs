// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestCalculateExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConquestCalculateExcel GetRootAsConquestCalculateExcel(ByteBuffer _bb) { return GetRootAsConquestCalculateExcel(_bb, new ConquestCalculateExcel()); }
  public static ConquestCalculateExcel GetRootAsConquestCalculateExcel(ByteBuffer _bb, ConquestCalculateExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestCalculateExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType CalculateConditionParcelType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long CalculateConditionParcelUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CalculateConditionParcelAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ConquestCalculateExcel> CreateConquestCalculateExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataJp.ParcelType CalculateConditionParcelType = FlatDataJp.ParcelType.None,
      long CalculateConditionParcelUniqueId = 0,
      long CalculateConditionParcelAmount = 0) {
    builder.StartTable(4);
    ConquestCalculateExcel.AddCalculateConditionParcelAmount(builder, CalculateConditionParcelAmount);
    ConquestCalculateExcel.AddCalculateConditionParcelUniqueId(builder, CalculateConditionParcelUniqueId);
    ConquestCalculateExcel.AddEventContentId(builder, EventContentId);
    ConquestCalculateExcel.AddCalculateConditionParcelType(builder, CalculateConditionParcelType);
    return ConquestCalculateExcel.EndConquestCalculateExcel(builder);
  }

  public static void StartConquestCalculateExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddCalculateConditionParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType CalculateConditionParcelType) { builder.AddInt(1, (int)CalculateConditionParcelType, 0); }
  public static void AddCalculateConditionParcelUniqueId(FlatBufferBuilder builder, long CalculateConditionParcelUniqueId) { builder.AddLong(2, CalculateConditionParcelUniqueId, 0); }
  public static void AddCalculateConditionParcelAmount(FlatBufferBuilder builder, long CalculateConditionParcelAmount) { builder.AddLong(3, CalculateConditionParcelAmount, 0); }
  public static Offset<FlatDataJp.ConquestCalculateExcel> EndConquestCalculateExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConquestCalculateExcel>(o);
  }
}


}
