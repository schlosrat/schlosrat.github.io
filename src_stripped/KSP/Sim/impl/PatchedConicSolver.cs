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

    public int MaxTotalPatches
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<PatchedConicsOrbit> CurrentTrajectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int PatchesAhead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculatePatchList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPatchesInactive(
      List<PatchedConicsOrbit> patchedConicsOrbits,
      int startIndex = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFirstPatch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(CelestialBodyComponent targetBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedConicsOrbit FindPatchContainingUT(double UT) => throw null;

    [ContextMenu("Decrease Patch Limit")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecreasePatchLimit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReferenceBodyChange(
      OrbiterComponent orbiter,
      CelestialBodyComponent newReferenceBody)
    {
      throw null;
    }

    [ContextMenu("Increase Patch Limit")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IncreasePatchLimit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPatchLimit() => throw null;

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
