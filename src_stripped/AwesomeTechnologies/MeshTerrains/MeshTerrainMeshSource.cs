// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrainMeshSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [Serializable]
  public struct MeshTerrainMeshSource
  {
    public MeshRenderer MeshRenderer;
    public TerrainSourceID TerrainSourceID;
    public MaterialPropertyBlock MaterialPropertyBlock;
  }
}
