// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrainTerrainSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [Serializable]
  public struct MeshTerrainTerrainSource
  {
    public Terrain Terrain;
    public TerrainSourceID TerrainSourceID;
    public MaterialPropertyBlock MaterialPropertyBlock;
  }
}
