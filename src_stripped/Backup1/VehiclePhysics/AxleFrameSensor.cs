// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.AxleFrameSensor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class AxleFrameSensor
  {
    private AxleFrameSensor.WheelData m_leftWheel;
    private AxleFrameSensor.WheelData m_rightWheel;
    private Transform m_reference;
    private Vector3 m_midPoint;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(VehicleBase vehicle, int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate(Transform reference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRideHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRollAngle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAbsRollAngle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (Vector3, Vector3) GetContactPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetMidPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateContactPoint(ref AxleFrameSensor.WheelData wheelData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxleFrameSensor() => throw null;

    private struct WheelData
    {
      public VehicleBase.WheelState wheelState;
      public Vector3 contactPoint;
    }
  }
}
