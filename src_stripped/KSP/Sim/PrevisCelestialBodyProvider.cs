// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PrevisCelestialBodyProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  public class PrevisCelestialBodyProvider
  {
    [SerializeField]
    private PrevisGameInstance PrevisGame;
    private Dictionary<string, ITransformModel> previsSimObj;
    private const double visibilityCutoff = 1E-06;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrevisCelestialBodyProvider(PrevisGameInstance previsGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnScaledSpaceViewInstantiated(GameObject instance, string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSimObjectInstantiated(ITransformModel transformModel, string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, ITransformModel> GetPrevisSimObjs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyCore Get(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformModel GetTransformModel(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetPosition(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRadius(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetObservedBodyName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetObservedStar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetReferenceBody(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetNeighboringBodies(bool includeStars = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, double> GetNeighboringBodiesByVisibility(
      Position viewerPos,
      bool includeObserved = true,
      bool includeStar = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateMaxCoverage(
      PrevisCelestialBodyProvider.CelestialBodyVisibility target,
      PrevisCelestialBodyProvider.CelestialBodyVisibility occluder,
      ref double maxCoverage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<string> SortBodiesByDistance(List<string> bodyList, Position viewerPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetArcRadius(Position viewerPos, Position bodyPos, double bodyRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetProjectedCapRadius(
      Position viewerPos,
      Position spherePos,
      double sphereRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetCircleCoveredArea(
      double radius_target,
      double radius_occluder,
      double distance)
    {
      throw null;
    }

    private struct CelestialBodyVisibility
    {
      public string name;
      public Vector viewerToBodyDir;
      public double arcRadius;
      public double unblockedVisibility;
      public double blockedVisibility;
    }
  }
}
