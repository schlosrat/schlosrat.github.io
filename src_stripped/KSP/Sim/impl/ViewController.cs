// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ViewController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.ScriptInterop;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ViewController : IViewController, IUpdate, IPriorityOverride
  {
    private const double QUICK_SWITCH_RADIUS_METERS_SQUARED = 4000000.0;
    private const float DEFAULT_QUICK_SWITCH_INTERVAL_SECONDS = 1f;
    private float _quickSwitchAuditTimer;
    private const string FLAG_SITE_FLOW_ACTION_NAME = "Flag Site";
    private const string FLAG_SITE_PREFAB_KEY = "FlagSite.prefab";
    private SpaceSimulation _spaceSimulation;
    private UniverseModel _universe;
    private IModelViewMap _modelViewMap;
    private ISimulationModelMap _simulationModelMap;
    private UniverseView _universeView;
    private TimeWarp _timeWarp;
    private VesselVehicle _activeVesselVehicle;
    private bool _canObserverLeaveActiveVessel;
    private bool _isCanObserverLeaveActiveVesselCheckDirty;
    private bool _isPendingVehicleChange;
    private VesselComponent _pendingActiveVessel;
    private GameObject _galaxyCubeRenderer;
    private List<VesselComponent> _vesselsInRange;
    private LinkedList<SimulationObjectModel> _quickSwitchNodeList;
    private SubscriptionHandle _oabEnteredHandle;
    private SubscriptionHandle _oabExitedHandle;
    private SubscriptionHandle _vesselDestroyedHandle;
    private static readonly Quaternion rotationOffset;

    public IReadOnlyList<VesselComponent> VesselsInRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyViewHandle propertyViewHandle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ViewDataProvider DataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameState GameStateBeforeEscMenu
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IKeyboardInputDriver keyboardInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FlightInputHandler flightInputHandler
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public EVAInputHandler evaInputHandler
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public InteractSystem interactSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ClimbSystem climbSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IInputLockManager inputLockManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IUniverseObserver FlightObserver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniverseModel Universe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TimeWarp TimeWarp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsNormalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsPaused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<bool> IsPausedChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPause(bool newPauseState) => throw null;

    public double universalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action OnViewControllerLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnViewControllerUnloaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool ready
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CanSwitchActiveVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool patchedConicsAttached
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsPendingVehicleChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool TryGetActiveVehicle(out IVehicle activeVehicle, bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool TryGetActiveSimVessel(out VesselComponent activeSimVessel, bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool IsActiveVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IVehicle GetActiveVehicle(bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public VesselComponent GetActiveSimVessel(bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HaveActiveVehicle(bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActiveVehicle(IGGuid vesselGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActiveVehicle(IGGuid vesselGuid, bool observeVehicle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActiveVehicle(VesselComponent simVesselComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActiveVehicle(
      VesselComponent simVesselComponent,
      bool observeVehicle,
      bool forceVesselActive)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent GetPendingActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool QuickSwitchToNextVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool QuickSwitchToPreviousVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanObserverLeaveTheActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ObserveKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateQuickSwitchList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LinkedListNode<SimulationObjectModel> GetActiveNode(bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsInQuickSwitchRange(
      SimulationObjectModel simObject1,
      SimulationObjectModel simObject2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetVesselFromQuickSwitchList(int deltaIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalSpaceDependenciesLoaded(string celestialBodyLoaded, bool isSuccess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNearbyViewObjectDependenciesLoaded(bool isSuccess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformSetActiveVessel(
      VesselComponent newActiveVesselComponent,
      bool observeVessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnKSCDependenciesLoaded(string bodyName, bool success) => throw null;

    public CutsceneTools cutsceneTools
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveInternalSpace(PartComponent visiblePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ViewController(
      IKeyboardInputDriver keyboardInput,
      IInputLockManager inputLockManager,
      SpaceSimulation spaceSimulation,
      IModelViewMap modelViewMap,
      UniverseModel universeModel,
      IScriptEnvironment universeScriptEnvironment)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncToView(UniverseView view, Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadViewController(Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnloadViewController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterReturnHomeScreenEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveReturnHomeScreenEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSceneChange(GameScenes scene) => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOabLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOabUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetBodyByName(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyBehavior GetBehaviorIfLoaded(CelestialBodyComponent celestialBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselBehavior GetBehaviorIfLoaded(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalBehavior GetBehaviorIfLoaded(KerbalComponent kerbal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberBehavior GetBehaviorIfLoaded(CrewMemberComponent crew) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalBehavior GetBehaviorIfLoaded(ThermalComponent thermalComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartBehavior GetBehaviorIfLoaded(PartComponent partComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISimulationObjectView GetSimulationViewIfLoaded(SimulationObjectModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CreatePlayerColony(
      string optionalGuid,
      LegacySerializedColony colony,
      SerializedLocation location,
      Action<IVehicle> creationCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static bool IsVehicleValid(IVehicle vehicle, bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ViewController() => throw null;
  }
}
