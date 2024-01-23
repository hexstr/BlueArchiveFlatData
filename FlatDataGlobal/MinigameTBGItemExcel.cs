// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGItemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MinigameTBGItemExcel GetRootAsMinigameTBGItemExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGItemExcel(_bb, new MinigameTBGItemExcel()); }
  public static MinigameTBGItemExcel GetRootAsMinigameTBGItemExcel(ByteBuffer _bb, MinigameTBGItemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGItemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.TBGItemType ItemType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.TBGItemType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TBGItemType.None; } }
  public FlatDataGlobal.TBGItemEffectType TBGItemEffectType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.TBGItemEffectType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.TBGItemEffectType.None; } }
  public string ItemParameter { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetItemParameterBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetItemParameterBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetItemParameterArray() { return __p.__vector_as_array<byte>(10); }
  public string LocalizeETCId { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeETCIdBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLocalizeETCIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLocalizeETCIdArray() { return __p.__vector_as_array<byte>(12); }
  public string Icon { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(14); }
  public int EncounterCount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string DiceEffectAniClip { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDiceEffectAniClipBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetDiceEffectAniClipBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetDiceEffectAniClipArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<FlatDataGlobal.MinigameTBGItemExcel> CreateMinigameTBGItemExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      FlatDataGlobal.TBGItemType ItemType = FlatDataGlobal.TBGItemType.None,
      FlatDataGlobal.TBGItemEffectType tBGItemEffectType = FlatDataGlobal.TBGItemEffectType.None,
      StringOffset ItemParameterOffset = default(StringOffset),
      StringOffset LocalizeETCIdOffset = default(StringOffset),
      StringOffset IconOffset = default(StringOffset),
      int EncounterCount = 0,
      StringOffset DiceEffectAniClipOffset = default(StringOffset)) {
    builder.StartTable(8);
    MinigameTBGItemExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGItemExcel.AddDiceEffectAniClip(builder, DiceEffectAniClipOffset);
    MinigameTBGItemExcel.AddEncounterCount(builder, EncounterCount);
    MinigameTBGItemExcel.AddIcon(builder, IconOffset);
    MinigameTBGItemExcel.AddLocalizeETCId(builder, LocalizeETCIdOffset);
    MinigameTBGItemExcel.AddItemParameter(builder, ItemParameterOffset);
    MinigameTBGItemExcel.AddTBGItemEffectType(builder, tBGItemEffectType);
    MinigameTBGItemExcel.AddItemType(builder, ItemType);
    return MinigameTBGItemExcel.EndMinigameTBGItemExcel(builder);
  }

  public static void StartMinigameTBGItemExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddItemType(FlatBufferBuilder builder, FlatDataGlobal.TBGItemType ItemType) { builder.AddInt(1, (int)ItemType, 0); }
  public static void AddTBGItemEffectType(FlatBufferBuilder builder, FlatDataGlobal.TBGItemEffectType tBGItemEffectType) { builder.AddInt(2, (int)tBGItemEffectType, 0); }
  public static void AddItemParameter(FlatBufferBuilder builder, StringOffset ItemParameterOffset) { builder.AddOffset(3, ItemParameterOffset.Value, 0); }
  public static void AddLocalizeETCId(FlatBufferBuilder builder, StringOffset LocalizeETCIdOffset) { builder.AddOffset(4, LocalizeETCIdOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(5, IconOffset.Value, 0); }
  public static void AddEncounterCount(FlatBufferBuilder builder, int EncounterCount) { builder.AddInt(6, EncounterCount, 0); }
  public static void AddDiceEffectAniClip(FlatBufferBuilder builder, StringOffset DiceEffectAniClipOffset) { builder.AddOffset(7, DiceEffectAniClipOffset.Value, 0); }
  public static Offset<FlatDataGlobal.MinigameTBGItemExcel> EndMinigameTBGItemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MinigameTBGItemExcel>(o);
  }
}


}
