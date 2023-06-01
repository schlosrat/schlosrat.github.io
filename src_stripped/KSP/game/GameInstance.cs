// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Game.Data;
using KSP.Assets;
using KSP.Audio;
using KSP.Contexts.Game;
using KSP.DebugTools;
using KSP.Game.Colonies;
using KSP.Game.Missions;
using KSP.Input;
using KSP.Inspector;
using KSP.IO;
using KSP.Messages;
using KSP.Modding;
using KSP.Networking.MP;
using KSP.Networking.OnlineServices;
using KSP.OAB;
using KSP.Platform;
using KSP.Plugins;
using KSP.Rendering;
using KSP.Research;
using KSP.ScriptInterop;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using KSP.UI;
using KSP.UI.Flight;
using KSP.Utilities.Scripting;
using KSP.VFX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class GameInstance : MonoBehaviour, IExceptionEventHandler, IUpdateDriver, ILateUpdateDriver
  {
    public const string EMPTY_SESSION_GUID_STRING = "";
    private string _sessionGuidString;
    private LocalPlayer _localPlayer;
    private CampaignPlayerManager _campaignPlayerManager;
    private AgencyManager _agencyManager;
    [ReadOnly]
    [SerializeField]
    private AssetProvider _assets;
    [ReadOnly]
    private SaveLoadManager _saveLoadManager;
    private SettingsMenuManager _settingsMenuManager;
    [ReadOnly]
    private SessionManager _sessionManager;
    [ReadOnly]
    private PersistentProfileManager _profileManager;
    [ReadOnly]
    private ResearchManager _researchManager;
    [ReadOnly]
    private PropertyWatcherDataBroker _propertyWatcherDataBroker;
    private IScriptInterop _scriptInterop;
    private DifficultyOptionsDataManager _difficultyOptionsDataManager;
    public bool DebugMessagesEnabled;
    [SerializeField]
    private GameObject _assetPrefab;
    [SerializeField]
    private GameObject _mouseManagerPrefab;
    private bool _isInitialized;
    [SerializeField]
    [ReadOnly]
    [Header("UI Manager")]
    private UIManager _ui;
    [SerializeField]
    private GameObject _uiManagerPrefab;
    [Header("Audio Initializer")]
    [ReadOnly]
    [SerializeField]
    private KSPAudioInitializer _kspAudioInitializer;
    [Tooltip("Provide a reference to a prefab to determine the type of KSPAudioInitializer that will be created.")]
    [SerializeField]
    private KSPAudioInitializer _kspAudioInitializerPrefab;
    [SerializeField]
    private List<GameModeSO> gameModes;
    private IScriptRunner _scriptRunner;
    private DynamicConfigurationDatabase _dynamicConfigurationDatabase;
    private DynamicScriptConfigurationDatabase _dynamicScriptConfigurationDatabase;
    private bool _shutdownInProgress;
    private int _fixedUpdateCount;
    private int _updateCount;
    private int _lateUpdateCount;
    private const int DEFAULT_UPDATE_PRIORITY = -1;
    public const int DEFAULT_UNIVERSE_MODEL_PRIORITY = 0;
    public const int DEFAULT_PHYSICS_SPACE_PROVIDER_PRIORITY = 1;
    public const int DEFAULT_FLOATING_ORIGIN_PRIORITY = 2;
    public const int DEFAULT_RIGIDBODY_BEHAVIOR_VESSEL_PRIORITY = 3;
    public const int DEFAULT_RIGIDBODY_BEHAVIOR_PART_PRIORITY = 4;
    public const int DEFAULT_KERBAL_BEHAVIOR_PRIORITY = 5;
    public const int DEFAULT_SPACE_SIMULATION_PRIORITY = 6;
    public const int DEFAULT_CELESTIAL_BODY_BEHAVIOR_PRIORITY = 10;
    public const int DEFAULT_CELESTIAL_BODY_DATA_PROVIDER_PRIORITY = 25;
    public const int DEFAULT_PART_BEHAVIOR_PRIORITY = 40;
    public const int DEFAULT_MODULE_PRIORITY = 50;
    public const int DEFAULT_VIEWCONTROLLER_PRIORITY = 50;
    public const int DEFAULT_VESSEL_BEHAVIOR_PRIORITY = 150;
    public const int DEFAULT_UNIVERSE_VIEW_PRIORITY = 500;
    public const int DEFAULT_TIME_WARP_PRIORITY = 1000;
    private bool _isFixedUpdateListDirty;
    private readonly List<IFixedUpdate> _pendingFixedUpdateAdds;
    private readonly List<IFixedUpdate> _fixedUpdateList;
    private readonly GameInstance.FixedUpdateComparer _fixedUpdateComparer;
    private const int DEFAULT_LATEUPDATE_PRIORITY = -1;
    public const int LATEUPDATE_WATER_INIT_PRIORITY = 0;
    public const int LATEUPDATE_OCEAN_UPDATE_PRIORITY = 1;
    public const int LATEUPDATE_CLEAR_WATER_DEPTH_PRIORITY = 2;
    public const int LATEUPDATE_DRAW_LANDBASED_WATER_PRIORITY = 3;
    public const int LATEUPDATE_DRAW_OCEAN_PRIORITY = 2001;
    private bool _isLateUpdateListDirty;
    private readonly List<ILateUpdate> _pendingLateUpdateAdds;
    private readonly List<ILateUpdate> _lateUpdateList;
    private readonly GameInstance.LateUpdateComparer _lateUpdateComparer;
    private bool _isUpdateListDirty;
    private readonly List<IUpdate> _pendingUpdateAdds;
    private readonly List<IUpdate> _updateList;
    private readonly GameInstance.UpdateComparer _updateComparer;

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string SessionGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSessionGuidString(string sessionGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearSessionGuidString() => throw null;

    public LocalPlayer LocalPlayer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CampaignPlayerManager CampaignPlayerManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AgencyManager AgencyManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AssetProvider Assets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MessageCenter Messages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GameStateMachine GlobalGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameInput Input
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public InputManager InputManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MouseManager MouseManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PlatformManager PlatformManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartProvider Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MapProvider Map
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OABProvider OAB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CelestialBodyProvider CelestialBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartsManagerCore PartsManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ActionGroupManager ActionGroupManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TripPlanner TripPlanner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public FlightReportUIManager FlightReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public FlagSiteUIManager FlagSite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResourceManagerUI ResourceManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TripPlannerSystem TripPlannerSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KerbalManager KerbalManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GraphicsManager GraphicsManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public NotificationManager Notifications
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public LogitechLightingManager LogitechLightingManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SaveLoadDialog SaveLoadDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public LaunchpadDialog LaunchpadDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TrainingCenterMenuController TrainingCenterDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ModManagerDialog ModManagerDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ColonyManagerDialog ColonyManagerDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MissionControlAction MissionControlDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MissionTrackerTooltip MissionTrackerTooltip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResearchDevelopmentTechTreeController ResearchDevelopmentTechTree
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResearchDevelopmentController ResearchDevelopment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AeroGUI AeroGUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public VFXTestSuiteDialog VFXTestSuiteDialog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public FXDebugTools FXDebugTools
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PhysicsForceDisplaySystem PhysicsForceDisplaySystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SaveLoadManager SaveLoadManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SettingsMenuManager SettingsMenuManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SessionManager SessionManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PersistentProfileManager ProfileManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResearchManager ResearchManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyWatcherDataBroker PropertyWatcherDataBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IOProvider IO
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ResourceDefinitionDatabase ResourceDefinitionDatabase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ProceduralPartDatabase ProceduralPartDefinitionDatabase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DynamicConfigurationDatabase DynamicConfigurationDatabase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DynamicScriptConfigurationDatabase DynamicScriptConfigurationDatabase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Units Units
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PhysicsSettings PhysicsSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ConsoleControlManager ConsoleContro
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SpaceSimulation SpaceSimulation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniverseCameraManager CameraManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniverseModel UniverseModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniverseView UniverseView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ViewController ViewController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IScriptEnvironment ScriptEnvironment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CheatSystem CheatSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public KSP2ModManager KSP2ModManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KSP2MissionManager KSP2MissionManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public StateReversionTracker stateRevTracker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ScriptRegistrationManager scriptRegistrar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MPFramework MP
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MPMonoBehaviour MPMonoBehaviour
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OnlineServicesFramework OnlineServices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public KSP.PlanetViewer.PlanetViewer PlanetViewer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DifficultyOptionsDataManager DifficultyOptionsDataManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PhysicsSettingsManager PhysicsSettingsManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<GameModeSO> GameModes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DebugVisualizer DebugVisualizer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FindGameModeByIndex(int index, out GameModeData gameModeDataOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FindGameModeByName(string name, out GameModeData gameModeDataOut, out int indexOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FindGameModeByCampaignMode(
      CampaignMode campaignMode,
      out GameModeData gameModeDataOut)
    {
      throw null;
    }

    public UIManager UI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSPAudioInitializer Audio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ShutdownInProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int FixedUpdateCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int UpdateCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int LateUpdateCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool InitializeDependencies(out string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void KeepAliveNetworkPump() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreatePlanetViewer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetUniverse(Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineResetUniverse(Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown(Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineShutdown(Action finishedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleException(Exception e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkExecutionPriorityDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSimulationRunning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterFixedUpdate(IFixedUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterFixedUpdate(IFixedUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterLateUpdate(ILateUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterLateUpdate(ILateUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterUpdate(IUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterUpdate(IUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetDataLinkEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetDataLinkEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTogglePartsManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowSaveLoadDialog(bool isLoading) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideSaveLoadDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowLaunchpadDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideLaunchpadDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideTrainingCenterDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowModManagerDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideModManagerDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowColonyManagerDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideColonyManagerDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowMissionControlCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToResearchAndDevelopment() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowResearchAndDevelopment() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BroadcastCheatValueChanged(
      CheatSystemItemID cheatSystemItemID,
      bool oldValue,
      bool newValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameInstance() => throw null;

    private class FixedUpdateComparer : GameInstance.NullComparer<IFixedUpdate>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override int CompareTo(IFixedUpdate x, IFixedUpdate y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FixedUpdateComparer() => throw null;
    }

    private class LateUpdateComparer : GameInstance.NullComparer<ILateUpdate>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override int CompareTo(ILateUpdate x, ILateUpdate y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LateUpdateComparer() => throw null;
    }

    private class UpdateComparer : GameInstance.NullComparer<IUpdate>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override int CompareTo(IUpdate x, IUpdate y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public UpdateComparer() => throw null;
    }

    private class NullComparer<T> : IComparer<T>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(T x, T y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected virtual int CompareTo(T x, T y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NullComparer() => throw null;
    }
  }
}
