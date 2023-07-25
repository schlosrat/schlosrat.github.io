// Decompiled with JetBrains decompiler
// Type: RTG.QuadMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class QuadMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Calc2DQuadRightUp(float degreeRotation, out Vector2 right, out Vector2 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Calc2DQuadCornerPoints(
      Vector2 quadCenter,
      Vector2 quadSize,
      float degreeRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Calc2DQuadCornerPoints(
      Vector2 quadCenter,
      Vector2 quadSize,
      Vector2 right,
      Vector2 up)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> Calc3DQuadCornerPoints(
      Vector3 quadCenter,
      Vector2 quadSize,
      Quaternion quadRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Calc3DQuadCorner(
      Vector3 quadCenter,
      Vector2 quadSize,
      Quaternion quadRotation,
      QuadCorner quadCorner)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB Calc3DQuadOBB(
      Vector3 quadCenter,
      Vector2 quadSize,
      Quaternion quadRotation,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 quadCenter,
      float quadWidth,
      float quadHeight,
      Vector3 quadRight,
      Vector3 quadUp,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastWire(
      Ray ray,
      out float t,
      Vector3 quadCenter,
      float quadWidth,
      float quadHeight,
      Vector3 quadRight,
      Vector3 quadUp,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      Vector3 quadCenter,
      float quadWidth,
      float quadHeight,
      Vector3 quadRight,
      Vector3 quadUp,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains2DPoint(
      Vector2 point,
      Vector2 quadCenter,
      float quadWidth,
      float quadHeight,
      float degreeRotation,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains2DPoint(
      Vector2 point,
      Vector2 quadCenter,
      float quadWidth,
      float quadHeight,
      Vector2 quadRight,
      Vector2 quadUp,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnBorder(
      Vector2 point,
      Vector2 quadCenter,
      float quadWidth,
      float quadHeight,
      float degreeRotation,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnBorder(
      Vector2 point,
      Vector2 quadCenter,
      float quadWidth,
      float quadHeight,
      Vector2 quadRight,
      Vector2 quadUp,
      QuadEpsilon epsilon = default (QuadEpsilon))
    {
      throw null;
    }
  }
}
