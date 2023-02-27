// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GoodsExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static GoodsExcel GetRootAsGoodsExcel(ByteBuffer _bb) { return GetRootAsGoodsExcel(_bb, new GoodsExcel()); }
  public static GoodsExcel GetRootAsGoodsExcel(ByteBuffer _bb, GoodsExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GoodsExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (FlatDataJp.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.Rarity.N; } }
  public string IconPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(10); }
  public FlatDataJp.ParcelType ConsumeParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int ConsumeParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetConsumeParcelTypeBytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetConsumeParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatDataJp.ParcelType[] GetConsumeParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ConsumeParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetConsumeParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetConsumeParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long ConsumeParcelAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeParcelAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeParcelAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetConsumeParcelAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetConsumeParcelAmountArray() { return __p.__vector_as_array<long>(16); }
  public FlatDataJp.ConsumeCondition ConsumeCondition_(int j) { int o = __p.__offset(18); return o != 0 ? (FlatDataJp.ConsumeCondition)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ConsumeCondition)0; }
  public int ConsumeCondition_Length { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ConsumeCondition> GetConsumeCondition_Bytes() { return __p.__vector_as_span<FlatDataJp.ConsumeCondition>(18, 4); }
#else
  public ArraySegment<byte>? GetConsumeCondition_Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public FlatDataJp.ConsumeCondition[] GetConsumeCondition_Array() { int o = __p.__offset(18); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ConsumeCondition[] a = new FlatDataJp.ConsumeCondition[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ConsumeCondition)__p.bb.GetInt(p + i * 4); } return a; }
  public FlatDataJp.GachaTicketType ConsumeGachaTicketType { get { int o = __p.__offset(20); return o != 0 ? (FlatDataJp.GachaTicketType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.GachaTicketType.None; } }
  public long ConsumeGachaTicketTypeAmount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ProductIdAOS { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ProductIdiOS { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConsumeExtraStep(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeExtraStepLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeExtraStepBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetConsumeExtraStepBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetConsumeExtraStepArray() { return __p.__vector_as_array<long>(28); }
  public long ConsumeExtraAmount(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeExtraAmountLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeExtraAmountBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetConsumeExtraAmountBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetConsumeExtraAmountArray() { return __p.__vector_as_array<long>(30); }
  public int State { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatDataJp.ParcelType ParcelType_(int j) { int o = __p.__offset(34); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.ParcelType)0; }
  public int ParcelType_Length { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.ParcelType> GetParcelType_Bytes() { return __p.__vector_as_span<FlatDataJp.ParcelType>(34, 4); }
#else
  public ArraySegment<byte>? GetParcelType_Bytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatDataJp.ParcelType[] GetParcelType_Array() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.ParcelType[] a = new FlatDataJp.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ParcelId(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelIdBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetParcelIdBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetParcelIdArray() { return __p.__vector_as_array<long>(36); }
  public long ParcelAmount(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelAmountLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelAmountBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetParcelAmountBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetParcelAmountArray() { return __p.__vector_as_array<long>(38); }

  public static Offset<FlatDataJp.GoodsExcel> CreateGoodsExcel(FlatBufferBuilder builder,
      long Id = 0,
      int Type = 0,
      FlatDataJp.Rarity Rarity = FlatDataJp.Rarity.N,
      StringOffset IconPathOffset = default(StringOffset),
      VectorOffset ConsumeParcelTypeOffset = default(VectorOffset),
      VectorOffset ConsumeParcelIdOffset = default(VectorOffset),
      VectorOffset ConsumeParcelAmountOffset = default(VectorOffset),
      VectorOffset ConsumeCondition_Offset = default(VectorOffset),
      FlatDataJp.GachaTicketType ConsumeGachaTicketType = FlatDataJp.GachaTicketType.None,
      long ConsumeGachaTicketTypeAmount = 0,
      long ProductIdAOS = 0,
      long ProductIdiOS = 0,
      VectorOffset ConsumeExtraStepOffset = default(VectorOffset),
      VectorOffset ConsumeExtraAmountOffset = default(VectorOffset),
      int State = 0,
      VectorOffset ParcelType_Offset = default(VectorOffset),
      VectorOffset ParcelIdOffset = default(VectorOffset),
      VectorOffset ParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(18);
    GoodsExcel.AddProductIdiOS(builder, ProductIdiOS);
    GoodsExcel.AddProductIdAOS(builder, ProductIdAOS);
    GoodsExcel.AddConsumeGachaTicketTypeAmount(builder, ConsumeGachaTicketTypeAmount);
    GoodsExcel.AddId(builder, Id);
    GoodsExcel.AddParcelAmount(builder, ParcelAmountOffset);
    GoodsExcel.AddParcelId(builder, ParcelIdOffset);
    GoodsExcel.AddParcelType_(builder, ParcelType_Offset);
    GoodsExcel.AddState(builder, State);
    GoodsExcel.AddConsumeExtraAmount(builder, ConsumeExtraAmountOffset);
    GoodsExcel.AddConsumeExtraStep(builder, ConsumeExtraStepOffset);
    GoodsExcel.AddConsumeGachaTicketType(builder, ConsumeGachaTicketType);
    GoodsExcel.AddConsumeCondition_(builder, ConsumeCondition_Offset);
    GoodsExcel.AddConsumeParcelAmount(builder, ConsumeParcelAmountOffset);
    GoodsExcel.AddConsumeParcelId(builder, ConsumeParcelIdOffset);
    GoodsExcel.AddConsumeParcelType(builder, ConsumeParcelTypeOffset);
    GoodsExcel.AddIconPath(builder, IconPathOffset);
    GoodsExcel.AddRarity(builder, Rarity);
    GoodsExcel.AddType(builder, Type);
    return GoodsExcel.EndGoodsExcel(builder);
  }

  public static void StartGoodsExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatDataJp.Rarity Rarity) { builder.AddInt(2, (int)Rarity, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(3, IconPathOffset.Value, 0); }
  public static void AddConsumeParcelType(FlatBufferBuilder builder, VectorOffset ConsumeParcelTypeOffset) { builder.AddOffset(4, ConsumeParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelTypeVector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConsumeParcelId(FlatBufferBuilder builder, VectorOffset ConsumeParcelIdOffset) { builder.AddOffset(5, ConsumeParcelIdOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeParcelAmount(FlatBufferBuilder builder, VectorOffset ConsumeParcelAmountOffset) { builder.AddOffset(6, ConsumeParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeCondition_(FlatBufferBuilder builder, VectorOffset ConsumeCondition_Offset) { builder.AddOffset(7, ConsumeCondition_Offset.Value, 0); }
  public static VectorOffset CreateConsumeCondition_Vector(FlatBufferBuilder builder, FlatDataJp.ConsumeCondition[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeCondition_VectorBlock(FlatBufferBuilder builder, FlatDataJp.ConsumeCondition[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeCondition_VectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ConsumeCondition> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeCondition_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ConsumeCondition>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeCondition_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConsumeGachaTicketType(FlatBufferBuilder builder, FlatDataJp.GachaTicketType ConsumeGachaTicketType) { builder.AddInt(8, (int)ConsumeGachaTicketType, 0); }
  public static void AddConsumeGachaTicketTypeAmount(FlatBufferBuilder builder, long ConsumeGachaTicketTypeAmount) { builder.AddLong(9, ConsumeGachaTicketTypeAmount, 0); }
  public static void AddProductIdAOS(FlatBufferBuilder builder, long ProductIdAOS) { builder.AddLong(10, ProductIdAOS, 0); }
  public static void AddProductIdiOS(FlatBufferBuilder builder, long ProductIdiOS) { builder.AddLong(11, ProductIdiOS, 0); }
  public static void AddConsumeExtraStep(FlatBufferBuilder builder, VectorOffset ConsumeExtraStepOffset) { builder.AddOffset(12, ConsumeExtraStepOffset.Value, 0); }
  public static VectorOffset CreateConsumeExtraStepVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeExtraStepVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeExtraAmount(FlatBufferBuilder builder, VectorOffset ConsumeExtraAmountOffset) { builder.AddOffset(13, ConsumeExtraAmountOffset.Value, 0); }
  public static VectorOffset CreateConsumeExtraAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeExtraAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddState(FlatBufferBuilder builder, int State) { builder.AddInt(14, State, 0); }
  public static void AddParcelType_(FlatBufferBuilder builder, VectorOffset ParcelType_Offset) { builder.AddOffset(15, ParcelType_Offset.Value, 0); }
  public static VectorOffset CreateParcelType_Vector(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, FlatDataJp.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelType_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelType_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParcelId(FlatBufferBuilder builder, VectorOffset ParcelIdOffset) { builder.AddOffset(16, ParcelIdOffset.Value, 0); }
  public static VectorOffset CreateParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddParcelAmount(FlatBufferBuilder builder, VectorOffset ParcelAmountOffset) { builder.AddOffset(17, ParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatDataJp.GoodsExcel> EndGoodsExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.GoodsExcel>(o);
  }
}


}
