// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAxle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  [Serializable]
  public class VPAxle
  {
    public VPWheelCollider leftWheel;
    public VPWheelCollider rightWheel;
    public Brakes.BrakeCircuit brakeCircuit;
    public Steering.SteeringMode steeringMode;
    public float steeringRatio;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAxle() => throw null;
  }
}
