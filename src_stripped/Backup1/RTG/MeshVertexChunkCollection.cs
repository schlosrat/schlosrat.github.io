// Decompiled with JetBrains decompiler
// Type: RTG.MeshVertexChunkCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
