// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SpaceSimulation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Game.Colonies;
using KSP.Messages;
using KSP.ScriptInterop;
using KSP.Sim.Debugging;
using KSP.Sim.Definitions;
using KSP.Sim.impl.lua;
using KSP.Sim.Maneuver;
using KSP.Sim.State;
using KSP.Sim.ViewActions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP.Sim.impl
{
  public class SpaceSimulation : 
    IViewActionQueue,
    IUpdate,
    IFixedUpdate,
    ILateUpdate,
    IPriorityOverride
  {
    private const string VESSEL_CREATE_DEBUG_NAME_FORMAT = "{0}_{1}";
    private const int DEFAULT_MAX_PLAYERS = 0;
    private int _maxPlayers;
    private ObjectIdManager _objectIdManager;
    private UniverseModel _universeModel;
    private UniverseView _universeView;
    private ManeuverProvider maneuvers;
    private readonly IModelViewMap _modelViewMap;
    private ILuaDebugInjector scriptInjector;
    public IScriptEnvironment scriptEnvironment;
    private PartProvider _partProvider;
    private Dictionary<string, System.Type> validComponentTypeCache;
    private HashSet<string> invalidComponentTypeCache;
    private const string invalidTypeWarningFormat = "SpaceSimulation.GetAllObjectsWithComponent called with invalid type name string `{0}`";
    private string remoteScriptPipeName;
    private IHandOfGodForces godForces;
    private List<IViewAction> _pendingViewActions;
    private PartComponent _pendingActiveVesselPart;
    private bool _celestialBodyCollisionApproximationEnabled;
    private KerbalRosterManager _kerbalRosterManager;
    public bool IsEnabled;
    private readonly List<PartComponent> _orphanedParts;

    [DllImport("LuaPipePlugin64", CharSet = CharSet.Ansi)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetPipeName(string pipeName) => throw null;

    [DllImport("LuaPipePlugin64", CharSet = CharSet.Ansi)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void QueryRemoteScripts(SpaceSimulation.ProcessRemoteScript callback) => throw null;

    public int MaxPlayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniverseModel UniverseModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniverseView UniverseView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IModelViewMap ModelViewMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectIdManager ObjectIdManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SpaceSimulationLua Lua
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ManeuverProvider Maneuvers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpaceSimulation(
      int maxPlayers,
      double universalTime,
      DynamicConfigurationDatabase dynamicConfigurationDatabase,
      IScriptEnvironment scriptEnvironment)
    {
      throw null;
    }

    public bool IsCelestialBodyCollisionApproximationEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObject(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByNameKey(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetSimulationObjectComponent<T>(IGGuid guid) where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateCelestialBodySimObject(
      CelestialBodyDefinition celestialBodyDefinition,
      SerializedCelestialBody celestialBody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel SplitCombinedVesselSimObject(
      VesselComponent combinedVessel,
      IGGuid detachingPartId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateCombinedVesselSimObject(
      VesselComponent masterVessel,
      PartComponent masterAttachPart,
      VesselComponent otherVessel,
      PartComponent otherAttachPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SimulationObjectModel CreateVesselSimObjectFromPart(PartComponent rootPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignSubVesselDataTo(
      VesselComponent vessel,
      VesselComponent.SubVesselData subVesselData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddColonyComponentToSimObject(IGGuid targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<IGGuid, PartToPartModuleDataList> CollectPartModuleStateData(
      SimulationObjectModel targetVessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartModuleStateData(
      Dictionary<IGGuid, PartToPartModuleDataList> sourcePartData,
      SimulationObjectModel newVessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<IGGuid, ResourceSnapshot> CollectPartResourceState(
      SimulationObjectModel targetVessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartResources(
      Dictionary<IGGuid, ResourceSnapshot> partResources,
      SimulationObjectModel newVessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel ReplaceVesselSimObject(
      SerializedAssembly vessel,
      bool preserveOrientation,
      string ownerPlayerGuidString,
      byte ownerPlayerId,
      byte authorityPlayerId,
      IGGuid targetVesselID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateVesselSimObjectInternal(
      SerializedAssembly vessel,
      string ownerPlayerGuidString,
      byte ownerPlayerId,
      byte authorityPlayerId,
      ulong vesselObjectId,
      string debuggingName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateVesselSimObject(
      SerializedAssembly vessel,
      string owningPlayerGuidString,
      byte owningPlayerId,
      byte authorityPlayerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateKerbalSimObject(
      SerializedAssembly kerbal,
      string ownerPlayerGuidString,
      byte ownerPlayerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateWaypointSimObject(
      WaypointComponentDefinition waypointDefinition,
      CelestialBodyComponent body,
      double latitude,
      double longitude,
      double altitudeFromRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel CreateFlagSimObject(
      SerializedFlag flag,
      string viewPrefabAssetKey,
      Action<SimulationObjectView> viewCreatedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncFlagToLocation(FlagComponent flagComponent, SerializedFlag flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVesselToLocation(
      VesselComponent vesselComponent,
      SerializedLocation location,
      VesselState vesselState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SimulationObjectModel CreatePart(
      SerializedPart part,
      string ownerPlayerGuidString,
      byte ownerPlayerId,
      byte authorityPlayerId,
      DictionaryValueList<IGGuid, IGGuid> originalPartIdLookup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsViewObjectLoaded(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetViewObject(
      SimulationObjectModel simObject,
      out SimulationObjectView viewObject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetViewObjectComponent<T>(
      SimulationObjectModel simObject,
      out T viewObjectComponent)
      where T : ViewObjectComponent
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCelestialBodyCollisionApproximation(
      ITransformModel transform,
      out CelestialBodyComponent collidingBody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAltitudeBelowCollisionApproximationLimit(
      Position position,
      ITransformFrame soiFrame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncToView(UniverseView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static UniverseModel CreateUniverseModel(
      ILateUpdateDriver lateUpdateDriver,
      double universalTime,
      MessageCenter messageCenter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnloadView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD GetRotationFromNormalHeading(Vector3d surfaceNormal, double heading) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetLaunchSiteHeading(
      GeographicPositionState geographicPosition,
      QuaternionD launchSiteRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD GetGeographicPositionHeading(Vector3d surfaceNormal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBodyRelativePosition(
      GeographicPositionState geographicPosition,
      out FramePositionState framePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetGeographicPosition(
      string cbNameKey,
      FramePositionState framePosition,
      out GeographicPositionState geographicPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetSurfaceObjectPosition(
      IGGuid celestialBodySimObject,
      string surfaceObjectName,
      out FramePositionState framePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetSurfaceObjectPosition(
      string cbNameKey,
      string surfaceObjectName,
      out FramePositionState framePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string processRemoteScripts(string context, string script) => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime, bool force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOrphanedPartActiveVessel(PartComponent targetPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitViewAction(IViewAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitViewActions(IEnumerable<IViewAction> actions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FlushViewActionQueue(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearViewActionQueue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ICollection<string> GetAllObjectNameKeysWithComponent<T>() where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetAllObjectsWithComponent<T>() where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<SimulationObjectModel> GetAllSimulationObjectsWithComponent<T>() where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetBodyNameKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetVesselGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetColonyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<string> GetPartGuids() => throw null;

    public delegate string ProcessRemoteScript(string context, string script);
  }
}
