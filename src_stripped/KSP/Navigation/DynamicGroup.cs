// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.DynamicGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public class DynamicGroup : HierachyGroup
  {
    private ADynamicNavLayout _parentLayout;
    protected bool _isDirty;
    protected List<SelectableElementInfo> _elementInfoes;
    protected List<SelectableElementInfo> _elementsAccessable;
    protected List<SelectableElementInfo> _elementsAccessableAsChild;

    public Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public NavigationParameter NavParameter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicGroup(Extend<NavElementGroup> extend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RefreshElementsAccessable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RefreshElementsAccessableAsChild() => throw null;

    protected List<SelectableElementInfo> ElementInfoes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<SelectableElementInfo> ElementsAccessable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected List<SelectableElementInfo> ElementsAccessableAsChild
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectableElementInfo FindInfo(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectableElementInfo GetInfo(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;
  }
}
