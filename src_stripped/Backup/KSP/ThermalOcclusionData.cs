// Decompiled with JetBrains decompiler
// Type: KSP.ThermalOcclusionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class ThermalOcclusionData : IComparable<ThermalOcclusionData>
  {
    public PartBehavior Part;
    public Data_Drag PartDragData;
    public double ProjectedArea;
    public double ProjectedRadius;
    public double InvFineness;
    public double MinimumDot;
    public double MaximumDot;
    public double CentroidDot;
    public double MaxWidthDepth;
    public Vector3 BoundsCenter;
    public Vector3[] BoundsVertices;
    public Vector3 ProjectedCenter;
    public Vector3[] ProjectedVertices;
    public float[] ProjectedDots;
    public Vector2 Center;
    public Vector2 MinExtents;
    public Vector2 MaxExtents;
    public Vector2 Extents;
    public OcclusionCone OcclusionCone;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalOcclusionData(PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CreateCornerArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetShockStats(
      OcclusionCone cone,
      ref double newTempMult,
      ref double newCoeffMult,
      float crossSectionMultiplier = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCylinderOcclusion(OcclusionCylinder cyl) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static double RectRectIntersection(
      double centralExtentX,
      double centralExtentY,
      double minX,
      double maxX,
      double minY,
      double maxY)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static double AreaOfIntersection(
      double existingConeRadius,
      double potentialConeRadius,
      double sqrDistance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(ThermalOcclusionData b) => throw null;
  }
}
