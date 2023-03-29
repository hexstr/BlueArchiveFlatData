// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BulletArmorDamageFactorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static BulletArmorDamageFactorExcel GetRootAsBulletArmorDamageFactorExcel(ByteBuffer _bb) { return GetRootAsBulletArmorDamageFactorExcel(_bb, new BulletArmorDamageFactorExcel()); }
  public static BulletArmorDamageFactorExcel GetRootAsBulletArmorDamageFactorExcel(ByteBuffer _bb, BulletArmorDamageFactorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BulletArmorDamageFactorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DamageFactorGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDamageFactorGroupIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDamageFactorGroupIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDamageFactorGroupIdArray() { return __p.__vector_as_array<byte>(4); }
  public FlatDataGlobal.BulletType BulletType { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.BulletType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.BulletType.Normal; } }
  public FlatDataGlobal.ArmorType ArmorType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.ArmorType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.ArmorType.LightArmor; } }
  public long DamageRate { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.DamageAttribute DamageAttribute { get { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.DamageAttribute)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.DamageAttribute.Resist; } }
  public long MinDamageRate { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxDamageRate { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ShowHighlightFloater { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatDataGlobal.BulletArmorDamageFactorExcel> CreateBulletArmorDamageFactorExcel(FlatBufferBuilder builder,
      StringOffset DamageFactorGroupIdOffset = default(StringOffset),
      FlatDataGlobal.BulletType BulletType = FlatDataGlobal.BulletType.Normal,
      FlatDataGlobal.ArmorType ArmorType = FlatDataGlobal.ArmorType.LightArmor,
      long DamageRate = 0,
      FlatDataGlobal.DamageAttribute DamageAttribute = FlatDataGlobal.DamageAttribute.Resist,
      long MinDamageRate = 0,
      long MaxDamageRate = 0,
      bool ShowHighlightFloater = false) {
    builder.StartTable(8);
    BulletArmorDamageFactorExcel.AddMaxDamageRate(builder, MaxDamageRate);
    BulletArmorDamageFactorExcel.AddMinDamageRate(builder, MinDamageRate);
    BulletArmorDamageFactorExcel.AddDamageRate(builder, DamageRate);
    BulletArmorDamageFactorExcel.AddDamageAttribute(builder, DamageAttribute);
    BulletArmorDamageFactorExcel.AddArmorType(builder, ArmorType);
    BulletArmorDamageFactorExcel.AddBulletType(builder, BulletType);
    BulletArmorDamageFactorExcel.AddDamageFactorGroupId(builder, DamageFactorGroupIdOffset);
    BulletArmorDamageFactorExcel.AddShowHighlightFloater(builder, ShowHighlightFloater);
    return BulletArmorDamageFactorExcel.EndBulletArmorDamageFactorExcel(builder);
  }

  public static void StartBulletArmorDamageFactorExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddDamageFactorGroupId(FlatBufferBuilder builder, StringOffset DamageFactorGroupIdOffset) { builder.AddOffset(0, DamageFactorGroupIdOffset.Value, 0); }
  public static void AddBulletType(FlatBufferBuilder builder, FlatDataGlobal.BulletType BulletType) { builder.AddInt(1, (int)BulletType, 0); }
  public static void AddArmorType(FlatBufferBuilder builder, FlatDataGlobal.ArmorType ArmorType) { builder.AddInt(2, (int)ArmorType, 0); }
  public static void AddDamageRate(FlatBufferBuilder builder, long DamageRate) { builder.AddLong(3, DamageRate, 0); }
  public static void AddDamageAttribute(FlatBufferBuilder builder, FlatDataGlobal.DamageAttribute DamageAttribute) { builder.AddInt(4, (int)DamageAttribute, 0); }
  public static void AddMinDamageRate(FlatBufferBuilder builder, long MinDamageRate) { builder.AddLong(5, MinDamageRate, 0); }
  public static void AddMaxDamageRate(FlatBufferBuilder builder, long MaxDamageRate) { builder.AddLong(6, MaxDamageRate, 0); }
  public static void AddShowHighlightFloater(FlatBufferBuilder builder, bool ShowHighlightFloater) { builder.AddBool(7, ShowHighlightFloater, false); }
  public static Offset<FlatDataGlobal.BulletArmorDamageFactorExcel> EndBulletArmorDamageFactorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.BulletArmorDamageFactorExcel>(o);
  }
}


}
