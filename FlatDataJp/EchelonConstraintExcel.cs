// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EchelonConstraintExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EchelonConstraintExcel GetRootAsEchelonConstraintExcel(ByteBuffer _bb) { return GetRootAsEchelonConstraintExcel(_bb, new EchelonConstraintExcel()); }
  public static EchelonConstraintExcel GetRootAsEchelonConstraintExcel(ByteBuffer _bb, EchelonConstraintExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EchelonConstraintExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsWhiteList { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CharacterId(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CharacterIdLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCharacterIdBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetCharacterIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetCharacterIdArray() { return __p.__vector_as_array<long>(8); }
  public long PersonalityId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PersonalityIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPersonalityIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetPersonalityIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetPersonalityIdArray() { return __p.__vector_as_array<long>(10); }
  public FlatDataJp.WeaponType WeaponType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.WeaponType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.WeaponType.None; } }
  public FlatDataJp.School School { get { int o = __p.__offset(14); return o != 0 ? (FlatDataJp.School)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.School.None; } }
  public FlatDataJp.Club Club { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.Club)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Club.None; } }
  public FlatDataJp.TacticRole Role { get { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.TacticRole)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TacticRole.None; } }

  public static Offset<FlatDataJp.EchelonConstraintExcel> CreateEchelonConstraintExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      bool IsWhiteList = false,
      VectorOffset CharacterIdOffset = default(VectorOffset),
      VectorOffset PersonalityIdOffset = default(VectorOffset),
      FlatDataJp.WeaponType WeaponType = FlatDataJp.WeaponType.None,
      FlatDataJp.School School = FlatDataJp.School.None,
      FlatDataJp.Club Club = FlatDataJp.Club.None,
      FlatDataJp.TacticRole Role = FlatDataJp.TacticRole.None) {
    builder.StartTable(8);
    EchelonConstraintExcel.AddGroupId(builder, GroupId);
    EchelonConstraintExcel.AddRole(builder, Role);
    EchelonConstraintExcel.AddClub(builder, Club);
    EchelonConstraintExcel.AddSchool(builder, School);
    EchelonConstraintExcel.AddWeaponType(builder, WeaponType);
    EchelonConstraintExcel.AddPersonalityId(builder, PersonalityIdOffset);
    EchelonConstraintExcel.AddCharacterId(builder, CharacterIdOffset);
    EchelonConstraintExcel.AddIsWhiteList(builder, IsWhiteList);
    return EchelonConstraintExcel.EndEchelonConstraintExcel(builder);
  }

  public static void StartEchelonConstraintExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddIsWhiteList(FlatBufferBuilder builder, bool IsWhiteList) { builder.AddBool(1, IsWhiteList, false); }
  public static void AddCharacterId(FlatBufferBuilder builder, VectorOffset CharacterIdOffset) { builder.AddOffset(2, CharacterIdOffset.Value, 0); }
  public static VectorOffset CreateCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddPersonalityId(FlatBufferBuilder builder, VectorOffset PersonalityIdOffset) { builder.AddOffset(3, PersonalityIdOffset.Value, 0); }
  public static VectorOffset CreatePersonalityIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePersonalityIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePersonalityIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePersonalityIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPersonalityIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddWeaponType(FlatBufferBuilder builder, FlatDataJp.WeaponType WeaponType) { builder.AddInt(4, (int)WeaponType, 0); }
  public static void AddSchool(FlatBufferBuilder builder, FlatDataJp.School School) { builder.AddInt(5, (int)School, 0); }
  public static void AddClub(FlatBufferBuilder builder, FlatDataJp.Club Club) { builder.AddInt(6, (int)Club, 0); }
  public static void AddRole(FlatBufferBuilder builder, FlatDataJp.TacticRole Role) { builder.AddInt(7, (int)Role, 0); }
  public static Offset<FlatDataJp.EchelonConstraintExcel> EndEchelonConstraintExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EchelonConstraintExcel>(o);
  }
}


}
