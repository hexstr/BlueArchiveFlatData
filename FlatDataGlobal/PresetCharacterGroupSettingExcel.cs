// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PresetCharacterGroupSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static PresetCharacterGroupSettingExcel GetRootAsPresetCharacterGroupSettingExcel(ByteBuffer _bb) { return GetRootAsPresetCharacterGroupSettingExcel(_bb, new PresetCharacterGroupSettingExcel()); }
  public static PresetCharacterGroupSettingExcel GetRootAsPresetCharacterGroupSettingExcel(ByteBuffer _bb, PresetCharacterGroupSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PresetCharacterGroupSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ArenaSimulatorFixed { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string PresetType(int j) { int o = __p.__offset(8); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PresetTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.PresetCharacterGroupSettingExcel> CreatePresetCharacterGroupSettingExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      bool ArenaSimulatorFixed = false,
      VectorOffset PresetTypeOffset = default(VectorOffset)) {
    builder.StartTable(3);
    PresetCharacterGroupSettingExcel.AddCharacterId(builder, CharacterId);
    PresetCharacterGroupSettingExcel.AddPresetType(builder, PresetTypeOffset);
    PresetCharacterGroupSettingExcel.AddArenaSimulatorFixed(builder, ArenaSimulatorFixed);
    return PresetCharacterGroupSettingExcel.EndPresetCharacterGroupSettingExcel(builder);
  }

  public static void StartPresetCharacterGroupSettingExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddArenaSimulatorFixed(FlatBufferBuilder builder, bool ArenaSimulatorFixed) { builder.AddBool(1, ArenaSimulatorFixed, false); }
  public static void AddPresetType(FlatBufferBuilder builder, VectorOffset PresetTypeOffset) { builder.AddOffset(2, PresetTypeOffset.Value, 0); }
  public static VectorOffset CreatePresetTypeVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePresetTypeVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePresetTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePresetTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPresetTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.PresetCharacterGroupSettingExcel> EndPresetCharacterGroupSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.PresetCharacterGroupSettingExcel>(o);
  }
}


}
