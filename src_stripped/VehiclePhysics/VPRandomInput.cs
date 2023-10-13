// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPRandomInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
