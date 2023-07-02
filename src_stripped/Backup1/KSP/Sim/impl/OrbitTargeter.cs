// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OrbitTargeter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class OrbitTargeter
  {
    public static int MAX_NUM_CAPTURE_MARKERS;
    private bool areCaptureMarkersDirty;
    public bool HasValidity;
    private SimulationObjectModel _targetObject;
    private readonly OrbiterComponent _orbiter;
    private const float PE_AP_INTERSECT_THRESHOLD = 10000f;
    private const int MAX_ITERATIONS = 20;
    private int _iterations;
    private bool _encountersTarget;

    public AnDnMarker DescendingNodeOrbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AnDnMarker AscendingNodeOrbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AnDnMarker DescendingNodeTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AnDnMarker AscendingNodeTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IntersectMarker Intersect1Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IntersectMarker Intersect2Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IntersectMarker Intersect1Target
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IntersectMarker Intersect2Target
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CloseApproachMarker CloseApproachMarkerOrbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CloseApproachMarker CloseApproachMarkerTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<CaptureMarker> CaptureMarkers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitTargeter(OrbiterComponent orbiter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(SimulationObjectModel targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateNodesAndVectors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateIntersectNodes(
      PatchedConicsOrbit orbiterPatch,
      PatchedConicsOrbit targetPatch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetRelativeSpeed(
      IPatchedOrbit orbiterPatch,
      IPatchedOrbit targetPatch,
      double universalTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetSeparationDistance(
      IPatchedOrbit orbiterPatch,
      IPatchedOrbit targetPatch,
      double universalTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAllIntersectInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAscnDscnNodes(
      PatchedConicsOrbit orbiterPatch,
      PatchedConicsOrbit targetPatch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateClosestApproachNodes(
      PatchedConicsOrbit orbiterPatch,
      PatchedConicsOrbit targetPatch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCaptureMarker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchedConicsOrbit FindManeuverPatchForTarget(List<PatchedConicsOrbit> PatchedConicsList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchedConicsOrbit GetOrbiterPatchForTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsTargetCb(CelestialBodyComponent refBody, CelestialBodyComponent tgtCb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchedConicsOrbit FindPatch(
      List<PatchedConicsOrbit> patchList,
      int startIndex,
      int endIndex,
      CelestialBodyComponent refCb,
      CelestialBodyComponent tgtCb = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchedConicsOrbit GetTargetPatch(PatchedConicsOrbit orbiterPatch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllMarkersInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetApAtUt(PatchedNBodyOrbit orbit, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetEccentricityAtUt(PatchedNBodyOrbit orbit, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetSemiMajorAxisAtUt(PatchedNBodyOrbit orbit, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3d GetSpecificAngularMomentumAtUt(PatchedNBodyOrbit orbit, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetSpecificEnergyAtUt(PatchedNBodyOrbit orbit, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OrbitTargeter() => throw null;
  }
}
