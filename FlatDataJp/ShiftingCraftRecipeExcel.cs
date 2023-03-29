// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShiftingCraftRecipeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ShiftingCraftRecipeExcel GetRootAsShiftingCraftRecipeExcel(ByteBuffer _bb) { return GetRootAsShiftingCraftRecipeExcel(_bb, new ShiftingCraftRecipeExcel()); }
  public static ShiftingCraftRecipeExcel GetRootAsShiftingCraftRecipeExcel(ByteBuffer _bb, ShiftingCraftRecipeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShiftingCraftRecipeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int NotificationId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ParcelType ResultParcel { get { int o = __p.__offset(10); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long ResultId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ResultAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RequireItemId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RequireItemAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RequireGold { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataJp.Tag IngredientTag(int j) { int o = __p.__offset(22); return o != 0 ? (FlatDataJp.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.Tag)0; }
  public int IngredientTagLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.Tag> GetIngredientTagBytes() { return __p.__vector_as_span<FlatDataJp.Tag>(22, 4); }
#else
  public ArraySegment<byte>? GetIngredientTagBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public FlatDataJp.Tag[] GetIngredientTagArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.Tag[] a = new FlatDataJp.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long IngredientExp { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatDataJp.ShiftingCraftRecipeExcel> CreateShiftingCraftRecipeExcel(FlatBufferBuilder builder,
      long Id = 0,
      long DisplayOrder = 0,
      int NotificationId = 0,
      FlatDataJp.ParcelType ResultParcel = FlatDataJp.ParcelType.None,
      long ResultId = 0,
      long ResultAmount = 0,
      long RequireItemId = 0,
      long RequireItemAmount = 0,
      long RequireGold = 0,
      VectorOffset IngredientTagOffset = default(VectorOffset),
      long IngredientExp = 0) {
    builder.StartTable(11);
    ShiftingCraftRecipeExcel.AddIngredientExp(builder, IngredientExp);
    ShiftingCraftRecipeExcel.AddRequireGold(builder, RequireGold);
    ShiftingCraftRecipeExcel.AddRequireItemAmount(builder, RequireItemAmount);
    ShiftingCraftRecipeExcel.AddRequireItemId(builder, RequireItemId);
    ShiftingCraftRecipeExcel.AddResultAmount(builder, ResultAmount);
    ShiftingCraftRecipeExcel.AddResultId(builder, ResultId);
    ShiftingCraftRecipeExcel.AddDisplayOrder(builder, DisplayOrder);
    ShiftingCraftRecipeExcel.AddId(builder, Id);
    ShiftingCraftRecipeExcel.AddIngredientTag(builder, IngredientTagOffset);
    ShiftingCraftRecipeExcel.AddResultParcel(builder, ResultParcel);
    ShiftingCraftRecipeExcel.AddNotificationId(builder, NotificationId);
    return ShiftingCraftRecipeExcel.EndShiftingCraftRecipeExcel(builder);
  }

  public static void StartShiftingCraftRecipeExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long DisplayOrder) { builder.AddLong(1, DisplayOrder, 0); }
  public static void AddNotificationId(FlatBufferBuilder builder, int NotificationId) { builder.AddInt(2, NotificationId, 0); }
  public static void AddResultParcel(FlatBufferBuilder builder, FlatDataJp.ParcelType ResultParcel) { builder.AddInt(3, (int)ResultParcel, 0); }
  public static void AddResultId(FlatBufferBuilder builder, long ResultId) { builder.AddLong(4, ResultId, 0); }
  public static void AddResultAmount(FlatBufferBuilder builder, long ResultAmount) { builder.AddLong(5, ResultAmount, 0); }
  public static void AddRequireItemId(FlatBufferBuilder builder, long RequireItemId) { builder.AddLong(6, RequireItemId, 0); }
  public static void AddRequireItemAmount(FlatBufferBuilder builder, long RequireItemAmount) { builder.AddLong(7, RequireItemAmount, 0); }
  public static void AddRequireGold(FlatBufferBuilder builder, long RequireGold) { builder.AddLong(8, RequireGold, 0); }
  public static void AddIngredientTag(FlatBufferBuilder builder, VectorOffset IngredientTagOffset) { builder.AddOffset(9, IngredientTagOffset.Value, 0); }
  public static VectorOffset CreateIngredientTagVector(FlatBufferBuilder builder, FlatDataJp.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIngredientTagVectorBlock(FlatBufferBuilder builder, FlatDataJp.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientTagVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIngredientTagVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIngredientExp(FlatBufferBuilder builder, long IngredientExp) { builder.AddLong(10, IngredientExp, 0); }
  public static Offset<FlatDataJp.ShiftingCraftRecipeExcel> EndShiftingCraftRecipeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.ShiftingCraftRecipeExcel>(o);
  }
}


}
