// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CalculateCellSpawnLocationsWideJob
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
  public struct CalculateCellSpawnLocationsWideJob : IJobParallelFor
  {
    [WriteOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocations;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;
    public Vector3 CellCorner;
    public Vector3 CellSize;
    public Rect CellRect;
    public int CellIndex;
    public float SampleDistance;
    public float Density;
    public float DefaultSpawnChance;
    public int Seed;
    public bool UseSamplePointOffset;
    public float SamplePointMinOffset;
    public float SamplePointMaxOffset;
    public bool RandomizePosition;
    public float CalculatedSampleDistance;
    public int XSamples;
    public int ZSamples;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 GetRandomOffset(float distance, int randomNumberIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;
  }
}
