// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct VoiceRoomExceptionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static VoiceRoomExceptionExcel GetRootAsVoiceRoomExceptionExcel(ByteBuffer _bb) { return GetRootAsVoiceRoomExceptionExcel(_bb, new VoiceRoomExceptionExcel()); }
  public static VoiceRoomExceptionExcel GetRootAsVoiceRoomExceptionExcel(ByteBuffer _bb, VoiceRoomExceptionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceRoomExceptionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatDataGlobal.CVExceptionTarget ExceptionTarget { get { int o = __p.__offset(4); return o != 0 ? (FlatDataGlobal.CVExceptionTarget)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.CVExceptionTarget.CharacterId; } }
  public FlatDataGlobal.SquadType SquadType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.SquadType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.SquadType.None; } }
  public long CharacterId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.CVPrintType LinkedCharacterVoicePrintType { get { int o = __p.__offset(10); return o != 0 ? (FlatDataGlobal.CVPrintType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.CVPrintType.CharacterOverwrite; } }
  public string LinkedCharacterName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLinkedCharacterNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLinkedCharacterNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLinkedCharacterNameArray() { return __p.__vector_as_array<byte>(12); }
  public uint BlackListNameHash(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int BlackListNameHashLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetBlackListNameHashBytes() { return __p.__vector_as_span<uint>(14, 4); }
#else
  public ArraySegment<byte>? GetBlackListNameHashBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public uint[] GetBlackListNameHashArray() { return __p.__vector_as_array<uint>(14); }

  public static Offset<FlatDataGlobal.VoiceRoomExceptionExcel> CreateVoiceRoomExceptionExcel(FlatBufferBuilder builder,
      FlatDataGlobal.CVExceptionTarget ExceptionTarget = FlatDataGlobal.CVExceptionTarget.CharacterId,
      FlatDataGlobal.SquadType squadType = FlatDataGlobal.SquadType.None,
      long CharacterId = 0,
      FlatDataGlobal.CVPrintType LinkedCharacterVoicePrintType = FlatDataGlobal.CVPrintType.CharacterOverwrite,
      StringOffset LinkedCharacterNameOffset = default(StringOffset),
      VectorOffset BlackListNameHashOffset = default(VectorOffset)) {
    builder.StartTable(6);
    VoiceRoomExceptionExcel.AddCharacterId(builder, CharacterId);
    VoiceRoomExceptionExcel.AddBlackListNameHash(builder, BlackListNameHashOffset);
    VoiceRoomExceptionExcel.AddLinkedCharacterName(builder, LinkedCharacterNameOffset);
    VoiceRoomExceptionExcel.AddLinkedCharacterVoicePrintType(builder, LinkedCharacterVoicePrintType);
    VoiceRoomExceptionExcel.AddSquadType(builder, squadType);
    VoiceRoomExceptionExcel.AddExceptionTarget(builder, ExceptionTarget);
    return VoiceRoomExceptionExcel.EndVoiceRoomExceptionExcel(builder);
  }

  public static void StartVoiceRoomExceptionExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddExceptionTarget(FlatBufferBuilder builder, FlatDataGlobal.CVExceptionTarget ExceptionTarget) { builder.AddInt(0, (int)ExceptionTarget, 0); }
  public static void AddSquadType(FlatBufferBuilder builder, FlatDataGlobal.SquadType squadType) { builder.AddInt(1, (int)squadType, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(2, CharacterId, 0); }
  public static void AddLinkedCharacterVoicePrintType(FlatBufferBuilder builder, FlatDataGlobal.CVPrintType LinkedCharacterVoicePrintType) { builder.AddInt(3, (int)LinkedCharacterVoicePrintType, 0); }
  public static void AddLinkedCharacterName(FlatBufferBuilder builder, StringOffset LinkedCharacterNameOffset) { builder.AddOffset(4, LinkedCharacterNameOffset.Value, 0); }
  public static void AddBlackListNameHash(FlatBufferBuilder builder, VectorOffset BlackListNameHashOffset) { builder.AddOffset(5, BlackListNameHashOffset.Value, 0); }
  public static VectorOffset CreateBlackListNameHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBlackListNameHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBlackListNameHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBlackListNameHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBlackListNameHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.VoiceRoomExceptionExcel> EndVoiceRoomExceptionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.VoiceRoomExceptionExcel>(o);
  }
}


}
