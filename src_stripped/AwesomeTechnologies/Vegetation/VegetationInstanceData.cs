// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.VegetationInstanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace AwesomeTechnologies.Vegetation
{
  public class VegetationInstanceData
  {
    public NativeList<float3> Position;
    public NativeList<quaternion> Rotation;
    public NativeList<float3> Scale;
    public NativeList<float3> TerrainNormal;
    public NativeList<float3> SphereNormal;
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
    public NativeList<float2> uv;
    public NativeList<VegetationSpawnLocationInstance> SpawnLocations;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationInstanceData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeUninitialized(int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompactMemory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCapasity(int capasity) => throw null;
  }
}
