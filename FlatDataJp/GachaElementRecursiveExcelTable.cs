// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaElementRecursiveExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static GachaElementRecursiveExcelTable GetRootAsGachaElementRecursiveExcelTable(ByteBuffer _bb) { return GetRootAsGachaElementRecursiveExcelTable(_bb, new GachaElementRecursiveExcelTable()); }
  public static GachaElementRecursiveExcelTable GetRootAsGachaElementRecursiveExcelTable(ByteBuffer _bb, GachaElementRecursiveExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaElementRecursiveExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.GachaElementRecursiveExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.GachaElementRecursiveExcel?)(new FlatDataJp.GachaElementRecursiveExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.GachaElementRecursiveExcelTable> CreateGachaElementRecursiveExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    GachaElementRecursiveExcelTable.AddDataList(builder, DataListOffset);
    return GachaElementRecursiveExcelTable.EndGachaElementRecursiveExcelTable(builder);
  }

  public static void StartGachaElementRecursiveExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset DataListOffset) { builder.AddOffset(0, DataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatDataJp.GachaElementRecursiveExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataJp.GachaElementRecursiveExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataJp.GachaElementRecursiveExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataJp.GachaElementRecursiveExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.GachaElementRecursiveExcelTable> EndGachaElementRecursiveExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.GachaElementRecursiveExcelTable>(o);
  }
}


}
