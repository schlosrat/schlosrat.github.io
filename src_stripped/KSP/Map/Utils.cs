// Decompiled with JetBrains decompiler
// Type: KSP.Map.Utils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Map
{
  public static class Utils
  {
    public const int INITIAL_RAYCAST_SIZE = 10;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetScaleForCameraNoots(
      Camera cam,
      Vector3 targetWorldPos,
      float targetNoots,
      float objectBaseScale = 1f,
      bool cullBehind = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetScaleForCameraHeightRatio(
      Camera cam,
      Vector3 targetWorldPos,
      float targetScreenRatio,
      float objectBaseScale = 1f,
      bool cullBehind = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Utils.SegmentInfo ClosestPointOnMultipleSegments(
      IReadOnlyList<Vector3> points,
      Ray ray)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Utils.SegmentInfo ClosestPointOnMultipleSegments(
      IReadOnlyList<GeneratedPointsData> pointData,
      Camera castingCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 ClosestPointToOtherSegment(
      Vector3 s1Offset,
      Vector3 s1Slope,
      Vector3 s2Offset,
      Vector3 s2Slope,
      float? s1Length = null,
      bool clamp0Regardless = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int RaycastUnderCursorSorted(Camera castCam, ref RaycastHit[] hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int RaycastUnderCursor(Camera castCam, ref RaycastHit[] hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int RaycastUIUnderCursor(ref List<RaycastResult> hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSetFocusedMapItem(MapItem mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSetSelectedMapItem(MapItem mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckIfParentOverrideUI(
      Map3DFocusItem target,
      MapItemHierarchy hierarchy,
      out Map3DFocusItem overrideMapItem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckIfParentOverrideUI(Map3DFocusItem target, MapItemHierarchy hierarchy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckIfParentOverride(
      Map3DFocusItem target,
      MapItemHierarchy hierarchy,
      out Map3DFocusItem overrideMapItem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckIfParentOverride(Map3DFocusItem target, MapItemHierarchy hierarchy) => throw null;

    public class SegmentInfo
    {
      public GeneratedPointsData SegmentData;
      public Vector3 RayPoint;
      public Vector3 SegmentPoint;
      public float SegmentTValue;
      public int SegmentStartIndex;
      public int SegmentEndIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SegmentInfo() => throw null;
    }
  }
}
