// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterWeaponExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterWeaponExcel GetRootAsCharacterWeaponExcel(ByteBuffer _bb) { return GetRootAsCharacterWeaponExcel(_bb, new CharacterWeaponExcel()); }
  public static CharacterWeaponExcel GetRootAsCharacterWeaponExcel(ByteBuffer _bb, CharacterWeaponExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterWeaponExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ImagePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(6); }
  public long SetRecipe { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StatLevelUpType.Standard; } }
  public long AttackPower { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower100 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP100 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower100 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Unlock(int j) { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int UnlockLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetUnlockBytes() { return __p.__vector_as_span<bool>(24, 1); }
#else
  public ArraySegment<byte>? GetUnlockBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public bool[] GetUnlockArray() { return __p.__vector_as_array<bool>(24); }
  public long RecipeId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RecipeIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRecipeIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetRecipeIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetRecipeIdArray() { return __p.__vector_as_array<long>(26); }
  public int MaxLevel(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MaxLevelLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMaxLevelBytes() { return __p.__vector_as_span<int>(28, 4); }
#else
  public ArraySegment<byte>? GetMaxLevelBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public int[] GetMaxLevelArray() { return __p.__vector_as_array<int>(28); }
  public string PreviousSkillGroupId(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PreviousSkillGroupIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string AfterSkillGroupId(int j) { int o = __p.__offset(32); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AfterSkillGroupIdLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataGlobal.EquipmentOptionType StatType(int j) { int o = __p.__offset(34); return o != 0 ? (FlatDataGlobal.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.EquipmentOptionType>(34, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatDataGlobal.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.EquipmentOptionType[] a = new FlatDataGlobal.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StatValue(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatValueLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatValueBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetStatValueBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetStatValueArray() { return __p.__vector_as_array<long>(36); }

  public static Offset<FlatDataGlobal.CharacterWeaponExcel> CreateCharacterWeaponExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset ImagePathOffset = default(StringOffset),
      long SetRecipe = 0,
      FlatDataGlobal.StatLevelUpType StatLevelUpType = FlatDataGlobal.StatLevelUpType.Standard,
      long AttackPower = 0,
      long AttackPower100 = 0,
      long MaxHP = 0,
      long MaxHP100 = 0,
      long HealPower = 0,
      long HealPower100 = 0,
      VectorOffset UnlockOffset = default(VectorOffset),
      VectorOffset RecipeIdOffset = default(VectorOffset),
      VectorOffset MaxLevelOffset = default(VectorOffset),
      VectorOffset PreviousSkillGroupIdOffset = default(VectorOffset),
      VectorOffset AfterSkillGroupIdOffset = default(VectorOffset),
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset StatValueOffset = default(VectorOffset)) {
    builder.StartTable(17);
    CharacterWeaponExcel.AddHealPower100(builder, HealPower100);
    CharacterWeaponExcel.AddHealPower(builder, HealPower);
    CharacterWeaponExcel.AddMaxHP100(builder, MaxHP100);
    CharacterWeaponExcel.AddMaxHP(builder, MaxHP);
    CharacterWeaponExcel.AddAttackPower100(builder, AttackPower100);
    CharacterWeaponExcel.AddAttackPower(builder, AttackPower);
    CharacterWeaponExcel.AddSetRecipe(builder, SetRecipe);
    CharacterWeaponExcel.AddId(builder, Id);
    CharacterWeaponExcel.AddStatValue(builder, StatValueOffset);
    CharacterWeaponExcel.AddStatType(builder, StatTypeOffset);
    CharacterWeaponExcel.AddAfterSkillGroupId(builder, AfterSkillGroupIdOffset);
    CharacterWeaponExcel.AddPreviousSkillGroupId(builder, PreviousSkillGroupIdOffset);
    CharacterWeaponExcel.AddMaxLevel(builder, MaxLevelOffset);
    CharacterWeaponExcel.AddRecipeId(builder, RecipeIdOffset);
    CharacterWeaponExcel.AddUnlock(builder, UnlockOffset);
    CharacterWeaponExcel.AddStatLevelUpType(builder, StatLevelUpType);
    CharacterWeaponExcel.AddImagePath(builder, ImagePathOffset);
    return CharacterWeaponExcel.EndCharacterWeaponExcel(builder);
  }

  public static void StartCharacterWeaponExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset ImagePathOffset) { builder.AddOffset(1, ImagePathOffset.Value, 0); }
  public static void AddSetRecipe(FlatBufferBuilder builder, long SetRecipe) { builder.AddLong(2, SetRecipe, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, FlatDataGlobal.StatLevelUpType StatLevelUpType) { builder.AddInt(3, (int)StatLevelUpType, 0); }
  public static void AddAttackPower(FlatBufferBuilder builder, long AttackPower) { builder.AddLong(4, AttackPower, 0); }
  public static void AddAttackPower100(FlatBufferBuilder builder, long AttackPower100) { builder.AddLong(5, AttackPower100, 0); }
  public static void AddMaxHP(FlatBufferBuilder builder, long MaxHP) { builder.AddLong(6, MaxHP, 0); }
  public static void AddMaxHP100(FlatBufferBuilder builder, long MaxHP100) { builder.AddLong(7, MaxHP100, 0); }
  public static void AddHealPower(FlatBufferBuilder builder, long HealPower) { builder.AddLong(8, HealPower, 0); }
  public static void AddHealPower100(FlatBufferBuilder builder, long HealPower100) { builder.AddLong(9, HealPower100, 0); }
  public static void AddUnlock(FlatBufferBuilder builder, VectorOffset UnlockOffset) { builder.AddOffset(10, UnlockOffset.Value, 0); }
  public static VectorOffset CreateUnlockVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnlockVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddRecipeId(FlatBufferBuilder builder, VectorOffset RecipeIdOffset) { builder.AddOffset(11, RecipeIdOffset.Value, 0); }
  public static VectorOffset CreateRecipeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRecipeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxLevel(FlatBufferBuilder builder, VectorOffset MaxLevelOffset) { builder.AddOffset(12, MaxLevelOffset.Value, 0); }
  public static VectorOffset CreateMaxLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPreviousSkillGroupId(FlatBufferBuilder builder, VectorOffset PreviousSkillGroupIdOffset) { builder.AddOffset(13, PreviousSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreatePreviousSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePreviousSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreviousSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreviousSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreviousSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAfterSkillGroupId(FlatBufferBuilder builder, VectorOffset AfterSkillGroupIdOffset) { builder.AddOffset(14, AfterSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateAfterSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAfterSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAfterSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAfterSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAfterSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset StatTypeOffset) { builder.AddOffset(15, StatTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, FlatDataGlobal.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatValue(FlatBufferBuilder builder, VectorOffset StatValueOffset) { builder.AddOffset(16, StatValueOffset.Value, 0); }
  public static VectorOffset CreateStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.CharacterWeaponExcel> EndCharacterWeaponExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterWeaponExcel>(o);
  }
}


}
