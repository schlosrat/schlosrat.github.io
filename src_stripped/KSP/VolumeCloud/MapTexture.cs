// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.MapTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  public class MapTexture
  {
    private int sourceWidth;
    private int sourceHeight;
    private int tileWidth;
    private int tileHeight;
    private int tileCountX;
    private int tileCountY;
    private List<Vector2> tilesPresent;
    private Color32[] rawDataSource;
    private Texture2D textureSource;
    public SparseTexture texture;
    private Color32[] tileColors;
    private bool hasCreated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<Vector2> GetTilesThatNeedToBePresent(int[] checkResult) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateTiles(List<Vector2> tiles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateSingleTile(int tx, int ty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~MapTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Create(
      int width,
      int height,
      TextureFormat textureFormat,
      int mipmapCount,
      Texture2D source)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasCreated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SparseTexture GetTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSparseTexture(int[] checkResult) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapTexture() => throw null;
  }
}
