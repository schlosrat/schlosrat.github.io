// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.PolygonMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies
{
  public class PolygonMaskArea : BaseMaskArea
  {
    private Vector2[] _points2D;
    private Vector3[] _points3D;
    private LineSegment2D[] _segments;
    public NativeArray<Vector2> PolygonArray;
    public NativeArray<LineSegment2D> SegmentArray;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPolygon(List<Vector3> pointList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSegments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JobHandle SampleMask(
      VegetationInstanceData instanceData,
      VegetationType vegetationType,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JobHandle SampleIncludeVegetationMask(
      VegetationInstanceData instanceData,
      VegetationTypeIndex vegetationTypeIndex,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool HasVegetationTypeIndex(VegetationTypeIndex vegetationTypeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetMaskBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolygonMaskArea() => throw null;
  }
}
