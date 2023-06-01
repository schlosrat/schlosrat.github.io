// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.IncludeVegetatiomMaskBeaconJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace AwesomeTechnologies
{
  [BurstCompile(CompileSynchronously = true)]
  public struct IncludeVegetatiomMaskBeaconJob : IJobParallelForDefer
  {
    public NativeArray<byte> Excluded;
    public NativeArray<float3> Position;
    public NativeArray<float> VegetationMaskScale;
    public NativeArray<float> VegetationMaskDensity;
    [ReadOnly]
    public NativeArray<float> FalloutCurveArray;
    public float Denisty;
    public float Scale;
    public float Radius;
    public float3 MaskPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SampleFalloutCurveArray(float value) => throw null;
  }
}
