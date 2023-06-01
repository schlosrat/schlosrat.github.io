// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.VesselState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct VesselState
  {
    public double? launchTime;
    public string landedAtBase;
    public double? landedAtBaseTime;
    public FlightCtrlStateIncremental? flightCtrlState;
    public SpeedDisplayMode? speedMode;
    public SpeedDisplayMode? autoSpeedMode;
    public AltimeterDisplayMode? altimeterMode;
    public AutopilotMode? autopilotMode;
    public bool? autoPilotState;
    public bool? isKerbalEVA;
    public bool? isRCSEnabled;
    public FlightControlsMode? flightControlsMode;
    public ActionGroupStates? actionGroupStates;
    public KSP.Sim.PhysicsMode? PhysicsMode;
    public IGGuid currentTargetID;
    public OABProvider.LaunchLocation launchLocation;
    public List<VesselComponent.SubVesselData> SubVessels;
    public VesselSituations? Situation;
    public VesselControlState? ControlState;
    public CommandControlState? CommandModulesState;
    public IGGuid? CurrentControlOwnerPart;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VesselState GetDefaultStateOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VesselState GetDefaultStateGround() => throw null;
  }
}
