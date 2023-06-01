// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationItemInfoPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Shaders;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class VegetationItemInfoPro
  {
    public string VegetationItemID;
    public string Name;
    public VegetationType VegetationType;
    public VegetationPrefabType PrefabType;
    public VegetationRenderMode VegetationRenderMode;
    public bool EnableRuntimeSpawn;
    public bool RenderItem;
    public bool UseComputeSpawnRules;
    public bool DisableShadows;
    public GameObject VegetationPrefab;
    public Texture2D VegetationTexture;
    public string VegetationGuid;
    public float SampleDistance;
    public float Density;
    public bool RandomizePosition;
    public bool UseVegetationMasksOnStorage;
    public bool UseSamplePointOffset;
    public float SamplePointMinOffset;
    public float SamplePointMaxOffset;
    public Vector3 Offset;
    public Vector3 RotationOffset;
    public VegetationRotationType Rotation;
    public float MinYOffset;
    public float MaxYOffset;
    public Bounds Bounds;
    public Vector3 ScaleMultiplier;
    public float RenderDistanceFactor;
    public int Seed;
    public float MinScale;
    public float MaxScale;
    public float YScale;
    public ColliderType ColliderType;
    public float ColliderRadius;
    public float ColliderHeight;
    public Vector3 ColliderOffset;
    public Vector3 ColliderSize;
    public bool ColliderTrigger;
    public Mesh ColliderMesh;
    public bool ColliderUseForBake;
    public float ColliderDistanceFactor;
    public string ColliderTag;
    public bool ColliderConvex;
    public NavMeshObstacleType NavMeshObstacleType;
    public Vector3 NavMeshObstacleCenter;
    public Vector3 NavMeshObstacleSize;
    public float NavMeshObstacleRadius;
    public float NavMeshObstacleHeight;
    public bool NavMeshObstacleCarve;
    public int NavMeshArea;
    public bool UseBillboards;
    public BillboardQuality BillboardQuality;
    public Texture2D BillboardTexture;
    public Texture2D BillboardNormalTexture;
    public Texture2D BillboardAoTexture;
    public LODLevel BillboardSourceLODLevel;
    public ColorSpace BillboardColorSpace;
    public float BillboardBrightness;
    public float BillboardCutoff;
    public Color BillboardTintColor;
    public Color BillboardAtlasBackgroundColor;
    public float BillboardMipmapBias;
    public float BillboardWindSpeed;
    public float BillboardSmoothness;
    public float BillboardMetallic;
    public float BillboardSpecular;
    public float BillboardOcclusion;
    public float BillboardNormalStrength;
    public bool BillboardRecalculateNormals;
    public float BillboardNormalBlendFactor;
    public BillboardRenderMode BillboardRenderMode;
    public bool BillboardFlipBackNormals;
    public GameObject BillboardCustomPrefab;
    public float BillboardFadeDistance;
    public bool UseHeightRule;
    public float MinHeight;
    public float MaxHeight;
    public bool UseAdvancedHeightRule;
    public float MaxCurveHeight;
    public AnimationCurve HeightRuleCurve;
    public bool UseSteepnessRule;
    public float MinSteepness;
    public float MaxSteepness;
    public bool UseAdvancedSteepnessRule;
    public AnimationCurve SteepnessRuleCurve;
    public bool UseNoiseCutoff;
    public float NoiseCutoffValue;
    public float NoiseCutoffScale;
    public bool NoiseCutoffInverse;
    public Vector2 NoiseCutoffOffset;
    public bool UseNoiseDensity;
    public float NoiseDensityScale;
    public bool NoiseDensityInverse;
    public Vector2 NoiseDensityOffset;
    public bool UseNoiseScaleRule;
    public float NoiseScaleMinScale;
    public float NoiseScaleMaxScale;
    public float NoiseScaleScale;
    public bool NoiseScaleInverse;
    public Vector2 NoiseScaleOffset;
    public bool UseBiomeEdgeScaleRule;
    public float BiomeEdgeScaleDistance;
    public float BiomeEdgeScaleMinScale;
    public float BiomeEdgeScaleMaxScale;
    public bool BiomeEdgeScaleInverse;
    public bool UseBiomeEdgeIncludeRule;
    public float BiomeEdgeIncludeDistance;
    public bool BiomeEdgeIncludeInverse;
    public bool UseConcaveLocationRule;
    public bool ConcaveLocationInverse;
    public float ConcaveLocationValue;
    public float ConcaveLoactionMinHeightDifference;
    public float ConcaveLoactionDistance;
    public bool ConcaveLoactionAverage;
    public bool UsePeakRule;
    public float PeakMinValue;
    public float PeakMaxValue;
    public bool UseCavityRule;
    public float CavityMinValue;
    public float CavityMaxValue;
    public bool UseTerrainTextureIncludeRules;
    public List<TerrainTextureRule> TerrainTextureIncludeRuleList;
    public bool UseTerrainTextureExcludeRules;
    public List<TerrainTextureRule> TerrainTextureExcludeRuleList;
    public bool UseProceduralTextureIncludeRules;
    public List<TerrainTextureRule> ProceduralTextureIncludeRuleList;
    public bool UseProceduralTextureExcludeRules;
    public List<TerrainTextureRule> ProceduralTextureExcludeRuleList;
    public bool UseTextureMaskIncludeRules;
    public List<TextureMaskRule> TextureMaskIncludeRuleList;
    public bool UseTextureMaskExcludeRules;
    public List<TextureMaskRule> TextureMaskExcludeRuleList;
    public PqsTextureSampleRule PqsTextureSampleRule;
    public bool UsePqsTextureSampleRule;
    public bool UseDependencyRules;
    public string DependencyVegetationID;
    public float DependencyMaxDistance;
    public float DependencyMinDistance;
    public float DependencyDistanceMinScale;
    public float DependencyDistanceMaxScale;
    public bool DependencyDistanceScaleInverse;
    public int DependencyMaxInstanceCount;
    public DependencyMode DependencyMode;
    public string ShaderName;
    public ShaderControllerSettings ShaderControllerSettings;
    public bool UseTerrainSourceIncludeRule;
    public TerrainSourceRule TerrainSourceIncludeRule;
    public bool UseTerrainSourceExcludeRule;
    public TerrainSourceRule TerrainSourceExcludeRule;
    public bool DisableLOD;
    public float LODFactor;
    public bool UseDistanceFalloff;
    public float DistanceFalloffStartDistance;
    public bool UseVegetationMask;
    public VegetationTypeIndex VegetationTypeIndex;
    public List<RuntimePrefabRule> RuntimePrefabRuleList;
    public HeightSampleMode HeightSampleMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemInfoPro() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemInfoPro(VegetationItemInfoPro sourceItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopySettingValues(VegetationItemInfoPro sourceItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDistanceBand() => throw null;
  }
}
