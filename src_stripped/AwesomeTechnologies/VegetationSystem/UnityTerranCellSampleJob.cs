// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.UnityTerranCellSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct UnityTerranCellSampleJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<float> InputHeights;
    public NativeArray<Bounds> VegetationCellBoundsList;
    public int HeightmapWidth;
    public int HeightmapHeight;
    public Vector3 HeightMapScale;
    public Rect TerrainRect;
    public Vector3 TerrainPosition;
    public float WorldspaceHeightCutoff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHeight(int x, int y) => throw null;
  }
}
