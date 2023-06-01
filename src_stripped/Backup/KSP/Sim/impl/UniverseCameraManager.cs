// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UniverseCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Map;
using KSP.Messages;
using KSP.OAB;
using KSP.Rendering;
using KSP.Rendering.impl;
using KSP.Rendering.Planets;
using KSP.Sim.State;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Sim.impl
{
  public class UniverseCameraManager : KerbalCameraBehaviour, ILateUpdate, ICameraGimbalStateProvider
  {
    private IViewController viewController;
    [HideInInspector]
    public PQS CurrentPQS;
    private Property<CameraID> primaryScreenCameraIDProperty;
    public CameraID LastPrimaryScreenCameraID;
    private CameraInputState cameraInputState;
    private KSP.Sim.CameraMode _currentFlightCameraMode;
    private FlightCameraContext _currentFlightCameraContext;
    public bool CameraFineMovementEnabled;
    public Vector2 CameraPanValue;
    private Dictionary<CameraID, UniverseCameraManager.CameraRenderData> CameraRenderMap;
    private bool _inputEnabled;
    private CameraMouseLook _cameraMouseLook;
    private IDisposable asyncLoadCameraManagerHandle;
    private TransformModel _kscCameraOriginTransformModel;
    public GimbalState gimbalStateForKSCCameraOrigin;
    private bool _flightViewDormant;
    private VesselComponent _activeVessel;
    private VABFlightCamera _vabFlightCam;
    public GimbalState targetGimbalState;
    private FlightCameraRenderStack_Scaled _scaledCameraStack;
    private FlightCameraRenderStack_Physics _physicsCameraStack;
    private SubscriptionHandle _handleFloatingOriginSnapped;
    private SubscriptionHandle _handleFlightViewEntered;
    private SubscriptionHandle _handleFlightViewLeft;
    private MapCamera _mapCamera;
    private ObjectAssemblyCameraManager _oabCameraManager;
    private PostProcessLayer.Antialiasing _antiAliasingMode;
    private bool _antiAliasingFastMode;
    private readonly KSP.Sim.CameraMode[] _allCameraModes;
    private readonly KSP.Sim.CameraMode[] _surfaceEVACameraModes;
    private const string GROUND_TWEAKABLES_KEY = "GroundCameraTweakables.prefab";
    private const string ORBITAL_TWEAKABLES_KEY = "OrbitalCameraTweakables.prefab";
    private const string EVA_GROUND_TWEAKABLES_KEY = "EVAGroundCameraTweakables.prefab";
    private const string EVA_ORBITAL_TWEAKABLES_KEY = "EVAOrbitalCameraTweakables.prefab";
    private const string KSC_TWEAKABLES_KEY = "KSCCameraTweakables.prefab";
    private List<CameraTweakables> _cameraTweakables;

    private IInputLockManager InputLockManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraID PrimaryScreenCameraID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<CameraID> PrimaryScreenCameraChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMainPhysicsCameraUnityTransform(out Transform cameraTransform) => throw null;

    public ICameraRig FlightCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraShot FlightCameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraShot PrimaryScreenCameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool InputEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniverseCameraManager.CameraRenderData CurrentCameraRenderData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetGimbalState(out GimbalState cameraGimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPrimaryScreenCamera(CameraID camera, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RevertToPreviousPrimaryScreenCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraRig GetCamera(CameraID cameraID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraShot GetCameraShotIncludeOverride(CameraID camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraShot GetCameraShot(CameraID cameraID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraTweakables GetCameraTweakables(FlightCameraContext cameraContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraShotInGimbal GetCameraShotWithGimbalData(CameraID cameraID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraRenderStack GetCameraRenderStack(CameraID cameraID, RenderSpaceType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadCameraTweakablesPrefab(string key, Action<CameraTweakables> onLoadedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGroundCameraTweakablesInstantiated(CameraTweakables defaultCameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOrbitalCameraTweakablesInstantiated(CameraTweakables orbitalCameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdatePrimaryCameraViewTransforms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFloatingOriginSnapped(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewLeft(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraTweakables(CameraID cameraID, FlightCameraContext cameraContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraRigSolutionForAutoMode(
      CameraID cameraID,
      FlightCameraContext cameraContext)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraMode(CameraID camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FocusFlightCamOnKSCGameLandingObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FocusFlightCameraOnOAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetSurfaceObjectTransformModel(
      string bodyID,
      string objectID,
      out ITransformModel transformModel,
      out SimulationObjectModel simulationObjectModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ITransformModel CreateSurfaceObjectTransformModel(
      string transformName,
      SimulationObjectModel model,
      FramePositionState framePosState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectPrevFlightCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectNextFlightCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSP.Sim.CameraMode[] GetCameraModesToUse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectFlightCameraMode(KSP.Sim.CameraMode cameraMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP.Sim.CameraMode GetFlightCameraMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectFlightCameraModeAndTweakables(
      KSP.Sim.CameraMode cameraMode,
      FlightCameraContext cameraContext,
      bool shouldInterpolate = true,
      bool sendPassiveNotification = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInLongExposureMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateCamera(CameraID camera, double universeDeltaTime, CameraInputState inputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ICameraRig CreateFlightCamera(CameraTweakables defaultCameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IDynamicFrameRotationProvider GetFrameRotationProvider(
      CameraUpRelative upRelative,
      IUniverseObserver flightObserver)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraShotOverride(CameraID camera, ICameraShotProvider provider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCameraShotOverride(CameraID camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOABCamera(ObjectAssemblyCameraManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAntiAliasingLevels(int level = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrySetMapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetSerializedActiveCameraInfo(
      out SerializedActiveCameraInfo serializedActiveCameraInfoOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPan(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseCameraManager() => throw null;

    public struct CameraRenderData
    {
      public ICameraRig CameraRig
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public ICameraRenderView RenderView
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public ICameraShotProvider ShotOverride
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ICameraShot GetShotExcludeOverride() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ICameraShot GetShotIncludeOverride() => throw null;
    }
  }
}
