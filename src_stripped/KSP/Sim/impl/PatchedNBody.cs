// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedNBody
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace KSP.Sim.impl
{
  public class PatchedNBody
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int MapIJ(int i, int j, int sizeJ) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static (int, int) MapIJInverse(int index, int sizeJ) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedNBody() => throw null;

    [BurstCompile]
    public struct CelestialBodyPositionJob : IJobParallelFor
    {
      [ReadOnly]
      public NativeArray<double> UniversalTimes;
      [ReadOnly]
      public NativeList<OrbitalElements> OrbitalElements;
      [ReadOnly]
      public NativeList<ReferenceBodyConstants> ReferenceBodyConstants;
      [WriteOnly]
      public NativeArray<CelestialBodyPosition> OutputPositions;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int index) => throw null;

      public readonly struct KeplerBody
      {
        public readonly double Period;
        public readonly double ObTAtEpoch;
        public readonly double Inclination;
        public readonly double Eccentricity;
        public readonly double SemiMajorAxis;
        public readonly double LongitudeOfAscendingNode;
        public readonly double ArgumentOfPeriapsis;
        public readonly double Epoch;
        public readonly double StandardGravitationParameter;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public KeplerBody(
          OrbitalElements orbitalElements,
          ReferenceBodyConstants referenceBodyConstants)
        {
          throw null;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double3 GetRelativePositionAtUt(double universalTime) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double3 GetRelativePositionAtobT(double orbitalTime) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double CalculateEccentricAnomaly(double meanAnomaly) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double CalculateTrueAnomaly(double eccentricAnomaly) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double CalculateDistance(double eccentricAnomaly) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double CalculateMeanAnomaly(double orbitalTime) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double3 CalculatePosOrbitFrame(double radialDistance, double trueAnomaly) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private double GetObtAtUt(double universalTime) => throw null;
      }
    }

    [BurstCompile]
    public struct OdeSolveJob : IJob
    {
      [ReadOnly]
      public const int NUM_EQNS = 6;
      [ReadOnly]
      private static readonly double SQRT_NUM_EQNS;
      [ReadOnly]
      private const double SAFETY = 0.9;
      [ReadOnly]
      private const double MIN_FACTOR = 0.2;
      [ReadOnly]
      private const int MAX_FACTOR = 10;
      [ReadOnly]
      public int ErrorEstimatorOrder;
      [ReadOnly]
      private const double minStep = 4.94065645841247E-323;
      [ReadOnly]
      public double TimeStart;
      [ReadOnly]
      public double TimeEnd;
      [ReadOnly]
      public double3 InitialPosition;
      [ReadOnly]
      public double3 InitialVelocity;
      [ReadOnly]
      public PatchedNBody.OdeSettings OdeSettings;
      [ReadOnly]
      public double ParentStandardGravParam;
      [ReadOnly]
      public double ParentSOI;
      [ReadOnly]
      public double ParentRadius;
      [ReadOnly]
      public NativeArray<double> ChildSOIs;
      [ReadOnly]
      public NativeArray<OrbitalElements> ChildOrbitalElements;
      [ReadOnly]
      public ReferenceBodyConstants ParentReferenceBodyConstants;
      [ReadOnly]
      public OdeSolverStageComponent OdeSolverStageComponent;
      [ReadOnly]
      public EvolveTypeEnum EvolveType;
      [ReadOnly]
      public ManeuverPlanSolver.IntegratorMethodEnum IntegratorMethodEnum;
      [ReadOnly]
      public NativeArray<double> AArray;
      [ReadOnly]
      public NativeArray<double> BArray;
      [ReadOnly]
      public NativeArray<double> CArray;
      [ReadOnly]
      public NativeArray<double> EArray;
      [ReadOnly]
      public NativeArray<double> PArray;
      [ReadOnly]
      public int2 PShape;
      public NativeArray<PatchedNBody.OdeState> KArray;
      [WriteOnly]
      public NativeList<PatchedNBody.OdeSolutionComponent> OdeSolution;
      [WriteOnly]
      public NativeList<PatchedNBody.OdeState> QArray;
      [WriteOnly]
      public NativeArray<PatchTransitionType> PatchEndTransition;
      [WriteOnly]
      public NativeArray<OdeSolveStatus> OdeSolveTerminationStatus;
      [WriteOnly]
      public NativeArray<int> EncounterBodyIndex;
      public NativeList<PatchedNBody.CelestialBodyPositionJob.KeplerBody> ChildKeplerBodies;
      private double _time;
      private double _h;
      private double _hPrevious;
      private double _errorExponent;
      private PatchedNBody.OdeState _y;
      private PatchedNBody.OdeState _y0;
      private PatchedNBody.OdeState _yOld;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void RKIntegrate() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsSOICrossed(double time, double3 yPosition) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsCollided(double3 yPosition) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SaveOdeSolution(
        PatchedNBody.OdeSolutionComponent odeSolutionComponent)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool RKStep() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private PatchedNBody.OdeState EstimateError(double h) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static PatchedNBody.OdeState ATransposeMultiplyB(
        NativeArray<PatchedNBody.OdeState> A,
        NativeArray<double> B)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void ATransposeMultiplyB_2D(
        NativeArray<PatchedNBody.OdeState> A,
        NativeArray<double> B,
        int2 BShape,
        ref NativeList<PatchedNBody.OdeState> C)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private double EstimateErrorNorm(double h, PatchedNBody.OdeState scale) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Initialize() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private double CalculateInitialStep(PatchedNBody.OdeState y0) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PatchedNBody.OdeState RKStep(
        double t,
        PatchedNBody.OdeState y,
        double h,
        PatchedNBody.OdeState f = default (PatchedNBody.OdeState))
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private PatchedNBody.OdeState OdeRhs(double t, PatchedNBody.OdeState y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static OdeSolveJob() => throw null;
    }

    public struct OdeState
    {
      public double3 Position;
      public double3 Velocity;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator *(PatchedNBody.OdeState v, double a) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator *(double a, PatchedNBody.OdeState v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator *(
        PatchedNBody.OdeState v1,
        PatchedNBody.OdeState v2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator /(
        PatchedNBody.OdeState v1,
        PatchedNBody.OdeState v2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator +(
        PatchedNBody.OdeState v1,
        PatchedNBody.OdeState v2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeState operator -(
        PatchedNBody.OdeState v1,
        PatchedNBody.OdeState v2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double Magnitude() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double NormRms() => throw null;
    }

    public readonly struct OdeSolutionComponent
    {
      public readonly double Time;
      public readonly double3 Position;
      public readonly double3 Velocity;
      private readonly double _stepSize;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OdeSolutionComponent(
        double time,
        double stepSize,
        double3 position,
        double3 velocity)
      {
        throw null;
      }
    }

    public struct OdeSettings
    {
      public int MaxSteps;
      public double AbsoluteTolerance;
      public double RelativeTolerance;
      public double MaxStepSize;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static PatchedNBody.OdeSettings Default() => throw null;
    }
  }
}
