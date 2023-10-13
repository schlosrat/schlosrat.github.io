// Decompiled with JetBrains decompiler
// Type: KSP.Game.StagingDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class StagingDataProvider : DataBus<StagingComponent>
  {
    public VesselDeltaVComponent VesselDeltaV;
    public List<PartSymmetrySet> PartSymmetrySets;
    private PropertyExternal<bool> CanStage;
    public PropertyExternal<bool> PartsBinVisible;
    public PropertyExternal<int> StageCount;
    public PropertyExternal<bool> HasReadyStage;
    public PropertyExternal<bool> isExpandToggleVisible;
    private Property<int> SelectedStageIndex;
    private Property<int> SelectedFolderIndex;
    private Property<bool> IsStagingExpanded;
    public Property<AssemblyPartStageType> SelectedPartType;
    public Property<KSP.OAB.SymmetrySet> HighlightedPartSymmetrySetOAB;
    public Property<KSP.Sim.SymmetrySet> HighlightedPartSymmetrySetFlight;
    public PropertyExternal<double> TotalDV;
    public Property<int> HighlightIndex;
    public Property<int> DraggingStageIndex;
    public Property<int> TargetDropStageDropIndex;
    public bool IsLoadingVessel;
    public Action<int, int> StageMoved;
    public Action<int> StageAdded;
    public Action<int> StageRemoved;
    public Action<int, IGGuid, int, int> PartGroupMoved;
    public Action<int, List<IGGuid>, int, int> PartFolderMoved;
    private bool _isOABStaging;
    private bool _isAddingPart;
    private bool _isPartOutlined;
    private bool _forceUpdate;
    private bool _clearActionsOnReset;
    private StagingAutomaticStagingDriver _automaticStagingDriver;
    private List<SymmetrySetData> _bufferedVesselPartSymmetrySets;
    private KSP.OAB.SymmetrySet _highlightedPartSymmetrySetOAB;
    private KSP.Sim.SymmetrySet _highlightedPartSymmetrySetFlight;

    public bool IsOABStaging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextListProperty<StagePartDataContext> AllParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ContextListProperty<StageDataContext> StagingStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public StageDataContext PartsBin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> PartWithSymIsHighlighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Action OnStageChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingDataProvider(bool isOABStaging = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NotifyOABIfPresent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateStageDeltaV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EngineModeChanged(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanEmptyStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionAddStage(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionRemoveStage(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionMoveStage(int indexFrom, int indexTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionMoveStagePartGroup(
      int stageFrom,
      int partGroupFrom,
      int stageTo,
      int partGroupTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionMoveFromSourceListToTargetList(
      int sourceListIndex,
      int sourceElementIndex,
      int targetListIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionMoveFromSourceFolderToTargetList(
      int sourceStageIndex,
      int partFolderIndex,
      int sourceElementIndex,
      int targetStageIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionSetTargetStageFromtoIndex(int fromStageIndex, int toStageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BoundActionMoveSourceFolderElementsToTargetStageAtIndex(
      int sourceStageIndex,
      int partFolderIndex,
      int targetStageIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanManipulateStagingStack(bool notifyIfInsufficient) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(StagingComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingStackChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageMoved(int arg1, int arg2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageActivated(int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAllStagesExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStagesExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsToggleExpandVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetStageCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetHasReadyStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPartsBinVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateListDerived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageDataContextIDs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTotalDV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildStagingStack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllParts(bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PartInStageIndex(IObjectAssemblyPart part, out int folderIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StagePartDataContext GetPartGroup(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddStage(int index = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveStage(int index = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveStage(int indexFrom, int indexTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveStagePartGroup(int stageFrom, int partGroupFrom, int stageTo, int partGroupTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveFromSourceListToTargetListAtIndex(
      int sourceListIndex,
      int sourceElementIndex,
      int targetListIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveFromSourceFolderToTargetStageListAtIndex(
      int sourceStageIndex,
      int partFolderIndex,
      int sourceElementIndex,
      int targetStageIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveSourceFolderElementsToTargetStageAtIndex(
      int sourceStageIndex,
      int partFolderIndex,
      int targetStageIndex,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HighlightStage(int stageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HighlightPart(int stageIndex, int partGroupIndex, int folderIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HighlightPartGroup(int stageIndex, int folderIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePart(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSymmetrySet FindPartSymmetrySet(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryAddPartSymmetrySet(
      IGGuid partGuid,
      SymmetrySetData symmetrySetData,
      bool updatePartSymmetrySetId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BufferVesselPartSymmetrySets(List<SymmetrySetData> partSymmetrySets) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPartSymmetrySets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartSymmetrySetToPartFolder(
      PartSymmetrySet partSymmetrySet,
      StagePartGroupDataContext stagePartGroup,
      ref List<StagePartDataContext> partFolderListCopy)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPartSymmetrySetIdsForPartFolder(
      StagePartGroupDataContext stagePartGroup,
      StageDataContext stage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPartSymmetrySetIdsForStage(StageDataContext stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartSymmetrySetToStage(
      PartSymmetrySet partSymmetrySet,
      StageDataContext stage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPartSymmetrySetIds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartSymmetrySetId(PartSymmetrySet partSymmetrySet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddPartSymmetrySet(PartSymmetrySet partSymmetrySet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryRemovePartSymmetrySet(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMainAssemblyChanged() => throw null;
  }
}
