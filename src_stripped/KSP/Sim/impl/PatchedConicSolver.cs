// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedConicSolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class PatchedConicSolver
  {
    private readonly PatchedConicSolver.SolverParameters _parameters;
    private readonly UniverseModel _universeModel;
    private int _patchLimit;
    private bool _hasMorePatchesAhead;
    private const int MIN_AMOUNT_OF_PATCHES = 1;
    private const int MAX_AMOUNT_OF_PATCHES = 5;
    private CelestialBodyComponent _targetBody;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedConicSolver(OrbiterComponent orbiter, UniverseModel universeModel) => throw null;

    /// <summary>
    /// The maximum limit on the number of patches. The default value = 10. This member can be get, but not set.
    /// </summary>
    public int MaxTotalPatches
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// The ObiterComponent object this class is associated with. This member can be get, but not set.
    /// </summary>
    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// A list of PatchedConicOrbits. May be given an index to obtain a particular trajectory. It’s basically a list of all the trajectories currently associated with this Orbiter object, and you can do things with it like any list. The length of the list will be no longer than MaxTotalPatches, with list members being chronologically organized from the patch that occurs first to the last patch. Unused members are null. This member can be get, but not set.
    /// </summary>
    public List<PatchedConicsOrbit> CurrentTrajectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    /// <summary>
    /// The number of patches ahead. This member can be get or set. It is set in the private method PatchedConicSolver.CalculatePatchList()
    /// </summary>
    public int PatchesAhead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    /// <summary>
    /// First tests to see if the Orbiter object is null. If it is, then it returns immediately. Otherwise, it will remove the handler for OnReferenceBodyChange which was added by the OnStart method.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    /// <summary>
    /// First tests to see if the Orbiter object is null. If it is, then it returns immediately. Otherwise, it will remove the handler for OnReferenceBodyChange which was added by the OnStart method.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    /// <summary>
    /// Adds a new handler for the Orbiter.OnReferenceBodyChange method so that OnReferenceBodyChange will be called when necessary. It then sets the private _patchLimit to be the max of PersistentProfileManager.ConicPatchLimit and 1, adds this.Orbiter.PatchedConicsOrbit to the CurrentTrajectory list, and similarly adds any remaining patches from 1 to MaxTotalPatches.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    /// <summary>
    /// You'd think calling this would cause the patch list to be updated, wouldn't you? Well, you're wrong. Deal with it.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculatePatchList() => throw null;

    /// <summary>
    /// Accepts a list of patches (i.e., CurrentTrajectory) and (optionally) a starting index for the list (defaults to 0). For each list member from the starting index to the end of the list, the member's ActivePatch property is set to false.
    /// NOTE: When called by ManeuverPlanSolver.UpdateManeuverTrajectory(), this method is called after calling ManeuverPlanSolver.SetPatchesInactive.
    /// </summary>
    /// <param name="patchedConicsOrbits"></param>
    /// <param name="startIndex"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPatchesInactive(
      List<PatchedConicsOrbit> patchedConicsOrbits,
      int startIndex = 0)
    {
      throw null;
    }

    /// <summary>
    /// Initialize the first patch in the patchlist.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFirstPatch() => throw null;

    /// <summary>
    /// Accepts a CelestialBodyComponent and uses that to set the private _targetBody. This sets the target to be used when generating the patch list.
    /// </summary>
    /// <param name="targetBody"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(CelestialBodyComponent targetBody) => throw null;

    /// <summary>
    /// Accepts a double (the universal time of interest) and returns the PatchedConicOrbit for the patch associated with that time.
    /// </summary>
    /// <param name="UT"></param>
    /// <returns name="patch"></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedConicsOrbit FindPatchContainingUT(double UT) => throw null;

    /// <summary>
    /// Decreases the current setting of the private _pathcLimit property by 1 to a value that is never less than 1.
    /// </summary>
    [ContextMenu("Decrease Patch Limit")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecreasePatchLimit() => throw null;

    /// <summary>
    /// Action triggered by reference body change?
    /// </summary>
    /// <param name="orbiter"></param>
    /// <param name="newReferenceBody"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReferenceBodyChange(
      OrbiterComponent orbiter,
      CelestialBodyComponent newReferenceBody)
    {
      throw null;
    }

    /// <summary>
    /// Increases the current setting of the private _pathcLimit property by 1 to a value that is never more than 5.
    /// </summary>
    [ContextMenu("Increase Patch Limit")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IncreasePatchLimit() => throw null;

    /// <summary>
    /// Clamps the current setting of the private _pathcLimit property to be between 1 and 5 inclusively.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPatchLimit() => throw null;

    /// <summary>
    /// Defines the parameters needed for the solver with default values assigned to maxGeometrySolverIterations (25), maxTimeSolverIterations (50), and outerReaches (1E+20).
    /// </summary>
    public class SolverParameters
    {
      public int maxGeometrySolverIterations;
      public int maxTimeSolverIterations;
      public int GeoSolverIterations;
      public int TimeSolverIterations1;
      public bool debug_disableEscapeCheck;
      public double outerReaches;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SolverParameters() => throw null;
    }
  }
}
