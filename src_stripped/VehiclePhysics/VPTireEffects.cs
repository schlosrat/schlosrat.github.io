// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Tire Effects", 3)]
  public class VPTireEffects : VehicleBehaviour
  {
    public float tireWidth;
    public float minSlip;
    public float maxSlip;
    [Header("Tire marks")]
    [Range(0.0f, 2f)]
    public float intensity;
    public float updateInterval;
    [Header("Smoke")]
    public float minIntensityTime;
    public float maxIntensityTime;
    public float limitIntensityTime;
    private VPTireEffects.TireFxData[] m_tireData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnReposition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTireMarks(VehicleBase.WheelState wheelState, VPTireEffects.TireFxData fxData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTireParticles(
      VehicleBase.WheelState wheelState,
      VPTireEffects.TireFxData fxData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTireEffects() => throw null;

    public class TireFxData
    {
      public VPGroundMarksRenderer lastRenderer;
      public int lastMarksIndex;
      public float marksDelta;
      public VPGroundParticleEmitter lastEmitter;
      public float lastParticleTime;
      public float slipTime;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TireFxData() => throw null;
    }
  }
}
