// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Engine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Engine : Block
  {
    public float throttleInput;
    public float clutchInput;
    public int ignitionInput;
    public float allowedFuelRatio;
    public float tcsRpms;
    public float tcsRatio;
    public float tcsThrottleFactor;
    public bool autoRpms;
    public float targetRpms;
    public Engine.Settings settings;
    public Engine.ClutchSettings clutchSettings;
    public static float KwToHp;
    public float damping;
    private Block.Connection m_output;
    private bool m_sensorStalled;
    private float m_sensorFlywheelTorque;
    private float m_sensorLoad;
    private float m_sensorPower;
    private float m_sensorClutchLock;
    private float m_sensorFuelRate;
    private bool m_sensorTcsEngaged;
    private Engine.StateVars m_stateVars;
    private float T;
    private float Tr;
    private float m_throttle;
    private BiasedRatio m_lockRatioBias;
    private BiasedRatio m_throttleMapBias;
    private float m_extraFrictionTorque;
    public float tempDebug1;
    public float tempDebug2;

    public float sensorRpm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorStalled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorWorking
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorStarting
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorFlywheelTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorOutputTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorPower
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorRpmLimiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool sensorTcsEngaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorFuelRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorLoad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorClutchLock
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetEngineSpecifications(ref Engine.EngineSpecs data, float deltaRpm = -1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateTorque(float rpm, float throttle = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculatePowerInKw(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateSpecificFuelConsumption(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateInstantFuelConsumption(float speed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float AddFrictionTorque(float frictionTorque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFrictionTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Engine.StateVars GetStateVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStateVars(Engine.StateVars stateVars) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxPowerTorqueRaw(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ClampPowerTorque(float powerTorque, float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxPowerTorque(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetFrictionTorque(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxFuelRate(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ThrottleMap(float throttleInput, float rpm) => throw null;

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
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeLockingTorque(float flywheelTorque, float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Engine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Engine() => throw null;

    public enum IdleControlType
    {
      Passive,
      Active,
    }

    public enum ClutchType
    {
      LockRatio,
      FrictionDisc,
      TorqueConverter,
      TorqueConverterLimited,
    }

    public enum RpmLimiterMode
    {
      InjectionCut,
      InjectionLimit,
    }

    [Serializable]
    public class Settings : ISerializationCallbackReceiver
    {
      public float idleRpm;
      public float peakRpm;
      public float maxRpm;
      public float idleRpmTorque;
      public float peakRpmTorque;
      [Range(0.0f, 1f)]
      public float idleRpmCurveBias;
      [Range(0.0f, 1f)]
      public float peakRpmCurveBias;
      public float inertia;
      public float frictionTorque;
      [Range(0.0f, 3f)]
      public float rotationalFriction;
      [Range(0.0f, 0.2f)]
      public float viscousFriction;
      public bool torqueCap;
      public float torqueCapLimit;
      public bool rpmLimiter;
      public Engine.RpmLimiterMode rpmLimiterMode;
      public float rpmLimiterMax;
      [Range(0.0f, 1f)]
      public float rpmLimiterCutoffTime;
      public Engine.IdleControlType idleControl;
      [Range(0.0f, 1f)]
      public float maxIdleThrottle;
      [Range(0.0f, 1f)]
      public float activeIdleRange;
      [Range(0.0001f, 0.9999f)]
      public float activeIdleBias;
      public bool canStall;
      [Range(0.0f, 1f)]
      public float stallBias;
      public float stalledFrictionTorque;
      [Range(0.0f, 1f)]
      public float starterMotorBias;
      public float maxFuelPerRev;
      public float fuelDensity;
      public float fuelConsumptionCorrection;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ApplyConstraints() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void OnBeforeSerialize() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void OnAfterDeserialize() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    [Serializable]
    public class ClutchSettings
    {
      public Engine.ClutchType type;
      public float maxTorqueTransfer;
      public float unlockRpm;
      public float lockRpm;
      [Range(0.001f, 0.999f)]
      public float lockRatioBias;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ClutchSettings() => throw null;
    }

    public struct EngineSpecs
    {
      public float idleRpm;
      public float maxTorqueAtIdle;
      public float frictionTorqueAtIdle;
      public float peakRpm;
      public float maxTorqueAtPeak;
      public float frictionTorqueAtPeak;
      public float specificFuelConsumption;
      public float specificFuelConsumptionRpm;
      public float maxPowerRpm;
      public float maxPowerInKw;
      public float maxPowerInHp;
      public float limitRpm;
      public float frictionTorqueAtLimit;
      public float stallRpm;
      public float frictionTorqueAtStall;
      public bool malformedTorque;
      public bool malformedRawPower;
    }

    [Serializable]
    public struct StateVars
    {
      public float L;
      public float Treaction;
      public bool rpmLimiterActive;
      public float rpmLimiterTime;
      public float tcsActivationTime;
    }
  }
}
