// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstAudioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConstAudioExcel GetRootAsConstAudioExcel(ByteBuffer _bb) { return GetRootAsConstAudioExcel(_bb, new ConstAudioExcel()); }
  public static ConstAudioExcel GetRootAsConstAudioExcel(ByteBuffer _bb, ConstAudioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstAudioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DefaultSnapShotName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefaultSnapShotNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDefaultSnapShotNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDefaultSnapShotNameArray() { return __p.__vector_as_array<byte>(4); }
  public string BattleSnapShotName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBattleSnapShotNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetBattleSnapShotNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetBattleSnapShotNameArray() { return __p.__vector_as_array<byte>(6); }
  public string RaidSnapShotName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRaidSnapShotNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetRaidSnapShotNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetRaidSnapShotNameArray() { return __p.__vector_as_array<byte>(8); }
  public string ExSkillCutInSnapShotName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExSkillCutInSnapShotNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetExSkillCutInSnapShotNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetExSkillCutInSnapShotNameArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<FlatDataJp.ConstAudioExcel> CreateConstAudioExcel(FlatBufferBuilder builder,
      StringOffset DefaultSnapShotNameOffset = default(StringOffset),
      StringOffset BattleSnapShotNameOffset = default(StringOffset),
      StringOffset RaidSnapShotNameOffset = default(StringOffset),
      StringOffset ExSkillCutInSnapShotNameOffset = default(StringOffset)) {
    builder.StartTable(4);
    ConstAudioExcel.AddExSkillCutInSnapShotName(builder, ExSkillCutInSnapShotNameOffset);
    ConstAudioExcel.AddRaidSnapShotName(builder, RaidSnapShotNameOffset);
    ConstAudioExcel.AddBattleSnapShotName(builder, BattleSnapShotNameOffset);
    ConstAudioExcel.AddDefaultSnapShotName(builder, DefaultSnapShotNameOffset);
    return ConstAudioExcel.EndConstAudioExcel(builder);
  }

  public static void StartConstAudioExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddDefaultSnapShotName(FlatBufferBuilder builder, StringOffset DefaultSnapShotNameOffset) { builder.AddOffset(0, DefaultSnapShotNameOffset.Value, 0); }
  public static void AddBattleSnapShotName(FlatBufferBuilder builder, StringOffset BattleSnapShotNameOffset) { builder.AddOffset(1, BattleSnapShotNameOffset.Value, 0); }
  public static void AddRaidSnapShotName(FlatBufferBuilder builder, StringOffset RaidSnapShotNameOffset) { builder.AddOffset(2, RaidSnapShotNameOffset.Value, 0); }
  public static void AddExSkillCutInSnapShotName(FlatBufferBuilder builder, StringOffset ExSkillCutInSnapShotNameOffset) { builder.AddOffset(3, ExSkillCutInSnapShotNameOffset.Value, 0); }
  public static Offset<FlatDataJp.ConstAudioExcel> EndConstAudioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConstAudioExcel>(o);
  }
}


}
