// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentChangeScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentChangeScenarioExcel GetRootAsEventContentChangeScenarioExcel(ByteBuffer _bb) { return GetRootAsEventContentChangeScenarioExcel(_bb, new EventContentChangeScenarioExcel()); }
  public static EventContentChangeScenarioExcel GetRootAsEventContentChangeScenarioExcel(ByteBuffer _bb, EventContentChangeScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentChangeScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EventChangeType ChangeType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.EventChangeType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EventChangeType.MainSub; } }
  public long ChangeCount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.EventContentChangeScenarioExcel> CreateEventContentChangeScenarioExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataJp.EventChangeType ChangeType = FlatDataJp.EventChangeType.MainSub,
      long ChangeCount = 0,
      long ScenarioGroupId = 0) {
    builder.StartTable(4);
    EventContentChangeScenarioExcel.AddScenarioGroupId(builder, ScenarioGroupId);
    EventContentChangeScenarioExcel.AddChangeCount(builder, ChangeCount);
    EventContentChangeScenarioExcel.AddEventContentId(builder, EventContentId);
    EventContentChangeScenarioExcel.AddChangeType(builder, ChangeType);
    return EventContentChangeScenarioExcel.EndEventContentChangeScenarioExcel(builder);
  }

  public static void StartEventContentChangeScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddChangeType(FlatBufferBuilder builder, FlatDataJp.EventChangeType ChangeType) { builder.AddInt(1, (int)ChangeType, 0); }
  public static void AddChangeCount(FlatBufferBuilder builder, long ChangeCount) { builder.AddLong(2, ChangeCount, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, long ScenarioGroupId) { builder.AddLong(3, ScenarioGroupId, 0); }
  public static Offset<FlatDataJp.EventContentChangeScenarioExcel> EndEventContentChangeScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentChangeScenarioExcel>(o);
  }
}


}
