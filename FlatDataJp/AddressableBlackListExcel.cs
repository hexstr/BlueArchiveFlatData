// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatDataJp
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AddressableBlackListExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static AddressableBlackListExcel GetRootAsAddressableBlackListExcel(ByteBuffer _bb) { return GetRootAsAddressableBlackListExcel(_bb, new AddressableBlackListExcel()); }
  public static AddressableBlackListExcel GetRootAsAddressableBlackListExcel(ByteBuffer _bb, AddressableBlackListExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AddressableBlackListExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string FolderPath(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int FolderPathLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ResourcePath(int j) { int o = __p.__offset(8); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ResourcePathLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatDataJp.AddressableBlackListExcel> CreateAddressableBlackListExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset FolderPathOffset = default(VectorOffset),
      VectorOffset ResourcePathOffset = default(VectorOffset)) {
    builder.StartTable(3);
    AddressableBlackListExcel.AddId(builder, Id);
    AddressableBlackListExcel.AddResourcePath(builder, ResourcePathOffset);
    AddressableBlackListExcel.AddFolderPath(builder, FolderPathOffset);
    return AddressableBlackListExcel.EndAddressableBlackListExcel(builder);
  }

  public static void StartAddressableBlackListExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, long Id) { builder.AddLong(0, Id, 0); }
  public static void AddFolderPath(FlatBufferBuilder builder, VectorOffset FolderPathOffset) { builder.AddOffset(1, FolderPathOffset.Value, 0); }
  public static VectorOffset CreateFolderPathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFolderPathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFolderPathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFolderPathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFolderPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddResourcePath(FlatBufferBuilder builder, VectorOffset ResourcePathOffset) { builder.AddOffset(2, ResourcePathOffset.Value, 0); }
  public static VectorOffset CreateResourcePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateResourcePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResourcePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResourcePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResourcePathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatDataJp.AddressableBlackListExcel> EndAddressableBlackListExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatDataJp.AddressableBlackListExcel>(o);
  }
}


}
