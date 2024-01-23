// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Form : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static Form GetRootAsForm(ByteBuffer _bb) { return GetRootAsForm(_bb, new Form()); }
  public static Form GetRootAsForm(ByteBuffer _bb, Form obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Form __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.MoveEnd? MoveEnd { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.MoveEnd?)(new FlatDataGlobal.MoveEnd()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public FlatDataGlobal.Motion? PublicSkill { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.Motion?)(new FlatDataGlobal.Motion()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<FlatDataGlobal.Form> CreateForm(FlatBufferBuilder builder,
      Offset<FlatDataGlobal.MoveEnd> moveEndOffset = default(Offset<FlatDataGlobal.MoveEnd>),
      Offset<FlatDataGlobal.Motion> PublicSkillOffset = default(Offset<FlatDataGlobal.Motion>)) {
    builder.StartTable(2);
    Form.AddPublicSkill(builder, PublicSkillOffset);
    Form.AddMoveEnd(builder, moveEndOffset);
    return Form.EndForm(builder);
  }

  public static void StartForm(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddMoveEnd(FlatBufferBuilder builder, Offset<FlatDataGlobal.MoveEnd> moveEndOffset) { builder.AddOffset(0, moveEndOffset.Value, 0); }
  public static void AddPublicSkill(FlatBufferBuilder builder, Offset<FlatDataGlobal.Motion> PublicSkillOffset) { builder.AddOffset(1, PublicSkillOffset.Value, 0); }
  public static Offset<FlatDataGlobal.Form> EndForm(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.Form>(o);
  }
}


}
