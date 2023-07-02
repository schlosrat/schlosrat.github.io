// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Brakes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Brakes
  {
    public float brakeInput;
    public float handbrakeInput;
    public float stateAvailableRetaderTorque;
    public Brakes.Settings settings;
    public Brakes.AbsSettings absSettings;
    private List<Brakes.WheelData> m_wheelData;
    private float m_absActivationTime;

    public bool sensorAbsEngaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorOnDemandRetarderTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakePressure
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Brakes.AbsOverride absOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWheel(
      VehicleBase.WheelState wheelState,
      Wheel wheel,
      float relPosition = 0.0f,
      Brakes.LateralPosition lateralPosition = Brakes.LateralPosition.Undefined)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWheel(
      VehicleBase.WheelState wheelState,
      Wheel wheel,
      Brakes.BrakeCircuit circuit,
      Brakes.LateralPosition lateralPosition = Brakes.LateralPosition.Undefined)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddBrakeRatio(
      float ratio,
      Brakes.BrakeCircuit circuit,
      Brakes.LateralPosition lateralPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetValvePressureRatio(Brakes.WheelData wd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Brakes() => throw null;

    public enum BrakeCircuit
    {
      Neutral,
      Front,
      Rear,
      NoBrakes,
    }

    public enum LateralPosition
    {
      Undefined,
      Left,
      Right,
    }

    public enum AbsMode
    {
      Simple,
      MultiPosition,
      Continuous,
    }

    public enum AbsTrigger
    {
      PeakSlipOffset,
      CustomSlip,
    }

    public enum AbsOverride
    {
      None,
      ForceEnabled,
      ForceDisabled,
    }

    [Serializable]
    public class Settings
    {
      public float maxBrakeTorque;
      [Range(0.0f, 1f)]
      public float brakeBias;
      public float handbrakeTorque;
      [Range(0.0f, 1f)]
      public float handbrakeAxle;
      public bool combinedRetarderBrake;
      [Range(0.0f, 1f)]
      public float fullBrakeThreshold;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    [Serializable]
    public class AbsSettings
    {
      public bool enabled;
      public Brakes.AbsMode mode;
      public Brakes.AbsTrigger trigger;
      public float minSlipOffset;
      public float maxSlipOffset;
      public float minSlip;
      public float maxSlip;
      [Range(0.0f, 1f)]
      public float minPressureRatio;
      [Range(2f, 8f)]
      public int valvePositions;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AbsSettings() => throw null;
    }

    private class WheelData
    {
      public float positionRatio;
      public Wheel wheel;
      public VehicleBase.WheelState wheelState;
      public Brakes.LateralPosition lateralPosition;
      public float externalBrakeRatio;
      public float brakeRatio;
      public float handbrakeRatio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WheelData() => throw null;
    }
  }
}
