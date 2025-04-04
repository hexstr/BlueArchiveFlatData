// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RecipeCraftExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static RecipeCraftExcel GetRootAsRecipeCraftExcel(ByteBuffer _bb) { return GetRootAsRecipeCraftExcel(_bb, new RecipeCraftExcel()); }
  public static RecipeCraftExcel GetRootAsRecipeCraftExcel(ByteBuffer _bb, RecipeCraftExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeCraftExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(6); }
  public FlatDataGlobal.RecipeType RecipeType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.RecipeType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.RecipeType.None; } }
  public long RecipeIngredientId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RecipeIngredientDevName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRecipeIngredientDevNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetRecipeIngredientDevNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetRecipeIngredientDevNameArray() { return __p.__vector_as_array<byte>(12); }
  public FlatDataGlobal.ParcelType ParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int ParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetParcelTypeBytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatDataGlobal.ParcelType[] GetParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ParcelId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetParcelIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetParcelIdArray() { return __p.__vector_as_array<long>(16); }
  public string ParcelDevName(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ParcelDevNameLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long ResultAmountMin(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ResultAmountMinLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetResultAmountMinBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetResultAmountMinBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetResultAmountMinArray() { return __p.__vector_as_array<long>(20); }
  public long ResultAmountMax(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ResultAmountMaxLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetResultAmountMaxBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetResultAmountMaxBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetResultAmountMaxArray() { return __p.__vector_as_array<long>(22); }

  public static Offset<FlatDataGlobal.RecipeCraftExcel> CreateRecipeCraftExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset DevNameOffset = default(StringOffset),
      FlatDataGlobal.RecipeType recipeType = FlatDataGlobal.RecipeType.None,
      long RecipeIngredientId = 0,
      StringOffset RecipeIngredientDevNameOffset = default(StringOffset),
      VectorOffset ParcelTypeOffset = default(VectorOffset),
      VectorOffset ParcelIdOffset = default(VectorOffset),
      VectorOffset ParcelDevNameOffset = default(VectorOffset),
      VectorOffset ResultAmountMinOffset = default(VectorOffset),
      VectorOffset ResultAmountMaxOffset = default(VectorOffset)) {
    builder.StartTable(10);
    RecipeCraftExcel.AddRecipeIngredientId(builder, RecipeIngredientId);
    RecipeCraftExcel.AddId(builder, Id);
    RecipeCraftExcel.AddResultAmountMax(builder, ResultAmountMaxOffset);
    RecipeCraftExcel.AddResultAmountMin(builder, ResultAmountMinOffset);
    RecipeCraftExcel.AddParcelDevName(builder, ParcelDevNameOffset);
    RecipeCraftExcel.AddParcelId(builder, ParcelIdOffset);
    RecipeCraftExcel.AddParcelType(builder, ParcelTypeOffset);
    RecipeCraftExcel.AddRecipeIngredientDevName(builder, RecipeIngredientDevNameOffset);
    RecipeCraftExcel.AddRecipeType(builder, recipeType);
    RecipeCraftExcel.AddDevName(builder, DevNameOffset);
    return RecipeCraftExcel.EndRecipeCraftExcel(builder);
  }

  public static void StartRecipeCraftExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset DevNameOffset) { builder.AddOffset(1, DevNameOffset.Value, 0); }
  public static void AddRecipeType(FlatBufferBuilder builder, FlatDataGlobal.RecipeType recipeType) { builder.AddInt(2, (int)recipeType, 0); }
  public static void AddRecipeIngredientId(FlatBufferBuilder builder, long RecipeIngredientId) { builder.AddLong(3, RecipeIngredientId, 0); }
  public static void AddRecipeIngredientDevName(FlatBufferBuilder builder, StringOffset RecipeIngredientDevNameOffset) { builder.AddOffset(4, RecipeIngredientDevNameOffset.Value, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, VectorOffset ParcelTypeOffset) { builder.AddOffset(5, ParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateParcelTypeVector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParcelId(FlatBufferBuilder builder, VectorOffset ParcelIdOffset) { builder.AddOffset(6, ParcelIdOffset.Value, 0); }
  public static VectorOffset CreateParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddParcelDevName(FlatBufferBuilder builder, VectorOffset ParcelDevNameOffset) { builder.AddOffset(7, ParcelDevNameOffset.Value, 0); }
  public static VectorOffset CreateParcelDevNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParcelDevNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelDevNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelDevNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelDevNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddResultAmountMin(FlatBufferBuilder builder, VectorOffset ResultAmountMinOffset) { builder.AddOffset(8, ResultAmountMinOffset.Value, 0); }
  public static VectorOffset CreateResultAmountMinVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResultAmountMinVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddResultAmountMax(FlatBufferBuilder builder, VectorOffset ResultAmountMaxOffset) { builder.AddOffset(9, ResultAmountMaxOffset.Value, 0); }
  public static VectorOffset CreateResultAmountMaxVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResultAmountMaxVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataGlobal.RecipeCraftExcel> EndRecipeCraftExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.RecipeCraftExcel>(o);
  }
}


}
