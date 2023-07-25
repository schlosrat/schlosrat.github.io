// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.HierachyGroup
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
  public class HierachyGroup : Decorator<NavElementGroup>
  {
    protected List<HierachyGroup> _children;

    public IHierachyGroupsLayout ParentLayout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public HierachyGroup Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public HierachyGroup Root
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<HierachyGroup> Children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HierachyGroup(Extend<NavElementGroup> extend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddChildGroup(HierachyGroup groupToAdd, bool forced = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HierachyGroup FindGroup(Transform key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsGroup(NavElementGroup group) => throw null;
  }
}
