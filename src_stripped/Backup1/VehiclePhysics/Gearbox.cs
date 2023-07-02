// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Gearbox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  public class Gearbox : Block
  {
    public int manualGearInput;
    public int automaticGearInput;
    public int gearShiftInput;
    public bool bypassAutoShift;
    public float stateVehicleSpeed;
    public float stateVehicleBrakes;
    public float stateVehicleThrottle;
    public Action signalSwitchingGears;
    public Gearbox.Settings settings;
    public float inputToRpmRatio;
    public float damping;
    public float pedalSoftPressThreshold;
    public float pedalHardPressThreshold;
    public float inverseSpeedThreshold;
    public float vehicleMovingThresholdMin;
    public float vehicleMovingThresholdMax;
    private Block.Connection m_input;
    private Block.Connection m_output;
    private float I;
    private float T;
    private Gearbox.StateVars m_stateVars;
    private bool m_isSwitchingGears;

    public int sensorGearMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int sensorEngagedGear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorSwitchingGears
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorOutputRpm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gearbox.AutoShiftOverride autoShiftOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetCurrentGearRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetGearRatio(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Gearbox.StateVars GetStateVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStateVars(Gearbox.StateVars stateVars) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PreStep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetState(ref Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSubstepState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanEngageParkMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanDisengageParkMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GearRatio(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ClampGear(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ClampReverseGear(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ClampForwardGear(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int EngagedGear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSwitchingGears() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShiftGearUp(float inRpm, float outRpm, float shiftUpRpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShiftGearDown(float inRpm, float outRpm, float shiftDownRpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetAutoShiftGearShiftRanges(out float gearUpRevs, out float gearDownRevs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoAutoShiftLogic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StandardProcessInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StandardComputeState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StandardEvaluateTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetAutomaticGearShiftRanges(out float gearUpRevs, out float gearDownRevs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int DoAutomaticForwardGearSelection(int currentGear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int DoAutomaticReverseGearSelection(int currentGear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlanetaryProcessInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlanetaryComputeState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlanetaryEvaluateTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StateTransitionFromZeroToGear(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StateTransitionFromGearToZero(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StateTransitionFromGearToGear(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TorqueTransitionFromZeroToGear(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TorqueTransitionFromGearToZero(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TorqueTransitionFromGearToGear(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Gearbox() => throw null;

    public enum Type
    {
      Manual,
      Automatic,
    }

    public enum AutomaticGear
    {
      M,
      P,
      R,
      N,
      D,
      L,
      _Count,
    }

    [Serializable]
    public class Settings
    {
      public Gearbox.Type type;
      public float[] forwardGearRatios;
      public float[] reverseGearRatios;
      public float auto2ndGearMinSpeed;
      public bool parkRequiresStopAndBrakes;
      public bool allowParkInManual;
      [Range(0.0f, 2f)]
      public float manualShiftTime;
      public bool autoShift;
      public float autoShiftNeutralRpm;
      public float autoShiftFirstGearRpm;
      public float autoShiftDownRevs;
      public float autoShiftUpRevs;
      public bool autoShiftThrottleSens;
      public float autoShiftThrottleSensMin;
      public float autoShiftFullThrottleDownRevs;
      public float autoShiftFullThrottleUpRevs;
      [Range(0.0f, 2f)]
      public float autoShiftUpInterval;
      [Range(0.0f, 2f)]
      public float autoShiftDownInterval;
      [Range(0.0f, 2f)]
      public float automaticTransitionTime;
      [Range(0.0f, 2f)]
      public float automaticShiftInterval;
      public float automaticGearDownRevs;
      public float automaticGearUpRevs;
      public bool automaticThrottleSens;
      public float automaticThrottleSensMin;
      public float automaticFullThrottleGearDownRevs;
      public float automaticFullThrottleGearUpRevs;
      public bool automaticGearUpRequiresThrottle;
      public bool automaticShiftReverseGears;
      [FormerlySerializedAs("automaticStartGear")]
      public int automaticInitialGearForward;
      public int automaticInitialGearReverse;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    public enum AutoShiftOverride
    {
      None,
      ForceAutoShift,
      ForceManualShift,
    }

    [Serializable]
    public struct StateVars
    {
      public float L;
      public int manualGear;
      public float manualRatio;
      public bool engaged;
      public float lastEngagedTime;
      public float lastAutoShiftTime;
      public bool vehicleMoving;
      public Gearbox.AutomaticGear gearMode;
      public int automaticGear;
      public float automaticRatio;
      public bool transition;
      public float transitionStartedTime;
      public int fromGear;
      public int toGear;
      public float fromRatio;
      public float toRatio;
      public float transitionRatio;
    }
  }
}
