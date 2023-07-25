// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPSegmentedSpeedGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Segmented Speed Gauge", 21)]
  public class VPSegmentedSpeedGauge : VehicleBehaviour
  {
    public Transform speedGauge;
    public VPSegmentedSpeedGauge.SpeedMark[] speedMarks;
    private InterpolatedFloat m_speedMs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPSegmentedSpeedGauge() => throw null;

    [Serializable]
    public class SpeedMark
    {
      public float speedKph;
      public float angle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SpeedMark() => throw null;
    }
  }
}
