// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterPotentialExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterPotentialExcel GetRootAsCharacterPotentialExcel(ByteBuffer _bb) { return GetRootAsCharacterPotentialExcel(_bb, new CharacterPotentialExcel()); }
  public static CharacterPotentialExcel GetRootAsCharacterPotentialExcel(ByteBuffer _bb, CharacterPotentialExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterPotentialExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PotentialStatGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.PotentialStatBonusRateType PotentialStatBonusRateType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.PotentialStatBonusRateType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.PotentialStatBonusRateType.None; } }
  public bool IsUnnecessaryStat { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataJp.CharacterPotentialExcel> CreateCharacterPotentialExcel(FlatBufferBuilder builder,
      long Id = 0,
      long PotentialStatGroupId = 0,
      FlatDataJp.PotentialStatBonusRateType potentialStatBonusRateType = FlatDataJp.PotentialStatBonusRateType.None,
      bool IsUnnecessaryStat = false) {
    builder.StartTable(4);
    CharacterPotentialExcel.AddPotentialStatGroupId(builder, PotentialStatGroupId);
    CharacterPotentialExcel.AddId(builder, Id);
    CharacterPotentialExcel.AddPotentialStatBonusRateType(builder, potentialStatBonusRateType);
    CharacterPotentialExcel.AddIsUnnecessaryStat(builder, IsUnnecessaryStat);
    return CharacterPotentialExcel.EndCharacterPotentialExcel(builder);
  }

  public static void StartCharacterPotentialExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddPotentialStatGroupId(FlatBufferBuilder builder, long PotentialStatGroupId) { builder.AddLong(1, PotentialStatGroupId, 0); }
  public static void AddPotentialStatBonusRateType(FlatBufferBuilder builder, FlatDataJp.PotentialStatBonusRateType potentialStatBonusRateType) { builder.AddInt(2, (int)potentialStatBonusRateType, 0); }
  public static void AddIsUnnecessaryStat(FlatBufferBuilder builder, bool IsUnnecessaryStat) { builder.AddBool(3, IsUnnecessaryStat, false); }
  public static Offset<FlatDataJp.CharacterPotentialExcel> EndCharacterPotentialExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CharacterPotentialExcel>(o);
  }
}


}
