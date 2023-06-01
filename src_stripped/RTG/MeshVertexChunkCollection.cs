// Decompiled with JetBrains decompiler
// Type: RTG.MeshVertexChunkCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MeshVertexChunkCollection : IEnumerable<MeshVertexChunk>, IEnumerable
  {
    private Mesh _mesh;
    private List<MeshVertexChunk> _vertexChunks;

    public MeshVertexChunk this[int chunkIndex]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<MeshVertexChunk> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MeshVertexChunk> GetWorldChunksHoveredByPoint(
      Vector3 hoverPoint,
      Matrix4x4 worldMtx,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshVertexChunk GetWorldVertChunkClosestToScreenPt(
      Vector2 screenPoint,
      Matrix4x4 worldMtx,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FromMesh(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshVertexChunkCollection() => throw null;

    private struct VertexChunkIndices
    {
      private int _XIndex;
      private int _YIndex;
      private int _ZIndex;

      public int XIndex
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int YIndex
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int ZIndex
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VertexChunkIndices(int xIndex, int yIndex, int zIndex) => throw null;
    }
  }
}
