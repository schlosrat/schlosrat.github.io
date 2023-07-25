// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BillboardAtlasRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  public class BillboardAtlasRenderer : MonoBehaviour
  {
    public List<BillboardObject> BillboardObjectList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GenerateBillboardTexture(
      GameObject prefab,
      BillboardQuality billboardQuality,
      LODLevel billboardSourceLODLevel,
      VegetationShaderType vegetationShaderType,
      Quaternion rotationOffset,
      Color backgroundColor,
      string overrideBillboardAtlasShader,
      bool recalculateNormals,
      float normalBlendFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GenerateBillboardNormalTexture(
      GameObject prefab,
      BillboardQuality billboardQuality,
      LODLevel billboardSourceLODLevel,
      Quaternion rotationOffset,
      string overrideBillboardAtlasNormalShader,
      bool recalculateNormals,
      float normalBlendFactor,
      bool flipBackNormals)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GenerateBillboardAOTexture(
      GameObject prefab,
      BillboardQuality billboardQuality,
      LODLevel billboardSourceLODLevel,
      Quaternion rotationOffset,
      bool recalculateNormals,
      float normalBlendFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetBillboardQualityTileWidth(BillboardQuality billboardQuality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetBillboardQualityRowCount(BillboardQuality billboardQuality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetBillboardQualityColumnCount(BillboardQuality billboardQuality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GenerateBillboardNew(
      GameObject prefab,
      int width,
      int height,
      int gridSizeX,
      int gridSizeY,
      Shader replacementShader,
      Color backgroundColor,
      Material minPostfilter,
      LODLevel billboardSourceLODLevel,
      Quaternion rotationOffset,
      bool generateAo,
      bool recalculateNormals,
      float normalBlendFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RecalculateMeshNormals(GameObject go, float normalBlendfactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RecalculateMeshNormals(Mesh mesh, int subMeshIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds CalculateBounds(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float FindLowestMeshYposition(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveTexture(Texture2D tex, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetTextureImportSettings(Texture2D texture, bool normalMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BillboardAtlasRenderer() => throw null;
  }
}
