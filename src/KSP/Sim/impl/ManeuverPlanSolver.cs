// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ManeuverPlanSolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Maneuver;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ManeuverPlanSolver : IDisposable
  {
    public const int MAX_PATCHEDNBODY_SOLVES = 10;
    private bool _isManeuverTrajectoryDirty;
    private int _maneuverStartIndex;
    private bool _doManeuverSolve;
    private CelestialBodyComponent _targetBody;
    private int _maxPatches;
    private int _numNBody;
    private int _numConics;
    private PatchedConicsOrbit _postManeueverOrbit;
    private readonly OrbiterComponent _orbiter;
    private List<List<OdeSolverStageComponent>> _deltaVStageStack;
    private readonly List<OdeManeuverNode> _odeManeuverNodes;
    private readonly PatchedConicSolver.SolverParameters _parameters;
    private int _patchConicsLimit;
    private bool _hasMorePatchesAhead;
    private readonly UniverseModel _universeModel;
    private int _lastStageIndexWithFuel;
    private PatchedConicsOrbit _workPatchedConicsOrbit;
    private PatchedNBodyOrbit _workPatchedNBodyOrbit;

    public List<IPatchedOrbit> ManeuverTrajectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<PatchedConicsOrbit> PatchedConicsList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<PatchedNBodyOrbit> PatchedNBodyList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent TargetBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasActiveManeuver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverPlanSolver(UniverseModel universeModel, OrbiterComponent orbiter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateManeuverTrajectory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetManeuverTrajectoryDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetManeuverStartIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(CelestialBodyComponent targetBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculatePatchConicList(int maneuverNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFirstPatchConic(int maneuverNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SolveManeuver(OdeManeuverNode odeManeuverNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdatePositionVelocityForSoiCross(
      IPatchedOrbit patch,
      PatchedNBodyOrbit patchedNBodyOrbit,
      double subStageStartUt,
      ref Vector3d localPosition,
      ref Vector3d localVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchTransitionType GetPatchEndTransitionType(
      PatchedNBodyOrbit patchedNBodyOrbit,
      int stageIndex,
      int subStageIndex,
      int numSubStages,
      OdeSolverStageComponent substage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsAllFuelConsumed(OdeSolverStageComponent substage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FindPatchContainingUt(
      double ut,
      List<IPatchedOrbit> patchList,
      out IPatchedOrbit patch,
      out int patchIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FindPatchContainingUt(
      double ut,
      List<PatchedConicsOrbit> patchList,
      out IPatchedOrbit patch,
      out int patchIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveAllOdeManeuverNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPatchesInactive(
      List<PatchedNBodyOrbit> patchedNBodyOrbits,
      int startIndex = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAllPatchesInactive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetBurnDuration(double deltaV, OdeSolverStageComponent deltaVStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodeAdded(List<ManeuverNodeData> nodes, ManeuverNodeData nodeAdded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodesRemoved(
      List<ManeuverNodeData> currentNodes,
      List<ManeuverNodeData> removedNodes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDoManeuverSolve(bool doSolve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodeBurnChanged(List<ManeuverNodeData> nodes, ManeuverNodeData nodeChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindPatchesForNodeChange(
      List<ManeuverNodeData> nodes,
      ManeuverNodeData nodeChanged,
      out int numConics,
      out int numNBody,
      out bool wasFound)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodePositionChanged(
      List<ManeuverNodeData> nodes,
      ManeuverNodeData nodeChanged)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleNodeChange(
      List<ManeuverNodeData> maneuverNodes,
      ManeuverNodeData nodeChanged = null,
      int numNBody = 0,
      int numConics = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateOdeManeuverNodes(List<ManeuverNodeData> maneuverNodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetVelocityAfterFirstManeuver(out double UT) => throw null;

    public enum IntegratorMethodEnum
    {
      RK23,
      RK45,
    }
  }
}
