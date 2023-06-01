// Decompiled with JetBrains decompiler
// Type: KSP.Game.CommNetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class CommNetManager : IUpdate
  {
    private GameInstance _game;
    private bool _isInitialized;
    private int _controlSourceIndex;
    private List<ConnectionGraphNode> _allNodes;
    private ConnectionGraph _connectionGraph;
    private bool _isDirty;
    private bool _isGraphBuilding;
    private const float REBUILD_GRAPH_TIMER_SECONDS = 3f;
    private float _timerRemaining;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterNode(ConnectionGraphNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterNode(ConnectionGraphNode node) => throw null;

    public bool IsGeneratingGraph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionGraphNode GetSourceNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSourceNode(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSourceNode(ConnectionGraphNode newSourceNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionNodeStatus GetConnectionStatus(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommNetManager() => throw null;
  }
}
