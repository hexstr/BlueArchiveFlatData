// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SkillAdditionalTooltipExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static SkillAdditionalTooltipExcel GetRootAsSkillAdditionalTooltipExcel(ByteBuffer _bb) { return GetRootAsSkillAdditionalTooltipExcel(_bb, new SkillAdditionalTooltipExcel()); }
  public static SkillAdditionalTooltipExcel GetRootAsSkillAdditionalTooltipExcel(ByteBuffer _bb, SkillAdditionalTooltipExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SkillAdditionalTooltipExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AdditionalSkillGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAdditionalSkillGroupIdBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetAdditionalSkillGroupIdBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAdditionalSkillGroupIdArray() { return __p.__vector_as_array<byte>(6); }
  public string ShowSkillSlot { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShowSkillSlotBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetShowSkillSlotBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetShowSkillSlotArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<FlatDataGlobal.SkillAdditionalTooltipExcel> CreateSkillAdditionalTooltipExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      StringOffset AdditionalSkillGroupIdOffset = default(StringOffset),
      StringOffset ShowSkillSlotOffset = default(StringOffset)) {
    builder.StartTable(3);
    SkillAdditionalTooltipExcel.AddGroupId(builder, GroupId);
    SkillAdditionalTooltipExcel.AddShowSkillSlot(builder, ShowSkillSlotOffset);
    SkillAdditionalTooltipExcel.AddAdditionalSkillGroupId(builder, AdditionalSkillGroupIdOffset);
    return SkillAdditionalTooltipExcel.EndSkillAdditionalTooltipExcel(builder);
  }

  public static void StartSkillAdditionalTooltipExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddGroupId(FlatBufferBuilder builder, long GroupId) { builder.AddLong(0, GroupId, 0); }
  public static void AddAdditionalSkillGroupId(FlatBufferBuilder builder, StringOffset AdditionalSkillGroupIdOffset) { builder.AddOffset(1, AdditionalSkillGroupIdOffset.Value, 0); }
  public static void AddShowSkillSlot(FlatBufferBuilder builder, StringOffset ShowSkillSlotOffset) { builder.AddOffset(2, ShowSkillSlotOffset.Value, 0); }
  public static Offset<FlatDataGlobal.SkillAdditionalTooltipExcel> EndSkillAdditionalTooltipExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.SkillAdditionalTooltipExcel>(o);
  }
}


}
