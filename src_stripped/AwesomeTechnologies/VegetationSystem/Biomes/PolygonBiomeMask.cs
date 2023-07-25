// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Biomes.PolygonBiomeMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Biomes
{
  public class PolygonBiomeMask
  {
    public Bounds MaskBounds;
    public BiomeType BiomeType;
    public float BlendDistance;
    public bool UseNoise;
    public float NoiseScale;
    public int BiomeSortOrder;
    private Rect _polygonRect;
    public PolygonBiomeMask.MultionMaskDeleteDelegate OnMaskDeleteDelegate;
    private Vector2[] _points2D;
    private LineSegment2D[] _segments;
    private Vector3[] _points3D;
    public NativeArray<Vector2> PolygonArray;
    public NativeArray<LineSegment2D> SegmentArray;
    public NativeArray<float> CurveArray;
    public NativeArray<float> InverseCurveArray;
    public NativeArray<float> TextureCurveArray;
    private bool[] _disableEdges;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CallDeleteEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPolygon(List<Vector3> pointList, List<bool> disableEdgeList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurve(float[] curveArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInverseCurve(float[] curveArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTextureCurve(float[] curveArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSegments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle FilterSpawnLocations(
      NativeList<VegetationSpawnLocationInstance> spawnLocationList,
      BiomeType currentBiomeType,
      int sampleCount,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetMaskBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInPolygon(Vector2 p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolygonBiomeMask() => throw null;

    public delegate void MultionMaskDeleteDelegate(PolygonBiomeMask maskArea);
  }
}
