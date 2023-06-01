// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.FilterBiomeTextureMaskSpawnLocationsJob
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
  public struct FilterBiomeTextureMaskSpawnLocationsJob : IJobParallelFor
  {
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    [ReadOnly]
    public NativeArray<Color32> RgbaNativeArray;
    public int Width;
    public int Height;
    public int SelectedChannel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float2 NewClampPosition(float2 position) => throw null;
  }
}
