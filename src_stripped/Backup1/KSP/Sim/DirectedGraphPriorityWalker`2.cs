// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DirectedGraphPriorityWalker`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
