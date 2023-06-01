// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightStagingStackInstrument
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class FlightStagingStackInstrument : UIFlightHUDInstrument
  {
    [SerializeField]
    private FlightStagingUIDriver _stagingDriver;
    [SerializeField]
    private UIWidget_GoButton _goButtonManager;
    private SubscriptionHandle _handleVesselDeltaVChanged;
    private SubscriptionHandle _handleEngineChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageDeltaV(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EngineChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightStagingStackInstrument() => throw null;
  }
}
