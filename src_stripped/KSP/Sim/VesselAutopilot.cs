// Decompiled with JetBrains decompiler
// Type: KSP.Sim.VesselAutopilot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class VesselAutopilot
  {
    private AutopilotMode _mode;
    private bool _isEnabled;
    [NonSerialized]
    private VesselBehavior _vesselView;
    [NonSerialized]
    private VesselComponent _vessel;
    [NonSerialized]
    private TelemetryComponent _telemetry;

    public AutopilotMode AutopilotMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public event Action<bool> AutoPilotEnabledChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutopilotStatus GetStatus() => throw null;

    public VesselSAS SAS
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselAutopilot(VesselBehavior vesselView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActive(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Activate(AutopilotMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPilotPreSASUpdate(ref FlightCtrlState s, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetAutopilot(bool initialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetMode(AutopilotMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanSetMode(AutopilotMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetAutopilotOrbit(bool initialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetAutopilotSurface(bool initialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetAutopilotTarget(bool initialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateNavigationTargets(bool initialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNavigationComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool VectorLockInvalid(float threshold) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TargetLockInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ManeuverLockInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AutopilotOrentationLockInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AutopilotInvalid() => throw null;
  }
}
