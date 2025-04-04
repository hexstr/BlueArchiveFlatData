// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BossPhaseExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BossPhaseExcel GetRootAsBossPhaseExcel(ByteBuffer _bb) { return GetRootAsBossPhaseExcel(_bb, new BossPhaseExcel()); }
  public static BossPhaseExcel GetRootAsBossPhaseExcel(ByteBuffer _bb, BossPhaseExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BossPhaseExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AIPhase { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string NormalAttackSkillUniqueName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNormalAttackSkillUniqueNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNormalAttackSkillUniqueNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNormalAttackSkillUniqueNameArray() { return __p.__vector_as_array<byte>(8); }
  public bool UseExSkill(int j) { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int UseExSkillLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetUseExSkillBytes() { return __p.__vector_as_span<bool>(10, 1); }
#else
  public ArraySegment<byte>? GetUseExSkillBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public bool[] GetUseExSkillArray() { return __p.__vector_as_array<bool>(10); }

  public static Offset<FlatDataJp.BossPhaseExcel> CreateBossPhaseExcel(FlatBufferBuilder builder,
      long Id = 0,
      long AIPhase = 0,
      StringOffset NormalAttackSkillUniqueNameOffset = default(StringOffset),
      VectorOffset UseExSkillOffset = default(VectorOffset)) {
    builder.StartTable(4);
    BossPhaseExcel.AddAIPhase(builder, AIPhase);
    BossPhaseExcel.AddId(builder, Id);
    BossPhaseExcel.AddUseExSkill(builder, UseExSkillOffset);
    BossPhaseExcel.AddNormalAttackSkillUniqueName(builder, NormalAttackSkillUniqueNameOffset);
    return BossPhaseExcel.EndBossPhaseExcel(builder);
  }

  public static void StartBossPhaseExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddAIPhase(FlatBufferBuilder builder, long AIPhase) { builder.AddLong(1, AIPhase, 0); }
  public static void AddNormalAttackSkillUniqueName(FlatBufferBuilder builder, StringOffset NormalAttackSkillUniqueNameOffset) { builder.AddOffset(2, NormalAttackSkillUniqueNameOffset.Value, 0); }
  public static void AddUseExSkill(FlatBufferBuilder builder, VectorOffset UseExSkillOffset) { builder.AddOffset(3, UseExSkillOffset.Value, 0); }
  public static VectorOffset CreateUseExSkillVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUseExSkillVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUseExSkillVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUseExSkillVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUseExSkillVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<FlatDataJp.BossPhaseExcel> EndBossPhaseExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.BossPhaseExcel>(o);
  }
}


}
