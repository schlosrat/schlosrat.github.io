// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Unity.Mathematics;

namespace AwesomeTechnologies.VegetationSystem
{
  public struct VegetationInstance
  {
    public float3 Position;
    public quaternion Rotation;
    public float3 Scale;
    public float3 TerrainNormal;
    public float BiomeDistance;
    public byte TerrainTextureData;
    public int RandomNumberIndex;
    public float DistanceFalloff;
    public float VegetationMaskDensity;
    public float VegetationMaskScale;
    public byte TerrainSourceID;
    public byte TextureMaskData;
    public byte Excluded;
    public byte HeightmapSampled;
  }
}
