// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartOwnerComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using KSP.Modules;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartOwnerComponent : ObjectComponent
  {
    public static bool DebugPrintEnabled;
    private UniverseModel universeModel;
    private readonly List<PartComponent> _tempSinglePartArray;
    public bool PartAttachmentsDirty;
    private PartOwnerComponent.PartInfoDictionary _parts;
    private bool _hasStellarExpsoureUpdated;
    private bool _lastHasPanelsStellarExposure;
    private bool _isPanelStellarExposureMessageArmed;
    private List<Data_SolarPanel> _solarPanelsData;
    private List<SolarPanelStarExposureData> _stellarExposureData;
    private readonly HashSet<PartComponent> _vistedSet;
    private List<PartRelationshipData> pendingVirtualConnections;
    private List<VirtualConnection> virtualConnections;
    private readonly FlowGraph flowGraph;
    private Dictionary<ResourceContainer, List<Callback>> _containerCallbacks;
    private List<PartComponent> _crewableParts;
    private bool _isPhysicsStatsDirty;
    private Position _centerOfMass;
    private bool _hasPreDetachSymmetrySetsData;
    private List<SymmetrySetData> _preDetachSymmetrySetsData;
    public List<SymmetrySet> SymmetrySets;

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

    public event Action PartsChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<List<PartComponent>> PartsAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<List<PartComponent>> PartsRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<Position> OnCenterOfMassChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public List<SolarPanelStarExposureData> StellarExposureData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public FlowGraph FlowGraph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceContainerGroup ContainerGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddContainerCallback(ResourceContainer container, Callback callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveContainerCallback(ResourceContainer container, Callback callback) => throw null;

    public int PartCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<PartComponent> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<VirtualConnection> VirtualConnections
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartComponent RootPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public List<PartComponent> CrewableParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CrewablePartsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceFlowRequestManager ResourceFlowRequestManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TotalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position CenterOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector MOI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AngularVelocity AngularMomentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AngularVelocity AngularVelocityMassAvg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Velocity VelocityMassAvg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double ReEntryMaximumFlux
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerComponent(PartOwnerDefinition definition, IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerComponent(UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<SolarPanelStarExposureData> GetStellarExposureData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartAdded_SolarPanelCheck(List<PartComponent> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsRemoved_SolarPanelCheck(List<PartComponent> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnContainerChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnLateUpdate(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInsolation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHasPanelsStellarExposure() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePartRelationships() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartRelationshipsRecursive(PartComponent parent, PartComponent previousPart = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent GetPartParent(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<PartComponent> GetPartChildren(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(PartComponent part, bool fireChangedEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(PartComponent part, bool fireChangedEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerPartsChangedEvents(
      List<PartComponent> partsAdded,
      List<PartComponent> partsRemoved)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPart(IGGuid guid, out PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DetachPart(
      PartComponent part,
      System.Guid? promotionGuid = null,
      bool forceRemove = false,
      bool ignoreChildrenOfCompoundParts = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<PartComponent> DetachPart(
      PartComponent part,
      bool forceRemove,
      bool ignoreChildrenOfCompoundParts,
      System.Guid? promotionGuid)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymmetrySetData GetPreDetachSymmetrySetData(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DetachPartInternal(
      PartComponent part,
      bool forceRemove,
      bool ignoreChildrenOfCompoundParts,
      out List<PartComponent> detachedParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasPartModule<T>() where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<T> GetPartModules<T>() where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPartModules<T>(List<T> results) where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPathToPart(PartComponent startPart, PartComponent targetPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsPathToPartRecursive(
      PartComponent part,
      PartComponent target,
      HashSet<PartComponent> visited)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePendingVirtualConnections(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Velocity GetVelocityMassAverage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculatePhysicsStats(bool forceRecalculation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMassStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculatePhysicsStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetRootPart() => throw null;

    [Obsolete("Do not use, use FindConnectedParts()")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PartComponent> FindConnectedPartsLegacy(PartComponent root, PartComponent parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent FindPartAttachedTo(PartComponent targetPart, string attachmentNodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<AttachNodeData> GetAllAttachmentsTo(PartComponent targetPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindConnectedPartsRecursive(
      PartComponent root,
      HashSet<PartComponent> openList,
      List<PartComponent> results)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PartComponent> FindSurfaceAttachments(
      PartComponent root,
      HashSet<PartComponent> openList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PartComponent> FindConnectedParts(PartComponent root, PartComponent partToIgnore = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetResourceFlowRequests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void LoadSymmetrySets(List<SymmetrySetData> setsData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<SymmetrySetData> ExtractSymmetrySetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ValidateSymmetrySets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PartOwnerComponent() => throw null;

    private class PartInfo
    {
      private PartComponent _part;
      private PartComponent _parent;
      private List<PartComponent> _children;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartInfo(PartComponent part, PartComponent parent) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetParent(PartComponent parent) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetChildren(IEnumerable<AttachNodeData> children) => throw null;

      public PartComponent Parent
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IEnumerable<PartComponent> Children
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public PartComponent Part
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    private class PartInfoDictionary : DictionaryValueList<IGGuid, PartOwnerComponent.PartInfo>
    {
      public IEnumerable<PartComponent> PartsEnumerable
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryGetPartValue(IGGuid guid, out PartComponent part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartInfoDictionary() => throw null;
    }
  }
}
