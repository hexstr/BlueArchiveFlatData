// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BossExternalBTExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BossExternalBTExcel GetRootAsBossExternalBTExcel(ByteBuffer _bb) { return GetRootAsBossExternalBTExcel(_bb, new BossExternalBTExcel()); }
  public static BossExternalBTExcel GetRootAsBossExternalBTExcel(ByteBuffer _bb, BossExternalBTExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BossExternalBTExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AIPhase { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ExternalBTNodeType Externalbtnodetype { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.ExternalBTNodeType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ExternalBTNodeType.Sequence; } }
  public FlatDataJp.ExternalBTTrigger Externalbttrigger { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ExternalBTTrigger)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ExternalBTTrigger.None; } }
  public string TriggerArgument { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTriggerArgumentBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTriggerArgumentBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTriggerArgumentArray() { return __p.__vector_as_array<byte>(12); }
  public long BehaviorRate { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ExternalBehavior Externalbehavior { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ExternalBehavior)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ExternalBehavior.UseNextExSkill; } }
  public string BehaviorArgument { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBehaviorArgumentBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetBehaviorArgumentBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetBehaviorArgumentArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataJp.BossExternalBTExcel> CreateBossExternalBTExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long AIPhase = 0,
      FlatDataJp.ExternalBTNodeType externalbtnodetype = FlatDataJp.ExternalBTNodeType.Sequence,
      FlatDataJp.ExternalBTTrigger externalbttrigger = FlatDataJp.ExternalBTTrigger.None,
      StringOffset TriggerArgumentOffset = default(StringOffset),
      long BehaviorRate = 0,
      FlatDataJp.ExternalBehavior externalbehavior = FlatDataJp.ExternalBehavior.UseNextExSkill,
      StringOffset BehaviorArgumentOffset = default(StringOffset)) {
    builder.StartTable(8);
    BossExternalBTExcel.AddBehaviorRate(builder, BehaviorRate);
    BossExternalBTExcel.AddAIPhase(builder, AIPhase);
    BossExternalBTExcel.AddCharacterId(builder, CharacterId);
    BossExternalBTExcel.AddBehaviorArgument(builder, BehaviorArgumentOffset);
    BossExternalBTExcel.AddExternalbehavior(builder, externalbehavior);
    BossExternalBTExcel.AddTriggerArgument(builder, TriggerArgumentOffset);
    BossExternalBTExcel.AddExternalbttrigger(builder, externalbttrigger);
    BossExternalBTExcel.AddExternalbtnodetype(builder, externalbtnodetype);
    return BossExternalBTExcel.EndBossExternalBTExcel(builder);
  }

  public static void StartBossExternalBTExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddAIPhase(FlatBufferBuilder builder, long AIPhase) { builder.AddLong(1, AIPhase, 0); }
  public static void AddExternalbtnodetype(FlatBufferBuilder builder, FlatDataJp.ExternalBTNodeType externalbtnodetype) { builder.AddInt(2, (int)externalbtnodetype, 0); }
  public static void AddExternalbttrigger(FlatBufferBuilder builder, FlatDataJp.ExternalBTTrigger externalbttrigger) { builder.AddInt(3, (int)externalbttrigger, 0); }
  public static void AddTriggerArgument(FlatBufferBuilder builder, StringOffset TriggerArgumentOffset) { builder.AddOffset(4, TriggerArgumentOffset.Value, 0); }
  public static void AddBehaviorRate(FlatBufferBuilder builder, long BehaviorRate) { builder.AddLong(5, BehaviorRate, 0); }
  public static void AddExternalbehavior(FlatBufferBuilder builder, FlatDataJp.ExternalBehavior externalbehavior) { builder.AddInt(6, (int)externalbehavior, 0); }
  public static void AddBehaviorArgument(FlatBufferBuilder builder, StringOffset BehaviorArgumentOffset) { builder.AddOffset(7, BehaviorArgumentOffset.Value, 0); }
  public static Offset<FlatDataJp.BossExternalBTExcel> EndBossExternalBTExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.BossExternalBTExcel>(o);
  }
}


}
