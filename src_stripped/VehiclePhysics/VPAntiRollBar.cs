// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAntiRollBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Vehicle Dynamics/Anti-roll Bar", 20)]
  public class VPAntiRollBar : VehicleBehaviour
  {
    public int axle;
    public VPAntiRollBar.Mode mode;
    [Range(0.0f, 1f)]
    [Tooltip("Ratio of spring rate than may be transferred among wheels")]
    public float stiffness;
    [Tooltip("Spring rate per compression distance that gets transferred among wheels")]
    public float springRate;
    [Tooltip("Spring rate per compression ratio that gets transferred among wheels. This is the previously used mode, now discouraged.")]
    public float antiRollRate;
    [Obsolete("The rigidity parameter has been deprecated, has no effect, and will be removed from the component. Please remove your references in the code, it won't hurt. This parameter caused issues in the WheelCollider making the handling worse.")]
    public float rigidity;
    public bool emitTelemetry;
    private VehicleBase.WheelState m_leftState;
    private VPWheelCollider m_leftCollider;
    private VehicleBase.WheelState m_rightState;
    private VPWheelCollider m_rightCollider;

    public float leftCompression
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float rightCompression
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float leftSpringRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float rightSpringRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicleSuspension() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool EmitTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RegisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UnregisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAntiRollBar() => throw null;

    public enum Mode
    {
      Stiffness,
      SpringRate,
      Legacy,
    }

    private class AntiRollBarChannels : Telemetry.ChannelGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int GetChannelCount() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPollFrequency() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void GetChannelInfo(Telemetry.ChannelInfo[] channelInfo, UnityEngine.Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void PollValues(float[] values, int index, UnityEngine.Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AntiRollBarChannels() => throw null;
    }
  }
}
