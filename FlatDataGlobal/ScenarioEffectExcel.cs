// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioEffectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ScenarioEffectExcel GetRootAsScenarioEffectExcel(ByteBuffer _bb) { return GetRootAsScenarioEffectExcel(_bb, new ScenarioEffectExcel()); }
  public static ScenarioEffectExcel GetRootAsScenarioEffectExcel(ByteBuffer _bb, ScenarioEffectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioEffectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string EffectName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetEffectNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetEffectNameArray() { return __p.__vector_as_array<byte>(4); }
  public uint Name { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatDataGlobal.ScenarioEffectExcel> CreateScenarioEffectExcel(FlatBufferBuilder builder,
      StringOffset EffectNameOffset = default(StringOffset),
      uint Name = 0) {
    builder.StartTable(2);
    ScenarioEffectExcel.AddName(builder, Name);
    ScenarioEffectExcel.AddEffectName(builder, EffectNameOffset);
    return ScenarioEffectExcel.EndScenarioEffectExcel(builder);
  }

  public static void StartScenarioEffectExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddEffectName(FlatBufferBuilder builder, StringOffset EffectNameOffset) { builder.AddOffset(0, EffectNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, uint Name) { builder.AddUint(1, Name, 0); }
  public static Offset<FlatDataGlobal.ScenarioEffectExcel> EndScenarioEffectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ScenarioEffectExcel>(o);
  }
}


}
