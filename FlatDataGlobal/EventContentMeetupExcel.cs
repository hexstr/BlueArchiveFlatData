// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentMeetupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb) { return GetRootAsEventContentMeetupExcel(_bb, new EventContentMeetupExcel()); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb, EventContentMeetupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMeetupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConditionScenarioGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.MeetupConditionType ConditionType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.MeetupConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MeetupConditionType.None; } }
  public long ConditionParameter(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionParameterLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionParameterBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetConditionParameterBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetConditionParameterArray() { return __p.__vector_as_array<long>(14); }
  public FlatDataGlobal.MeetupConditionPrintType ConditionPrintType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataGlobal.MeetupConditionPrintType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MeetupConditionPrintType.None; } }

  public static Offset<FlatDataGlobal.EventContentMeetupExcel> CreateEventContentMeetupExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long CharacterId = 0,
      long ConditionScenarioGroupId = 0,
      FlatDataGlobal.MeetupConditionType ConditionType = FlatDataGlobal.MeetupConditionType.None,
      VectorOffset ConditionParameterOffset = default(VectorOffset),
      FlatDataGlobal.MeetupConditionPrintType ConditionPrintType = FlatDataGlobal.MeetupConditionPrintType.None) {
    builder.StartTable(7);
    EventContentMeetupExcel.AddConditionScenarioGroupId(builder, ConditionScenarioGroupId);
    EventContentMeetupExcel.AddCharacterId(builder, CharacterId);
    EventContentMeetupExcel.AddEventContentId(builder, EventContentId);
    EventContentMeetupExcel.AddId(builder, Id);
    EventContentMeetupExcel.AddConditionPrintType(builder, ConditionPrintType);
    EventContentMeetupExcel.AddConditionParameter(builder, ConditionParameterOffset);
    EventContentMeetupExcel.AddConditionType(builder, ConditionType);
    return EventContentMeetupExcel.EndEventContentMeetupExcel(builder);
  }

  public static void StartEventContentMeetupExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(2, CharacterId, 0); }
  public static void AddConditionScenarioGroupId(FlatBufferBuilder builder, long ConditionScenarioGroupId) { builder.AddLong(3, ConditionScenarioGroupId, 0); }
  public static void AddConditionType(FlatBufferBuilder builder, FlatDataGlobal.MeetupConditionType ConditionType) { builder.AddInt(4, (int)ConditionType, 0); }
  public static void AddConditionParameter(FlatBufferBuilder builder, VectorOffset ConditionParameterOffset) { builder.AddOffset(5, ConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionPrintType(FlatBufferBuilder builder, FlatDataGlobal.MeetupConditionPrintType ConditionPrintType) { builder.AddInt(6, (int)ConditionPrintType, 0); }
  public static Offset<FlatDataGlobal.EventContentMeetupExcel> EndEventContentMeetupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentMeetupExcel>(o);
  }
}


}
