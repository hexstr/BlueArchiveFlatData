// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CombatEmojiExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CombatEmojiExcel GetRootAsCombatEmojiExcel(ByteBuffer _bb) { return GetRootAsCombatEmojiExcel(_bb, new CombatEmojiExcel()); }
  public static CombatEmojiExcel GetRootAsCombatEmojiExcel(ByteBuffer _bb, CombatEmojiExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CombatEmojiExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.EmojiEvent Emojievent { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.EmojiEvent)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.EmojiEvent.EnterConver; } }
  public int OrderOfPriority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool EmojiDuration { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EmojiReversal { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EmojiTurnOn { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int ShowEmojiDelay { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.CombatEmojiExcel> CreateCombatEmojiExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      FlatDataJp.EmojiEvent emojievent = FlatDataJp.EmojiEvent.EnterConver,
      int OrderOfPriority = 0,
      bool EmojiDuration = false,
      bool EmojiReversal = false,
      bool EmojiTurnOn = false,
      int ShowEmojiDelay = 0) {
    builder.StartTable(7);
    CombatEmojiExcel.AddUniqueId(builder, UniqueId);
    CombatEmojiExcel.AddShowEmojiDelay(builder, ShowEmojiDelay);
    CombatEmojiExcel.AddOrderOfPriority(builder, OrderOfPriority);
    CombatEmojiExcel.AddEmojievent(builder, emojievent);
    CombatEmojiExcel.AddEmojiTurnOn(builder, EmojiTurnOn);
    CombatEmojiExcel.AddEmojiReversal(builder, EmojiReversal);
    CombatEmojiExcel.AddEmojiDuration(builder, EmojiDuration);
    return CombatEmojiExcel.EndCombatEmojiExcel(builder);
  }

  public static void StartCombatEmojiExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddEmojievent(FlatBufferBuilder builder, FlatDataJp.EmojiEvent emojievent) { builder.AddInt(1, (int)emojievent, 0); }
  public static void AddOrderOfPriority(FlatBufferBuilder builder, int OrderOfPriority) { builder.AddInt(2, OrderOfPriority, 0); }
  public static void AddEmojiDuration(FlatBufferBuilder builder, bool EmojiDuration) { builder.AddBool(3, EmojiDuration, false); }
  public static void AddEmojiReversal(FlatBufferBuilder builder, bool EmojiReversal) { builder.AddBool(4, EmojiReversal, false); }
  public static void AddEmojiTurnOn(FlatBufferBuilder builder, bool EmojiTurnOn) { builder.AddBool(5, EmojiTurnOn, false); }
  public static void AddShowEmojiDelay(FlatBufferBuilder builder, int ShowEmojiDelay) { builder.AddInt(6, ShowEmojiDelay, 0); }
  public static Offset<FlatDataJp.CombatEmojiExcel> EndCombatEmojiExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CombatEmojiExcel>(o);
  }
}


}
