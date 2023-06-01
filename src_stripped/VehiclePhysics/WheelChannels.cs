// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.WheelChannels
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class WheelChannels : Telemetry.ChannelGroup
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
    public WheelChannels() => throw null;
  }
}
