// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentDiceRaceProbExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentDiceRaceProbExcel GetRootAsEventContentDiceRaceProbExcel(ByteBuffer _bb) { return GetRootAsEventContentDiceRaceProbExcel(_bb, new EventContentDiceRaceProbExcel()); }
  public static EventContentDiceRaceProbExcel GetRootAsEventContentDiceRaceProbExcel(ByteBuffer _bb, EventContentDiceRaceProbExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDiceRaceProbExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EventContentDiceRaceResultType EventContentDiceRaceResultType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.EventContentDiceRaceResultType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EventContentDiceRaceResultType.DiceResult1; } }
  public int DiceResult { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.EventContentDiceRaceProbExcel> CreateEventContentDiceRaceProbExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatDataJp.EventContentDiceRaceResultType EventContentDiceRaceResultType = FlatDataJp.EventContentDiceRaceResultType.DiceResult1,
      int DiceResult = 0,
      int Prob = 0) {
    builder.StartTable(4);
    EventContentDiceRaceProbExcel.AddEventContentId(builder, EventContentId);
    EventContentDiceRaceProbExcel.AddProb(builder, Prob);
    EventContentDiceRaceProbExcel.AddDiceResult(builder, DiceResult);
    EventContentDiceRaceProbExcel.AddEventContentDiceRaceResultType(builder, EventContentDiceRaceResultType);
    return EventContentDiceRaceProbExcel.EndEventContentDiceRaceProbExcel(builder);
  }

  public static void StartEventContentDiceRaceProbExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddEventContentDiceRaceResultType(FlatBufferBuilder builder, FlatDataJp.EventContentDiceRaceResultType EventContentDiceRaceResultType) { builder.AddInt(1, (int)EventContentDiceRaceResultType, 0); }
  public static void AddDiceResult(FlatBufferBuilder builder, int DiceResult) { builder.AddInt(2, DiceResult, 0); }
  public static void AddProb(FlatBufferBuilder builder, int Prob) { builder.AddInt(3, Prob, 0); }
  public static Offset<FlatDataJp.EventContentDiceRaceProbExcel> EndEventContentDiceRaceProbExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentDiceRaceProbExcel>(o);
  }
}


}
