// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationSystemPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.BillboardSystem;
using AwesomeTechnologies.Utility;
using AwesomeTechnologies.Utility.Quadtree;
using AwesomeTechnologies.Vegetation.Masks;
using AwesomeTechnologies.Vegetation.PersistentStorage;
using AwesomeTechnologies.VegetationStudio;
using AwesomeTechnologies.VegetationSystem.Wind;
using KSP.Rendering;
using KSP.Rendering.Planets;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace AwesomeTechnologies.VegetationSystem
{
  [AwesomeTechnologiesScriptOrder(100)]
  [ExecuteInEditMode]
  public class VegetationSystemPro : MonoBehaviour
  {
    public QuadTree<VegetationCell> VegetationCellQuadTree;
    public QuadTree<VegetationCell> BillboardCellQuadTree;
    public QuadTree<VegetationCell> HeroCellQuadTree;
    [NonSerialized]
    public readonly List<VegetationCell> VegetationCellList;
    [NonSerialized]
    public readonly List<VegetationCell> BillboardCellList;
    [NonSerialized]
    public readonly List<VegetationCell> HeroCellList;
    [NonSerialized]
    public readonly List<VegetationCell> LoadedVegetationCellList;
    [NonSerialized]
    public readonly List<VegetationCell> LoadedBillboardCellList;
    [NonSerialized]
    public readonly List<VegetationCell> LoadedHeroCellList;
    [NonSerialized]
    public readonly List<VegetationCell> PredictiveCellLoaderList;
    public VegetationCellFactory VegetationCellFactory;
    public VegetationCellFactory BillboardCellFactory;
    public VegetationCellFactory HeroCellFactory;
    public VegetationCellSpawner VegetationCellSpawner;
    public Bounds VegetationSystemBounds;
    public bool AutomaticBoundsCalculation;
    public TerrainType TerrainType;
    public float PolarSphereRadius;
    public float PolarSphereMaxHeight;
    public Transform PolarSphereTransform;
    public Vector3 PolarSphereInitialPosition;
    public Rect InitialRect;
    public Rect FirstRect;
    public Rect LastRect;
    public PersistentVegetationStorage PersistentVegetationStorage;
    public int CurrentTabIndex;
    public int VegetationPackageIndex;
    public float SeaLevel;
    public bool ExcludeSeaLevelCells;
    public float VegetationCellSize;
    public int BillboardCellSizeMultiplier;
    public int HeroCellSizeMultiplier;
    public Texture2D BiomeTextureMask;
    public bool UseBiomeTextureMask;
    public BiomeType BiomeTextureMaskRChannelType;
    public BiomeType BiomeTextureMaskGChannelType;
    public BiomeType BiomeTextureMaskBChannelType;
    public BiomeType BiomeTextureMaskAChannelType;
    public TextureMaskRotation BiomeTextureRotation;
    public Vector2 BiomeTextureOffset;
    public TextureMaskFlip BiomeTextureFlip;
    [NonSerialized]
    public float AdditionalBoundingSphereRadius;
    public int SelectedTextureMaskGroupTextureIndex;
    public int SelectedTextureMaskGroupIndex;
    public bool ReadBackInstanceCount;
    public int TotalInstanceCount;
    public int TotalBillboardCount;
    [NonSerialized]
    public bool BillboardOn;
    [NonSerialized]
    public bool InstancedOn;
    [NonSerialized]
    public bool ShowItemSpecificProfileMarkers;
    public TextureMask DebugTextureMask;
    public Vector2 PolarCellOffset;
    [NonSerialized]
    public bool InitDone;
    public VegetationSettings VegetationSettings;
    public VegetationRenderSettings VegetationRenderSettings;
    public EnvironmentSettings EnvironmentSettings;
    public List<VegetationStudioCamera> VegetationStudioCameraList;
    public List<VegetationStudioColliderCamera> VegetationStudioColliderCameraList;
    public bool ShowBoundingSpheres;
    public bool ShowVegetationCells;
    public bool ShowBillboardCells;
    public bool ShowHeroCells;
    public bool ShowVisibleBillboardCells;
    public bool ShowVisibleHeroCells;
    public bool ShowPotentialVisibleCells;
    public bool ShowVisibleCells;
    public bool ShowBiomeCells;
    public bool ShowVegetationMaskCells;
    public bool ShowHeatMap;
    public bool ShowTerrainTextures;
    public bool ShowVegetationPackageGeneralSettingsMenu;
    public bool ShowVegetationPackageNoiseMenu;
    public bool ShowTerrainTextureRulesMenu;
    public bool ShowTextureMaskRulesMenu;
    public bool ShowVegetationMaskRulesMenu;
    public bool ShowShaderSettingsMenu;
    public bool ShowPositionMenu;
    public bool ShowDistanceFalloffMenu;
    public bool ShowBiomeRulesMenu;
    public bool ShowConcaveLocationRulesMenu;
    public bool ShowColliderRulesMenu;
    public bool ShowBillboardsMenu;
    public bool ShowVegetationItemSettingsMenu;
    public bool ShowTerrainSourceSettingsMenu;
    public bool ShowPqsTextureSettingsMenu;
    public bool ShowAddVegetationItemMenu;
    public bool ShowLODMenu;
    public bool ShowProceduralTextureRulesMenu;
    public bool ShowDependencyRulesMenu;
    public bool _suspendVegetationSystem;
    public List<IVegetationStudioTerrain> VegetationStudioTerrainList;
    public List<GameObject> VegetationStudioTerrainObjectList;
    public List<VegetationPackagePro> VegetationPackageProList;
    public List<VegetationPackageProModelInfo> VegetationPackageProModelsList;
    public List<WindControllerSettings> WindControllerSettingsList;
    public PredictiveCellLoader PredictiveCellLoader;
    public int PredictiveCellLoaderCellsPerFrame;
    public bool LoadPotentialVegetationCells;
    public VegetationSystemPro.MultiOnAddCameraDelegate OnAddCameraDelegate;
    public VegetationSystemPro.MultiOnRemoveCameraDelegate OnRemoveCameraDelegate;
    public VegetationSystemPro.MultiOnVegetationStudioRefreshDelegate OnRefreshVegetationSystemDelegate;
    public VegetationSystemPro.MultiOnVegetationStudioRefreshDelegate OnRefreshColliderSystemDelegate;
    public VegetationSystemPro.MultiOnVegetationCellSpawnedDelegate OnVegetationCellLoaded;
    public VegetationSystemPro.MultiOnClearCacheDelegate OnClearCacheDelegate;
    public VegetationSystemPro.MultiOnClearCacheVegetationItemDelegate OnClearCacheVegetationItemDelegate;
    public VegetationSystemPro.MultiOnClearCacheVegetationCellDelegate OnClearCacheVegetationCellDelegate;
    public VegetationSystemPro.MultiOnClearCacheVegetationCellVegetationItemDelegate OnClearCacheVegetationCellVegetatonItemDelegate;
    public VegetationSystemPro.MultOnRenderCompleteDelegate OnRenderCompleteDelegate;
    [NonSerialized]
    private readonly List<IWindController> _windControllerList;
    public WindZone SelectedWindZone;
    public float WindSpeedFactor;
    public Light SunDirectionalLight;
    public int FrustumKernelHandle;
    public int ComputeFrustumCullingThreadCountKernelHandle;
    public ComputeShader FrusumMatrixShader;
    private int _cameraFrustumPlan0;
    private int _cameraFrustumPlan1;
    private int _cameraFrustumPlan2;
    private int _cameraFrustumPlan3;
    private int _cameraFrustumPlan4;
    private int _cameraFrustumPlan5;
    public int BillboardMergeBufferKernelDirectHandle;
    public ComputeShader BillboardMergeBufferShader;
    public int _billboardCellInstanceCountID;
    public int SpawnPositionsKernelHandle;
    public int CreatePersistantInstancesHandle;
    public int InjectDependentInstancesCircleHandle;
    public int DependencyRulesKernelHandle;
    public int CreateInstancesKernelHandle;
    public int CompactMemoryHandle;
    public int CalculateSpawnThreadCountHandle;
    public ComputeShader SpawnCreateInstancesShader;
    private static int _sizeOfItemSpawnData;
    private int _billboardCullDistanceID;
    private int _billboardLODFadeDistanceID;
    private int _billboardFarCullDistanceID;
    private int _billboardWorldSpaceCameraPosID;
    private int _floatingOriginOffsetID;
    private int _spawningArgsID;
    private int _mergeBufferID;
    private int _mergeSourceBuffer0ID;
    private int _mergeInstanceCount0ID;
    private int _visibleBufferLod0ID;
    private int _visibleBufferLod1ID;
    private int _visibleBufferLod2ID;
    private int _visibleBufferLod3ID;
    private int _shadowBufferLod0ID;
    private int _shadowBufferLod1ID;
    private int _shadowBufferLod2ID;
    private int _shadowBufferLod3ID;
    private int _sourceBufferID;
    private int _instanceCountID;
    private int _boundingSphereRadiusID;
    private int _boundingSphereOffsetID;
    private int _scaleMultiplierID;
    private int _useLodsID;
    private int _noFrustumCullingID;
    private int _shadowCullingID;
    private int _cullFarStartID;
    private int _visibleShaderDataBufferID;
    private int _indirectShaderDataBufferID;
    private int _lod1Distance;
    private int _lod2Distance;
    private int _lod3Distance;
    private int _lightDirection;
    private int _planeOrigin;
    private int _boundsSize;
    private int _lodFactor;
    private int _lodBias;
    private int _lodFadeDistance;
    private int _lodCount;
    private static readonly int TextureWidthId;
    private static readonly int TextureHeightId;
    private static readonly int InstanceDataBufferId;
    private static readonly int InstanceCountId;
    private static readonly int BillboardFadeDistanceId;
    public static readonly int PQSToWorldMtxId;
    private readonly List<VegetationCell> _hasBufferList;
    private readonly List<VegetationCell> _hasBillboardBufferList;
    private readonly Matrix4x4[] _renderArray;
    private readonly Vector4[] _renderLodFadeArray;
    public Transform FloatingOriginAnchor;
    public Vector3 FloatingOriginOffset;
    public Vector3 TestFloatingOriginOffset;
    public Vector3 FloatingOriginStartPosition;
    private static readonly int VsFloatingOriginOffset;
    private static readonly int VsFloatingOriginOffset2;
    public PQS PQS;
    public Material MicroSplatMaterial;
    public Camera kspCameraCached;
    private List<VegetationCellReadbackRequest> _vegetationCellReadbackRequestList;
    private KSP.Rendering.GraphicsSettings _graphicsSettings;
    private QualityManager _qualityManager;
    private readonly HashSet<VegetationCell> _incompletelySpawnedVegetationCells;
    private readonly HashSet<VegetationCell> _incompletelySpawnedBillboardCells;
    private readonly HashSet<VegetationCell> _incompletelySpawnedHeroCells;
    private List<VegetationCell> delayedSpawnRemoveWorker;
    [NonSerialized]
    private readonly List<VegetationCell> _billboardTempVegetationCellList;
    [NonSerialized]
    private readonly List<BillboardCell> _loadBillboardCellList;
    private static Vector3[] frustumRaysWorker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugShowGPUMemoryUsage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VegetationCellType VegetationTypeToVegetationCellType(VegetationType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetVegetationCellSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetBillboardCellSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetHeroCellSize() => throw null;

    public Vector3 VegetationSystemPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DetectPersistentVegetationStorage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SuspendVegetationSystem(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindDirectionalLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AdapterAddCamera(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoSelectCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshVegetationSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshColliderSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupVegetationSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompleteCellLoading() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDefaultSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnabledSettingChanged(Setting setting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeregisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadSettingsFromQualityManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableEditorApi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableEditorApi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSceneviewTransformChanged(Camera currentCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSceneviewCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transform GetFloatingOriginAnchor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitForDelayedSpawning(VegetationCell cell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCell GetOverlappingBillboardCell(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCell GetOverlappingHeroCell(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetDependencyInfo(
      string parentVegetationItemId,
      VegetationCell childCell,
      out VegetationCell parentCell,
      out int packageIndex,
      out int vegetationIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteSpawnRulesDelayed(
      VegetationCell vegetationCell,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SpawnItemsInIncompletelySpawnedCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SpawnItemsInIncompletelySpawnedCells(
      HashSet<VegetationCell> incompletelySpawnedCells)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadVisibleHeroCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadVisibleBillboardCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadVisibleVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeAllVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderInstancedIndirectVegetation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeTemporaryTerrainMemory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QualityManager GetQualityManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeBillboardCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBillboardCulling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearBillboardCellsCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearHeroCellsCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearBillboardCellsCache(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearHeroCellsCache(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearBillboardCellsCache(
      Bounds bounds,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderBillboardCellsInstancedIndirect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBillboardFrustumCullingPlanes(Camera selectedCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CompactCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CompactVegetationCellCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CompactBillboardCellCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CompactHeroCellCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCamera(
      Camera aCamera,
      bool noFrustumCulling = false,
      bool renderDirectToCamera = false,
      bool renderBillboardsOnly = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddVegetationStudioCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCamera(Camera aCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveVegetationStudioCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera GetVegetationStudioCamera(Camera aCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera GetVegetationStudioCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera GetSceneViewVegetationStudioCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeVegetationStudioCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationStudioCameraDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVegetationStudioCamerasDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveColliderCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveColliderCamera(VegetationStudioColliderCamera colliderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupColliderCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCamera(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFrustumCullingPlanes(Camera selectedCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupComputeShaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool _CanAnyVegetationBeSeenInThisCell(
      VegetationCell cell,
      float cullDistance,
      Vector3 cameraPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CalculateMaxPossibleVisibleItems(
      Vector3[] frustumRays,
      VegetationItemInfoPro vegetationItemInfoPro,
      float cullDistance,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetVegetationItemCullDistanceForBillboard(VegetationItemInfoPro vegetationItemInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetVegetationItemCullDistance(VegetationItemInfoPro vegetationItemInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawCellsIndirectComputeShader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderVegetationItemLODIndirect(
      VegetationItemModelInfo vegetationItemModelInfo,
      Bounds cellBounds,
      int lodIndex,
      int cameraIndex,
      Camera selectedCamera,
      ShadowCastingMode shadowCastingMode,
      int layer,
      bool shadows,
      CommandBuffer commandBuffer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshAllPrefabs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSeaLevel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawTextureMaskAreas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPolarRect(Rect rect, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPolarSphereTerrainGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupVegetationItemModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupVegetationItemModelsPerCameraBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearWindSampler(GameObject windSampler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemModelInfo GetVegetationItemModelInfo(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemModelInfo GetVegetationItemModelInfo(
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshMaterials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearVegetationItemModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupPolarSphereInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPolarSphereRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPolarSphereMaxHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform GetPolarSphereTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupPredictiveCellLoader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadArea(Rect rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadArea(Rect rect, List<VegetationCell> overlapVegetationCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadAllVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTerrain(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTerrains(List<GameObject> terrainList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerifySplatmapAccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainHeightmap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAllUnityTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAllMeshTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAllTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAllRaycastTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTerrain(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshVegetationStudioTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerifyVegetationStudioTerrains() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateVegetationSystemBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessReadbackRequests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CompactGPUMemory(
      VegetationCell vegetationCell,
      int instanceCount,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasColliderOrRuntimePrefab(int vegetationPackageIndex, int vegetationItemIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationCellReadbackRequest(
      VegetationCellReadbackRequest vegetationCellReadbackRequest)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeReadbackRequests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeAndClearVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeHeroCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCellFactory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTerrainArea(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ForceCullingRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupVegetationCellSpawner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeList<ScatterInstance> GetVegetationItemInstances(
      VegetationCell vegetationCell,
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemIndexes GetVegetationItemIndexes(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(VegetationCell vegetationCell, string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(
      VegetationCell vegetationCell,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(int vegetationPackageIndex, int vegetationItemIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDemandCreateVegetationCells(Rect rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDemandCreateVegetationCells(
      Rect rect,
      List<VegetationCell> overlapVegetationCellList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDemandClearVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDemandCreateBillboardCells(
      Rect rect,
      List<VegetationCell> overlapBillboardCellList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDemandCreateHeroCells(Rect rect, List<VegetationCell> overlapHeroCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationPackage(VegetationPackagePro vegetationPackagePro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationPackage(VegetationPackagePro vegetationPackagePro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationPackagePro GetVegetationPackageFromBiome(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMaxVegetationPackageItemCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<BiomeType> GetAdditionalBiomeList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetBiomeSortOrder(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemInfoPro GetVegetationItemInfo(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllVegetationPackagesDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupWind() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindWindZone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWindSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupWindSamplers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private WindControllerSettings GetWindControllerSettings(string windControllerID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSystemPro() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VegetationSystemPro() => throw null;

    public delegate void MultiOnAddCameraDelegate(VegetationStudioCamera vegetationStudioCamera);

    public delegate void MultiOnRemoveCameraDelegate(VegetationStudioCamera vegetationStudioCamera);

    public delegate void MultiOnVegetationStudioRefreshDelegate(
      VegetationSystemPro vegetationSystemPro);

    public delegate void MultiOnClearCacheDelegate(VegetationSystemPro vegetationSystemPro);

    public delegate void MultiOnClearCacheVegetationCellDelegate(
      VegetationSystemPro vegetationSystemPro,
      VegetationCell vegetationCell);

    public delegate void MultiOnClearCacheVegetationItemDelegate(
      VegetationSystemPro vegetationSystemPro,
      int vegetationPackageIndex,
      int vegetationItemIndex);

    public delegate void MultiOnClearCacheVegetationCellVegetationItemDelegate(
      VegetationSystemPro vegetationSystemPro,
      VegetationCell vegetationCell,
      int vegetationPackageIndex,
      int vegetationItemIndex);

    public delegate void MultiOnVegetationCellSpawnedDelegate(VegetationCell vegetationCell);

    public delegate void MultOnRenderCompleteDelegate(VegetationSystemPro vegetationSystemPro);
  }
}
