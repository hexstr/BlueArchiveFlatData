// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeekDungeonGroupBuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static WeekDungeonGroupBuffExcel GetRootAsWeekDungeonGroupBuffExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonGroupBuffExcel(_bb, new WeekDungeonGroupBuffExcel()); }
  public static WeekDungeonGroupBuffExcel GetRootAsWeekDungeonGroupBuffExcel(ByteBuffer _bb, WeekDungeonGroupBuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonGroupBuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long WeekDungeonBuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.School School { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.School)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.School.None; } }
  public uint RecommandLocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint FormationLocalizeEtcId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string SkillGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillGroupIdBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSkillGroupIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSkillGroupIdArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataGlobal.WeekDungeonGroupBuffExcel> CreateWeekDungeonGroupBuffExcel(FlatBufferBuilder builder,
      long WeekDungeonBuffId = 0,
      FlatDataGlobal.School school = FlatDataGlobal.School.None,
      uint RecommandLocalizeEtcId = 0,
      uint FormationLocalizeEtcId = 0,
      StringOffset SkillGroupIdOffset = default(StringOffset)) {
    builder.StartTable(5);
    WeekDungeonGroupBuffExcel.AddWeekDungeonBuffId(builder, WeekDungeonBuffId);
    WeekDungeonGroupBuffExcel.AddSkillGroupId(builder, SkillGroupIdOffset);
    WeekDungeonGroupBuffExcel.AddFormationLocalizeEtcId(builder, FormationLocalizeEtcId);
    WeekDungeonGroupBuffExcel.AddRecommandLocalizeEtcId(builder, RecommandLocalizeEtcId);
    WeekDungeonGroupBuffExcel.AddSchool(builder, school);
    return WeekDungeonGroupBuffExcel.EndWeekDungeonGroupBuffExcel(builder);
  }

  public static void StartWeekDungeonGroupBuffExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddWeekDungeonBuffId(FlatBufferBuilder builder, long WeekDungeonBuffId) { builder.AddLong(0, WeekDungeonBuffId, 0); }
  public static void AddSchool(FlatBufferBuilder builder, FlatDataGlobal.School school) { builder.AddInt(1, (int)school, 0); }
  public static void AddRecommandLocalizeEtcId(FlatBufferBuilder builder, uint RecommandLocalizeEtcId) { builder.AddUint(2, RecommandLocalizeEtcId, 0); }
  public static void AddFormationLocalizeEtcId(FlatBufferBuilder builder, uint FormationLocalizeEtcId) { builder.AddUint(3, FormationLocalizeEtcId, 0); }
  public static void AddSkillGroupId(FlatBufferBuilder builder, StringOffset SkillGroupIdOffset) { builder.AddOffset(4, SkillGroupIdOffset.Value, 0); }
  public static Offset<FlatDataGlobal.WeekDungeonGroupBuffExcel> EndWeekDungeonGroupBuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.WeekDungeonGroupBuffExcel>(o);
  }
}


}
