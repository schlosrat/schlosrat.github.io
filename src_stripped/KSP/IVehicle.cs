// Decompiled with JetBrains decompiler
// Type: KSP.IVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
