// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static EventContentSeasonExcel GetRootAsEventContentSeasonExcel(ByteBuffer _bb) { return GetRootAsEventContentSeasonExcel(_bb, new EventContentSeasonExcel()); }
  public static EventContentSeasonExcel GetRootAsEventContentSeasonExcel(ByteBuffer _bb, EventContentSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OriginalEventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsReturn { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Name { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(10); }
  public FlatDataGlobal.EventContentType EventContentType { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentType.Stage; } }
  public FlatDataGlobal.OpenConditionContent OpenConditionContent { get { int o = __p.__offset(14); return o != 0 ? (FlatDataGlobal.OpenConditionContent)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.OpenConditionContent.Shop; } }
  public bool EventDisplay { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int IconOrder { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataGlobal.SubEventType SubEventType { get { int o = __p.__offset(20); return o != 0 ? (FlatDataGlobal.SubEventType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.SubEventType.None; } }
  public bool SubEvent { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long EventItemId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MainEventId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventChangeOpenCondition { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BeforehandExposedTime { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforehandExposedTimeBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetBeforehandExposedTimeBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetBeforehandExposedTimeArray() { return __p.__vector_as_array<byte>(30); }
  public string EventContentOpenTime { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventContentOpenTimeBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetEventContentOpenTimeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetEventContentOpenTimeArray() { return __p.__vector_as_array<byte>(32); }
  public string EventContentCloseTime { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventContentCloseTimeBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetEventContentCloseTimeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetEventContentCloseTimeArray() { return __p.__vector_as_array<byte>(34); }
  public string ExtensionTime { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExtensionTimeBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetExtensionTimeBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetExtensionTimeArray() { return __p.__vector_as_array<byte>(36); }
  public string MainIconParcelPath { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMainIconParcelPathBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetMainIconParcelPathBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetMainIconParcelPathArray() { return __p.__vector_as_array<byte>(38); }
  public string SubIconParcelPath { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubIconParcelPathBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetSubIconParcelPathBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetSubIconParcelPathArray() { return __p.__vector_as_array<byte>(40); }
  public string BeforehandBgImagePath { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBeforehandBgImagePathBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetBeforehandBgImagePathBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetBeforehandBgImagePathArray() { return __p.__vector_as_array<byte>(42); }
  public long MinigamePrologScenarioGroupId { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BeforehandScenarioGroupId(int j) { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BeforehandScenarioGroupIdLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBeforehandScenarioGroupIdBytes() { return __p.__vector_as_span<long>(46, 8); }
#else
  public ArraySegment<byte>? GetBeforehandScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public long[] GetBeforehandScenarioGroupIdArray() { return __p.__vector_as_array<long>(46); }
  public string MainBannerImagePath { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMainBannerImagePathBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetMainBannerImagePathBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetMainBannerImagePathArray() { return __p.__vector_as_array<byte>(48); }
  public string MainBgImagePath { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMainBgImagePathBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetMainBgImagePathBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetMainBgImagePathArray() { return __p.__vector_as_array<byte>(50); }
  public long ShiftTriggerStageId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ShiftMainBgImagePath { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShiftMainBgImagePathBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetShiftMainBgImagePathBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetShiftMainBgImagePathArray() { return __p.__vector_as_array<byte>(54); }
  public string MinigameLobbyPrefabName { get { int o = __p.__offset(56); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMinigameLobbyPrefabNameBytes() { return __p.__vector_as_span<byte>(56, 1); }
#else
  public ArraySegment<byte>? GetMinigameLobbyPrefabNameBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public byte[] GetMinigameLobbyPrefabNameArray() { return __p.__vector_as_array<byte>(56); }
  public string MinigameVictoryPrefabName { get { int o = __p.__offset(58); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMinigameVictoryPrefabNameBytes() { return __p.__vector_as_span<byte>(58, 1); }
#else
  public ArraySegment<byte>? GetMinigameVictoryPrefabNameBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public byte[] GetMinigameVictoryPrefabNameArray() { return __p.__vector_as_array<byte>(58); }
  public string MinigameMissionBgPrefabName { get { int o = __p.__offset(60); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMinigameMissionBgPrefabNameBytes() { return __p.__vector_as_span<byte>(60, 1); }
#else
  public ArraySegment<byte>? GetMinigameMissionBgPrefabNameBytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public byte[] GetMinigameMissionBgPrefabNameArray() { return __p.__vector_as_array<byte>(60); }
  public string CardBgImagePath { get { int o = __p.__offset(62); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCardBgImagePathBytes() { return __p.__vector_as_span<byte>(62, 1); }
#else
  public ArraySegment<byte>? GetCardBgImagePathBytes() { return __p.__vector_as_arraysegment(62); }
#endif
  public byte[] GetCardBgImagePathArray() { return __p.__vector_as_array<byte>(62); }
  public bool EventAssist { get { int o = __p.__offset(64); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.EventContentReleaseType EventContentReleaseType { get { int o = __p.__offset(66); return o != 0 ? (FlatDataGlobal.EventContentReleaseType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.EventContentReleaseType.None; } }
  public long EventContentStageRewardIdPermanent { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.RewardTag RewardTagPermanent { get { int o = __p.__offset(70); return o != 0 ? (FlatDataGlobal.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.RewardTag.Default; } }
  public long MiniEventShortCutScenarioModeId { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.EventContentSeasonExcel> CreateEventContentSeasonExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long OriginalEventContentId = 0,
      bool IsReturn = false,
      StringOffset NameOffset = default(StringOffset),
      FlatDataGlobal.EventContentType eventContentType = FlatDataGlobal.EventContentType.Stage,
      FlatDataGlobal.OpenConditionContent openConditionContent = FlatDataGlobal.OpenConditionContent.Shop,
      bool EventDisplay = false,
      int IconOrder = 0,
      FlatDataGlobal.SubEventType subEventType = FlatDataGlobal.SubEventType.None,
      bool SubEvent = false,
      long EventItemId = 0,
      long MainEventId = 0,
      long EventChangeOpenCondition = 0,
      StringOffset BeforehandExposedTimeOffset = default(StringOffset),
      StringOffset EventContentOpenTimeOffset = default(StringOffset),
      StringOffset EventContentCloseTimeOffset = default(StringOffset),
      StringOffset ExtensionTimeOffset = default(StringOffset),
      StringOffset MainIconParcelPathOffset = default(StringOffset),
      StringOffset SubIconParcelPathOffset = default(StringOffset),
      StringOffset BeforehandBgImagePathOffset = default(StringOffset),
      long MinigamePrologScenarioGroupId = 0,
      VectorOffset BeforehandScenarioGroupIdOffset = default(VectorOffset),
      StringOffset MainBannerImagePathOffset = default(StringOffset),
      StringOffset MainBgImagePathOffset = default(StringOffset),
      long ShiftTriggerStageId = 0,
      StringOffset ShiftMainBgImagePathOffset = default(StringOffset),
      StringOffset MinigameLobbyPrefabNameOffset = default(StringOffset),
      StringOffset MinigameVictoryPrefabNameOffset = default(StringOffset),
      StringOffset MinigameMissionBgPrefabNameOffset = default(StringOffset),
      StringOffset CardBgImagePathOffset = default(StringOffset),
      bool EventAssist = false,
      FlatDataGlobal.EventContentReleaseType eventContentReleaseType = FlatDataGlobal.EventContentReleaseType.None,
      long EventContentStageRewardIdPermanent = 0,
      FlatDataGlobal.RewardTag RewardTagPermanent = FlatDataGlobal.RewardTag.Default,
      long MiniEventShortCutScenarioModeId = 0) {
    builder.StartTable(35);
    EventContentSeasonExcel.AddMiniEventShortCutScenarioModeId(builder, MiniEventShortCutScenarioModeId);
    EventContentSeasonExcel.AddEventContentStageRewardIdPermanent(builder, EventContentStageRewardIdPermanent);
    EventContentSeasonExcel.AddShiftTriggerStageId(builder, ShiftTriggerStageId);
    EventContentSeasonExcel.AddMinigamePrologScenarioGroupId(builder, MinigamePrologScenarioGroupId);
    EventContentSeasonExcel.AddEventChangeOpenCondition(builder, EventChangeOpenCondition);
    EventContentSeasonExcel.AddMainEventId(builder, MainEventId);
    EventContentSeasonExcel.AddEventItemId(builder, EventItemId);
    EventContentSeasonExcel.AddOriginalEventContentId(builder, OriginalEventContentId);
    EventContentSeasonExcel.AddEventContentId(builder, EventContentId);
    EventContentSeasonExcel.AddRewardTagPermanent(builder, RewardTagPermanent);
    EventContentSeasonExcel.AddEventContentReleaseType(builder, eventContentReleaseType);
    EventContentSeasonExcel.AddCardBgImagePath(builder, CardBgImagePathOffset);
    EventContentSeasonExcel.AddMinigameMissionBgPrefabName(builder, MinigameMissionBgPrefabNameOffset);
    EventContentSeasonExcel.AddMinigameVictoryPrefabName(builder, MinigameVictoryPrefabNameOffset);
    EventContentSeasonExcel.AddMinigameLobbyPrefabName(builder, MinigameLobbyPrefabNameOffset);
    EventContentSeasonExcel.AddShiftMainBgImagePath(builder, ShiftMainBgImagePathOffset);
    EventContentSeasonExcel.AddMainBgImagePath(builder, MainBgImagePathOffset);
    EventContentSeasonExcel.AddMainBannerImagePath(builder, MainBannerImagePathOffset);
    EventContentSeasonExcel.AddBeforehandScenarioGroupId(builder, BeforehandScenarioGroupIdOffset);
    EventContentSeasonExcel.AddBeforehandBgImagePath(builder, BeforehandBgImagePathOffset);
    EventContentSeasonExcel.AddSubIconParcelPath(builder, SubIconParcelPathOffset);
    EventContentSeasonExcel.AddMainIconParcelPath(builder, MainIconParcelPathOffset);
    EventContentSeasonExcel.AddExtensionTime(builder, ExtensionTimeOffset);
    EventContentSeasonExcel.AddEventContentCloseTime(builder, EventContentCloseTimeOffset);
    EventContentSeasonExcel.AddEventContentOpenTime(builder, EventContentOpenTimeOffset);
    EventContentSeasonExcel.AddBeforehandExposedTime(builder, BeforehandExposedTimeOffset);
    EventContentSeasonExcel.AddSubEventType(builder, subEventType);
    EventContentSeasonExcel.AddIconOrder(builder, IconOrder);
    EventContentSeasonExcel.AddOpenConditionContent(builder, openConditionContent);
    EventContentSeasonExcel.AddEventContentType(builder, eventContentType);
    EventContentSeasonExcel.AddName(builder, NameOffset);
    EventContentSeasonExcel.AddEventAssist(builder, EventAssist);
    EventContentSeasonExcel.AddSubEvent(builder, SubEvent);
    EventContentSeasonExcel.AddEventDisplay(builder, EventDisplay);
    EventContentSeasonExcel.AddIsReturn(builder, IsReturn);
    return EventContentSeasonExcel.EndEventContentSeasonExcel(builder);
  }

  public static void StartEventContentSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(35); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(0, EventContentId, 0); }
  public static void AddOriginalEventContentId(FlatBufferBuilder builder, long OriginalEventContentId) { builder.AddLong(1, OriginalEventContentId, 0); }
  public static void AddIsReturn(FlatBufferBuilder builder, bool IsReturn) { builder.AddBool(2, IsReturn, false); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(3, NameOffset.Value, 0); }
  public static void AddEventContentType(FlatBufferBuilder builder, FlatDataGlobal.EventContentType eventContentType) { builder.AddInt(4, (int)eventContentType, 0); }
  public static void AddOpenConditionContent(FlatBufferBuilder builder, FlatDataGlobal.OpenConditionContent openConditionContent) { builder.AddInt(5, (int)openConditionContent, 0); }
  public static void AddEventDisplay(FlatBufferBuilder builder, bool EventDisplay) { builder.AddBool(6, EventDisplay, false); }
  public static void AddIconOrder(FlatBufferBuilder builder, int IconOrder) { builder.AddInt(7, IconOrder, 0); }
  public static void AddSubEventType(FlatBufferBuilder builder, FlatDataGlobal.SubEventType subEventType) { builder.AddInt(8, (int)subEventType, 0); }
  public static void AddSubEvent(FlatBufferBuilder builder, bool SubEvent) { builder.AddBool(9, SubEvent, false); }
  public static void AddEventItemId(FlatBufferBuilder builder, long EventItemId) { builder.AddLong(10, EventItemId, 0); }
  public static void AddMainEventId(FlatBufferBuilder builder, long MainEventId) { builder.AddLong(11, MainEventId, 0); }
  public static void AddEventChangeOpenCondition(FlatBufferBuilder builder, long EventChangeOpenCondition) { builder.AddLong(12, EventChangeOpenCondition, 0); }
  public static void AddBeforehandExposedTime(FlatBufferBuilder builder, StringOffset BeforehandExposedTimeOffset) { builder.AddOffset(13, BeforehandExposedTimeOffset.Value, 0); }
  public static void AddEventContentOpenTime(FlatBufferBuilder builder, StringOffset EventContentOpenTimeOffset) { builder.AddOffset(14, EventContentOpenTimeOffset.Value, 0); }
  public static void AddEventContentCloseTime(FlatBufferBuilder builder, StringOffset EventContentCloseTimeOffset) { builder.AddOffset(15, EventContentCloseTimeOffset.Value, 0); }
  public static void AddExtensionTime(FlatBufferBuilder builder, StringOffset ExtensionTimeOffset) { builder.AddOffset(16, ExtensionTimeOffset.Value, 0); }
  public static void AddMainIconParcelPath(FlatBufferBuilder builder, StringOffset MainIconParcelPathOffset) { builder.AddOffset(17, MainIconParcelPathOffset.Value, 0); }
  public static void AddSubIconParcelPath(FlatBufferBuilder builder, StringOffset SubIconParcelPathOffset) { builder.AddOffset(18, SubIconParcelPathOffset.Value, 0); }
  public static void AddBeforehandBgImagePath(FlatBufferBuilder builder, StringOffset BeforehandBgImagePathOffset) { builder.AddOffset(19, BeforehandBgImagePathOffset.Value, 0); }
  public static void AddMinigamePrologScenarioGroupId(FlatBufferBuilder builder, long MinigamePrologScenarioGroupId) { builder.AddLong(20, MinigamePrologScenarioGroupId, 0); }
  public static void AddBeforehandScenarioGroupId(FlatBufferBuilder builder, VectorOffset BeforehandScenarioGroupIdOffset) { builder.AddOffset(21, BeforehandScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateBeforehandScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBeforehandScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBeforehandScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBeforehandScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBeforehandScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMainBannerImagePath(FlatBufferBuilder builder, StringOffset MainBannerImagePathOffset) { builder.AddOffset(22, MainBannerImagePathOffset.Value, 0); }
  public static void AddMainBgImagePath(FlatBufferBuilder builder, StringOffset MainBgImagePathOffset) { builder.AddOffset(23, MainBgImagePathOffset.Value, 0); }
  public static void AddShiftTriggerStageId(FlatBufferBuilder builder, long ShiftTriggerStageId) { builder.AddLong(24, ShiftTriggerStageId, 0); }
  public static void AddShiftMainBgImagePath(FlatBufferBuilder builder, StringOffset ShiftMainBgImagePathOffset) { builder.AddOffset(25, ShiftMainBgImagePathOffset.Value, 0); }
  public static void AddMinigameLobbyPrefabName(FlatBufferBuilder builder, StringOffset MinigameLobbyPrefabNameOffset) { builder.AddOffset(26, MinigameLobbyPrefabNameOffset.Value, 0); }
  public static void AddMinigameVictoryPrefabName(FlatBufferBuilder builder, StringOffset MinigameVictoryPrefabNameOffset) { builder.AddOffset(27, MinigameVictoryPrefabNameOffset.Value, 0); }
  public static void AddMinigameMissionBgPrefabName(FlatBufferBuilder builder, StringOffset MinigameMissionBgPrefabNameOffset) { builder.AddOffset(28, MinigameMissionBgPrefabNameOffset.Value, 0); }
  public static void AddCardBgImagePath(FlatBufferBuilder builder, StringOffset CardBgImagePathOffset) { builder.AddOffset(29, CardBgImagePathOffset.Value, 0); }
  public static void AddEventAssist(FlatBufferBuilder builder, bool EventAssist) { builder.AddBool(30, EventAssist, false); }
  public static void AddEventContentReleaseType(FlatBufferBuilder builder, FlatDataGlobal.EventContentReleaseType eventContentReleaseType) { builder.AddInt(31, (int)eventContentReleaseType, 0); }
  public static void AddEventContentStageRewardIdPermanent(FlatBufferBuilder builder, long EventContentStageRewardIdPermanent) { builder.AddLong(32, EventContentStageRewardIdPermanent, 0); }
  public static void AddRewardTagPermanent(FlatBufferBuilder builder, FlatDataGlobal.RewardTag RewardTagPermanent) { builder.AddInt(33, (int)RewardTagPermanent, 0); }
  public static void AddMiniEventShortCutScenarioModeId(FlatBufferBuilder builder, long MiniEventShortCutScenarioModeId) { builder.AddLong(34, MiniEventShortCutScenarioModeId, 0); }
  public static Offset<FlatDataGlobal.EventContentSeasonExcel> EndEventContentSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.EventContentSeasonExcel>(o);
  }
}


}
