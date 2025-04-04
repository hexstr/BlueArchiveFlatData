// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterGearExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterGearExcel GetRootAsCharacterGearExcel(ByteBuffer _bb) { return GetRootAsCharacterGearExcel(_bb, new CharacterGearExcel()); }
  public static CharacterGearExcel GetRootAsCharacterGearExcel(ByteBuffer _bb, CharacterGearExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterGearExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StatLevelUpType.Standard; } }
  public long Tier { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextTierEquipment { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenFavorLevel { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LearnSkillSlot { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLearnSkillSlotBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetLearnSkillSlotBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetLearnSkillSlotArray() { return __p.__vector_as_array<byte>(20); }
  public FlatDataGlobal.EquipmentOptionType StatType(int j) { int o = __p.__offset(22); return o != 0 ? (FlatDataGlobal.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.EquipmentOptionType>(22, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public FlatDataGlobal.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.EquipmentOptionType[] a = new FlatDataGlobal.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MinStatValue(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MinStatValueLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMinStatValueBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetMinStatValueBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetMinStatValueArray() { return __p.__vector_as_array<long>(24); }
  public long MaxStatValue(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MaxStatValueLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMaxStatValueBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetMaxStatValueBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetMaxStatValueArray() { return __p.__vector_as_array<long>(26); }
  public string Icon { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(28); }
  public uint LocalizeEtcId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataGlobal.Tag Tags(int j) { int o = __p.__offset(32); return o != 0 ? (FlatDataGlobal.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.Tag> GetTagsBytes() { return __p.__vector_as_span<FlatDataGlobal.Tag>(32, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public FlatDataGlobal.Tag[] GetTagsArray() { int o = __p.__offset(32); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.Tag[] a = new FlatDataGlobal.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.Tag)__p.bb.GetInt(p + i * 4); } return a; }

  public static Offset<FlatDataGlobal.CharacterGearExcel> CreateCharacterGearExcel(FlatBufferBuilder builder,
      long Id = 0,
      long CharacterId = 0,
      FlatDataGlobal.StatLevelUpType statLevelUpType = FlatDataGlobal.StatLevelUpType.Standard,
      long Tier = 0,
      long NextTierEquipment = 0,
      long RecipeId = 0,
      long OpenFavorLevel = 0,
      long MaxLevel = 0,
      StringOffset LearnSkillSlotOffset = default(StringOffset),
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset MinStatValueOffset = default(VectorOffset),
      VectorOffset MaxStatValueOffset = default(VectorOffset),
      StringOffset IconOffset = default(StringOffset),
      uint LocalizeEtcId = 0,
      VectorOffset TagsOffset = default(VectorOffset)) {
    builder.StartTable(15);
    CharacterGearExcel.AddMaxLevel(builder, MaxLevel);
    CharacterGearExcel.AddOpenFavorLevel(builder, OpenFavorLevel);
    CharacterGearExcel.AddRecipeId(builder, RecipeId);
    CharacterGearExcel.AddNextTierEquipment(builder, NextTierEquipment);
    CharacterGearExcel.AddTier(builder, Tier);
    CharacterGearExcel.AddCharacterId(builder, CharacterId);
    CharacterGearExcel.AddId(builder, Id);
    CharacterGearExcel.AddTags(builder, TagsOffset);
    CharacterGearExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    CharacterGearExcel.AddIcon(builder, IconOffset);
    CharacterGearExcel.AddMaxStatValue(builder, MaxStatValueOffset);
    CharacterGearExcel.AddMinStatValue(builder, MinStatValueOffset);
    CharacterGearExcel.AddStatType(builder, StatTypeOffset);
    CharacterGearExcel.AddLearnSkillSlot(builder, LearnSkillSlotOffset);
    CharacterGearExcel.AddStatLevelUpType(builder, statLevelUpType);
    return CharacterGearExcel.EndCharacterGearExcel(builder);
  }

  public static void StartCharacterGearExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(1, CharacterId, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, FlatDataGlobal.StatLevelUpType statLevelUpType) { builder.AddInt(2, (int)statLevelUpType, 0); }
  public static void AddTier(FlatBufferBuilder builder, long Tier) { builder.AddLong(3, Tier, 0); }
  public static void AddNextTierEquipment(FlatBufferBuilder builder, long NextTierEquipment) { builder.AddLong(4, NextTierEquipment, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, long RecipeId) { builder.AddLong(5, RecipeId, 0); }
  public static void AddOpenFavorLevel(FlatBufferBuilder builder, long OpenFavorLevel) { builder.AddLong(6, OpenFavorLevel, 0); }
  public static void AddMaxLevel(FlatBufferBuilder builder, long MaxLevel) { builder.AddLong(7, MaxLevel, 0); }
  public static void AddLearnSkillSlot(FlatBufferBuilder builder, StringOffset LearnSkillSlotOffset) { builder.AddOffset(8, LearnSkillSlotOffset.Value, 0); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset StatTypeOffset) { builder.AddOffset(9, StatTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, FlatDataGlobal.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinStatValue(FlatBufferBuilder builder, VectorOffset MinStatValueOffset) { builder.AddOffset(10, MinStatValueOffset.Value, 0); }
  public static VectorOffset CreateMinStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMinStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxStatValue(FlatBufferBuilder builder, VectorOffset MaxStatValueOffset) { builder.AddOffset(11, MaxStatValueOffset.Value, 0); }
  public static VectorOffset CreateMaxStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(12, IconOffset.Value, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint LocalizeEtcId) { builder.AddUint(13, LocalizeEtcId, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset TagsOffset) { builder.AddOffset(14, TagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.CharacterGearExcel> EndCharacterGearExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterGearExcel>(o);
  }
}


}
