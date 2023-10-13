// Decompiled with JetBrains decompiler
// Type: KSP.IVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
