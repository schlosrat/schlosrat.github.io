// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.BiomeEdgeDistanceScaleRuleJob
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
  public struct BiomeEdgeDistanceScaleRuleJob : IJobParallelFor
  {
    public NativeArray<float3> Scale;
    public NativeArray<byte> Excluded;
    public NativeArray<float> BiomeDistance;
    public float MaxDistance;
    public float MinScale;
    public float MaxScale;
    public bool InverseScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
