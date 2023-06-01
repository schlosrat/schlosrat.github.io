// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.SampleVegetatiomMaskPolygonJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SampleVegetatiomMaskPolygonJob : IJobParallelForDefer
  {
    public NativeArray<float3> Position;
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<Vector2> PolygonArray;
    [ReadOnly]
    public NativeArray<LineSegment2D> SegmentArray;
    public float AdditionalWidth;
    public float AdditionalWidthMax;
    public float NoiseScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float DistanceToEdge(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInPolygon(Vector2 p) => throw null;
  }
}
