// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.FlightCtrlStateIncremental
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct FlightCtrlStateIncremental
  {
    public float? mainThrottle;
    public float? roll;
    public float? yaw;
    public float? pitch;
    public float? rollTrim;
    public float? yawTrim;
    public float? pitchTrim;
    public float? inputRoll;
    public float? inputYaw;
    public float? inputPitch;
    public float? wheelSteer;
    public float? wheelSteerTrim;
    public float? wheelThrottle;
    public float? wheelThrottleTrim;
    public float? X;
    public float? Y;
    public float? Z;
    public bool? killRot;
    public bool? gearUp;
    public bool? gearDown;
    public bool? headlight;
    public bool? brakes;
    public bool? stage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlState ApplyTo(FlightCtrlState baseState) => throw null;
  }
}
