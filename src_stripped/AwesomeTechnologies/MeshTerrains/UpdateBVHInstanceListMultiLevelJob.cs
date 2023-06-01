// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.UpdateBVHInstanceListMultiLevelJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace AwesomeTechnologies.MeshTerrains
{
  [BurstCompile(CompileSynchronously = true)]
  public struct UpdateBVHInstanceListMultiLevelJob : IJob
  {
    [ReadOnly]
    public NativeArray<HitInfo> RaycastHits;
    public NativeList<float3> Position;
    public NativeList<quaternion> Rotation;
    public NativeList<float3> Scale;
    public NativeList<float3> TerrainNormal;
    public NativeList<float> BiomeDistance;
    public NativeList<byte> TerrainTextureData;
    public NativeList<int> RandomNumberIndex;
    public NativeList<float> DistanceFalloff;
    public NativeList<float> VegetationMaskDensity;
    public NativeList<float> VegetationMaskScale;
    public NativeList<byte> TerrainSourceID;
    public NativeList<byte> TextureMaskData;
    public NativeList<byte> Excluded;
    public NativeList<byte> HeightmapSampled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
