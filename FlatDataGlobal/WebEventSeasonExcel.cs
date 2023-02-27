// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WebEventSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static WebEventSeasonExcel GetRootAsWebEventSeasonExcel(ByteBuffer _bb) { return GetRootAsWebEventSeasonExcel(_bb, new WebEventSeasonExcel()); }
  public static WebEventSeasonExcel GetRootAsWebEventSeasonExcel(ByteBuffer _bb, WebEventSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WebEventSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Enabled { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string StartDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(8); }
  public string EndDate { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(10); }
  public string LobbyBannerImage { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyBannerImageBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLobbyBannerImageBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLobbyBannerImageArray() { return __p.__vector_as_array<byte>(12); }
  public string PopupTitleLocalizeKey { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPopupTitleLocalizeKeyBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetPopupTitleLocalizeKeyBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetPopupTitleLocalizeKeyArray() { return __p.__vector_as_array<byte>(14); }
  public string EventUrl { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventUrlBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetEventUrlBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetEventUrlArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatDataGlobal.WebEventSeasonExcel> CreateWebEventSeasonExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool Enabled = false,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      StringOffset LobbyBannerImageOffset = default(StringOffset),
      StringOffset PopupTitleLocalizeKeyOffset = default(StringOffset),
      StringOffset EventUrlOffset = default(StringOffset)) {
    builder.StartTable(7);
    WebEventSeasonExcel.AddId(builder, Id);
    WebEventSeasonExcel.AddEventUrl(builder, EventUrlOffset);
    WebEventSeasonExcel.AddPopupTitleLocalizeKey(builder, PopupTitleLocalizeKeyOffset);
    WebEventSeasonExcel.AddLobbyBannerImage(builder, LobbyBannerImageOffset);
    WebEventSeasonExcel.AddEndDate(builder, EndDateOffset);
    WebEventSeasonExcel.AddStartDate(builder, StartDateOffset);
    WebEventSeasonExcel.AddEnabled(builder, Enabled);
    return WebEventSeasonExcel.EndWebEventSeasonExcel(builder);
  }

  public static void StartWebEventSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEnabled(FlatBufferBuilder builder, bool Enabled) { builder.AddBool(1, Enabled, false); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset StartDateOffset) { builder.AddOffset(2, StartDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset EndDateOffset) { builder.AddOffset(3, EndDateOffset.Value, 0); }
  public static void AddLobbyBannerImage(FlatBufferBuilder builder, StringOffset LobbyBannerImageOffset) { builder.AddOffset(4, LobbyBannerImageOffset.Value, 0); }
  public static void AddPopupTitleLocalizeKey(FlatBufferBuilder builder, StringOffset PopupTitleLocalizeKeyOffset) { builder.AddOffset(5, PopupTitleLocalizeKeyOffset.Value, 0); }
  public static void AddEventUrl(FlatBufferBuilder builder, StringOffset EventUrlOffset) { builder.AddOffset(6, EventUrlOffset.Value, 0); }
  public static Offset<FlatDataGlobal.WebEventSeasonExcel> EndWebEventSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.WebEventSeasonExcel>(o);
  }
}


}
