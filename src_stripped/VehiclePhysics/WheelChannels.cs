// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.WheelChannels
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
