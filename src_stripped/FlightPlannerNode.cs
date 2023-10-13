// Decompiled with JetBrains decompiler
// Type: FlightPlannerNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class FlightPlannerNode
{
  public string name;
  public List<FlightPlannerNode.NodeValues> destinations;
  [SerializeField]
  public Dictionary<FlightPlannerNode, int> connectedNodes;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsConnected(string node) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int DistanceTo(FlightPlannerNode destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int DistanceTo(string destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int DeltaVTo(FlightPlannerNode destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int DeltaVTo(string destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FlightPlannerNode() => throw null;

  [Serializable]
  public class NodeValues
  {
    public string destinationName;
    public int destinationDistance;
    public int journeyDeltaV;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NodeValues() => throw null;
  }
}
