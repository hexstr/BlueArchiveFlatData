// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct InformationStrategyObjectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static InformationStrategyObjectExcel GetRootAsInformationStrategyObjectExcel(ByteBuffer _bb) { return GetRootAsInformationStrategyObjectExcel(_bb, new InformationStrategyObjectExcel()); }
  public static InformationStrategyObjectExcel GetRootAsInformationStrategyObjectExcel(ByteBuffer _bb, InformationStrategyObjectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public InformationStrategyObjectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PageName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPageNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPageNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPageNameArray() { return __p.__vector_as_array<byte>(8); }
  public string LocalizeCodeId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<FlatDataJp.InformationStrategyObjectExcel> CreateInformationStrategyObjectExcel(FlatBufferBuilder builder,
      long Id = 0,
      long StageId = 0,
      StringOffset PageNameOffset = default(StringOffset),
      StringOffset LocalizeCodeIdOffset = default(StringOffset)) {
    builder.StartTable(4);
    InformationStrategyObjectExcel.AddStageId(builder, StageId);
    InformationStrategyObjectExcel.AddId(builder, Id);
    InformationStrategyObjectExcel.AddLocalizeCodeId(builder, LocalizeCodeIdOffset);
    InformationStrategyObjectExcel.AddPageName(builder, PageNameOffset);
    return InformationStrategyObjectExcel.EndInformationStrategyObjectExcel(builder);
  }

  public static void StartInformationStrategyObjectExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddStageId(FlatBufferBuilder builder, long StageId) { builder.AddLong(1, StageId, 0); }
  public static void AddPageName(FlatBufferBuilder builder, StringOffset PageNameOffset) { builder.AddOffset(2, PageNameOffset.Value, 0); }
  public static void AddLocalizeCodeId(FlatBufferBuilder builder, StringOffset LocalizeCodeIdOffset) { builder.AddOffset(3, LocalizeCodeIdOffset.Value, 0); }
  public static Offset<FlatDataJp.InformationStrategyObjectExcel> EndInformationStrategyObjectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.InformationStrategyObjectExcel>(o);
  }
}


}
