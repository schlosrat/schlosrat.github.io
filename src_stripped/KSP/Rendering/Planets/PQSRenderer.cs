// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering.Planets
{
  [AwesomeTechnologiesScriptOrder(50)]
  public class PQSRenderer : KerbalMonoBehaviour, IPQSRenderer
  {
    private static int _numVecs;
    private const int BATCH_SIZE = 96;
    private int _componentsPerOctave;
    private float[] _wavelengths;
    private float[] _amplitudes;
    private float[] _angleDegs;
    private float[] _phases;
    private float[] _angleDegs_variance180;
    private static readonly int sp_Wavelengths;
    private static readonly int sp_TwoPiOverWavelengths;
    private static readonly int sp_Amplitudes;
    private static readonly int sp_WaveDirX;
    private static readonly int sp_WaveDirZ;
    private static readonly int sp_Phases;
    private static readonly int sp_WaveDirX_Variance180;
    private static readonly int sp_WaveDirZ_Variance180;
    private static readonly int sp_Phases_Variance180;
    private static readonly int sp_NumWaveVecs;
    private static readonly int sp_LocalToPlanetMatrix;
    private static readonly int sp_PlanetToWorldMatrix;
    private static readonly int sp_WaterAnimationTexture;
    private static readonly int sp_SimulateSize;
    private static readonly int sp_HeightFromWater;
    private static readonly int sp_CameraPosOnOceanPlane;
    private static readonly int sp_WaveAnimationTextureHalfSize;
    private static readonly int sp_WorldSizePerPixel;
    private static readonly int sp_AnimationFadeStartHeight;
    private static readonly int sp_AnimationFadeEndHeight;
    private static readonly int sp_ComputeGroupHalfSize;
    private static readonly int sp_WorldSizePerGroup;
    private static readonly int sp_FarWaterAnimationTexture;
    private static readonly int sp_FarWorldSizePerPixel;
    private static readonly int sp_Params;
    private static readonly int sp_TessellationFactor;
    private static readonly int sp_SimDeltaTime;
    private static readonly int sp_SimulateSizePre;
    private static readonly int sp_FoamFade;
    private static readonly int sp_FoamStrength;
    private static readonly int sp_ShorelineFoamStrength;
    private static readonly int sp_FoamTextureSource;
    private static readonly int sp_FoamTextureTarget;
    private static readonly int sp_FoamHalf2TextureSource;
    private static readonly int sp_FoamHalf2TextureTarget;
    private static readonly int sp_FoamTextureSize;
    private static readonly int sp_FoamTextureHalfSize;
    private static readonly int sp_MipmapLevel;
    private static readonly int sp_FarParams;
    private static readonly int sp_FarFoamFade;
    private static readonly int sp_FarFoamStrength;
    private static readonly int sp_FarShorelineFoamStrength;
    private static readonly int sp_FarFoamTextureSource;
    private static readonly int sp_FarFoamTextureTarget;
    private static readonly int sp_FarFoamTextureSize;
    private static readonly int sp_FoamCycleTexture;
    private static readonly int sp_FoamTextureSourceSize;
    private static readonly int sp_FoamTextureSourceSizeSubOne;
    private static readonly int sp_OceanVertsIndicesBuffer;
    private static readonly int sp_OceanVertsWorldPositionBuffer;
    private static readonly int sp_OceanVertsOnPlanetBuffer;
    private static readonly int sp_OceanVertsOnOceanPlaneBuffer;
    private static readonly int sp_OceanVertsSphereUV;
    private static readonly int sp_OceanVertsFaceNorthMatrixBuffer_X;
    private static readonly int sp_OceanVertsFaceNorthMatrixBuffer_Y;
    private static readonly int sp_OceanSphereVertsIndicesBuffer;
    private static readonly int sp_OceanSphereVertsWorldPositionBuffer;
    private static readonly int sp_OceanSphereVertsOnPlanetBuffer;
    private static readonly int sp_OceanSphereVertsFaceNorthMatrixBuffer_X;
    private static readonly int sp_OceanSphereVertsFaceNorthMatrixBuffer_Y;
    private static readonly int sp_QuadWaterMaskTexture;
    private static readonly int sp_ShorelineSDFTexture;
    private static readonly int sp_SpectrumFadeStartHeight;
    private static readonly int sp_SpectrumFadeEndHeight;
    private static readonly int sp_ShoreWaveAttenuation;
    private static readonly int sp_CameraViewProjMatrix;
    private static readonly int sp_OceanMaskTexture;
    private static readonly int sp_UnderOceanMaskTexture;
    private static readonly int sp_LightDirection;
    private static readonly int sp_LightColor;
    private static readonly int sp_RunningTime;
    private static readonly int sp_RunningTimeCaustics;
    private static readonly int sp_WaterNormalTexture;
    private static readonly int sp_SpectrumNormalStrength;
    private static readonly int sp_WaterTwoSideDepthTexture;
    private static readonly int sp_UnderWaterLightingTexture;
    private static readonly int sp_BluredUnderWaterLightingTexture;
    private static readonly int sp_UnderWaterLightingTextureSize;
    private static readonly int sp_UnderOceanRegionVertexDensity;
    private static readonly int sp_UnderOceanRegionVertsBuffer;
    private static readonly int sp_CameraPos;
    private static readonly int sp_ProjectionExtents;
    private static readonly int sp_PlanetToOceanMatrix;
    private static readonly int sp_WorldToPlanetMatrix;
    private static readonly int sp_WorldToOceanMatrix;
    private static readonly int sp_OceanRadius;
    private static readonly int sp_OceanRadiusOffsetHeight;
    private static readonly int sp_CameraPosOnPlanet;
    private static readonly int sp_CenterOfPlanet;
    private static readonly int sp_UnderWaterDiffuseColor;
    private static readonly int sp_UnderWaterTransparentStrength;
    private static readonly int sp_UnderWaterRefractionStrength;
    private static readonly int sp_UnderWaterMaxVisibleDistance;
    private static readonly int sp_UnderWaterDistanceFadeStrength;
    private static readonly int sp_UnderWaterMaxVisibleDepth;
    private static readonly int sp_UnderWaterDepthFadeStrength;
    private static readonly int sp_UnderWaterSpecularStrength;
    private static readonly int sp_UnderWaterSpecularDistribution;
    private static readonly int sp_CausticsTexture;
    private static readonly int sp_CausticsStrength;
    private static readonly int sp_CausticsMaxVisibleDepth;
    private static readonly int sp_CausticsTilingSize;
    private static readonly int sp_CausticsAnimationStrength;
    private static readonly int sp_CausticsAnimationSpeed;
    private static readonly int sp_CausticsAnimationFactor;
    private static readonly int sp_GodRayStrength;
    private static readonly int sp_GodRayColorMask;
    private static readonly int sp_DetailNormalMap;
    private static readonly int sp_DetailNormalStrength;
    private static readonly int sp_DetailNormalTilingSize;
    private static readonly int sp_DetailNormalMoveSpeed;
    private static readonly int sp_DetailNormalDirectionX;
    private static readonly int sp_DetailNormalDirectionY;
    private static readonly int sp_DetailRefractionStrength;
    private static readonly int sp_DetailRefractionSpeed;
    private static readonly int sp_DetailRefractionDensity;
    private static readonly int sp_DetailEmissiveFlashTexture;
    private static readonly int sp_DetailEmissiveFlashStrength;
    private static readonly int sp_DetailEmissiveFlashSpeed;
    private static readonly int sp_DetailEmissiveFlashDistribution;
    private static readonly int sp_DetailEmissiveTexture;
    private static readonly int sp_DetailEmissiveColorMask;
    private static readonly int sp_FoamFadeStartHeight;
    private static readonly int sp_FoamFadeEndHeight;
    private static readonly int sp_LargeFadeEndHeight_1;
    private static readonly int sp_CloseFoamFadeStartHeight;
    private static readonly int sp_CloseFoamFadeEndHeight;
    private static readonly int sp_FoamTexture;
    private static readonly int sp_FarFoamTexture;
    private static readonly int sp_FarFoamShapeTexture_CustomMipmap;
    private static readonly int sp_FarFoamSimulateSize;
    private static readonly int sp_ShallowColorDistributionReMap;
    private static readonly int sp_ReflectionTextureOcean;
    private static readonly int sp_ScreenInfo;
    private static readonly int sp_ShoreDivisionNumberY;
    private static readonly int sp_TerrainDepthTexture;
    private static readonly int sp_ShallowDepthTexture;
    private static readonly int sp_OceanAltitude;
    private static readonly int sp_ShallowColorDistribution;
    private static readonly int sp_CameraDirection;
    private static readonly int sp_ReflectionTexture;
    private static readonly int sp_OceanMaskDebugTexture;
    private static readonly int sp_MaskMode;
    private static readonly int sp_Ocean_SHAr;
    private static readonly int sp_Ocean_SHAg;
    private static readonly int sp_Ocean_SHAb;
    private static readonly int sp_Ocean_SHBr;
    private static readonly int sp_Ocean_SHBg;
    private static readonly int sp_Ocean_SHBb;
    private static readonly int sp_Ocean_SHC;
    private static readonly int sp_LargeNormalMap_2;
    private static readonly int sp_LargeNormalStrength_2;
    private static readonly int sp_LargeNormalMapTilingSize_2;
    private static readonly int sp_LargeNormalMoveSpeed_2;
    private static readonly int sp_LargeNormalDirectionX_2;
    private static readonly int sp_LargeNormalDirectionY_2;
    private static readonly int sp_Large2DivisionNumberY;
    private static readonly int sp_ScaleAlbedoTexture;
    private static readonly int sp_ScaleAlbedoStartHeight;
    private static readonly int sp_ScaleAlbedoEndHeight;
    private static readonly int sp_ScaleAlbedoStartOpacity;
    private static readonly int sp_ScaleAlbedoEndOpacity;
    private static readonly int sp_ScaleNormalTexture;
    private static readonly int sp_ScaleNormalStartHeight;
    private static readonly int sp_ScaleNormalEndHeight;
    private static readonly int sp_ScaleNormalStartOpacity;
    private static readonly int sp_ScaleNormalEndOpacity;
    private static readonly int sp_ScaleNormalScale;
    private static readonly int sp_ScalePackedTexture;
    private static readonly int sp_ScalePackedStartHeight;
    private static readonly int sp_ScalePackedEndHeight;
    private static readonly int sp_ScalePackedStartOpacity;
    private static readonly int sp_ScalePackedEndOpacity;
    private static readonly int sp_Smoothness;
    private static readonly int sp_Metalness;
    private static readonly int sp_DiffuseColor;
    private static readonly int sp_ReflectionStarHeight;
    private static readonly int sp_ReflectionEndHeight;
    private static readonly int sp_ReflectionStartStrength;
    private static readonly int sp_ReflectionEndStrength;
    private static readonly int sp_ShallowColor;
    private static readonly int sp_ShallowMaxDepth;
    private static readonly int sp_SpecularStartHeight;
    private static readonly int sp_SpecularEndHeight;
    private static readonly int sp_SpecularStartStrength;
    private static readonly int sp_SpecularEndStrength;
    private static readonly int sp_ScaleEmissionTexture;
    private static readonly int sp_ScaleEmissionStartHeight;
    private static readonly int sp_ScaleEmissionEndHeight;
    private static readonly int sp_ScaleEmissionStartOpacity;
    private static readonly int sp_ScaleEmissionEndOpacity;
    private static readonly int sp_ScaleEmissionScale;
    private static readonly int sp_LargeDiffuseTexture_2;
    private static readonly int sp_LargeEmissiveTexture_2;
    private static readonly int sp_LargeEmissiveColorMask_2;
    private static readonly int sp_LargeEmissiveBlendMode_2;
    private static readonly int sp_EnableReflection;
    private static readonly int sp_ShadowStrength;
    private const float OCEAN_COLLIDER_FO_THRESHOLD_MULTIPLIER = 4f;
    private const float OCEAN_COLLIDER_RADIUS_OFFSET = -1f;
    private const float OCEAN_COLLIDER_UPDATE_ALTITUDE = 15000f;
    private const float SIMULATE_SIZE = 1024f;
    private const float FAR_OCEAN_SIMULATE_SIZE = 4096f;
    private const float FOAM_MAX_DELTA_TIME_SCALE = 5f;
    private const float DEEP_WATER_HEIGHT = 20f;
    private const float ANIMATION_FADE_START_HEIGHT = 40f;
    private const float ANIMATION_FADE_END_HEIGHT = 80f;
    private const float CLOSE_FOAM_FADE_START_HEIGHT = 100f;
    private const float CLOSE_FOAM_FADE_END_HEIGHT = 500f;
    private const float USE_TERRAIN_TEXTURE_HEIGHT = 5000f;
    private const float TESSELLATION_FACTOR_HIGH = 6f;
    private const float TESSELLATION_FACTOR_MEDIUM = 5f;
    private const float TESSELLATION_FACTOR_LOW = 4f;
    private const float TESSELLATION_FACTOR_DEFAULT = 1f;
    private const float OCEAN_RADIUS_OFFSET = 10f;
    private const float OCEAN_RADIUS_OFFSET_HEIGHT = 200000f;
    private PQSRenderer.OceanType _oceanType;
    private Material _oceanMaterial;
    private Material _oceanSpereMaterial;
    private Material _oceanBackSurfaceMaterial;
    [Header("Ocean")]
    public OceanWaveSpectrum _oceanSpectrum;
    public Material OceanWaterMaterial;
    public Material OceanLavaMaterial;
    public bool OceanColliderIsTrigger;
    [Tooltip("Which quality is used for display in Debug Scene.")]
    public OceanQuality QualitySettingsInDebugScene;
    [Header("Ocean Quality Setting")]
    [Tooltip("Which quality needs to be configured")]
    public OceanQuality OceanQualitySetting;
    public OceanFeature OceanFeatures;
    [HideInInspector]
    public OceanFeature OceanFeaure_LowQuality;
    [HideInInspector]
    public OceanFeature OceanFeaure_MediumQuality;
    [HideInInspector]
    public OceanFeature OceanFeaure_HighQuality;
    [HideInInspector]
    public bool needSaveSDF;
    [HideInInspector]
    public float sdfDistance;
    private WaterManager _waterManager;
    private OceanFeature _oceanFeature;
    private Texture _farFoamShapeTexture;
    private int _currentLod;
    private int _computeThreadSize;
    private float _teslationFactor;
    private Matrix4x4[] _oceanQuadScaleList;
    private Bounds _meshBounds;
    private bool _oceanInitDone;
    private SphericalHarmonicsL2 _currentGIProbe;
    private RenderTexture _reflectionTexture;
    private Renderer _kscCampusRenderer;
    private Texture _shorelineSDFTexture;
    private Vector3 _lightDirection;
    private Vector3 _lightColor;
    private float _simulateSize;
    private float _simulateSizePre;
    private float _oceanRadius;
    private Vector3 _centerOfPlanet;
    private float _heightFromWater;
    private float _heightFromWaterAbs;
    private Vector4 _params;
    private float _worldSizePerPixel;
    private float _tessellationFactor;
    private float _oceanRadiusOffset;
    private DateTime _startTime;
    private float _deltaTime;
    private float _runningTime;
    private float _runningTime_variance180;
    private float _runningTime_caustics;
    private CommandBuffer _drawOceanCommand;
    private CommandBuffer _drawUnderWaterCommand;
    private Matrix4x4D _oceanRotationMatrix;
    private Matrix4x4D _planetToOceanMatrix;
    private Matrix4x4D _worldToLocalMatrix;
    private Matrix4x4D _worldToOceanMatrix;
    private Vector3d _cameraPosOnPlanet;
    private Vector2d _cameraPosOnOceanPlane;
    private Vector2d _cameraPosOnOceanPlanePre;
    private float _oceanQuadMeshScale;
    private bool _drawSphereOcean;
    private bool needFreshPlanetToOcean;
    private GameObject _fullScreenProxy;
    private MeshRenderer _fullScreenProxyRender;
    private bool _firstIn;
    private bool _shallowDepthTexInitDone;
    private bool _generateDepthMatInitDone;
    private bool _underOceanMaskMatInitDone;
    private bool _underWaterEffetMatInitDone;
    private bool _oceanBackSurfaceMatInitDone;
    private bool _oceanSphereMatInitDone;
    private bool _meetOceanCondition;
    private RenderTexture _foamTextureSource;
    private RenderTexture _foamTextureTarget;
    private RenderTexture _farFoamTextureSource;
    private RenderTexture _farFoamTextureTarget;
    private GameObject _oceanColliderObjAtRoot;
    private GameObject _oceanColliderObjAtCelestialBody;
    private CelestialBodyBehavior bodyBehavior;
    private SubscriptionHandle _handleGameStateEntered;
    private bool _forceUpdateOceanCollider;
    private VesselComponent activeSimVessel;
    private FloatingOrigin _floatingOrigin;
    private bool _debugOceanCollider;
    public PQS Pqs;
    private RenderTexture PqsPrepassRenderTarget0;
    private RenderTexture PqsPrepassRenderTarget1;
    private RenderTexture PqsPrepassRenderTarget2;
    private RenderTexture PqsPrepassRenderTarget3;
    private RenderTexture PqsPrepassRenderTarget4;
    private RenderTargetIdentifier[] PqsTargetIdentifiers;
    private CommandBuffer _prePassCommandBuffer;
    private const string DEFERRED_DECAL_BUFFER_NAME = "PQSRENDER_DEFERRED_DECAL_MASK";
    private RenderTargetIdentifier DeferredDecalIdentifier;
    private RenderTexture DeferredDecalBuffer;
    [Header("Settings")]
    public bool DrawPQS;
    public bool WatherSphere;
    public bool CreateColliders;
    public bool ForceReload;
    public int Layer;
    [Header("Debug settings")]
    public bool CalculateNormals;
    public bool UseDebugMaterial;
    public Material DebugMaterial;
    public bool SelectSubdivision;
    public int MinSubdivision;
    public int MaxSubdivision;
    public bool EnableLowQualityLocal;
    public bool CullBackSideQuads;
    public float BackSideCutoff;
    public int VisibleQuads;
    public GraphicsManager GraphicsManager;
    [Header("Collider Settings")]
    public bool RenderColliderMeshes;
    [Header("Satter Blending")]
    public bool RenderDepthTexture;
    public RenderTexture DiffuseBuffer;
    public RenderTexture DepthBuffer;
    public float BlendDistance;
    [Header("Debug info")]
    public int NewQuadCount;
    public int EdgesChangedCount;
    private int _bufferSize;
    [Header("Debug info")]
    private Mesh _universalMesh;
    private ComputeShader PQSQuadConstructorShader;
    private int CreateQuadMeshKernelHandle;
    private int CreateWaterQuadMeshKernelHandle;
    private int ClearNormalsKernelHandle;
    private int CalculateNormalsKernelHandle;
    private int NormalizeNormalsKernelHandle;
    private int SampleHeightsKernelHandle;
    private int CreateUniversalMeshKernelHandle;
    private bool _computeInitDone;
    private int _vertexCount;
    private int _indiceCount;
    private int _visualIndiceCount;
    private int _triangleCount;
    private int _compactVisualVertexCount;
    private int _quadMeshDataSize;
    private int _quadDataSize;
    private int _colliderMeshDataSize;
    private int _heightSampleRequestSize;
    private int _decalDataSize;
    private static readonly int QuadMeshDataBufferID;
    private static readonly int VisibleQuadMeshIndexBufferID;
    private static readonly int WorldCameraPositionID;
    private static readonly int TotalTriangleCountID;
    private static readonly int VisibleTriangleCountID;
    private const string SUB_ZONES_ENABLED_KEYWORD = "SUB_ZONES_ENABLED";
    private const string DECALS_ENABLED_KEYWORD = "DECALS_ENABLED";
    private const string DECALS_FROM_MASK_KEYWORD = "DECALS_FROM_MASK";
    private const string ANTI_TILE_ON_KEYWORD = "ANTI_TILE_ON";
    private const string ANTI_TILE_QUALITY_KEYWORD = "ANTI_TILE_QUALITY_ON";
    private const int PQS_DEPTH_NOW_PASS = 4;
    private const int PQS_PREPASS = 5;
    private const int PQS_DECAL_DEFERRED_DEPTH_PASS = 6;
    private const RenderTextureFormat RENDERTARGETFORMAT_PREPASS_NORMALS = RenderTextureFormat.ARGBHalf;
    private const RenderTextureFormat RENDERTARGETFORMAT_PREPASS = RenderTextureFormat.ARGB32;
    private const RenderTextureFormat RENDERTARGETFORMAT_DECALMASK = RenderTextureFormat.R8;
    private ComputeBuffer _quadMeshDataBuffer;
    private ComputeBuffer _universalQuadMeshDataBuffer;
    private ComputeBuffer _visibleQuadDataBuffer;
    private ComputeBuffer _createMeshQuadDataBuffer;
    private ComputeBuffer _updateNormalsQuadDataBuffer;
    private ComputeBuffer _indicesBuffer;
    private ComputeBuffer _visualIndicesBuffer;
    private ComputeBuffer _cachedVertsBuffer;
    private ComputeBuffer _decalInstancesBuffer;
    private ComputeBuffer _materialDecalInstancesBuffer;
    private ComputeBuffer _decalArrayBuffer;
    private ComputeBuffer _decalAlphaBuffer;
    private NativeList<QuadDataGPU> _allQuadDataList;
    private NativeList<QuadDataGPU> _createMeshQuadDataList;
    private NativeList<QuadDataGPU> _updateNormalsQuadDataList;
    private NativeList<QuadDataGPU> _visibleQuadDataList;
    private Plane[] _frustumPlanes;
    private Vector4[] _frustumPlaneNormals;
    private uint[] _initialArgs;
    private const string QUAD_MESH_TRIANGLE_CULLING = "QuadMeshTriangleCulling";
    private ComputeBuffer _culledQuadMeshIndexBuffer;
    private ComputeBuffer _drawArgsBuffer;
    private ComputeBuffer _frustumNormalPlanesBuffer;
    private int CullQuadMeshTriangleKernelHandle;
    public static int COLLIDER_POOL_SIZE;
    private int CreateColliderMeshKernelHandle;
    private ComputeBuffer _colliderQuadDataBuffer;
    private ComputeBuffer _colliderQuadMeshBuffer;
    private NativeList<QuadDataGPU> _colliderQuadDataList;
    private NativeList<int> _destroyedColliderList;
    private NativeHashMap<int, PQSColliderInfo> _activeColliderMap;
    private Queue<PQSColliderRequest> _colliderReadbackRequests;
    private bool _colliderComputeReadbackRequest;
    private int _colliderComputeReadbackCount;
    private bool _colliderDestructionRequest;
    private int _colliderDestructionCount;
    private PQSColliderPool _pqsColliderPool;
    private Transform _colliderParent;
    private bool _internalRenderColliderMeshes;
    private Material _debugRenderCollidersMat;
    private bool _colliderInitDone;
    public Camera SourceCamera;
    public float NearClip;
    public float FarClip;
    private List<int> _paddedCompactVisualIndiceList;
    private int _frameCounter;
    private MaterialPropertyBlock _localSpaceMaterialPropertyBlock;
    private MaterialPropertyBlock _scaledSpaceMaterialPropertyBlock;
    private Material _localSpaceShadowMaterial;
    private int _transitionParamID;
    private int _ditherScaleParamID;
    private float _currTransition;
    private float _currScaledTransition;
    private CelestialBodyGIProbeDataReference _localGIProbes;
    public bool _drawPlanetQueued;
    private readonly List<IPQSOverlay> _overlays;
    private CommandBuffer _overlayCommandBuffer;
    private bool _regeneratePQSTiles;
    private static readonly int DECAL_OFFSET_ID;
    private static readonly int PQS_TO_WORLD_MATRIX_ID;
    private static readonly int PQS_DEPTH_TEXTURE_ID;
    private static readonly int PQS_DEFERRED_DECAL_TEXTURE_ID;
    private DebugBiomeUIManager _debugUIBiomeManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateWaveData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitPhases() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAmplitudes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWaterAnimationData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double Repeat(double t, double length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBatchData(int firstComponent, int lastComponentNonInc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string OceanColliderName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Swap<T>(ref T a, ref T b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetRunTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPQSHeightSampleShaderValue(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateOceanRenderData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeOceanComputeResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupOceanComputeResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateShallowDepthTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGenerateOceanAnimationShader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateOceanAnimationTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateFarOceanAnimationTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateOceanNormalTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMaterialKeyword() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMaterialGIProbe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOceanMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOceanBackSurfaceMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOceanSphereMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateFarFoamShapeTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSRenderer.OceanType GetOceanType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawOcean() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateOceanDepthTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateTerrainDepthTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearFoamTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateOceanFoamTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateFarOceanFoamTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleGenerateOceanVertsJob() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleGenerateOceanSphereVertsJob() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion GetRotationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4D GetFaceNorthMatrix(Vector3d directionFromPlanetCenter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float LinearStep(float from, float to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float Remap(
      float original_value,
      float original_min,
      float original_max,
      float new_min,
      float new_max)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInertialReferenceFrameSnapEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateEntered(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateOceanColliderCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOceanCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateUnderWaterLightingTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateUnderOceanMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetUnderWaterEffectMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawUnderWaterEffect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OceanFeature GetOceanFeature() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetTerrainObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOceanUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double RayTraceSphere(Vector3d position, Vector3d direction, double radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleWaterDetectJob() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTransition(bool scaled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBuffer GetDecalInstancesBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBuffer GetDecalArrayBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBuffer GetDecalAlphaBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDecalFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDecalInstances(bool materialUpdate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateColliderResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateShaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyQualitySettingsToLocalShader(Material localSpacePlanetMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateMeshes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPQSUpdated(
      NativeList<PQJob.PQ> PQs,
      NativeList<int> destroyedQuads,
      NativeList<int> addedQuads,
      NativeList<int> changedEdges,
      NativeList<int> changedSubdiv,
      NativeList<int> changedCollapsed,
      NativeQueue<int> quadCache,
      NativeHashSet<int> uniqueQuadCache)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncSourceCam() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderPQS(
      NativeList<PQJob.PQ> PQs,
      NativeList<int> addedQuads,
      NativeList<int> changedEdges,
      NativeList<int> changedSubdiv,
      NativeList<int> changedCollapsed,
      NativeQueue<int> quadCache,
      NativeHashSet<int> uniqueQuadCache)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessColliderDestructionRequest(NativeList<int> destroyCollidersList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessColliderComputeReadback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PositionColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColliderData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableColliderRenderer(Transform tf, PQSCollider col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableColliderRenderer(Transform tf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderColliderMeshesEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderColliderMeshesDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitDebugManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateScaledMeshTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindDebugKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindDebugKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleBiomeDebugView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawPlanet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VerifyBlendCommandBuffer(Camera targetCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPqsDepthNow(Material selectedMaterial, Camera targetCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPQSDeferredDecalSurfacePass(Material selectedMaterial, Camera targetCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOverlay(IPQSOverlay overlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOverlay(IPQSOverlay overlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPQSOverlays(Camera targetCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPQSQuads(
      Material selectedMaterial,
      int renderLayer,
      Camera targetCamera,
      MaterialPropertyBlock materialPropertyBlock)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateComputeBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupComputeResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupColliderResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeComputeResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeColliderResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeDebugUIView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyRenderTargets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetScaledSpaceTransitionValues(float transitionValue, float ditheringValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLocalSpaceLightProbe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSurfaceHeightGPU(Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetHeightGPU(Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetVertexSphericalUVsGPU(Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetVertexSphericalUVs(Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderPrepass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQSRenderer() => throw null;

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    private struct UpdateBatchScratchData
    {
      public static readonly Vector4[] _wavelengthsBatch;
      public static readonly Vector4[] _twoPiOverWavelengthsBatch;
      public static readonly Vector4[] _ampsBatch;
      public static readonly Vector4[] _waveDirXBatch;
      public static readonly Vector4[] _waveDirZBatch;
      public static readonly Vector4[] _phasesBatch;
      public static readonly Vector4[] _waveDirXBatch_variance180;
      public static readonly Vector4[] _waveDirZBatch_variance180;
      public static readonly Vector4[] _phasesBatch_variance180;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static UpdateBatchScratchData() => throw null;
    }

    [BurstCompile]
    public struct GenerateOceanVertsJob : IJobParallelFor
    {
      [ReadOnly]
      public NativeArray<Vector3> OceanQuadVerts;
      [WriteOnly]
      public NativeArray<Vector3> OceanVertsWorldPosition;
      [WriteOnly]
      public NativeArray<Vector3> OceanVertsOnPlanet;
      [WriteOnly]
      public NativeArray<Vector2> OceanVertsOnOceanPlane;
      [WriteOnly]
      public NativeArray<Vector2> OceanVertsSphereUV;
      [WriteOnly]
      public NativeArray<Vector3> OceanVertsFaceNorthMatrix_X;
      [WriteOnly]
      public NativeArray<Vector3> OceanVertsFaceNorthMatrix_Y;
      [ReadOnly]
      public float OceanRadius;
      [ReadOnly]
      public float OceanQuadScale;
      [ReadOnly]
      public Matrix4x4D OceanRotationMatrix;
      [ReadOnly]
      public Matrix4x4D PlanetToOceanMatrix;
      [ReadOnly]
      public Matrix4x4D PlanetToWorldMatrix;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector2 GetVertexSphericalUVs(Vector3d pos) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int i) => throw null;
    }

    [BurstCompile]
    public struct GenerateOceanSphereVertsJob : IJobParallelFor
    {
      [ReadOnly]
      public NativeArray<Vector3> OceanSphereVerts;
      [WriteOnly]
      public NativeArray<Vector3> OceanSphereVertsWorldPosition;
      [WriteOnly]
      public NativeArray<Vector3> OceanSphereVertsOnPlanet;
      [WriteOnly]
      public NativeArray<Vector3> OceanSphereVertsFaceNorthMatrix_X;
      [WriteOnly]
      public NativeArray<Vector3> OceanSphereVertsFaceNorthMatrix_Y;
      [ReadOnly]
      public float OceanRadius;
      [ReadOnly]
      public Matrix4x4D OceanRotationMatrix;
      [ReadOnly]
      public Matrix4x4D PlanetToWorldMatrix;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int i) => throw null;
    }

    public enum OceanType
    {
      NONE,
      OCEAN_WATER,
      OCEAN_LAVA,
    }
  }
}
