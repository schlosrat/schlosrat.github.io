// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.StabilityControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class StabilityControl
  {
    public StabilityControl.Settings settings;
    public float wheelbase;
    public float stateVehicleSpeed;
    public float stateVehicleSpeedAngle;
    public float stateVehicleRotationRate;
    public float stateVehicleSteeringAngle;
    private float m_espBrakeFL;
    private float m_espBrakeFR;
    private float m_espBrakeRL;
    private float m_espBrakeRR;

    public bool sensorEngaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorUndersteerL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorUndersteerR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorOversteerL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorOversteerR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeFL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeFR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeRL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeRR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public StabilityControl.Override escOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StabilityControl() => throw null;

    [Serializable]
    public class Settings
    {
      public bool enabled;
      public float minSpeed;
      public float understeerMinRate;
      public float understeerMaxRate;
      public float understeerMinSpeed;
      public float oversteerMinAngle;
      public float oversteerMaxAngle;
      public float oversteerMinSpeed;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    public enum Override
    {
      None,
      ForceEnabled,
      ForceDisabled,
    }
  }
}
