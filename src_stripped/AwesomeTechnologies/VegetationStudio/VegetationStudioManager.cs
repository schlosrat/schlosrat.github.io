// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationStudio.VegetationStudioManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationStudio
{
  [ExecuteInEditMode]
  public class VegetationStudioManager : MonoBehaviour
  {
    public int CurrentTabIndex;
    public static VegetationStudioManager Instance;
    public List<VegetationSystemPro> VegetationSystemList;
    public VegetationStudioManager.MultiAddVegetationSystemDelegate OnAddVegetationSystemDelegate;
    public VegetationStudioManager.MultiRemoveVegetationSystemDelegate OnRemoveVegetationSystemDelegate;
    [NonSerialized]
    private VegetationItemInfoPro _clippboardvegetationItemInfo;
    private bool _suspendVegetationSystems;
    [NonSerialized]
    private AnimationCurve _clippboardAnimationCurve;
    public LayerMask PostProcessingLayer;
    private readonly List<PolygonBiomeMask> _biomeMaskList;
    private static bool _showBiomes;
    private readonly List<BaseMaskArea> _vegetationMaskList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Instance_RegisterVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void FindInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Instance_UnregisterVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVegetationSystemsSuspended() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVegetationSystemsSuspended() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAddVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRemoveVegetationSystem(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnVegetationCellRefresh(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Internal_OnVegetationCellRefresh(VegetationSystemPro vegetationSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddAnimationCurveToClipboard(AnimationCurve animationCurve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Internal_AddAnimationCurveToClipboard(AnimationCurve animationCurve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AnimationCurve GetAnimationCurveFromClippboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimationCurve Internal_GetAnimationCurveFromClippboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Internal_ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Internal_ClearCache(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearCache(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Internal_AddVegetationItemToClipboard(VegetationItemInfoPro vegetationItemInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VegetationItemInfoPro Internal_GetVegetationItemFromClipboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddVegetationItemToClipboard(VegetationItemInfoPro vegetationItemInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VegetationItemInfoPro GetVegetationItemFromClipboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RefreshTerrainHeightMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RefreshTerrainHeightMap(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RefreshTerrainHeightmap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RefreshTerrainHeightmap(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_AddTerrain(GameObject go, bool forceAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RemoveTerrain(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddTerrain(GameObject go, bool forceAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddCamera(
      Camera camera,
      bool noFrustumCulling = false,
      bool renderDirectToCamera = false,
      bool renderBillboardsOnly = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_AddCamera(
      Camera aCamera,
      bool noFrustumCulling = false,
      bool renderDirectToCamera = false,
      bool renderBillboardsOnly = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RemoveCamera(Camera aCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveTerrain(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RefreshTerrainArea(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RefreshTerrainArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RefreshTerrainArea(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RefreshTerrainArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 Instance_GetFloatingOriginOffset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetFloatingOriginOffset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetSunDirectionalLight(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_SetSunDirectionalLight(Light alight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_AddColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RemoveColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_SuspendVegetationSystem(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SuspendVegetationSystem(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RenderScatter(bool value) => throw null;

    public static bool ShowBiomes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveBiomeMask(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddBiomeMask(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<PolygonBiomeMask> GetBiomeMasks(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PolygonBiomeMask> Instance_GetBiomeMasks(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeBiomeMasks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Instance_AddBiomeMask(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Instance_RemoveBiomeMask(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddBiomeMaskToVegetationSystem(
      VegetationSystemPro vegetationSystem,
      PolygonBiomeMask maskArea)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GenerateSplatMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeType Instance_GetBiomeType(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BiomeType GetBiomeType(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AddVegetationItem(
      GameObject prefab,
      VegetationType vegetationType,
      bool enableRuntimeSpawn,
      BiomeType biomeType = BiomeType.Default)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RefreshVegetationSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetVegetationItemID(string assetGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AddVegetationItem(
      Texture2D texture,
      VegetationType vegetationType,
      bool enableRuntimeSpawn,
      BiomeType biomeType = BiomeType.Default)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddVegetationItemInstance(
      string vegetationItemID,
      Vector3 worldPosition,
      Vector3 scale,
      Quaternion rotation,
      bool applyMeshRotation,
      byte vegetationSourceID,
      float distanceFalloff,
      bool clearCellCache = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveVegetationItemInstance(
      string vegetationItemID,
      Vector3 worldPosition,
      float minimumDistance,
      bool clearCellCache = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveVegetationItemInstances(
      string vegetationItemID,
      byte vegetationSourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveVegetationItemInstances(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddVegetationItemInstanceEx(
      string vegetationItemID,
      Vector3 worldPosition,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float minimumDistance,
      float distanceFalloff,
      bool clearCellCache = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<VegetationPackagePro> GetVegetationPackageList(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<VegetationPackagePro> GetAllVegetationPackageList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearVegetationItemInstancesArea(string vegetationItemID, Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearVegetationItemInstancesArea(
      string vegetationItemID,
      byte vegetationSourceID,
      Bounds bounds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddVegetationMask(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveVegetationMask(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_AddVegetationMask(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Instance_RemoveVegetationMask(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeVegetationMasksMasks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddVegetationMaskToVegetationSystem(
      VegetationSystemPro vegetationSystem,
      BaseMaskArea maskArea)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioManager() => throw null;

    public delegate void MultiAddVegetationSystemDelegate(VegetationSystemPro vegetationSystem);

    public delegate void MultiRemoveVegetationSystemDelegate(VegetationSystemPro vegetationSystem);
  }
}
