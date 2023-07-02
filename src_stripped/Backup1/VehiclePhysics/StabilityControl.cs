// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.StabilityControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
