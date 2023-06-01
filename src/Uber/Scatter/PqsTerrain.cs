// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.PqsTerrain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using AwesomeTechnologies.VegetationSystem.Biomes;
using KSP.Rendering.Planets;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Uber.Scatter
{
  [ExecuteInEditMode]
  public class PqsTerrain : MonoBehaviour, IVegetationStudioTerrain
  {
    public PQS Pqs;
    public float MaxHeight;
    public float MinReportedCellHeight;
    public float MaxReportedCellHeight;
    private Texture2D ghm;
    private Texture2D lR;
    private Texture2D lG;
    private Texture2D lB;
    private Texture2D lA;
    private Texture2D mR;
    private Texture2D mG;
    private Texture2D mB;
    private Texture2D mA;
    public Texture2D GlobalHeightMap;
    public Texture2D LargeMapR;
    public Texture2D LargeMapG;
    public Texture2D LargeMapB;
    public Texture2D LargeMapA;
    public Texture2D MediumMapR;
    public Texture2D MediumMapG;
    public Texture2D MediumMapB;
    public Texture2D MediumMapA;
    public Texture2D LayerMask;
    public int GlobalWidth;
    public int GlobalHeight;
    public float GlobalMapScale;
    public int LargeMapWidthR;
    public int LargeMapHeightR;
    public float LargeUvScaleR;
    public float LargeHeightScaleR;
    public int LargeMapWidthG;
    public int LargeMapHeightG;
    public float LargeUvScaleG;
    public float LargeHeightScaleG;
    public int LargeMapWidthB;
    public int LargeMapHeightB;
    public float LargeUvScaleB;
    public float LargeHeightScaleB;
    public int LargeMapWidthA;
    public int LargeMapHeightA;
    public float LargeUvScaleA;
    public float LargeHeightScaleA;
    public int MediumMapWidthR;
    public int MediumMapHeightR;
    public float MediumUvScaleR;
    public float MediumHeightScaleR;
    public int MediumMapWidthG;
    public int MediumMapHeightG;
    public float MediumUvScaleG;
    public float MediumHeightScaleG;
    public int MediumMapWidthB;
    public int MediumMapHeightB;
    public float MediumUvScaleB;
    public float MediumHeightScaleB;
    public int MediumMapWidthA;
    public int MediumMapHeightA;
    public float MediumUvScaleA;
    public float MediumHeightScaleA;
    public float TiledHeightMapContrast;
    public int MaskWidth;
    public int MaskHeight;
    private int _decalDataSize;
    private ComputeShader SamplePQSHeightShader;
    private int SamplePQSHeighKernelHandle;
    private int SampleTerrainNormalKernelHandle;
    private int CalculateThreadCountHandle;
    private ComputeShader SampleProceduralTextureShader;
    private int SampleProceduralTextureKernelHandle;
    private ComputeBuffer _decalInstancesBuffer;
    private ComputeBuffer _decalArrayBuffer;
    private ComputeBuffer _decalAlphaBuffer;
    public ComputeBuffer _terrainSampleArgsBuffer;
    private readonly uint[] _terrainSampleArgs;
    private const string SUB_ZONES_ENABLED_KEYWORD = "SUB_ZONES_ENABLED";
    private static readonly int Compute_SampleCountID;
    private static readonly int Compute_NumQuadsAlongCubeFaceID;
    private static readonly int Compute_ReduceFloatingScatterID;
    private static readonly int Compute_HeightSampleModeID;
    private static readonly int Compute_InstanceDataBufferID;
    private static readonly int TerrainSampleArgsID;
    private NativeList<DecalInstance> _emptyDecalInstanceList;
    private bool _computeInitDone;
    private PQSRenderer _pqsRenderer;
    private const int MaxDefaultSubdivisionsFallback = 17;

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
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDecals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDecalInstances() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainData(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateComputeShaderResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateShaders() => throw null;

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
    private void CreateHeightMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

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
    public PqsTerrain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PqsTerrain() => throw null;
  }
}
