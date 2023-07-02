// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.UnityTerranCellSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
