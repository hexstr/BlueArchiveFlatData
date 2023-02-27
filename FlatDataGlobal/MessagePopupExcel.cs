// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataGlobal
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MessagePopupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_21(); }
  public static MessagePopupExcel GetRootAsMessagePopupExcel(ByteBuffer _bb) { return GetRootAsMessagePopupExcel(_bb, new MessagePopupExcel()); }
  public static MessagePopupExcel GetRootAsMessagePopupExcel(ByteBuffer _bb, MessagePopupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MessagePopupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint StringId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatDataGlobal.MessagePopupLayout MessagePopupLayout { get { int o = __p.__offset(6); return o != 0 ? (FlatDataGlobal.MessagePopupLayout)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MessagePopupLayout.TextOnly; } }
  public FlatDataGlobal.MessagePopupImagePositionType OrderType { get { int o = __p.__offset(8); return o != 0 ? (FlatDataGlobal.MessagePopupImagePositionType)__p.bb.GetInt(o + __p.bb_pos) : FlatDataGlobal.MessagePopupImagePositionType.ImageFirst; } }
  public string Image { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImageBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImageBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImageArray() { return __p.__vector_as_array<byte>(10); }
  public uint TitleText { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint MessageText { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool DisplayXButton { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatDataGlobal.MessagePopupButtonType Button(int j) { int o = __p.__offset(18); return o != 0 ? (FlatDataGlobal.MessagePopupButtonType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatDataGlobal.MessagePopupButtonType)0; }
  public int ButtonLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatDataGlobal.MessagePopupButtonType> GetButtonBytes() { return __p.__vector_as_span<FlatDataGlobal.MessagePopupButtonType>(18, 4); }
#else
  public ArraySegment<byte>? GetButtonBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public FlatDataGlobal.MessagePopupButtonType[] GetButtonArray() { int o = __p.__offset(18); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatDataGlobal.MessagePopupButtonType[] a = new FlatDataGlobal.MessagePopupButtonType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatDataGlobal.MessagePopupButtonType)__p.bb.GetInt(p + i * 4); } return a; }
  public uint ButtonText(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int ButtonTextLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetButtonTextBytes() { return __p.__vector_as_span<uint>(20, 4); }
#else
  public ArraySegment<byte>? GetButtonTextBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public uint[] GetButtonTextArray() { return __p.__vector_as_array<uint>(20); }
  public string ButtonCommand(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ButtonCommandLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ButtonParameter(int j) { int o = __p.__offset(24); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ButtonParameterLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataGlobal.MessagePopupExcel> CreateMessagePopupExcel(FlatBufferBuilder builder,
      uint StringId = 0,
      FlatDataGlobal.MessagePopupLayout MessagePopupLayout = FlatDataGlobal.MessagePopupLayout.TextOnly,
      FlatDataGlobal.MessagePopupImagePositionType OrderType = FlatDataGlobal.MessagePopupImagePositionType.ImageFirst,
      StringOffset ImageOffset = default(StringOffset),
      uint TitleText = 0,
      uint MessageText = 0,
      bool DisplayXButton = false,
      VectorOffset ButtonOffset = default(VectorOffset),
      VectorOffset ButtonTextOffset = default(VectorOffset),
      VectorOffset ButtonCommandOffset = default(VectorOffset),
      VectorOffset ButtonParameterOffset = default(VectorOffset)) {
    builder.StartTable(11);
    MessagePopupExcel.AddButtonParameter(builder, ButtonParameterOffset);
    MessagePopupExcel.AddButtonCommand(builder, ButtonCommandOffset);
    MessagePopupExcel.AddButtonText(builder, ButtonTextOffset);
    MessagePopupExcel.AddButton(builder, ButtonOffset);
    MessagePopupExcel.AddMessageText(builder, MessageText);
    MessagePopupExcel.AddTitleText(builder, TitleText);
    MessagePopupExcel.AddImage(builder, ImageOffset);
    MessagePopupExcel.AddOrderType(builder, OrderType);
    MessagePopupExcel.AddMessagePopupLayout(builder, MessagePopupLayout);
    MessagePopupExcel.AddStringId(builder, StringId);
    MessagePopupExcel.AddDisplayXButton(builder, DisplayXButton);
    return MessagePopupExcel.EndMessagePopupExcel(builder);
  }

  public static void StartMessagePopupExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddStringId(FlatBufferBuilder builder, uint StringId) { builder.AddUint(0, StringId, 0); }
  public static void AddMessagePopupLayout(FlatBufferBuilder builder, FlatDataGlobal.MessagePopupLayout MessagePopupLayout) { builder.AddInt(1, (int)MessagePopupLayout, 0); }
  public static void AddOrderType(FlatBufferBuilder builder, FlatDataGlobal.MessagePopupImagePositionType OrderType) { builder.AddInt(2, (int)OrderType, 0); }
  public static void AddImage(FlatBufferBuilder builder, StringOffset ImageOffset) { builder.AddOffset(3, ImageOffset.Value, 0); }
  public static void AddTitleText(FlatBufferBuilder builder, uint TitleText) { builder.AddUint(4, TitleText, 0); }
  public static void AddMessageText(FlatBufferBuilder builder, uint MessageText) { builder.AddUint(5, MessageText, 0); }
  public static void AddDisplayXButton(FlatBufferBuilder builder, bool DisplayXButton) { builder.AddBool(6, DisplayXButton, false); }
  public static void AddButton(FlatBufferBuilder builder, VectorOffset ButtonOffset) { builder.AddOffset(7, ButtonOffset.Value, 0); }
  public static VectorOffset CreateButtonVector(FlatBufferBuilder builder, FlatDataGlobal.MessagePopupButtonType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, FlatDataGlobal.MessagePopupButtonType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatDataGlobal.MessagePopupButtonType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatDataGlobal.MessagePopupButtonType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonText(FlatBufferBuilder builder, VectorOffset ButtonTextOffset) { builder.AddOffset(8, ButtonTextOffset.Value, 0); }
  public static VectorOffset CreateButtonTextVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonTextVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonCommand(FlatBufferBuilder builder, VectorOffset ButtonCommandOffset) { builder.AddOffset(9, ButtonCommandOffset.Value, 0); }
  public static VectorOffset CreateButtonCommandVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonCommandVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonParameter(FlatBufferBuilder builder, VectorOffset ButtonParameterOffset) { builder.AddOffset(10, ButtonParameterOffset.Value, 0); }
  public static VectorOffset CreateButtonParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataGlobal.MessagePopupExcel> EndMessagePopupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataGlobal.MessagePopupExcel>(o);
  }
}


}
