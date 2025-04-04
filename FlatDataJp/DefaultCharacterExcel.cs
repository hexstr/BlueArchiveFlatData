// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DefaultCharacterExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DefaultCharacterExcel GetRootAsDefaultCharacterExcel(ByteBuffer _bb) { return GetRootAsDefaultCharacterExcel(_bb, new DefaultCharacterExcel()); }
  public static DefaultCharacterExcel GetRootAsDefaultCharacterExcel(ByteBuffer _bb, DefaultCharacterExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultCharacterExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool FavoriteCharacter { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Exp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FavorExp { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FavorRank { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StarGrade { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExSkillLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PassiveSkillLevel { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExtraPassiveSkillLevel { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CommonSkillLevel { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LeaderSkillLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.DefaultCharacterExcel> CreateDefaultCharacterExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      bool FavoriteCharacter = false,
      int Level = 0,
      int Exp = 0,
      int FavorExp = 0,
      int FavorRank = 0,
      int StarGrade = 0,
      int ExSkillLevel = 0,
      int PassiveSkillLevel = 0,
      int ExtraPassiveSkillLevel = 0,
      int CommonSkillLevel = 0,
      int LeaderSkillLevel = 0) {
    builder.StartTable(12);
    DefaultCharacterExcel.AddCharacterId(builder, CharacterId);
    DefaultCharacterExcel.AddLeaderSkillLevel(builder, LeaderSkillLevel);
    DefaultCharacterExcel.AddCommonSkillLevel(builder, CommonSkillLevel);
    DefaultCharacterExcel.AddExtraPassiveSkillLevel(builder, ExtraPassiveSkillLevel);
    DefaultCharacterExcel.AddPassiveSkillLevel(builder, PassiveSkillLevel);
    DefaultCharacterExcel.AddExSkillLevel(builder, ExSkillLevel);
    DefaultCharacterExcel.AddStarGrade(builder, StarGrade);
    DefaultCharacterExcel.AddFavorRank(builder, FavorRank);
    DefaultCharacterExcel.AddFavorExp(builder, FavorExp);
    DefaultCharacterExcel.AddExp(builder, Exp);
    DefaultCharacterExcel.AddLevel(builder, Level);
    DefaultCharacterExcel.AddFavoriteCharacter(builder, FavoriteCharacter);
    return DefaultCharacterExcel.EndDefaultCharacterExcel(builder);
  }

  public static void StartDefaultCharacterExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddFavoriteCharacter(FlatBufferBuilder builder, bool FavoriteCharacter) { builder.AddBool(1, FavoriteCharacter, false); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(3, Exp, 0); }
  public static void AddFavorExp(FlatBufferBuilder builder, int FavorExp) { builder.AddInt(4, FavorExp, 0); }
  public static void AddFavorRank(FlatBufferBuilder builder, int FavorRank) { builder.AddInt(5, FavorRank, 0); }
  public static void AddStarGrade(FlatBufferBuilder builder, int StarGrade) { builder.AddInt(6, StarGrade, 0); }
  public static void AddExSkillLevel(FlatBufferBuilder builder, int ExSkillLevel) { builder.AddInt(7, ExSkillLevel, 0); }
  public static void AddPassiveSkillLevel(FlatBufferBuilder builder, int PassiveSkillLevel) { builder.AddInt(8, PassiveSkillLevel, 0); }
  public static void AddExtraPassiveSkillLevel(FlatBufferBuilder builder, int ExtraPassiveSkillLevel) { builder.AddInt(9, ExtraPassiveSkillLevel, 0); }
  public static void AddCommonSkillLevel(FlatBufferBuilder builder, int CommonSkillLevel) { builder.AddInt(10, CommonSkillLevel, 0); }
  public static void AddLeaderSkillLevel(FlatBufferBuilder builder, int LeaderSkillLevel) { builder.AddInt(11, LeaderSkillLevel, 0); }
  public static Offset<FlatDataJp.DefaultCharacterExcel> EndDefaultCharacterExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.DefaultCharacterExcel>(o);
  }
}


}
