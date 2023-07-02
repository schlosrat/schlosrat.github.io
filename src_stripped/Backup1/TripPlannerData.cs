// Decompiled with JetBrains decompiler
// Type: TripPlannerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class TripPlannerData
{
  public List<TripNode> TripNodes;
  public List<TripEdge> TripEdges;
  public List<TripAngle> TripAngles;
  private Dictionary<string, TripNode> _nodeReferences;
  private Dictionary<string, CelestialBodyComponent> _celestialBodyReferences;
  private Dictionary<string, CelestialBodyComponent> _nodeCelestialBodies;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TripPlannerData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void BuildFromTripData(TripData rawTripData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialBodyComponent GetCelestialBodyReference(string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool HasCelestialBodyInData(string name, out CelestialBodyComponent celestialBodyComponent) => throw null;
}
