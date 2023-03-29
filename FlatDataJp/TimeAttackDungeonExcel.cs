// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TimeAttackDungeonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TimeAttackDungeonExcel GetRootAsTimeAttackDungeonExcel(ByteBuffer _bb) { return GetRootAsTimeAttackDungeonExcel(_bb, new TimeAttackDungeonExcel()); }
  public static TimeAttackDungeonExcel GetRootAsTimeAttackDungeonExcel(ByteBuffer _bb, TimeAttackDungeonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TimeAttackDungeonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.TimeAttackDungeonType TimeAttackDungeonType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.TimeAttackDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.TimeAttackDungeonType.None; } }
  public uint LocalizeEtcKey { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<FlatDataJp.TimeAttackDungeonExcel> CreateTimeAttackDungeonExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatDataJp.TimeAttackDungeonType TimeAttackDungeonType = FlatDataJp.TimeAttackDungeonType.None,
      uint LocalizeEtcKey = 0,
      StringOffset IconPathOffset = default(StringOffset)) {
    builder.StartTable(4);
    TimeAttackDungeonExcel.AddId(builder, Id);
    TimeAttackDungeonExcel.AddIconPath(builder, IconPathOffset);
    TimeAttackDungeonExcel.AddLocalizeEtcKey(builder, LocalizeEtcKey);
    TimeAttackDungeonExcel.AddTimeAttackDungeonType(builder, TimeAttackDungeonType);
    return TimeAttackDungeonExcel.EndTimeAttackDungeonExcel(builder);
  }

  public static void StartTimeAttackDungeonExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddTimeAttackDungeonType(FlatBufferBuilder builder, FlatDataJp.TimeAttackDungeonType TimeAttackDungeonType) { builder.AddInt(1, (int)TimeAttackDungeonType, 0); }
  public static void AddLocalizeEtcKey(FlatBufferBuilder builder, uint LocalizeEtcKey) { builder.AddUint(2, LocalizeEtcKey, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(3, IconPathOffset.Value, 0); }
  public static Offset<FlatDataJp.TimeAttackDungeonExcel> EndTimeAttackDungeonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.TimeAttackDungeonExcel>(o);
  }
}


}
