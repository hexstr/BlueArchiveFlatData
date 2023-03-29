// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameRhythmExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static MiniGameRhythmExcel GetRootAsMiniGameRhythmExcel(ByteBuffer _bb) { return GetRootAsMiniGameRhythmExcel(_bb, new MiniGameRhythmExcel()); }
  public static MiniGameRhythmExcel GetRootAsMiniGameRhythmExcel(ByteBuffer _bb, MiniGameRhythmExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameRhythmExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RhythmBgmId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PresetName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPresetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPresetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPresetNameArray() { return __p.__vector_as_array<byte>(8); }
  public FlatDataGlobal.Difficulty StageDifficulty { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.Difficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.Difficulty.Normal; } }
  public bool IsSpecial { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long OpenStageScoreAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MissDamage { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalHPRestoreValue { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxScore { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FeverScoreRate { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NoteScoreRate { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ComboScoreRate { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackScoreRate { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float FeverCriticalRate { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FeverAttackRate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long MaxHpScore { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RhythmFileName { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRhythmFileNameBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetRhythmFileNameBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetRhythmFileNameArray() { return __p.__vector_as_array<byte>(38); }
  public string ArtLevelSceneName { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetArtLevelSceneNameBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetArtLevelSceneNameBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetArtLevelSceneNameArray() { return __p.__vector_as_array<byte>(40); }
  public string ComboImagePath { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetComboImagePathBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetComboImagePathBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetComboImagePathArray() { return __p.__vector_as_array<byte>(42); }

  public static Offset<FlatDataGlobal.MiniGameRhythmExcel> CreateMiniGameRhythmExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long RhythmBgmId = 0,
      StringOffset PresetNameOffset = default(StringOffset),
      FlatDataGlobal.Difficulty StageDifficulty = FlatDataGlobal.Difficulty.Normal,
      bool IsSpecial = false,
      long OpenStageScoreAmount = 0,
      long MaxHp = 0,
      long MissDamage = 0,
      long CriticalHPRestoreValue = 0,
      long MaxScore = 0,
      long FeverScoreRate = 0,
      long NoteScoreRate = 0,
      long ComboScoreRate = 0,
      long AttackScoreRate = 0,
      float FeverCriticalRate = 0.0f,
      float FeverAttackRate = 0.0f,
      long MaxHpScore = 0,
      StringOffset RhythmFileNameOffset = default(StringOffset),
      StringOffset ArtLevelSceneNameOffset = default(StringOffset),
      StringOffset ComboImagePathOffset = default(StringOffset)) {
    builder.StartTable(20);
    MiniGameRhythmExcel.AddMaxHpScore(builder, MaxHpScore);
    MiniGameRhythmExcel.AddAttackScoreRate(builder, AttackScoreRate);
    MiniGameRhythmExcel.AddComboScoreRate(builder, ComboScoreRate);
    MiniGameRhythmExcel.AddNoteScoreRate(builder, NoteScoreRate);
    MiniGameRhythmExcel.AddFeverScoreRate(builder, FeverScoreRate);
    MiniGameRhythmExcel.AddMaxScore(builder, MaxScore);
    MiniGameRhythmExcel.AddCriticalHPRestoreValue(builder, CriticalHPRestoreValue);
    MiniGameRhythmExcel.AddMissDamage(builder, MissDamage);
    MiniGameRhythmExcel.AddMaxHp(builder, MaxHp);
    MiniGameRhythmExcel.AddOpenStageScoreAmount(builder, OpenStageScoreAmount);
    MiniGameRhythmExcel.AddRhythmBgmId(builder, RhythmBgmId);
    MiniGameRhythmExcel.AddUniqueId(builder, UniqueId);
    MiniGameRhythmExcel.AddComboImagePath(builder, ComboImagePathOffset);
    MiniGameRhythmExcel.AddArtLevelSceneName(builder, ArtLevelSceneNameOffset);
    MiniGameRhythmExcel.AddRhythmFileName(builder, RhythmFileNameOffset);
    MiniGameRhythmExcel.AddFeverAttackRate(builder, FeverAttackRate);
    MiniGameRhythmExcel.AddFeverCriticalRate(builder, FeverCriticalRate);
    MiniGameRhythmExcel.AddStageDifficulty(builder, StageDifficulty);
    MiniGameRhythmExcel.AddPresetName(builder, PresetNameOffset);
    MiniGameRhythmExcel.AddIsSpecial(builder, IsSpecial);
    return MiniGameRhythmExcel.EndMiniGameRhythmExcel(builder);
  }

  public static void StartMiniGameRhythmExcel(FlatBufferBuilder builder) { builder.StartTable(20); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(0, UniqueId, 0); }
  public static void AddRhythmBgmId(FlatBufferBuilder builder, long RhythmBgmId) { builder.AddLong(1, RhythmBgmId, 0); }
  public static void AddPresetName(FlatBufferBuilder builder, StringOffset PresetNameOffset) { builder.AddOffset(2, PresetNameOffset.Value, 0); }
  public static void AddStageDifficulty(FlatBufferBuilder builder, FlatDataGlobal.Difficulty StageDifficulty) { builder.AddInt(3, (int)StageDifficulty, 0); }
  public static void AddIsSpecial(FlatBufferBuilder builder, bool IsSpecial) { builder.AddBool(4, IsSpecial, false); }
  public static void AddOpenStageScoreAmount(FlatBufferBuilder builder, long OpenStageScoreAmount) { builder.AddLong(5, OpenStageScoreAmount, 0); }
  public static void AddMaxHp(FlatBufferBuilder builder, long MaxHp) { builder.AddLong(6, MaxHp, 0); }
  public static void AddMissDamage(FlatBufferBuilder builder, long MissDamage) { builder.AddLong(7, MissDamage, 0); }
  public static void AddCriticalHPRestoreValue(FlatBufferBuilder builder, long CriticalHPRestoreValue) { builder.AddLong(8, CriticalHPRestoreValue, 0); }
  public static void AddMaxScore(FlatBufferBuilder builder, long MaxScore) { builder.AddLong(9, MaxScore, 0); }
  public static void AddFeverScoreRate(FlatBufferBuilder builder, long FeverScoreRate) { builder.AddLong(10, FeverScoreRate, 0); }
  public static void AddNoteScoreRate(FlatBufferBuilder builder, long NoteScoreRate) { builder.AddLong(11, NoteScoreRate, 0); }
  public static void AddComboScoreRate(FlatBufferBuilder builder, long ComboScoreRate) { builder.AddLong(12, ComboScoreRate, 0); }
  public static void AddAttackScoreRate(FlatBufferBuilder builder, long AttackScoreRate) { builder.AddLong(13, AttackScoreRate, 0); }
  public static void AddFeverCriticalRate(FlatBufferBuilder builder, float FeverCriticalRate) { builder.AddFloat(14, FeverCriticalRate, 0.0f); }
  public static void AddFeverAttackRate(FlatBufferBuilder builder, float FeverAttackRate) { builder.AddFloat(15, FeverAttackRate, 0.0f); }
  public static void AddMaxHpScore(FlatBufferBuilder builder, long MaxHpScore) { builder.AddLong(16, MaxHpScore, 0); }
  public static void AddRhythmFileName(FlatBufferBuilder builder, StringOffset RhythmFileNameOffset) { builder.AddOffset(17, RhythmFileNameOffset.Value, 0); }
  public static void AddArtLevelSceneName(FlatBufferBuilder builder, StringOffset ArtLevelSceneNameOffset) { builder.AddOffset(18, ArtLevelSceneNameOffset.Value, 0); }
  public static void AddComboImagePath(FlatBufferBuilder builder, StringOffset ComboImagePathOffset) { builder.AddOffset(19, ComboImagePathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.MiniGameRhythmExcel> EndMiniGameRhythmExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MiniGameRhythmExcel>(o);
  }
}


}
