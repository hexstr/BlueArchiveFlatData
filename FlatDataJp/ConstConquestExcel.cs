// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstConquestExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ConstConquestExcel GetRootAsConstConquestExcel(ByteBuffer _bb) { return GetRootAsConstConquestExcel(_bb, new ConstConquestExcel()); }
  public static ConstConquestExcel GetRootAsConstConquestExcel(ByteBuffer _bb, ConstConquestExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstConquestExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ManageUnitChange { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AssistCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PlayTimeLimitInSeconds { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AnimationUnitAmountMin { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AnimationUnitAmountMax { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float AnimationUnitDelay { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataJp.ConstConquestExcel> CreateConstConquestExcel(FlatBufferBuilder builder,
      int ManageUnitChange = 0,
      int AssistCount = 0,
      int PlayTimeLimitInSeconds = 0,
      int AnimationUnitAmountMin = 0,
      int AnimationUnitAmountMax = 0,
      float AnimationUnitDelay = 0.0f) {
    builder.StartTable(6);
    ConstConquestExcel.AddAnimationUnitDelay(builder, AnimationUnitDelay);
    ConstConquestExcel.AddAnimationUnitAmountMax(builder, AnimationUnitAmountMax);
    ConstConquestExcel.AddAnimationUnitAmountMin(builder, AnimationUnitAmountMin);
    ConstConquestExcel.AddPlayTimeLimitInSeconds(builder, PlayTimeLimitInSeconds);
    ConstConquestExcel.AddAssistCount(builder, AssistCount);
    ConstConquestExcel.AddManageUnitChange(builder, ManageUnitChange);
    return ConstConquestExcel.EndConstConquestExcel(builder);
  }

  public static void StartConstConquestExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddManageUnitChange(FlatBufferBuilder builder, int ManageUnitChange) { builder.AddInt(0, ManageUnitChange, 0); }
  public static void AddAssistCount(FlatBufferBuilder builder, int AssistCount) { builder.AddInt(1, AssistCount, 0); }
  public static void AddPlayTimeLimitInSeconds(FlatBufferBuilder builder, int PlayTimeLimitInSeconds) { builder.AddInt(2, PlayTimeLimitInSeconds, 0); }
  public static void AddAnimationUnitAmountMin(FlatBufferBuilder builder, int AnimationUnitAmountMin) { builder.AddInt(3, AnimationUnitAmountMin, 0); }
  public static void AddAnimationUnitAmountMax(FlatBufferBuilder builder, int AnimationUnitAmountMax) { builder.AddInt(4, AnimationUnitAmountMax, 0); }
  public static void AddAnimationUnitDelay(FlatBufferBuilder builder, float AnimationUnitDelay) { builder.AddFloat(5, AnimationUnitDelay, 0.0f); }
  public static Offset<FlatDataJp.ConstConquestExcel> EndConstConquestExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ConstConquestExcel>(o);
  }
}


}
