// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestGroupBuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ConquestGroupBuffExcel GetRootAsConquestGroupBuffExcel(ByteBuffer _bb) { return GetRootAsConquestGroupBuffExcel(_bb, new ConquestGroupBuffExcel()); }
  public static ConquestGroupBuffExcel GetRootAsConquestGroupBuffExcel(ByteBuffer _bb, ConquestGroupBuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestGroupBuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ConquestBuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.School School_(int j) { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.School)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.School)0; }
  public int School_Length { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.School> GetSchool_Bytes() { return __p.__vector_as_span<FlatDataGlobal.School>(6, 4); }
#else
  public ArraySegment<byte>? GetSchool_Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatDataGlobal.School[] GetSchool_Array() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.School[] a = new FlatDataGlobal.School[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.School)__p.bb.GetInt(p + i * 4); } return a; }
  public uint RecommandLocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string SkillGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillGroupIdBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSkillGroupIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSkillGroupIdArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<FlatDataGlobal.ConquestGroupBuffExcel> CreateConquestGroupBuffExcel(FlatBufferBuilder builder,
      long ConquestBuffId = 0,
      VectorOffset School_Offset = default(VectorOffset),
      uint RecommandLocalizeEtcId = 0,
      StringOffset SkillGroupIdOffset = default(StringOffset)) {
    builder.StartTable(4);
    ConquestGroupBuffExcel.AddConquestBuffId(builder, ConquestBuffId);
    ConquestGroupBuffExcel.AddSkillGroupId(builder, SkillGroupIdOffset);
    ConquestGroupBuffExcel.AddRecommandLocalizeEtcId(builder, RecommandLocalizeEtcId);
    ConquestGroupBuffExcel.AddSchool_(builder, School_Offset);
    return ConquestGroupBuffExcel.EndConquestGroupBuffExcel(builder);
  }

  public static void StartConquestGroupBuffExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddConquestBuffId(FlatBufferBuilder builder, long ConquestBuffId) { builder.AddLong(0, ConquestBuffId, 0); }
  public static void AddSchool_(FlatBufferBuilder builder, VectorOffset School_Offset) { builder.AddOffset(1, School_Offset.Value, 0); }
  public static VectorOffset CreateSchool_Vector(FlatBufferBuilder builder, FlatDataGlobal.School[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSchool_VectorBlock(FlatBufferBuilder builder, FlatDataGlobal.School[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSchool_VectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.School> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSchool_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.School>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSchool_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecommandLocalizeEtcId(FlatBufferBuilder builder, uint RecommandLocalizeEtcId) { builder.AddUint(2, RecommandLocalizeEtcId, 0); }
  public static void AddSkillGroupId(FlatBufferBuilder builder, StringOffset SkillGroupIdOffset) { builder.AddOffset(3, SkillGroupIdOffset.Value, 0); }
  public static Offset<FlatDataGlobal.ConquestGroupBuffExcel> EndConquestGroupBuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.ConquestGroupBuffExcel>(o);
  }
}


}
