// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterSkillListExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterSkillListExcel GetRootAsCharacterSkillListExcel(ByteBuffer _bb) { return GetRootAsCharacterSkillListExcel(_bb, new CharacterSkillListExcel()); }
  public static CharacterSkillListExcel GetRootAsCharacterSkillListExcel(ByteBuffer _bb, CharacterSkillListExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterSkillListExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterSkillListGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MinimumGradeCharacterWeapon { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MinimumTierCharacterGear { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FormIndex { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsRootMotion { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsMoveLeftRight { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool UseRandomExSkillTimeline { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long TSAInteractionId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string NormalSkillGroupId(int j) { int o = __p.__offset(20); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int NormalSkillGroupIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int NormalSkillTimeLineIndex(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int NormalSkillTimeLineIndexLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetNormalSkillTimeLineIndexBytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetNormalSkillTimeLineIndexBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetNormalSkillTimeLineIndexArray() { return __p.__vector_as_array<int>(22); }
  public string ExSkillGroupId(int j) { int o = __p.__offset(24); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ExSkillGroupIdLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ExSkillCutInTimeLineIndex(int j) { int o = __p.__offset(26); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ExSkillCutInTimeLineIndexLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ExSkillLevelTimeLineIndex(int j) { int o = __p.__offset(28); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ExSkillLevelTimeLineIndexLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string PublicSkillGroupId(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PublicSkillGroupIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int PublicSkillTimeLineIndex(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int PublicSkillTimeLineIndexLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetPublicSkillTimeLineIndexBytes() { return __p.__vector_as_span<int>(32, 4); }
#else
  public ArraySegment<byte>? GetPublicSkillTimeLineIndexBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public int[] GetPublicSkillTimeLineIndexArray() { return __p.__vector_as_array<int>(32); }
  public string PassiveSkillGroupId(int j) { int o = __p.__offset(34); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PassiveSkillGroupIdLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string LeaderSkillGroupId(int j) { int o = __p.__offset(36); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LeaderSkillGroupIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ExtraPassiveSkillGroupId(int j) { int o = __p.__offset(38); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ExtraPassiveSkillGroupIdLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string HiddenPassiveSkillGroupId(int j) { int o = __p.__offset(40); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int HiddenPassiveSkillGroupIdLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.CharacterSkillListExcel> CreateCharacterSkillListExcel(FlatBufferBuilder builder,
      long CharacterSkillListGroupId = 0,
      int MinimumGradeCharacterWeapon = 0,
      int MinimumTierCharacterGear = 0,
      int FormIndex = 0,
      bool IsRootMotion = false,
      bool IsMoveLeftRight = false,
      bool UseRandomExSkillTimeline = false,
      long TSAInteractionId = 0,
      VectorOffset NormalSkillGroupIdOffset = default(VectorOffset),
      VectorOffset NormalSkillTimeLineIndexOffset = default(VectorOffset),
      VectorOffset ExSkillGroupIdOffset = default(VectorOffset),
      VectorOffset ExSkillCutInTimeLineIndexOffset = default(VectorOffset),
      VectorOffset ExSkillLevelTimeLineIndexOffset = default(VectorOffset),
      VectorOffset PublicSkillGroupIdOffset = default(VectorOffset),
      VectorOffset PublicSkillTimeLineIndexOffset = default(VectorOffset),
      VectorOffset PassiveSkillGroupIdOffset = default(VectorOffset),
      VectorOffset LeaderSkillGroupIdOffset = default(VectorOffset),
      VectorOffset ExtraPassiveSkillGroupIdOffset = default(VectorOffset),
      VectorOffset HiddenPassiveSkillGroupIdOffset = default(VectorOffset)) {
    builder.StartTable(19);
    CharacterSkillListExcel.AddTSAInteractionId(builder, TSAInteractionId);
    CharacterSkillListExcel.AddCharacterSkillListGroupId(builder, CharacterSkillListGroupId);
    CharacterSkillListExcel.AddHiddenPassiveSkillGroupId(builder, HiddenPassiveSkillGroupIdOffset);
    CharacterSkillListExcel.AddExtraPassiveSkillGroupId(builder, ExtraPassiveSkillGroupIdOffset);
    CharacterSkillListExcel.AddLeaderSkillGroupId(builder, LeaderSkillGroupIdOffset);
    CharacterSkillListExcel.AddPassiveSkillGroupId(builder, PassiveSkillGroupIdOffset);
    CharacterSkillListExcel.AddPublicSkillTimeLineIndex(builder, PublicSkillTimeLineIndexOffset);
    CharacterSkillListExcel.AddPublicSkillGroupId(builder, PublicSkillGroupIdOffset);
    CharacterSkillListExcel.AddExSkillLevelTimeLineIndex(builder, ExSkillLevelTimeLineIndexOffset);
    CharacterSkillListExcel.AddExSkillCutInTimeLineIndex(builder, ExSkillCutInTimeLineIndexOffset);
    CharacterSkillListExcel.AddExSkillGroupId(builder, ExSkillGroupIdOffset);
    CharacterSkillListExcel.AddNormalSkillTimeLineIndex(builder, NormalSkillTimeLineIndexOffset);
    CharacterSkillListExcel.AddNormalSkillGroupId(builder, NormalSkillGroupIdOffset);
    CharacterSkillListExcel.AddFormIndex(builder, FormIndex);
    CharacterSkillListExcel.AddMinimumTierCharacterGear(builder, MinimumTierCharacterGear);
    CharacterSkillListExcel.AddMinimumGradeCharacterWeapon(builder, MinimumGradeCharacterWeapon);
    CharacterSkillListExcel.AddUseRandomExSkillTimeline(builder, UseRandomExSkillTimeline);
    CharacterSkillListExcel.AddIsMoveLeftRight(builder, IsMoveLeftRight);
    CharacterSkillListExcel.AddIsRootMotion(builder, IsRootMotion);
    return CharacterSkillListExcel.EndCharacterSkillListExcel(builder);
  }

  public static void StartCharacterSkillListExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddCharacterSkillListGroupId(FlatBufferBuilder builder, long CharacterSkillListGroupId) { builder.AddLong(0, CharacterSkillListGroupId, 0); }
  public static void AddMinimumGradeCharacterWeapon(FlatBufferBuilder builder, int MinimumGradeCharacterWeapon) { builder.AddInt(1, MinimumGradeCharacterWeapon, 0); }
  public static void AddMinimumTierCharacterGear(FlatBufferBuilder builder, int MinimumTierCharacterGear) { builder.AddInt(2, MinimumTierCharacterGear, 0); }
  public static void AddFormIndex(FlatBufferBuilder builder, int FormIndex) { builder.AddInt(3, FormIndex, 0); }
  public static void AddIsRootMotion(FlatBufferBuilder builder, bool IsRootMotion) { builder.AddBool(4, IsRootMotion, false); }
  public static void AddIsMoveLeftRight(FlatBufferBuilder builder, bool IsMoveLeftRight) { builder.AddBool(5, IsMoveLeftRight, false); }
  public static void AddUseRandomExSkillTimeline(FlatBufferBuilder builder, bool UseRandomExSkillTimeline) { builder.AddBool(6, UseRandomExSkillTimeline, false); }
  public static void AddTSAInteractionId(FlatBufferBuilder builder, long TSAInteractionId) { builder.AddLong(7, TSAInteractionId, 0); }
  public static void AddNormalSkillGroupId(FlatBufferBuilder builder, VectorOffset NormalSkillGroupIdOffset) { builder.AddOffset(8, NormalSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateNormalSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNormalSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNormalSkillTimeLineIndex(FlatBufferBuilder builder, VectorOffset NormalSkillTimeLineIndexOffset) { builder.AddOffset(9, NormalSkillTimeLineIndexOffset.Value, 0); }
  public static VectorOffset CreateNormalSkillTimeLineIndexVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNormalSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNormalSkillTimeLineIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExSkillGroupId(FlatBufferBuilder builder, VectorOffset ExSkillGroupIdOffset) { builder.AddOffset(10, ExSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateExSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateExSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExSkillCutInTimeLineIndex(FlatBufferBuilder builder, VectorOffset ExSkillCutInTimeLineIndexOffset) { builder.AddOffset(11, ExSkillCutInTimeLineIndexOffset.Value, 0); }
  public static VectorOffset CreateExSkillCutInTimeLineIndexVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateExSkillCutInTimeLineIndexVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillCutInTimeLineIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillCutInTimeLineIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExSkillCutInTimeLineIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExSkillLevelTimeLineIndex(FlatBufferBuilder builder, VectorOffset ExSkillLevelTimeLineIndexOffset) { builder.AddOffset(12, ExSkillLevelTimeLineIndexOffset.Value, 0); }
  public static VectorOffset CreateExSkillLevelTimeLineIndexVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateExSkillLevelTimeLineIndexVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillLevelTimeLineIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExSkillLevelTimeLineIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExSkillLevelTimeLineIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPublicSkillGroupId(FlatBufferBuilder builder, VectorOffset PublicSkillGroupIdOffset) { builder.AddOffset(13, PublicSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreatePublicSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPublicSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPublicSkillTimeLineIndex(FlatBufferBuilder builder, VectorOffset PublicSkillTimeLineIndexOffset) { builder.AddOffset(14, PublicSkillTimeLineIndexOffset.Value, 0); }
  public static VectorOffset CreatePublicSkillTimeLineIndexVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillTimeLineIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPublicSkillTimeLineIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkillGroupId(FlatBufferBuilder builder, VectorOffset PassiveSkillGroupIdOffset) { builder.AddOffset(15, PassiveSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPassiveSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLeaderSkillGroupId(FlatBufferBuilder builder, VectorOffset LeaderSkillGroupIdOffset) { builder.AddOffset(16, LeaderSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateLeaderSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLeaderSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLeaderSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLeaderSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLeaderSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraPassiveSkillGroupId(FlatBufferBuilder builder, VectorOffset ExtraPassiveSkillGroupIdOffset) { builder.AddOffset(17, ExtraPassiveSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateExtraPassiveSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateExtraPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraPassiveSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHiddenPassiveSkillGroupId(FlatBufferBuilder builder, VectorOffset HiddenPassiveSkillGroupIdOffset) { builder.AddOffset(18, HiddenPassiveSkillGroupIdOffset.Value, 0); }
  public static VectorOffset CreateHiddenPassiveSkillGroupIdVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateHiddenPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHiddenPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateHiddenPassiveSkillGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartHiddenPassiveSkillGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.CharacterSkillListExcel> EndCharacterSkillListExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterSkillListExcel>(o);
  }
}


}
