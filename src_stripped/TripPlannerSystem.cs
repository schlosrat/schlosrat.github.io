// Decompiled with JetBrains decompiler
// Type: TripPlannerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class TripPlannerSystem
{
  private const int TIME_SLICE_AMOUNT = 3600;
  private const int MAX_ITERATIONS = 10000;
  private TripPlannerData _tripPlannerData;
  private GameInstance _game;

  public TripNode CurrentOriginNode
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TripPlannerSystem(TripData deserializedTripData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TripNode GetNode(TripNodeType nodeType, string cbName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public List<TripEdge> FindPath(TripNode current, TripNode target, bool isTwoWay) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool Walk(
    TripNode current,
    TripNode target,
    List<TripNode> visited,
    List<TripNode> path)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public double GetTotalTripDV(List<TripEdge> edges) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetTransferWindow(
    TripNode startNode,
    TripNode endNode,
    List<TripEdge> path,
    double UT,
    out double windowStartTime,
    out double windowEndTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TryGetRelevantTripAngle(List<TripEdge> path, out TripAngle relevantAngle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetTransferWindowTimes(
    TripAngle tripAngle,
    double UT,
    out double windowStartTime,
    out double windowEndTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private double GetTimeAtPhaseAngle(
    CelestialBodyComponent startBody,
    CelestialBodyComponent endBody,
    double targetPhaseAngle,
    double startTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static double GetPhaseAngleAtUT(
    CelestialBodyComponent sourceBody,
    CelestialBodyComponent targetBody,
    CelestialBodyComponent parentBody,
    double UT)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool HasDataOnCelestialBody(
    string celestialBodyName,
    out CelestialBodyComponent celestialBodycomponent)
  {
    throw null;
  }
}
