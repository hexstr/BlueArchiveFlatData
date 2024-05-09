// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGVoiceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MinigameTBGVoiceExcel GetRootAsMinigameTBGVoiceExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGVoiceExcel(_bb, new MinigameTBGVoiceExcel()); }
  public static MinigameTBGVoiceExcel GetRootAsMinigameTBGVoiceExcel(ByteBuffer _bb, MinigameTBGVoiceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGVoiceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TBGVoiceCondition VoiceCondition { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.TBGVoiceCondition)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TBGVoiceCondition.None; } }
  public uint VoiceId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatDataGlobal.MinigameTBGVoiceExcel> CreateMinigameTBGVoiceExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long UniqueId = 0,
      FlatDataGlobal.TBGVoiceCondition VoiceCondition = FlatDataGlobal.TBGVoiceCondition.None,
      uint VoiceId = 0) {
    builder.StartTable(4);
    MinigameTBGVoiceExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGVoiceExcel.AddEventContentId(builder, EventContentId);
    MinigameTBGVoiceExcel.AddVoiceId(builder, VoiceId);
    MinigameTBGVoiceExcel.AddVoiceCondition(builder, VoiceCondition);
    return MinigameTBGVoiceExcel.EndMinigameTBGVoiceExcel(builder);
  }

  public static void StartMinigameTBGVoiceExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(1, UniqueId, 0); }
  public static void AddVoiceCondition(FlatBufferBuilder builder, FlatDataGlobal.TBGVoiceCondition VoiceCondition) { builder.AddInt(2, (int)VoiceCondition, 0); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint VoiceId) { builder.AddUint(3, VoiceId, 0); }
  public static Offset<FlatDataGlobal.MinigameTBGVoiceExcel> EndMinigameTBGVoiceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MinigameTBGVoiceExcel>(o);
  }
}


}
