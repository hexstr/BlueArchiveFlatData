// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RecipeSelectionAutoUseExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static RecipeSelectionAutoUseExcelTable GetRootAsRecipeSelectionAutoUseExcelTable(ByteBuffer _bb) { return GetRootAsRecipeSelectionAutoUseExcelTable(_bb, new RecipeSelectionAutoUseExcelTable()); }
  public static RecipeSelectionAutoUseExcelTable GetRootAsRecipeSelectionAutoUseExcelTable(ByteBuffer _bb, RecipeSelectionAutoUseExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeSelectionAutoUseExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.RecipeSelectionAutoUseExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.RecipeSelectionAutoUseExcel?)(new FlatDataGlobal.RecipeSelectionAutoUseExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.RecipeSelectionAutoUseExcelTable> CreateRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    RecipeSelectionAutoUseExcelTable.AddDataList(builder, DataListOffset);
    return RecipeSelectionAutoUseExcelTable.EndRecipeSelectionAutoUseExcelTable(builder);
  }

  public static void StartRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset DataListOffset) { builder.AddOffset(0, DataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatDataGlobal.RecipeSelectionAutoUseExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatDataGlobal.RecipeSelectionAutoUseExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatDataGlobal.RecipeSelectionAutoUseExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatDataGlobal.RecipeSelectionAutoUseExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.RecipeSelectionAutoUseExcelTable> EndRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.RecipeSelectionAutoUseExcelTable>(o);
  }
}


}
