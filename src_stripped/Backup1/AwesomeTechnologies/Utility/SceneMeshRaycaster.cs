// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.SceneMeshRaycaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public class SceneMeshRaycaster
  {
    private readonly MethodInfo _methIntersectRayMesh;
    public List<MeshRendererRaycastInfo> MeshRendererRaycastInfoList;
    public List<TerrainCollider> SceneTerrainColliderList;
    public AwesomeTechnologies.External.Octree.BoundsOctree<MeshRendererRaycastInfo> BoundsOctree;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneMeshRaycaster() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetSceneBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupOctree() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindMeshRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IntersectRayMesh(Ray ray, MeshFilter meshFilter, out RaycastHit hit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IntersectRayMesh(Ray ray, Mesh mesh, Matrix4x4 matrix, out RaycastHit hit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastSceneMeshes(
      Ray ray,
      out RaycastHit hit,
      bool includeTerrain,
      bool includeColliders,
      bool includeMeshes)
    {
      throw null;
    }
  }
}
