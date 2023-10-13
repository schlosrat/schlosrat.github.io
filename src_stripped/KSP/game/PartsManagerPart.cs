// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class PartsManagerPart : KerbalMonoBehaviour, IPooledUI
  {
    [SerializeField]
    private ContextBindRoot _contextBindRoot;
    [SerializeField]
    private Transform _accordianContent;
    [SerializeField]
    private ToggleExtended _toggle;
    private bool initialized;
    private DataContext _dataContext;
    private Property<string> _partName;
    private IInteractivePart _part;
    private PartsManagerCategory _uiCategory;
    private GameObjectPool<PartsManagerPart> _pool;
    private PartsManagerPartsList _parentPartsList;
    private bool isFavorite;
    public Property<bool> IsHighlighted;
    public PropertyReadonly<IGGuid> Guid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IInteractivePart GetInteractivePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCategory(PartsManagerCategory category) => throw null;

    public PartsManagerCategory ParentCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<PartsManagerEntry> Entries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IGGuid PartGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      GameObjectPool<PartsManagerPart> pool,
      IGGuid guid,
      IInteractivePart part,
      PartsManagerPartsList _parentList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddEntry(PartsManagerEntry entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExpanded(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFavorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFavorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFavorite(bool isfavorite) => throw null;

    [ContextMenu("Sort Entry Tarnsforms")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortPartEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareBySortIndex(PartsManagerEntry x, PartsManagerEntry y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartHighlight(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerPart() => throw null;
  }
}
