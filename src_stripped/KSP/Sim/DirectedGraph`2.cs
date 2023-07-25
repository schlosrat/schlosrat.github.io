// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DirectedGraph`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class DirectedGraph<TNodeRef, TEdgeData>
  {
    protected readonly Dictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.NodeEdgeState> _nodeEdgeStateMap;
    protected readonly HashSet<TNodeRef> _nodes;
    protected readonly HashSet<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> _nodeEdges;
    protected static readonly IReadOnlyDictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> EMPTY_NODE_EDGES;
    protected static readonly IReadOnlyCollection<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> EMPTY_DIRECTED_EDGES;

    public bool HasChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ReadOnlySet<TNodeRef> Nodes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ReadOnlySet<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> Edges
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectedGraph() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectedGraph(DirectedGraph<TNodeRef, TEdgeData> other) => throw null;

    public DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge this[TNodeRef from, TNodeRef to]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> this[
      TNodeRef from]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasNode(TNodeRef node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasEdge(TNodeRef from, TNodeRef to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge GetEdge(TNodeRef from, TNodeRef to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyCollection<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> GetEdges(
      TNodeRef nodeFrom)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyDictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> GetNodeEdges(
      TNodeRef nodeFrom)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetEdgeData(TNodeRef from, TNodeRef to, out TEdgeData edgeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyCollection<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> GetInboundEdges(
      TNodeRef nodeTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyDictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> GetInboundNodeEdges(
      TNodeRef nodeTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNode(TNodeRef nodeReference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(TNodeRef nodeReference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEdge(TNodeRef fromNodeReference, TNodeRef toNodeReference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEdge(
      TNodeRef fromNodeReference,
      TNodeRef toNodeReference,
      TEdgeData edgeData = null,
      bool skipValidation = false,
      bool addInboundEdges = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearGraph() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool ValidateAllEdges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool ValidateEdge(
      TNodeRef fromNodeReference,
      TNodeRef toNodeReference,
      TEdgeData edgeData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<KeyValuePair<TNodeRef, IReadOnlyDictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge>>> GetNodeEdgeEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DirectedGraph<TNodeRef, TEdgeData>.NodeEdgeState GetOrAllocateNodeState(
      TNodeRef nodeReference)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Dictionary<TNodeRef, TValue> NewNodeDictionary<TValue>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static HashSet<TNodeRef> NewNodeHashSet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DirectedGraph() => throw null;

    public class DirectedEdge
    {
      public TNodeRef FromNode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public TNodeRef ToNode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public TEdgeData EdgeData
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DirectedEdge(TNodeRef from, TNodeRef to, TEdgeData data) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetEdgeData(TEdgeData data) => throw null;
    }

    protected class NodeEdgeState
    {
      public Dictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> outboundNodeEdges;
      public Dictionary<TNodeRef, DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> cachedInboundNodeEdges;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NodeEdgeState() => throw null;
    }
  }
}
