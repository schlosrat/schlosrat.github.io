// Decompiled with JetBrains decompiler
// Type: KSP.Game.StagePartGroupDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Modules;
using KSP.OAB;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class StagePartGroupDataContext : DataContext
  {
    public const bool DEFAULT_IS_PART_GROUP_EXPANDED = false;
    protected string partName;
    protected AssemblyPartStageType StageType;
    protected EngineType EngineType;
    public Property<Sprite> Icon;
    public ContextListProperty<StagePartDataContext> Items;
    public PropertyExternal<int> GroupItemCount;
    public PropertyExternal<bool> IsActive;
    public PropertyExternal<bool> IsEmpty;
    public Property<bool> IsGroupExpanded;
    public Property<bool> IsGroupIconHighlighted;
    public Property<string> GroupDisplayName;
    private StageDataContext _stage;

    public Property<bool> IsDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<int> HighlightIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> PartWithSymIsHighlighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> GroupAndStageExpanded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartGroupDataContext(StageDataContext stage, StagePartDataContext partToAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStageOrGroupExpandedChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExpandGroupWhenInActiveStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchesCriteria(string _partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsGroupEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsGroupActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetGroupItemCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartAtIndex(int partIndex, out StagePartDataContext part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryAddPart(StagePartDataContext partToAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryAddPartAtIndex(StagePartDataContext partToAdd, int targetIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryRemovePart(StagePartDataContext partToRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnItemsListChanged() => throw null;
  }
}
