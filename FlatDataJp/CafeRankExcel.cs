// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CafeRankExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CafeRankExcel GetRootAsCafeRankExcel(ByteBuffer _bb) { return GetRootAsCafeRankExcel(_bb, new CafeRankExcel()); }
  public static CafeRankExcel GetRootAsCafeRankExcel(ByteBuffer _bb, CafeRankExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CafeRankExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Rank { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ComfortMax { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActionPointProductionCoefficient { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActionPointProductionCorrectionValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActionPointStorageMax { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoldProductionCoefficient { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoldProductionCorrectionValue { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoldStorageMax { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TagCountMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int CharacterVisitMin { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterVisitMax { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatDataJp.CafeRankExcel> CreateCafeRankExcel(FlatBufferBuilder builder,
      long Rank = 0,
      long RecipeId = 0,
      long ComfortMax = 0,
      long ActionPointProductionCoefficient = 0,
      long ActionPointProductionCorrectionValue = 0,
      long ActionPointStorageMax = 0,
      long GoldProductionCoefficient = 0,
      long GoldProductionCorrectionValue = 0,
      long GoldStorageMax = 0,
      long TagCountMax = 0,
      int CharacterVisitMin = 0,
      int CharacterVisitMax = 0) {
    builder.StartTable(12);
    CafeRankExcel.AddTagCountMax(builder, TagCountMax);
    CafeRankExcel.AddGoldStorageMax(builder, GoldStorageMax);
    CafeRankExcel.AddGoldProductionCorrectionValue(builder, GoldProductionCorrectionValue);
    CafeRankExcel.AddGoldProductionCoefficient(builder, GoldProductionCoefficient);
    CafeRankExcel.AddActionPointStorageMax(builder, ActionPointStorageMax);
    CafeRankExcel.AddActionPointProductionCorrectionValue(builder, ActionPointProductionCorrectionValue);
    CafeRankExcel.AddActionPointProductionCoefficient(builder, ActionPointProductionCoefficient);
    CafeRankExcel.AddComfortMax(builder, ComfortMax);
    CafeRankExcel.AddRecipeId(builder, RecipeId);
    CafeRankExcel.AddRank(builder, Rank);
    CafeRankExcel.AddCharacterVisitMax(builder, CharacterVisitMax);
    CafeRankExcel.AddCharacterVisitMin(builder, CharacterVisitMin);
    return CafeRankExcel.EndCafeRankExcel(builder);
  }

  public static void StartCafeRankExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddRank(FlatBufferBuilder builder, long Rank) { builder.AddLong(0, Rank, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, long RecipeId) { builder.AddLong(1, RecipeId, 0); }
  public static void AddComfortMax(FlatBufferBuilder builder, long ComfortMax) { builder.AddLong(2, ComfortMax, 0); }
  public static void AddActionPointProductionCoefficient(FlatBufferBuilder builder, long ActionPointProductionCoefficient) { builder.AddLong(3, ActionPointProductionCoefficient, 0); }
  public static void AddActionPointProductionCorrectionValue(FlatBufferBuilder builder, long ActionPointProductionCorrectionValue) { builder.AddLong(4, ActionPointProductionCorrectionValue, 0); }
  public static void AddActionPointStorageMax(FlatBufferBuilder builder, long ActionPointStorageMax) { builder.AddLong(5, ActionPointStorageMax, 0); }
  public static void AddGoldProductionCoefficient(FlatBufferBuilder builder, long GoldProductionCoefficient) { builder.AddLong(6, GoldProductionCoefficient, 0); }
  public static void AddGoldProductionCorrectionValue(FlatBufferBuilder builder, long GoldProductionCorrectionValue) { builder.AddLong(7, GoldProductionCorrectionValue, 0); }
  public static void AddGoldStorageMax(FlatBufferBuilder builder, long GoldStorageMax) { builder.AddLong(8, GoldStorageMax, 0); }
  public static void AddTagCountMax(FlatBufferBuilder builder, long TagCountMax) { builder.AddLong(9, TagCountMax, 0); }
  public static void AddCharacterVisitMin(FlatBufferBuilder builder, int CharacterVisitMin) { builder.AddInt(10, CharacterVisitMin, 0); }
  public static void AddCharacterVisitMax(FlatBufferBuilder builder, int CharacterVisitMax) { builder.AddInt(11, CharacterVisitMax, 0); }
  public static Offset<FlatDataJp.CafeRankExcel> EndCafeRankExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CafeRankExcel>(o);
  }
}


}
