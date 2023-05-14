// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CurrencyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CurrencyExcel GetRootAsCurrencyExcel(ByteBuffer _bb) { return GetRootAsCurrencyExcel(_bb, new CurrencyExcel()); }
  public static CurrencyExcel GetRootAsCurrencyExcel(ByteBuffer _bb, CurrencyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CurrencyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.CurrencyTypes CurrencyType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CurrencyTypes.Invalid; } }
  public string CurrencyName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCurrencyNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetCurrencyNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetCurrencyNameArray() { return __p.__vector_as_array<byte>(10); }
  public string Icon { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(12); }
  public FlatDataJp.Rarity Rarity { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Rarity.N; } }
  public int AutoChargeMsc { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AutoChargeAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.CurrencyOverChargeType Currencyoverchargetype { get { int o = __p.__offset(20); return o != 0 ? (FlatDataJp.CurrencyOverChargeType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CurrencyOverChargeType.CanNotCharge; } }
  public FlatDataJp.CurrencyAdditionalChargeType Currencyadditionalchargetype { get { int o = __p.__offset(22); return o != 0 ? (FlatDataJp.CurrencyAdditionalChargeType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CurrencyAdditionalChargeType.EnableAutoChargeOverLimit; } }
  public long ChargeLimit { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OverChargeLimit { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SpriteName { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpriteNameBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetSpriteNameBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetSpriteNameArray() { return __p.__vector_as_array<byte>(28); }
  public long DailyRefillAmount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DailyRefillTime(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int DailyRefillTimeLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetDailyRefillTimeBytes() { return __p.__vector_as_span<long>(32, 8); }
#else
  public ArraySegment<byte>? GetDailyRefillTimeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public long[] GetDailyRefillTimeArray() { return __p.__vector_as_array<long>(32); }

  public static Offset<FlatDataJp.CurrencyExcel> CreateCurrencyExcel(FlatBufferBuilder builder,
      long ID = 0,
      uint LocalizeEtcId = 0,
      FlatDataJp.CurrencyTypes CurrencyType = FlatDataJp.CurrencyTypes.Invalid,
      StringOffset CurrencyNameOffset = default(StringOffset),
      StringOffset IconOffset = default(StringOffset),
      FlatDataJp.Rarity rarity = FlatDataJp.Rarity.N,
      int AutoChargeMsc = 0,
      int AutoChargeAmount = 0,
      FlatDataJp.CurrencyOverChargeType currencyoverchargetype = FlatDataJp.CurrencyOverChargeType.CanNotCharge,
      FlatDataJp.CurrencyAdditionalChargeType currencyadditionalchargetype = FlatDataJp.CurrencyAdditionalChargeType.EnableAutoChargeOverLimit,
      long ChargeLimit = 0,
      long OverChargeLimit = 0,
      StringOffset SpriteNameOffset = default(StringOffset),
      long DailyRefillAmount = 0,
      VectorOffset DailyRefillTimeOffset = default(VectorOffset)) {
    builder.StartTable(15);
    CurrencyExcel.AddDailyRefillAmount(builder, DailyRefillAmount);
    CurrencyExcel.AddOverChargeLimit(builder, OverChargeLimit);
    CurrencyExcel.AddChargeLimit(builder, ChargeLimit);
    CurrencyExcel.AddID(builder, ID);
    CurrencyExcel.AddDailyRefillTime(builder, DailyRefillTimeOffset);
    CurrencyExcel.AddSpriteName(builder, SpriteNameOffset);
    CurrencyExcel.AddCurrencyadditionalchargetype(builder, currencyadditionalchargetype);
    CurrencyExcel.AddCurrencyoverchargetype(builder, currencyoverchargetype);
    CurrencyExcel.AddAutoChargeAmount(builder, AutoChargeAmount);
    CurrencyExcel.AddAutoChargeMsc(builder, AutoChargeMsc);
    CurrencyExcel.AddRarity(builder, rarity);
    CurrencyExcel.AddIcon(builder, IconOffset);
    CurrencyExcel.AddCurrencyName(builder, CurrencyNameOffset);
    CurrencyExcel.AddCurrencyType(builder, CurrencyType);
    CurrencyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    return CurrencyExcel.EndCurrencyExcel(builder);
  }

  public static void StartCurrencyExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddID(FlatBufferBuilder builder, long ID) { builder.AddLong(0, ID, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(1, LocalizeEtcId, 0); }
  public static void AddCurrencyType(FlatBufferBuilder builder, FlatDataJp.CurrencyTypes CurrencyType) { builder.AddInt(2, (int)CurrencyType, 0); }
  public static void AddCurrencyName(FlatBufferBuilder builder, StringOffset CurrencyNameOffset) { builder.AddOffset(3, CurrencyNameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(4, IconOffset.Value, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatDataJp.Rarity rarity) { builder.AddInt(5, (int)rarity, 0); }
  public static void AddAutoChargeMsc(FlatBufferBuilder builder, int AutoChargeMsc) { builder.AddInt(6, AutoChargeMsc, 0); }
  public static void AddAutoChargeAmount(FlatBufferBuilder builder, int AutoChargeAmount) { builder.AddInt(7, AutoChargeAmount, 0); }
  public static void AddCurrencyoverchargetype(FlatBufferBuilder builder, FlatDataJp.CurrencyOverChargeType currencyoverchargetype) { builder.AddInt(8, (int)currencyoverchargetype, 0); }
  public static void AddCurrencyadditionalchargetype(FlatBufferBuilder builder, FlatDataJp.CurrencyAdditionalChargeType currencyadditionalchargetype) { builder.AddInt(9, (int)currencyadditionalchargetype, 0); }
  public static void AddChargeLimit(FlatBufferBuilder builder, long ChargeLimit) { builder.AddLong(10, ChargeLimit, 0); }
  public static void AddOverChargeLimit(FlatBufferBuilder builder, long OverChargeLimit) { builder.AddLong(11, OverChargeLimit, 0); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset SpriteNameOffset) { builder.AddOffset(12, SpriteNameOffset.Value, 0); }
  public static void AddDailyRefillAmount(FlatBufferBuilder builder, long DailyRefillAmount) { builder.AddLong(13, DailyRefillAmount, 0); }
  public static void AddDailyRefillTime(FlatBufferBuilder builder, VectorOffset DailyRefillTimeOffset) { builder.AddOffset(14, DailyRefillTimeOffset.Value, 0); }
  public static VectorOffset CreateDailyRefillTimeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDailyRefillTimeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.CurrencyExcel> EndCurrencyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CurrencyExcel>(o);
  }
}


}
