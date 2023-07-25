// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedConicsOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Map.impl;
using KSP.Sim.Converters;
using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PatchedConicsOrbit : 
    IPatchedOrbit,
    IOrbit,
    IDisposable,
    IComparable<IPatchedOrbit>,
    IKeplerOrbit,
    IDynamicOrbit
  {
    private CelestialBodyComponent _referenceBody;
    public OrbitalElements OrbitalElements;
    public ReferenceBodyConstants ReferenceBodyConstants;
    public const double Rad2Deg = 57.295779513082323;
    public const double Deg2Rad = 0.017453292519943295;
    private CelestialFrame orbitFrame;
    private Velocity _orbitalMomentum;
    public double meanMotion;
    private IUniverseModel universeModel;
    public PatchedConicsOrbit.FindClosestPointsDelegate findClosestPoints;
    private PatchedConicsOrbit.SolveClosestApproachDelegate solveClosestApproachDelegate;
    private PatchedConicsOrbit.SolveSOI_BSPDelegate solveSOI_BSP;

    [TypeConverterIgnore]
    public CelestialBodyComponent referenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double inclination
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double eccentricity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double semiMajorAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double longitudeOfAscendingNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double argumentOfPeriapsis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double meanAnomalyAtEpoch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double epoch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double period
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public CelestialFrame OrbitFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d relativeVelocityZup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Velocity SpecificAngularMomentumVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double OrbitalEnergy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double MeanAnomaly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double TrueAnomaly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double EccentricAnomaly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double altitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double orbitalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double orbitPercent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double ObT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double ObTAtEpoch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double TimeToPe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double TimeToAp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d SpecificAngularMomentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public OrbitMarkerHandler OrbitMarkerHandler
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d eccVec
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d an
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double SemiMinorAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double SemiLatusRectum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double Periapsis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double Apoapsis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double PeriapsisArl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public double ApoapsisArl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedConicsOrbit(IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeplerOrbitState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ValidateState(KeplerOrbitState stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(
      OrbitalElements newElements,
      string referenceBodyGuid,
      ISimulationModelMap simulationModelMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeMarkerHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeMarkerHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceBody(CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMeanMotion(double sma) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double SafeAcos(double c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromOrbitAtUT(IOrbit orbit, double UT, CelestialBodyComponent toBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3d GetVelocityAtUTInStarSpace(IOrbit orbit, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3d GetVelocityAtUTInStarSpace(
      IOrbit orbit,
      double UT,
      ref QuaternionD localToFixedRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3d GetPositionAtUTInStarSpace(IOrbit orbit, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3d GetPositionAtUTInStarSpace(
      IOrbit orbit,
      double UT,
      ref QuaternionD localToFixedRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CelestialBodyComponent GetStar(CelestialBodyComponent referenceBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromStateVectors(
      Position position,
      Velocity velocity,
      CelestialBodyComponent refBody,
      double UT)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFromStateVectors(
      Vector3d posInRefBodySpace,
      Vector3d velInRefBodySpace,
      CelestialBodyComponent refBody,
      double UT)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetStateVectorsFromUT(double UT, out Vector3d pos, out Vector vel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDTforTrueAnomaly(double trueAnomaly, double wrapAfterSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetUTforTrueAnomaly(double trueAnomaly, double wrapAfterSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtUT(double UT, ICoordinateSystem targetCoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtT(double obT, ICoordinateSystem targetCoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtT(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetOrbitalVelocityAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetObtAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeOrbitNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeEccVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeANVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetVel(VesselComponent relativeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetFrameVelZup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetFrameVelAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTimeToPeriapsis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetEccentricAnomaly(double trueAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMeanAnomaly(double eccentricAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RadiusAtTrueAnomaly(double trueAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double TrueAnomalyAtRadius(double R) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double TrueAnomalyAtRadiusExtreme(double R) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double TrueAnomalyAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double TrueAnomalyAtObT(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double EccentricAnomalyAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double EccentricAnomalyAtObT(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double SolveEccentricAnomaly(
      double meanAnomaly,
      double orbitEccentricity,
      double maxError = 1E-07,
      int maxIterations = 8)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double SolveEccentricAnomalyStd(
      double meanAnomaly,
      double orbitEccentricity,
      double maxError = 1E-07)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double SolveEccentricAnomalyExtremeEcc(
      double meanAnomaly,
      double orbitEccenricity,
      int iterations = 8)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double SolveEccentricAnomalyHyp(
      double meanAnomaly,
      double orbitEccenricity,
      double maxError = 1E-07)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTrueAnomaly(double eccentricAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTrueAnomalyOfZupVector(Vector3d vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionAtObT(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetRelativePositionAtObTZup(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionFromEccAnomaly(double eccentricAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetRelativePositionFromEccAnomalyZup(double eccentricAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionFromEccAnomalyWithSemiMinorAxis(
      double eccentricAnomaly,
      double semiMinorAxis)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetRelativePositionFromEccAnomalyWithSemiMinorAxisZup(
      double eccentricAnomaly,
      double semiMinorAxis)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionFromTrueAnomaly(double trueAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionFromTrueAnomalyZup(double trueAnomalyA) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalSpeedAtDistance(double d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetOrbitalVelocityAtObTZup(double obT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetOrbitalVelocityAtTrueAnomaly(double trueAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalStateVectorsAtUT(
      double UT,
      out Vector3d localPositionZup,
      out Vector3d relativeVelocityZup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalStateVectorsAtObT(
      double ObT,
      double UT,
      out Vector3d localPositionZup,
      out Vector3d relativeVelocityZup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalStateVectorsAtTrueAnomaly(
      double trueAnomaly,
      double UT,
      out Vector3d localPositionZup,
      out Vector3d relativeVelocityZup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalCurvatureAtTrueAnomaly(double trueAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PeApIntersects(IKeplerOrbit secondary, double threshold) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindClosestPoints(
      IKeplerOrbit s,
      ref double CD,
      ref double CCD,
      ref double FFp,
      ref double FFs,
      ref double SFp,
      ref double SFs,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int _FindClosestPoints(
      IKeplerOrbit s,
      ref double CD,
      ref double CCD,
      ref double FFp,
      ref double FFs,
      ref double SFp,
      ref double SFs,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void process_intercept(
      Targeting.Sample cept,
      out double Vp,
      out double Vs,
      out double D)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindClosestPoints_old(
      IKeplerOrbit p,
      IKeplerOrbit s,
      ref double CD,
      ref double CCD,
      ref double FFp,
      ref double FFs,
      ref double SFp,
      ref double SFs,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double SolveClosestBsp(
      ref double Fp,
      ref double Fs,
      double Ir,
      double dF,
      IKeplerOrbit p,
      IKeplerOrbit s,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SolveClosestApproach(
      IKeplerOrbit s,
      ref double UT,
      double dT,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double _SolveClosestApproach(
      IKeplerOrbit s,
      ref double UT,
      double dT,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SolveSOI_BSP(
      IKeplerOrbit secondaryKeplerOrbit,
      ref double UT,
      double dT,
      double Rsoi,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool _SolveSOI_BSP(
      IKeplerOrbit secondaryOrbit,
      ref double UT,
      double dT,
      double Rsoi,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount)
    {
      throw null;
    }

    [TypeConverterIgnore]
    public int numClosePoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double TrueAnomalyFirstEncounterPriOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double TrueAnomalyFirstEncounterSecOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double TrueAnomalySecEncounterPriOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double TrueAnomalySecEncounterSecOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double UniversalTimeAtClosestApproach
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double UniversalTimeAtSoiEncounter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double ClosestApproachDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double ClEctr1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double ClEctr2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double timeToTransition1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double timeToTransition2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double nearestTT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double nextTT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public Position secondaryPosAtTransition1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public Position secondaryPosAtTransition2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double closestTgtApprUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double collisionPointUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double StartUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double EndUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double StartTrueAnomaly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public double EndTrueAnomaly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public bool ActivePatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public PatchedConicsOrbit closestEncounterPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public CelestialBodyComponent closestEncounterBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public EncounterSolutionLevel closestEncounterLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public PatchTransitionType PatchStartTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public PatchTransitionType PatchEndTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public IPatchedOrbit NextPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public IPatchedOrbit PreviousPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(IPatchedOrbit other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    public delegate int FindClosestPointsDelegate(
      IKeplerOrbit s,
      ref double CD,
      ref double CCD,
      ref double FFp,
      ref double FFs,
      ref double SFp,
      ref double SFs,
      double epsilon,
      int maxIterations,
      ref int iterationCount);

    private delegate double SolveClosestApproachDelegate(
      IKeplerOrbit s,
      ref double UT,
      double dT,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount);

    private delegate bool SolveSOI_BSPDelegate(
      IKeplerOrbit s,
      ref double UT,
      double dT,
      double Rsoi,
      double MinUT,
      double MaxUT,
      double epsilon,
      int maxIterations,
      ref int iterationCount);
  }
}
