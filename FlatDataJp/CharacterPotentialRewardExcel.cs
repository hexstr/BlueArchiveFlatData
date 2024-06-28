// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterPotentialRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterPotentialRewardExcel GetRootAsCharacterPotentialRewardExcel(ByteBuffer _bb) { return GetRootAsCharacterPotentialRewardExcel(_bb, new CharacterPotentialRewardExcel()); }
  public static CharacterPotentialRewardExcel GetRootAsCharacterPotentialRewardExcel(ByteBuffer _bb, CharacterPotentialRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterPotentialRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.PotentialStatBonusRateType RequirePotentialStatType(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.PotentialStatBonusRateType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.PotentialStatBonusRateType)0; }
  public int RequirePotentialStatTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.PotentialStatBonusRateType> GetRequirePotentialStatTypeBytes() { return __p.__vector_as_span<FlatDataJp.PotentialStatBonusRateType>(6, 4); }
#else
  public ArraySegment<byte>? GetRequirePotentialStatTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatDataJp.PotentialStatBonusRateType[] GetRequirePotentialStatTypeArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.PotentialStatBonusRateType[] a = new FlatDataJp.PotentialStatBonusRateType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.PotentialStatBonusRateType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RequirePotentialStatLevel(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RequirePotentialStatLevelLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRequirePotentialStatLevelBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetRequirePotentialStatLevelBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetRequirePotentialStatLevelArray() { return __p.__vector_as_array<long>(8); }
  public FlatDataJp.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long RewardId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RewardAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.CharacterPotentialRewardExcel> CreateCharacterPotentialRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset RequirePotentialStatTypeOffset = default(VectorOffset),
      VectorOffset RequirePotentialStatLevelOffset = default(VectorOffset),
      FlatDataJp.ParcelType RewardParcelType = FlatDataJp.ParcelType.None,
      long RewardId = 0,
      int RewardAmount = 0) {
    builder.StartTable(6);
    CharacterPotentialRewardExcel.AddRewardId(builder, RewardId);
    CharacterPotentialRewardExcel.AddId(builder, Id);
    CharacterPotentialRewardExcel.AddRewardAmount(builder, RewardAmount);
    CharacterPotentialRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    CharacterPotentialRewardExcel.AddRequirePotentialStatLevel(builder, RequirePotentialStatLevelOffset);
    CharacterPotentialRewardExcel.AddRequirePotentialStatType(builder, RequirePotentialStatTypeOffset);
    return CharacterPotentialRewardExcel.EndCharacterPotentialRewardExcel(builder);
  }

  public static void StartCharacterPotentialRewardExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddRequirePotentialStatType(FlatBufferBuilder builder, VectorOffset RequirePotentialStatTypeOffset) { builder.AddOffset(1, RequirePotentialStatTypeOffset.Value, 0); }
  public static VectorOffset CreateRequirePotentialStatTypeVector(FlatBufferBuilder builder, FlatDataJp.PotentialStatBonusRateType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.PotentialStatBonusRateType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.PotentialStatBonusRateType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.PotentialStatBonusRateType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRequirePotentialStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRequirePotentialStatLevel(FlatBufferBuilder builder, VectorOffset RequirePotentialStatLevelOffset) { builder.AddOffset(2, RequirePotentialStatLevelOffset.Value, 0); }
  public static VectorOffset CreateRequirePotentialStatLevelVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatLevelVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequirePotentialStatLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRequirePotentialStatLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType RewardParcelType) { builder.AddInt(3, (int)RewardParcelType, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, long RewardId) { builder.AddLong(4, RewardId, 0); }
  public static void AddRewardAmount(FlatBufferBuilder builder, int RewardAmount) { builder.AddInt(5, RewardAmount, 0); }
  public static Offset<FlatDataJp.CharacterPotentialRewardExcel> EndCharacterPotentialRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterPotentialRewardExcel>(o);
  }
}


}
