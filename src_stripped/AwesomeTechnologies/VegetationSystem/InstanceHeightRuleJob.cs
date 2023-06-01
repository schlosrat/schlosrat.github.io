// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.InstanceHeightRuleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct InstanceHeightRuleJob : IJobParallelFor
  {
    public NativeArray<byte> Excluded;
    public NativeArray<float3> Position;
    public NativeArray<int> RandomNumberIndex;
    public float MinHeight;
    public float MaxHeight;
    [ReadOnly]
    public NativeArray<float> HeightRuleCurveArray;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;
    public bool Advanced;
    public float MaxCurveHeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RandomCutoff(float value, int randomNumberIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SampleCurveArray(float value) => throw null;
  }
}
