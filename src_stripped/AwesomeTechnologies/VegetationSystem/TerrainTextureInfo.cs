// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.TerrainTextureInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class TerrainTextureInfo
  {
    public Texture2D Texture;
    public Texture2D TextureNormals;
    public Texture2D TextureOcclusion;
    public Texture2D TextureHeightMap;
    public Vector2 TileSize;
    public Vector2 Offset;
    public TerrainLayer TerrainLayer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TerrainTextureInfo() => throw null;
  }
}
