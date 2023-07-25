// Decompiled with JetBrains decompiler
// Type: RTG.TriangleMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class TriangleMath
  {
    private static readonly float _eqTriangleAltFactor;

    public static float EqTriangleAltFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetEqTriangleAltitude(float sideLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetEqTriangleCentroidAltitude(float sideLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CalcEqTriangle3DPoints(
      Vector3 centroid,
      float sideLength,
      Quaternion rotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> CalcEqTriangle2DPoints(
      Vector2 centroid,
      float sideLength,
      Quaternion rotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CalcRATriangleHypotenuse(float side0, float side1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CalcRATriangleHypotenuse(Vector2 sides) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CalcRATriangleAltitude(Vector2 sides) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CalcRATriangle3DPoints(
      Vector3 rightAngleCorner,
      float xLength,
      float yLength,
      Quaternion triangleRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> CalcRATriangle2DPoints(
      Vector2 rightAngleCorner,
      float xLength,
      float yLength,
      float degreeTriRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB Calc3DTriangleOBB(
      Vector3 p0,
      Vector3 p1,
      Vector3 p2,
      Vector3 normal,
      TriangleEpsilon epsilon = default (TriangleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 p0,
      Vector3 p1,
      Vector3 p2,
      TriangleEpsilon epsilon = default (TriangleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastWire(
      Ray ray,
      out float t,
      Vector3 p0,
      Vector3 p1,
      Vector3 p2,
      TriangleEpsilon epsilon = default (TriangleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      Vector3 p0,
      Vector3 p1,
      Vector3 p2,
      TriangleEpsilon epsilon = default (TriangleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains2DPoint(
      Vector2 point,
      Vector2 p0,
      Vector2 p1,
      Vector2 p2,
      TriangleEpsilon epsilon = default (TriangleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TriangleMath() => throw null;
  }
}
