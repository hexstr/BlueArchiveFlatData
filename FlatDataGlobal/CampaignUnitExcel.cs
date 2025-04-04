// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignUnitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CampaignUnitExcel GetRootAsCampaignUnitExcel(ByteBuffer _bb) { return GetRootAsCampaignUnitExcel(_bb, new CampaignUnitExcel()); }
  public static CampaignUnitExcel GetRootAsCampaignUnitExcel(ByteBuffer _bb, CampaignUnitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignUnitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint Key { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string PrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string StrategyPrefabName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyPrefabNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStrategyPrefabNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStrategyPrefabNameArray() { return __p.__vector_as_array<byte>(12); }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(14); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(16); }
  public long GroundId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MoveRange { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.StrategyAIType AIMoveType { get { int o = __p.__offset(22); return o != 0 ? (FlatDataGlobal.StrategyAIType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.StrategyAIType.None; } }
  public FlatDataGlobal.HexaUnitGrade Grade { get { int o = __p.__offset(24); return o != 0 ? (FlatDataGlobal.HexaUnitGrade)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.HexaUnitGrade.Grade1; } }
  public FlatDataGlobal.TacticEnvironment EnvironmentType { get { int o = __p.__offset(26); return o != 0 ? (FlatDataGlobal.TacticEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TacticEnvironment.None; } }
  public float Scale { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IsTacticSkip { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.CampaignUnitExcel> CreateCampaignUnitExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint Key = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset PrefabNameOffset = default(StringOffset),
      StringOffset StrategyPrefabNameOffset = default(StringOffset),
      VectorOffset EnterScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ClearScenarioGroupIdOffset = default(VectorOffset),
      long GroundId = 0,
      int MoveRange = 0,
      FlatDataGlobal.StrategyAIType AIMoveType = FlatDataGlobal.StrategyAIType.None,
      FlatDataGlobal.HexaUnitGrade Grade = FlatDataGlobal.HexaUnitGrade.Grade1,
      FlatDataGlobal.TacticEnvironment EnvironmentType = FlatDataGlobal.TacticEnvironment.None,
      float Scale = 0.0f,
      bool IsTacticSkip = false) {
    builder.StartTable(14);
    CampaignUnitExcel.AddGroundId(builder, GroundId);
    CampaignUnitExcel.AddId(builder, Id);
    CampaignUnitExcel.AddScale(builder, Scale);
    CampaignUnitExcel.AddEnvironmentType(builder, EnvironmentType);
    CampaignUnitExcel.AddGrade(builder, Grade);
    CampaignUnitExcel.AddAIMoveType(builder, AIMoveType);
    CampaignUnitExcel.AddMoveRange(builder, MoveRange);
    CampaignUnitExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    CampaignUnitExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    CampaignUnitExcel.AddStrategyPrefabName(builder, StrategyPrefabNameOffset);
    CampaignUnitExcel.AddPrefabName(builder, PrefabNameOffset);
    CampaignUnitExcel.AddName(builder, NameOffset);
    CampaignUnitExcel.AddKey(builder, Key);
    CampaignUnitExcel.AddIsTacticSkip(builder, IsTacticSkip);
    return CampaignUnitExcel.EndCampaignUnitExcel(builder);
  }

  public static void StartCampaignUnitExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddKey(FlatBufferBuilder builder, uint Key) { builder.AddUint(1, Key, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset PrefabNameOffset) { builder.AddOffset(3, PrefabNameOffset.Value, 0); }
  public static void AddStrategyPrefabName(FlatBufferBuilder builder, StringOffset StrategyPrefabNameOffset) { builder.AddOffset(4, StrategyPrefabNameOffset.Value, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset EnterScenarioGroupIdOffset) { builder.AddOffset(5, EnterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset ClearScenarioGroupIdOffset) { builder.AddOffset(6, ClearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddGroundId(FlatBufferBuilder builder, long GroundId) { builder.AddLong(7, GroundId, 0); }
  public static void AddMoveRange(FlatBufferBuilder builder, int MoveRange) { builder.AddInt(8, MoveRange, 0); }
  public static void AddAIMoveType(FlatBufferBuilder builder, FlatDataGlobal.StrategyAIType AIMoveType) { builder.AddInt(9, (int)AIMoveType, 0); }
  public static void AddGrade(FlatBufferBuilder builder, FlatDataGlobal.HexaUnitGrade Grade) { builder.AddInt(10, (int)Grade, 0); }
  public static void AddEnvironmentType(FlatBufferBuilder builder, FlatDataGlobal.TacticEnvironment EnvironmentType) { builder.AddInt(11, (int)EnvironmentType, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(12, Scale, 0.0f); }
  public static void AddIsTacticSkip(FlatBufferBuilder builder, bool IsTacticSkip) { builder.AddBool(13, IsTacticSkip, false); }
  public static Offset<FlatDataGlobal.CampaignUnitExcel> EndCampaignUnitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CampaignUnitExcel>(o);
  }
}


}
