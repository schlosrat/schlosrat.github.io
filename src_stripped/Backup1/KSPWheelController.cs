// Decompiled with JetBrains decompiler
// Type: KSPWheelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using VehiclePhysics;

[DisallowMultipleComponent]
public class KSPWheelController : VehicleBase
{
  [Header("KSP Wheel Controller")]
  public VPWheelCollider WheelCollider;
  public TireFriction TireFriction;
  public float MaxDriveTorque;
  public float MaxBrakeTorque;
  public float MaxBrakeTorqueRest;
  public float MaxSteerAngle;
  public float MaxRpm;
  public float WheelDamping;
  public Rigidbody tgtRb;
  public bool KeyboardSteering;
  public bool KeyboardDrive;
  public bool KeyboardBrakes;
  [Range(-1f, 1f)]
  public float DriveInput;
  [Range(0.0f, 1f)]
  public float BrakeInput;
  [Range(-1f, 1f)]
  public float SteerInput;
  [Range(0.1f, 100f)]
  public float SteeringResponse;
  [Range(0.1f, 100f)]
  public float DriveResponse;
  [Range(0.1f, 100f)]
  public float BrakeResponse;
  public float DriveState;
  public float SteerState;
  public float BrakeState;
  public Transform WcTransform;
  protected DirectDrive m_directDrive;
  private bool init;
  public Func<VehicleBase.WheelState, bool> OnShouldIgnoreForces;

  public Rigidbody rb
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool IsGrounded
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 SuspensionAxis
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Rigidbody RbTgt
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public VehicleBase.WheelState currentState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float LegacyWheelLoad
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static KSPWheelController Create(
    RigidbodyBehavior rb,
    GameObject host,
    GameObject wheelColliderHost)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetRigidbodyTarget(Rigidbody tgt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnInitialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void DoUpdateBlocks() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelTransform(Vector3 position, Quaternion rotation) => throw null;

  public Vector3 WheelCenter
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float WheelRadius
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 WheelDown
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 WheelBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPWheelController() => throw null;
}
