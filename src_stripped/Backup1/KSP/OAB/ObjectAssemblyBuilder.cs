// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.IO;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilder : KerbalMonoBehaviour, IUpdate, ILateUpdate
  {
    [Header("Behavioral Values")]
    [SerializeField]
    private ObjectAssemblyBehaviorValues behaviorValues;
    [Header("Flaw List Setup")]
    [SerializeField]
    private EngineeringReportFlawListSetup flawListSetup;
    [Header("Icons and Visuals")]
    public ObjectAssemblyAssets BuilderAssets;
    private ObjectAssemblyBuilderHUD _OABHUD;
    [Header("Camera Settings")]
    [SerializeField]
    [Tooltip("The camera prefab to instantiate. Use CameraManager to get the current camera at runtime.")]
    private ObjectAssemblyCameraManager assemblyCameraPrefab;
    private GameObject blueprintSmallObject;
    private GameObject blueprintLargeObject;
    private bool cameraResetInitial;
    [HideInInspector]
    public List<IObjectAssemblyRelationship> _relationships;
    private bool galaxyCubeCameraActive;
    private bool lastGalaxyCubeCameraActiveState;
    private PostProcessLayer oabCameraPostLayer;
    private Action _onLaunchCallback;
    private OABHistoricalSnapshot _startingSnapshot;
    private OABConfig _config;
    private IReadOnlyCollection<PartCore> _allPossibleParts;
    private bool _isShuttingDown;
    private static bool renderDebugSizeLimits;
    private string workspaceDescriptionDefaultValue;
    public OABOrientation CurrentOrientation;
    private DataContext _dataContext;
    private Property<OABVariant> _variant;
    private Property<OABEnvironmentType> _environment;
    private Property<OABConstructionType> _construction;
    public ObjectAssemblyBuilderEvents eventsBuilder;
    public ObjectAssemblyUIEvents eventsUI;
    private ObjectAssemblyBuilder.ObjectAssemblyBuilderEventsManager eventsManager;
    protected ObjectAssemblyBuilderFileIO utilFileIO;
    protected ObjectAssemblyInputHandler utilInput;
    protected ObjectAssemblyShoppingCart utilShoppingCart;
    protected ObjectAssemblyBuilderLog utilLog;
    protected OABSessionInformation watcherStats;
    protected ObjectAssemblyChecklist watcherChecklist;
    protected ObjectAssemblyPartTracker _activePartTracker;
    protected ObjectyAssemblyBuilderHistorian _activeHistorian;
    protected ObjectAssemblyBuilderResourceCosting _resourceCosting;
    protected IConstructionResourceProvider _resourceProvider;
    protected IObjectAssemblyTool currentTool;
    protected IObjectAssemblyTool previousTool;
    protected bool currentToolIsOneTimeUse;
    public ProceduralPartsManager ProceduralPartsManager;
    public ProceduralFairingManager ProceduralFairingManager;

    public ObjectAssemblyBuilderHUD OABHUD
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsSavingBackupWorkspace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string WorkspaceDefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string WorkspaceVehicleDefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string WorkspaceDescriptionDefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectAssemblyInputHandler InputHandler
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABSessionInformation Stats
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectBuilderChecklist Checklist
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyEnvironment CurrentEnvironment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OABEnvironmentType EnvironmentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string CelestialBodyDependencyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABConstructionType ConstructionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABVariant ActiveBuilderVariant
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABConfig ActiveConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyBuilderSizeLimits CurrentSizeLimits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool ResultAssemblyOutOfBounds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool ResultHasEnoughResourcesForLaunchAssembly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ObjectAssemblyCameraManager CameraManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DataContext DataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsShuttingDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyTool CurrentTool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectAssemblyPartTracker ActivePartTracker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectyAssemblyBuilderHistorian Historian
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectAssemblyBuilderFileIO UtilFileIO
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectAssemblyUIEvents EventsUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleRenderDebugSizeLimits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(
      OABConfig config,
      IReadOnlyCollection<PartCore> allPossibleParts,
      OABHistoricalSnapshot startSnapshot = null,
      Action onLaunchCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABConfigChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CreateObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CreateClasses() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeClasses() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResolveConstructionState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator BuildAssembly(Action onComplete = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator EndOfInitializationFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ToggleCameraTargetLock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentTool(IObjectAssemblyTool toolToUse, bool oneTimeUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RevertTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerializedAssembly CollectSerializedAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBlueprintAlpha(GameObject blueprintObject, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowStructureObjects(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CopyAssemblyToClipboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PasteAssemblyFromClipboard() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABToolType GetCurrentToolType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AsyncLoadAllParts(Action callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AsyncLoadAllPartsInternal(Action callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssemblyOutOfBounds(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasEnoughResourcesForLaunchAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasEnoughResourcesToLoadAssembly(SerializedAssembly serializedAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAvailableResourceAmount(ResourceDefinitionID resourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryDeductResourceCostAtLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyAvailablePart GetValidAvailablePart(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProceduralPartMeshBaked(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSavingBackupVessel(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<PartCategories, List<IObjectAssemblyAvailablePart>> GetPartLookupDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator CreateBasicShip(Action onComplete = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator LoadFromFile(
      TextAsset toLoad,
      OABOrientation orientation = OABOrientation.VAB,
      BuilderSymmetryMode symmetryMode = BuilderSymmetryMode.X1,
      string launch = null,
      Action onComplete = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StackAttachSpecificParts(
      IObjectAssemblyPart top,
      IObjectAssemblyPart bottom,
      bool topIsParent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SurfaceAttachSpecificParts(
      IObjectAssemblyPart parentPart,
      IObjectAssemblyPart surfacePart,
      Vector3 localOffset,
      Vector3 rotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPart CreateSpecifiedPart(
      IReadOnlyDictionary<string, IObjectAssemblyAvailablePart> partLookupByName,
      string partName,
      Vector3? partPosition = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyAvailablePart SelectPartRandomly(
      PartCategories category,
      IReadOnlyDictionary<PartCategories, List<IObjectAssemblyAvailablePart>> partLookup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ObjectAssemblyBuilder.RuntimeQAPartData> CollectAllLoadedParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LaunchShip(Action onLaunch = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssemblyBuilder() => throw null;

    public class ObjectAssemblyBuilderEventsManager
    {
      private ObjectAssemblyBuilder builder;
      private bool _isAttemptingLaunch;
      private static readonly HashSet<string> HACK_AudioListenerNameBlacklist;
      private Dictionary<AudioListener, bool> HACK_AudioListenerEnabledCache;
      private static readonly HashSet<string> HACK_CameraNameBlacklist;
      private Dictionary<Camera, bool> HACK_CachedCameraEnabledCache;

      public GameInstance Game
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ObjectAssemblyBuilderEventsManager(ObjectAssemblyBuilder builder) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetPropertyCallbacks() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SymmetryMode_OnChanged() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void ManipulationMode_OnChanged() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetBuilderEventCallbacks() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_CopyAssemblyToClipboard() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_PasteAssemblyFromClipboard() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_DuplicateAssembly(IObjectAssemblyPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_OnPartGrabbed(IObjectAssemblyPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_OnPartDropped(IObjectAssemblyPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_OnPartDeleted(IObjectAssemblyPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetUIEventCallbacks() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static bool ShouldShowStructureObjects(bool toOrtho, bool fromOrtho, float interpT) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnOrthoTransitionStart(bool toOrtho, bool didChange) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnOrthoTransitionUpdated(
        bool toOrtho,
        float interpT,
        Quaternion orthoRot)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnOrthoZoomChanged(float orthoSize, float aspect) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_DeleteGrabbedPart() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_SpawnPart(IObjectAssemblyAvailablePart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_Undo() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_Redo() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_QuitOrthoView() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_New() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_Refresh() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_SaveWorkspace(
        string fileName,
        string displayName,
        string vehicleName,
        string description,
        bool isAutosave,
        IOProvider.DataLocation dataLocation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_LoadWorkspace(OABLoadDialogExistingSave selectedEntry) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_MergeWorkspace(OABLoadDialogExistingSave selectedEntry) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_DeleteWorkspaceFile(string filename, IOProvider.DataLocation dataLocation) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_SaveFavorites() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Builder_LoadFavorites() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_SetUIDeletionLock(bool newValue) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_Launch() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsClearedForLaunch() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void RemoveIfOrphanCompoundPart(IObjectAssemblyPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HandleLaunchUnavailableWarningModal() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HandleOccupiedLaunchpadWarningModal() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HandleNoCommandModuleWarningModal() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HandleCollisionWarningModal() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void ClearAndLaunch() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void BeginAssemblyLaunch() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void FinishAssemblyLaunch(SerializedLocation launchLocation) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void LaunchAtLocation(SerializedLocation launchLocation) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private SerializedLocation? DetermineLaunchLocation() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private SerializedLocation GetLaunchLocationFromOABConfig() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnExit() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnSetAssemblyAnchorButton() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnSetLaunchAssemblyButton() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnSetManipulateButton() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnSetColorButton() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnRevertTool() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UIBind_OnToolReadyToRelease(IObjectAssemblyTool tool) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float GetCamZoomPower(Camera cam, int subDivisions) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateBlueprintGrid() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HACK_HandleOABChange(bool isOAB) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HACK_HandleOABChangeAudioListeners(bool isOAB) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void HACK_HandleOABChangeCameraCulling(bool isOAB) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static ObjectAssemblyBuilderEventsManager() => throw null;
    }

    public class RuntimeQAPartData
    {
      public const string PartsInBuildersQATestTitles = "ASSET,NAME,CAT,SIZE,MASS,BUILDER_CAT";
      public string AssetName;
      public string InGameName;
      public MetaAssemblySizeFilterType PartSize;
      public double PartMass;
      public PartCategories PartCategory;
      public OABEditorPartCategory OABEditorCategory;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RuntimeQAPartData(PartData partData) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string ToString() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string ToCSVString() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void ExportPartInBuilderDataToCSV(ObjectAssemblyBuilder builder) => throw null;
    }
  }
}
