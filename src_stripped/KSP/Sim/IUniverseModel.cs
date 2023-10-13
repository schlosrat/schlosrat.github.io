// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IUniverseModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;

namespace KSP.Sim
{
  public interface IUniverseModel
  {
    InertialFrame inertialReferenceFrame { get; }

    ILateUpdateDriver lateUpdateDriver { get; }

    double UniverseTime { get; }

    double UniverseTimeDelta { get; }

    string ViewPrefabAssetKey { get; }

    QuaternionD Rotation { get; set; }

    double InverseRotAngle { get; set; }

    CelestialFrame Zup { get; set; }

    void ZupAtUT(double UT, CelestialBodyComponent body, ref CelestialFrame tempZup);

    CelestialBodyComponent GetStar(Position position);

    CelestialBodyComponent GetStar(ICoordinateSystem coordinateSystem, Vector3d refPos);

    CelestialBodyComponent GetMainBody(Position refPos);

    CelestialBodyComponent GetMainBody(ICoordinateSystem referenceFrame, Vector3d localPosition);

    Vector GetGeeForceAtPosition(Position pos, CelestialBodyComponent mainBody);

    Vector GetGeeForceAtPosition(
      ICoordinateSystem coordinateSystem,
      Vector3d pos,
      CelestialBodyComponent mainBody);

    double GetAtmDensity(double pressure, double temperature, CelestialBodyComponent body);

    double GetStaticPressure(Position position);

    double GetStaticPressure(ICoordinateSystem coordinateSystem, Vector3d position);

    double GetStaticPressure(double altitude, CelestialBodyComponent body);

    double GetStaticPressure(Position position, CelestialBodyComponent body);

    double GetStaticPressure(
      ICoordinateSystem coordinateSystem,
      Vector3d position,
      CelestialBodyComponent body);

    double GetAltitudeAtPos(Position position, CelestialBodyComponent body);

    double GetAltitudeAtPos(
      ICoordinateSystem coordinateSystem,
      Vector3d position,
      CelestialBodyComponent body);

    Vector GetUpAxis(CelestialBodyComponent body, Position position);

    Vector GetUpAxis(
      CelestialBodyComponent body,
      ICoordinateSystem coordinateSystem,
      Vector3d position);

    double GetAltitudeAtPos(Position position);

    double GetAltitudeAtPos(ICoordinateSystem coordinateSystem, Vector3d position);

    Vector GetUpAxis(Position position);

    CelestialBodyComponent HomeWorld { get; }

    TransformModel GalacticOrigin { get; set; }

    VesselComponent FindVesselComponent(IGGuid guid);

    void SetUniverseTime(double universeTime, double deltaUT);

    bool AddSimulationObject(SimulationObjectModel model);

    void RemoveSimulationObject(SimulationObjectModel model);

    IEnumerable<SimulationObjectModel> SimulationObjects { get; }

    event Action<SimulationObjectModel> onSimulationObjectAdded;

    event Action<SimulationObjectModel> onSimulationObjectRemoved;

    bool AddCelestialBody(CelestialBodyComponent celestialBody);

    void RemoveCelestialBody(CelestialBodyComponent celestialBody);

    int CelestialBodiesCount { get; }

    event Action<CelestialBodyComponent> onCelestialBodyAdded;

    event Action<CelestialBodyComponent> onCelestialBodyRemoved;

    bool AddVessel(VesselComponent vessel);

    void RemoveVessel(VesselComponent vessel);

    bool AddKerbal(KerbalComponent kerbal);

    void RemoveKerbal(KerbalComponent kerbal);

    event Action<VesselComponent> onVesselAdded;

    event Action<VesselComponent> onVesselRemoved;

    void Reset();
  }
}
