// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ClearDeckRuleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ClearDeckRuleExcel GetRootAsClearDeckRuleExcel(ByteBuffer _bb) { return GetRootAsClearDeckRuleExcel(_bb, new ClearDeckRuleExcel()); }
  public static ClearDeckRuleExcel GetRootAsClearDeckRuleExcel(ByteBuffer _bb, ClearDeckRuleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClearDeckRuleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataJp.ContentType ContentType { get { int o = __p.__offset(4); return o != 0 ? (FlatDataJp.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ContentType.None; } }
  public long SizeLimit { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ClearDeckRuleExcel> CreateClearDeckRuleExcel(FlatBufferBuilder builder,
      FlatDataJp.ContentType contentType = FlatDataJp.ContentType.None,
      long SizeLimit = 0) {
    builder.StartTable(2);
    ClearDeckRuleExcel.AddSizeLimit(builder, SizeLimit);
    ClearDeckRuleExcel.AddContentType(builder, contentType);
    return ClearDeckRuleExcel.EndClearDeckRuleExcel(builder);
  }

  public static void StartClearDeckRuleExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddContentType(FlatBufferBuilder builder, FlatDataJp.ContentType contentType) { builder.AddInt(0, (int)contentType, 0); }
  public static void AddSizeLimit(FlatBufferBuilder builder, long SizeLimit) { builder.AddLong(1, SizeLimit, 0); }
  public static Offset<FlatDataJp.ClearDeckRuleExcel> EndClearDeckRuleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ClearDeckRuleExcel>(o);
  }
}


}
