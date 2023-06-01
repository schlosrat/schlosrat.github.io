// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartFlowGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartFlowGraph : IPartFlowGraph
  {
    private Dictionary<PartComponent, PartFlowGraph.FlowLookup> fastDelivery;
    private Dictionary<PartComponent, PartFlowGraph.FlowLookup> fastRequest;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashSet<PartComponent> GetDeliveryFlowFromPart(PartComponent root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashSet<PartComponent> GetRequestFlowToPart(PartComponent root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildFlowGraph(
      IEnumerable<PartComponent> parts,
      List<VirtualConnection> virtualConnections)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartFlowGraph.FlowLookup BuildFastLookup(Vertex<PartComponent> root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildFastLookup(Vertex<PartComponent> root, PartFlowGraph.FlowLookup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartVertex(
      bool isRequest,
      PartComponent part,
      FlowGraph<PartComponent> flowGraph,
      List<VirtualConnection> virtualConnections)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartFlowGraph() => throw null;

    private class FlowLookup
    {
      public PartComponent root;
      public HashSet<PartComponent> parts;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FlowLookup(PartComponent root) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Add(PartComponent part) => throw null;
    }
  }
}
