// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Biomes.FilterBiomeSpawnLocationsJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
