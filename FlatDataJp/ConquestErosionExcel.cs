// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestErosionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConquestErosionExcel GetRootAsConquestErosionExcel(ByteBuffer _bb) { return GetRootAsConquestErosionExcel(_bb, new ConquestErosionExcel()); }
  public static ConquestErosionExcel GetRootAsConquestErosionExcel(ByteBuffer _bb, ConquestErosionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestErosionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ConquestErosionType ErosionType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ConquestErosionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ConquestErosionType.None; } }
  public int Phase { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool PhaseAlarm { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int StepIndex { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ConquestConditionType PhaseStartConditionType(int j) { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ConquestConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ConquestConditionType)0; }
  public int PhaseStartConditionTypeLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ConquestConditionType> GetPhaseStartConditionTypeBytes() { return __p.__vector_as_span<FlatDataJp.ConquestConditionType>(16, 4); }
#else
  public ArraySegment<byte>? GetPhaseStartConditionTypeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public FlatDataJp.ConquestConditionType[] GetPhaseStartConditionTypeArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ConquestConditionType[] a = new FlatDataJp.ConquestConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ConquestConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public string PhaseStartConditionParameter(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PhaseStartConditionParameterLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataJp.ConquestConditionType PhaseBeforeExposeConditionType(int j) { int o = __p.__offset(20); return o != 0 ? (FlatDataJp.ConquestConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ConquestConditionType)0; }
  public int PhaseBeforeExposeConditionTypeLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ConquestConditionType> GetPhaseBeforeExposeConditionTypeBytes() { return __p.__vector_as_span<FlatDataJp.ConquestConditionType>(20, 4); }
#else
  public ArraySegment<byte>? GetPhaseBeforeExposeConditionTypeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public FlatDataJp.ConquestConditionType[] GetPhaseBeforeExposeConditionTypeArray() { int o = __p.__offset(20); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ConquestConditionType[] a = new FlatDataJp.ConquestConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ConquestConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public string PhaseBeforeExposeConditionParameter(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PhaseBeforeExposeConditionParameterLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatDataJp.ParcelType ErosionBattleConditionParcelType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ErosionBattleConditionParcelUniqueId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ErosionBattleConditionParcelAmount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConquestRewardId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ConquestErosionExcel> CreateConquestErosionExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Id = 0,
      FlatDataJp.ConquestErosionType ErosionType = FlatDataJp.ConquestErosionType.None,
      int Phase = 0,
      bool PhaseAlarm = false,
      int StepIndex = 0,
      VectorOffset PhaseStartConditionTypeOffset = default(VectorOffset),
      VectorOffset PhaseStartConditionParameterOffset = default(VectorOffset),
      VectorOffset PhaseBeforeExposeConditionTypeOffset = default(VectorOffset),
      VectorOffset PhaseBeforeExposeConditionParameterOffset = default(VectorOffset),
      FlatDataJp.ParcelType ErosionBattleConditionParcelType = FlatDataJp.ParcelType.None,
      long ErosionBattleConditionParcelUniqueId = 0,
      long ErosionBattleConditionParcelAmount = 0,
      long ConquestRewardId = 0) {
    builder.StartTable(14);
    ConquestErosionExcel.AddConquestRewardId(builder, ConquestRewardId);
    ConquestErosionExcel.AddErosionBattleConditionParcelAmount(builder, ErosionBattleConditionParcelAmount);
    ConquestErosionExcel.AddErosionBattleConditionParcelUniqueId(builder, ErosionBattleConditionParcelUniqueId);
    ConquestErosionExcel.AddId(builder, Id);
    ConquestErosionExcel.AddEventContentId(builder, EventContentId);
    ConquestErosionExcel.AddErosionBattleConditionParcelType(builder, ErosionBattleConditionParcelType);
    ConquestErosionExcel.AddPhaseBeforeExposeConditionParameter(builder, PhaseBeforeExposeConditionParameterOffset);
    ConquestErosionExcel.AddPhaseBeforeExposeConditionType(builder, PhaseBeforeExposeConditionTypeOffset);
    ConquestErosionExcel.AddPhaseStartConditionParameter(builder, PhaseStartConditionParameterOffset);
    ConquestErosionExcel.AddPhaseStartConditionType(builder, PhaseStartConditionTypeOffset);
    ConquestErosionExcel.AddStepIndex(builder, StepIndex);
    ConquestErosionExcel.AddPhase(builder, Phase);
    ConquestErosionExcel.AddErosionType(builder, ErosionType);
    ConquestErosionExcel.AddPhaseAlarm(builder, PhaseAlarm);
    return ConquestErosionExcel.EndConquestErosionExcel(builder);
  }

  public static void StartConquestErosionExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(1, Id, 0); }
  public static void AddErosionType(FlatBufferBuilder builder, FlatDataJp.ConquestErosionType ErosionType) { builder.AddInt(2, (int)ErosionType, 0); }
  public static void AddPhase(FlatBufferBuilder builder, int Phase) { builder.AddInt(3, Phase, 0); }
  public static void AddPhaseAlarm(FlatBufferBuilder builder, bool PhaseAlarm) { builder.AddBool(4, PhaseAlarm, false); }
  public static void AddStepIndex(FlatBufferBuilder builder, int StepIndex) { builder.AddInt(5, StepIndex, 0); }
  public static void AddPhaseStartConditionType(FlatBufferBuilder builder, VectorOffset PhaseStartConditionTypeOffset) { builder.AddOffset(6, PhaseStartConditionTypeOffset.Value, 0); }
  public static VectorOffset CreatePhaseStartConditionTypeVector(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ConquestConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ConquestConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPhaseStartConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPhaseStartConditionParameter(FlatBufferBuilder builder, VectorOffset PhaseStartConditionParameterOffset) { builder.AddOffset(7, PhaseStartConditionParameterOffset.Value, 0); }
  public static VectorOffset CreatePhaseStartConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseStartConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPhaseStartConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPhaseBeforeExposeConditionType(FlatBufferBuilder builder, VectorOffset PhaseBeforeExposeConditionTypeOffset) { builder.AddOffset(8, PhaseBeforeExposeConditionTypeOffset.Value, 0); }
  public static VectorOffset CreatePhaseBeforeExposeConditionTypeVector(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ConquestConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ConquestConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPhaseBeforeExposeConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPhaseBeforeExposeConditionParameter(FlatBufferBuilder builder, VectorOffset PhaseBeforeExposeConditionParameterOffset) { builder.AddOffset(9, PhaseBeforeExposeConditionParameterOffset.Value, 0); }
  public static VectorOffset CreatePhaseBeforeExposeConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePhaseBeforeExposeConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPhaseBeforeExposeConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddErosionBattleConditionParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType ErosionBattleConditionParcelType) { builder.AddInt(10, (int)ErosionBattleConditionParcelType, 0); }
  public static void AddErosionBattleConditionParcelUniqueId(FlatBufferBuilder builder, long ErosionBattleConditionParcelUniqueId) { builder.AddLong(11, ErosionBattleConditionParcelUniqueId, 0); }
  public static void AddErosionBattleConditionParcelAmount(FlatBufferBuilder builder, long ErosionBattleConditionParcelAmount) { builder.AddLong(12, ErosionBattleConditionParcelAmount, 0); }
  public static void AddConquestRewardId(FlatBufferBuilder builder, long ConquestRewardId) { builder.AddLong(13, ConquestRewardId, 0); }
  public static Offset<FlatDataJp.ConquestErosionExcel> EndConquestErosionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConquestErosionExcel>(o);
  }
}


}
