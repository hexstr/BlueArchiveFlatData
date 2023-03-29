// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SkillExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static SkillExcel GetRootAsSkillExcel(ByteBuffer _bb) { return GetRootAsSkillExcel(_bb, new SkillExcel()); }
  public static SkillExcel GetRootAsSkillExcel(ByteBuffer _bb, SkillExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SkillExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeSkillId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroupIdBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetGroupIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetGroupIdArray() { return __p.__vector_as_array<byte>(8); }
  public int Level { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SkillCost { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExtraSkillCost { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EnemySkillCost { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExtraEnemySkillCost { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NPCSkillCost { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExtraNPCSkillCost { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.BulletType BulletType { get { int o = __p.__offset(24); return o != 0 ? (FlatDataJp.BulletType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.BulletType.Normal; } }
  public int StartCoolTime { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CoolTime { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EnemyStartCoolTime { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EnemyCoolTime { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NPCStartCoolTime { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NPCCoolTime { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UseAtg { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RequireCharacterLevel { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long RequireLevelUpMaterial { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string IconName { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconNameBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetIconNameBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetIconNameArray() { return __p.__vector_as_array<byte>(44); }
  public bool IsShowInfo { get { int o = __p.__offset(46); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsShowSpeechbubble { get { int o = __p.__offset(48); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.SkillExcel> CreateSkillExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint LocalizeSkillId = 0,
      StringOffset GroupIdOffset = default(StringOffset),
      int Level = 0,
      int SkillCost = 0,
      int ExtraSkillCost = 0,
      int EnemySkillCost = 0,
      int ExtraEnemySkillCost = 0,
      int NPCSkillCost = 0,
      int ExtraNPCSkillCost = 0,
      FlatDataJp.BulletType BulletType = FlatDataJp.BulletType.Normal,
      int StartCoolTime = 0,
      int CoolTime = 0,
      int EnemyStartCoolTime = 0,
      int EnemyCoolTime = 0,
      int NPCStartCoolTime = 0,
      int NPCCoolTime = 0,
      int UseAtg = 0,
      int RequireCharacterLevel = 0,
      long RequireLevelUpMaterial = 0,
      StringOffset IconNameOffset = default(StringOffset),
      bool IsShowInfo = false,
      bool IsShowSpeechbubble = false) {
    builder.StartTable(23);
    SkillExcel.AddRequireLevelUpMaterial(builder, RequireLevelUpMaterial);
    SkillExcel.AddId(builder, Id);
    SkillExcel.AddIconName(builder, IconNameOffset);
    SkillExcel.AddRequireCharacterLevel(builder, RequireCharacterLevel);
    SkillExcel.AddUseAtg(builder, UseAtg);
    SkillExcel.AddNPCCoolTime(builder, NPCCoolTime);
    SkillExcel.AddNPCStartCoolTime(builder, NPCStartCoolTime);
    SkillExcel.AddEnemyCoolTime(builder, EnemyCoolTime);
    SkillExcel.AddEnemyStartCoolTime(builder, EnemyStartCoolTime);
    SkillExcel.AddCoolTime(builder, CoolTime);
    SkillExcel.AddStartCoolTime(builder, StartCoolTime);
    SkillExcel.AddBulletType(builder, BulletType);
    SkillExcel.AddExtraNPCSkillCost(builder, ExtraNPCSkillCost);
    SkillExcel.AddNPCSkillCost(builder, NPCSkillCost);
    SkillExcel.AddExtraEnemySkillCost(builder, ExtraEnemySkillCost);
    SkillExcel.AddEnemySkillCost(builder, EnemySkillCost);
    SkillExcel.AddExtraSkillCost(builder, ExtraSkillCost);
    SkillExcel.AddSkillCost(builder, SkillCost);
    SkillExcel.AddLevel(builder, Level);
    SkillExcel.AddGroupId(builder, GroupIdOffset);
    SkillExcel.AddLocalizeSkillId(builder, LocalizeSkillId);
    SkillExcel.AddIsShowSpeechbubble(builder, IsShowSpeechbubble);
    SkillExcel.AddIsShowInfo(builder, IsShowInfo);
    return SkillExcel.EndSkillExcel(builder);
  }

  public static void StartSkillExcel(FlatBufferBuilder builder) { builder.StartTable(23); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddLocalizeSkillId(FlatBufferBuilder builder, uint LocalizeSkillId) { builder.AddUint(1, LocalizeSkillId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, StringOffset GroupIdOffset) { builder.AddOffset(2, GroupIdOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(3, Level, 0); }
  public static void AddSkillCost(FlatBufferBuilder builder, int SkillCost) { builder.AddInt(4, SkillCost, 0); }
  public static void AddExtraSkillCost(FlatBufferBuilder builder, int ExtraSkillCost) { builder.AddInt(5, ExtraSkillCost, 0); }
  public static void AddEnemySkillCost(FlatBufferBuilder builder, int EnemySkillCost) { builder.AddInt(6, EnemySkillCost, 0); }
  public static void AddExtraEnemySkillCost(FlatBufferBuilder builder, int ExtraEnemySkillCost) { builder.AddInt(7, ExtraEnemySkillCost, 0); }
  public static void AddNPCSkillCost(FlatBufferBuilder builder, int NPCSkillCost) { builder.AddInt(8, NPCSkillCost, 0); }
  public static void AddExtraNPCSkillCost(FlatBufferBuilder builder, int ExtraNPCSkillCost) { builder.AddInt(9, ExtraNPCSkillCost, 0); }
  public static void AddBulletType(FlatBufferBuilder builder, FlatDataJp.BulletType BulletType) { builder.AddInt(10, (int)BulletType, 0); }
  public static void AddStartCoolTime(FlatBufferBuilder builder, int StartCoolTime) { builder.AddInt(11, StartCoolTime, 0); }
  public static void AddCoolTime(FlatBufferBuilder builder, int CoolTime) { builder.AddInt(12, CoolTime, 0); }
  public static void AddEnemyStartCoolTime(FlatBufferBuilder builder, int EnemyStartCoolTime) { builder.AddInt(13, EnemyStartCoolTime, 0); }
  public static void AddEnemyCoolTime(FlatBufferBuilder builder, int EnemyCoolTime) { builder.AddInt(14, EnemyCoolTime, 0); }
  public static void AddNPCStartCoolTime(FlatBufferBuilder builder, int NPCStartCoolTime) { builder.AddInt(15, NPCStartCoolTime, 0); }
  public static void AddNPCCoolTime(FlatBufferBuilder builder, int NPCCoolTime) { builder.AddInt(16, NPCCoolTime, 0); }
  public static void AddUseAtg(FlatBufferBuilder builder, int UseAtg) { builder.AddInt(17, UseAtg, 0); }
  public static void AddRequireCharacterLevel(FlatBufferBuilder builder, int RequireCharacterLevel) { builder.AddInt(18, RequireCharacterLevel, 0); }
  public static void AddRequireLevelUpMaterial(FlatBufferBuilder builder, long RequireLevelUpMaterial) { builder.AddLong(19, RequireLevelUpMaterial, 0); }
  public static void AddIconName(FlatBufferBuilder builder, StringOffset IconNameOffset) { builder.AddOffset(20, IconNameOffset.Value, 0); }
  public static void AddIsShowInfo(FlatBufferBuilder builder, bool IsShowInfo) { builder.AddBool(21, IsShowInfo, false); }
  public static void AddIsShowSpeechbubble(FlatBufferBuilder builder, bool IsShowSpeechbubble) { builder.AddBool(22, IsShowSpeechbubble, false); }
  public static Offset<FlatDataJp.SkillExcel> EndSkillExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.SkillExcel>(o);
  }
}


}
