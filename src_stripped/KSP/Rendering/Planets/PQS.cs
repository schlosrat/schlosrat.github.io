// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [AwesomeTechnologiesScriptOrder(3)]
  [AddComponentMenu("PQuadSphere/PQS")]
  public class PQS : MonoBehaviour
  {
    public const int BUFFER_SIZE = 12000;
    public const double SCALED_SPACE_MESH_SCALE = 1000.0;
    public static readonly int PQSToWorldMtxId;
    public static readonly int WorldToPQSMtxId;
    public static readonly int PQSPositionId;
    public PQSGlobalSettings settings;
    public PQSData data;
    private CelestialBodyBehavior _planetSimBehavior;
    private MeshRenderer _scaledRenderer;
    private Material _scaledMaterial;
    private LightData _lightData;
    private AtmosphereDataModelComponent _scaledAtmosphere;
    private GraphicsSettings _graphicsSettings;
    private const string LOW_QUALITY_KEYWORD = "LOW_QUALITY";
    private CoreCelestialBodyData _coreCelestialBodyData;
    [HideInInspector]
    public double collapseDelta;
    [HideInInspector]
    public double visRadDelta;
    [HideInInspector]
    public double visRad;
    [HideInInspector]
    public PQS parentSphere;
    public bool generatePhysics;
    public List<Transform> interestPositions;
    private bool _initialCheckFixedOperation;
    public bool UseFixedLevel;
    public int FixedLevel;
    public NativeList<DecalInstance> EmptyDecalInstanceList;
    public ScaledSpaceTextureGeneratorSettings ScaledSpaceTextureGeneratorSettings;
    [HideInInspector]
    private float angularTargetSpeed;
    public bool isAlive;
    public bool isActive;
    public bool isStarted;
    private Vector3d lastRelTgtPosNormalized;
    public double primaryTargetDistance;
    public double primaryTargetAltitude;
    private bool subdividedAtLeastOnce;
    public bool isSubdivisionEnabled;
    [HideInInspector]
    public double radiusSquared;
    [HideInInspector]
    public double circumference;
    [HideInInspector]
    public bool quadAllowBuild;
    [HideInInspector]
    public double radiusMax;
    [HideInInspector]
    public double radiusMin;
    [HideInInspector]
    public double halfChord;
    private int fixedUpdateFrame;
    public PQData PQRenderData;
    public PQSRenderer PQSRenderer;
    public float maxRaycastDistance;
    private static int raycastLayerBitMask;
    private bool _firstFrameJob;
    private bool _quadJobActive;
    private PQJob.PQSJobHolder _surfaceJob;
    private static int SGTLightPositionID;
    private static int SGTLightDirectionID;
    private static int SGTLightColorID;
    private static int cameraDistanceID;
    private static int localToWorldID;
    private static int worldToLocalID;
    private GameObject ringShadowObject;
    private static int ringShadowMatrixID;
    private static int ringShadowRatioID;
    private bool _hasCaughtMissingDataError;
    private Material _VSPInstance;
    public PQS.StatCollection graphicsStats;
    public PQS.StatCollection physicsStats;
    public PQS.StatCollection waterStats;
    private int statFrameCounter;
    public bool trackStats;
    private const float HalfPI = 1.57079625f;
    private const float ALTITUDE_TO_OFFSET_SCALE = 0.05f;

    public CelestialBodyBehavior PlanetSimBehavior
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MeshRenderer ScaledRenderer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public LightData LightData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AtmosphereDataModelComponent AtmosphereData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CoreCelestialBodyData CoreCelestialBodyData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeList<double3> AllocInterestPositions() => throw null;

    public PQSTargetProvider PrimaryTargetProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasPrimaryTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasPrimaryTargetForRendering
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d relativePrimaryTargetPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3d relativePrimaryTargetPositionNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3d relativePrimaryTargetPositionOnRadiusSphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3d relativePrimaryTargetObserverPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3d relativePrimaryTargetObserverPositionNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double primaryTargetHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double primaryTargetObserverHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double primaryTargetObserverTerrainHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PQSTargetProvider SecondaryTargetProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasSecondaryTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d relativeSecondaryTargetPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double secondaryTargetAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event PQS.OnEvent onStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event PQS.OnEvent onDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event PQS.OnEvent onUpdateFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event PQS.OnEvent SphereActivated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event PQS.OnEvent SphereDeactivated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Material VSPInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SyncVSPMat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddStats(
      PQS.StatCollection c,
      int total,
      int added,
      int destroyed,
      int cached,
      int changed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AwakeInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckGraphicsSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSettingChanged(Setting setting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeregisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCelestialBodyBehavior(CelestialBodyBehavior cbBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledSpaceRenderer(MeshRenderer renderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledSpaceMaterial(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCoreCelestialBodyData(CoreCelestialBodyData cbData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightData(LightData lightData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRunning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeactivateSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(PQSTargetProvider targetProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSecondaryTarget(PQSTargetProvider targetProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeSubdivisionVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableSubdivision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableSubdivision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateQuadsInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateQuads() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetFallbackTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupBuildDelegates(bool fakeBuild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSurfaceMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTransition(bool scaled = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledAtmosphereTransition(float transition, float ditherScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledMeshTransition(float transition, float ditherScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePosition(Vector3d worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeDirection(Vector3d worldDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetWorldPosition(Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRelativeDistance(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRelativeAltitude(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRelativeDistanceSqr(Vector3 worldDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSurfaceHeight(Vector3d radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetHeight(Vector2 uv, Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitude(Vector3d worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetVertexSphericalUVs(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetBiomeMaskAtTextureCoordinate(Vector2 texCoord) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDominantBiomeIndexFromBiomeMask(Color biomeMaskWeights) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4 GetBiomeTextureWeights(int biomeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RayIntersection(
      Vector3 worldStart,
      Vector3 worldDirection,
      out double intersectionDistance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RayIntersection(
      Vector3 worldStart,
      Vector3 worldDirection,
      out Vector3d intersection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LineSphereIntersection(
      Vector3d relPos,
      Vector3d relVel,
      double radius,
      out Vector3d relIntersection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQS() => throw null;

    public delegate void OnEvent(PQS sphere);

    public struct MicroSplatLight
    {
      public Vector3 position;
      public Vector3 direction;
      public Color color;
    }

    public struct MicroSplatShadow
    {
      public Matrix4x4 matrix;
      public float ratio;
    }

    public class Stats
    {
      public int totalQuads;
      public int newQuads;
      public int destroyedQuads;
      public int cachedQuads;
      public int changedQuads;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Stats() => throw null;
    }

    public class StatCollection
    {
      public PQS.Stats frameStats;
      public PQS.Stats averageStats;
      public PQS.Stats averageShown;
      public PQS.Stats peakStats;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StatCollection() => throw null;
    }
  }
}
