// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentStageRewardExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static EventContentStageRewardExcelTable GetRootAsEventContentStageRewardExcelTable(ByteBuffer _bb) { return GetRootAsEventContentStageRewardExcelTable(_bb, new EventContentStageRewardExcelTable()); }
  public static EventContentStageRewardExcelTable GetRootAsEventContentStageRewardExcelTable(ByteBuffer _bb, EventContentStageRewardExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentStageRewardExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.EventContentStageRewardExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.EventContentStageRewardExcel?)(new FlatDataJp.EventContentStageRewardExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.EventContentStageRewardExcelTable> CreateEventContentStageRewardExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    EventContentStageRewardExcelTable.AddDataList(builder, DataListOffset);
    return EventContentStageRewardExcelTable.EndEventContentStageRewardExcelTable(builder);
  }

  public static void StartEventContentStageRewardExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset DataListOffset) { builder.AddOffset(0, DataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatDataJp.EventContentStageRewardExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.EventContentStageRewardExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.EventContentStageRewardExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.EventContentStageRewardExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.EventContentStageRewardExcelTable> EndEventContentStageRewardExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.EventContentStageRewardExcelTable>(o);
  }
}


}
