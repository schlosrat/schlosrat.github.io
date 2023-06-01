// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightWidgetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.UI.Flight
{
  public abstract class FlightWidgetManager : UIDependendsOn<IViewController>
  {
    private SubscriptionHandle _handleOnVesselChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CleanUp() => throw null;

    protected override IViewController Dependency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetBackendCallbacks(IViewController backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearBackendCallbacks(IViewController backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void UpdateWidget(IVehicle vehicle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FlightWidgetManager() => throw null;
  }
}
