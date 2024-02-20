// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ContentEnterCostReduceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ContentEnterCostReduceExcel GetRootAsContentEnterCostReduceExcel(ByteBuffer _bb) { return GetRootAsContentEnterCostReduceExcel(_bb, new ContentEnterCostReduceExcel()); }
  public static ContentEnterCostReduceExcel GetRootAsContentEnterCostReduceExcel(ByteBuffer _bb, ContentEnterCostReduceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ContentEnterCostReduceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EnterCostReduceGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ContentType ContentType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ContentType.None; } }
  public long StageId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.ParcelType ReduceEnterCostType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ReduceEnterCostId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ReduceAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ContentEnterCostReduceExcel> CreateContentEnterCostReduceExcel(FlatBufferBuilder builder,
      long EnterCostReduceGroupId = 0,
      FlatDataJp.ContentType contentType = FlatDataJp.ContentType.None,
      long StageId = 0,
      FlatDataJp.ParcelType ReduceEnterCostType = FlatDataJp.ParcelType.None,
      long ReduceEnterCostId = 0,
      long ReduceAmount = 0) {
    builder.StartTable(6);
    ContentEnterCostReduceExcel.AddReduceAmount(builder, ReduceAmount);
    ContentEnterCostReduceExcel.AddReduceEnterCostId(builder, ReduceEnterCostId);
    ContentEnterCostReduceExcel.AddStageId(builder, StageId);
    ContentEnterCostReduceExcel.AddEnterCostReduceGroupId(builder, EnterCostReduceGroupId);
    ContentEnterCostReduceExcel.AddReduceEnterCostType(builder, ReduceEnterCostType);
    ContentEnterCostReduceExcel.AddContentType(builder, contentType);
    return ContentEnterCostReduceExcel.EndContentEnterCostReduceExcel(builder);
  }

  public static void StartContentEnterCostReduceExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddEnterCostReduceGroupId(FlatBufferBuilder builder, long EnterCostReduceGroupId) { builder.AddLong(0, EnterCostReduceGroupId, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatDataJp.ContentType contentType) { builder.AddInt(1, (int)contentType, 0); }
  public static void AddStageId(FlatBufferBuilder builder, long StageId) { builder.AddLong(2, StageId, 0); }
  public static void AddReduceEnterCostType(FlatBufferBuilder builder, FlatDataJp.ParcelType ReduceEnterCostType) { builder.AddInt(3, (int)ReduceEnterCostType, 0); }
  public static void AddReduceEnterCostId(FlatBufferBuilder builder, long ReduceEnterCostId) { builder.AddLong(4, ReduceEnterCostId, 0); }
  public static void AddReduceAmount(FlatBufferBuilder builder, long ReduceAmount) { builder.AddLong(5, ReduceAmount, 0); }
  public static Offset<FlatDataJp.ContentEnterCostReduceExcel> EndContentEnterCostReduceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ContentEnterCostReduceExcel>(o);
  }
}


}
