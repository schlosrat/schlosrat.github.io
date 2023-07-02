// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public static class SplineUtility
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float HermiteLerp(
      float x0,
      float y0,
      float x1,
      float y1,
      float outTangent,
      float inTangent,
      float x)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Hermite(Vector3 p0, Vector3 p1, Vector3 t0, Vector3 t1, float s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 HermiteTangent(Vector3 p0, Vector3 p1, Vector3 t0, Vector3 t1, float s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 HermiteTangentDerivative(
      Vector3 p0,
      Vector3 p1,
      Vector3 t0,
      Vector3 t1,
      float s)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 HermiteTangentSafe(
      Vector3 p0,
      Vector3 p1,
      Vector3 t0,
      Vector3 t1,
      float s,
      float threshold = 0.002f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetNormal(Vector3 tangent, Vector3 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetBinormal(Vector3 tangent, Vector3 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Bezier(Vector3[] points, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 BezierTangent(Vector3[] points, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 BezierNormal(Vector3[] points, float t, Vector3 up) => throw null;
  }
}
