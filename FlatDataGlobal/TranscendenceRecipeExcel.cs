// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TranscendenceRecipeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static TranscendenceRecipeExcel GetRootAsTranscendenceRecipeExcel(ByteBuffer _bb) { return GetRootAsTranscendenceRecipeExcel(_bb, new TranscendenceRecipeExcel()); }
  public static TranscendenceRecipeExcel GetRootAsTranscendenceRecipeExcel(ByteBuffer _bb, TranscendenceRecipeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TranscendenceRecipeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(6); }
  public FlatDataGlobal.CurrencyTypes CostCurrencyType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.CurrencyTypes.Invalid; } }
  public long CostCurrencyAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatDataGlobal.ParcelType ParcelType_(int j) { int o = __p.__offset(12); return o != 0 ? (FlatDataGlobal.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.ParcelType)0; }
  public int ParcelType_Length { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.ParcelType> GetParcelType_Bytes() { return __p.__vector_as_span<FlatDataGlobal.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetParcelType_Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatDataGlobal.ParcelType[] GetParcelType_Array() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.ParcelType[] a = new FlatDataGlobal.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public int ParcelAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ParcelAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetParcelAmountBytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetParcelAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetParcelAmountArray() { return __p.__vector_as_array<int>(16); }

  public static Offset<FlatDataGlobal.TranscendenceRecipeExcel> CreateTranscendenceRecipeExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset DevNameOffset = default(StringOffset),
      FlatDataGlobal.CurrencyTypes CostCurrencyType = FlatDataGlobal.CurrencyTypes.Invalid,
      long CostCurrencyAmount = 0,
      VectorOffset ParcelType_Offset = default(VectorOffset),
      VectorOffset ParcelIdOffset = default(VectorOffset),
      VectorOffset ParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(7);
    TranscendenceRecipeExcel.AddCostCurrencyAmount(builder, CostCurrencyAmount);
    TranscendenceRecipeExcel.AddId(builder, Id);
    TranscendenceRecipeExcel.AddParcelAmount(builder, ParcelAmountOffset);
    TranscendenceRecipeExcel.AddParcelId(builder, ParcelIdOffset);
    TranscendenceRecipeExcel.AddParcelType_(builder, ParcelType_Offset);
    TranscendenceRecipeExcel.AddCostCurrencyType(builder, CostCurrencyType);
    TranscendenceRecipeExcel.AddDevName(builder, DevNameOffset);
    return TranscendenceRecipeExcel.EndTranscendenceRecipeExcel(builder);
  }

  public static void StartTranscendenceRecipeExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset DevNameOffset) { builder.AddOffset(1, DevNameOffset.Value, 0); }
  public static void AddCostCurrencyType(FlatBufferBuilder builder, FlatDataGlobal.CurrencyTypes CostCurrencyType) { builder.AddInt(2, (int)CostCurrencyType, 0); }
  public static void AddCostCurrencyAmount(FlatBufferBuilder builder, long CostCurrencyAmount) { builder.AddLong(3, CostCurrencyAmount, 0); }
  public static void AddParcelType_(FlatBufferBuilder builder, VectorOffset ParcelType_Offset) { builder.AddOffset(4, ParcelType_Offset.Value, 0); }
  public static VectorOffset CreateParcelType_Vector(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, FlatDataGlobal.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelType_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParcelId(FlatBufferBuilder builder, VectorOffset ParcelIdOffset) { builder.AddOffset(5, ParcelIdOffset.Value, 0); }
  public static VectorOffset CreateParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddParcelAmount(FlatBufferBuilder builder, VectorOffset ParcelAmountOffset) { builder.AddOffset(6, ParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateParcelAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.TranscendenceRecipeExcel> EndTranscendenceRecipeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.TranscendenceRecipeExcel>(o);
  }
}


}
