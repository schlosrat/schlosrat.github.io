// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPWheelFrameMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  public class VPWheelFrameMonitor : VehicleBehaviour
  {
    [Header("Axle references")]
    public Transform frontReference;
    public Transform rearReference;
    [Header("Telemetry")]
    public bool emitTelemetry;
    [Header("Debug")]
    public bool showDebugGizmos;
    [FormerlySerializedAs("showTelemetry")]
    public bool showDebugWidget;
    [FormerlySerializedAs("telemetrySettings")]
    public GUITextBox.Settings debugWidget;
    [HideInInspector]
    public Font defaultFont;
    private AxleFrameSensor m_frontAxleSensor;
    private AxleFrameSensor m_rearAxleSensor;
    private GUITextBox m_textBox;
    private StringBuilder m_text;

    public float frontRideHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float rearRideHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float frontRollAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float rearRollAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float groundSlope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float groundGrade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DebugGizmos(AxleFrameSensor axleSensor, Transform reference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool EmitTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RegisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UnregisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPWheelFrameMonitor() => throw null;

    public class ChassisChannels : Telemetry.ChannelGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int GetChannelCount() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPollFrequency() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void GetChannelInfo(Telemetry.ChannelInfo[] channelInfo, Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void PollValues(float[] values, int index, Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ChassisChannels() => throw null;
    }
  }
}
