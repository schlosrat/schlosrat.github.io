// Decompiled with JetBrains decompiler
// Type: KSP.Game.CelestialBodyProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Rendering;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class CelestialBodyProvider
  {
    private readonly Dictionary<string, CelestialBodyCore> _celestialBodyLookup;
    private readonly Dictionary<string, CelestialBodyLightingData> _celestialBodyLightingLookup;
    private readonly Dictionary<string, CelestialBodyLensFlare> _celestialBodyLensFlareLookup;
    private readonly Dictionary<string, PostProcessData> _celestialBodyPostProcessLookup;
    private readonly Dictionary<string, CelestialBodyRingGroup> _celestialBodyRingLookup;
    private InterstellarNeighborhood _interstellarNeighborhood;
    private SubscriptionHandle _celestialBodyAddedHandle;
    private SubscriptionHandle _celestialBodyRemovedHandle;
    private int _latestSortedBodiesFrame;
    private Position _latestSortedBodiesViewpoint;
    private Dictionary<string, double> _latestSortedBodies;
    public bool flowActionResolved;
    private const double visibilityCutoff = 1E-06;

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InterstellarNeighborhood InterstellarNeighborhood
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializePrevis(PrevisGameInstance previs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterBodyFromData(CelestialBodyCore jsonData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyCore Get(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLightingData GetLightingData(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLensFlare GetLensFlareData(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessData GetPostProcessData(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingGroup GetRingGroupData(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCelestialBodyBehavior(string name, out CelestialBodyBehavior behavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCelestialBodyComponent(string name, out CelestialBodyComponent component) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCelestialBodyLocalSpaceObject(string name, out GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCelestialBodyScaledSpaceObject(string name, out GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBehaviorValid(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, CelestialBodyCore> GetAllBodiesData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, CelestialBodyLightingData> GetAllLightingData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, CelestialBodyLensFlare> GetAllLensFlareData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformModel GetTransformModel(string cbNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, PostProcessData> GetAllPostProcessData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetPosition(string cbNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRadius(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetAtmosphereStatus(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetStarStatus(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPeriapsis(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetApoapsis(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetReferenceBody(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyBehavior GetObservedBody(Position pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetObservedBodyName(Position pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetObservedStar(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetOrbitingBodies(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetNeighboringBodies(string name, bool includeStars = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, double> GetNeighboringBodiesByVisibility(
      Position viewerPos,
      List<string> bodies)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetVisibility(string targetName, Position viewerPos, List<string> bodies) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateMaxCoverage(
      CelestialBodyProvider.CelestialBodyVisibility target,
      CelestialBodyProvider.CelestialBodyVisibility occluder,
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodiesLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodyLightingDataAdded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodyLightingDataRemoved(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyProvider() => throw null;

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
