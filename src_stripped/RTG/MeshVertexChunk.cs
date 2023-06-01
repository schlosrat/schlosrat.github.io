// Decompiled with JetBrains decompiler
// Type: RTG.MeshVertexChunk
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
  public class MeshVertexChunk : IEnumerable<Vector3>, IEnumerable
  {
    private List<Vector3> _modelSpaceVerts;
    private AABB _modelSpaceAABB;
    private Mesh _mesh;

    public Vector3 this[int vertexIndex]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Mesh Mesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int VertexCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AABB ModelSpaceAABB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<Vector3> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetWorldVertClosestToScreenPt(
      Vector2 screenPoint,
      Matrix4x4 worldMtx,
      Camera camera)
    {
      throw null;
    }
  }
}
