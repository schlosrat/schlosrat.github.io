// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.NavElementGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  [ExecuteInEditMode]
  public class NavElementGroup : KerbalMonoBehaviour, IExtendable<NavElementGroup>
  {
    protected List<Selectable> _elements;
    private global::Extend<NavElementGroup> _extend;
    public Action OnInitializing;

    public List<Selectable> Elements
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public global::Extend<NavElementGroup> Extend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NavElementGroup() => throw null;
  }
}
