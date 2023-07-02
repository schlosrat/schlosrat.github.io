// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [ExecuteInEditMode]
  public class MeshTerrain : MonoBehaviour, IVegetationStudioTerrain
  {
    private List<ObjectData> _objects;
    public List<BVHTriangle> Tris;
    private List<BVHNode> _nodes;
    private List<BVHTriangle> _finalPrims;
    public int CurrentTabIndex;
    public MeshTerrainData MeshTerrainData;
    public List<MeshTerrainTerrainSource> MeshTerrainTerrainSourceList;
    public List<MeshTerrainMeshSource> MeshTerrainMeshSourceList;
    public bool ShowDebugInfo;
    public bool NeedGeneration;
    private Material _debugMaterial;
    public bool MultiLevelRaycast;
    public bool AutoAddToVegegetationSystem;
    private NativeArray<LBVHNODE> _nativeNodes;
    private NativeArray<LBVHTriangle> _nativePrims;
    private bool _initDone;
    public bool Filterlods;
    public List<BVHRaycastContainer> RaycastContainerList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateMeshTerrain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds CalculateTerrainBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddMeshRenderer(GameObject go, TerrainSourceID terrainSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetMeshTerrainSourceTypeColor(TerrainSourceID terrainSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTerrain(GameObject go, TerrainSourceID terrainSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateNativeArrays() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeNativeArrays() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasMeshRenderer(MeshRenderer meshRenderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasTerrain(Terrain terrain) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawDebuginfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawMeshRenderer(
      MeshRenderer meshRenderer,
      MaterialPropertyBlock materialPropertyBlock,
      TerrainSourceID terrainSourceID)
    {
      throw null;
    }

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

    public float PolarSphereMaxHeight
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
    public MeshTerrain() => throw null;
  }
}
