// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SpineLipsyncExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static SpineLipsyncExcel GetRootAsSpineLipsyncExcel(ByteBuffer _bb) { return GetRootAsSpineLipsyncExcel(_bb, new SpineLipsyncExcel()); }
  public static SpineLipsyncExcel GetRootAsSpineLipsyncExcel(ByteBuffer _bb, SpineLipsyncExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SpineLipsyncExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint VoiceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string AnimJson { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimJsonBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetAnimJsonBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAnimJsonArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<FlatDataGlobal.SpineLipsyncExcel> CreateSpineLipsyncExcel(FlatBufferBuilder builder,
      uint VoiceId = 0,
      StringOffset AnimJsonOffset = default(StringOffset)) {
    builder.StartTable(2);
    SpineLipsyncExcel.AddAnimJson(builder, AnimJsonOffset);
    SpineLipsyncExcel.AddVoiceId(builder, VoiceId);
    return SpineLipsyncExcel.EndSpineLipsyncExcel(builder);
  }

  public static void StartSpineLipsyncExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint VoiceId) { builder.AddUint(0, VoiceId, 0); }
  public static void AddAnimJson(FlatBufferBuilder builder, StringOffset AnimJsonOffset) { builder.AddOffset(1, AnimJsonOffset.Value, 0); }
  public static Offset<FlatDataGlobal.SpineLipsyncExcel> EndSpineLipsyncExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.SpineLipsyncExcel>(o);
  }
}


}
