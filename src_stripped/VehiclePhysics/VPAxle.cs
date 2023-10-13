// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAxle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
