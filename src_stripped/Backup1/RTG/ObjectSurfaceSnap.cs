// Decompiled with JetBrains decompiler
// Type: RTG.ObjectSurfaceSnap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class ObjectSurfaceSnap
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ObjectSurfaceSnap.SnapResult SnapHierarchy(
      GameObject root,
      ObjectSurfaceSnap.SnapConfig snapConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalculateSitOnSurfaceOffset(
      OBB obb,
      Plane surfacePlane,
      float offsetFromSurface)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalculateSitOnSurfaceOffset(
      AABB aabb,
      Plane surfacePlane,
      float offsetFromSurface)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalculateEmbedVector(
      List<Vector3> embedPoints,
      GameObject embedSurface,
      Vector3 embedDirection,
      ObjectSurfaceSnap.Type surfaceType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ObjectSurfaceSnap.SurfaceRaycaster CreateSurfaceRaycaster(
      ObjectSurfaceSnap.Type surfaceType,
      GameObject surfaceObject,
      bool raycastReverse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectSurfaceSnap() => throw null;

    public enum Type
    {
      UnityTerrain,
      Mesh,
      TerrainMesh,
      SphericalMesh,
      SceneGrid,
    }

    public struct SnapConfig
    {
      public bool AlignAxis;
      public TransformAxis AlignmentAxis;
      public ObjectSurfaceSnap.Type SurfaceType;
      public float OffsetFromSurface;
      public Vector3 SurfaceHitPoint;
      public Vector3 SurfaceHitNormal;
      public Plane SurfaceHitPlane;
      public GameObject SurfaceObject;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsSurfaceMesh() => throw null;
    }

    public struct SnapResult
    {
      public bool Success;
      public Plane SittingPlane;
      public Vector3 SittingPoint;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SnapResult(Plane sittingPlane, Vector3 sittingPoint) => throw null;
    }

    private abstract class SurfaceRaycaster
    {
      protected GameObject _surfaceObject;
      protected bool _raycastReverse;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public abstract GameObjectRayHit Raycast(Ray ray) => throw null;
    }

    private class MeshSurfaceRaycaster : ObjectSurfaceSnap.SurfaceRaycaster
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override GameObjectRayHit Raycast(Ray ray) => throw null;
    }

    private class TerrainSurfaceRaycaster : ObjectSurfaceSnap.SurfaceRaycaster
    {
      private TerrainCollider _terrainCollider;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TerrainSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override GameObjectRayHit Raycast(Ray ray) => throw null;
    }
  }
}
