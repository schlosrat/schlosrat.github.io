// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Biomes.FilterBiomeSpawnLocationsJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Biomes
{
  [BurstCompile(CompileSynchronously = true)]
  public struct FilterBiomeSpawnLocationsJob : IJobParallelFor
  {
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    [ReadOnly]
    public NativeArray<float> CurveArray;
    [ReadOnly]
    public NativeArray<float> InverseCurveArray;
    [ReadOnly]
    public NativeArray<Vector2> PolygonArray;
    [ReadOnly]
    public NativeArray<LineSegment2D> SegmentArray;
    public bool Include;
    public bool UseNoise;
    public float NoiseScale;
    public float BlendDistance;
    public Rect PolygonRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SampleCurveArray(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SampleInverseCurveArray(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float DistanceToEdge(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInPolygon(Vector2 p) => throw null;
  }
}
