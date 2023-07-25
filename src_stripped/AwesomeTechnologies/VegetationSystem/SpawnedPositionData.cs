// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.SpawnedPositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public struct SpawnedPositionData
  {
    public Vector3 Position;
    public Vector3 TerrainNormal;
    public float UniformScale;
    public int RandomNumberIndex;
    public float SpawnChance;
    public Vector2 Uv;
    public Vector3 ProceduralValues1;
    public Vector4 ProceduralValues2;
    public Vector3 ProceduralPeak;
    public Vector3 ProceduralCavity;
    public Vector4 SubzoneGrad;
    public Vector4 SubzonePeakCav;
  }
}
