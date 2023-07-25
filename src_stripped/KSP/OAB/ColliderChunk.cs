// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ColliderChunk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ColliderChunk
  {
    public MeshCollider collider;
    private Mesh mesh;
    private List<int> tris;
    private MeshPoint[] pts;
    private int nSides;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColliderChunk(
      MeshArc bottom,
      MeshArc top,
      int nSidesTotal,
      int nArcs,
      int nColliders,
      int subdivIdx)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshCollider CreateColliderGO(GameObject parent, string name, int layer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh GenerateColliderMesh(bool triangulate, Vector3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void TriangulateColliderMesh(MeshPoint[] pts, List<int> tris) => throw null;
  }
}
