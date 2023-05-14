// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct OpenConditionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static OpenConditionExcel GetRootAsOpenConditionExcel(ByteBuffer _bb) { return GetRootAsOpenConditionExcel(_bb, new OpenConditionExcel()); }
  public static OpenConditionExcel GetRootAsOpenConditionExcel(ByteBuffer _bb, OpenConditionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OpenConditionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.OpenConditionContent OpenConditionContentType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.OpenConditionContent)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.OpenConditionContent.Shop; } }
  public string LockUI(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LockUILength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long ShortcutPopupPriority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ShortcutUIName(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUINameLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int ShortcutParam { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Scene { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSceneBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSceneBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSceneArray() { return __p.__vector_as_array<byte>(14); }
  public bool HideWhenLocked { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CampaignStageId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.MultipleConditionCheckType Multipleconditionchecktype { get { int o = __p.__offset(24); return o != 0 ? (FlatDataJp.MultipleConditionCheckType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.MultipleConditionCheckType.And; } }
  public FlatDataJp.WeekDay OpenDayOfWeek { get { int o = __p.__offset(26); return o != 0 ? (FlatDataJp.WeekDay)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.WeekDay.Sunday; } }
  public long OpenHour { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.WeekDay CloseDayOfWeek { get { int o = __p.__offset(30); return o != 0 ? (FlatDataJp.WeekDay)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.WeekDay.Sunday; } }
  public long CloseHour { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CafeRank { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ContentsOpenShow { get { int o = __p.__offset(36); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ContentsOpenShortcutUI { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetContentsOpenShortcutUIBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetContentsOpenShortcutUIBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetContentsOpenShortcutUIArray() { return __p.__vector_as_array<byte>(38); }

  public static Offset<FlatDataJp.OpenConditionExcel> CreateOpenConditionExcel(FlatBufferBuilder builder,
      FlatDataJp.OpenConditionContent OpenConditionContentType = FlatDataJp.OpenConditionContent.Shop,
      VectorOffset LockUIOffset = default(VectorOffset),
      long ShortcutPopupPriority = 0,
      VectorOffset ShortcutUINameOffset = default(VectorOffset),
      int ShortcutParam = 0,
      StringOffset SceneOffset = default(StringOffset),
      bool HideWhenLocked = false,
      long AccountLevel = 0,
      long ScenarioModeId = 0,
      long CampaignStageId = 0,
      FlatDataJp.MultipleConditionCheckType multipleconditionchecktype = FlatDataJp.MultipleConditionCheckType.And,
      FlatDataJp.WeekDay OpenDayOfWeek = FlatDataJp.WeekDay.Sunday,
      long OpenHour = 0,
      FlatDataJp.WeekDay CloseDayOfWeek = FlatDataJp.WeekDay.Sunday,
      long CloseHour = 0,
      long CafeRank = 0,
      bool ContentsOpenShow = false,
      StringOffset ContentsOpenShortcutUIOffset = default(StringOffset)) {
    builder.StartTable(18);
    OpenConditionExcel.AddCafeRank(builder, CafeRank);
    OpenConditionExcel.AddCloseHour(builder, CloseHour);
    OpenConditionExcel.AddOpenHour(builder, OpenHour);
    OpenConditionExcel.AddCampaignStageId(builder, CampaignStageId);
    OpenConditionExcel.AddScenarioModeId(builder, ScenarioModeId);
    OpenConditionExcel.AddAccountLevel(builder, AccountLevel);
    OpenConditionExcel.AddShortcutPopupPriority(builder, ShortcutPopupPriority);
    OpenConditionExcel.AddContentsOpenShortcutUI(builder, ContentsOpenShortcutUIOffset);
    OpenConditionExcel.AddCloseDayOfWeek(builder, CloseDayOfWeek);
    OpenConditionExcel.AddOpenDayOfWeek(builder, OpenDayOfWeek);
    OpenConditionExcel.AddMultipleconditionchecktype(builder, multipleconditionchecktype);
    OpenConditionExcel.AddScene(builder, SceneOffset);
    OpenConditionExcel.AddShortcutParam(builder, ShortcutParam);
    OpenConditionExcel.AddShortcutUIName(builder, ShortcutUINameOffset);
    OpenConditionExcel.AddLockUI(builder, LockUIOffset);
    OpenConditionExcel.AddOpenConditionContentType(builder, OpenConditionContentType);
    OpenConditionExcel.AddContentsOpenShow(builder, ContentsOpenShow);
    OpenConditionExcel.AddHideWhenLocked(builder, HideWhenLocked);
    return OpenConditionExcel.EndOpenConditionExcel(builder);
  }

  public static void StartOpenConditionExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddOpenConditionContentType(FlatBufferBuilder builder, FlatDataJp.OpenConditionContent OpenConditionContentType) { builder.AddInt(0, (int)OpenConditionContentType, 0); }
  public static void AddLockUI(FlatBufferBuilder builder, VectorOffset LockUIOffset) { builder.AddOffset(1, LockUIOffset.Value, 0); }
  public static VectorOffset CreateLockUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLockUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutPopupPriority(FlatBufferBuilder builder, long ShortcutPopupPriority) { builder.AddLong(2, ShortcutPopupPriority, 0); }
  public static void AddShortcutUIName(FlatBufferBuilder builder, VectorOffset ShortcutUINameOffset) { builder.AddOffset(3, ShortcutUINameOffset.Value, 0); }
  public static VectorOffset CreateShortcutUINameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUINameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutParam(FlatBufferBuilder builder, int ShortcutParam) { builder.AddInt(4, ShortcutParam, 0); }
  public static void AddScene(FlatBufferBuilder builder, StringOffset SceneOffset) { builder.AddOffset(5, SceneOffset.Value, 0); }
  public static void AddHideWhenLocked(FlatBufferBuilder builder, bool HideWhenLocked) { builder.AddBool(6, HideWhenLocked, false); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long AccountLevel) { builder.AddLong(7, AccountLevel, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, long ScenarioModeId) { builder.AddLong(8, ScenarioModeId, 0); }
  public static void AddCampaignStageId(FlatBufferBuilder builder, long CampaignStageId) { builder.AddLong(9, CampaignStageId, 0); }
  public static void AddMultipleconditionchecktype(FlatBufferBuilder builder, FlatDataJp.MultipleConditionCheckType multipleconditionchecktype) { builder.AddInt(10, (int)multipleconditionchecktype, 0); }
  public static void AddOpenDayOfWeek(FlatBufferBuilder builder, FlatDataJp.WeekDay OpenDayOfWeek) { builder.AddInt(11, (int)OpenDayOfWeek, 0); }
  public static void AddOpenHour(FlatBufferBuilder builder, long OpenHour) { builder.AddLong(12, OpenHour, 0); }
  public static void AddCloseDayOfWeek(FlatBufferBuilder builder, FlatDataJp.WeekDay CloseDayOfWeek) { builder.AddInt(13, (int)CloseDayOfWeek, 0); }
  public static void AddCloseHour(FlatBufferBuilder builder, long CloseHour) { builder.AddLong(14, CloseHour, 0); }
  public static void AddCafeRank(FlatBufferBuilder builder, long CafeRank) { builder.AddLong(15, CafeRank, 0); }
  public static void AddContentsOpenShow(FlatBufferBuilder builder, bool ContentsOpenShow) { builder.AddBool(16, ContentsOpenShow, false); }
  public static void AddContentsOpenShortcutUI(FlatBufferBuilder builder, StringOffset ContentsOpenShortcutUIOffset) { builder.AddOffset(17, ContentsOpenShortcutUIOffset.Value, 0); }
  public static Offset<FlatDataJp.OpenConditionExcel> EndOpenConditionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.OpenConditionExcel>(o);
  }
}


}
