// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CafeInteractionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static CafeInteractionExcel GetRootAsCafeInteractionExcel(ByteBuffer _bb) { return GetRootAsCafeInteractionExcel(_bb, new CafeInteractionExcel()); }
  public static CafeInteractionExcel GetRootAsCafeInteractionExcel(ByteBuffer _bb, CafeInteractionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CafeInteractionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IgnoreIfUnobtained { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string IgnoreIfUnobtainedStartDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIgnoreIfUnobtainedStartDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIgnoreIfUnobtainedStartDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIgnoreIfUnobtainedStartDateArray() { return __p.__vector_as_array<byte>(8); }
  public string IgnoreIfUnobtainedEndDate { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIgnoreIfUnobtainedEndDateBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIgnoreIfUnobtainedEndDateBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIgnoreIfUnobtainedEndDateArray() { return __p.__vector_as_array<byte>(10); }
  public FlatDataJp.BubbleType BubbleType_(int j) { int o = __p.__offset(12); return o != 0 ? (FlatDataJp.BubbleType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataJp.BubbleType)0; }
  public int BubbleType_Length { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataJp.BubbleType> GetBubbleType_Bytes() { return __p.__vector_as_span<FlatDataJp.BubbleType>(12, 4); }
#else
  public ArraySegment<byte>? GetBubbleType_Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatDataJp.BubbleType[] GetBubbleType_Array() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataJp.BubbleType[] a = new FlatDataJp.BubbleType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataJp.BubbleType)__p.bb.GetInt(p + i * 4); } return a; }
  public long BubbleDuration(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BubbleDurationLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBubbleDurationBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetBubbleDurationBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetBubbleDurationArray() { return __p.__vector_as_array<long>(14); }
  public FlatDataJp.ParcelType FavorEmoticonRewardParcelType { get { int o = __p.__offset(16); return o != 0 ? (FlatDataJp.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataJp.ParcelType.None; } }
  public long FavorEmoticonRewardId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FavorEmoticonRewardAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string CafeCharacterState(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int CafeCharacterStateLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.CafeInteractionExcel> CreateCafeInteractionExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      bool IgnoreIfUnobtained = false,
      StringOffset IgnoreIfUnobtainedStartDateOffset = default(StringOffset),
      StringOffset IgnoreIfUnobtainedEndDateOffset = default(StringOffset),
      VectorOffset BubbleType_Offset = default(VectorOffset),
      VectorOffset BubbleDurationOffset = default(VectorOffset),
      FlatDataJp.ParcelType FavorEmoticonRewardParcelType = FlatDataJp.ParcelType.None,
      long FavorEmoticonRewardId = 0,
      long FavorEmoticonRewardAmount = 0,
      VectorOffset CafeCharacterStateOffset = default(VectorOffset)) {
    builder.StartTable(10);
    CafeInteractionExcel.AddFavorEmoticonRewardAmount(builder, FavorEmoticonRewardAmount);
    CafeInteractionExcel.AddFavorEmoticonRewardId(builder, FavorEmoticonRewardId);
    CafeInteractionExcel.AddCharacterId(builder, CharacterId);
    CafeInteractionExcel.AddCafeCharacterState(builder, CafeCharacterStateOffset);
    CafeInteractionExcel.AddFavorEmoticonRewardParcelType(builder, FavorEmoticonRewardParcelType);
    CafeInteractionExcel.AddBubbleDuration(builder, BubbleDurationOffset);
    CafeInteractionExcel.AddBubbleType_(builder, BubbleType_Offset);
    CafeInteractionExcel.AddIgnoreIfUnobtainedEndDate(builder, IgnoreIfUnobtainedEndDateOffset);
    CafeInteractionExcel.AddIgnoreIfUnobtainedStartDate(builder, IgnoreIfUnobtainedStartDateOffset);
    CafeInteractionExcel.AddIgnoreIfUnobtained(builder, IgnoreIfUnobtained);
    return CafeInteractionExcel.EndCafeInteractionExcel(builder);
  }

  public static void StartCafeInteractionExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddCharacterId(FlatBufferBuilder builder, long CharacterId) { builder.AddLong(0, CharacterId, 0); }
  public static void AddIgnoreIfUnobtained(FlatBufferBuilder builder, bool IgnoreIfUnobtained) { builder.AddBool(1, IgnoreIfUnobtained, false); }
  public static void AddIgnoreIfUnobtainedStartDate(FlatBufferBuilder builder, StringOffset IgnoreIfUnobtainedStartDateOffset) { builder.AddOffset(2, IgnoreIfUnobtainedStartDateOffset.Value, 0); }
  public static void AddIgnoreIfUnobtainedEndDate(FlatBufferBuilder builder, StringOffset IgnoreIfUnobtainedEndDateOffset) { builder.AddOffset(3, IgnoreIfUnobtainedEndDateOffset.Value, 0); }
  public static void AddBubbleType_(FlatBufferBuilder builder, VectorOffset BubbleType_Offset) { builder.AddOffset(4, BubbleType_Offset.Value, 0); }
  public static VectorOffset CreateBubbleType_Vector(FlatBufferBuilder builder, FlatDataJp.BubbleType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBubbleType_VectorBlock(FlatBufferBuilder builder, FlatDataJp.BubbleType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBubbleType_VectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataJp.BubbleType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBubbleType_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataJp.BubbleType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBubbleType_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBubbleDuration(FlatBufferBuilder builder, VectorOffset BubbleDurationOffset) { builder.AddOffset(5, BubbleDurationOffset.Value, 0); }
  public static VectorOffset CreateBubbleDurationVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBubbleDurationVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBubbleDurationVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBubbleDurationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBubbleDurationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddFavorEmoticonRewardParcelType(FlatBufferBuilder builder, FlatDataJp.ParcelType FavorEmoticonRewardParcelType) { builder.AddInt(6, (int)FavorEmoticonRewardParcelType, 0); }
  public static void AddFavorEmoticonRewardId(FlatBufferBuilder builder, long FavorEmoticonRewardId) { builder.AddLong(7, FavorEmoticonRewardId, 0); }
  public static void AddFavorEmoticonRewardAmount(FlatBufferBuilder builder, long FavorEmoticonRewardAmount) { builder.AddLong(8, FavorEmoticonRewardAmount, 0); }
  public static void AddCafeCharacterState(FlatBufferBuilder builder, VectorOffset CafeCharacterStateOffset) { builder.AddOffset(9, CafeCharacterStateOffset.Value, 0); }
  public static VectorOffset CreateCafeCharacterStateVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeCharacterStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeCharacterStateVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.CafeInteractionExcel> EndCafeInteractionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.CafeInteractionExcel>(o);
  }
}


}
