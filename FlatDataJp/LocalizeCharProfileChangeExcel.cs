// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LocalizeCharProfileChangeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static LocalizeCharProfileChangeExcel GetRootAsLocalizeCharProfileChangeExcel(ByteBuffer _bb) { return GetRootAsLocalizeCharProfileChangeExcel(_bb, new LocalizeCharProfileChangeExcel()); }
  public static LocalizeCharProfileChangeExcel GetRootAsLocalizeCharProfileChangeExcel(ByteBuffer _bb, LocalizeCharProfileChangeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeCharProfileChangeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ChangeCharacterID { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.LocalizeCharProfileChangeExcel> CreateLocalizeCharProfileChangeExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long ScenarioModeId = 0,
      long ChangeCharacterID = 0) {
    builder.StartTable(3);
    LocalizeCharProfileChangeExcel.AddChangeCharacterID(builder, ChangeCharacterID);
    LocalizeCharProfileChangeExcel.AddScenarioModeId(builder, ScenarioModeId);
    LocalizeCharProfileChangeExcel.AddCharacterId(builder, CharacterId);
    return LocalizeCharProfileChangeExcel.EndLocalizeCharProfileChangeExcel(builder);
  }

  public static void StartLocalizeCharProfileChangeExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, long ScenarioModeId) { builder.AddLong(1, ScenarioModeId, 0); }
  public static void AddChangeCharacterID(FlatBufferBuilder builder, long ChangeCharacterID) { builder.AddLong(2, ChangeCharacterID, 0); }
  public static Offset<FlatDataJp.LocalizeCharProfileChangeExcel> EndLocalizeCharProfileChangeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.LocalizeCharProfileChangeExcel>(o);
  }
}


}
