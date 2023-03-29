// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct StrategyObjectBuffDefineExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static StrategyObjectBuffDefineExcel GetRootAsStrategyObjectBuffDefineExcel(ByteBuffer _bb) { return GetRootAsStrategyObjectBuffDefineExcel(_bb, new StrategyObjectBuffDefineExcel()); }
  public static StrategyObjectBuffDefineExcel GetRootAsStrategyObjectBuffDefineExcel(ByteBuffer _bb, StrategyObjectBuffDefineExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StrategyObjectBuffDefineExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StrategyObjectBuffID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StrategyObjectTurn { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string SkillGroupId { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillGroupIdBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSkillGroupIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSkillGroupIdArray() { return __p.__vector_as_array<byte>(8); }
  public uint LocalizeCodeId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<FlatDataGlobal.StrategyObjectBuffDefineExcel> CreateStrategyObjectBuffDefineExcel(FlatBufferBuilder builder,
      long StrategyObjectBuffID = 0,
      int StrategyObjectTurn = 0,
      StringOffset SkillGroupIdOffset = default(StringOffset),
      uint LocalizeCodeId = 0,
      StringOffset IconPathOffset = default(StringOffset)) {
    builder.StartTable(5);
    StrategyObjectBuffDefineExcel.AddStrategyObjectBuffID(builder, StrategyObjectBuffID);
    StrategyObjectBuffDefineExcel.AddIconPath(builder, IconPathOffset);
    StrategyObjectBuffDefineExcel.AddLocalizeCodeId(builder, LocalizeCodeId);
    StrategyObjectBuffDefineExcel.AddSkillGroupId(builder, SkillGroupIdOffset);
    StrategyObjectBuffDefineExcel.AddStrategyObjectTurn(builder, StrategyObjectTurn);
    return StrategyObjectBuffDefineExcel.EndStrategyObjectBuffDefineExcel(builder);
  }

  public static void StartStrategyObjectBuffDefineExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddStrategyObjectBuffID(FlatBufferBuilder builder, long StrategyObjectBuffID) { builder.AddLong(0, StrategyObjectBuffID, 0); }
  public static void AddStrategyObjectTurn(FlatBufferBuilder builder, int StrategyObjectTurn) { builder.AddInt(1, StrategyObjectTurn, 0); }
  public static void AddSkillGroupId(FlatBufferBuilder builder, StringOffset SkillGroupIdOffset) { builder.AddOffset(2, SkillGroupIdOffset.Value, 0); }
  public static void AddLocalizeCodeId(FlatBufferBuilder builder, uint LocalizeCodeId) { builder.AddUint(3, LocalizeCodeId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(4, IconPathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.StrategyObjectBuffDefineExcel> EndStrategyObjectBuffDefineExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.StrategyObjectBuffDefineExcel>(o);
  }
}


}
