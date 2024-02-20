// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
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

  public long CostumeUniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.CVPrintType LinkedCharacterVoicePrintType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataJp.CVPrintType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.CVPrintType.CharacterOverwrite; } }
  public long LinkedCostumeUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.VoiceRoomExceptionExcel> CreateVoiceRoomExceptionExcel(FlatBufferBuilder builder,
      long CostumeUniqueId = 0,
      FlatDataJp.CVPrintType LinkedCharacterVoicePrintType = FlatDataJp.CVPrintType.CharacterOverwrite,
      long LinkedCostumeUniqueId = 0) {
    builder.StartTable(3);
    VoiceRoomExceptionExcel.AddLinkedCostumeUniqueId(builder, LinkedCostumeUniqueId);
    VoiceRoomExceptionExcel.AddCostumeUniqueId(builder, CostumeUniqueId);
    VoiceRoomExceptionExcel.AddLinkedCharacterVoicePrintType(builder, LinkedCharacterVoicePrintType);
    return VoiceRoomExceptionExcel.EndVoiceRoomExceptionExcel(builder);
  }

  public static void StartVoiceRoomExceptionExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddCostumeUniqueId(FlatBufferBuilder builder, long CostumeUniqueId) { builder.AddLong(0, CostumeUniqueId, 0); }
  public static void AddLinkedCharacterVoicePrintType(FlatBufferBuilder builder, FlatDataJp.CVPrintType LinkedCharacterVoicePrintType) { builder.AddInt(1, (int)LinkedCharacterVoicePrintType, 0); }
  public static void AddLinkedCostumeUniqueId(FlatBufferBuilder builder, long LinkedCostumeUniqueId) { builder.AddLong(2, LinkedCostumeUniqueId, 0); }
  public static Offset<FlatDataJp.VoiceRoomExceptionExcel> EndVoiceRoomExceptionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.VoiceRoomExceptionExcel>(o);
  }
}


}
