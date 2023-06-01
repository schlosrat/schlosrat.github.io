// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DirectedGraphPriorityWalker`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Priority_Queue;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class DirectedGraphPriorityWalker<TNodeRef, TEdgeData>
  {
    public readonly List<List<TNodeRef>> PriorityNodeGroups;
    public readonly Dictionary<TNodeRef, int> NodePriorityIndexCache;
    private readonly IComparer<int> _priorityComparer;
    private readonly SimplePriorityQueue<TNodeRef, int> _openListScratch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectedGraphPriorityWalker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool CanTraverseNode(TNodeRef node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool CanTraverseEdge(
      DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge edge)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool EdgeIncrementsPriority(
      DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge edge)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAllPriorities(
      DirectedGraph<TNodeRef, TEdgeData> graph,
      params TNodeRef[] startNodes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateNodePriorityIndex(in TNodeRef curNode, in int newPriorityIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEmptyTrailingLists(int targetListIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEmptyTrailingLists(int targetListIndex) => throw null;
  }
}
