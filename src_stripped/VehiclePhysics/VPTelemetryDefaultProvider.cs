// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTelemetryDefaultProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPTelemetryDefaultProvider : VehicleBehaviour
  {
    public bool emitTelemetry;
    [Space(10f)]
    public bool inputs;
    public bool platform;
    public bool accelerations;
    public bool powertrain;
    [Space(5f)]
    public bool suspension;
    public bool suspensionExtended;
    public bool wheels;
    [Space(5f)]
    public bool tires;
    public bool tiresExtended;
    private bool m_inputs;
    private bool m_platform;
    private bool m_accelerations;
    private bool m_powertrain;
    private bool m_suspension;
    private bool m_suspensionExtended;
    private bool m_wheels;
    private bool m_tires;
    private bool m_tiresExtended;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateAfterFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool EmitTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RegisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UnregisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetChannelsRegistrationStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAndRegisterChannels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAndRegisterOrUnregister<T>(bool wantedState, ref bool currentState) where T : Telemetry.ChannelGroup => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterChannels() => throw null;

    [ContextMenu("Reset Time")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTime() => throw null;

    [ContextMenu("Reset Distance")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTelemetryDefaultProvider() => throw null;
  }
}
