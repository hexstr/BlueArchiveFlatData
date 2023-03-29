// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterIllustCoordinateExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static CharacterIllustCoordinateExcel GetRootAsCharacterIllustCoordinateExcel(ByteBuffer _bb) { return GetRootAsCharacterIllustCoordinateExcel(_bb, new CharacterIllustCoordinateExcel()); }
  public static CharacterIllustCoordinateExcel GetRootAsCharacterIllustCoordinateExcel(ByteBuffer _bb, CharacterIllustCoordinateExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterIllustCoordinateExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float CharacterBodyCenterX { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CharacterBodyCenterY { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DefaultScale { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MinScale { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MaxScale { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatDataGlobal.CharacterIllustCoordinateExcel> CreateCharacterIllustCoordinateExcel(FlatBufferBuilder builder,
      long Id = 0,
      float CharacterBodyCenterX = 0.0f,
      float CharacterBodyCenterY = 0.0f,
      float DefaultScale = 0.0f,
      float MinScale = 0.0f,
      float MaxScale = 0.0f) {
    builder.StartTable(6);
    CharacterIllustCoordinateExcel.AddId(builder, Id);
    CharacterIllustCoordinateExcel.AddMaxScale(builder, MaxScale);
    CharacterIllustCoordinateExcel.AddMinScale(builder, MinScale);
    CharacterIllustCoordinateExcel.AddDefaultScale(builder, DefaultScale);
    CharacterIllustCoordinateExcel.AddCharacterBodyCenterY(builder, CharacterBodyCenterY);
    CharacterIllustCoordinateExcel.AddCharacterBodyCenterX(builder, CharacterBodyCenterX);
    return CharacterIllustCoordinateExcel.EndCharacterIllustCoordinateExcel(builder);
  }

  public static void StartCharacterIllustCoordinateExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddCharacterBodyCenterX(FlatBufferBuilder builder, float CharacterBodyCenterX) { builder.AddFloat(1, CharacterBodyCenterX, 0.0f); }
  public static void AddCharacterBodyCenterY(FlatBufferBuilder builder, float CharacterBodyCenterY) { builder.AddFloat(2, CharacterBodyCenterY, 0.0f); }
  public static void AddDefaultScale(FlatBufferBuilder builder, float DefaultScale) { builder.AddFloat(3, DefaultScale, 0.0f); }
  public static void AddMinScale(FlatBufferBuilder builder, float MinScale) { builder.AddFloat(4, MinScale, 0.0f); }
  public static void AddMaxScale(FlatBufferBuilder builder, float MaxScale) { builder.AddFloat(5, MaxScale, 0.0f); }
  public static Offset<FlatDataGlobal.CharacterIllustCoordinateExcel> EndCharacterIllustCoordinateExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.CharacterIllustCoordinateExcel>(o);
  }
}


}
