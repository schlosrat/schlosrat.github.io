// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ManeuverPlanComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    /// <summary>
    /// Default = 60.0
    /// </summary>
    private const double TIME_CONSIDERED_CLOSE = 60.0;
    /// <summary>
    /// Default = 0.001
    /// </summary>
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

    /// <summary>
    /// Returns the current active node if there is one, otherwise null.
    /// </summary>
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

    /// <summary>
    /// Subscribes to SOIEnteredMessage and SOIExitedMessage.
    /// </summary>
    /// <param name="universalTime"></param>
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

    /// <summary>
    /// calls this.CommitToState() and returns the state.
    /// </summary>
    /// <returns object></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CommitToState() => throw null;

    /// <summary>
    /// Returns the current list of nodes
    /// </summary>
    /// <returns List{ManeuverNodeData}></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ManeuverNodeData> GetNodes() => throw null;

    /// <summary>
    /// If there is a _currentRebuildOperation (RebuildNodes is already running with a previous task), then stops the Coroutine, sets the list of current nodes,
    /// and kicks off a new Coroutine call to RebuildNodes(onRebuild).
    /// </summary>
    /// <param name="onRebuild"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildNodeData(Action onRebuild) => throw null;

    /// <summary>
    /// Called by RebuildNodeData to rebuild all the current nodes for this vessel.
    /// </summary>
    /// <param name="onRebuild"></param>
    /// <returns IEnumerator></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator RebuildNodes(Action onRebuild) => throw null;

    /// <summary>
    /// Returns true if the specified node is valid, false otherwise.
    /// </summary>
    /// <param name="node"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidNode(ManeuverNodeData node) => throw null;

    /// <summary>
    /// Attempts to get the specified nodeID, returning true if successful and false otherwise. If successful, the requested node structure is returned in the node output.
    /// </summary>
    /// <param name="nodeID"></param>
    /// <param name="node"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetNode(System.Guid nodeID, out ManeuverNodeData node) => throw null;

    /// <summary>
    /// Attempts to remove the specified node, returning true if successful and false otherwise.
    /// </summary>
    /// <param name="nodeID"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryRemoveNode(System.Guid nodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WarpToNode(ManeuverNodeData nodeData) => throw null;

    /// <summary>
    /// Checks to see if there is any available DeltaV (based on the active engine and available fuel).
    /// Existing nodes that are already budgeted for are accounted for in the caluclation, however DeltaV available from RCS is not.
    /// </summary>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToAddNode() => throw null;

    /// <summary>
    /// Returns true if the active engine is in air breathing mode, and false otherwise.
    /// </summary>
    /// <param name="vesselDeltaV"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEngineInAirbreathingMode(VesselDeltaVComponent vesselDeltaV) => throw null;

    /// <summary>
    /// Checks to see if there's enough DeltaV for the proposed change to the node on a node rebuild. Called by this.AddNode.
    /// </summary>
    /// <param name="node"></param>
    /// <param name="reducedBurnVectorChange"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToAddNodeOnRebuild(
      ManeuverNodeData node,
      out Vector3d reducedBurnVectorChange)
    {
      throw null;
    }

    /// <summary>
    /// Checks to see if there's enough DeltaV for the proposed change to the node. Called by this.UpdateChangeOnNode
    /// </summary>
    /// <param name="node"></param>
    /// <param name="change"></param>
    /// <param name="newChange"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EnoughDeltaVToChangeNode(
      ManeuverNodeData node,
      Vector3 change,
      out Vector3 newChange)
    {
      throw null;
    }

    /// <summary>
    /// This is probably not the function you're looking for. This function is called by ManeuverProvider.AddNodeToVessel, which is the main
    /// entry point to use if you wish to add a node to a vessel. ManeuverPlanner.AddNodeToVessel calls this method among other things. Calling
    /// this method will add a node, but it will not do the other necessary things that AddNodeToVessel does in addition.
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="rebuilding"></param>
    /// <returns bool></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddNode(ManeuverNodeData nodeData, bool rebuilding) => throw null;

    /// <summary>
    /// Removes the specified node if found.
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="showMessageIfError"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(ManeuverNodeData nodeData, bool showMessageIfError = true) => throw null;

    /// <summary>
    /// Removes all the nodes found in the specified nodes list.
    /// </summary>
    /// <param name="nodes"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNodes(List<ManeuverNodeData> nodes) => throw null;

    /// <summary>
    /// Processes an update on the specified node structure applying the specified change to the burn vector provided there is sufficient DeltaV available.
    /// If there is some DeltaV, but not enough for the whole change then a partial change will be applied. NOTE: This method just calls the next one by
    /// passing it data.NodeID and the requested change.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="change"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateChangeOnNode(ManeuverNodeData data, Vector3 change) => throw null;

    /// <summary>
    /// Processes an update on the specified nodeId applying the specified change to the burn vector provided there is sufficient DeltaV available.
    /// If there is some DeltaV, but not enough for the whole change then a partial change will be applied.
    /// </summary>
    /// <param name="nodeId"></param>
    /// <param name="change"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateChangeOnNode(System.Guid nodeId, Vector3 change) => throw null;

    /// <summary>
    /// Processes an update on the specified nodeData setting a new nodeData.Time value to adjust the timing of the node. NOTE: This method just calls the
    /// next one bypassing it nodeData.NodeID and the updated time.
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="time"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTimeOnNode(ManeuverNodeData nodeData, double time) => throw null;

    /// <summary>
    /// Processes an update on the specified nodeId setting a new nodeData.Time value to adjust the timing of the node.
    /// </summary>
    /// <param name="nodeId"></param>
    /// <param name="time"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTimeOnNode(System.Guid nodeId, double time) => throw null;

    /// <summary>
    /// Refresh the state of the specified (indexed) maneuver
    /// </summary>
    /// <param name="maneuverNumber"></param>
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

    /// <summary>
    /// Action triggered when a maneuver node is removed.
    /// </summary>
    /// <param name="simulationObject"></param>
    /// <param name="universalTime"></param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;
  }
}
