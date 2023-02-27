// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterCombatSkinExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CharacterCombatSkinExcel GetRootAsCharacterCombatSkinExcel(ByteBuffer _bb) { return GetRootAsCharacterCombatSkinExcel(_bb, new CharacterCombatSkinExcel()); }
  public static CharacterCombatSkinExcel GetRootAsCharacterCombatSkinExcel(ByteBuffer _bb, CharacterCombatSkinExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterCombatSkinExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGroupIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetGroupIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetGroupIdArray() { return __p.__vector_as_array<byte>(4); }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ResourcePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourcePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetResourcePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetResourcePathArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<FlatDataGlobal.CharacterCombatSkinExcel> CreateCharacterCombatSkinExcel(FlatBufferBuilder builder,
      StringOffset GroupIdOffset = default(StringOffset),
      long UniqueId = 0,
      StringOffset ResourcePathOffset = default(StringOffset)) {
    builder.StartTable(3);
    CharacterCombatSkinExcel.AddUniqueId(builder, UniqueId);
    CharacterCombatSkinExcel.AddResourcePath(builder, ResourcePathOffset);
    CharacterCombatSkinExcel.AddGroupId(builder, GroupIdOffset);
    return CharacterCombatSkinExcel.EndCharacterCombatSkinExcel(builder);
  }

  public static void StartCharacterCombatSkinExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddGroupId(FlatBufferBuilder builder, StringOffset GroupIdOffset) { builder.AddOffset(0, GroupIdOffset.Value, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long UniqueId) { builder.AddLong(1, UniqueId, 0); }
  public static void AddResourcePath(FlatBufferBuilder builder, StringOffset ResourcePathOffset) { builder.AddOffset(2, ResourcePathOffset.Value, 0); }
  public static Offset<FlatDataGlobal.CharacterCombatSkinExcel> EndCharacterCombatSkinExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterCombatSkinExcel>(o);
  }
}


}
