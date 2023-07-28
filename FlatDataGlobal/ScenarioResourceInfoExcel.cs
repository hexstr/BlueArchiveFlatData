// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioResourceInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ScenarioResourceInfoExcel GetRootAsScenarioResourceInfoExcel(ByteBuffer _bb) { return GetRootAsScenarioResourceInfoExcel(_bb, new ScenarioResourceInfoExcel()); }
  public static ScenarioResourceInfoExcel GetRootAsScenarioResourceInfoExcel(ByteBuffer _bb, ScenarioResourceInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioResourceInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string VideoName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVideoNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetVideoNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetVideoNameArray() { return __p.__vector_as_array<byte>(8); }
  public string BgmId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(10); }
  public string AudioName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetAudioNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetAudioNameArray() { return __p.__vector_as_array<byte>(12); }
  public string SpinePath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpinePathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSpinePathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSpinePathArray() { return __p.__vector_as_array<byte>(14); }
  public int Ratio { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string LobbyAniPath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyAniPathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetLobbyAniPathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetLobbyAniPathArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataGlobal.ScenarioResourceInfoExcel> CreateScenarioResourceInfoExcel(FlatBufferBuilder builder,
      long Id = 0,
      long ScenarioModeId = 0,
      StringOffset VideoNameOffset = default(StringOffset),
      StringOffset BgmIdOffset = default(StringOffset),
      StringOffset AudioNameOffset = default(StringOffset),
      StringOffset SpinePathOffset = default(StringOffset),
      int Ratio = 0,
      StringOffset LobbyAniPathOffset = default(StringOffset)) {
    builder.StartTable(8);
    ScenarioResourceInfoExcel.AddScenarioModeId(builder, ScenarioModeId);
    ScenarioResourceInfoExcel.AddId(builder, Id);
    ScenarioResourceInfoExcel.AddLobbyAniPath(builder, LobbyAniPathOffset);
    ScenarioResourceInfoExcel.AddRatio(builder, Ratio);
    ScenarioResourceInfoExcel.AddSpinePath(builder, SpinePathOffset);
    ScenarioResourceInfoExcel.AddAudioName(builder, AudioNameOffset);
    ScenarioResourceInfoExcel.AddBgmId(builder, BgmIdOffset);
    ScenarioResourceInfoExcel.AddVideoName(builder, VideoNameOffset);
    return ScenarioResourceInfoExcel.EndScenarioResourceInfoExcel(builder);
  }

  public static void StartScenarioResourceInfoExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, long ScenarioModeId) { builder.AddLong(1, ScenarioModeId, 0); }
  public static void AddVideoName(FlatBufferBuilder builder, StringOffset VideoNameOffset) { builder.AddOffset(2, VideoNameOffset.Value, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset BgmIdOffset) { builder.AddOffset(3, BgmIdOffset.Value, 0); }
  public static void AddAudioName(FlatBufferBuilder builder, StringOffset AudioNameOffset) { builder.AddOffset(4, AudioNameOffset.Value, 0); }
  public static void AddSpinePath(FlatBufferBuilder builder, StringOffset SpinePathOffset) { builder.AddOffset(5, SpinePathOffset.Value, 0); }
  public static void AddRatio(FlatBufferBuilder builder, int Ratio) { builder.AddInt(6, Ratio, 0); }
  public static void AddLobbyAniPath(FlatBufferBuilder builder, StringOffset LobbyAniPathOffset) { builder.AddOffset(7, LobbyAniPathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.ScenarioResourceInfoExcel> EndScenarioResourceInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ScenarioResourceInfoExcel>(o);
  }
}


}
