// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCellSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.Vegetation.PersistentStorage;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationCellSpawner
  {
    public NativeList<JobHandle> JobHandleList;
    public NativeList<JobHandle> CellJobHandleList;
    public NativeArray<float> RandomNumbers;
    public ComputeBuffer RandomNumberBuffer;
    public ComputeBuffer SpawningArgsBuffer;
    private ComputeBuffer _computeInstancesBuffer;
    private readonly uint[] _spawningArgs;
    public List<IVegetationStudioTerrain> VegetationStudioTerrainList;
    public List<VegetationPackagePro> VegetationPackageProList;
    public List<VegetationPackageProModelInfo> VegetationPackageProModelsList;
    public VegetationSettings VegetationSettings;
    public VegetationSystemPro VegetationSystemPro;
    public PersistentVegetationStorage PersistentVegetationStorage;
    public VegetationInstanceDataPool VegetationInstanceDataPool;
    public float WorldspaceSeaLevel;
    public readonly int Compute_XSamplesID;
    public readonly int Compute_ZSamplesD;
    public readonly int Compute_SampleCountID;
    private static readonly int Compute_CellIndexID;
    private static readonly int Compute_SeedID;
    private static readonly int Compute_SampleDistanceID;
    private static readonly int Compute_SphereRadiusID;
    private static readonly int Compute_CalculatedSampleDistanceID;
    private static readonly int Compute_CellSizeID;
    private static readonly int Compute_CellCornerID;
    private static readonly int Compute_AppendInstanceDataBufferID;
    private static readonly int Compute_RandomNumberBufferID;
    private static readonly int Compute_InstanceDataBufferID;
    private static readonly int Compute_HeightmapTextureID;
    private static readonly int Compute_TerrainPositionID;
    private static readonly int Compute_TerrainSizeID;
    private static readonly int Compute_TerrainScaleID;
    private static readonly int Compute_HeightmapScaleID;
    private static readonly int Compute_HeightmapWidthID;
    private static readonly int Compute_HeightmapHeightID;
    public static readonly int Compute_OutputInstanceBufferID;
    public static readonly int Compute_InputInstanceBufferID;
    public static readonly int PersistentInstanceBufferID;
    public static readonly int CellArgsID;
    private static readonly int RandomizePositionID;
    private static readonly int UseSamplePointOffsetID;
    private static readonly int SamplePointMinOffsetID;
    private static readonly int SamplePointMaxOffsetID;
    private static readonly int UseNoiseCutoffID;
    private static readonly int NoiseCutoffInverseID;
    private static readonly int NoiseCutoffValueID;
    private static readonly int NoiseCutoffScaleID;
    private static readonly int NoiseCutoffOffsetID;
    private static readonly int UseNoiseDensityID;
    private static readonly int NoiseDensityInverseID;
    private static readonly int NoiseDensityScaleID;
    private static readonly int NoiseDensityOffsetID;
    private static readonly int UseNoiseScaleRuleID;
    private static readonly int NoiseScaleInverseID;
    private static readonly int NoiseScaleScaleID;
    private static readonly int NoiseScaleMinScaleID;
    private static readonly int NoiseScaleMaxScaleID;
    private static readonly int NoiseScaleOffsetID;
    private static readonly int UseHeightRuleID;
    private static readonly int MinHeightID;
    private static readonly int MaxHeightID;
    private static readonly int DefaultSpawnChanceID;
    private static readonly int DensityID;
    private static readonly int MinScaleID;
    private static readonly int MaxScaleID;
    private static readonly int ScaleMultiplierID;
    private static readonly int MinYOffsetID;
    private static readonly int MaxYOffsetID;
    private static readonly int VegetationRotationTypeID;
    private static readonly int RotationOffsetID;
    private static readonly int UseSteepnessRuleID;
    private static readonly int MinSteepnessID;
    private static readonly int MaxSteepnessID;
    private static readonly int UseBiomeMaskID;
    private static readonly int BiomeMaskTextureID;
    private static readonly int SelectedBiomeChannelID;
    private static readonly int BiomeMaskWidthID;
    private static readonly int BiomeMaskHeightID;
    private static readonly int BiomeCutoffWeightID;
    private static readonly int DependencyMaxDistanceDegreesID;
    private static readonly int DependencyMinDistanceDegreesID;
    private static readonly int DependencyDistanceMinScaleID;
    private static readonly int DependencyDistanceMaxScaleID;
    private static readonly int MaxDependentInstanceCountID;
    private static readonly int InjectedInstanceCountID;
    private static readonly int DependencyDistanceScaleInverseID;
    private static readonly int PositionDataBufferID;
    private static readonly int InstanceArgsID;
    private static readonly int PositionAppendBufferID;
    private static readonly int XIndexID;
    private static readonly int ZIndexID;
    private static readonly int UsePeakRuleID;
    private static readonly int PeakMinValueID;
    private static readonly int PeakMaxValueID;
    private static readonly int UseCavityRuleID;
    private static readonly int CavityMinValueID;
    private static readonly int CavityMaxValueID;
    private static readonly int SelectedBiomeChannelsID;
    private static readonly int SpawningArgsID;
    private static int _sizeOfComputeInstance;
    private static int _sizeOfMatrixInstance;
    private static readonly uint[] defaultArgsBuffer;
    private const int MaxDependentParentsInACell = 250;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSpawningArgsBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateRandomNumberList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetFirstUnityTerrainIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareVegetationCell(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetBiomeTextureMaskChannelIndex(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector4 GetBiomeTextureMaskChannelIndexVector4(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SampleBiomeData(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Color32 Max(Color32 x, Color32 y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte Max(byte a, byte b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Color32 SampleBiomePosition(
      Vector2 position,
      int width,
      int height,
      NativeArray<Color32> textureMaskNativeArray)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float2 NewClampPosition(float2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private JobHandle ExecuteSpawnRules(
      VegetationCell vegetationCell,
      Rect vegetationCellRect,
      int vegetationPackageIndex,
      int vegetationItemIndex,
      bool allowDelayedSpawning)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SpawnVegetationCell(
      VegetationCell vegetationCell,
      out bool hasInstancedIndirect,
      bool allowDelayedSpawning)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteSpawnRulesVegetationType(
      VegetationCell vegetationCell,
      Rect vegetationCellRect,
      ref bool hasInstancedIndirect,
      VegetationType vegetationType,
      bool allowDelayedSpawning)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 PolarToCartesian(Vector2 polar, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExecuteDelayedSpawnRulesCompute(
      VegetationCell vegetationCell,
      Rect vegetationCellRect,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private JobHandle ExecuteSpawnRulesCompute(
      VegetationCell vegetationCell,
      Rect vegetationCellRect,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ComputeBufferInfo GetComputeBufferInfo(
      string vegetationItemID,
      VegetationCell vegetationCell)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetDependencyMaxDistance(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCellSpawner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VegetationCellSpawner() => throw null;
  }
}
