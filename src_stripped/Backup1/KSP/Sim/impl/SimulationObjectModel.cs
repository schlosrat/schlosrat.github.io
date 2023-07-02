// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SimulationObjectModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.DeltaV;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class SimulationObjectModel : IGuidIdentity
  {
    private readonly IGGuid _globalId;
    private readonly string _globalNameKey;
    private readonly string _debugName;
    private readonly double _utCreationTime;
    private GimbalState _observedGimbal;
    private byte _authorizingPlayerId;
    private readonly TransformModel _transform;
    private readonly List<ObjectComponent> _components;
    private bool _isDestroying;
    private bool _isDestroyed;
    private string _globalIdGuidString;
    private string _ownerPlayerGuidString;
    private byte _ownerPlayerId;
    private ulong _objectId;
    private string _spawnLocationString;
    private bool started;
    private string _name;
    private string _localizationNameKey;
    private string _displayName;
    private string _description;

    public string ViewPrefabAssetKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double UTCreationTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<ObjectComponent> Components
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<System.Type, ObjectComponent> onComponentAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<System.Type, ObjectComponent> onComponentRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action onStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public IGGuid GlobalId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal string GlobalIdGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GlobalNameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string OwnerPlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOwnerPlayerGuidString(string ownerPlayerGuidString) => throw null;

    public byte OwnerPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOwnerPlayerId(byte ownerPlayerId) => throw null;

    public bool IsCelestialBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsKerbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsActiveVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ulong ObjectId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string DebugObjectIdString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string DebugObjectIdStringAbbrev
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string DebugName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDestroyedOrBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GimbalState ObservedCameraGimbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string SpawnLocationString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpawnLocationString(string spawnLocationString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearSpawnLocationString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel(
      IGGuid globalId,
      string ownerPlayerGuidString,
      byte ownerPlayerId,
      byte authorityPlayerId,
      ulong objectId,
      string viewPrefabAssetKey,
      string name,
      double utCreationTime,
      string globalNameKey)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy(double universeTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FindComponent<T>() where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponent FindComponent(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryFindComponent<T>(out T component) where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstantiateViewObjectAsync(Action<SimulationObjectView> finishedCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstantiateViewObjectAsync(
      Vector3 worldPosition,
      Quaternion worldRotation,
      Action<SimulationObjectView> finishedCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectView InstantiateViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddComponent<T>(T component, double universalTime) where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddComponent(ObjectComponent component, System.Type componentType, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveComponent<T>(double universalTime) where T : ObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveComponent(ObjectComponent component, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Is(IGuidIdentity other) => throw null;

    public CelestialBodyComponent CelestialBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ColonyComponent Colony
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CrewMemberComponent CrewMember
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public KerbalComponent Kerbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartComponent Part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartOwnerComponent PartOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RigidbodyComponent Rigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public StagingComponent Staging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public TelemetryComponent Telemetry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselComponent Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselBehavior objVesselBehavior
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ManeuverPlanComponent ManeuverPlan
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselDeltaVComponent VesselDeltaV
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CommonCacheTryAdd(System.Type type, ObjectComponent value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CommonCacheTryRemoveByType(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(SimulationObjectState? state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMe(
      SimulationObjectState? state,
      Dictionary<System.Type, object> componentStates,
      ISimulationModelMap simulationModelMap,
      Dictionary<System.Type, object> viewGraphUpdates)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDefinition(
      Dictionary<System.Type, object> componentDefinitions,
      Dictionary<System.Type, object> viewGraphUpdates)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwitchPrefabAssets(string newKey) => throw null;

    public Vector ObtVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector SrfVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector FwdVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string LocalizationNameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayName() => throw null;

    public string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IKeplerOrbit Orbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselTargetMode TargetingMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ActiveTargetable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void bound(SimulationObjectModel model, ISimulationObjectView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void unbound(SimulationObjectModel model, ISimulationObjectView view) => throw null;

    public event Action<ISimulationObjectView> onViewLoad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<ISimulationObjectView> onViewUnload
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsPlayerOwned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public byte AuthorizingPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssumeAuthority() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAuthoritativePlayerId(byte playerId) => throw null;

    public bool IsLocallyAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsNobodyAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLocalPlayerOrHostOverrideAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthorizedBy(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssumeOwnership() => throw null;

    public bool IsLocallyOwned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOwnedBy(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectId(ulong objectId) => throw null;
  }
}
