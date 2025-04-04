// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AcademyTicketExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static AcademyTicketExcel GetRootAsAcademyTicketExcel(ByteBuffer _bb) { return GetRootAsAcademyTicketExcel(_bb, new AcademyTicketExcel()); }
  public static AcademyTicketExcel GetRootAsAcademyTicketExcel(ByteBuffer _bb, AcademyTicketExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyTicketExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long LocationRankSum { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScheduleTicktetMax { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.AcademyTicketExcel> CreateAcademyTicketExcel(FlatBufferBuilder builder,
      long LocationRankSum = 0,
      long ScheduleTicktetMax = 0) {
    builder.StartTable(2);
    AcademyTicketExcel.AddScheduleTicktetMax(builder, ScheduleTicktetMax);
    AcademyTicketExcel.AddLocationRankSum(builder, LocationRankSum);
    return AcademyTicketExcel.EndAcademyTicketExcel(builder);
  }

  public static void StartAcademyTicketExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLocationRankSum(FlatBufferBuilder builder, long LocationRankSum) { builder.AddLong(0, LocationRankSum, 0); }
  public static void AddScheduleTicktetMax(FlatBufferBuilder builder, long ScheduleTicktetMax) { builder.AddLong(1, ScheduleTicktetMax, 0); }
  public static Offset<FlatDataJp.AcademyTicketExcel> EndAcademyTicketExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.AcademyTicketExcel>(o);
  }
}


}
