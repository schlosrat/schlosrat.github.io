// Decompiled with JetBrains decompiler
// Type: RTG.SegmentMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class SegmentMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 startPoint,
      Vector3 endPoint,
      SegmentEpsilon epsilon = default (SegmentEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is3DPointOnSegment(
      Vector3 point,
      Vector3 startPoint,
      Vector3 endPoint,
      SegmentEpsilon epsilon = default (SegmentEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnSegment(
      Vector2 point,
      Vector2 startPoint,
      Vector2 endPoint,
      SegmentEpsilon epsilon = default (SegmentEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ProjectPtOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint) => throw null;
  }
}
