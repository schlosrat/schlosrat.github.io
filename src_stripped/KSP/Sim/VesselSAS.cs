// Decompiled with JetBrains decompiler
// Type: KSP.Sim.VesselSAS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [Serializable]
  public class VesselSAS
  {
    private const float SAS_TUNING_SCALAR = 1f;
    private VesselBehavior vesselView;
    private VesselComponent vessel;
    private ITransformModel storedTransform;
    public PIDclamp PidLockedPitch;
    public PIDclamp PidLockedRoll;
    public PIDclamp PidLockedYaw;
    private bool _sasEquippedVessel;
    private bool _FBWconnected;
    private bool _TBWconnected;
    private bool _NBWconnected;
    private bool _isStarted;
    private bool _dampingMode;
    private bool _lockedMode;
    public const float OVERRIDE_MINIMUM_MAGNITUDE = 0.1f;
    private bool _resetLastRotation;
    public QuaternionD LockedRotation;
    private ITransformFrame _referenceFrame;
    private QuaternionD currentRotation;
    private QuaternionD lastRotation;
    private Vector3d rotationDelta;
    private Vector3d angularDelta;
    private Vector3d angularDeltaRad;
    private Vector3d sasResponse;
    public static readonly Vector3d AUTO_SCALAR_MIN;
    public static readonly Vector3d AUTO_SCALAR_MAX;
    public bool AutoTune;
    private Vector3d autoScalar;
    private Vector3d torqueVector;
    private Vector3d angularAccelerationMax;
    public const float STOP_SCALAR = 1f;
    public const float COAST_SCALAR = 2f;
    public Vector3d TargetOrientation;
    private float neededPitch;
    private float neededYaw;
    public static readonly Vector3 DECAY_RESPONSE_THRESHOLD;
    public static readonly Vector3 DECAY_DELTA_THRESHOLD;
    public static readonly Vector3 DECAY_RATE;
    public static readonly Vector3 DECAY_MIN;
    public bool UseDecay;
    private bool decayLocked;
    private Vector3 decayScalar;
    public const int DAMPING_COOLDOWN = 20;
    private int dampingCooldownTimer;
    private bool pitchInput;
    private bool rollInput;
    private bool yawInput;

    private bool sasEquippedVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool FBWconnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool TBWconnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool NBWconnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool isStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool dampingMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool lockedMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselSAS(VesselBehavior vesselView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSasPIDs(Vector4d Pitch, Vector4d Roll, Vector4d Yaw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLockYawPID(float Kp, float Ki, float Kd, float clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLockRollPID(float Kp, float Ki, float Kd, float clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLockPitchPID(float Kp, float Ki, float Kd, float clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllPIDS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTuningScalars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TuneScalars(float scalar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanEngageSAS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LockRotation(Rotation newRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LockRotation(QuaternionD newRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SASUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckStoredTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdatePitchInput(ref FlightCtrlState playerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateRollInput(ref FlightCtrlState playerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateYawInput(ref FlightCtrlState playerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double EvaluateScalar(double ratio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AutoTuneScalar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AutoTuneReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetTotalVesselTorque(VesselBehavior v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMaximumAcceleration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMaxAngularAcceleration(double moi, double torque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVesselTorque(ref FlightCtrlState s, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDampingMode(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectFlyByWire(bool reset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectFlyByWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectThrottleByWire(bool reset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectThrottleByWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectNavigationByWire(bool reset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectNavigationByWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetOrientation(Vector tgtOrientation, bool reset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PitchYawAngle(
      ICoordinateSystem targetCoordinateSystem,
      Vector3 vectorInReferenceFrame,
      out float pitch,
      out float yaw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckCoasting(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StabilityDecay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Decayed(Vector3 decayScalar, Vector3 decayMin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KillAngularVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckDamping(ref FlightCtrlState playerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD GetRotationDelta() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double AngularTrim(double angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPhysicsSpaceProviderReferenceChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControlPointChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselControlOwnerChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD GetPhysicsRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ControlUpdate(ref FlightCtrlState s, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModuleSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VesselSAS() => throw null;
  }
}
