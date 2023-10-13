// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DirectedGraphExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public static class DirectedGraphExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void SetBothEdges<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      TNodeRef sourceNodeReference,
      TNodeRef targetNodeReference,
      TEdgeData dataForBothEdges)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void RemoveBothEdges<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      TNodeRef sourceNodeReference,
      TNodeRef targetNodeReference)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void SetBothEdges<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      TNodeRef sourceNodeReference,
      TNodeRef targetNodeReference,
      TEdgeData sourceToTargetEdgeData,
      TEdgeData targetToSourceEdgeData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void ForEach<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      Action<TNodeRef> action)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void ForEach<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      Action<TNodeRef> action,
      Func<TNodeRef, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static int FindAll<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      Func<TNodeRef, bool> predicate,
      IList<TNodeRef> output)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Find<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      Func<TNodeRef, bool> predicate,
      out TNodeRef node)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IReadOnlyList<DirectedGraph<TNodeRef, TEdgeData>.DirectedEdge> GetShortestEdgePath<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph,
      TNodeRef fromNode,
      TNodeRef toNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string DebugToString<TNodeRef, TEdgeData>(
      this DirectedGraph<TNodeRef, TEdgeData> graph)
    {
      throw null;
    }
  }
}
