// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PersonalityExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static PersonalityExcel GetRootAsPersonalityExcel(ByteBuffer _bb) { return GetRootAsPersonalityExcel(_bb, new PersonalityExcel()); }
  public static PersonalityExcel GetRootAsPersonalityExcel(ByteBuffer _bb, PersonalityExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PersonalityExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<FlatDataGlobal.PersonalityExcel> CreatePersonalityExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset)) {
    builder.StartTable(2);
    PersonalityExcel.AddId(builder, Id);
    PersonalityExcel.AddName(builder, NameOffset);
    return PersonalityExcel.EndPersonalityExcel(builder);
  }

  public static void StartPersonalityExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static Offset<FlatDataGlobal.PersonalityExcel> EndPersonalityExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.PersonalityExcel>(o);
  }
}


}
