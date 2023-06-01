// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.ActionBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Logging;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  [RequireComponent(typeof (ContextBindRoot))]
  public class ActionBar : UIFlightHUDInstrument
  {
    private const LogFilter LOG_FILTER = LogFilter.UI;
    private const string LOG_PREFIX = "[ActionBar] - ";
    public List<ActionBarButton_Data> ButtonList;
    public ActionBarButton ButtonPrefab;
    public Transform ButtonParent;
    public List<Transform> ButtonListPersistentObjects;
    private Dictionary<string, ActionBarButton> _ActionBarButtonMap;
    private Transform _workingTransform;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [ContextMenu("Reset Buttons List")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionBarButton AddButton(ActionBarButton_Data newButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveButton(string appKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionBar() => throw null;
  }
}
