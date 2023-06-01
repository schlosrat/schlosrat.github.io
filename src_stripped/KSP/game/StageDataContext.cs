// Decompiled with JetBrains decompiler
// Type: KSP.Game.StageDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class StageDataContext : DataContext
  {
    public PropertyExternal<int> PartGroupCount;
    public PropertyExternal<double> DeltaV;
    public PropertyExternal<bool> HasThrust;
    public Property<int> VesselStageID;
    public Property<int> DisplayedStageID;
    public bool CanBeRemoved;
    private StagingDataProvider _stagingDataProvider;

    public ContextListProperty<StagePartGroupDataContext> PartGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<bool> IsHighlighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<bool> IsDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<int> HighlightIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> IsExpanded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<bool> IsEmpty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<bool> IsActiveStageFlight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StageDataContext(
      int displayStageID,
      int vesselStageID,
      StagingDataProvider stagingDataProvider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsExpanded(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveStage(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleExpandPartFolder(int partFolderIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartFoldersListChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsStageEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool StageHasThrust() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StagePartGroupDataContext FindPartFolder(StagePartDataContext part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryAddPart(StagePartDataContext partToAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryRemovePart(StagePartDataContext partToRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnumeratePartsRemoveIf(
      Func<StagePartDataContext, bool> removeIfPredicate,
      bool fireEvent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildPartGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateStageDeltaV(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int StagePartGroupCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double StageDeltaV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryAddPartToPartGroupInPlace(
      StagePartDataContext partToAdd,
      StagePartGroupDataContext stagePartGroup)
    {
      throw null;
    }
  }
}
