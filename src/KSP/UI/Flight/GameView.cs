// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.GameView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Map;
using KSP.Messages;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  [RequireComponent(typeof (ContextBindRoot))]
  public class GameView : UIFlightHUDInstrument
  {
    private DataContext _dataContext;
    private PropertyExternal<MapMode> _currentMapModeProperty;
    private SubscriptionHandle _handleGameViewShutdown;
    private SubscriptionHandle _handleMapShutdown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapModeChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableFlightView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MapMode GetCurrentMapMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableMapView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableTrackingStationFlight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuitTutorial(bool reloadPriorState, Action onCompleteCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameView() => throw null;
  }
}
