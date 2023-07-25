// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.UnityTerrainSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
  public struct UnityTerrainSampleJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<float> InputHeights;
    [ReadOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    public NativeArray<float3> Position;
    public NativeArray<quaternion> Rotation;
    public NativeArray<float3> Scales;
    public NativeArray<float3> TerrainNormal;
    public NativeArray<float> BiomeDistance;
    public NativeArray<byte> TerrainTextureData;
    public NativeArray<int> RandomNumberIndex;
    public NativeArray<float> DistanceFalloff;
    public NativeArray<float> VegetationMaskDensity;
    public NativeArray<float> VegetationMaskScale;
    public NativeArray<byte> TerrainSourceIDs;
    public NativeArray<byte> TextureMaskData;
    public NativeArray<byte> Excluded;
    public NativeArray<byte> HeightmapSampled;
    public int HeightmapWidth;
    public int HeightmapHeight;
    public Vector3 Scale;
    public Vector3 Size;
    public Vector3 HeightMapScale;
    public Vector3 TerrainPosition;
    public byte TerrainSourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTriangleInterpolatedHeight(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHeight(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float3 GetInterpolatedNormal(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 CalculateNormalSobel(int x, int y) => throw null;
  }
}
