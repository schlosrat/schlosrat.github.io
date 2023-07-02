// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
