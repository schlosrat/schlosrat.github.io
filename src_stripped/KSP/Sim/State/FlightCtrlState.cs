// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.FlightCtrlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.State
{
  public struct FlightCtrlState
  {
    public static readonly FlightCtrlState identity;
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
    public bool brakes;
    public bool stage;
    public bool prelaunchInitiated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlState(FlightCtrlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlState(SerializedFlightControlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(FlightCtrlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(SerializedFlightControlState src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(FlightCtrlState x, FlightCtrlState y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(FlightCtrlState x, FlightCtrlState y) => throw null;

    public bool isIdle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isNeutral
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlStateIncremental MakeIncrementalDiff(FlightCtrlState todiff) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CutThrottle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Neutralize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NeutralizeStick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTrim() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NeutralizeAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPitchRollYaw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPitchRollYawInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetXYZ() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetWheels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FlightCtrlState() => throw null;
  }
}
