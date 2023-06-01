// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ManeuverPlanComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.Maneuver;
using KSP.Sim.State;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ManeuverPlanComponent : ObjectComponent
  {
    private const double TIME_CONSIDERED_CLOSE = 60.0;
    private const double OUT_OF_FUEL_EPSILON = 0.001;
    private ManeuverPlanState _state;
    private bool _warpingToNode;
    private ManeuverNodeData _lastActiveManeuverNodeReached;
    private ManeuverNodeData _lastActiveManeuverNodeClose;
    public Action<System.Guid> OnManeuverNodeAdded;
    public Action<List<ManeuverNodeData>> OnManeuverNodesRemoved;
    public Action<System.Guid> OnManeuverNodeBurnChanged;
    public Action<System.Guid> OnManeuverNodePositionChanged;
    private List<ManeuverNodeData> _currentNodes;
    private Queue<ManeuverNodeData> _nodesToRebuild;
    private Coroutine _currentRebuildOperation;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action OnManeuverNodeETAChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnManeuverNodeDataUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public ManeuverNodeData ActiveNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverPlanComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverPlanComponent(
      ManeuverPlanDefinition componentDefinition,
      IUniverseModel universeModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CommitToState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ManeuverNodeData> GetNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildNodeData(Action onRebuild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator RebuildNodes(Action onRebuild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidNode(ManeuverNodeData node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetNode(System.Guid nodeID, out ManeuverNodeData node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryRemoveNode(System.Guid nodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WarpToNode(ManeuverNodeData nodeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToAddNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEngineInAirbreathingMode(VesselDeltaVComponent vesselDeltaV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToAddNodeOnRebuild(
      ManeuverNodeData node,
      out Vector3d reducedBurnVectorChange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToChangeNode(
      ManeuverNodeData node,
      Vector3 change,
      out Vector3 newChange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddNode(ManeuverNodeData nodeData, bool rebuilding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(ManeuverNodeData nodeData, bool showMessageIfError = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNodes(List<ManeuverNodeData> nodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateChangeOnNode(ManeuverNodeData data, Vector3 change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateChangeOnNode(System.Guid nodeId, Vector3 change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTimeOnNode(ManeuverNodeData nodeData, double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTimeOnNode(System.Guid nodeId, double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshManeuverNodeState(int maneuverNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateNodeDetails(ManeuverNodeData node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetManeuverNodeBurnDirVector(System.Guid nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetManeuverNodeBurnVector(System.Guid nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SOIChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckIfActiveManeuverNodeWasReached(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckIfActiveManeuverNodeIsCloseOnInactiveVessel(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;
  }
}
