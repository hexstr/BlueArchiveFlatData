// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EquipmentStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EquipmentStatExcel GetRootAsEquipmentStatExcel(ByteBuffer _bb) { return GetRootAsEquipmentStatExcel(_bb, new EquipmentStatExcel()); }
  public static EquipmentStatExcel GetRootAsEquipmentStatExcel(ByteBuffer _bb, EquipmentStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EquipmentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.StatLevelUpType.Standard; } }
  public FlatDataJp.EquipmentOptionType StatType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<FlatDataJp.EquipmentOptionType>(8, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatDataJp.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.EquipmentOptionType[] a = new FlatDataJp.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MinStat(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MinStatLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMinStatBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetMinStatBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetMinStatArray() { return __p.__vector_as_array<long>(10); }
  public long MaxStat(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MaxStatLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMaxStatBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetMaxStatBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetMaxStatArray() { return __p.__vector_as_array<long>(12); }
  public int LevelUpInsertLimit { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long LevelUpFeedExp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.CurrencyTypes LevelUpFeedCostCurrency { get { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CurrencyTypes.Invalid; } }
  public long LevelUpFeedCostAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EquipmentCategory EquipmentCategory { get { int o = __p.__offset(22); return o != 0 ? (FlatDataJp.EquipmentCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EquipmentCategory.Unable; } }
  public long LevelUpFeedAddExp { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int DefaultMaxLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TranscendenceMax { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string DamageFactorGroupId { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDamageFactorGroupIdBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetDamageFactorGroupIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetDamageFactorGroupIdArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<FlatDataJp.EquipmentStatExcel> CreateEquipmentStatExcel(FlatBufferBuilder builder,
      long EquipmentId = 0,
      FlatDataJp.StatLevelUpType statLevelUpType = FlatDataJp.StatLevelUpType.Standard,
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset MinStatOffset = default(VectorOffset),
      VectorOffset MaxStatOffset = default(VectorOffset),
      int LevelUpInsertLimit = 0,
      long LevelUpFeedExp = 0,
      FlatDataJp.CurrencyTypes LevelUpFeedCostCurrency = FlatDataJp.CurrencyTypes.Invalid,
      long LevelUpFeedCostAmount = 0,
      FlatDataJp.EquipmentCategory equipmentCategory = FlatDataJp.EquipmentCategory.Unable,
      long LevelUpFeedAddExp = 0,
      int DefaultMaxLevel = 0,
      int TranscendenceMax = 0,
      StringOffset DamageFactorGroupIdOffset = default(StringOffset)) {
    builder.StartTable(14);
    EquipmentStatExcel.AddLevelUpFeedAddExp(builder, LevelUpFeedAddExp);
    EquipmentStatExcel.AddLevelUpFeedCostAmount(builder, LevelUpFeedCostAmount);
    EquipmentStatExcel.AddLevelUpFeedExp(builder, LevelUpFeedExp);
    EquipmentStatExcel.AddEquipmentId(builder, EquipmentId);
    EquipmentStatExcel.AddDamageFactorGroupId(builder, DamageFactorGroupIdOffset);
    EquipmentStatExcel.AddTranscendenceMax(builder, TranscendenceMax);
    EquipmentStatExcel.AddDefaultMaxLevel(builder, DefaultMaxLevel);
    EquipmentStatExcel.AddEquipmentCategory(builder, equipmentCategory);
    EquipmentStatExcel.AddLevelUpFeedCostCurrency(builder, LevelUpFeedCostCurrency);
    EquipmentStatExcel.AddLevelUpInsertLimit(builder, LevelUpInsertLimit);
    EquipmentStatExcel.AddMaxStat(builder, MaxStatOffset);
    EquipmentStatExcel.AddMinStat(builder, MinStatOffset);
    EquipmentStatExcel.AddStatType(builder, StatTypeOffset);
    EquipmentStatExcel.AddStatLevelUpType(builder, statLevelUpType);
    return EquipmentStatExcel.EndEquipmentStatExcel(builder);
  }

  public static void StartEquipmentStatExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEquipmentId(FlatBufferBuilder builder, long EquipmentId) { builder.AddLong(0, EquipmentId, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, FlatDataJp.StatLevelUpType statLevelUpType) { builder.AddInt(1, (int)statLevelUpType, 0); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset StatTypeOffset) { builder.AddOffset(2, StatTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, FlatDataJp.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinStat(FlatBufferBuilder builder, VectorOffset MinStatOffset) { builder.AddOffset(3, MinStatOffset.Value, 0); }
  public static VectorOffset CreateMinStatVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMinStatVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxStat(FlatBufferBuilder builder, VectorOffset MaxStatOffset) { builder.AddOffset(4, MaxStatOffset.Value, 0); }
  public static VectorOffset CreateMaxStatVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxStatVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddLevelUpInsertLimit(FlatBufferBuilder builder, int LevelUpInsertLimit) { builder.AddInt(5, LevelUpInsertLimit, 0); }
  public static void AddLevelUpFeedExp(FlatBufferBuilder builder, long LevelUpFeedExp) { builder.AddLong(6, LevelUpFeedExp, 0); }
  public static void AddLevelUpFeedCostCurrency(FlatBufferBuilder builder, FlatDataJp.CurrencyTypes LevelUpFeedCostCurrency) { builder.AddInt(7, (int)LevelUpFeedCostCurrency, 0); }
  public static void AddLevelUpFeedCostAmount(FlatBufferBuilder builder, long LevelUpFeedCostAmount) { builder.AddLong(8, LevelUpFeedCostAmount, 0); }
  public static void AddEquipmentCategory(FlatBufferBuilder builder, FlatDataJp.EquipmentCategory equipmentCategory) { builder.AddInt(9, (int)equipmentCategory, 0); }
  public static void AddLevelUpFeedAddExp(FlatBufferBuilder builder, long LevelUpFeedAddExp) { builder.AddLong(10, LevelUpFeedAddExp, 0); }
  public static void AddDefaultMaxLevel(FlatBufferBuilder builder, int DefaultMaxLevel) { builder.AddInt(11, DefaultMaxLevel, 0); }
  public static void AddTranscendenceMax(FlatBufferBuilder builder, int TranscendenceMax) { builder.AddInt(12, TranscendenceMax, 0); }
  public static void AddDamageFactorGroupId(FlatBufferBuilder builder, StringOffset DamageFactorGroupIdOffset) { builder.AddOffset(13, DamageFactorGroupIdOffset.Value, 0); }
  public static Offset<FlatDataJp.EquipmentStatExcel> EndEquipmentStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EquipmentStatExcel>(o);
  }
}


}
