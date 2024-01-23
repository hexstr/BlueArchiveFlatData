// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestObjectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConquestObjectExcel GetRootAsConquestObjectExcel(ByteBuffer _bb) { return GetRootAsConquestObjectExcel(_bb, new ConquestObjectExcel()); }
  public static ConquestObjectExcel GetRootAsConquestObjectExcel(ByteBuffer _bb, ConquestObjectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestObjectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ConquestObjectType ConquestObjectType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ConquestObjectType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ConquestObjectType.None; } }
  public uint Key { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(12); }
  public string PrefabName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(14); }
  public FlatDataGlobal.ParcelType ConquestRewardParcelType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ParcelType.None; } }
  public long ConquestRewardID { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ConquestRewardAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool Disposable { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int StepIndex { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StepObjectCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataGlobal.ConquestObjectExcel> CreateConquestObjectExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      FlatDataGlobal.ConquestObjectType conquestObjectType = FlatDataGlobal.ConquestObjectType.None,
      uint Key = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset PrefabNameOffset = default(StringOffset),
      FlatDataGlobal.ParcelType ConquestRewardParcelType = FlatDataGlobal.ParcelType.None,
      long ConquestRewardID = 0,
      int ConquestRewardAmount = 0,
      bool Disposable = false,
      int StepIndex = 0,
      int StepObjectCount = 0) {
    builder.StartTable(12);
    ConquestObjectExcel.AddConquestRewardID(builder, ConquestRewardID);
    ConquestObjectExcel.AddEventContentId(builder, EventContentId);
    ConquestObjectExcel.AddId(builder, Id);
    ConquestObjectExcel.AddStepObjectCount(builder, StepObjectCount);
    ConquestObjectExcel.AddStepIndex(builder, StepIndex);
    ConquestObjectExcel.AddConquestRewardAmount(builder, ConquestRewardAmount);
    ConquestObjectExcel.AddConquestRewardParcelType(builder, ConquestRewardParcelType);
    ConquestObjectExcel.AddPrefabName(builder, PrefabNameOffset);
    ConquestObjectExcel.AddName(builder, NameOffset);
    ConquestObjectExcel.AddKey(builder, Key);
    ConquestObjectExcel.AddConquestObjectType(builder, conquestObjectType);
    ConquestObjectExcel.AddDisposable(builder, Disposable);
    return ConquestObjectExcel.EndConquestObjectExcel(builder);
  }

  public static void StartConquestObjectExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long EventContentId) { builder.AddLong(1, EventContentId, 0); }
  public static void AddConquestObjectType(FlatBufferBuilder builder, FlatDataGlobal.ConquestObjectType conquestObjectType) { builder.AddInt(2, (int)conquestObjectType, 0); }
  public static void AddKey(FlatBufferBuilder builder, uint Key) { builder.AddUint(3, Key, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(4, NameOffset.Value, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset PrefabNameOffset) { builder.AddOffset(5, PrefabNameOffset.Value, 0); }
  public static void AddConquestRewardParcelType(FlatBufferBuilder builder, FlatDataGlobal.ParcelType ConquestRewardParcelType) { builder.AddInt(6, (int)ConquestRewardParcelType, 0); }
  public static void AddConquestRewardID(FlatBufferBuilder builder, long ConquestRewardID) { builder.AddLong(7, ConquestRewardID, 0); }
  public static void AddConquestRewardAmount(FlatBufferBuilder builder, int ConquestRewardAmount) { builder.AddInt(8, ConquestRewardAmount, 0); }
  public static void AddDisposable(FlatBufferBuilder builder, bool Disposable) { builder.AddBool(9, Disposable, false); }
  public static void AddStepIndex(FlatBufferBuilder builder, int StepIndex) { builder.AddInt(10, StepIndex, 0); }
  public static void AddStepObjectCount(FlatBufferBuilder builder, int StepObjectCount) { builder.AddInt(11, StepObjectCount, 0); }
  public static Offset<FlatDataGlobal.ConquestObjectExcel> EndConquestObjectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConquestObjectExcel>(o);
  }
}


}
