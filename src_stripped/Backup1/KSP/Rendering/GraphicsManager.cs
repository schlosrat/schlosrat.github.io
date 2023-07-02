// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.GraphicsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using KSP.Game;
using KSP.Messages;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Startup;
using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class GraphicsManager : KerbalMonoBehaviour
  {
    [Header("Systems")]
    public LightingSystem LightingSystem;
    public ShadowSystem ShadowSystem;
    public PostProcessingSystem PostProcessingSystem;
    public DecalSystem DecalSystem;
    public ContextualFxSystem ContextualFxSystem;
    public PanelBlurSystem PanelBlurSystem;
    [Header("Settings")]
    public GraphicsSettings GraphicsSettings;
    public PQSGlobalSettings PQSGlobalSettings;
    public PostProcessingSettings PostProcessingSettings;
    public RenderKitSettings RenderKitSettings;
    public BiomePhysicsMapping BiomePhysicsMappingTable;
    private CameraClipPlaneManager _camClipPlaneManager;
    public CelestialBodyProvider CelestialBodyProvider;
    private UniverseView UniverseView;
    private UniverseCameraManager CameraManager;
    private SessionManager SessionManager;
    private WaterManager WaterManager;
    public ReentryManager ReentryManager;
    private FlowCamera _mainMenuCamera;
    public Dictionary<string, LightData> flightLightingData;
    public Dictionary<string, LightData> mapLightingData;
    public Dictionary<string, CelestialBodyBehavior> celestialBodyBehaviors;
    public Dictionary<string, CelestialBodyRingGroup> flightLoadedRingGroups;
    public Dictionary<string, List<CelestialBodyRingGroup>> flightRingGroupQueue;
    public Dictionary<string, List<CelestialBodyRingGroup>> mapRingGroupQueue;
    public Dictionary<string, List<ParticleFieldRingData>> particleFieldQueue;
    [Header("Presets")]
    public PresetQualityLevel LowQualityPreset;
    public PresetQualityLevel MediumQualityPreset;
    public PresetQualityLevel HighQualityPreset;
    public PresetQualityLevel QualityQualityPreset;
    public PresetQualityLevel PerformanceQualityPreset;
    public Dictionary<string, PresetQualityLevel> qualityPresets;
    public VegetationSystemPro ActiveVegetationSystem;
    [Header("Previs Scene")]
    public PrevisGameInstance PrevisGame;
    public PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    public bool celestialBodyPrevisScene;
    private PrevisCameraManager PrevisCameraManager;
    private SubscriptionHandle _handleOABExited;
    private SubscriptionHandle _handleOABEntered;
    private SubscriptionHandle _handleMapInitialized;
    private SubscriptionHandle _handleMapShutdown;
    private SubscriptionHandle _handleObserverSOIChanged;
    private SubscriptionHandle _handleMapViewEntered;
    private SubscriptionHandle _handleMapViewExited;
    private SubscriptionHandle _handleFlightViewEntered;
    private SubscriptionHandle _handleFlightViewExited;
    private SubscriptionHandle _handleKSCReturn;
    private SubscriptionHandle _handleCelestialBodyAdded;
    private SubscriptionHandle _handleCelestialBodyRemoved;
    private SubscriptionHandle _handleMapCelestialBodyAdded;
    private SubscriptionHandle _handleMapCelestialBodyRemoved;
    private SubscriptionHandle _handleCameraChanged;
    private SubscriptionHandle _handleGameStateChanged;
    private SubscriptionHandle _handleTutorialLoaded;
    private SubscriptionHandle _handleTutorialRestarted;
    private SubscriptionHandle _handleTutorialEnded;
    private SubscriptionHandle _handleCameraPqsChanged;
    private SubscriptionHandle _handleCelestialBodyContextMenuOpened;
    private SubscriptionHandle _handleTimeZoomChangeCompleted;
    private SubscriptionHandle _handleViewControllerFlowFinished;
    private Camera _currentUnityCamera;
    private double _currentStarVisibility;
    private Position _observerPos;
    private string _observedBody;
    private CameraEffectsSystem _cameraEffectsSystem;
    private List<Renderer> _scaledSpaceOpaqueRenderers;
    private List<Renderer> _scaledSpaceTransparentRenderers;
    private bool graphicsInitialized;
    private string _celestialBodyName;

    public CameraClipPlaneManager LocalCameraClipPlaneManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public FlowCamera MainMenuCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Initialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitPrevis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitStartingBodyLighting(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitDependencies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitChildren() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterDependencyEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyQualityPreset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PresetQualityLevel GetQualityPreset(string presetName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewControllerFlowFinished(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABUnloaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewEntered(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewExited(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKSCReturn(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnObserverSOIChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeZoomChangeCompleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnablePQSForAllCelestialBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisablePQSForAllCelestialBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDrawEnabledForAllCelestialBodies(bool isDrawEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodyLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodyRemoved(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapInitialized(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapShutdown(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapViewEntered(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapViewExited(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapCelestialBodyAdded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapCelestialBodyRemoved(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraPQSChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodyContextMenuOpened(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCelestialBodyContextMenuName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialRestarted(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialEnded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPrevisSceneEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetObservedPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObserverPosition(Position pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetObservedBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObservedBody(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyBehavior GetSOIBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyCore GetSOIBodyCoreData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQS GetSOIBodyPQS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetCurrentScaledUnityCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetCurrentUnityCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentUnityCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraEffectsSystem GetPhysicsFlightCameraEffectsSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPhysicsFlightCameraEffectsSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphericalHarmonicsL2 GetCelestialBodyGIProbeSHTerm(string celestialBodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeAtPositionAndBody(Position pos, string body = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CursorLockMode GetDesiredCursorLockMode(FullScreenMode fullscreenMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateCursorLockState(FullScreenMode fullscreenMode, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetResolution(int width, int height, bool isFullscreen) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, double> GetVisibleBodies(
      Position pos,
      bool includeObserved = true,
      bool includeStar = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAntiAliasingLevel(int level) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentStarVisibility(double visibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCurrentStarVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetCurrentStarVisibility(string starName, Dictionary<string, double> visibleBodies) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light GetCurrentStarLocalLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light GetCurrentStarScaledLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetCurrentStarDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateSourceStarDotProductForObserver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateSourceStarDotProductForPosition(Position pos, string observedBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateSourceStarDotProduct(Position pos, string observedBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateSourceStarTimeOfDayForObserver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateSourceStarTimeOfDayForPosition(Position pos, string observedBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateSourceStarTimeOfDay(Position pos, string observedBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateAltitudeWeight(
      float a,
      float b,
      double innerAltitude,
      double outerAltitude,
      double altitude)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double InvLerpDouble(double a, double b, double v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddFlightLightData(
      string name,
      bool isStar,
      CelestialBodyLightingData lightingData,
      CelestialBodyLensFlare lensFlareData,
      AtmosphereDataModelComponent atmosphereData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFlightLightDataPrevis(
      string bodyName,
      bool isStar,
      GameObject instance,
      CelestialBodyLightingData lightingData,
      CelestialBodyLensFlare lensFlareData,
      AtmosphereDataModelComponent atmosphereData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFlightLightData(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddMapLightingData(
      string name,
      MeshRenderer meshRenderer,
      CelestialBodyLightingData lightingData,
      CelestialBodyLensFlare lensFlareData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveMapLightData(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveAllCelestialBodyMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Renderer> GetScaledSpaceOpaqueRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Renderer> GetScaledSpaceTransparentRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreRenderObserverCubemap(
      float value,
      ref Dictionary<string, float> prevTransitionValues)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PostRenderObserverCubemap(ref Dictionary<string, float> prevTransitionValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PostRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaledCloudDataModelComponent GetScaledCloudDataModel(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateShadowConfigs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsManager() => throw null;
  }
}
