// Decompiled with JetBrains decompiler
// Type: RTG.RTMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTMesh
  {
    private Mesh _unityMesh;
    private Vector3[] _vertices;
    private int[] _vertIndices;
    private int _numTriangles;
    private AABB _aabb;
    private MeshTree _meshTree;

    public int NumTriangles
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Mesh UnityMesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AABB AABB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsTreeBuilt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTMesh(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RTMesh Create(Mesh unityMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildTree() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshTriangle GetTriangle(int triangleIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugDrawTree() => throw null;
  }
}
