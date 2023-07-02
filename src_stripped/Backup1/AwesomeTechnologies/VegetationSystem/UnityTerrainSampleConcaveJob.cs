// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.UnityTerrainSampleConcaveJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct UnityTerrainSampleConcaveJob : IJobParallelForDefer
  {
    public NativeArray<byte> Excluded;
    public NativeArray<float3> Position;
    [ReadOnly]
    public NativeArray<float> InputHeights;
    public float Distance;
    public float MinHeightDifference;
    public bool Inverse;
    public bool Average;
    public int HeightmapWidth;
    public int HeightmapHeight;
    public Vector3 HeightMapScale;
    public Vector3 Size;
    public Vector3 TerrainPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMinimumHeight(
      float height1,
      float height2,
      float height3,
      float height4,
      float height5,
      float height6,
      float height7,
      float height8)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHeight(int x, int y) => throw null;
  }
}
