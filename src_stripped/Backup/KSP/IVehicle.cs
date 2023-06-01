// Decompiled with JetBrains decompiler
// Type: KSP.IVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System;

namespace KSP
{
  public interface IVehicle
  {
    bool CanPlayerControl(byte playerId);

    VesselComponent GetSimVessel(bool requireValidInSim = true);

    SimulationObjectModel GetSimulationObject(bool requireValidInSim = true);

    bool IsValidInSim { get; }

    IGGuid Guid { get; }

    Position Position { get; }

    IFlightControlInput FlightControlInput { get; }

    IOrbitControlInput OrbitControlInput { get; }

    bool IsLandedOrSplashed { get; }

    CelestialBodyComponent MainBody { get; }

    SpeedDisplayMode SpeedDisplayMode { get; }

    AltimeterDisplayMode AltimeterDisplayMode { get; }

    FlightControlsMode FlightControlsMode { get; }

    IControllableInput ControllableInput { get; }

    IFlightControllableInput FlightControllableInput { get; }

    IOrbitControllableInput OrbitControllableInput { get; }

    IControllableActionGroups ControllableActionGroups { get; }

    void SetSpeedDisplayMode(SpeedDisplayMode value, Action<string> callback = null);

    void SetAltimeterDisplayMode(AltimeterDisplayMode value, Action<string> callback = null);

    void SetFlightControlsMode(FlightControlsMode value, Action<string> callback = null);
  }
}
