// Decompiled with JetBrains decompiler
// Type: KSP.UI.TabGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
