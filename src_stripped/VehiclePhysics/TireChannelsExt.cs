// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TireChannelsExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class TireChannelsExt : Telemetry.ChannelGroup
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
    public TireChannelsExt() => throw null;
  }
}
