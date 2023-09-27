// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FarmingDungeonLocationManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static FarmingDungeonLocationManageExcel GetRootAsFarmingDungeonLocationManageExcel(ByteBuffer _bb) { return GetRootAsFarmingDungeonLocationManageExcel(_bb, new FarmingDungeonLocationManageExcel()); }
  public static FarmingDungeonLocationManageExcel GetRootAsFarmingDungeonLocationManageExcel(ByteBuffer _bb, FarmingDungeonLocationManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FarmingDungeonLocationManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FarmingDungeonLocationId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ContentType Contenttype { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ContentType.None; } }
  public FlatDataGlobal.WeekDungeonType Weekdungeontype { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.WeekDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.WeekDungeonType.None; } }
  public FlatDataGlobal.SchoolDungeonType Schooldungeontype { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.SchoolDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.SchoolDungeonType.SchoolA; } }
  public long Order { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string OpenStartDateTime { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenStartDateTimeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetOpenStartDateTimeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetOpenStartDateTimeArray() { return __p.__vector_as_array<byte>(14); }
  public string OpenEndDateTime { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenEndDateTimeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetOpenEndDateTimeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetOpenEndDateTimeArray() { return __p.__vector_as_array<byte>(16); }
  public string LocationButtonImagePath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocationButtonImagePathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetLocationButtonImagePathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetLocationButtonImagePathArray() { return __p.__vector_as_array<byte>(18); }
  public uint LocalizeCodeTitle { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeCodeInfo { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatDataGlobal.FarmingDungeonLocationManageExcel> CreateFarmingDungeonLocationManageExcel(FlatBufferBuilder builder,
      long FarmingDungeonLocationId = 0,
      FlatDataGlobal.ContentType contenttype = FlatDataGlobal.ContentType.None,
      FlatDataGlobal.WeekDungeonType weekdungeontype = FlatDataGlobal.WeekDungeonType.None,
      FlatDataGlobal.SchoolDungeonType schooldungeontype = FlatDataGlobal.SchoolDungeonType.SchoolA,
      long Order = 0,
      StringOffset OpenStartDateTimeOffset = default(StringOffset),
      StringOffset OpenEndDateTimeOffset = default(StringOffset),
      StringOffset LocationButtonImagePathOffset = default(StringOffset),
      uint LocalizeCodeTitle = 0,
      uint LocalizeCodeInfo = 0) {
    builder.StartTable(10);
    FarmingDungeonLocationManageExcel.AddOrder(builder, Order);
    FarmingDungeonLocationManageExcel.AddFarmingDungeonLocationId(builder, FarmingDungeonLocationId);
    FarmingDungeonLocationManageExcel.AddLocalizeCodeInfo(builder, LocalizeCodeInfo);
    FarmingDungeonLocationManageExcel.AddLocalizeCodeTitle(builder, LocalizeCodeTitle);
    FarmingDungeonLocationManageExcel.AddLocationButtonImagePath(builder, LocationButtonImagePathOffset);
    FarmingDungeonLocationManageExcel.AddOpenEndDateTime(builder, OpenEndDateTimeOffset);
    FarmingDungeonLocationManageExcel.AddOpenStartDateTime(builder, OpenStartDateTimeOffset);
    FarmingDungeonLocationManageExcel.AddSchooldungeontype(builder, schooldungeontype);
    FarmingDungeonLocationManageExcel.AddWeekdungeontype(builder, weekdungeontype);
    FarmingDungeonLocationManageExcel.AddContenttype(builder, contenttype);
    return FarmingDungeonLocationManageExcel.EndFarmingDungeonLocationManageExcel(builder);
  }

  public static void StartFarmingDungeonLocationManageExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddFarmingDungeonLocationId(FlatBufferBuilder builder, long FarmingDungeonLocationId) { builder.AddLong(0, FarmingDungeonLocationId, 0); }
  public static void AddContenttype(FlatBufferBuilder builder, FlatDataGlobal.ContentType contenttype) { builder.AddInt(1, (int)contenttype, 0); }
  public static void AddWeekdungeontype(FlatBufferBuilder builder, FlatDataGlobal.WeekDungeonType weekdungeontype) { builder.AddInt(2, (int)weekdungeontype, 0); }
  public static void AddSchooldungeontype(FlatBufferBuilder builder, FlatDataGlobal.SchoolDungeonType schooldungeontype) { builder.AddInt(3, (int)schooldungeontype, 0); }
  public static void AddOrder(FlatBufferBuilder builder, long Order) { builder.AddLong(4, Order, 0); }
  public static void AddOpenStartDateTime(FlatBufferBuilder builder, StringOffset OpenStartDateTimeOffset) { builder.AddOffset(5, OpenStartDateTimeOffset.Value, 0); }
  public static void AddOpenEndDateTime(FlatBufferBuilder builder, StringOffset OpenEndDateTimeOffset) { builder.AddOffset(6, OpenEndDateTimeOffset.Value, 0); }
  public static void AddLocationButtonImagePath(FlatBufferBuilder builder, StringOffset LocationButtonImagePathOffset) { builder.AddOffset(7, LocationButtonImagePathOffset.Value, 0); }
  public static void AddLocalizeCodeTitle(FlatBufferBuilder builder, uint LocalizeCodeTitle) { builder.AddUint(8, LocalizeCodeTitle, 0); }
  public static void AddLocalizeCodeInfo(FlatBufferBuilder builder, uint LocalizeCodeInfo) { builder.AddUint(9, LocalizeCodeInfo, 0); }
  public static Offset<FlatDataGlobal.FarmingDungeonLocationManageExcel> EndFarmingDungeonLocationManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.FarmingDungeonLocationManageExcel>(o);
  }
}


}
