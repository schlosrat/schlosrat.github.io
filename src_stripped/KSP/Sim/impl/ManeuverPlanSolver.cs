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
    /// <summary>
    /// Max value = 10
    /// </summary>
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

    /// <summary>
    /// List of maneuver trajecotries.
    /// </summary>
    public List<IPatchedOrbit> ManeuverTrajectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// List of patched conic orbits.
    /// </summary>
    public List<PatchedConicsOrbit> PatchedConicsList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// List of Patched N-Body Orbits.
    /// </summary>
    public List<PatchedNBodyOrbit> PatchedNBodyList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// The target celestial body.
    /// </summary>
    public CelestialBodyComponent TargetBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// A flag indicating if this maneuver plan has an active maneuver.
    /// </summary>
    public bool HasActiveManeuver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// Creates a ManeuverPlanSolver using the supplied UniverseModel for the supplied OrbiterComponent.
    /// </summary>
    /// <param name="universeModel"></param>
    /// <param name="orbiter"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverPlanSolver(UniverseModel universeModel, OrbiterComponent orbiter) => throw null;

    /// <summary>
    /// Good question!
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    /// <summary>
    /// Mono behavior called automatically.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    /// <summary>
    /// Mono behavior called automatically.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    /// <summary>
    /// Updates all the PatchedConicsOrbit list for this maneuver plan?
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateManeuverTrajectory() => throw null;

    /// <summary>
    /// Sets the maneuver trajectory to be "dirty" - meaning in need of update?
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetManeuverTrajectoryDirty() => throw null;

    /// <summary>
    /// Sets this maneuver plan to start at the given maneuver node index.
    /// </summary>
    /// <param name="index"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetManeuverStartIndex(int index) => throw null;

    /// <summary>
    /// Set the TargetBody pameter using the supplied CelestialBodyComponent.
    /// </summary>
    /// <param name="targetBody"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(CelestialBodyComponent targetBody) => throw null;

    /// <summary>
    /// Calculates the PatchedConicsList.
    /// </summary>
    /// <param name="maneuverNumber"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculatePatchConicList(int maneuverNumber) => throw null;

    /// <summary>
    /// Initialized the first patched conic orbit in the PatchedConicsList using the supplied maneuverNumber.
    /// </summary>
    /// <param name="maneuverNumber"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFirstPatchConic(int maneuverNumber) => throw null;

    /// <summary>
    /// Attempts to solve the maneuver plan using the odeManeuverNode.
    /// </summary>
    /// <param name="odeManeuverNode"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SolveManeuver(OdeManeuverNode odeManeuverNode) => throw null;

    /// <summary>
    /// Updates the position and velocity vectors for the SOI transition using the supplier patch and patchedNBodyOrbit.
    /// </summary>
    /// <param name="patch"></param>
    /// <param name="patchedNBodyOrbit"></param>
    /// <param name="subStageStartUt"></param>
    /// <param name="localPosition"></param>
    /// <param name="localVelocity"></param>
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

    /// <summary>
    /// Returns the patch end transition type for the supplied patchedNBodyOrbit using the supplied stageIndex, subStageIndex, numSubStages, and the OdeSolverStageComponent substage.
    /// </summary>
    /// <param name="patchedNBodyOrbit"></param>
    /// <param name="stageIndex"></param>
    /// <param name="subStageIndex"></param>
    /// <param name="numSubStages"></param>
    /// <param name="substage"></param>
    /// <returns patchTransitionType></returns>
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

    /// <summary>
    /// Returns true is all fuel has been consumed given the supplied OdeSolverStageComponent substage.
    /// </summary>
    /// <param name="substage"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsAllFuelConsumed(OdeSolverStageComponent substage) => throw null;

    /// <summary>
    /// Returns the patch from the supplied pathcLust containing the supplied ut.
    /// </summary>
    /// <param name="ut"></param>
    /// <param name="patchList"></param>
    /// <param name="patch"></param>
    /// <param name="patchIndex"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FindPatchContainingUt(
      double ut,
      List<IPatchedOrbit> patchList,
      out IPatchedOrbit patch,
      out int patchIndex)
    {
      throw null;
    }

    /// <summary>
    /// Returns the patch from the supplied pathcLust containing the supplied ut.
    /// </summary>
    /// <param name="ut"></param>
    /// <param name="patchList"></param>
    /// <param name="patch"></param>
    /// <param name="patchIndex"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FindPatchContainingUt(
      double ut,
      List<PatchedConicsOrbit> patchList,
      out IPatchedOrbit patch,
      out int patchIndex)
    {
      throw null;
    }

    /// <summary>
    /// Removes all ODE Maneuver Nodes for this ManeuverPlanSolver.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveAllOdeManeuverNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPatchesInactive(
      List<PatchedNBodyOrbit> patchedNBodyOrbits,
      int startIndex = 0)
    {
      throw null;
    }

    /// <summary>
    /// Sets all patches in the PatchedConicList to be inactive.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAllPatchesInactive() => throw null;

    /// <summary>
    /// Returns the burnDuration given the supplied deltaV and OdeSolverStageComponent deltaVStage.
    /// </summary>
    /// <param name="deltaV"></param>
    /// <param name="deltaVStage"></param>
    /// <returns burnDuration></returns>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetBurnDuration(double deltaV, OdeSolverStageComponent deltaVStage) => throw null;

    /// <summary>
    /// Handles adding the supplied nodeAdded to the supplied list of nodes.
    /// </summary>
    /// <param name="nodes"></param>
    /// <param name="nodeAdded"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodeAdded(List<ManeuverNodeData> nodes, ManeuverNodeData nodeAdded) => throw null;

    /// <summary>
    /// Handles removing the supplied list of nodes to remove (removedNodes) from the supplier list of currentNodes.
    /// </summary>
    /// <param name="currentNodes"></param>
    /// <param name="removedNodes"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodesRemoved(
      List<ManeuverNodeData> currentNodes,
      List<ManeuverNodeData> removedNodes)
    {
      throw null;
    }

    /// <summary>
    /// Sets the doSolve flag to the supplied value for this ManeuverPlanSolver.
    /// </summary>
    /// <param name="doSolve"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDoManeuverSolve(bool doSolve) => throw null;

    /// <summary>
    /// Applies the updated ManeuverNodeData (nodeChanged) to the list of nodes for this ManeuverPlanSolver.
    /// </summary>
    /// <param name="nodes"></param>
    /// <param name="nodeChanged"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodeBurnChanged(List<ManeuverNodeData> nodes, ManeuverNodeData nodeChanged) => throw null;

    /// <summary>
    /// Finds the patches affected by the specified nodeChanged for the list of nodes, outputting the nunConics, numNBody and the wasFound flag.
    /// </summary>
    /// <param name="nodes"></param>
    /// <param name="nodeChanged"></param>
    /// <param name="numConics"></param>
    /// <param name="numNBody"></param>
    /// <param name="wasFound"></param>
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

    /// <summary>
    /// Updates the list of maneuver nodes supplied using the nodeChanged structure supplied.
    /// </summary>
    /// <param name="nodes"></param>
    /// <param name="nodeChanged"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleNodePositionChanged(
      List<ManeuverNodeData> nodes,
      ManeuverNodeData nodeChanged)
    {
      throw null;
    }

    /// <summary>
    /// Updates the list of maneuver nodes supplied using the nodeChanged structure supplied (default null), numNBody (default 0), and numConics (default 0).
    /// </summary>
    /// <param name="maneuverNodes"></param>
    /// <param name="nodeChanged"></param>
    /// <param name="numNBody"></param>
    /// <param name="numConics"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleNodeChange(
      List<ManeuverNodeData> maneuverNodes,
      ManeuverNodeData nodeChanged = null,
      int numNBody = 0,
      int numConics = 0)
    {
      throw null;
    }

    /// <summary>
    /// Calculates the ODE Maneuver Nodes for the list of maneuver nodes supplied.
    /// </summary>
    /// <param name="maneuverNodes"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateOdeManeuverNodes(List<ManeuverNodeData> maneuverNodes) => throw null;

    /// <summary>
    /// Returns the velocity vector after the first maneuver
    /// </summary>
    /// <param name="UT"></param>
    /// <returns velocity></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetVelocityAfterFirstManeuver(out double UT) => throw null;

    /// <summary>
    /// Integrator method enumeration (RK23, RK45)
    /// </summary>
    public enum IntegratorMethodEnum
    {
      RK23,
      RK45,
    }
  }
}
