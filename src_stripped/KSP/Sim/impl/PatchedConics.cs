// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedConics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PatchedConics
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetClosestApproach(
      PatchedConicsOrbit primaryOrbit,
      PatchedConicsOrbit secondaryOrbit,
      double startEpoch,
      double dT,
      PatchedConicSolver.SolverParameters pars)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool EncountersBody(
      PatchedConicsOrbit currentPatch,
      PatchedConicsOrbit secondaryOrbit,
      PatchedConicsOrbit nextPatch,
      OrbiterComponent secondaryOrbiterComponent,
      double startEpoch,
      PatchedConicSolver.SolverParameters pars)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WillCollideWithParent(PatchedConicsOrbit currentPatch, double startEpoch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckEncounter(
      PatchedConicsOrbit currentPatch,
      PatchedConicsOrbit nextPatch,
      double startEpoch,
      OrbiterComponent sec,
      CelestialBodyComponent targetBody,
      PatchedConicSolver.SolverParameters pars)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double AngleWrap(double a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsUniversalTimeWithinPatchBounds(
      double universalTime,
      PatchedConicsOrbit patch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PatchedConics() => throw null;
  }
}
