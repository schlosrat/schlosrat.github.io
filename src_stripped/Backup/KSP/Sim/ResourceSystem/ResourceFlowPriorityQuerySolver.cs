// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowPriorityQuerySolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceFlowPriorityQuerySolver
  {
    private DirectedGraph<IFlowNode, IFlowEdge> _flowGraph;
    private IFlowNode _rootNode;
    private bool _isQueryCacheDirty;
    private HashSet<IFlowNode> _evaluatedInboundNodes;
    private HashSet<IFlowNode> _evaluatedOutboundNodes;
    private readonly PriorityGroupCollection<IFlowNode> _rootMaxDistancePriority;
    private readonly PriorityGroupCollection<IFlowNode> _rootMinDistancePriority;
    private readonly Dictionary<IFlowNode, ResourceFlowPriorityQuerySolver.FlowModeNodeQueryCache> _nodePriorityCaches;
    private readonly SimplePriorityQueue<IFlowNode, int> _floodFillFrontier;
    private readonly Dictionary<IFlowNode, int> _floodFillValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkQueryCacheDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlowGraph(DirectedGraph<IFlowNode, IFlowEdge> flowGraph, IFlowNode rootNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IReadOnlyPriorityGroupCollection<IFlowNode> QueryMaxDistFromRoot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IReadOnlyPriorityGroupCollection<IFlowNode> QueryMinDistFromRoot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IReadOnlyPriorityGroupCollection<IFlowNode> QueryFlowModePriorities(
      IFlowNode targetNode,
      FlowDirection flowDirection,
      ResourceFlowMode flowMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalUpdateQueryCachesIfDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalCacheRootQueries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalCacheFlowModeQueries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateNodeFlowModeQueryCache(
      IFlowNode thisFlowNode,
      PriorityGroupCollection<IFlowNode> allVesselInbound,
      PriorityGroupCollection<IFlowNode> allVesselOutbound,
      bool doInbound)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    protected static PriorityGroupCollection<IFlowNode> NewPriorityGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceFlowPriorityQuerySolver.FlowModeNodeQueryCache AddOrGetNodePriorityCache(
      IFlowNode flowNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FlowNoCompoundEdges(IFlowEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FlowEdges(IFlowEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FlowEdgesRequireCrossfeed(IFlowEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FlowNoCompoundEdgesRequireCrossfeed(IFlowEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool EdgeIncrement_Boundary(IFlowEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool EdgeIncrement_Fuel_line_Boundary(IFlowNode curNode, IFlowNode nextNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FloodFillValues(
      DirectedGraph<IFlowNode, IFlowEdge> flowGraph,
      SimplePriorityQueue<IFlowNode, int> frontier,
      Dictionary<IFlowNode, int> visited,
      ResourceFlowPriorityQuerySolver.FloodFillType fillType = ResourceFlowPriorityQuerySolver.FloodFillType.INBOUND,
      Func<IFlowEdge, bool> inboundEdgeIsWalkable = null,
      Func<IFlowEdge, bool> outboundEdgeIsWalkable = null,
      Func<IFlowNode, bool> nodeIsWalkable = null,
      Func<IFlowEdge, bool> edgeIncrementsFillValue = null,
      Func<IFlowNode, IFlowNode, bool> nodeIncrementsFillValue = null)
    {
      throw null;
    }

    [Conditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ConcatenateEditorDebugString(
      ref StringBuilder stringBuilder,
      string additionalString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void _WalkNextNode(
      ref StringBuilder editorDebugStringBuilder,
      ref SimplePriorityQueue<IFlowNode, int> frontier,
      ref Dictionary<IFlowNode, int> visited,
      IFlowNode curNode,
      int curFillValue,
      IFlowNode nextNode,
      IFlowEdge nextEdgeData,
      ResourceFlowPriorityQuerySolver.FloodFillType fillType,
      Func<IFlowEdge, bool> edgeIsWalkable,
      Func<IFlowNode, bool> nodeIsWalkable,
      Func<IFlowEdge, bool> edgeIncrementsFillValue,
      Func<IFlowNode, IFlowNode, bool> nodeIncrementsFillValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowPriorityQuerySolver() => throw null;

    private class FlowModeNodeQueryCache
    {
      private readonly Dictionary<ResourceFlowMode, IReadOnlyPriorityGroupCollection<IFlowNode>> _inboundQueryCache;
      private readonly Dictionary<ResourceFlowMode, IReadOnlyPriorityGroupCollection<IFlowNode>> _outboundQueryCache;
      public static readonly IReadOnlyPriorityGroupCollection<IFlowNode> EMPTY_COLLECTION;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IReadOnlyPriorityGroupCollection<IFlowNode> GetInboundQuery(ResourceFlowMode flowMode) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IReadOnlyPriorityGroupCollection<IFlowNode> GetOutboundQuery(ResourceFlowMode flowMode) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void StoreInboundFlowModePriorities(
        ResourceFlowMode flowMode,
        IReadOnlyPriorityGroupCollection<IFlowNode> inboundQueryResult)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void StoreOutboundFlowModePriorities(
        ResourceFlowMode flowMode,
        IReadOnlyPriorityGroupCollection<IFlowNode> outboundQueryResult)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FlowModeNodeQueryCache() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static FlowModeNodeQueryCache() => throw null;
    }

    private enum FloodFillType
    {
      INBOUND,
      OUTBOUND,
      BOTH,
    }
  }
}
