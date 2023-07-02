// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.VesselState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
