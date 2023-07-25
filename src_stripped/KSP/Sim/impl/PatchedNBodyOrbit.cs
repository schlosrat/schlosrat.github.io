// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedNBodyOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace KSP.Sim.impl
{
  public class PatchedNBodyOrbit : 
    IPatchedOrbit,
    IOrbit,
    IDisposable,
    IComparable<IPatchedOrbit>,
    IDynamicOrbit
  {
    public const Allocator BURST_ALLOCATOR_TYPE = Allocator.Persistent;
    public const int MAX_ITERATIONS = 50;
    public const double TOLERANCE = 0.01;
    public PatchedNBody.OdeSolveJob OdeSolveJob;
    public int ErrorEstimateOrder;
    public int2 PShape;
    public NativeArray<double> AArray;
    public NativeArray<double> BArray;
    public NativeArray<double> CArray;
    public NativeArray<double> EArray;
    public NativeArray<double> PArray;
    public NativeArray<PatchedNBody.OdeState> KArray;
    public NativeList<PatchedNBody.CelestialBodyPositionJob.KeplerBody> OdeChildKeplerBodies;
    public NativeList<PatchedNBody.OdeState> QArray;
    public NativeArray<OdeSolveStatus> OdeSolveTerminationStatus;
    public NativeArray<PatchTransitionType> PatchEndTransitionNative;
    public NativeArray<int> EncounterBodyIndex;
    private int _numStages;
    private OdeSolutionInterpolator _odeSolutionInterpolator;

    public PatchedNBodyOrbit.SolverParameters SolverParams
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public NativeList<PatchedNBody.OdeSolutionComponent> OdeSolution
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeMarkerHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeMarkerHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromOrbitAtUT(IOrbit orbit, double UT, CelestialBodyComponent toBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromStateVectors(
      Position pos,
      Velocity vel,
      CelestialBodyComponent refBody,
      double UT)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromStateVectors(
      ICoordinateSystem coordinateSystem,
      Vector3d pos,
      IMotion relativeMotion,
      Vector3d vel,
      CelestialBodyComponent refBody,
      double UT)
    {
      throw null;
    }

    public CelestialBodyComponent referenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceBody(CelestialBodyComponent body) => throw null;

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialFrame OrbitFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d SpecificAngularMomentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OrbitMarkerHandler OrbitMarkerHandler
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Periapsis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Apoapsis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double PeriapsisArl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ApoapsisArl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtUT(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtUT(double universalTime, ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtT(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtT(double universalTime, ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeVelocityAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetVel(VesselComponent relativeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetOrbitalVelocityAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativePositionFromEccAnomaly(double eccentricAnomaly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetOrbitalStateVectorsAtUT(
      double UT,
      out Vector3d localPositionZup,
      out Vector3d relativeVelocityZup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SolveClosestApproach(
      IKeplerOrbit secondaryKeplerOrbit,
      ref double UT,
      double dT,
      double minUt,
      double maxUt,
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
    public double GetTimeToPeriapsis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromUT(double UT) => throw null;

    public double StartUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double EndUT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ActivePatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PatchTransitionType PatchStartTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PatchTransitionType PatchEndTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IPatchedOrbit NextPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IPatchedOrbit PreviousPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double UniversalTimeAtClosestApproach
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double UniversalTimeAtSoiEncounter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double ClosestApproachDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double TimeToPe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double TimeToAp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeOdeSolverData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateInterpolator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOdeSolveComplete(PatchTransitionType patchEndTransitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double SolvePatchEndTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private (double, double) SolveAllClosestApproach(
      double startUt,
      double endUt,
      List<CelestialBodyComponent> childBodies)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(IPatchedOrbit other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSolverParams(
      double startUt,
      double endUt,
      double3 initialPosition,
      double3 initialVelocity,
      CelestialBodyComponent parentBody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetSolverParams() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedNBodyOrbit() => throw null;

    public class SolverParameters
    {
      public double3 InitialPosition;
      public double3 InitialVelocity;
      public ManeuverPlanSolver.IntegratorMethodEnum IntegratorMethod;
      public List<CelestialBodyComponent> OdeChildBodies;
      public List<double> OdeChildSoIs;
      public ReferenceBodyConstants OdeParentReferenceBodyConstants;
      public double OdeParentSoi;
      public PatchedNBody.OdeSettings OdeSettings;
      public double ParentStandardGravParam;
      public double TimeEnd;
      public double TimeStart;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SolverParameters(
        double timeStart,
        double timeEnd,
        double odeParentSoi,
        double parentStandardGravParam,
        double3 initialPosition,
        double3 initialVelocity,
        List<double> odeChildSoIs,
        List<CelestialBodyComponent> odeChildBodies,
        ReferenceBodyConstants odeParentReferenceBodyConstants,
        PatchedNBody.OdeSettings odeSettings,
        ManeuverPlanSolver.IntegratorMethodEnum integratorMethod = ManeuverPlanSolver.IntegratorMethodEnum.RK45)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SolverParameters() => throw null;
    }
  }
}
