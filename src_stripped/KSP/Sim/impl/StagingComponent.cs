// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.StagingComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class StagingComponent : ObjectComponent
  {
    private const LogFilter LOGFLAG = LogFilter.Simulation;
    private static readonly string LOGTAG_BASE;
    private static readonly string CMDTAG_BASE;
    public const int UNASSIGNED_PARTS_INDEX = -1;
    private string logTag;
    private string cmdTag;
    private readonly PartComponent[] _tempSinglePartArray;
    private readonly List<int> _tempModifiedStages;
    private List<StagingComponent.PendingPartRemovalData> _partsPendingRemoval;
    private List<PartComponent> _partsPendingAddition;
    private int _totalStageCount;
    public bool AutoRemoveEmptyStages;
    public VesselDeltaVComponent VesselDVComponent;
    private List<StagePartsInternal> availableStages;
    private StagePartsInternal unassignedPartStage;
    private HashSet<IGGuid> _partIdsInStagingStack;

    [TypeConverterIgnore]
    public override Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action StagingStackChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<int> StageActivated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool HaveStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int StageCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int TotalStageCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int LastStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyList<StagePartsInternal> AvailableStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingComponent(StagingDefinition stagingDefinition, IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingComponent(UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartOwnerAttachments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPendingPartAdditions(bool addToStage = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryAddPartsToBin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryAddPartsToStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPendingPartRemovals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyList<PartComponent> GetPartsInStage(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetStageIndex(PartComponent part, out int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidStageIndex(int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateNextStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveActivePartsToNextStage(int currentStageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveInactivePartsInStage(int currentStageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivatePartsInStage(int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartStatusUpdated(PartComponent part, bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InvokeStageActivated(int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InsertNewStageAt(int index, ICollection<PartComponent> parts = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveStageAt(int index, bool removeByActivation = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapUnassignedParts(int indexA, int indexB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapPartsInStage(int stageIndex, int indexA, int indexB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReorderPartsInStage(int stageIndex, ICollection<PartComponent> newOrder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReorderUnassignedParts(ICollection<PartComponent> newOrder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveStage(int stageIndexFrom, int stageIndexTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePartsToUnassigned(ICollection<PartComponent> parts, int partIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePartToUnassigned(PartComponent part, int partIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePartToStage(
      int stageIndex,
      PartComponent part,
      int partIndex,
      bool activateOnMoveToActive = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePartsToStage(
      int stageIndex,
      ICollection<PartComponent> parts,
      int partIndex,
      bool activateOnMoveToActive = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageIDs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState ExtractStagingState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InjectStagingState(StagingState stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResyncStagingState(bool forceAllPartsToPartsBin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsStageablePart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartComponent MapGuidToPartOnVessel(
      IGGuid partGuid,
      ISimulationModelMap simulationModelMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecachePartStageIndices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePartsFromStaging(ICollection<PartComponent> toRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PartOwner_OnPartsAdded(List<PartComponent> addedParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PartOwner_OnPartsRemoved(List<PartComponent> removedParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StagingComponent() => throw null;

    private struct PendingPartRemovalData
    {
      public IGGuid Guid;
      public int ActivationStage;
    }
  }
}
