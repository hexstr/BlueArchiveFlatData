// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArenaLevelSectionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ArenaLevelSectionExcel GetRootAsArenaLevelSectionExcel(ByteBuffer _bb) { return GetRootAsArenaLevelSectionExcel(_bb, new ArenaLevelSectionExcel()); }
  public static ArenaLevelSectionExcel GetRootAsArenaLevelSectionExcel(ByteBuffer _bb, ArenaLevelSectionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaLevelSectionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ArenaSeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StartLevel { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LastLevel { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UserCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataGlobal.ArenaLevelSectionExcel> CreateArenaLevelSectionExcel(FlatBufferBuilder builder,
      long ArenaSeasonId = 0,
      long StartLevel = 0,
      long LastLevel = 0,
      long UserCount = 0) {
    builder.StartTable(4);
    ArenaLevelSectionExcel.AddUserCount(builder, UserCount);
    ArenaLevelSectionExcel.AddLastLevel(builder, LastLevel);
    ArenaLevelSectionExcel.AddStartLevel(builder, StartLevel);
    ArenaLevelSectionExcel.AddArenaSeasonId(builder, ArenaSeasonId);
    return ArenaLevelSectionExcel.EndArenaLevelSectionExcel(builder);
  }

  public static void StartArenaLevelSectionExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddArenaSeasonId(FlatBufferBuilder builder, long ArenaSeasonId) { builder.AddLong(0, ArenaSeasonId, 0); }
  public static void AddStartLevel(FlatBufferBuilder builder, long StartLevel) { builder.AddLong(1, StartLevel, 0); }
  public static void AddLastLevel(FlatBufferBuilder builder, long LastLevel) { builder.AddLong(2, LastLevel, 0); }
  public static void AddUserCount(FlatBufferBuilder builder, long UserCount) { builder.AddLong(3, UserCount, 0); }
  public static Offset<FlatDataGlobal.ArenaLevelSectionExcel> EndArenaLevelSectionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ArenaLevelSectionExcel>(o);
  }
}


}
