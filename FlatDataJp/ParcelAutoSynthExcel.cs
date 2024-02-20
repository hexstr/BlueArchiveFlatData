// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ParcelAutoSynthExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ParcelAutoSynthExcel GetRootAsParcelAutoSynthExcel(ByteBuffer _bb) { return GetRootAsParcelAutoSynthExcel(_bb, new ParcelAutoSynthExcel()); }
  public static ParcelAutoSynthExcel GetRootAsParcelAutoSynthExcel(ByteBuffer _bb, ParcelAutoSynthExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParcelAutoSynthExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.ParcelType RequireParcelType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long RequireParcelId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RequireParcelAmount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SynthStartAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SynthEndAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool SynthMaxItem { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataJp.ParcelType ResultParcelType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ResultParcelId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ResultParcelAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ParcelAutoSynthExcel> CreateParcelAutoSynthExcel(FlatBufferBuilder builder,
      FlatDataJp.ParcelType RequireParcelType = FlatDataJp.ParcelType.None,
      long RequireParcelId = 0,
      long RequireParcelAmount = 0,
      long SynthStartAmount = 0,
      long SynthEndAmount = 0,
      bool SynthMaxItem = false,
      FlatDataJp.ParcelType ResultParcelType = FlatDataJp.ParcelType.None,
      long ResultParcelId = 0,
      long ResultParcelAmount = 0) {
    builder.StartTable(9);
    ParcelAutoSynthExcel.AddResultParcelAmount(builder, ResultParcelAmount);
    ParcelAutoSynthExcel.AddResultParcelId(builder, ResultParcelId);
    ParcelAutoSynthExcel.AddSynthEndAmount(builder, SynthEndAmount);
    ParcelAutoSynthExcel.AddSynthStartAmount(builder, SynthStartAmount);
    ParcelAutoSynthExcel.AddRequireParcelAmount(builder, RequireParcelAmount);
    ParcelAutoSynthExcel.AddRequireParcelId(builder, RequireParcelId);
    ParcelAutoSynthExcel.AddResultParcelType(builder, ResultParcelType);
    ParcelAutoSynthExcel.AddRequireParcelType(builder, RequireParcelType);
    ParcelAutoSynthExcel.AddSynthMaxItem(builder, SynthMaxItem);
    return ParcelAutoSynthExcel.EndParcelAutoSynthExcel(builder);
  }

  public static void StartParcelAutoSynthExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddRequireParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType RequireParcelType) { builder.AddInt(0, (int)RequireParcelType, 0); }
  public static void AddRequireParcelId(FlatBufferBuilder builder, long RequireParcelId) { builder.AddLong(1, RequireParcelId, 0); }
  public static void AddRequireParcelAmount(FlatBufferBuilder builder, long RequireParcelAmount) { builder.AddLong(2, RequireParcelAmount, 0); }
  public static void AddSynthStartAmount(FlatBufferBuilder builder, long SynthStartAmount) { builder.AddLong(3, SynthStartAmount, 0); }
  public static void AddSynthEndAmount(FlatBufferBuilder builder, long SynthEndAmount) { builder.AddLong(4, SynthEndAmount, 0); }
  public static void AddSynthMaxItem(FlatBufferBuilder builder, bool SynthMaxItem) { builder.AddBool(5, SynthMaxItem, false); }
  public static void AddResultParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType ResultParcelType) { builder.AddInt(6, (int)ResultParcelType, 0); }
  public static void AddResultParcelId(FlatBufferBuilder builder, long ResultParcelId) { builder.AddLong(7, ResultParcelId, 0); }
  public static void AddResultParcelAmount(FlatBufferBuilder builder, long ResultParcelAmount) { builder.AddLong(8, ResultParcelAmount, 0); }
  public static Offset<FlatDataJp.ParcelAutoSynthExcel> EndParcelAutoSynthExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ParcelAutoSynthExcel>(o);
  }
}


}
