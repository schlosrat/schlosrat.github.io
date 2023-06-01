// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.DistanceFalloffJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct DistanceFalloffJob : IJobParallelFor
  {
    public NativeArray<int> RandomNumberIndex;
    public NativeArray<float> DistanceFalloff;
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;
    [ReadOnly]
    public float DistanceFalloffStartDistance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;
  }
}
