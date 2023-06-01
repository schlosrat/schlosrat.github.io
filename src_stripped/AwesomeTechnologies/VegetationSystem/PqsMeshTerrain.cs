// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.PqsMeshTerrain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class PqsMeshTerrain : MonoBehaviour, IVegetationStudioTerrain
  {
    public Bounds RaycastTerrainBounds;
    public LayerMask RaycastLayerMask;
    public LayerMask ExcluideLayerMask;
    public int MaxHits;
    public List<RaycastContainers> RaycastContainerList;
    public ObjectPool<RaycastContainers> RaycastContainerPool;
    public TerrainSourceID TerrainSourceID;
    public bool AutoAddToVegegetationSystem;
    private bool _initDone;
    public Vector3 TerrainPosition;

    public string TerrainType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Bounds TerrainBounds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PolarSphereRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 PolarSpherePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform PolarSphereTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PolarSphereMaxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainData(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleCellHeight(
      NativeArray<Bounds> vegetationCellBoundsList,
      float worldspaceHeightCutoff,
      Rect cellBoundsRect,
      JobHandle dependsOn = default (JobHandle))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rect GetMeshTerrainRect(float polarSphereRadius, Vector3 floatingOriginOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleTerrain(
      NativeList<VegetationSpawnLocationInstance> spawnLocationList,
      VegetationInstanceData instanceData,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SampleTerrainCompute(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      HeightSampleMode heightSampleMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SampleProceduralTerrainTexture(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      List<TerrainTextureRule> includeRules,
      List<TerrainTextureRule> excludeRules,
      bool useIncludeRules,
      bool useExcludeRules)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SampleConcaveLocationCompute(
      ComputeBuffer computeInstancesBuffer,
      int sampleCount,
      Rect spawnRect,
      float polarSphereRadius,
      float minHeightDifference,
      float distance,
      bool inverse,
      bool average)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool NeedsSplatMapUpdate(Bounds updateBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareSplatmapGeneration(bool clearLockedTextures) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateSplatMapBiome(
      Bounds updateBounds,
      BiomeType biomeType,
      List<PolygonBiomeMask> polygonBiomeMaskList,
      List<TerrainTextureSettings> terrainTextureSettingsList,
      float heightCurveSampleHeight,
      float worldSpaceSeaLevel,
      bool clearLockedTextures)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompleteSplatmapGeneration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleConcaveLocation(
      VegetationInstanceData instanceData,
      float minHeightDifference,
      float distance,
      bool inverse,
      bool average,
      Rect spawnRect,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeTemporaryMemory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OverrideTerrainMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreTerrainMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerifySplatmapAccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTerrainMaterial(
      float worldspaceSeaLevel,
      float worldspaceMaxTerrainHeight,
      TerrainTextureSettings terrainTextureSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle ProcessSplatmapRules(
      List<TerrainTextureRule> terrainTextureRuleList,
      VegetationInstanceData instanceData,
      bool include,
      Rect cellRect,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasTerrainTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetTerrainTexture(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TerrainLayer[] GetTerrainLayers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerrainLayers(TerrainLayer[] terrainLayers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrain(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PqsMeshTerrain() => throw null;
  }
}
