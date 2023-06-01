// Decompiled with JetBrains decompiler
// Type: RTG.PlaneEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class PlaneEx
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane InvertNormal(this Plane plane) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAbsDistanceToPoint(this Plane plane, Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ProjectPoint(this Plane plane, Vector3 pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> ProjectAllPoints(this Plane plane, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetFurthestPtInFront(this Plane plane, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetClosestPtInFront(this Plane plane, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetClosestPtInFrontOrOnPlane(this Plane plane, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetFurthestPtBehind(this Plane plane, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane GetCameraFacingAxisSlicePlane(
      Vector3 axisOrigin,
      Vector3 axis,
      Camera camera)
    {
      throw null;
    }
  }
}
