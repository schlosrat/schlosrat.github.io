// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.SampleHeightMapJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SampleHeightMapJob : IJobParallelFor
  {
    public NativeArray<HeightMapSample> HeightMapSamples;
    [ReadOnly]
    public NativeArray<float> InputHeights;
    public int Width;
    public int Height;
    public int HeightmapWidth;
    public int HeightmapHeight;
    public Vector3 Scale;
    public Vector3 Size;
    public Vector3 HeightMapScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTriangleInterpolatedHeight(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHeight(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float3 GetInterpolatedNormal(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 CalculateNormalSobel(int x, int y) => throw null;
  }
}
