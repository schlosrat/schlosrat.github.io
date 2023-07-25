// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.GameView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private SubscriptionHandle _handleTrackingStationLoaded;
    private SubscriptionHandle _handleVesselDestroyed;
    private SubscriptionHandle _handleVesselChanged;
    private SubscriptionHandle _handleVesselRecovered;
    private CanvasGroup _canvasGroup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselUpdated(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRecovered(MessageCenterMessage message) => throw null;

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
