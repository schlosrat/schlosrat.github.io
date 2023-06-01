// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.ProcessIncludeVegetationMaskJob
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
  public struct ProcessIncludeVegetationMaskJob : IJobParallelFor
  {
    public NativeArray<byte> Excluded;
    public NativeArray<float> VegetationMaskDensity;
    public NativeArray<float> VegetationMaskScale;
    public NativeArray<float3> Scale;
    public NativeArray<int> RandomNumberIndex;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RandomCutoff(float value, int randomNumberIndex) => throw null;
  }
}
