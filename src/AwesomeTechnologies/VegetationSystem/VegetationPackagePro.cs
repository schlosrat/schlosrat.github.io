// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationPackagePro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Shaders;
using AwesomeTechnologies.Vegetation.Masks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class VegetationPackagePro : ScriptableObject
  {
    public string PackageName;
    [SerializeField]
    public List<VegetationItemInfoPro> VegetationInfoList;
    public List<TerrainTextureSettings> TerrainTextureSettingsList;
    public List<TerrainTextureInfo> TerrainTextureList;
    public List<TextureMaskGroup> TextureMaskGroupList;
    public int TerrainTextureCount;
    public BiomeType BiomeType;
    public int BiomeSortOrder;
    public bool GenerateBiomeSplamap;
    public float BiomeCutoffWeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitPackage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetVegetationItemID(string assetGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeTerrainTextureList(int newCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeTerrainTextureSettingsList(int newCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteTextureMaskGroup(TextureMaskGroup textureMaskGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMaskGroup GetTextureMaskGroup(string textureMaskGroupID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemInfoPro GetVegetationInfo(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareNativeArrayTextureCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ValidateAnimationCurve(AnimationCurve curve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AnimationCurve CreateResetAnimationCurve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeNativeArrayTextureCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadDefaultTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupTerrainTextureSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TerrainTextureInfo LoadTexture(
      string textureName,
      string normalTextureName,
      Vector2 uv)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshVegetationItemShaderController(VegetationItemInfoPro vegetationItemInfoPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshVegetationItemPrefab(VegetationItemInfoPro vegetationItemInfoPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CopyOldShaderControllerSettings(
      ShaderControllerSettings shaderControllerSettings,
      ShaderControllerSettings oldShaderControllerSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItem(
      Texture2D texture,
      VegetationType vegetationType,
      bool enableRuntimeSpawn = true,
      string newVegetationItemID = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItem(
      GameObject go,
      VegetationType vegetationType,
      bool enableRuntimeSpawn = true,
      string newVegetationItemID = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DuplicateVegetationItem(VegetationItemInfoPro vegetationItemInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateBillboard(int vegetationItemIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateBillboard(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetVegetationItemIndexFromID(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationPackagePro() => throw null;
  }
}
