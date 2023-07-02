// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.UpdateBVHInstanceListMultiLevelJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
