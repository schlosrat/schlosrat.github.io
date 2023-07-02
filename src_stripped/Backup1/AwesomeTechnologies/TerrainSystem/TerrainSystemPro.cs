// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.TerrainSystem.TerrainSystemPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AwesomeTechnologies.TerrainSystem
{
  public class TerrainSystemPro : MonoBehaviour
  {
    public VegetationSystemPro VegetationSystemPro;
    public int CurrentTabIndex;
    public int VegetationPackageIndex;
    public int VegetationPackageTextureIndex;
    public bool ShowCurvesMenu;
    public bool ShowNoiseMenu;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IVegetationStudioTerrain> GetOverlapTerrainList(Bounds updateBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareTextureCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeTextureCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetTerrainTexture(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetSplatPrototypesFromTerrain(VegetationPackagePro vegetationPackage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSplatPrototypes(VegetationPackagePro vegetationPackage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TerrainLayer SaveTerrainLayer(
      TerrainLayer terrainLayer,
      VegetationPackagePro vegetationPackagePro)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateSplatMap(
      bool clearLockedTextures,
      IVegetationStudioTerrain iVegetationStudioTerrain)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateSplatMap(bool clearLockedTextures) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateSplatMapParallel(bool clearLockedTextures) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowTerrainHeatmap(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTerrainHeatmap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSceneSaving(Scene scene, string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TerrainSystemPro() => throw null;
  }
}
