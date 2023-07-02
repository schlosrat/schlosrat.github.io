// Decompiled with JetBrains decompiler
// Type: RTG.PrimitiveFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class PrimitiveFactory
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Generate2DPolyBorderQuadsCW(
      List<Vector2> cwPolyPoints,
      List<Vector2> cwBorderPts,
      PrimitiveFactory.PolyBorderDirection borderDirection,
      bool isClosed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float PolyBorderDirToSign(
      PrimitiveFactory.PolyBorderDirection borderDirection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Generate2DPolyBorderPointsCW(
      List<Vector2> cwPolyPoints,
      PrimitiveFactory.PolyBorderDirection borderDirection,
      float borderThickness,
      bool isClosed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Generate2DCircleBorderPointsCW(
      Vector2 circleCenter,
      float circleRadius,
      int numPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> Generate3DCircleBorderPoints(
      Vector3 circleCenter,
      float circleRadius,
      Vector3 circleRight,
      Vector3 circleUp,
      int numPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> GenerateSphereBorderPoints(
      Camera camera,
      Vector3 sphereCenter,
      float sphereRadius,
      int numPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Generate2DArcBorderPoints(
      Vector2 arcOrigin,
      Vector2 arcStartPoint,
      float degreesFromStart,
      bool forceShortestArc,
      int numPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> ProjectArcPointsOnPoly2DBorder(
      Vector2 arcOrigin,
      List<Vector2> arcPoints,
      List<Vector2> clockwisePolyPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> Generate3DArcBorderPoints(
      Vector3 arcOrigin,
      Vector3 arcStartPoint,
      Plane arcPlane,
      float degreesFromStart,
      bool forceShortestArc,
      int numPoints)
    {
      throw null;
    }

    public enum PolyBorderDirection
    {
      Inward,
      Outward,
    }
  }
}
