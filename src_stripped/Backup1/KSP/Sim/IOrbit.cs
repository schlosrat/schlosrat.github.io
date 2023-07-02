// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IOrbit
  {
    CelestialBodyComponent referenceBody { get; }

    Position Position { get; }

    ITransformFrame ReferenceFrame { get; }

    Vector3d localPosition { get; }

    ICoordinateSystem coordinateSystem { get; }

    Vector relativeVelocity { get; }

    IMotion relativeToMotion { get; }

    CelestialFrame OrbitFrame { get; }

    Vector3d SpecificAngularMomentum { get; }

    OrbitMarkerHandler OrbitMarkerHandler { get; }

    double Periapsis { get; }

    double Apoapsis { get; }

    double PeriapsisArl { get; }

    double ApoapsisArl { get; }

    Position GetTruePositionAtUT(double universalTime);

    Vector3d GetTruePositionAtUT(double universalTime, ICoordinateSystem coordinateSystem);

    Position GetTruePositionAtT(double universalTime);

    Vector3d GetTruePositionAtT(double universalTime, ICoordinateSystem coordinateSystem);

    Vector3d GetRelativePositionAtUT(double UT);

    Vector3d GetVel(VesselComponent relativeVessel);

    Vector3d GetOrbitalVelocityAtUTZup(double UT);

    Vector3d GetRelativePositionAtUTZup(double UT);

    Vector3d GetRelativePositionFromEccAnomaly(double eccentricAnomaly);

    double GetOrbitalStateVectorsAtUT(
      double UT,
      out Vector3d localPositionZup,
      out Vector3d relativeVelocityZup);

    double SolveClosestApproach(
      IKeplerOrbit s,
      ref double UT,
      double dT,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount);

    bool SolveSOI_BSP(
      IKeplerOrbit secondaryKeplerOrbit,
      ref double UT,
      double dT,
      double Rsoi,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount);

    double GetTimeToPeriapsis();

    void UpdateFromUT(double UT);

    void InitializeMarkerHandler();

    void DisposeMarkerHandler();

    void SetReferenceBody(CelestialBodyComponent body);
  }
}
