// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.ResourceSystem;
using KSP.Sim.State;
using KSP.VFX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("{_Value_ForDebuggerOnly}")]
  public class PartComponent : ObjectComponent, IFlowNode, IDeltaVPart, IEquatable<IDeltaVPart>
  {
    private const LogFilter LOGFLAG = LogFilter.Simulation;
    private static readonly string LOGTAG_BASE;
    private static readonly string CMDTAG_BASE;
    private string logTag;
    private string cmdTag;
    private PartOwnerComponent _partOwner;
    private readonly HashSet<PartComponent> _visited;
    private List<PartComponent> _ownerChangedParts;
    private IResourceContainer[] _containers;
    private readonly Vector3d[] _boundCoords;
    private readonly double[] _coordDepths;
    public List<float> AssemblySizeTypeDiameters;
    private bool _splashed;
    private double mass;
    private double massModifyAmount;
    private double resourceMass;
    private double greenMass;
    private double physicsMass;
    private Data_Drag _dragData;
    private bool _dragDataWarningIssued;
    private int _stageIndex;
    private int _decoupleIndex;
    private bool _hasPendingPromotionGuid;
    private PartComponent.PendingPromotion _pendingPromotion;
    public ThermalData ThermalData;
    private Action<PartComponent, bool> _onPartActiveUpdated;
    private PartComponent.BuoyancyForce buoyantForce;
    private Vector3d lastForcePosition;
    private bool isBuoyancyActive;
    private double _dragScalar;
    private bool _isEarlySplash;
    private double _splashCounter;
    private bool _wasSplashed;
    private Dictionary<string, AttachNodeData> attachNodesByID;
    private List<AttachNodeData> _surfaceAttachmentsToMe;
    private UniverseModel universeModel;
    public DictionaryValueList<System.Type, PartComponentModule> Modules;
    private PartDefinition _definition;
    private TransformModel controlTransform;
    private int _currentKerbalCountTotal;
    private SymmetrySetData _previousSymmetrySet;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerComponent PartOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override bool IsValidInSim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceFlowRequestBroker PartResourceFlowRequestBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ResourceContainer PartResourceContainer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IResourceContainer[] Containers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsCompound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float StaticPressureAtm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float StaticPressureAtmASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperatureASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmDensityASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IResourceContainer[] DeltaVContainers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent PartCelestialBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public List<Dictionary<string, object>> LegacyModuleData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isDecimated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<PartBehavior> decimatedChildParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3d CenterOfMassOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position CenterOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3d CenterOfLiftOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position CenterOfLift
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float maximum_drag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float minimum_drag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double WettedArea
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double Temperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double LiquidDragScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double LiquidAngularDragScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double ThermalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double ResourceThermalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double staticPressurekPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double staticPressureAtm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double dynamicPressurekPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double dynamicPressureAtm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double atmDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double soundSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double machNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double dragCoefficient
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool AllowKinematicPhysicsIfIntersectTerrain
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsAeroActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Splashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ActivationStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int DecoupleStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double DryMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double WetMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ResourceMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double GreenMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double PhysicsMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IDeltaVPart Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartComponent ParentPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<IDeltaVPart> DeltaVChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDeltaVPart FindAttachNodeAttachedPart(string nodeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(IDeltaVPart other) => throw null;

    [Obsolete("Please use PartData instead")]
    public PartProperties partProperties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartData PartData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float CrashTolerance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double MaxTemp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double BreakingForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double BreakingTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ExplosionPotential
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool FuelCrossfeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartPhysicsModes PhysicsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DecouplePartEvent OnDecoupled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public event Action<FXContextualEventParams> PartExploded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<WaterSplashEventData> WaterSplash
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public List<AttachNodeData> SurfaceAttachmentsToMe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSymmetryMirrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStageIndex(int value, bool notifyStaging) => throw null;

    public bool IsActiveInStaging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsDamaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ITransformModel ControlTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SymmetrySet SymmetrySet
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalRosterChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCurrentKerbalCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent(PartDefinition partDefinition, UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(bool notifyObservers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule<T>(out T module) where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule(System.Type moduleType, out PartComponentModule foundModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleData<T, U>(out U data)
      where T : PartComponentModule
      where U : ModuleData
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PartComponent> SetPartOwner(
      PartOwnerComponent newPartOwner,
      bool isRecursive,
      bool ignoreChildrenOfCompoundParts = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOwnerRecursively(
      PartOwnerComponent newOwner,
      HashSet<PartComponent> visited,
      List<PartComponent> changedParts,
      bool ignoreChildrenOfCompoundParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTransformAndMotionFrom(PartOwnerComponent partOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAttachNodeState(
      List<AttachNodeState> attachNodeStates,
      ISimulationModelMap simulationModelMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllAttachments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ClearNodeAttachment(string nodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddNodeAttachment(AttachNodeData newAttachNodeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveNodeAttachment(string nodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetNodeAttachment(string nodeID, PartComponent otherPart, string otherPartNodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeData GetNodeAttachment(string attachmentNodeId, bool logWarning = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetAttachment(string attachmentNodeId, out AttachNodeData attachNodeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<AttachNodeData> FindNodeAttachmentsOfType(AttachNodeType nodeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FindAttachmentsTo(PartComponent otherPart, ref List<AttachNodeData> results) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeData FindAttachmentTo(PartComponent otherPart, string otherPartNodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<AttachNodeData> GetAttachments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<AttachNodeData> GetAllAttachments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IInternalSeat FindInternalSeat(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyPart(ExplosionType explosionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuoyancyUpdate(double deltaUniverseTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d CalculateBuoyantLocalForcePosition(
      Vector3d center,
      Vector3d[] bounds,
      double[] depthBounds,
      double velocityMag,
      double submergedPercent,
      double minDepth,
      double maxDepth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateDisplacement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateSubmergedPercentage(
      double centerDepth,
      double minDepth,
      double maxDepth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectPartBoundsAndDepths(
      double waterSurfaceAltitude,
      out Vector3d[] boundCoords,
      out double[] coordDepths,
      out double minDepth,
      out double maxDepth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d[] GetPartBoundCoords() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateLiquidDrag(
      VesselComponent vessel,
      double localVelocityMag,
      double submergedPortion,
      double dotAbs,
      double deltaUniversalTime,
      bool isKerbal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableBuoyancy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableBuoyancy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DragCube GetOverrideCube() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerPartExplosionEvent(FXContextualEventParams data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerWaterSplashEvent(WaterSplashEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindPartCelestialBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSurfaceAttachment(AttachNodeData attachment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveSurfaceAttachment(AttachNodeData attachment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PartComponent GetPartComponentFromGuid(
      IGGuid instanceGuid,
      ISimulationModelMap simulationModelMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UsedOnlyForAOTCodeGeneration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetControlTransform(Vector3 position, Vector3 orientation, string cpId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetAsVesselControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSymmetrySyncRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetPreviousSymmetrySet(SymmetrySetData oldSetData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool TryGetPreviousSymmetrySet(out SymmetrySetData oldSetData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ClearPreviousSymmetrySet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPendingPromotion(IGGuid promotionGuid, IGGuid subVesselDataId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearPendingPromotion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPendingPromotion(out PartComponent.PendingPromotion result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModuleActiveUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubscribeOnPartActiveUpdate(Action<PartComponent, bool> action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnsubscribeOnPartActiveUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MergePartModuleData(List<SerializedPartModule> modifiedPartModules) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MergePartModuleData(
      string partName,
      List<SerializedPartModule> modifiedPartModules)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PartComponent() => throw null;

    public class BuoyancyForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static PartComponent.BuoyancyForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BuoyancyForce() => throw null;
    }

    public struct PendingPromotion
    {
      public IGGuid VesselId;
      public IGGuid SubVesselDataId;
      public IGGuid RootPartId;
      public bool RecentlyPromoted;
    }
  }
}
