// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.FilterSpawnLocationsChanceJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct FilterSpawnLocationsChanceJob : IJobParallelFor
  {
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;
    public float Density;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RandomCutoff(float value, int randomNumberIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
