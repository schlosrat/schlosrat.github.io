// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PatchedConics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
