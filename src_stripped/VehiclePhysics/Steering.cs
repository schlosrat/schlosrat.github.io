// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Steering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Steering
  {
    public float steerInput;
    public Steering.Settings settings;
    private List<Steering.WheelData> m_wheels;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWheel(
      VehicleBase.WheelState wheelState,
      Vector3 localPosition,
      Steering.SteeringMode steeringMode,
      float steerRatio = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWheel(VehicleBase.WheelState wheelState, Vector3 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculateRelativeSteerRatios() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringAngle(Steering.WheelData wd, float steerAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Steering() => throw null;

    public enum SteeringMode
    {
      Disabled,
      Steerable,
      Ratio,
      Reference,
    }

    [Serializable]
    public class Settings
    {
      [Range(0.0f, 90f)]
      public float maxSteerAngle;
      [Range(-15f, 15f)]
      public float toeAngle;
      public bool ackerman;
      public Transform ackermanReference;
      public Transform ratioReference;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    private class WheelData
    {
      public VehicleBase.WheelState wheelState;
      public Vector3 position;
      public Steering.SteeringMode mode;
      public float ratio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WheelData() => throw null;
    }
  }
}
