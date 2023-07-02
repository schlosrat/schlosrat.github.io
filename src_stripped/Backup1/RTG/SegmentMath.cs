// Decompiled with JetBrains decompiler
// Type: RTG.SegmentMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
