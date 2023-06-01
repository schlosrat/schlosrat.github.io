// Decompiled with JetBrains decompiler
// Type: RTG.PolygonMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
