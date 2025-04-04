// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AniEventData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static AniEventData GetRootAsAniEventData(ByteBuffer _bb) { return GetRootAsAniEventData(_bb, new AniEventData()); }
  public static AniEventData GetRootAsAniEventData(ByteBuffer _bb, AniEventData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AniEventData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public float Time { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int IntParam { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float FloatParam { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string StringParam { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStringParamBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStringParamBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStringParamArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataGlobal.AniEventData> CreateAniEventData(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      float Time = 0.0f,
      int IntParam = 0,
      float FloatParam = 0.0f,
      StringOffset StringParamOffset = default(StringOffset)) {
    builder.StartTable(5);
    AniEventData.AddStringParam(builder, StringParamOffset);
    AniEventData.AddFloatParam(builder, FloatParam);
    AniEventData.AddIntParam(builder, IntParam);
    AniEventData.AddTime(builder, Time);
    AniEventData.AddName(builder, NameOffset);
    return AniEventData.EndAniEventData(builder);
  }

  public static void StartAniEventData(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(0, NameOffset.Value, 0); }
  public static void AddTime(FlatBufferBuilder builder, float Time) { builder.AddFloat(1, Time, 0.0f); }
  public static void AddIntParam(FlatBufferBuilder builder, int IntParam) { builder.AddInt(2, IntParam, 0); }
  public static void AddFloatParam(FlatBufferBuilder builder, float FloatParam) { builder.AddFloat(3, FloatParam, 0.0f); }
  public static void AddStringParam(FlatBufferBuilder builder, StringOffset StringParamOffset) { builder.AddOffset(4, StringParamOffset.Value, 0); }
  public static Offset<FlatDataGlobal.AniEventData> EndAniEventData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.AniEventData>(o);
  }
}


}
