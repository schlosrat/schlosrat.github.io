// Decompiled with JetBrains decompiler
// Type: RTG.CameraEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class CameraEx
  {
    private static List<GameObject> _objectBuffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsCurrent(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFrustumDistanceFromHeight(this Camera camera, float frustumHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFOVFromDistanceAndHeight(
      this Camera camera,
      float frustumHeight,
      float distance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFrustumWidthFromDistance(this Camera camera, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFrustumHeightFromDistance(this Camera camera, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalculateVolumeAABB(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalculateFrustumAABB(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalculateOrthoAABB(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPointInFrontNearPlane(this Camera camera, Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane GetNearPlaneForward(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetFarMidPoint(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetFarMidOrthoTop(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetOrthoFOV(this Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPointFacingCamera(this Camera camera, Vector3 point, Vector3 pointNormal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetPointZDistance(this Camera camera, Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> GetVisibleSphereExtents(this Camera camera, Sphere sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> ConvertWorldToScreenPoints(
      this Camera camera,
      List<Vector3> worldPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ScreenToEstimatedWorldSize(
      this Camera camera,
      Vector3 worldPos,
      float screenSize)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float EstimateZoomFactor(this Camera camera, Vector3 worldPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float EstimateZoomFactorSpherical(this Camera camera, Vector3 worldPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetVisibleObjects(
      this Camera camera,
      CameraViewVolume viewVolume,
      List<GameObject> visibleObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraEx() => throw null;
  }
}
