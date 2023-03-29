// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaElementRecursiveExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static GachaElementRecursiveExcel GetRootAsGachaElementRecursiveExcel(ByteBuffer _bb) { return GetRootAsGachaElementRecursiveExcel(_bb, new GachaElementRecursiveExcel()); }
  public static GachaElementRecursiveExcel GetRootAsGachaElementRecursiveExcel(ByteBuffer _bb, GachaElementRecursiveExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaElementRecursiveExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GachaGroupID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType ParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long ParcelID { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ParcelAmountMin { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ParcelAmountMax { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int State { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.GachaElementRecursiveExcel> CreateGachaElementRecursiveExcel(FlatBufferBuilder builder,
      long ID = 0,
      long GachaGroupID = 0,
      FlatDataGlobal.ParcelType ParcelType = FlatDataGlobal.ParcelType.None,
      long ParcelID = 0,
      int ParcelAmountMin = 0,
      int ParcelAmountMax = 0,
      int Prob = 0,
      int State = 0) {
    builder.StartTable(8);
    GachaElementRecursiveExcel.AddParcelID(builder, ParcelID);
    GachaElementRecursiveExcel.AddGachaGroupID(builder, GachaGroupID);
    GachaElementRecursiveExcel.AddID(builder, ID);
    GachaElementRecursiveExcel.AddState(builder, State);
    GachaElementRecursiveExcel.AddProb(builder, Prob);
    GachaElementRecursiveExcel.AddParcelAmountMax(builder, ParcelAmountMax);
    GachaElementRecursiveExcel.AddParcelAmountMin(builder, ParcelAmountMin);
    GachaElementRecursiveExcel.AddParcelType(builder, ParcelType);
    return GachaElementRecursiveExcel.EndGachaElementRecursiveExcel(builder);
  }

  public static void StartGachaElementRecursiveExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddID(FlatBufferBuilder builder, long ID) { builder.AddLong(0, ID, 0); }
  public static void AddGachaGroupID(FlatBufferBuilder builder, long GachaGroupID) { builder.AddLong(1, GachaGroupID, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType ParcelType) { builder.AddInt(2, (int)ParcelType, 0); }
  public static void AddParcelID(FlatBufferBuilder builder, long ParcelID) { builder.AddLong(3, ParcelID, 0); }
  public static void AddParcelAmountMin(FlatBufferBuilder builder, int ParcelAmountMin) { builder.AddInt(4, ParcelAmountMin, 0); }
  public static void AddParcelAmountMax(FlatBufferBuilder builder, int ParcelAmountMax) { builder.AddInt(5, ParcelAmountMax, 0); }
  public static void AddProb(FlatBufferBuilder builder, int Prob) { builder.AddInt(6, Prob, 0); }
  public static void AddState(FlatBufferBuilder builder, int State) { builder.AddInt(7, State, 0); }
  public static Offset<FlatDataGlobal.GachaElementRecursiveExcel> EndGachaElementRecursiveExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.GachaElementRecursiveExcel>(o);
  }
}


}
