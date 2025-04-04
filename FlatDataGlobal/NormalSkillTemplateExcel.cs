// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct NormalSkillTemplateExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static NormalSkillTemplateExcel GetRootAsNormalSkillTemplateExcel(ByteBuffer _bb) { return GetRootAsNormalSkillTemplateExcel(_bb, new NormalSkillTemplateExcel()); }
  public static NormalSkillTemplateExcel GetRootAsNormalSkillTemplateExcel(ByteBuffer _bb, NormalSkillTemplateExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NormalSkillTemplateExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float FirstCoolTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CoolTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool MultiAni { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.NormalSkillTemplateExcel> CreateNormalSkillTemplateExcel(FlatBufferBuilder builder,
      long Index = 0,
      float FirstCoolTime = 0.0f,
      float CoolTime = 0.0f,
      bool MultiAni = false) {
    builder.StartTable(4);
    NormalSkillTemplateExcel.AddIndex(builder, Index);
    NormalSkillTemplateExcel.AddCoolTime(builder, CoolTime);
    NormalSkillTemplateExcel.AddFirstCoolTime(builder, FirstCoolTime);
    NormalSkillTemplateExcel.AddMultiAni(builder, MultiAni);
    return NormalSkillTemplateExcel.EndNormalSkillTemplateExcel(builder);
  }

  public static void StartNormalSkillTemplateExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddIndex(FlatBufferBuilder builder, long Index) { builder.AddLong(0, Index, 0); }
  public static void AddFirstCoolTime(FlatBufferBuilder builder, float FirstCoolTime) { builder.AddFloat(1, FirstCoolTime, 0.0f); }
  public static void AddCoolTime(FlatBufferBuilder builder, float CoolTime) { builder.AddFloat(2, CoolTime, 0.0f); }
  public static void AddMultiAni(FlatBufferBuilder builder, bool MultiAni) { builder.AddBool(3, MultiAni, false); }
  public static Offset<FlatDataGlobal.NormalSkillTemplateExcel> EndNormalSkillTemplateExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.NormalSkillTemplateExcel>(o);
  }
}


}
