// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct StrategyObjectBuffDefineExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static StrategyObjectBuffDefineExcelTable GetRootAsStrategyObjectBuffDefineExcelTable(ByteBuffer _bb) { return GetRootAsStrategyObjectBuffDefineExcelTable(_bb, new StrategyObjectBuffDefineExcelTable()); }
  public static StrategyObjectBuffDefineExcelTable GetRootAsStrategyObjectBuffDefineExcelTable(ByteBuffer _bb, StrategyObjectBuffDefineExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StrategyObjectBuffDefineExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.StrategyObjectBuffDefineExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.StrategyObjectBuffDefineExcel?)(new FlatDataJp.StrategyObjectBuffDefineExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.StrategyObjectBuffDefineExcelTable> CreateStrategyObjectBuffDefineExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    StrategyObjectBuffDefineExcelTable.AddDataList(builder, DataListOffset);
    return StrategyObjectBuffDefineExcelTable.EndStrategyObjectBuffDefineExcelTable(builder);
  }

  public static void StartStrategyObjectBuffDefineExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset DataListOffset) { builder.AddOffset(0, DataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatDataJp.StrategyObjectBuffDefineExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.StrategyObjectBuffDefineExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.StrategyObjectBuffDefineExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.StrategyObjectBuffDefineExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.StrategyObjectBuffDefineExcelTable> EndStrategyObjectBuffDefineExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.StrategyObjectBuffDefineExcelTable>(o);
  }
}


}
