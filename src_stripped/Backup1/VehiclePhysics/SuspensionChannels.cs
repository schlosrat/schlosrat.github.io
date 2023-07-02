// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SuspensionChannels
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class SuspensionChannels : Telemetry.ChannelGroup
  {
    private VehicleBase.WheelState m_wheelFL;
    private VehicleBase.WheelState m_wheelFR;
    private VehicleBase.WheelState m_wheelRL;
    private VehicleBase.WheelState m_wheelRR;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float GetPollFrequency() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetChannelCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetChannelInfo(Telemetry.ChannelInfo[] channelInfo, Object instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PollValues(float[] values, int index, Object instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SuspensionChannels() => throw null;
  }
}
