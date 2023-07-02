// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedFlightControlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedFlightControlState
  {
    public float mainThrottle;
    public float roll;
    public float yaw;
    public float pitch;
    public float rollTrim;
    public float yawTrim;
    public float pitchTrim;
    public float inputRoll;
    public float inputYaw;
    public float inputPitch;
    public float wheelSteer;
    public float wheelSteerTrim;
    public float wheelThrottle;
    public float wheelThrottleTrim;
    public float X;
    public float Y;
    public float Z;
    public bool killRot;
    public bool gearUp;
    public bool gearDown;
    public bool headlight;
    public bool stage;
    public bool brakes;
    public bool prelaunchInitiated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedFlightControlState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedFlightControlState(SerializedFlightControlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedFlightControlState(FlightCtrlState flightCtrlState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(SerializedFlightControlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(FlightCtrlState flightCtrlState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
