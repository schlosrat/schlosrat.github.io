// Decompiled with JetBrains decompiler
// Type: RTG.PolygonMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class PolygonMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      List<Vector3> cwPolyPoints,
      bool isClosed,
      Vector3 polyNormal,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      List<Vector3> cwPolyPoints,
      bool isClosed,
      Vector3 polyNormal,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains2DPoint(
      Vector2 point,
      List<Vector2> polyPoints,
      bool isClosed,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is3DPointOnBorder(
      Vector3 point,
      bool checkOnPlane,
      List<Vector3> cwPolyPoints,
      bool isClosed,
      Vector3 polyNormal,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnBorder(
      Vector2 point,
      List<Vector2> polyPoints,
      bool isClosed,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnThickBorder(
      Vector2 point,
      List<Vector2> polyPoints,
      List<Vector2> thickBorderPoints,
      bool isClosed,
      PolygonEpsilon epsilon = default (PolygonEpsilon))
    {
      throw null;
    }
  }
}
