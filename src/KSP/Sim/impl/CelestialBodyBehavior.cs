// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CelestialBodyBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using KSP.Rendering;
using KSP.Rendering.Planets;
using KSP.Sim.ViewAdapters;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class CelestialBodyBehavior : ViewObjectComponent<CelestialBodyComponent>, ISurfaceProvider
  {
    private const int DEFAULT_RAYCAST_COUNT = 8;
    private ScaledPlanetaryBodyView _scaledObject;
    private CelestialBodyLightingData _lightingData;
    private CelestialBodyLensFlare _lensFlareData;
    private PostProcessData _postProcessData;
    private CelestialBodyRingGroup _ringGroup;
    private AtmosphereDataModelComponent _atmosphereDataModel;
    private ScaledCloudDataModelComponent _scaledCloudDataModel;
    private PQS _pqsController;
    private IViewToUnityAdapter<VegetationSystemPro> _surfaceScatterAdapter;
    private Dictionary<string, PQSSurfaceObject> _surfaceObjects;
    private CelestialBodyProxy _surfaceProxy;
    private readonly RaycastHit[] _altitudeRaycastHits;
    private int _lastRaycastHitCount;
    private int _pendingPrefabSpawners;
    private bool _isLocalSpaceLoaded;
    private bool _isScaledSpaceLoaded;
    private float _scaledSpaceLoadStartTimeSeconds;
    private float _localSpaceLoadStartTimeSeconds;
    private CoreCelestialBodyData _coreCelestialBodyData;
    private static int TERRAIN_ALTITUDE_LAYER_MASK;
    private static int SCENERY_LAYER_MASK;
    private static int TERRAIN_COLLIDER_LAYER_MASK;
    private VegetationSystemPro _scatterSystem;

    public CoreCelestialBodyData CelestialBodyData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyProxy SurfaceProxy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaledPlanetaryBodyView ScaledObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyRingGroup RingGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public System.Type ModelType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PQS PqsController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VegetationSystemPro VegetationSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    public bool IsLocalSpaceLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsScaledSpaceLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(CelestialBodyComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFloatingOriginSnapEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool BeginSpawnLocalSpaceView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator CoroutineSpawnLocalSpaceView(bool waitForSurfaceObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyLocalSpaceView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginSpawnScaledSpaceView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator CoroutineSpawnScaledSpaceView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyScaledSpaceView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SpawnSurfaceProxy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroySurfaceProxy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSSurfaceObject GetSurfaceObject(string key) => throw null;

    public bool IsSpawningSurfaceObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelTerrainPosition(double latitude, double longitude, double surfaceOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfaceNVector(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetSurfaceNVector(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLatLonAltFromRadius(
      Vector3d physicsSpacePosition,
      out double lat,
      out double lon,
      out double radiusAlt)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTerrainAltitudeFromCenter(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeFromRadius(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAltitudeFromTerrain(
      Position position,
      out double altitudeFromTerrain,
      out double terrainToSceneryOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerrainPhysicsAtCachedPosition(PQSData.KSP2BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetSurfaceObjectPosition(
      string surfaceObjectName,
      out Position position,
      out Rotation rotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrySetPQSCelestialBodyBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrySetPQSCoreCelestialBodyData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrySetPQSLightData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScaledSpaceViewInstantiated(GameObject instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalSpaceViewInstantiated(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNestedPrefabSpawnerFinished(NestedPrefabSpawner spawner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseCelestialBodyAsset(GameObject prefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialBodyBehavior() => throw null;
  }
}
