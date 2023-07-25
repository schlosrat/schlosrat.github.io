// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPRandomInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPRandomInput : VehicleBehaviour
  {
    public float steerInterval;
    public float steerIntervalTolerance;
    public float steerChangeRate;
    [Range(0.0f, 1f)]
    public float steerStraightRandom;
    [Space(5f)]
    public float throttleInterval;
    public float throttleIntervalTolerance;
    public float throttleChangeRate;
    [Range(0.0f, 1f)]
    public float throttleForwardRandom;
    private float m_targetSteer;
    private float m_nextSteerTime;
    private float m_targetThrottle;
    private float m_targetBrake;
    private float m_nextThrottleTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPRandomInput() => throw null;
  }
}
