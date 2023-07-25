// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace KSP.Sim
{
  public class ConnectionGraph
  {
    private List<ConnectionGraphNode> _allNodes;
    private int _allNodeCount;
    private bool _isEnabled;
    private bool _isRunning;
    private bool _hasBuiltGraph;
    private JobHandle _jobHandle;
    private NativeArray<ConnectionGraph.ConnectionGraphJobNode> _nodes;
    private NativeArray<int> _previousIndices;
    private int _prevSourceIndex;
    private List<uint> _path;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ConnectionGraph() => throw null;

    public bool IsRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildConnectionGraph(List<ConnectionGraphNode> nodes, int sourceNodeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionNodeStatus GetConnectionStatus(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionNodeStatus GetConnectionStatus(ConnectionGraphNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPathFromSourceNode(
      ConnectionGraphNode end,
      ref List<ConnectionGraphNode> resultPath)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResizeCollections(int numNodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeNativeCollections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetPath(
      uint startNodeIndex,
      uint endNodeIndex,
      NativeArray<int> prev,
      ref List<uint> path)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ConnectionGraphNodeFlags GetFlagsFrom(ConnectionGraphNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionGraph() => throw null;

    public struct ConnectionGraphJobNode
    {
      public double3 Position;
      public double MaxRange;
      public ConnectionGraphNodeFlags Flags;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConnectionGraphJobNode(
        double3 position,
        double maxRange,
        ConnectionGraphNodeFlags flags)
      {
        throw null;
      }
    }
  }
}
