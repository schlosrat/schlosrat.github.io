// Decompiled with JetBrains decompiler
// Type: RTG.GameObjectRayHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GameObjectRayHit
  {
    private GameObject _hitObject;
    private Vector3 _hitPoint;
    private float _hitEnter;
    private Vector3 _hitNormal;
    private Plane _hitPlane;
    private MeshRayHit _meshRayHit;

    public GameObject HitObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HitPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float HitEnter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HitNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane HitPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MeshRayHit MeshRayHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SortByHitDistance(List<GameObjectRayHit> hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Store(
      Ray hitRay,
      IEnumerable<RaycastHit2D> hits2D,
      IEnumerable<RaycastHit> hits3D,
      List<GameObjectRayHit> hits)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit(Ray hitRay, RaycastHit hit3D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit) => throw null;
  }
}
