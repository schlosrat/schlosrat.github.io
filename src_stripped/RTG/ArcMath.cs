// Decompiled with JetBrains decompiler
// Type: RTG.ArcMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ArcMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ConvertToSh3DArcAngle(
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ConvertToSh2DArcAngle(
      Vector2 arcOrigin,
      Vector2 arcStartPoint,
      float degreesFromStart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB CalcSh3DArcOBB(
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB CalcLg3DArcOBB(
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastShArc(
      Ray ray,
      out float t,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastShArcWire(
      Ray ray,
      out float t,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastLgArc(
      Ray ray,
      out float t,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastLgArcWire(
      Ray ray,
      out float t,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ShArcContains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is3DPointOnShArcWire(
      Vector3 point,
      bool checkOnPlane,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ShArcContains2DPoint(
      Vector2 point,
      Vector2 arcOrigin,
      Vector2 arcStartPoint,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LgArcContains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is3DPointOnLgArcWire(
      Vector3 point,
      bool checkOnPlane,
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Vector3 arcPlaneNormal,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LgArcContains2DPoint(
      Vector2 point,
      Vector2 arcOrigin,
      Vector2 arcStartPoint,
      float degreesFromStart,
      ArcEpsilon epsilon = default (ArcEpsilon))
    {
      throw null;
    }
  }
}
