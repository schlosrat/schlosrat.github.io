// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightWidgetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
