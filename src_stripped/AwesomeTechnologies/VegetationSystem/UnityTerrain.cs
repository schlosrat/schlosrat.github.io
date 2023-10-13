// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.UnityTerrain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [ExecuteInEditMode]
  [AwesomeTechnologiesScriptOrder(-100)]
  public class UnityTerrain : MonoBehaviour, IVegetationStudioTerrain
  {
    public NativeArray<float> Heights;
    [SerializeField]
    private Terrain _terrain;
    private int _heightmapHeight;
    private int _heightmapWidth;
    private Vector3 _size;
    private Vector3 _scale;
    private Vector3 _heightmapScale;
    private Rect _terrainRect;
    private readonly List<NativeArray<ARGBBytes>> _splatMapArrayList;
    private Terrain.MaterialType _originalTerrainMaterialType;
    private Material _originalTerrainMaterial;
    private float _originalTerrainheightmapPixelError;
    public bool TerrainMaterialOverridden;
    private bool _originalTerrainInstanced;
    private float _originalBasemapDistance;
    [NonSerialized]
    public Material TerrainHeatmapMaterial;
    public bool DisableTerrainTreesAndDetails;
    public bool AutoAddToVegegetationSystem;
    private bool _initDone;
    public TerrainSourceID TerrainSourceID;
    public Vector3 TerrainPosition;
    private JobHandle _splatMapHandle;
    private NativeArray<HeightMapSample> _heightMapSamples;
    private NativeArray<float> _currentSplatmapArray;
    private readonly List<NativeArray<float>> _nativeArrayFloatList;

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
    private void FindTerrain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadHeightData() => throw null;

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
    public bool HasTerrainTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetTerrainTexture(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TerrainLayer[] GetTerrainLayers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerrainLayers(TerrainLayer[] terrainLayers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTerrainToVegetationSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    public string TerrainType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Bounds TerrainBounds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

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
    private void SetupHeatmapMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OverrideTerrainMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreTerrainMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTerrainMaterial(
      float worldspaceSeaLevel,
      float worldspaceMaxTerrainHeight,
      TerrainTextureSettings terrainTextureSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetTerrainPreviewTexture(int textureIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSplatMaps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSplatmapArraysValid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerifySplatmapAccess() => throw null;

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
    public UnityTerrain() => throw null;

    [BurstCompile(CompileSynchronously = true)]
    public struct GenerateDefaultBiomeBlendMaskJob : IJobParallelFor
    {
      public NativeArray<float> BlendMask;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct GenerateBlendMaskJob : IJobParallelFor
    {
      public NativeArray<float> BlendMask;
      [ReadOnly]
      public NativeArray<Vector2> PolygonArray;
      [ReadOnly]
      public NativeArray<LineSegment2D> SegmentArray;
      [ReadOnly]
      public NativeArray<float> CurveArray;
      public int Width;
      public int Height;
      public Vector3 TerrainSize;
      public Vector4 TerrainPosition;
      public Rect PolygonRect;
      public bool UseNoise;
      public float NoiseScale;
      public float BlendDistance;
      public bool Include;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float SampleCurveArray(float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float DistanceToEdge(Vector2 point) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsInPolygon(Vector2 p) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct CopyLockedDataJob : IJobParallelFor
    {
      public NativeArray<float> SplatMapArray;
      [ReadOnly]
      public NativeArray<float> CurrentSplatMapArray;
      public int Width;
      public int Height;
      public int Layers;
      public int TextureIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct ProcessSplatMapJob : IJobParallelFor
    {
      public NativeArray<float> SplatMapArray;
      [ReadOnly]
      public NativeArray<float> BlendMask;
      [ReadOnly]
      public NativeArray<HeightMapSample> HeightMap;
      [ReadOnly]
      public NativeArray<float> Heights;
      [ReadOnly]
      public NativeArray<float> HeightCurve;
      [ReadOnly]
      public NativeArray<float> SteepnessCurve;
      public int Width;
      public int Height;
      public int Layers;
      public int TextureIndex;
      public bool TextureUseNoise;
      public float TextureNoiseScale;
      public float TextureWeight;
      public Vector2 TextureNoiseOffset;
      public float NoiceCellResolutionFactor;
      public bool InverseTextureNoise;
      public float TerrainHeight;
      public float TerrainYPosition;
      public float WorldspaceSeaLevel;
      public int HeightmapWidth;
      public int HeightmapHeight;
      public Vector3 HeightMapScale;
      public bool ConcaveEnable;
      public bool ConvexEnable;
      public bool ConcaveAverage;
      public float ConcaveMinHeightDifference;
      public float ConcaveDistance;
      public int ConcaveMode;
      public Vector3 TerrainSize;
      public Vector4 TerrainPosition;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float SampleCurveArray(NativeArray<float> curve, float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float SampleConcaveFactor(float2 heightmapPosition) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float GetMinimumHeight(
        float height1,
        float height2,
        float height3,
        float height4,
        float height5,
        float height6,
        float height7,
        float height8)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float GetHeight(int x, int y) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct BlendSplatMapJob : IJobParallelFor
    {
      public NativeArray<float> CurrentSplatMapArray;
      [ReadOnly]
      public NativeArray<float> SplatMapArray;
      [ReadOnly]
      public NativeArray<float> BlendMask;
      public int Width;
      public int Height;
      public int Layers;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct NormalizeSplatMapJob : IJobParallelForBatch
    {
      public NativeArray<float> SplatMapArray;
      public int FirstEnabledIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int startIndex, int count) => throw null;
    }

    [BurstCompile(CompileSynchronously = true)]
    public struct NormalizeSplatMapKeepLockedDataJob : IJobParallelForBatch
    {
      public NativeArray<float> SplatMapArray;
      public int FirstEnabledIndex;
      [ReadOnly]
      [DeallocateOnJobCompletion]
      public NativeArray<int> AutomaticGenerationArray;
      [ReadOnly]
      [DeallocateOnJobCompletion]
      public NativeArray<int> LockedTextureArray;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int startIndex, int count) => throw null;
    }
  }
}
