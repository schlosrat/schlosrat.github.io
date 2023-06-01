// Decompiled with JetBrains decompiler
// Type: KSP.UI.TabGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  public class TabGroup : KerbalMonoBehaviour
  {
    [SerializeField]
    protected List<GameObject> tabContentPanels;
    protected List<TabButton> tabButtons;
    protected TabButton selectedTab;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Subscribe(TabButton button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTabEnter(TabButton button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTabExit(TabButton button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTabSelected(TabButton button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetTabs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetVisibility(CanvasGroup canvasGroup, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TabGroup() => throw null;
  }
}
