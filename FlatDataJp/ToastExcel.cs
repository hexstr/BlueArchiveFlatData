// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ToastExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static ToastExcel GetRootAsToastExcel(ByteBuffer _bb) { return GetRootAsToastExcel(_bb, new ToastExcel()); }
  public static ToastExcel GetRootAsToastExcel(ByteBuffer _bb, ToastExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ToastExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataJp.ToastType ToastType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.ToastType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ToastType.None; } }
  public uint MissionId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint TextId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long LifeTime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ToastExcel> CreateToastExcel(FlatBufferBuilder builder,
      uint Id = 0,
      FlatDataJp.ToastType ToastType = FlatDataJp.ToastType.None,
      uint MissionId = 0,
      uint TextId = 0,
      long LifeTime = 0) {
    builder.StartTable(5);
    ToastExcel.AddLifeTime(builder, LifeTime);
    ToastExcel.AddTextId(builder, TextId);
    ToastExcel.AddMissionId(builder, MissionId);
    ToastExcel.AddToastType(builder, ToastType);
    ToastExcel.AddId(builder, Id);
    return ToastExcel.EndToastExcel(builder);
  }

  public static void StartToastExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, uint Id) { builder.AddUint(0, Id, 0); }
  public static void AddToastType(FlatBufferBuilder builder, FlatDataJp.ToastType ToastType) { builder.AddInt(1, (int)ToastType, 0); }
  public static void AddMissionId(FlatBufferBuilder builder, uint MissionId) { builder.AddUint(2, MissionId, 0); }
  public static void AddTextId(FlatBufferBuilder builder, uint TextId) { builder.AddUint(3, TextId, 0); }
  public static void AddLifeTime(FlatBufferBuilder builder, long LifeTime) { builder.AddLong(4, LifeTime, 0); }
  public static Offset<FlatDataJp.ToastExcel> EndToastExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ToastExcel>(o);
  }
}


}
