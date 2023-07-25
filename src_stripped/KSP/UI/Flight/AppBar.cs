// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.AppBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Logging;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  [RequireComponent(typeof (ContextBindRoot))]
  public class AppBar : UIFlightHUDInstrument
  {
    private const LogFilter LOG_FILTER = (LogFilter) 2097152;
    private const string LOG_PREFIX = "[AppBar] - ";
    public List<AppBarButton_Data> ButtonList;
    public AppBarButton ButtonPrefab;
    public Transform ButtonParent;
    public List<Transform> ButtonListPersistentObjects;
    private Dictionary<string, AppBarButton> _AppBarButtonMap;
    private Transform _workingTransform;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [ContextMenu("Reset Buttons List")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AppBarButton AddButton(AppBarButton_Data newButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveButton(string appKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AppBar() => throw null;
  }
}
