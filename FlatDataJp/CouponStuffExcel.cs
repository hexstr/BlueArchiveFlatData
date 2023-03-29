// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CouponStuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CouponStuffExcel GetRootAsCouponStuffExcel(ByteBuffer _bb) { return GetRootAsCouponStuffExcel(_bb, new CouponStuffExcel()); }
  public static CouponStuffExcel GetRootAsCouponStuffExcel(ByteBuffer _bb, CouponStuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CouponStuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType ParcelType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int LimitAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string CouponStuffNameLocalizeKey { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCouponStuffNameLocalizeKeyBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetCouponStuffNameLocalizeKeyBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetCouponStuffNameLocalizeKeyArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataJp.CouponStuffExcel> CreateCouponStuffExcel(FlatBufferBuilder builder,
      long StuffId = 0,
      FlatDataJp.ParcelType ParcelType = FlatDataJp.ParcelType.None,
      long ParcelId = 0,
      int LimitAmount = 0,
      StringOffset CouponStuffNameLocalizeKeyOffset = default(StringOffset)) {
    builder.StartTable(5);
    CouponStuffExcel.AddParcelId(builder, ParcelId);
    CouponStuffExcel.AddStuffId(builder, StuffId);
    CouponStuffExcel.AddCouponStuffNameLocalizeKey(builder, CouponStuffNameLocalizeKeyOffset);
    CouponStuffExcel.AddLimitAmount(builder, LimitAmount);
    CouponStuffExcel.AddParcelType(builder, ParcelType);
    return CouponStuffExcel.EndCouponStuffExcel(builder);
  }

  public static void StartCouponStuffExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddStuffId(FlatBufferBuilder builder, long StuffId) { builder.AddLong(0, StuffId, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType ParcelType) { builder.AddInt(1, (int)ParcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long ParcelId) { builder.AddLong(2, ParcelId, 0); }
  public static void AddLimitAmount(FlatBufferBuilder builder, int LimitAmount) { builder.AddInt(3, LimitAmount, 0); }
  public static void AddCouponStuffNameLocalizeKey(FlatBufferBuilder builder, StringOffset CouponStuffNameLocalizeKeyOffset) { builder.AddOffset(4, CouponStuffNameLocalizeKeyOffset.Value, 0); }
  public static Offset<FlatDataJp.CouponStuffExcel> EndCouponStuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CouponStuffExcel>(o);
  }
}


}
